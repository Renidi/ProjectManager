using ProjectManager.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        UserGroup userGroup = new UserGroup();
        GenericSqlHelper<User> genericUser = new GenericSqlHelper<User>();
        GenericSqlHelper<Group> genericGroup = new GenericSqlHelper<Group>();
        GenericSqlHelper<UserGroup> genericUserGroup = new GenericSqlHelper<UserGroup>();

        public PopupCreateTeam(int userId, Teams formTeams)
        {
            user.UserId = userId;
            user = genericUser.ReadById(user);
            InitializeComponent();
            teams = formTeams;
        }

        private void btnCreateTeam_Click(object sender, EventArgs e)
        {
            group.GroupName = txGroupName.Text;
            group.GroupFounderId = user.UserId;
            group.GroupManagerId = user.UserId;
            group.GroupDescription = txGroupDescription.Text;
            group.GroupFormationDate = DateTime.Now;

            if(genericGroup.Create(group))
            {
                this.Close();
            }

        }

        private void PopupCreateTeam_FormClosing(object sender, FormClosingEventArgs e)
        {
            teams.DisplayTeams();
        }
    }
}
