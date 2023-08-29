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
        public List<T> Read(T t, User user=null)
        { 
            List<T> result = new List<T>();
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
                        cmd = new SqlCommand(sql, con); // Change sql to SqlHelper.cs -> 301
                        var prop = properties[0];
                        cmd.Parameters.AddWithValue("@"+tableName+"_ID",GetItemId(t));
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
        private int GetItemId(T t)
        {
            if (t is Project project)
                return project.ProjectId;
            else if (t is Task task)
                return task.TaskId;
            else if (t is User user)
                return user.UserId;
            else if (t is Group group)
                return group.GroupId;
            else if (t is UserGroup userGroup)
                return userGroup.UserId;
            else
                throw new ArgumentException("Unsupported Type");
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
