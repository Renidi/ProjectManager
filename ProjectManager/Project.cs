using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager
{
    internal class Project
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string ProjectStatus { get; set; }
        public string ProjectPriority { get; set; }
        public DateTime ProjectStartDate { get; set; }
        public DateTime ProjectFinishDate { get; set; }
        public string ProjectOwner { get; set; }
        public Project()
        {
            ProjectStartDate = DateTime.Now;
        }

    }


}
