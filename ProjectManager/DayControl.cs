using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManager
{
    public partial class DayControl : UserControl
    {
        public DayControl()
        {
            InitializeComponent();
        }
        SqlDbHelper sqlDbHelper = new SqlDbHelper();
        Project project = new Project();
        User user = new User();
        static DateTime currentDt = DateTime.Now.Date;

        private void DayControl_Load(object sender, EventArgs e)
        {
            
        }
        public void Days(int numDay, string dateDay)
        {
            lbl.Text = numDay.ToString();
            List <string> tempList = new List <string>();
            tempList = sqlDbHelper.TakeProjectsName("ProjectsTbl",dateDay);
            if (Convert.ToDateTime(dateDay).ToString() == currentDt.ToString())
            {
                lbl.Font = new Font(Label.DefaultFont,FontStyle.Bold);
                lbl.ForeColor = Color.Blue;
            }


            for (int i = 0; i < tempList.Count; i+=2)
            {
                switch(i)
                {
                    case 0:
                        lblProject1.Text = tempList[i];
                        if (tempList[i + 1] == "MEDIUM")
                        {
                            lblProject1.ForeColor = Color.Orange;

                        }
                        else if (tempList[i + 1] == "HIGH")
                        {
                            lblProject1.ForeColor = Color.Red;
                        }
                        break;
                    case 2:
                        lblProject2.Text = tempList[i];
                        if (tempList[i + 1] == "MEDIUM")
                        {
                            lblProject2.ForeColor = Color.Orange;

                        }
                        else if (tempList[i + 1] == "HIGH")
                        {
                            lblProject2.ForeColor = Color.Red;
                        }
                        break;
                    case 4:
                        lblProject3.Text = tempList[i];
                        if (tempList[i + 1] == "MEDIUM")
                        {
                            lblProject3.ForeColor = Color.Orange;

                        }
                        else if (tempList[i + 1] == "HIGH")
                        {
                            lblProject3.ForeColor = Color.Red;
                        }
                        break;
                }
            }
        }

        private void DayControl_Click(object sender, EventArgs e)
        {
            
        }
    }
}
