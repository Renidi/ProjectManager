using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager
{
    internal class Operation
    {
        public int Id { get; set; }
        public string OperationName{ get; set; }
        public string OperationTable { get; set; }
        public string OperationType { get; set; }
        public DateTime OperationTime { get; set; }
        public string OperationChange { get; set; } 
        public string OperationUser { get; set; }
        public int OperationUserId { get; set; }
        public Operation() 
        {
            OperationTime = DateTime.Now;
        }

    }
}
