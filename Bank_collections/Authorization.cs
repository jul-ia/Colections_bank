using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_collections
{
    [Serializable]
    public class Authorization
    {
        string login;
        string password;

        public string Login
        {
            get{ return login; }
            set { login = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
