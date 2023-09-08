using ProjectManager.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace ProjectManager
{
    public class GenericSqlHelper<T>
    {
        public bool Create(T t)
        {
            try
            {
                string tableName = typeof(T).Name;
                PropertyInfo[] properties = typeof(T).GetProperties();

                string strCol = string.Join(",", properties.Skip(1).Select(r => ConvertPropName(r.Name)));
                string strParam = string.Join(",", properties.Skip(1).Select(r => "@"+ConvertPropName(r.Name)));
                string sql = "INSERT INTO [" + tableName + "] (" + strCol + ") VALUES(" + strParam + ")";

                using (SqlConnection con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sql, con);
                    for(int i = 0; i < properties.Length-1; i++)
                    {
                        cmd.Parameters.AddWithValue("@" + ConvertPropName(properties[i+1].Name), properties[i+1].GetValue(t));
                    }

                    cmd.ExecuteNonQuery();
                    con.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return false;
        }
        public DataTable ReadTable(User user)
        {
            string tableName = typeof(T).Name.ToUpper();
            DataTable table = new DataTable(tableName);
            try
            {
                List<int> authIdList = GetAuthList(user.UserId);
                string idData = string.Join(",", authIdList.Select((id, index) => "@id" + (index + 1)));
                using (SqlConnection con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;"))
                {
                    con.Open();
                    string sql = "SELECT * FROM [" + tableName + "] WHERE " + tableName + "_GROUP_ID IN (" + idData + ") OR " + tableName + "_CREATOR_ID=@" + tableName + "_CREATOR_ID";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        for (int i = 0; i < authIdList.Count; i++)
                        {
                            cmd.Parameters.AddWithValue("@id" + (i + 1), authIdList[i]);
                        }
                        cmd.Parameters.AddWithValue("@" + tableName + "_CREATOR_ID", user.UserId);

                        using (SqlDataAdapter adptr = new SqlDataAdapter(cmd))
                        {
                            adptr.Fill(table);
                        }
                    }
                }

                return table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return table;
        }
        public T ReadById(T t)
        {
            string tableName = typeof(T).Name.ToUpper();
            PropertyInfo[] properties = typeof(T).GetProperties();
            string sql = "SELECT * FROM [" + tableName + "] WHERE " + ConvertPropName(properties[0].Name) + "=@" + ConvertPropName(properties[0].Name);
            if ((int)properties[0].GetValue(t) == 0) // üye id si yoksa mail ve secret word check yapılır
            {
                sql = "SELECT * FROM [" + tableName + "] WHERE USER_MAIL=@USER_MAIL AND USER_SECRET_WORD=@USER_SECRET_WORD";
            }
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sql, con);
                    if ((int)properties[0].GetValue(t) != 0) 
                    {
                        cmd.Parameters.AddWithValue("@" + ConvertPropName(properties[0].Name), properties[0].GetValue(t));
                    }
                    else // üye id si yoksa mail ve secret word check yapılır
                    {
                        cmd.Parameters.AddWithValue("@USER_MAIL", properties[3].GetValue(t));
                        cmd.Parameters.AddWithValue("@USER_SECRET_WORD", properties[8].GetValue(t));
                    }
                    
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.HasRows)
                        {
                            while (rd.Read())
                            {
                                T item = Activator.CreateInstance<T>();

                                for (int i = 0; i < rd.FieldCount; i++)
                                {
                                    PropertyInfo property = typeof(T).GetProperty(ConvertName(rd.GetName(i)));
                                    property?.SetValue(item, rd[i] == DBNull.Value ? null : rd[i]);
                                }
                                return item;

                            }
                        }
                        else
                        {
                            T item = Activator.CreateInstance<T>();
                            PropertyInfo property = typeof(T).GetProperty(ConvertName(rd.GetName(0)));
                            property.SetValue(item, 0);
                            return item;
                        }
                    }
                    con.Close();
                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return default;
        }
        public List<T> ReadList(User user,int filteredGroupId = -1)
        {
            string tableName = typeof(T).Name.ToUpper()=="USERGROUP" ? "USER_GROUP": typeof(T).Name.ToUpper();
            List<int> authIdList = filteredGroupId == -1 ? GetAuthList(user.UserId) : GetAuthList(user.UserId, filteredGroupId);
            string idData = string.Join(",", authIdList.Select((id, index) => "@id" + (index + 1)));
            string sql = "SELECT * FROM [" + tableName + "] WHERE ";// + tableName + "_GROUP_ID IN (" + idData + ") OR " + tableName + "_CREATOR_ID=@" + tableName + "_CREATOR_ID"
                                                                    // SELECT * FROM [USER] WHERE USER_ID IN (idData)
            if (tableName == "USER_GROUP")
            {
                sql += filteredGroupId==-1 ? "USER_ID=@USER_ID" : "GROUP_ID=@GROUP_ID";

            }
            else if (tableName == "USER"|| tableName == "GROUP")
            {
                sql += tableName + "_ID IN (" + idData + ")";
            }
            else // PROJECT - TASK 
            {
                sql += tableName + "_GROUP_ID IN (" + idData + ") OR " + tableName + "_CREATOR_ID=@" + tableName + "_CREATOR_ID";
            }

            List<T> result = new List<T>();


            try
            {
                
                using (SqlConnection con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;"))
                {
                    SqlCommand cmd = new SqlCommand(sql, con);
                    if (tableName != "USER_GROUP")
                    {
                        for (int i = 0; i < authIdList.Count; i++)
                        {
                            cmd.Parameters.AddWithValue("@id" + (i + 1), authIdList[i]);
                        }
                        if (tableName == "TASK" || tableName == "PROJECT")
                            cmd.Parameters.AddWithValue("@" + tableName + "_CREATOR_ID", user.UserId);
                    }
                    else
                    {
                        if (filteredGroupId == -1)
                            cmd.Parameters.AddWithValue("@USER_ID", user.UserId);
                        else
                            cmd.Parameters.AddWithValue("@GROUP_ID", filteredGroupId);
                    }

                    con.Open();
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            T item = Activator.CreateInstance<T>();
                            for (int i = 0; i < rd.FieldCount; i++)
                            {
                                PropertyInfo property = typeof(T).GetProperty(ConvertName(rd.GetName(i)));
                                property?.SetValue(item, rd[i] == DBNull.Value ? null : rd[i]);
                            }
                            result.Add(item);
                        }
                    }
                    con.Close();
                }
                    return result;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result;
        }
        public bool Update(T t) 
        {
            try
            {
                string tableName = typeof(T).Name.ToUpper();
                List<PropertyInfo> properties = t.GetType().GetProperties().ToList();
                PropertyInfo keyProperty = properties.FirstOrDefault(prop => prop.Name.Equals(ConvertName(tableName + "_ID"), StringComparison.OrdinalIgnoreCase)); // ID prop and value
                string sql = "UPDATE [" + tableName + "] SET ";

                foreach (PropertyInfo property in properties)
                {
                    if (property != keyProperty)
                    {
                        string propName = ConvertPropName(property.Name);
                        sql += propName + "=@" + propName + ", ";

                    }
                }

                sql = sql.TrimEnd(',', ' ');
                sql += " WHERE " + ConvertPropName(keyProperty.Name) + "=@" + ConvertPropName(keyProperty.Name);

                using (SqlConnection con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;"))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        foreach (PropertyInfo property in properties)
                        {
                            if (property != keyProperty)
                            {
                                object value = property.GetValue(t);
                                cmd.Parameters.AddWithValue("@" + ConvertPropName(property.Name), value ?? DBNull.Value);
                            }
                        }

                        object keyValue = keyProperty.GetValue(t);
                        cmd.Parameters.AddWithValue("@" + ConvertPropName(keyProperty.Name), keyValue);

                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            return false;
        }
        public bool Delete(T t) 
        {
            string tableName = typeof(T).Name.ToUpper();
            PropertyInfo[] properties = typeof(T).GetProperties();
            try
            {
                string sql = "DELETE FROM [" + tableName + "] WHERE " + tableName + "_ID=@" + tableName + "_ID";
                using (SqlConnection con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;"))
                {
                    string param = "@" + tableName + "_ID";
                    var value = (int)properties[0].GetValue(t);
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue(param,value);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    if (tableName == "PROJECT") // İf project deleted also delete subtasks
                    {
                        sql = "DELETE FROM [TASK] WHERE TASK_PROJECT_ID=@TASK_PROJECT_ID";
                        cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@TASK_PROJECT_ID", properties[0].GetValue(t));
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }

                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        public int Login(string userMail, string userPassword) // İf login succes return userId, otherwise return 0
        {
            int userId = 0; 
            try
            {
                using(SqlConnection con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;"))
                {
                    con.Open();
                    string sql = "SELECT USER_ID FROM [USER] WHERE USER_MAIL=@USER_MAIL AND USER_PASSWORD=@USER_PASSWORD";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@USER_MAIL",userMail);
                        cmd.Parameters.AddWithValue("@USER_PASSWORD",userPassword);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            userId = (int)result;
                        }

                    }
                    con.Close();
                    return userId;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return userId;
        }

        // Subprocesses
        private string ConvertPropName(string input) // ProjectId => PROJECT_ID / entity to sql
        {
            StringBuilder result = new StringBuilder();
            for(int i =0; i < input.Length; i++)
            {
                char currentChar = input[i];
                if (currentChar == 'i')
                    currentChar = 'ı';

                if (i > 0 && char.IsUpper(currentChar))
                    result.Append('_');
                result.Append(char.ToUpper(currentChar));
            }

            return result.ToString();
        }
        private string ConvertName(string input) // PROJECT_ID => ProjectId  / sql to entity
        {
            StringBuilder result = new StringBuilder();
            bool bayrak = true;
            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                if (bayrak)
                {
                    result.Append(currentChar);
                    bayrak = false;
                }
                else
                {
                    currentChar = currentChar == 'I' ? 'İ' : currentChar;
                    if (currentChar != '_')
                    {
                        result.Append(char.ToLower(currentChar));
                    }
                    else
                        bayrak = true;
                }
            }
            return result.ToString();
        }
        private List<int> GetAuthList(int userId, int filteredGroupId = -1) // The user can see the tasks or projects for which user has authority
        {
            List<int> authIdList = new List<int>() { -1,0 }; // -1 for projects with no group 
            string sql;
            int value;
            string parameter;
            string getId;
            if (filteredGroupId == -1)
            {
                sql = "SELECT GROUP_ID FROM [USER_GROUP] WHERE USER_ID=@USER_ID AND INVITE_STATUS=@INVITE_STATUS";
                getId = "GROUP_ID";
                parameter = "@USER_ID";
                value = userId;
            }
            else
            {
                sql = "SELECT USER_ID FROM [USER_GROUP] WHERE GROUP_ID=@GROUP_ID AND INVITE_STATUS=@INVITE_STATUS";
                getId = "USER_ID";
                parameter = "@GROUP_ID";
                value = filteredGroupId;
            }

            try
            {
                using (SqlConnection con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;"))
                {
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue(parameter, value);
                    cmd.Parameters.AddWithValue("@INVITE_STATUS", "Accepted");
                    con.Open();
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            authIdList.Add(Convert.ToInt32(rd[getId]));
                        }
                    }
                    con.Close();
                    return authIdList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return authIdList;
        }

    }
}
