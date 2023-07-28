﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager
{
    internal class Task
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public string TaskStatus { get; set; }
        public string TaskPriority { get; set; }
        public DateTime TaskStartDate { get; set; }
        public DateTime TaskEndDate { get; set; }
        public int TaskDuration { get; set; }
        public string TaskOwner { get; set; }
        public string TaskProject { get; set; }
        public string TaskDescription { get; set; }

    }
}
