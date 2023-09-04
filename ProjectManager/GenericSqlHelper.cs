using ProjectManager.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManager
{
    public class GenericSqlHelper<T>
    {
        SqlCommand cmd;
        SqlConnection con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;");

        public bool Create(T t)
        {
            try
            {
                string tableName = typeof(T).Name;
                PropertyInfo[] properties = typeof(T).GetProperties();

                string strCol = string.Join(",", properties.Skip(1).Select(r => ConvertPropName(r.Name)));
                string strParam = string.Join(",", properties.Skip(1).Select(r => "@"+ConvertPropName(r.Name)));
                string sql = "INSERT INTO [" + tableName + "] (" + strCol + ") VALUES(" + strParam + ")";

                using (con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;"))
                {
                    con.Open();
                    cmd = new SqlCommand(sql, con);
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
        public T ReadById(T t)
        {
            try
            {
                string tableName = typeof(T).Name;
                PropertyInfo[] properties = typeof(T).GetProperties();
                string sql = "SELECT * FROM [" + tableName + "] WHERE "+ ConvertPropName(properties[0].Name) + "=@"+ properties[0].Name;
                using (con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;"))
                {
                    con.Open();
                    cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@"+ ConvertPropName(properties[0].Name), properties[0].GetValue(t));
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            T item = Activator.CreateInstance<T>();

                            for(int i = 0; i<rd.FieldCount; i++)
                            {
                                PropertyInfo property = typeof(T).GetProperty(ConvertName(rd.GetName(i)));
                                property?.SetValue(item, rd[i] == DBNull.Value ? null : rd[i]);
                            }
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
        public List<T> ReadForList(User user,int filteredGroupId = -1)
        {
            string tableName = typeof(T).Name.ToUpper();
            List<T> result = new List<T>();
            try
            {
                List<int> authIdList = filteredGroupId == -1 ? GetAuthList(user.UserId) : GetAuthList(user.UserId,filteredGroupId);
                string idData = string.Join(",", authIdList.Select((id, index) => "@id" + (index + 1)));
                string sql = "SELECT * FROM [" + tableName + "] WHERE ";// + tableName + "_GROUP_ID IN (" + idData + ") OR " + tableName + "_CREATOR_ID=@" + tableName + "_CREATOR_ID"
                // SELECT * FROM [USER] WHERE USER_ID IN (idData)
                sql += tableName == "USER" ? tableName+ "_ID IN ("+idData+")" : tableName + "_GROUP_ID IN (" + idData + ") OR " + tableName + "_CREATOR_ID=@" + tableName + "_CREATOR_ID";
                
                using (con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;"))
                {
                    cmd = new SqlCommand(sql, con);
                    for (int i = 0; i < authIdList.Count; i++)
                    {
                        cmd.Parameters.AddWithValue("@id" + (i + 1), authIdList[i]);
                    }
                    if (tableName == "TASK" || tableName == "PROJECT")
                        cmd.Parameters.AddWithValue("@" + tableName + "_CREATOR_ID", user.UserId);
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
        
        private List<int> GetAuthList(int userId, int filteredGroupId = -1) // The user can see the tasks or projects for which user has authority
        {
            List<int> authIdList = new List<int>() { -1 }; // -1 for projects with no group 
            string sql = "";
            string getId = "";
            string parameter = "";
            var value = 0;
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
                using (con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;"))
                {
                    cmd = new SqlCommand(sql,con);
                    cmd.Parameters.AddWithValue(parameter, value);
                    cmd.Parameters.AddWithValue("@INVITE_STATUS","Accepted");
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
        // -----
        public List<T> Read(T t, User user=null)
        { 
            List<T> result = new List<T>();
            List<int> result2 = new List<int>();
            try
            {
                string tableName = typeof(T).Name.ToUpper();
                PropertyInfo[] properties = typeof(T).GetProperties();
                

                string strCol = string.Join(",",properties.Select(p=>ConvertPropName(p.Name)));
                string strParam = string.Join(",",properties.Select(p=>"@"+ConvertPropName(p.Name)));


                using (con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;"))
                {
                    var lookingFor = strCol.Contains(tableName+"_GROUP_ID");
                    if (lookingFor)
                    {
                        cmd = new SqlCommand("SELECT GROUP_ID FROM [USER_GROUP] WHERE USER_ID=@USER_ID AND INVITE_STATUS=@INVITE_STATUS", con);
                        cmd.Parameters.AddWithValue("@USER_ID", user.UserId);
                        cmd.Parameters.AddWithValue("@INVITE_STATUS", "Accepted");
                        List<int> authIdList = new List<int> { -1 };
                        con.Open();
                        using (SqlDataReader rd = cmd.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                authIdList.Add(Convert.ToInt32(rd["GROUP_ID"]));
                            }
                        }
                        con.Close();

                        string idData = string.Join(",", authIdList.Select((id, index) => "@id" + (index + 1)));
                        string sql = "SELECT * FROM [" + tableName + "] WHERE " + tableName + "_GROUP_ID IN (" + idData + ") OR " + tableName + "_CREATOR_ID=@" + tableName + "_CREATOR_ID";
                        cmd = new SqlCommand(sql, con);
                        for (int i = 0; i < authIdList.Count; i++)
                        {
                            cmd.Parameters.AddWithValue("@id" + (i + 1), authIdList[i]);
                        }
                        cmd.Parameters.AddWithValue("@" + tableName + "_CREATOR_ID", user.UserId);
                        
                    }
                    else
                    {
                        string sql = "SELECT * FROM ["+tableName+"] WHERE "+tableName+"_ID=@"+tableName+"=_ID";
                        cmd = new SqlCommand(sql, con); // Change sql to SqlHelper.cs -> 301,

                        PropertyInfo prop = typeof(T).GetProperty(ConvertName(tableName + "_ID"));
                        object idValue = prop.GetValue(t);
                        
                        string query = "SELECT GROUP_ID FROM USER_GROUP WHERE USER_ID=@USER_ID";
                        SqlCommand cmd2= new SqlCommand(query, con);
                        cmd2.Parameters.AddWithValue("@USER_ID",idValue);
                        con.Open();
                        using (SqlDataReader rd = cmd2.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                int item = Activator.CreateInstance<int>();
                                for (int i = 0; i < rd.FieldCount; i++)
                                {
                                    PropertyInfo property = typeof(T).GetProperty(ConvertName(rd.GetName(i)));
                                    property?.SetValue(item, rd[i] == DBNull.Value ? null : rd[i]);
                                }

                                result2.Add(item);
                            }
                        }
                        con.Close();
                        //string idData = string.Join(",", authIdList.Select((id, index) => "@id" + (index + 1)));
                        string idData = string.Join(",", result2.Select((id, index) => "@id" + (index + 1)));
                        query = "SELECT USER_ID FROM [USER_GROUP] WHERE GROUP_ID IN (" + idData + ")";



                        cmd.Parameters.AddWithValue(tableName+"_ID",idValue);
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

                    return result;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //return (T) Convert.ChangeType(yat, typeof(T)); // sometimes
            return result;
        }
        public bool Update(T t) 
        {

            return false;
        }
        public bool Delete(T t) 
        {

            return false;
        }
        private string ConvertPropName(string input)
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
        private string ConvertName(string input)
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

    }
}
