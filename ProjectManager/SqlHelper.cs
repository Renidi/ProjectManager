using ProjectManager.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace ProjectManager
{
    internal class SqlHelper
    {
        SqlCommand cmd;
        SqlDataReader rd;
        SqlDataAdapter adapter;

        // ACCOUNTING /*
        public bool Login(string userMail, string userPassword)
        {
            try
            {
                using (SqlConnection Con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;"))
                {
                    cmd = new SqlCommand("SELECT * FROM[USER] WHERE USER_MAIL = @USER_MAIL AND USER_PASSWORD = @USER_PASSWORD", Con);
                    cmd.Parameters.AddWithValue("@USER_MAIL", userMail);
                    cmd.Parameters.AddWithValue("@USER_PASSWORD", userPassword);
                    Con.Open();
                    rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        UpdateLastLoginDate(userMail);
                        return true;
                    }
                    Con.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool Register(User user)
        {
            try
            {
                using (SqlConnection Con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;"))
                {
                    cmd = new SqlCommand("INSERT INTO [USER](USER_NAME , USER_SURNAME , USER_MAIL , USER_PASSWORD , USER_REGISTER_DATE , USER_LAST_LOGIN_DATE , USER_SECRET_WORD )" +
                                                            "values(@USER_NAME , @USER_SURNAME , @USER_MAIL , @USER_PASSWORD , @USER_REGISTER_DATE , @USER_LAST_LOGIN_DATE , @USER_SECRET_WORD )", Con);
                    cmd.Parameters.AddWithValue("@USER_NAME", user.UserName);
                    cmd.Parameters.AddWithValue("@USER_SURNAME", user.UserSurname);
                    cmd.Parameters.AddWithValue("@USER_MAIL", user.UserMail);
                    cmd.Parameters.AddWithValue("@USER_PASSWORD", user.UserPassword);
                    cmd.Parameters.AddWithValue("@USER_REGISTER_DATE", user.UserRegisterDate);
                    cmd.Parameters.AddWithValue("@USER_LAST_LOGIN_DATE", user.UserLastLoginDate);
                    cmd.Parameters.AddWithValue("@USER_SECRET_WORD", user.UserSecretWord);
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    return true;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool SecretWordCheck(string userMail, string userSecretWord) 
        {
            try 
            {
                using(SqlConnection Con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;"))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM [USER] WHERE USER_MAIL = @USER_MAIL AND USER_SECRET_WORD = @USER_SECRET_WORD", Con);
                    cmd.Parameters.AddWithValue("@USER_MAIL", userMail);
                    cmd.Parameters.AddWithValue("@USER_SECRET_WORD", userSecretWord);
                    Con.Open();
                    rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        return true;
                    }
                    Con.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }
        public bool ChangePassword(string userMail, string userNewPassword)
        {
            try
            {
                using (SqlConnection Con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;"))
                {
                    SqlCommand cmd = new SqlCommand("UPDATE [USER] SET USER_PASSWORD=@USER_PASSWORD WHERE USER_MAIL=@USER_MAIL", Con);

                    cmd.Parameters.AddWithValue("@USER_PASSWORD", userNewPassword);
                    cmd.Parameters.AddWithValue("@USER_MAIL", userMail);
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    Con.Close();    
                    UpdateLastLoginDate(userMail);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public void UpdateLastLoginDate(string userMail)
        {
            try
            {
                using (SqlConnection Con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;"))
                {
                    SqlCommand cmd = new SqlCommand("UPDATE [USER] SET USER_LAST_LOGIN_DATE=@USER_LAST_LOGIN_DATE WHERE USER_MAIL=@USER_MAIL", Con);
                    cmd.Parameters.AddWithValue("@USER_LAST_LOGIN_DATE", DateTime.Now);
                    cmd.Parameters.AddWithValue("@USER_MAIL", userMail);
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ACCOUNTING */
        // DATA INFO /*
        public DataTable GetDataTable(string table, int userId)
        {
            try
            {
                List<int> authorizedGroupIds = GetAuthorityGroupList(userId);
                using (SqlConnection Con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;"))
                {
                    using(DataTable dt =  new DataTable())
                    {
                        adapter = new SqlDataAdapter("SELECT * FROM [" + table + "] WHERE "+ table +"_CREATOR_ID=@" + table + "_CREATOR_ID", Con);
                        // SELECT * FROM [PROJECT] WHERE PROJECT_CREATOR_ID=@PROJECT_CREATOR_ID
                        adapter.SelectCommand.Parameters.AddWithValue("@" + table + "_CREATOR_ID", userId);
                        adapter.Fill(dt);
                        foreach (var groupId in authorizedGroupIds)
                        {
                            adapter = new SqlDataAdapter("SELECT * FROM [" + table + "] WHERE "+table+"_GROUP_ID=@"+table+"_GROUP_ID ", Con);
                            // SELECT * FROM [PROJECT] WHERE PROJECT_GROUP_ID=@PROJECT_GROUP_ID
                            adapter.SelectCommand.Parameters.AddWithValue("@"+table+"_GROUP_ID",groupId);
                            adapter.Fill(dt);
                            if (dt.Columns.Contains("PROJECT_GROUP_ID"))
                            {
                                int groupIdColumnIndex = dt.Columns["PROJECT_GROUP_ID"].Ordinal;

                                DataColumn newColumn = new DataColumn("PROJECT GROUP", typeof(string));
                                dt.Columns.Add(newColumn);

                                int groupNameColumnIndex = dt.Columns["PROJECT GROUP"].Ordinal;
                                foreach (DataRow dr in dt.Rows)
                                {
                                    int projectGroupId = Convert.ToInt32(dr[groupIdColumnIndex]);
                                    Group tempGroup = new Group();
                                    if (groupId != -1 && projectGroupId != -1)
                                    {
                                        tempGroup = GetGroupInfo(projectGroupId);
                                        dr[groupNameColumnIndex] = tempGroup == null ? "No Group" : tempGroup.GroupName;
                                    }
                                    else
                                    {
                                        dr[groupNameColumnIndex] = "No Group";
                                    }
                                }
                            }
                        }
                        Hashtable hTable = new Hashtable();
                        ArrayList duplicates = new ArrayList();
                        foreach (DataRow dr in dt.Rows)
                        {
                            if (hTable.Contains(dr[table + "_ID"]))
                            {
                                duplicates.Add(dr);
                            }
                            else
                            {
                                hTable.Add(dr[table + "_ID"],string.Empty);
                            }
                        }
                        foreach (DataRow dr in duplicates)
                            dt.Rows.Remove(dr);

                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
        private List<int> GetAuthorityGroupList(int userId)
        {
            List<int> groupIdList = new List<int>();
            try
            {
                
                using (SqlConnection Con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;"))
                {
                    cmd = new SqlCommand("SELECT GROUP_ID,USER_GROUP_AUTHORIZATION FROM [USER_GROUPS] WHERE USER_ID=@USER_ID", Con);
                    cmd.Parameters.AddWithValue("@USER_ID",userId);
                    using (Con)
                    {
                        Con.Open();
                        using (SqlDataReader rd = cmd.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                int authLevel = Convert.ToInt32(rd["USER_GROUP_AUTHORIZATION"]); // 0 invited, others member
                                if (authLevel > 0)
                                {
                                    groupIdList.Add(rd.GetInt32(0));
                                }
                            }
                        }
                        Con.Close();
                    }
                    return groupIdList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return groupIdList;
        }
        
        public User GetUserInfo(int userId,string userMail=null)
        {
            
            try
            {
                using (SqlConnection Con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;"))
                {
                    if (userId != -1)
                    {
                        cmd = new SqlCommand("SELECT * FROM [USER] WHERE USER_ID=@USER_ID", Con);
                        cmd.Parameters.AddWithValue("@USER_ID", userId);
                    }
                    else
                    {
                        cmd = new SqlCommand("SELECT * FROM [USER] WHERE USER_MAIL=@USER_MAIL", Con);
                        cmd.Parameters.AddWithValue("@USER_MAIL", userMail);
                    }
                    Con.Open();
                    using (rd = cmd.ExecuteReader()) 
                    {
                        while(rd.Read())
                        {
                            User user = new User()
                            {
                                UserId = Convert.ToInt32(rd["USER_ID"]),
                                UserName = rd["USER_NAME"].ToString(),
                                UserSurname = rd["USER_SURNAME"].ToString(),
                                UserMail = rd["USER_MAIL"].ToString(),
                                UserRegisterDate = Convert.ToDateTime(rd["USER_REGISTER_DATE"].ToString()),
                                UserLastLoginDate = Convert.ToDateTime(rd["USER_LAST_LOGIN_DATE"].ToString()),
                            };
                            return user;
                        }
                    }
                    Con.Close();
                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }
        public List<User> GetUserList(int userId,int filteredGroupId = -1)
        {
            try
            {
                using (SqlConnection Con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;"))
                {
                    List<int> userIdList = new List<int>();
                    List<User> userList = new List<User>();
                    List<int> authorizedGroupIds = GetAuthorityGroupList(userId);

                    void innerFunc(int innerGroupId)
                    {
                        cmd = new SqlCommand("SELECT USER_ID,USER_GROUP_AUTHORIZATION FROM [USER_GROUPS] WHERE GROUP_ID=@GROUP_ID", Con);
                        cmd.Parameters.AddWithValue("@GROUP_ID", innerGroupId);
                        Con.Open();
                        using (rd = cmd.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                if (Convert.ToInt32(rd["USER_GROUP_AUTHORIZATION"]) > 0) // 0 invited, others member
                                {
                                    userIdList.Add(Convert.ToInt32(rd["USER_ID"]));
                                }
                            }
                        }
                        Con.Close();
                    }

                    if (filteredGroupId != -1)
                    {
                        foreach (var groupId in authorizedGroupIds)
                        {
                            innerFunc(groupId);
                        }
                    }
                    else
                    {
                        innerFunc(filteredGroupId);
                    }

                    userIdList = userIdList.Distinct().ToList(); // Remove duplicates
                    foreach(int tempUserId in userIdList)
                    {
                        userList.Add(GetUserInfo(tempUserId));
                    }
                    
                    return userList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }
        public List<User> GetGroupUserList(int groupId)
        {
            try
            {
                using (SqlConnection Con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;"))
                {
                    cmd = new SqlCommand("SELECT USER_ID,USER_GROUP_AUTHORIZATION FROM [USER_GROUPS] WHERE GROUP_ID=@GROUP_ID", Con);
                    cmd.Parameters.AddWithValue("@GROUP_ID",groupId);
                    Con.Open();
                    using (rd = cmd.ExecuteReader())
                    {
                        var tempUserIdList = new List<int>();
                        List<User> userList = new List<User>();
                        while(rd.Read())
                        {
                            if (rd.GetInt32(1)>0) // USER_GROUP_AUTHORIZATION = 0 invited 
                                tempUserIdList.Add(rd.GetInt32(0));
                        }
                        
                        foreach(int userId in tempUserIdList)
                        {
                            User user = GetUserInfo(userId);
                            userList.Add(user);
                        }
                        Con.Close();
                        return userList;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
        public Project GetProjectInfo(int projectId)
        {
            try
            {
                using (SqlConnection Con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;"))
                {
                    cmd = new SqlCommand("SELECT * FROM [PROJECT] WHERE PROJECT_ID=@PROJECT_ID", Con);
                    cmd.Parameters.AddWithValue("@PROJECT_ID",projectId);
                    Con.Open();
                    using (rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            Project project = new Project()
                            {
                                ProjectId = Convert.ToInt32(rd["PROJECT_ID"]),
                                ProjectName = rd["PROJECT_NAME"].ToString(),
                                ProjectStatus = rd["PROJECT_STATUS"].ToString(),
                                ProjectPriority = rd["PROJECT_PRIORITY"].ToString(),
                                ProjectStartDate = Convert.ToDateTime(rd["PROJECT_START_DATE"]),
                                ProjectEndDate = Convert.ToDateTime(rd["PROJECT_END_DATE"]),
                                ProjectDuration = Convert.ToInt32(rd["PROJECT_DURATION"]),
                                ProjectGroupId = Convert.ToInt32(rd["PROJECT_GROUP_ID"]),
                                ProjectCreatorId = Convert.ToInt32(rd["PROJECT_CREATOR_ID"]),
                                ProjectDescription = rd["PROJECT_DESCRIPTION"].ToString(),
                            };
                            return project;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }
        public Task GetTaskInfo(int taskId)
        {
            try
            {
                using (SqlConnection Con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;"))
                {
                    cmd = new SqlCommand("SELECT * FROM [TASK] WHERE TASK_ID = @TASK_ID",Con);
                    cmd.Parameters.AddWithValue("@TASK_ID",taskId);
                    Con.Open();
                    using (rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            Task task = new Task()
                            {
                                TaskId = Convert.ToInt32(rd["TASK_ID"]),
                                TaskName = rd["TASK_NAME"].ToString(),
                                TaskStatus = rd["TASK_STATUS"].ToString(),
                                TaskPriority = rd["TASK_PRIORITY"].ToString(),
                                TaskStartDate = Convert.ToDateTime(rd["TASK_START_DATE"]),
                                TaskEndDate = Convert.ToDateTime(rd["TASK_END_DATE"]),
                                TaskDuration = Convert.ToInt32(rd["TASK_DURATION"]),
                                TaskOwnerId = Convert.ToInt32(rd["TASK_OWNER_ID"]),
                                TaskCreatorId = Convert.ToInt32(rd["TASK_CREATOR_ID"]),
                                TaskGroupId = Convert.ToInt32(rd["TASK_GROUP_ID"]),
                                TaskDescription = rd["TASK_DESCRIPTION"].ToString(),
                            };
                            Con.Close();
                            return task;
                        }
                    }
                       
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
        public List<Task> GetTasks(int userId)
        {
            try
            {
                using (SqlConnection Con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;"))
                {
                    List<int> authGroupIdList = GetAuthorityGroupList(userId);
                    List<int> taskIdList = new List<int>();
                    List<Task> tasks = new List<Task>(); 
                    foreach (var authGroupId in authGroupIdList)
                    {
                        cmd = new SqlCommand("SELECT TASK_ID FROM [TASK] WHERE TASK_GROUP_ID=@TASK_GROUP_ID OR TASK_CREATOR_ID=@TASK_CREATOR_ID OR TASK_OWNER_ID=@TASK_OWNER_ID ", Con);
                        cmd.Parameters.AddWithValue("@TASK_GROUP_ID",authGroupId);
                        cmd.Parameters.AddWithValue("@TASK_CREATOR_ID", userId);
                        cmd.Parameters.AddWithValue("@TASK_OWNER_ID",userId);
                        Con.Open();
                        using (rd = cmd.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                taskIdList.Add(rd.GetInt32(0));
                                //tasks.Add( GetTaskInfo(rd.GetInt32(0)) );
                            }
                        }
                        Con.Close();
                    }
                    foreach(int taskId in taskIdList)
                    {
                        tasks.Add(GetTaskInfo(taskId));
                    }
                    return tasks;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }
        public List<Project> GetProjects(int userId)
        {
            try
            {
                using (SqlConnection Con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;"))
                {
                    List<int> authorizedGroupIds = GetAuthorityGroupList(userId);
                    List<int> projectIdList = new List<int>();
                    List<Project> projects = new List<Project>();
                    cmd = new SqlCommand("SELECT PROJECT_ID FROM [PROJECT] WHERE PROJECT_CREATOR_ID=@PROJECT_CREATOR_ID", Con);
                    cmd.Parameters.AddWithValue("@PROJECT_CREATOR_ID",userId);
                    Con.Open();
                    using (rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            projectIdList.Add(rd.GetInt32(0));
                        }
                    }
                    Con.Close();
                    foreach (int groupId in authorizedGroupIds)
                    {
                        cmd = new SqlCommand("SELECT PROJECT_ID FROM [PROJECT] WHERE PROJECT_GROUP_ID=@PROJECT_GROUP_ID", Con);
                        cmd.Parameters.AddWithValue("@PROJECT_GROUP_ID",groupId);
                        Con.Open();
                        using(rd = cmd.ExecuteReader())
                        {   
                            while (rd.Read())
                            {
                                projectIdList.Add(rd.GetInt32(0));
                            }
                        }
                        Con.Close();
                    }
                    projectIdList = projectIdList.Distinct().ToList();
                    foreach(int projectId in projectIdList)
                    {
                        projects.Add( GetProjectInfo(projectId) );
                    }

                    return projects;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            return null;
        }
        public Group GetGroupInfo(int groupId)
        {
            try
            {
                using (SqlConnection Con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;"))
                {
                    cmd = new SqlCommand("SELECT * FROM [GROUP] WHERE GROUP_ID=@GROUP_ID", Con);
                    cmd.Parameters.AddWithValue("@GROUP_ID", groupId);
                    Con.Open();
                    using (rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            Group group = new Group()
                            {
                                GroupId = (int)rd["GROUP_ID"],
                                GroupName = rd["GROUP_NAME"].ToString(),
                                GroupFounderId = (int)rd["GROUP_FOUNDER_ID"],
                                GroupManagerId = (int)rd["GROUP_MANAGER_ID"],
                                GroupDescription = rd["GROUP_DESCRIPTION"].ToString(),
                                GroupFormationDate = Convert.ToDateTime(rd["GROUP_FORMATION_DATE"])
                            };
                            return group;
                        }
                    }
                    Con.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return null;
        }

        public List<UserGroup> GetTeams(int userId,int filteredGroupId = -1)
        {
            try
            {
                using (SqlConnection Con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;"))
                {
                    List<UserGroup> userGroups = new List<UserGroup>();
                    if (filteredGroupId == -1)
                    {
                        cmd = new SqlCommand("SELECT * FROM [USER_GROUPS] WHERE USER_ID=@USER_ID", Con);
                        cmd.Parameters.AddWithValue("@USER_ID", userId);
                    }
                    else
                    {
                        cmd = new SqlCommand("SELECT * FROM [USER_GROUPS] WHERE USER_ID=@USER_ID AND GROUP_ID=@GROUP_ID", Con);
                        cmd.Parameters.AddWithValue("@USER_ID", userId);
                        cmd.Parameters.AddWithValue("@GROUP_ID", filteredGroupId);
                    }
                    
                    Con.Open();
                    using(rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())// USER_GROUP_ID / USER_ID / GROUP_ID / USER_GROUP_AUTH / INVITE_DATE / PROCESS_DATE / INVITE_SENDER_ID / INVITE_STATUS
                        {               //         0     /    1    /    2     /        3        /      4      /      5       /       6          /       7
                            userGroups.Add(new UserGroup()
                            {
                                UserGroupId = rd.GetInt32(0),
                                UserId = rd.GetInt32(1),
                                GroupId = rd.GetInt32(2),
                                UserGroupAuthorization = rd.GetInt32(3),
                                InviteDate = rd.GetDateTime(4),
                                InviteSenderId = rd.GetInt32(6),
                                InviteStatus = rd.GetString(7),
                            });
                        }
                    }
                    Con.Close();
                    userGroups = userGroups.Distinct().ToList();// Remove duplicates
                    return userGroups;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }
        public (int,int) GetProjectAndTaskCounts(int groupId)
        {//  Project,Task
            int counterProject = 0;
            int counterTask = 0;
            try
            {
                using (SqlConnection Con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;"))
                {
                    using (Con)
                    {
                        List<string> tableList = new List<string>() { "PROJECT", "TASK" };
                        foreach (string table in tableList)
                        {
                            cmd = new SqlCommand("SELECT COUNT(" + table + "_GROUP_ID) FROM [" + table + "] WHERE " + table + "_GROUP_ID=@" + table + "_GROUP_ID", Con);
                            //                    SELECT COUNT(PROJECT_GROUP_ID) FROM [PROJECT] WHERE PROJECT_GROUP_ID=@PROJECT_GROUP_ID
                            cmd.Parameters.AddWithValue("@" + table + "_GROUP_ID", groupId);
                            Con.Open();
                            cmd.ExecuteNonQuery();
                            if (table == "PROJECT")
                                counterProject = Convert.ToInt32(cmd.ExecuteScalar());

                            else
                                counterTask = Convert.ToInt32(cmd.ExecuteScalar());
                            Con.Close();

                        }

                        return (counterProject, counterTask);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return (counterProject,counterTask);
        }
        public int GetTaskCounts(int projectId) 
        {
            var counter = 0;
            using (SqlConnection Con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;"))
            {
                using (Con)
                {
                    using (cmd = new SqlCommand("SELECT COUNT(TASK_PROJECT_ID) FROM [TASK] WHERE TASK_PROJECT_ID=@TASK_PROJECT_ID", Con))
                    {
                        cmd.Parameters.AddWithValue("@TASK_PROJECT_ID",projectId);
                        Con.Open();
                        cmd.ExecuteNonQuery ();
                        counter = Convert.ToInt32(cmd.ExecuteScalar());
                        Con.Close();
                        return counter;
                    }
                }
            }
        }
        public Group GetTeamInfo(Group group)
        {
            try
            {
                using (SqlConnection Con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;"))
                {
                    if(group.GroupName != null || group.GroupName != "")
                    {
                        cmd = new SqlCommand("SELECT * FROM [GROUP] WHERE GROUP_NAME=@GROUP_NAME AND GROUP_FOUNDER_ID=@GROUP_FOUNDER_ID AND GROUP_FORMATION_DATE=@GROUP_FORMATION_DATE", Con);
                        cmd.Parameters.AddWithValue("@GROUP_NAME", group.GroupName);
                        cmd.Parameters.AddWithValue("@GROUP_FOUNDER_ID", group.GroupFounderId);
                        cmd.Parameters.AddWithValue("@GROUP_FORMATION_DATE", group.GroupFormationDate);
                    }
                    else
                    {
                        cmd = new SqlCommand("SELECT * FROM [GROUP] WHERE GROUP_ID=@GROUP_ID", Con);
                        cmd.Parameters.AddWithValue("@GROUP_ID", group.GroupId);
                    }

                    Con.Open();
                    using (rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            Group returnGroupInfo = new Group()
                            {
                                GroupId = Convert.ToInt32(rd["GROUP_ID"]),
                                GroupName = rd["GROUP_NAME"].ToString(),
                                GroupFounderId = Convert.ToInt32(rd["GROUP_FOUNDER_ID"]),
                                GroupManagerId = Convert.ToInt32(rd["GROUP_MANAGER_ID"]),
                                GroupDescription = rd["GROUP_DESCRIPTION"].ToString(),
                                GroupFormationDate = Convert.ToDateTime(rd["GROUP_FORMATION_DATE"]),
                            };
                            return returnGroupInfo;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        // DATA INFO */
        // CREATE DATA /*
        public bool NewProject(Project project)
        {
            try
            {
                using (SqlConnection Con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;"))
                {
                    cmd = new SqlCommand("INSERT INTO [PROJECT](PROJECT_NAME,PROJECT_STATUS,PROJECT_PRIORITY,PROJECT_START_DATE,PROJECT_END_DATE,PROJECT_DURATION,PROJECT_GROUP_ID,PROJECT_CREATOR_ID,PROJECT_DESCRIPTION)" +
                                                     "values(@PROJECT_NAME,@PROJECT_STATUS,@PROJECT_PRIORITY,@PROJECT_START_DATE,@PROJECT_END_DATE,@PROJECT_DURATION,@PROJECT_GROUP_ID,@PROJECT_CREATOR_ID,@PROJECT_DESCRIPTION)", Con);
                    cmd.Parameters.AddWithValue("@PROJECT_NAME", project.ProjectName);
                    cmd.Parameters.AddWithValue("@PROJECT_STATUS", project.ProjectStatus);
                    cmd.Parameters.AddWithValue("@PROJECT_PRIORITY", project.ProjectPriority);
                    cmd.Parameters.AddWithValue("@PROJECT_START_DATE", project.ProjectStartDate);
                    cmd.Parameters.AddWithValue("@PROJECT_END_DATE", project.ProjectEndDate);
                    cmd.Parameters.AddWithValue("@PROJECT_DURATION", project.ProjectDuration);
                    cmd.Parameters.AddWithValue("@PROJECT_GROUP_ID", project.ProjectGroupId);
                    cmd.Parameters.AddWithValue("@PROJECT_CREATOR_ID", project.ProjectCreatorId);
                    cmd.Parameters.AddWithValue("@PROJECT_DESCRIPTION", project.ProjectDescription);
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool NewTask(Task task) 
        {
            try
            {
                using (SqlConnection Con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;"))
                {
                    cmd = new SqlCommand("INSERT INTO [TASK](TASK_NAME,TASK_STATUS,TASK_PRIORITY,TASK_START_DATE,TASK_END_DATE,TASK_DURATION,TASK_OWNER_ID,TASK_CREATOR_ID,TASK_PROJECT_ID,TASK_GROUP_ID,TASK_DESCRIPTION)" +
                                              "values(@TASK_NAME,@TASK_STATUS,@TASK_PRIORITY,@TASK_START_DATE,@TASK_END_DATE,@TASK_DURATION,@TASK_OWNER_ID,@TASK_CREATOR_ID,@TASK_PROJECT_ID,@TASK_GROUP_ID,@TASK_DESCRIPTION)", Con);
                    cmd.Parameters.AddWithValue("@TASK_NAME", task.TaskName);
                    cmd.Parameters.AddWithValue("@TASK_STATUS", task.TaskStatus);
                    cmd.Parameters.AddWithValue("@TASK_PRIORITY", task.TaskPriority);
                    cmd.Parameters.AddWithValue("@TASK_START_DATE", task.TaskStartDate);
                    cmd.Parameters.AddWithValue("@TASK_END_DATE", task.TaskEndDate);
                    cmd.Parameters.AddWithValue("@TASK_DURATION", task.TaskDuration);
                    cmd.Parameters.AddWithValue("@TASK_OWNER_ID", task.TaskOwnerId);
                    cmd.Parameters.AddWithValue("@TASK_CREATOR_ID", task.TaskCreatorId);
                    cmd.Parameters.AddWithValue("@TASK_PROJECT_ID", task.TaskProjectId);
                    cmd.Parameters.AddWithValue("@TASK_GROUP_ID", task.TaskGroupId);
                    cmd.Parameters.AddWithValue("@TASK_DESCRIPTION", task.TaskDescription);
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool NewTeam(Group group)
        {
            try
            {
                using (SqlConnection Con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;"))
                {
                    cmd = new SqlCommand("INSERT INTO [GROUP](GROUP_NAME , GROUP_FOUNDER_ID , GROUP_MANAGER_ID , GROUP_DESCRIPTION , GROUP_FORMATION_DATE)" +
                                                     "values(@GROUP_NAME, @GROUP_FOUNDER_ID, @GROUP_MANAGER_ID, @GROUP_DESCRIPTION , @GROUP_FORMATION_DATE)", Con);
                    cmd.Parameters.AddWithValue("@GROUP_NAME", group.GroupName);
                    cmd.Parameters.AddWithValue("@GROUP_FOUNDER_ID", group.GroupFounderId);
                    cmd.Parameters.AddWithValue("@GROUP_MANAGER_ID", group.GroupManagerId);
                    cmd.Parameters.AddWithValue("@GROUP_DESCRIPTION", group.GroupDescription);
                    cmd.Parameters.AddWithValue("@GROUP_FORMATION_DATE", group.GroupFormationDate);
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    group = GetTeamInfo(group);

                    UserGroup userGroup = new UserGroup()
                    {
                        UserId = group.GroupFounderId,
                        GroupId = group.GroupId,
                        UserGroupAuthorization = 3,//3 - owner / 2 - admin / 1 - member / 0 - viewer (invited)
                        InviteDate = DateTime.Now,
                        ProcessDate = DateTime.Now,
                        InviteSenderId = group.GroupManagerId,
                        InviteStatus = "Accepted", // -Rejected -Accepted -Waiting
                    };
                    TeamInvite(userGroup);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }
        public bool TeamInvite(UserGroup userGroup)
        {
            try
            {
                using (SqlConnection Con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;"))
                {
                    cmd = new SqlCommand("INSERT INTO [USER_GROUPS](USER_ID , GROUP_ID , USER_GROUP_AUTHORIZATION , INVITE_DATE , INVITE_SENDER_ID , INVITE_STATUS )" +
                                                           "values(@USER_ID, @GROUP_ID, @USER_GROUP_AUTHORIZATION, @INVITE_DATE , @INVITE_SENDER_ID, @INVITE_STATUS )", Con);
                    cmd.Parameters.AddWithValue("@USER_ID", userGroup.UserId);
                    cmd.Parameters.AddWithValue("@GROUP_ID", userGroup.GroupId);
                    cmd.Parameters.AddWithValue("@USER_GROUP_AUTHORIZATION ", userGroup.UserGroupAuthorization);
                    cmd.Parameters.AddWithValue("@INVITE_DATE", userGroup.InviteDate);
                    cmd.Parameters.AddWithValue("@INVITE_SENDER_ID", userGroup.InviteSenderId);
                    cmd.Parameters.AddWithValue("@INVITE_STATUS", userGroup.InviteStatus);
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        // CREATE DATA */
        // EDIT DATA /*
        public bool HandleGroupInvitation(UserGroup userGroup)
        {
            try
            {
                using (SqlConnection Con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;"))
                {
                    cmd = new SqlCommand("UPDATE [USER_GROUPS] SET USER_GROUP_AUTHORIZATION=@USER_GROUP_AUTHORIZATION , USER_INVITE_STATUS=@USER_INVITE_STATUS , USER_JOIN_DATE=@USER_JOIN_DATE WHERE USER_GROUP_ID=@USER_GROUP_ID", Con);
                    cmd.Parameters.AddWithValue("@USER_GROUP_AUTHORIZATION", userGroup.UserGroupAuthorization);
                    cmd.Parameters.AddWithValue("@PROCESS_DATE", userGroup.ProcessDate);
                    cmd.Parameters.AddWithValue("@USER_INVITE_STATUS", userGroup.InviteStatus);

                    Con.Open();
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public static T EditGenericData<T>(T entitiyData)
        {
            // Yaplıcak
            return (T)Convert.ChangeType(null, typeof(T));
        }
        public bool EditData(Project project=null,Task task=null,UserGroup userGroup=null)
        { // Edit project or task
            try
            {
                using (SqlConnection Con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;"))
                {
                    if (task == null)
                    {
                        cmd = new SqlCommand("UPDATE [PROJECT] SET PROJECT_NAME=@PROJECT_NAME,PROJECT_STATUS=PROJECT_STATUS,PROJECT_PRIORITY=@PROJECT_PRIORITY," +
                                        "PROJECT_END_DATE=@PROJECT_END_DATE, PROJECT_DURATION=@PROJECT_DURATION ,PROJECT_GROUP_ID=@PROJECT_GROUP_ID," +
                                        "PROJECT_CREATOR_ID=@PROJECT_CREATOR_ID,PROJECT_DESCRIPTION=@PROJECT_DESCRIPTION WHERE PROJECT_ID=@PROJECT_ID", Con);
                        cmd.Parameters.AddWithValue("@PROJECT_NAME", project.ProjectName);
                        cmd.Parameters.AddWithValue("@PROJECT_STATUS", project.ProjectStatus);
                        cmd.Parameters.AddWithValue("@PROJECT_PRIORITY", project.ProjectPriority);
                        cmd.Parameters.AddWithValue("@PROJECT_START_DATE", project.ProjectStartDate);
                        cmd.Parameters.AddWithValue("@PROJECT_END_DATE", project.ProjectEndDate);
                        cmd.Parameters.AddWithValue("@PROJECT_DURATION", project.ProjectDuration);
                        cmd.Parameters.AddWithValue("@PROJECT_GROUP_ID", project.ProjectGroupId);
                        cmd.Parameters.AddWithValue("@PROJECT_CREATOR_ID", project.ProjectCreatorId);
                        cmd.Parameters.AddWithValue("@PROJECT_DESCRIPTION", project.ProjectDescription);
                        cmd.Parameters.AddWithValue("@PROJECT_ID", project.ProjectId);
                        Con.Open();
                        cmd.ExecuteNonQuery();
                        Con.Close();
                        return true;
                    }
                    else if (userGroup != null)
                    {
                        cmd = new SqlCommand("UPDATE [USER_GROUPS] SET PROCESS_DATE=@PROCESS_DATE , INVITE_STATUS=@INVITE_STATUS , USER_GROUP_AUTHORIZATION=@USER_GROUP_AUTHORIZATION", Con);
                        cmd.Parameters.AddWithValue("@PROCESS_DATE=@PROCESS_DATE",userGroup.ProcessDate); // DateTime.Now
                        cmd.Parameters.AddWithValue("@INVITE_STATUS",userGroup.InviteStatus);
                        cmd.Parameters.AddWithValue("@USER_GROUP_AUTHORIZATION",userGroup.UserGroupAuthorization);
                        Con.Open();
                        cmd.ExecuteNonQuery();
                        Con.Close();
                        return true;
                    }
                    else
                    {
                        cmd = new SqlCommand("UPDATE [TASK] SET TASK_NAME = @TASK_NAME, TASK_STATUS = @TASK_STATUS, TASK_PRIORITY = @TASK_PRIORITY , " +
                                             "TASK_START_DATE = @TASK_START_DATE , TASK_END_DATE = @TASK_END_DATE, TASK_DURATION = @TASK_DURATION , TASK_OWNER_ID = @TASK_OWNER_ID , " +
                                             "TASK_PROJECT_ID = @TASK_PROJECT_ID , TASK_GROUP_ID = @TASK_GROUP_ID , TASK_DESCRIPTION = @TASK_DESCRIPTION WHERE TASK_ID = @TASK_ID", Con);
                        cmd.Parameters.AddWithValue("@TASK_NAME", task.TaskName);
                        cmd.Parameters.AddWithValue("@TASK_STATUS", task.TaskStatus);
                        cmd.Parameters.AddWithValue("@TASK_PRIORITY", task.TaskPriority);
                        cmd.Parameters.AddWithValue("@TASK_START_DATE", task.TaskStartDate);
                        cmd.Parameters.AddWithValue("@TASK_END_DATE", task.TaskEndDate);
                        cmd.Parameters.AddWithValue("@TASK_DURATION", task.TaskDuration);
                        cmd.Parameters.AddWithValue("@TASK_OWNER_ID", task.TaskOwnerId);
                        cmd.Parameters.AddWithValue("@TASK_PROJECT_ID", task.TaskProjectId);
                        cmd.Parameters.AddWithValue("@TASK_GROUP_ID", task.TaskGroupId);
                        cmd.Parameters.AddWithValue("@TASK_DESCRIPTION", task.TaskDescription);
                        cmd.Parameters.AddWithValue("@TASK_ID",task.TaskId);
                        Con.Open();
                        cmd.ExecuteNonQuery();
                        Con.Close();
                        return true;
                    }

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool DeleteData(string table,int itemId)
        {
            try
            {
                using (SqlConnection Con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;"))
                {
                    cmd = new SqlCommand("DELETE FROM ["+table+"] WHERE "+table+"_ID = @"+table+"_ID",Con);
                    cmd.Parameters.AddWithValue("@"+table+"_ID",itemId);
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    Con.Close();

                    if (table == "PROJECT")
                        DeleteSubTasks(itemId);

                    return true;
                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        private void DeleteSubTasks(int itemId)
        {
            try
            {
                using (SqlConnection Con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;"))
                {
                    cmd = new SqlCommand("DELETE FROM [TASK] WHERE TASK_PROJECT_ID = @TASK_PROJECT_ID");
                    cmd.Parameters.AddWithValue("@TASK_PROJECT_ID",itemId);
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // EDIT DATA */
        // DATA LOG /*
        public void DataLog(Log log)
        {
            if (log.LogStatus.ToLower() == "true")
                log.LogStatus = "Successful";
            else
                log.LogStatus = "Fail";

            try
            {
                using (SqlConnection Con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;"))
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO [LOG_DATA](LOG_SOURCE , LOG_TYPE , LOG_DATE , LOG_USER , LOG_USER_ID , LOG_DESCRIPTION , LOG_STATUS)" +
                                                               "values(@LOG_SOURCE,@LOG_TYPE,@LOG_DATE,@LOG_USER,@LOG_USER_ID,@LOG_DESCRIPTION,@LOG_STATUS)", Con);
                    cmd.Parameters.AddWithValue("@LOG_SOURCE", log.LogSource);
                    cmd.Parameters.AddWithValue("@LOG_TYPE", log.LogType);
                    cmd.Parameters.AddWithValue("@LOG_DATE", log.LogDate);
                    cmd.Parameters.AddWithValue("@LOG_USER", log.LogUser);
                    cmd.Parameters.AddWithValue("@LOG_USER_ID", log.LogUserId);
                    cmd.Parameters.AddWithValue("@LOG_DESCRIPTION", log.LogDescription);
                    cmd.Parameters.AddWithValue("@LOG_STATUS", log.LogStatus);

                    cmd.ExecuteNonQuery();
                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // DATA LOG */
    }
}
