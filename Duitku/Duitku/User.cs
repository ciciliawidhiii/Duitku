using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duitku
{
    class User
    {
        private string _userName; 
        private string _password;
        private string _email;

        public string userName
        {
            get { return _userName;}
            set { _userName = value;}
        }

        public string Password
        {
            get { return _password;}
            set { _password = value;}
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public Boolean Login(string username, string password)
        {
            return true; 
        }
    }
}
