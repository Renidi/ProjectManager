using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Web.UI.WebControls;

namespace ProjectManager
{
    internal class SqlDbHelper
    {
        SqlDataReader dr;
        SqlConnection Con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;");

        User user = new User();
        Project project = new Project();

        public SqlDbHelper() 
        {

        }
        public DataTable LoadData(params string[] arguments) 
        {                       // arg[0] = Table , arg[1] =? userMail
            try
            {
                SqlConnection Con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;"); // THINK
                Con.Open();
                using (Con)
                {
                    using(DataTable dt = new DataTable(arguments[0]))
                    {
                        SqlDataAdapter adptr = new SqlDataAdapter();
                        if (arguments.Length == 2)
                        {
                            adptr = new SqlDataAdapter("SELECT * FROM [" + arguments[0] + "] WHERE TASK_OWNER=@TASK_OWNER", Con);
                            adptr.SelectCommand.Parameters.AddWithValue("@TASK_OWNER", arguments[1]);
                        }
                        else
                        {
                            adptr = new SqlDataAdapter("SELECT * FROM [" + arguments[0] + "]", Con);
                        }
                        adptr.Fill(dt);
                        Con.Close();
                        //dt.Columns.Remove("Id");
                        return dt;
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                Con.Close();
                return null;
            }
            finally 
            {
                Con.Close();
            }

        }

        public bool SaveProject(Project project)
        {
            SqlConnection Con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;");
            try
            {
                
                SqlCommand cmd = new SqlCommand("INSERT INTO [PROJECT](PROJECT_NAME,PROJECT_STATUS,PROJECT_PRIORITY,PROJECT_START_DATE,PROJECT_END_DATE,PROJECT_DURATION,PROJECT_CREATOR,PROJECT_DESCRIPTION)" +
                                                                "values(@PROJECT_NAME,@PROJECT_STATUS,@PROJECT_PRIORITY,@PROJECT_START_DATE,@PROJECT_END_DATE,@PROJECT_DURATION,@PROJECT_CREATOR,@PROJECT_DESCRIPTION)", Con);

                cmd.Parameters.AddWithValue("@PROJECT_NAME", project.ProjectName);
                cmd.Parameters.AddWithValue("@PROJECT_STATUS", project.ProjectStatus);
                cmd.Parameters.AddWithValue("@PROJECT_PRIORITY", project.ProjectPriority);
                cmd.Parameters.AddWithValue("@PROJECT_START_DATE", project.ProjectStartDate);
                cmd.Parameters.AddWithValue("@PROJECT_END_DATE", project.ProjectEndDate);
                cmd.Parameters.AddWithValue("@PROJECT_DURATION", project.ProjectDuration);
                cmd.Parameters.AddWithValue("@PROJECT_CREATOR", project.ProjectCreator);
                cmd.Parameters.AddWithValue("@PROJECT_DESCRIPTION", project.ProjectDescription);
                Con.Open();
                cmd.ExecuteNonQuery();
                Con.Close() ;
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Con.Close();
                return false;
            }
        }

        public bool SaveTask(Task task)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO [TASK](TASK_NAME,TASK_STATUS,TASK_PRIORITY,TASK_START_DATE,TASK_END_DATE,TASK_DURATION,TASK_OWNER,TASK_PROJECT,TASK_DESCRIPTION)" +
                                                            "values(@TASK_NAME,@TASK_STATUS,@TASK_PRIORITY,@TASK_START_DATE,@TASK_END_DATE,@TASK_DURATION,@TASK_OWNER,@TASK_PROJECT,@TASK_DESCRIPTION)", Con);
                cmd.Parameters.AddWithValue("@TASK_NAME", task.TaskName);
                cmd.Parameters.AddWithValue("@TASK_STATUS", task.TaskStatus);
                cmd.Parameters.AddWithValue("@TASK_PRIORITY", task.TaskPriority);
                cmd.Parameters.AddWithValue("@TASK_START_DATE", task.TaskStartDate);
                cmd.Parameters.AddWithValue("@TASK_END_DATE", task.TaskEndDate);
                cmd.Parameters.AddWithValue("@TASK_DURATION", task.TaskDuration);
                cmd.Parameters.AddWithValue("@TASK_OWNER", task.TaskOwner);
                cmd.Parameters.AddWithValue("@TASK_PROJECT", task.TaskProject);
                cmd.Parameters.AddWithValue("@TASK_DESCRIPTION", task.TaskDescription);
                Con.Open();
                cmd.ExecuteNonQuery();
                Con.Close();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Con.Close();
            return false;
        }

