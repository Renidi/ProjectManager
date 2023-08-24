using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager
{
    public class Task
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public string TaskStatus { get; set; }
        public string TaskPriority { get; set; }
        public DateTime TaskStartDate { get; set; }
        public DateTime TaskEndDate { get; set; }
        public int TaskDuration { get; set; }
        public int TaskOwnerId { get; set; }
        public int TaskCreatorId { get; set; }
        public int TaskProjectId { get; set; }
        public int TaskGroupId { get; set; }
        public string TaskDescription { get; set; }

    }
}
