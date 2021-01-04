using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAutoMail.User
{
    public class UserAccount
    {
        public UserAccount(string n, string ad, string ac, string pw)
        {
            Name = n;
            Address = ad;
            Account = ac;
            Password = pw;
        }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Account { get; set; }

        public string Password { get; set; }

    }
}
