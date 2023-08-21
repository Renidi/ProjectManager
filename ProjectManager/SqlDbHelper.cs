using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Web.UI.WebControls;
using ProjectManager.Entities;
using System.Data.SqlTypes;

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

                        if (dt.Columns.Contains("PROJECT_GROUP_ID"))
                        {
                            int groupIdColumnIndex = dt.Columns["PROJECT_GROUP_ID"].Ordinal;
                            
                            DataColumn newColumn = new DataColumn("PROJECT GROUP", typeof(string));
                            dt.Columns.Add(newColumn);

                            int groupNameColumnIndex = dt.Columns["PROJECT GROUP"].Ordinal;
                            foreach (DataRow dr in dt.Rows)
                            {
                                int groupId = Convert.ToInt32(dr[groupIdColumnIndex]);
                                Group tempGroup = new Group
                                {
                                    GroupId = groupId
                                };
                                if (groupId != -1)
                                {
                                    tempGroup = TakeInformationOfGroup(tempGroup);
                                    dr[groupNameColumnIndex] = tempGroup.GroupName == null ? "No Group" : tempGroup.GroupName;
                                }
                                else
                                {
                                    dr[groupNameColumnIndex] = "No Group"; 
                                }
                                
                            }
                        }

                        
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
                
                SqlCommand cmd = new SqlCommand("INSERT INTO [PROJECT](PROJECT_NAME,PROJECT_STATUS,PROJECT_PRIORITY,PROJECT_START_DATE,PROJECT_END_DATE,PROJECT_DURATION,PROJECT_CREATOR,PROJECT_DESCRIPTION,PROJECT_GROUP_ID)" +
                                                                "values(@PROJECT_NAME,@PROJECT_STATUS,@PROJECT_PRIORITY,@PROJECT_START_DATE,@PROJECT_END_DATE,@PROJECT_DURATION,@PROJECT_CREATOR,@PROJECT_DESCRIPTION,@PROJECT_GROUP_ID)", Con);

                cmd.Parameters.AddWithValue("@PROJECT_NAME", project.ProjectName);
                cmd.Parameters.AddWithValue("@PROJECT_STATUS", project.ProjectStatus);
                cmd.Parameters.AddWithValue("@PROJECT_PRIORITY", project.ProjectPriority);
                cmd.Parameters.AddWithValue("@PROJECT_START_DATE", project.ProjectStartDate);
                cmd.Parameters.AddWithValue("@PROJECT_END_DATE", project.ProjectEndDate);
                cmd.Parameters.AddWithValue("@PROJECT_DURATION", project.ProjectDuration);
                cmd.Parameters.AddWithValue("@PROJECT_CREATOR", project.ProjectCreator);
                cmd.Parameters.AddWithValue("@PROJECT_DESCRIPTION", project.ProjectDescription);
                cmd.Parameters.AddWithValue("@PROJECT_GROUP_ID", project.ProjectGroupId);
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
                cmd.Parameters.AddWithValue("@TASK_gROUP_ID", task.TaskGroupId);
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
        public List<UserGroup> TakeUserGroupInfo(List<User> userList, int groupId)
        {
            List<UserGroup> userGroupInfo = new List<UserGroup>();

            SqlConnection Con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;");
            SqlCommand cmd;
            try
            {
                using (Con)
                {
                    foreach (User user in userList)
                    {
                        cmd = new SqlCommand("SELECT * FROM [USER_GROUPS] WHERE USER_ID=@USER_ID AND GROUP_ID=@GROUP_ID", Con);
                        cmd.Parameters.AddWithValue("@GROUP_ID", groupId);
                        cmd.Parameters.AddWithValue("@USER_ID", user.UserId);
                        Con.Open();
                        SqlDataReader rd = cmd.ExecuteReader();
                        while (rd.Read())
                        {
                            UserGroup userGroup = new UserGroup();
                            userGroup.UserGroupId = Convert.ToInt32(rd["USER_GROUP_ID"]);
                            userGroup.UserId = Convert.ToInt32(rd["USER_ID"]);
                            userGroup.GroupId = Convert.ToInt32(rd["GROUP_ID"]);
                            userGroup.UserGroupAuthorization = Convert.ToInt32(rd["USER_GROUP_AUTHORIZATION"]);
                            userGroup.UserJoinDate = Convert.ToDateTime(rd["USER_JOIN_DATE"]);
                            userGroup.InviteSenderId = Convert.ToInt32(rd["INVITE_SENDER_ID"]);
                            userGroup.InviteStatus = rd["INVITE_STATUS"].ToString();
                            userGroupInfo.Add(userGroup);
                        }
                        Con.Close();
                    }
                    return userGroupInfo;

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Con.Close();
            return userGroupInfo;
        }
        public List<User> TakeUserListForComboBox(Group group)
        {
            List<User> userList = new List<User>();
            List<int> tempList = new List<int>();
            SqlConnection Con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;");
            SqlCommand cmd;
            try
            {
                using (Con)
                {    // if invited ?
                    cmd = new SqlCommand("SELECT USER_ID FROM [USER_GROUPS] WHERE GROUP_ID=@GROUP_ID ",Con);
                    cmd.Parameters.AddWithValue("@GROUP_ID", group.GroupId);
                    Con.Open();
                    SqlDataReader rd = cmd.ExecuteReader();
                    while(rd.Read())
                    {
                        tempList.Add(rd.GetInt32(0));
                    }

                    foreach (int id in tempList)
                    {
                        User userTemp = new User();
                        userTemp.UserId = id;
                        userTemp = UserInfo(userTemp);
                        userList.Add(userTemp);
                    }
                    Con.Close();
                    return userList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Con.Close();
            return userList;
        }
        // combine with project names
        public List<string> TakeEmployeeMails(params string[] arguments)
        {                                                   // arg[0] = userId
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
        public List<Project> TakeProjectList(string userMail, string status)
        {
            List<Project> projectList = new List<Project>();
            List<int> groupIdList = new List<int>();
            SqlConnection Con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;");
            SqlCommand cmd;
            SqlDataReader rd;
            try
            {
                using (Con)
                {
                    cmd= new SqlCommand("SELECT GROUP_ID FROM [USER_GROUPS] WHERE USER_ID=@USER_ID",Con);
                    cmd.Parameters.AddWithValue("@USER_ID", userMail);
                    Con.Open();
                    rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        groupIdList.Add(Convert.ToInt32(rd["GROUP_ID"]));
                    }
                    Con.Close();
                    foreach(int groupId in groupIdList)
                    { // !!
                        cmd = new SqlCommand("SELECT * FROM [PROJECT] WHERE PROJECT_GROUP_ID=@PROJECT_GROUP_ID", Con);
                        
                        cmd.Parameters.AddWithValue("@PROJECT_GROUP_ID",groupId);
                        rd = cmd.ExecuteReader();
                        while (rd.Read())
                        {
                            Project project = new Project();
                            project.ProjectId = rd.GetInt32(0);
                            project.ProjectName = rd.GetString(1);
                            project.ProjectStatus = rd.GetString(2);
                            project.ProjectPriority = rd.GetString(3);
                            project.ProjectStartDate = rd.GetDateTime(4);
                            project.ProjectEndDate = rd.GetDateTime(5);
                            project.ProjectDuration = rd.GetInt32(6);
                            project.ProjectGroupId = rd.GetInt32(7);
                            project.ProjectCreator = rd.GetString(8);
                            project.ProjectDescription = rd.GetString(9);
                            projectList.Add(project);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Con.Close();
            return projectList;
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
                        SqlCommand cmd = new SqlCommand("SELECT PROJECT_NAME , PROJECT_STATUS FROM [" + arguments[0]+"]", Con);

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
                        SqlCommand cmd = new SqlCommand("SELECT PROJECT_NAME , PROJECT_END_DATE , PROJECT_PRIORITY , PROJECT_STATUS FROM [" + arguments[0] + "]", Con);

                        using (SqlDataReader rd = cmd.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                string projectDate = rd.GetDateTime(1).Date.ToString();
                                if (tempDate == projectDate)
                                {
                                    if (rd.GetString(3) != "COMPLETED")
                                    {
                                        list.Add(rd.GetString(0)); // PROJECT_NAME
                                        list.Add(rd.GetString(2)); // PROJECT_PRIORITY
                                    }
                                    
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

        public int GetCount(string tableName,int selectId)
        {
            int counter = 0;

            SqlConnection Con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;");
            Con.Open();
            try
            {
                using (Con)
                {
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(" + tableName + "_ID) FROM [" + tableName + "] WHERE "+ tableName +"_ID=@"+tableName+"_ID", Con);
                    cmd.Parameters.AddWithValue("@"+tableName+"_ID",selectId);
                    cmd.ExecuteNonQuery();
                    counter = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Con.Close();
            return counter;
        }

        public bool Login(string Mail, string Password)
        {
            try
            {
                Con.Open();
                // !?
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
                SqlCommand cmd;

                if (user.UserMail != null)
                {
                    cmd = new SqlCommand("SELECT * FROM [USER] WHERE USER_MAIL=@USER_MAIL", Con);
                    cmd.Parameters.AddWithValue("@USER_MAIL", user.UserMail);
                }
                else
                {
                    cmd = new SqlCommand("SELECT * FROM [USER] WHERE USER_ID=@USER_ID", Con);
                    cmd.Parameters.AddWithValue("@USER_ID", user.UserId);
                }
                
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

        public void UpdateLastLoginDate(string userMail)
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
        // Check twice
        public bool CreateTeam(Group group)
        {
            SqlConnection Con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;");
            UserGroup userGroup = new UserGroup();
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO [GROUP](GROUP_NAME , GROUP_FOUNDER_ID , GROUP_MANAGER_ID , GROUP_DESCRIPTION , GROUP_FORMATION_DATE)" +
                                                            "values(@GROUP_NAME, @GROUP_FOUNDER_ID, @GROUP_MANAGER_ID, @GROUP_DESCRIPTION , @GROUP_FORMATION_DATE)", Con);
                cmd.Parameters.AddWithValue("@GROUP_NAME", group.GroupName);
                cmd.Parameters.AddWithValue("@GROUP_FOUNDER_ID", group.GroupFounderId);
                cmd.Parameters.AddWithValue("@GROUP_MANAGER_ID", group.GroupManagerId);  
                cmd.Parameters.AddWithValue("@GROUP_DESCRIPTION", group.GroupDescription);
                cmd.Parameters.AddWithValue("@GROUP_FORMATION_DATE", group.GroupFormationDate);
                Con.Open();
                cmd.ExecuteNonQuery();
                Con.Close();
                group = TakeInformationOfGroup(group);

                userGroup.UserId = group.GroupFounderId;
                userGroup.GroupId = group.GroupId;
                userGroup.UserGroupAuthorization = 3; //3 - owner / 2 - admin / 1 - member / 0 - viewer (invited)
                userGroup.UserJoinDate = DateTime.Now;
                userGroup.InviteSenderId = group.GroupFounderId;
                userGroup.InviteStatus = "Accepted";

                AddMember(userGroup);
                return true;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool AddMember(UserGroup userGroup)
        {
            SqlConnection Con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;");
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO [USER_GROUPS](USER_ID , GROUP_ID , USER_GROUP_AUTHORIZATION , USER_JOIN_DATE , INVITE_SENDER_ID , INVITE_STATUS )" +
                                                                  "values(@USER_ID, @GROUP_ID, @USER_GROUP_AUTHORIZATION, @USER_JOIN_DATE, @INVITE_SENDER_ID, @INVITE_STATUS )", Con);
                cmd.Parameters.AddWithValue("@USER_ID", userGroup.UserId);
                cmd.Parameters.AddWithValue("@GROUP_ID", userGroup.GroupId);
                cmd.Parameters.AddWithValue("@USER_GROUP_AUTHORIZATION ", userGroup.UserGroupAuthorization);
                cmd.Parameters.AddWithValue("@USER_JOIN_DATE", userGroup.UserJoinDate);
                cmd.Parameters.AddWithValue("@INVITE_SENDER_ID", userGroup.InviteSenderId);
                cmd.Parameters.AddWithValue("@INVITE_STATUS", userGroup.InviteStatus);
                Con.Open();
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

        public bool InviteUser(Team team)
        {
            SqlConnection Con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;");

            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO [USER_GROUPS](USER_ID , GROUP_ID , USER_GROUP_AUTHORIZATION , USER_JOIN_DATE , USER_INVITE_STATUS) " +
                                                                   "values(@USER_ID, @GROUP_ID , @USER_GROUP_AUTHORIZATION, @USER_JOIN_DATE, @USER_INVITE_STATUS)", Con);
                cmd.Parameters.AddWithValue("@USER_ID", team.UserId);
                cmd.Parameters.AddWithValue("GROUP_ID", team.GroupId);
                cmd.Parameters.AddWithValue("@USER_GROUP_AUTHORIZATION", team.UserGroupAuthorization);
                cmd.Parameters.AddWithValue("@USER_JOIN_DATE", team.UserJoinDate);
                cmd.Parameters.AddWithValue("INVITE_SENDER_ID", team.InviteSenderId);
                cmd.Parameters.AddWithValue("@USER_INVITE_STATUS", team.UserInviteStatus);

                Con.Open();
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

        public bool HandleGroupInvitation(Team team, string anahtar)
        {
            SqlConnection Con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;");
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE [USER_GROUPS] SET USER_GROUP_AUTHORIZATION=@USER_GROUP_AUTHORIZATION , USER_INVITE_STATUS=@USER_INVITE_STATUS WHERE USER_GROUP_ID=@USER_GROUP_ID", Con);
                cmd.Parameters.AddWithValue("@USER_GROUP_AUTHORIZATION", team.UserGroupAuthorization);
                cmd.Parameters.AddWithValue("@USER_JOIN_DATE", team.UserJoinDate);
                cmd.Parameters.AddWithValue("INVITE_SENDER_ID", team.InviteSenderId);
                cmd.Parameters.AddWithValue("@USER_INVITE_STATUS", team.UserInviteStatus);
                cmd.Parameters.AddWithValue("@USER_GROUP_ID", team.UserGroupId);

                Con.Open();
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

        public Group TakeInformationOfGroup(Group group)
        {
            try
            {
                SqlConnection Con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;");
                SqlCommand cmd;
                if (group.GroupName != null)
                {
                    cmd = new SqlCommand("SELECT * FROM [GROUP] WHERE GROUP_NAME=@GROUP_NAME AND GROUP_FOUNDER_ID=@GROUP_FOUNDER_ID AND GROUP_FORMATION_DATE=@GROUP_FORMATION_DATE", Con);
                    cmd.Parameters.AddWithValue("@GROUP_NAME", group.GroupName);
                    cmd.Parameters.AddWithValue("@GROUP_FOUNDER_ID", group.GroupFounderId);
                    cmd.Parameters.AddWithValue("@GROUP_FORMATION_DATE", group.GroupFormationDate);
                    Con.Open();
                    
                }
                else
                {
                    cmd = new SqlCommand("SELECT * FROM [GROUP] WHERE GROUP_ID=@GROUP_ID", Con);
                    cmd.Parameters.AddWithValue("@GROUP_ID", group.GroupId);
                    Con.Open();
                    
                }
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        group.GroupId = (int)rd["GROUP_ID"];
                        group.GroupName = rd["GROUP_NAME"].ToString();
                        group.GroupFounderId = (int)rd["GROUP_FOUNDER_ID"];
                        group.GroupManagerId = (int)rd["GROUP_MANAGER_ID"];
                        group.GroupDescription = rd["GROUP_DESCRIPTION"].ToString();
                        group.GroupFormationDate = Convert.ToDateTime(rd["GROUP_FORMATION_DATE"]);
                    }
                }

                Con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return group;
        }

        public List<Team> TakeTeams(int userId) 
        {
            List<Team> teamsList = new List<Team>();
            SqlConnection Con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security = true;");
            Con.Open();
            try
            {
                using (Con)
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM [USER_GROUPS]",Con);
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        
                        while (rd.Read()) // USER_GROUP_ID / USER_ID / GROUP_ID / USER_GROUP_AUTH / USER_JOIN_DATE / INVITE_SENDER_ID / INVITE_STATUS
                        {                 //        0      /    1    /    2     /       3          /      4        /       5          /       6
                            if ( rd.GetInt32(1) == userId )
                            {
                                teamsList.Add(new Team()
                                {
                                    UserGroupId = rd.GetInt32(0),
                                    UserId = rd.GetInt32(1),
                                    GroupId = rd.GetInt32(2),
                                    UserGroupAuthorization = rd.GetInt32(3),
                                    UserJoinDate = rd.GetDateTime(4),
                                    InviteSenderId = rd.GetInt32(5),
                                    UserInviteStatus = rd.GetString(6)
                                });
                                Console.WriteLine(teamsList);
                            }
                        }
                    }
                }
                Con.Close();
                return teamsList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return teamsList;
        }

    }
}
