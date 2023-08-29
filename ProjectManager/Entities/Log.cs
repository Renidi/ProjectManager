using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager
{
    public class Log
    {
        public int LogId { get; set; }
        public string LogSource { get; set; }
        public string LogType { get; set; }
        public DateTime LogDate { get; set; }
        public string LogUser { get; set; } 
        public int LogUserId { get; set; }
        public string LogDescription { get; set; }
        public string LogStatus { get; set; }

    }
}
