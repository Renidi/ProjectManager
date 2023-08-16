using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.Entities
{
    public class Group
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public int GroupFounderId { get; set; }
        public int GroupManagerId { get; set; }
        public string GroupDescription { get; set; }
        public DateTime GroupFormationDate { get; set; }
    }
}
