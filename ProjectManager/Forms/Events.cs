using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManager
{
    public partial class Events : Form
    {
        public PictureBox pbTeamClick {  get { return pbTeams; } }
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int LPAR);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;

        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }

        public int UserId { get; set; }
        User user = new User();
        public Events(int userId)
        {
            InitializeComponent();
            UserId = userId;
            openChildForm(new Projects(userId));
            DoubleBuffered = true;
        }
        
        
        private void Events_Load(object sender, EventArgs e)
        {
            user.UserId = UserId;
            GenericSqlHelper<User> genericUser = new GenericSqlHelper<User>();
            user = genericUser.ReadById(user);
            lblMail.Text = user.UserMail;
            lblAdSoyad.Text = user.UserName + " " + user.UserSurname;
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            activeForm?.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            pnlMiddle.Controls.Add(childForm);
            pnlMiddle.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            this.DoubleBuffered = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {  // user settings !!??
            openChildForm (new UserSettings(user.UserId));
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Log log = new Log
            {
                LogSource = "User",
                LogType = "Logout",
                LogDate = DateTime.Now,
                LogUser = user.UserMail,
                LogUserId = user.UserId,
                LogDescription = "Logout",
                LogStatus = "true"
            };

            GenericSqlHelper<Log> genericLog = new GenericSqlHelper<Log>();
            genericLog.Create(log);

            Entry entry = new Entry();
            entry.Show();
            this.Hide();
        }

        private void pbCalender_Click(object sender, EventArgs e)
        {
            openChildForm(new Calendar(user.UserId));
        }

        private void pbTask_Click(object sender, EventArgs e)
        {
            openChildForm(new Tasks(user.UserId));
        }

        private void pbProject_Click(object sender, EventArgs e)
        {
            openChildForm(new Projects(user.UserId));
        }

        public void pbTeams_Click(object sender, EventArgs e)
        {
            openChildForm(new Teams(user.UserId));
        }

    }

}

