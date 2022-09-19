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

        public Boolean Login(string username, string password)
        {
            return true; 
        }
        
        
    }
}
