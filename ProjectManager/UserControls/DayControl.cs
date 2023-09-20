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
        User user = new User();
        static DateTime currentDt = DateTime.Now.Date;

        public void Days(int numDay, string dateDay,int userId,List<Task> todaysTask)
        {
            lbl.Text = numDay.ToString();
            if (Convert.ToDateTime(dateDay).ToString() == currentDt.ToString())
            {
                lbl.Font = new Font("Microsoft Sans Serif", 12,FontStyle.Bold);
                lbl.ForeColor = Color.Blue;
            }

            user.UserId = userId;
            
            int loopCount = todaysTask.Count>3 ? 3 : todaysTask.Count;
            if(todaysTask.Count>3)
                lblExtra.Text = "+" + (todaysTask.Count - 3);

            List<Label> labels = new List<Label>() { lblProject1,lblProject2,lblProject3 };
            for (int i = 0; i < loopCount; i++)
            {
                Task task = todaysTask[i];
                Label label = labels[i];
                label.Text = task.TaskName;
                if (task.TaskStatus == "COMPLETED")
                    label.ForeColor = Color.Green;
                else if (task.TaskPriority == "MEDIUM")
                    label.ForeColor = Color.OrangeRed;
                else if (task.TaskPriority == "HIGH")
                    label.ForeColor = Color.Red;
            }
        }
    }
}
