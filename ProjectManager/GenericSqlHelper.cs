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
        SqlDataReader rd;
        SqlDataAdapter adptr;
        SqlConnection con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;");

        readonly List<string> projectColumns = new List<string>() {"PROJECT_NAME","PROJECT_STATUS", "PROJECT_PRIORITY", "PROJECT_START_DATE", "PROJECT_END_DATE", "PROJECT_GROUP_ID", "PROJECT_CREATOR_ID", "PROJECT_DESCRIPTION" };
        readonly List<string> taskColumns = new List<string>() {"TASK_NAME", "TASK_STATUS", "TASK_PRIORITY", "TASK_START_DATE", "TASK_END_DATE" , "TASK_DURATION" , "TASK_OWNER_ID" , "TASK_CREATOR_ID" , "TASK_PROJECT_ID" , "TASK_GROUP_ID" , "TASK_DESCRIPTION" };
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
        public T Read(T t)
        { 
            try
            {
                string tableName = typeof(T).Name;
                PropertyInfo[] properties = typeof(T).GetProperties();

                string strCol = string.Join(",",properties.Select(p=>ConvertPropName(p.Name)));
                string strParam = string.Join(",",properties.Select(p=>"@"+ConvertPropName(p.Name)));
                string sql = "SELECT * FROM [" + tableName + "] WHERE "+tableName+"_ID=@"+tableName+"_ID";

                using (con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;"))
                {
                    con.Open();
                    cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@"+ tableName + "_ID", properties[0].GetValue(t));
                    
                
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //return (T) Convert.ChangeType(yat, typeof(T)); // sometimes
            return t;
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

    }
}
