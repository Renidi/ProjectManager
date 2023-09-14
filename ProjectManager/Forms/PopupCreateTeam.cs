using ProjectManager.Entities;
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
    public partial class PopupCreateTeam : Form
    {
        private Teams teams;

        User user = new User();
        Group group = new Group();
        GenericSqlHelper<User> genericUser = new GenericSqlHelper<User>();
        GenericSqlHelper<Group> genericGroup = new GenericSqlHelper<Group>();

        public PopupCreateTeam(User recUser, Teams formTeams)
        {
            user = recUser;
            user = genericUser.ReadById(user);
            InitializeComponent();
            teams = formTeams;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnCreateTeam_Click(object sender, EventArgs e)
        {
            if(group.GroupName != "")
            {
                group.GroupName = txGroupName.Text;
                group.GroupFounderId = user.UserId;
                group.GroupManagerId = user.UserId;
                group.GroupDescription = txGroupDescription.Text;
                group.GroupFormationDate = DateTime.Now;
                group.GroupStatus = "Active";

                if (genericGroup.Create(group))
                    this.Close();
            }
            else
            {
                MessageBox.Show("Please enter team name");
            }
        }

        private void PopupCreateTeam_FormClosing(object sender, FormClosingEventArgs e)
        {
            teams.DisplayTeams();
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr one, int two, int three, int four);
        private void PopupCreateTeam_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void guna2Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            PopupCreateTeam_MouseDown(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
