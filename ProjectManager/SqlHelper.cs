using ProjectManager.Entities;
using System;
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
        SqlConnection Con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;");
        SqlCommand cmd;
        SqlDataReader rd;
        SqlDataAdapter adapter;

        // ACCOUNTING /*
        public bool Login(string userMail, string userPassword)
        {
            try
            {
                using (Con)
                {
                    cmd = new SqlCommand("SELECT * FROM[USER] WHERE USER_MAIL = @USER_MAIL AND USER_PASSWORD = @USER_PASSWORD", Con);
                    cmd.Parameters.AddWithValue("@USER_MAIL", userMail);
                    cmd.Parameters.AddWithValue("@USER_PASSWORD", userPassword);
                    
                    rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        UpdateLastLoginDate(userMail);
                        return true;
                    }
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
                using (Con)
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

                    cmd.ExecuteNonQuery();
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
                using(Con)
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM [USER] WHERE USER_MAIL = @USER_MAIL AND USER_SECRET_WORD = @USER_SECRET_WORD", Con);
                    cmd.Parameters.AddWithValue("@USER_MAIL", userMail);
                    cmd.Parameters.AddWithValue("@USER_SECRET_WORD", userSecretWord);

                    rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        return true;
                    }
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
                using (Con)
                {
                    SqlCommand cmd = new SqlCommand("UPDATE [USER] SET USER_PASSWORD=@USER_PASSWORD WHERE USER_MAIL=@USER_MAIL", Con);

                    cmd.Parameters.AddWithValue("@USER_PASSWORD", userNewPassword);
                    cmd.Parameters.AddWithValue("@USER_MAIL", userMail);
                    cmd.ExecuteNonQuery();

                    UpdateLastLoginDate(userMail);
                    return true;
                }
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
                using (Con)
                {
                    SqlCommand cmd = new SqlCommand("UPDATE [USER] SET USER_LAST_LOGIN_DATE=@USER_LAST_LOGIN_DATE WHERE USER_MAIL=@USER_MAIL", Con);
                    cmd.Parameters.AddWithValue("@USER_LAST_LOGIN_DATE", DateTime.Now);
                    cmd.Parameters.AddWithValue("@USER_MAIL", userMail);
                    cmd.ExecuteNonQuery();
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
                using (Con)
                {
                    using(DataTable dt =  new DataTable())
                    {
                        foreach (var groupId in authorizedGroupIds)
                        {
                            adapter = new SqlDataAdapter("SELECT * FROM [" + table + "] WHERE "+table+"_GROUP_ID=@"+table+"_GROUP_ID " +
                                                        "OR "+table+"_CREATOR_ID=@"+table+"_CREATOR_ID", Con);
                            // SELECT * FROM [PROJECT] WHERE PROJECT_GROUP_ID=@PROJECT_GROUP_ID OR PROJECT_CREATOR_ID=@PROJECT_CREATOR_ID
                            adapter.SelectCommand.Parameters.AddWithValue("@"+table+"GROUP_ID",groupId);
                            adapter.SelectCommand.Parameters.AddWithValue("@"+table+"CREATOR_ID",userId);
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
                                    if (groupId != -1)
                                    {
                                        tempGroup = GetGroupInfo(projectGroupId);
                                        dr[groupNameColumnIndex] = tempGroup.GroupName == null ? "No Group" : tempGroup.GroupName;
                                    }
                                    else
                                    {
                                        dr[groupNameColumnIndex] = "No Group";
                                    }
                                }
                            }
                        }
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
                
                using (Con)
                {
                    cmd = new SqlCommand("SELECT GROUP_ID,USER_GROUP_AUTHORIZATION FROM [USER_GROUPS] WHERE USER_ID=@USER_ID", Con);
                    cmd.Parameters.AddWithValue("@USER_ID",userId);
                    rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        int authLevel = Convert.ToInt32(rd["USER_GROUP_AUTHORIZATION"]); // 0 invited, others member
                        if (authLevel>0) 
                        {
                            groupIdList.Add(rd.GetInt32(0));
                        }
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
                using (Con)
                {
                    if (userId != -1)
                    {
                        cmd = new SqlCommand("SELCET * FROM [USER] WHERE USER_ID=@USER_ID", Con);
                        cmd.Parameters.AddWithValue("@USER_ID", userId);
                    }
                    else
                    {
                        cmd = new SqlCommand("SELECT * FROM [USER] WHERE USER_MAIL=@USER_MAIL", Con);
                        cmd.Parameters.AddWithValue("@USER_MAIL", userMail);
                    }
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
                using (Con)
                {
                    List<int> userIdList = new List<int>();
                    List<User> userList = new List<User>();
                    List<int> authorizedGroupIds = GetAuthorityGroupList(userId);

                    void innerFunc(int innerGroupId)
                    {
                        cmd = new SqlCommand("SELECT USER_ID,USER_GROUP_AUTHORIZATION FROM [USER_GROUPS] WHERE GROUP_ID=@GROUP_ID", Con);
                        cmd.Parameters.AddWithValue("@GROUP_ID", innerGroupId);
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
                using (Con)
                {
                    cmd = new SqlCommand("SELECT USER_ID,USER_GROUP_AUTHORIZATION FROM [USER_GROUPS] WHERE GROUP_ID=@GROUP_ID", Con);
                    cmd.Parameters.AddWithValue("@GROUP_ID",groupId);
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
                using (Con)
                {
                    cmd = new SqlCommand("SELECT * FROM [PROJECT] WHERE PROJECT_ID=@PROJECT_ID", Con);
                    cmd.Parameters.AddWithValue("@PROJECT_ID",projectId);

                    Project project = new Project()
                    {
                        ProjectId = Convert.ToInt32(rd["PROJECT_ID"]),
                        ProjectName = rd["PROJECT_NAME"].ToString(),
                        ProjectStatus = rd["PORJECT_STATUS"].ToString(),
                        ProjectPriority = rd["PROJECT_PRIORITY"].ToString(),
                        ProjectStartDate = Convert.ToDateTime(rd["PROJECT_START_DATE"]),
                        ProjectEndDate = Convert.ToDateTime(rd["PROJECT_END_DATE"]),
                        ProjectDuration = Convert.ToInt32(rd["PROJECT_DURATION"]),
                        ProjectGroupId = Convert.ToInt32(rd["PROJECT_GROUP_ID"]),
                        ProjectCreator = rd["PROJECT_CREATOR"].ToString(),
                        ProjectDescription  = rd["PROJECT_DESCRIPTION"].ToString(),
                    };
                    return project;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }
        public List<Project> GetProjects(string table,int userId)
        {
            try
            {
                using (Con)
                {
                    List<int> authorizedGroupIds = GetAuthorityGroupList(userId);
                    List<Project> projects = new List<Project>();
                    foreach (int groupId in authorizedGroupIds)
                    {
                        cmd = new SqlCommand("SELECT PROJECT_ID FROM[PROJECT] WHERE PROJECT_GROUP_ID = @PROJECT_GROUP_ID OR PROJECT_CREATOR_ID = @PROJECT_CREATOR_ID", Con);
                        cmd.Parameters.AddWithValue("@PROJECT_GROUP_ID",groupId);
                        cmd.Parameters.AddWithValue("@PROJECT_CREATOR_ID",userId);

                        using(rd = cmd.ExecuteReader())
                        {   
                            while (rd.Read())
                            {
                                projects.Add( GetProjectInfo(rd.GetInt32(0)) );
                            }
                        }
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
                using (Con)
                {
                    cmd = new SqlCommand("SELECT * FROM [GROUP] WHERE GROUP_ID=@GROUP_ID", Con);
                    cmd.Parameters.AddWithValue("@GROUP_ID", groupId);
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
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return null;
        }

        public List<Team> GetTeams(int userId)
        {
            try
            {
                using (Con)
                {
                    List<Team> teams = new List<Team>();
                    cmd = new SqlCommand("SELECT * FROM [USER_GROUPS] WHERE USER_ID=@USER_ID",Con);
                    using(rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())// USER_GROUP_ID / USER_ID / GROUP_ID / USER_GROUP_AUTH / USER_JOIN_DATE / INVITE_SENDER_ID / INVITE_STATUS
                        {                //        0      /    1    /    2     /       3          /      4        /       5          /       6
                            teams.Add(new Team()
                            {
                                UserGroupId = rd.GetInt32(0),
                                UserId = rd.GetInt32(1),
                                GroupId = rd.GetInt32(2),
                                UserGroupAuthorization = rd.GetInt32(3),
                                UserJoinDate = rd.GetDateTime(4),
                                InviteSenderId = rd.GetInt32(5),
                                UserInviteStatus = rd.GetString(6)
                            });
                        }
                    }
                    return teams;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }
        public (int,int) GetProjectAndTaskCounts(int groupId)
        {
            int counterProject = 0;
            int counterTask = 0;

            SqlConnection Con = new SqlConnection("Data Source = .;Initial Catalog = ProjectManager; Integrated Security=true;");
            Con.Open();
            try
            {
                using (Con)
                {
                    List<string> tableList = new List<string>(){"PROJECT", "TASK"};
                    foreach (string table in tableList)
                    {
                        cmd = new SqlCommand("SELECT COUNT(" + table + "_ID) FROM [" + table + "] WHERE " + table + "_GROUP_ID=@" + table + "_GROUP_ID", Con);
                        cmd.Parameters.AddWithValue("@" + table + "_GROUP_ID", groupId);
                        cmd.ExecuteNonQuery();
                        if (table == "PROJECT")
                            counterProject++;
                        else
                            counterTask++;
                    }

                    return (counterProject, counterTask);
                    //SqlCommand cmd = new SqlCommand("SELECT COUNT(PROJECT_ID) FROM [PROJECT] WHERE PROJECT_GROUP_ID=@PROJECT_GROUP_ID", Con);
                    //                              SELECT COUNT(PROJECT_ID) FROM [PROJECT] WHERE PROJECT_ID=@PROJECT_ID
                    //cmd.Parameters.AddWithValue("@PROJECT_GROUP_ID", GroupId);
                    //cmd.ExecuteNonQuery();
                    //counterProject = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return (counterProject,counterTask);
        }

        // DATA INFO */
        // CREATE DATA /*

        // CREATE DATA */

    }
}
