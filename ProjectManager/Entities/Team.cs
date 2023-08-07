using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.Entities
{
    internal class Team
    {
        public int UserId { get; set; }
        public int GroupId { get; set; }
        public int UserGroupAuthorization { get; set; }
        public DateTime UserJoinDate { get; set; }  
        public string UserInviteStatus { get; set; }
        // -Rejected -Accepted -Waiting Confirmation
    }
}
