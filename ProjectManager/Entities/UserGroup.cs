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
        public int UserGroupAuthorization { get; set; }//3 - owner / 2 - admin / 1 - member / 0 - viewer (invited)
        public DateTime InviteDate { get; set; }
        public DateTime ProcessDate { get; set; }
        public int InviteSenderId { get; set; }
        public string InviteStatus { get; set; } // -Rejected -Accepted -Waiting
    }
}
