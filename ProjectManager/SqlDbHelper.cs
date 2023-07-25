using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace ProjectManager
{
    internal class SqlDbHelper
    {
        SqlDataReader dr;
        SqlConnection Con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManagerDb; Integrated Security=true;");

        User user = new User();
        Project project = new Project();

        public SqlDbHelper() 
        {

        }
        public DataTable LoadData(params string[] arguments) 
        {                       // arg[0] = Table , arg[1] =? userMail
            try
            {
                SqlConnection Con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManagerDb; Integrated Security=true;"); // THINK
                Con.Open();
                using (Con)
                {
                    using(DataTable dt = new DataTable(arguments[0]))
                    {
                        SqlDataAdapter adptr = new SqlDataAdapter();
                        if (arguments.Length == 2)
                        {
                            adptr = new SqlDataAdapter("SELECT * FROM " + arguments[0] + " WHERE TaskOwner=@TaskOwner", Con);
                            adptr.SelectCommand.Parameters.AddWithValue("@TaskOwner", arguments[1]);
                        }
                        else
                        {
                            adptr = new SqlDataAdapter("SELECT * FROM " + arguments[0], Con);
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
            try
            {
                
                SqlCommand cmd = new SqlCommand("INSERT INTO ProjectsTbl(ProjectName,ProjectStatus,ProjectPriority,ProjectStartDate,ProjectFinishDate,ProjectOwner)" +
                                                                "values(@ProjectName,@ProjectStatus,@ProjectPriority,@ProjectStartDate,@ProjectFinishDate,@ProjectOwner)", Con);

                cmd.Parameters.AddWithValue("@ProjectName",project.ProjectName);
                cmd.Parameters.AddWithValue("@ProjectStatus", project.ProjectStatus);
                cmd.Parameters.AddWithValue("@ProjectPriority", project.ProjectPriority);
                cmd.Parameters.AddWithValue("@ProjectFinishDate", project.ProjectFinishDate);
                cmd.Parameters.AddWithValue("@ProjectOwner", project.ProjectOwner);
                cmd.Parameters.AddWithValue("@ProjectStartDate", project.ProjectStartDate);
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
                SqlCommand cmd = new SqlCommand("INSERT INTO TasksTbl(TaskName,Taskstatus,TaskPriority,TaskStartDate,TaskFinishDate,TaskOwner,TaskProject,TaskDescription)" +
                                                            "values(@TaskName,@TaskStatus,@TaskPriority,@TaskStartDate,@TaskFinishDate,@TaskOwner,@TaskProject,@TaskDescription)",Con);
                cmd.Parameters.AddWithValue("@TaskName",task.TaskName);
                cmd.Parameters.AddWithValue("@TaskStatus",task.TaskStatus);
                cmd.Parameters.AddWithValue("@TaskPriority",task.TaskPriority);
                cmd.Parameters.AddWithValue("@TaskStartDate",task.TaskStartDate);
                cmd.Parameters.AddWithValue("@TaskFinishDate",task.TaskFinishDate);
                cmd.Parameters.AddWithValue("@TaskOwner",task.TaskOwner);
                cmd.Parameters.AddWithValue("@TaskProject",task.TaskProject);
                cmd.Parameters.AddWithValue("@TaskDescription",task.TaskDescription);
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
                SqlCommand cmd = new SqlCommand("UPDATE ProjectsTbl SET ProjectName=@ProjectName,ProjectStatus=ProjectStatus,ProjectPriority=@ProjectPriority,ProjectFinishDate=@ProjectFinishDate,ProjectOwner=@ProjectOwner WHERE Id=@Id", Con);
                cmd.Parameters.AddWithValue("@ProjectName", project.ProjectName);
                cmd.Parameters.AddWithValue("@ProjectStatus", project.ProjectStatus);
                cmd.Parameters.AddWithValue("@ProjectPriority", project.ProjectPriority);
                cmd.Parameters.AddWithValue("@ProjectFinishDate", project.ProjectFinishDate);
                cmd.Parameters.AddWithValue("@ProjectOwner", project.ProjectOwner);
                cmd.Parameters.AddWithValue("@Id", project.Id);
                
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
                SqlCommand cmd = new SqlCommand("UPDATE TasksTbl SET TaskName = @TaskName, TaskStatus = @TaskStatus, TaskFinishDate = @TaskFinishDate, TaskOwner = @TaskOwner, TaskProject = @TaskProject, TaskDescription = @TaskDescription WHERE Id = @Id", Con);
                cmd.Parameters.AddWithValue("@TaskName", task.TaskName);
                cmd.Parameters.AddWithValue("@TaskStatus", task.TaskStatus);
                cmd.Parameters.AddWithValue("@TaskPriority", task.TaskPriority);
                cmd.Parameters.AddWithValue("@TaskFinishDate", task.TaskFinishDate);
                cmd.Parameters.AddWithValue("@TaskOwner", task.TaskOwner);
                cmd.Parameters.AddWithValue("@TaskProject", task.TaskProject);
                cmd.Parameters.AddWithValue("@TaskDescription", task.TaskDescription);
                cmd.Parameters.AddWithValue("@Id", task.Id);

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

        public bool Delete(string where, Project project = null, Task task = null)
        {
            try
            {
                SqlConnection Con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManagerDb; Integrated Security=true;");
                Con.Open();
                using (Con)
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM "+ where + " WHERE Id=@Id", Con);
                    if(project != null)
                    {
                        cmd.Parameters.AddWithValue("@Id", project.Id);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("Id", task.Id);
                    }
                    cmd.ExecuteNonQuery();
                }
                Con.Close();
                if (where == "ProjectsTbl")
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
                SqlConnection Con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManagerDb; Integrated Security=true;");
                Con.Open();
                using (Con)
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM TasksTbl WHERE TaskProject=@TaskProject",Con);
                    cmd.Parameters.AddWithValue("@TaskProject",project.ProjectName);
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
        // combin with project names
        public List<string> TakeEmployeeMails(params string[] arguments)
        {
            List<string> list = new List<string>();
            SqlConnection Con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManagerDb; Integrated Security=true;");
            Con.Open();
            try
            {
                using (Con)
                {
                    SqlCommand cmd = new SqlCommand("SELECT UserMail FROM UserTbl ", Con);
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
            SqlConnection Con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManagerDb; Integrated Security=true;");
            Con.Open();
            try
            {
                using (Con)
                { 
                    if (arguments.Length == 1)
                    { // Project Names in Combobox
                        SqlCommand cmd = new SqlCommand("SELECT ProjectName FROM "+ arguments[0], Con);

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
                        SqlCommand cmd = new SqlCommand("SELECT ProjectName,ProjectFinishDate,ProjectPriority FROM "+ arguments[0], Con);

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
                SqlCommand cmd = new SqlCommand("SELECT * FROM UserTbl WHERE UserMail = @UserMail AND UserPassword = @UserPassword", Con);
                cmd.Parameters.AddWithValue("@UserMail", Mail);
                cmd.Parameters.AddWithValue("@UserPassword", Password);
                
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
            try
            {
                Con.Open();
                 
                SqlCommand cmd = new SqlCommand("INSERT INTO UserTbl(UserName,UserSurname,UserMail,UserPassword,UserRegisterDate,UserLastLoginDate,UserSecretWord)" +
                                                            "values(@UserName,@UserSurname,@UserMail,@UserPassword,@UserRegisterDate,@UserLastLoginDate,@UserSecretWord)", Con);
                cmd.Parameters.AddWithValue("@UserName",user.UserName);
                cmd.Parameters.AddWithValue("@UserSurname", user.UserSurname);
                cmd.Parameters.AddWithValue("@UserMail", user.UserMail);
                cmd.Parameters.AddWithValue("@UserPassword", user.UserPassword);
                cmd.Parameters.AddWithValue("@UserRegisterDate",user.UserRegisterDate);
                cmd.Parameters.AddWithValue("@UserLastLoginDate",user.UserRegisterDate);
                cmd.Parameters.AddWithValue("@UserSecretWord", user.UserSecretWord);

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
                SqlConnection Con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManagerDb; Integrated Security=true;");
                
                SqlCommand cmd = new SqlCommand("SELECT * FROM UserTbl WHERE UserMail=@UserMail",Con);
                cmd.Parameters.AddWithValue("@UserMail", user.UserMail);
                Con.Open();
                using (SqlDataReader rd = cmd.ExecuteReader()) 
                {
                    while (rd.Read())
                    {
                        user.Id = Convert.ToInt32(rd["UserId"]);
                        user.UserName = rd["UserName"].ToString();
                        user.UserSurname = rd["UserSurname"].ToString();
                        user.UserMail = rd["UserMail"].ToString();
                        user.UserRegisterDate = Convert.ToDateTime(rd["UserRegisterDate"].ToString());
                        user.UserLastLoginDate = Convert.ToDateTime(rd["UserLastLoginDate"].ToString());
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
                SqlCommand cmd = new SqlCommand("SELECT * FROM UserTbl WHERE UserMail = @UserMail AND UserSecretWord = @UserSecretWord", Con);
                cmd.Parameters.AddWithValue("@UserMail", userMail);
                cmd.Parameters.AddWithValue("@UserSecretWord", userSecretWord);

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
                SqlCommand cmd = new SqlCommand("UPDATE UserTbl SET UserPassword=@UserPassword WHERE UserMail=@UserMail", Con);

                cmd.Parameters.AddWithValue("@UserPassword", userNewPassword);
                cmd.Parameters.AddWithValue("@UserMail", userMail);
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
                SqlCommand cmd = new SqlCommand("UPDATE UserTbl SET UserLastLoginDate=@UserLastLoginDate WHERE UserMail=@UserMail", Con);
                cmd.Parameters.AddWithValue("@UserLastLoginDate", DateTime.Now);
                cmd.Parameters.AddWithValue("@UserMail", userMail);
                cmd.ExecuteNonQuery();
                Con.Close();

            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Con.Close() ;
        }

        public void DataLog(Operation operation)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO LogDataTbl(OperationName,OperationTable,OperationType,OperationTime,OperationChange,OperationUser,OperationUserId)" +
                                                     "values(@OperationName,@OperationTable,@OperationType,@OperationTime,@OperationChange,@OperationUser,@OperationUserId)", Con);
                cmd.Parameters.AddWithValue("@OperationName",operation.OperationName);
                cmd.Parameters.AddWithValue("@OperationTable",operation.OperationTable);
                cmd.Parameters.AddWithValue("@OperationType",operation.OperationType);
                cmd.Parameters.AddWithValue("@OperationTime",operation.OperationTime);
                cmd.Parameters.AddWithValue("@OperationChange",operation.OperationChange);
                cmd.Parameters.AddWithValue("@OperationUser",operation.OperationUser);
                cmd.Parameters.AddWithValue("@OperationUserId",operation.OperationUserId);

                cmd.ExecuteNonQuery();
                Con.Close();
            
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Con.Close();
        }
        public void UserLog(User user, string type)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO LogUserTbl(ProcessUser,ProcessUserId,ProcessType,ProcessTime)" +
                                                              "values(@ProcessUser,@ProcessUserId,@ProcessType,@ProcessTime)", Con);
                cmd.Parameters.AddWithValue("@ProcessUser", user.UserMail);
                cmd.Parameters.AddWithValue("@ProcessUserId", user.Id);
                cmd.Parameters.AddWithValue("@ProcessType", type);
                cmd.Parameters.AddWithValue("@ProcessTime", DateTime.Now);
                cmd.ExecuteNonQuery();

                Con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Operation Transmitter(params string[] arguments)
        {
            Operation operation = new Operation
            {
                OperationName = arguments[0],
                OperationTable = arguments[1],
                OperationType = arguments[2],
                OperationTime = Convert.ToDateTime(arguments[3]),
                OperationChange = arguments[4],
                OperationUser = arguments[5],
                OperationUserId = Convert.ToInt32(arguments[6])
            };

            return operation;
        }
    }
}