        public bool EditProject(Project project)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE [PROJECT] SET PROJECT_NAME=@PROJECT_NAME,PROJECT_STATUS=PROJECT_STATUS,PROJECT_PRIORITY=@PROJECT_PRIORITY,PROJECT_END_DATE=@PROJECT_END_DATE, PROJECT_DURATION=@PROJECT_DURATION ,PROJECT_DESCRIPTION=@PROJECT_DESCRIPTION WHERE PROJECT_ID=@PROJECT_ID", Con);
                cmd.Parameters.AddWithValue("@PROJECT_NAME", project.ProjectName);
                cmd.Parameters.AddWithValue("@PROJECT_STATUS", project.ProjectStatus);
                cmd.Parameters.AddWithValue("@PROJECT_PRIORITY", project.ProjectPriority);
                cmd.Parameters.AddWithValue("@PROJECT_DURATION", project.ProjectDuration);
                cmd.Parameters.AddWithValue("@PROJECT_END_DATE", project.ProjectEndDate);
                cmd.Parameters.AddWithValue("@PROJECT_DESCRIPTION", project.ProjectDescription);

                cmd.Parameters.AddWithValue("@PROJECT_ID", project.ProjectId);
                
                cmd.ExecuteNonQuery();
                Con.Close();
                return true;
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Con.Close();
            return false;
        }

        public bool EditTask(Task task)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE [TASK] SET TASK_NAME = @TASK_NAME, TASK_STATUS = @TASK_STATUS, TASK_PRIORITY = @TASK_PRIORITY , TASK_END_DATE = @TASK_END_DATE, TASK_OWNER = @TASK_OWNER, TASK_PROJECT = @TASK_PROJECT, TASK_DESCRIPTION = @TASK_DESCRIPTION WHERE TASK_ID = @TASK_ID", Con);
                cmd.Parameters.AddWithValue("@TASK_NAME", task.TaskName);
                cmd.Parameters.AddWithValue("@TASK_STATUS", task.TaskStatus);
                cmd.Parameters.AddWithValue("@TASK_PRIORITY", task.TaskPriority);
                cmd.Parameters.AddWithValue("@TASK_END_DATE", task.TaskEndDate);
                cmd.Parameters.AddWithValue("@TASK_OWNER", task.TaskOwner);
                cmd.Parameters.AddWithValue("@TASK_PROJECT", task.TaskProject);
                cmd.Parameters.AddWithValue("@TASK_DESCRIPTION", task.TaskDescription);

                cmd.Parameters.AddWithValue("@TASK_ID", task.TaskId);

