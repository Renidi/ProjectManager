﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager
{
    internal class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string UserMail { get; set; }
        public string UserPassword { get; set; }
        public DateTime UserRegisterDate { get; set; }
        public DateTime UserLastLoginDate { get; set; }
        public string UserSecretWord { get; set; }

        public User()
        {
            UserRegisterDate = DateTime.Now;
        }

    }

}
