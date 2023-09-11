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
        public Calendar(int getUserId)
        {
            user.UserId = getUserId;
            user = genericUser.ReadById(user);
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

            
            for(int i = 1; i < dayOfWeek ; i++)
            {
                CardControl cardControl = new CardControl();
                flContainer.Controls.Add(cardControl);
            }
            for (int i = 1;i <= days ; i++)
            {
                DayControl dayControl = new DayControl();
                dayControl.Days(i, i + "." + currentMonth + "." + currentYear,user.UserId);
                
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

        private void btnPrevious_Click(object sender, EventArgs e)
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
