using ProjectManager.UserControls;
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

namespace ProjectManager
{
    public partial class LoginPage : Form
    {
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int LPAR);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
        public LoginPage()
        {
            InitializeComponent();
            DoubleBuffered = true;
            StartPosition = FormStartPosition.CenterScreen;
        }
        public void Entry_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
        private void Entry_Load(object sender, EventArgs e)
        {
            SetPanelSettings("Login");
        }

        public void SetPanelSettings(string panelMod,User user = null) // panel componentlerini ayarlar.
        {
            panelMain.Controls.Clear();
            switch (panelMod)
            {
                case "Login": // Login
                    LoginComponent loginCompanets = new LoginComponent(this);
                    panelMain.Controls.Add(loginCompanets);
                    break;
                case "ResetPassword": // Reset Password
                    ResetPasswordComponent resetPassword = new ResetPasswordComponent(this,user);
                    panelMain.Controls.Add(resetPassword);
                    break;
                case "Reset": // Reset password with secret word
                    ForgotPasswordComponent forgotPassword = new ForgotPasswordComponent(this);
                    panelMain.Controls.Add(forgotPassword);
                    break;
                case "Register": // Register
                    RegisterComponent registerControl = new RegisterComponent(this);
                    panelMain.Controls.Add(registerControl);
                    break;
                default:
                    break;
            }
        }

        private void exitApp_Click(object sender, EventArgs e) { Application.Exit(); }
    }
}