                cmd.ExecuteNonQuery();
                Con.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Con.Close();
            return false;
        }

        public bool Delete(string table, Project project = null, Task task = null)
        {
            try
            {
                SqlConnection Con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;");
                Con.Open();
                using (Con)
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM ["+ table + "] WHERE "+ table + "_ID = @"+ table + "_ID", Con);
                    // SqlCommand cmd = new SqlCommand("DELETE FROM PROJECT WHERE PROJECT_ID = @PROJECT_ID, Con);
                    // SqlCommand cmd = new SqlCommand("DELETE FROM TASK WHERE TASK_ID = @TASK_ID, Con);
                    if(project != null)
                    {
                        cmd.Parameters.AddWithValue("@PROJECT_ID", project.ProjectId);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("TASK_ID", task.TaskId);
                    }
                    var temp = project.ProjectName;
                    cmd.ExecuteNonQuery();
                }
                Con.Close();
                if (table == "PROJECT")
                {
                    DeleteSubTasks(project);
                }
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Con.Close();
            return false;
        }

        public bool DeleteSubTasks(Project project)
        {
            try
            {
                SqlConnection Con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;");
                Con.Open();
                using (Con)
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM [TASK] WHERE TASK_RPOJECT=@TASK_PROJECT",Con);
                    cmd.Parameters.AddWithValue("@TASK_PROJECT", project.ProjectName);
                    cmd.ExecuteNonQuery ();
                }
                Con.Close();
                return true;
            }   
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }
        // combine with project names
        public List<string> TakeEmployeeMails(params string[] arguments)
        {
            List<string> list = new List<string>();
            SqlConnection Con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;");
            Con.Open();
            try
            {
                using (Con)
                {
                    SqlCommand cmd = new SqlCommand("SELECT USER_MAIL FROM [USER]", Con);
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            list.Add(rd.GetString(0));
                        }
                    }
                }
                Con.Close();
                return list;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return list;
        }
        
        public List<string> TakeProjectsName(params string[] arguments)
        {
            List<string> list = new List<string>();
            SqlConnection Con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;");
            Con.Open();
            try
            {
                using (Con)
                { 
                    if (arguments.Length == 1)
                    { // Project Names in Combobox
                        SqlCommand cmd = new SqlCommand("SELECT PROJECT_NAME FROM [" + arguments[0]+"]", Con);

                        using (SqlDataReader rd = cmd.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                list.Add(rd.GetString(0));
                            }
                        }
                    }
                    else
                    { // Project Names on Calender with Priority
                        string tempDate = Convert.ToDateTime(arguments[1]).ToString();
                        SqlCommand cmd = new SqlCommand("SELECT PROJECT_NAME , PROJECT_END_DATE , PROJECT_PRIORITY FROM [" + arguments[0] + "]", Con);

                        using (SqlDataReader rd = cmd.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                string projectDate = rd.GetDateTime(1).Date.ToString();
                                if (tempDate == projectDate)
                                {
                                    list.Add(rd.GetString(0));
                                    list.Add(rd.GetString(2));
                                }

                            }
                        }

                    }
                    
                }

                return list;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            return list;
        }

        public bool Login(string Mail, string Password)
        {
            try
            {
                Con.Open();
                // CAN BE CHANGE
                SqlCommand cmd = new SqlCommand("SELECT * FROM [USER] WHERE USER_MAIL = @USER_MAIL AND USER_PASSWORD = @USER_PASSWORD", Con);
                cmd.Parameters.AddWithValue("@USER_MAIL", Mail);
                cmd.Parameters.AddWithValue("@USER_PASSWORD", Password);
                
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    Con.Close();
                    UpdateLastLoginDate(Mail);
                    return true;
                }
                Con.Close();
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Con.Close();
            return false;
        } 

        public void Register(User user)
        {
            SqlConnection Con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;");
            try
            {
                Con.Open();
                 
                SqlCommand cmd = new SqlCommand("INSERT INTO [USER](USER_NAME , USER_SURNAME , USER_MAIL , USER_PASSWORD , USER_REGISTER_DATE , USER_LAST_LOGIN_DATE , USER_SECRET_WORD )" +
                                                            "values(@USER_NAME , @USER_SURNAME , @USER_MAIL , @USER_PASSWORD , @USER_REGISTER_DATE , @USER_LAST_LOGIN_DATE , @USER_SECRET_WORD )", Con);
                cmd.Parameters.AddWithValue("@USER_NAME", user.UserName);
                cmd.Parameters.AddWithValue("@USER_SURNAME", user.UserSurname);
                cmd.Parameters.AddWithValue("@USER_MAIL", user.UserMail);
                cmd.Parameters.AddWithValue("@USER_PASSWORD", user.UserPassword);
                cmd.Parameters.AddWithValue("@USER_REGISTER_DATE", user.UserRegisterDate);
                cmd.Parameters.AddWithValue("@USER_LAST_LOGIN_DATE", user.UserLastLoginDate);
                cmd.Parameters.AddWithValue("@USER_SECRET_WORD", user.UserSecretWord);

                cmd.ExecuteNonQuery();
                Con.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Con.Close();

        }
        public User UserInfo(User user)
        {
            try
            {
                SqlConnection Con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;");
                
                SqlCommand cmd = new SqlCommand("SELECT * FROM [USER] WHERE USER_MAIL=@USER_MAIL", Con);
                cmd.Parameters.AddWithValue("@USER_MAIL", user.UserMail);
                Con.Open();
                using (SqlDataReader rd = cmd.ExecuteReader()) 
                {
                    while (rd.Read())
                    {
                        user.UserId = Convert.ToInt32(rd["USER_ID"]);
                        user.UserName = rd["USER_NAME"].ToString();
                        user.UserSurname = rd["USER_SURNAME"].ToString();
                        user.UserMail = rd["USER_MAIL"].ToString();
                        user.UserRegisterDate = Convert.ToDateTime(rd["USER_REGISTER_DATE"].ToString());
                        user.UserLastLoginDate = Convert.ToDateTime(rd["USER_LAST_LOGIN_DATE"].ToString());
                    }
                }
                Con.Close();
                return user;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Con.Close() ;
            return user;
        }

        public bool CheckSecretWord(string userMail, string userSecretWord)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [USER] WHERE USER_MAIL = @USER_MAIL AND USER_SECRET_WORD = @USER_SECRET_WORD", Con);
                cmd.Parameters.AddWithValue("@USER_MAIL", userMail);
                cmd.Parameters.AddWithValue("@USER_SECRET_WORD", userSecretWord);

                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    Con.Close();
                    return true;
                }
                Con.Close();
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Con.Close() ;
            return false;
        }

        public bool ChangePassword(string userMail, string userNewPassword)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE [USER] SET USER_PASSWORD=@USER_PASSWORD WHERE USER_MAIL=@USER_MAIL", Con);

                cmd.Parameters.AddWithValue("@USER_PASSWORD", userNewPassword);
                cmd.Parameters.AddWithValue("@USER_MAIL", userMail);
                cmd.ExecuteNonQuery();
                Con.Close();
                UpdateLastLoginDate(userMail);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Con.Close();
            return false;
        }

        void UpdateLastLoginDate(string userMail)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE [USER] SET USER_LAST_LOGIN_DATE=@USER_LAST_LOGIN_DATE WHERE USER_MAIL=@USER_MAIL", Con);
                cmd.Parameters.AddWithValue("@USER_LAST_LOGIN_DATE", DateTime.Now);
                cmd.Parameters.AddWithValue("@USER_MAIL", userMail);
                cmd.ExecuteNonQuery();
                Con.Close();

            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Con.Close() ;
        }

        public void DataLog(Log log)
        {
            if (log.LogStatus.ToLower() == "true")
                log.LogStatus = "Successful";
            else
                log.LogStatus = "Fail";

            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO [LOG_DATA](LOG_SOURCE , LOG_TYPE , LOG_DATE , LOG_USER , LOG_USER_ID , LOG_DESCRIPTION , LOG_STATUS)" +
                                                           "values(@LOG_SOURCE,@LOG_TYPE,@LOG_DATE,@LOG_USER,@LOG_USER_ID,@LOG_DESCRIPTION,@LOG_STATUS)", Con);
                cmd.Parameters.AddWithValue("@LOG_SOURCE",log.LogSource);
                cmd.Parameters.AddWithValue("@LOG_TYPE",log.LogType);
                cmd.Parameters.AddWithValue("@LOG_DATE",log.LogDate);
                cmd.Parameters.AddWithValue("@LOG_USER",log.LogUser);
                cmd.Parameters.AddWithValue("@LOG_USER_ID",log.LogUserId);
                cmd.Parameters.AddWithValue("@LOG_DESCRIPTION",log.LogDescription);
                cmd.Parameters.AddWithValue("@LOG_STATUS",log.LogStatus);

                cmd.ExecuteNonQuery();
                Con.Close();
            
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Con.Close();
        }

    }
}
