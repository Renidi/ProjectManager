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
    public partial class TeamsControl : UserControl
    {
        public TeamsControl()
        {
            InitializeComponent();
        }
        SqlDbHelper sqlDbHelper = new SqlDbHelper();
        Project project = new Project();
        User user = new User();
        static DateTime currentDt = DateTime.Now.Date;

        private void TeamsControl_Load(object sender, EventArgs e)
        {

        }

        

    }
}
