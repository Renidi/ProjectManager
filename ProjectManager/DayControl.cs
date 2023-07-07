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

        private void DayControl_Load(object sender, EventArgs e)
        {

        }
        public void Days(int numDay)
        {
            lbl.Text = numDay.ToString();
        }
    }
}
