﻿using ProjectManager.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManager.Forms
{
    public partial class PopupAddMembeer : Form
    {
        Group group = new Group();
        List<UserGroup> userGroups = new List<UserGroup>();
        List<Group> groups = new List<Group>();
        User user = new User();
        GenericSqlHelper<Group> genericGroup = new GenericSqlHelper<Group>();
        GenericSqlHelper<UserGroup> genericUserGroup = new GenericSqlHelper<UserGroup>();
        GenericSqlHelper<User> genericUser = new GenericSqlHelper<User>();
        public PopupAddMembeer(User usr,List<UserGroup> list)
        {
            user = usr;
            InitializeComponent();
            foreach (UserGroup inGroup in list)
            {
                group.GroupId = inGroup.GroupId;
                group = genericGroup.ReadById(group);
                groups.Add(group);
                cmbTeams.Items.Add(group.GroupName);
            }
            userGroups = list;

        }

        private void cmbTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtxDes.Text = groups[cmbTeams.SelectedIndex].GroupDescription;
        }

        private void btnInvite_Click(object sender, EventArgs e)
        {
            if(txInviteUserMail.Text != "" && cmbTeams.SelectedIndex != -1)
            {
                User invitedUser = new User() { UserId = genericUser.CheckUserMail(txInviteUserMail.Text) };
                if (invitedUser.UserId > 0)
                {
                    invitedUser = genericUser.ReadById(invitedUser);
                    UserGroup userGroup = new UserGroup()
                    {
                        UserId = invitedUser.UserId,
                        GroupId = groups[cmbTeams.SelectedIndex].GroupId
                    };
                    userGroup = genericUserGroup.ReadById(userGroup);
                    if (userGroup.UserGroupId !=0) // if the user was previously in the group
                    {
                        if(userGroup.InviteStatus == "Accepted")
                        {
                            MessageBox.Show("User already in this team");
                        }
                        else
                        {
                            userGroup.InviteStatus = "Waiting";
                            userGroup.UserGroupAuthorization = 0;
                            userGroup.InviteDate = DateTime.Now;
                            userGroup.InviteSenderId = user.UserId;
                            if (genericUserGroup.Update(userGroup))
                                MessageBox.Show("User has been successfully invited");
                            else
                                MessageBox.Show("Error");
                        }
                    }
                    else
                    {
                        userGroup = new UserGroup()
                        {
                            UserId = invitedUser.UserId,
                            GroupId = groups[cmbTeams.SelectedIndex].GroupId,
                            UserGroupAuthorization = 0,
                            InviteDate = DateTime.Now,
                            InviteSenderId = user.UserId,
                            InviteStatus = "Waiting"
                        };
                        if (genericUserGroup.Create(userGroup))
                            MessageBox.Show("User has been successfully invited");
                        else
                            MessageBox.Show("Error");
                    }
                    
                }
                else
                {
                    MessageBox.Show("There is no user with this mail");
                }
            }
            else
            {
                if(cmbTeams.SelectedIndex != -1)
                {
                    MessageBox.Show("Please select the team you want to invite member");
                }
                else
                {
                    MessageBox.Show("Pleas enter the mail of the member you want to invite");
                }
            }
            
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);
        private void PopupAddMembeer_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
    }
}
