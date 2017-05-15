using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class User
    {

        private string account;
        private string password;
        private string phone;

        public User() { 
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }


        public string Account
        {
            get { return account; }
            set { account = value; }
        }
    }
}
