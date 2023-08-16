using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.Entities
{
    public class UserGroup
    {
        public int UserGroupId { get; set; }
        public int UserId { get; set; }
        public int GroupId { get; set; }
        public int UserGroupAuthorization { get; set; } 
        public DateTime UserJoinDate { get; set; }
        public int InviteSenderId { get; set; }
        public string InviteStatus { get; set; }
    }
}
