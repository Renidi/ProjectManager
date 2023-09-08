using ProjectManager.UserControls;
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
    public partial class RelatingTasks : Form
    {
        User user = new User(); 
        public RelatingTasks(int userId)
        {
            InitializeComponent();
            user.UserId = userId;
        }

        private void RelatingTasks_Load(object sender, EventArgs e)
        {
            GenericSqlHelper<User> genericUser = new GenericSqlHelper<User>();
            user = genericUser.ReadById(user);
            DisplayProjects();
        }

        public void DisplayProjects()
        {
            ClearPanels();
            FillPanel();
        }

        void ClearPanels()
        {
            pnlActive.Controls.Clear();
            pnlComplete.Controls.Clear();
            pnlOnHold.Controls.Clear();
        }

        void FillPanel()
        {

            ClearPanels();
            List<FlowLayoutPanel> pnlList = new List<FlowLayoutPanel>
            {
                pnlActive,
                pnlOnHold,
                pnlCancelled,
                pnlComplete
            };
            List<string> statusList = new List<string>
            {
                "ACTIVE",
                "ON HOLD",
                "CANCELLED",
                "COMPLETED"
            };
            GenericSqlHelper<Task> genericSqlHelper = new GenericSqlHelper<Task>();
            List<Task> taskList = genericSqlHelper.ReadList(user);
            foreach(var pnl in pnlList)
            {
                pnl.AutoScroll = false;
            }
            
            for (int i = 0; i < taskList.Count; i++)
            {
                Task task = taskList[i];
                if (task.TaskStatus == statusList[0])
                {
                    TaskCard taskCard = new TaskCard(task);
                    pnlList[0].Controls.Add(taskCard);
                }
                else if (task.TaskStatus == statusList[1])
                {
                    TaskCard taskCard = new TaskCard(task);
                    pnlList[1].Controls.Add(taskCard);
                }
                else if (task.TaskStatus == statusList[2])
                {
                    TaskCard taskCard = new TaskCard(task);
                    pnlList[2].Controls.Add(taskCard);
                }
                else
                {
                    TaskCard taskCard = new TaskCard(task);
                    pnlList[3].Controls.Add(taskCard);
                }
            }

            foreach (var pnl in pnlList)
            {
                pnl.AutoScroll = true;
                pnl.HorizontalScroll.Visible = false;
            }

        }

    }
}
