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
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int LPAR);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;

        SqlDbHelper sqlDbHelper = new SqlDbHelper();
        Project project = new Project();
        User user = new User();
        
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

        public Events(string usermail)
        {
            InitializeComponent();
            Mail = usermail;
            openChildForm(new Projects(Mail));
            DoubleBuffered = true;

        }
        
        public string Mail { get; set; }
        private void Events_Load(object sender, EventArgs e)
        {
            user.UserMail = Mail;
            user = sqlDbHelper.UserInfo(user);
            lblMail.Text = user.UserMail;
            lblAdSoyad.Text = user.UserName + " " + user.UserSurname;
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            user = sqlDbHelper.UserInfo(user);
            sqlDbHelper.UserLog(user, "Logout");
            Entry entry = new Entry();
            entry.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            openChildForm(new Projects(user.UserMail));
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            openChildForm(new Tasks(user.UserMail));
        }


        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            activeForm?.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            pnlMiddle.Controls.Add(childForm);
            pnlMiddle.Tag = childForm; ;
            childForm.BringToFront();
            childForm.Show();
            this.DoubleBuffered = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {  // user settings
            openChildForm (new UserSettings(user.UserMail));
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            openChildForm(new Calendar());
        }

    }

}

