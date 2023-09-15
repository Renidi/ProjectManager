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
    public partial class PopupEditTeam : Form
    {
        Teams teams;
        User user;
        Group group = new Group();  
        GenericSqlHelper<Group> genericGroup = new GenericSqlHelper<Group>();
        public PopupEditTeam(Group groupInfo,User recUser,Teams teamS)
        {
            InitializeComponent();
            group = groupInfo;
            teams = teamS;
            user = recUser;
            txGroupName.Text = group.GroupName;
            txGroupDescription.Text = group.GroupDescription;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnEditTeam_Click(object sender, EventArgs e)
        {
            group.GroupName = txGroupName.Text;
            group.GroupDescription = txGroupDescription.Text;
            if (genericGroup.Update(group))
            {
                MessageBox.Show("Team info updated", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                teams.DisplayTeams();
                this.Close();
            }
            else
                MessageBox.Show("Something went wrong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);
        private void PopupEditTeam_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            PopupEditTeam_MouseDown(sender, e);
        }
    }
}
