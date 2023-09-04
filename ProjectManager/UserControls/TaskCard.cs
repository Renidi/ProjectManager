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

namespace ProjectManager.UserControls
{
    public partial class TaskCard : UserControl
    {
        
        public void ShowSubMenu()
        {
            ContextMenuStrip myMenu = new ContextMenuStrip();
            myMenu.Items.Add("1",null,menuItem_Click);
            myMenu.Items.Add("2",null,menuItem2_Click);
            myMenu.Items.Add("3",null,menuItem3_Click);
            myMenu.Show(pbMenu, new Point(-15, pbMenu.Height/2+15));

        }
        public TaskCard()
        {
            InitializeComponent();
        }

        private void pbMenu_Click(object sender, EventArgs e)
        {
            ShowSubMenu();
        }

        private void menuItem_Click(object sender,EventArgs e)
        {

        }
        private void menuItem2_Click(object sender, EventArgs e)
        {

        }
        private void menuItem3_Click(object sender, EventArgs e)
        {

        }
    }
}
