using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManager
{
    public partial class Calendar : Form
    {
        static DateTime currentDt = DateTime.Now;
        static int currentMonth = currentDt.Month;
        static int currentYear = currentDt.Year;
        User user = new User();
        GenericSqlHelper<User> genericUser = new GenericSqlHelper<User>();
        GenericSqlHelper<Task> genericTask = new GenericSqlHelper<Task>();
        public Calendar(User recUser)
        {
            user = recUser;
            InitializeComponent();
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            displayDays();
        }
        private void displayDays()
        {
            lblTarih.Text = DateTimeFormatInfo.CurrentInfo.GetMonthName(currentMonth) + " " + currentYear;
            DateTime startOfMonth = new DateTime(currentYear,currentMonth, 1);
            int days = DateTime.DaysInMonth(currentYear,currentMonth);
            int dayOfWeek = Convert.ToInt32(startOfMonth.DayOfWeek.ToString("d"));

            List<Task> taskList = genericTask.ReadList(user);
            

            for (int i = 1; i < dayOfWeek ; i++)
            {
                LeapDayControl cardControl = new LeapDayControl();
                flContainer.Controls.Add(cardControl);
            }

            for (int i = 1;i <= days ; i++)
            {
                List<Task> mainTaskList = new List<Task>();
                foreach (Task item in taskList)
                {
                    if(item.TaskEndDate.Date == Convert.ToDateTime(i + "." + currentMonth + "." + currentYear).Date && item.TaskStatus != "CANCELLED")
                    {
                        mainTaskList.Add(item);
                    }
                }
                DayControl dayControl = new DayControl();
                dayControl.Days(i, i + "." + currentMonth + "." + currentYear,user.UserId,mainTaskList);
                
                flContainer.Controls.Add(dayControl);
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            flContainer.Controls.Clear();
                        if (currentMonth == 12)
                        {
                            currentYear += 1;
                            currentMonth = 1;
                        }
                        else
                        {
                            currentMonth += 1;
                        }
            displayDays();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            flContainer.Controls.Clear();
            if (currentMonth == 1)
            {
                currentYear -= 1;
                currentMonth = 12;
            }
            else
            {
                currentMonth -= 1;
            }

            displayDays();
        }


    }
}
