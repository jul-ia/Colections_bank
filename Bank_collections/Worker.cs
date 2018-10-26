using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_collections
{
    [Serializable]
    public class Worker : Authorization
    {
        public string ID { set; get; }

        public Worker(string login, string id, string password)
        {
            Login = login;
            Password = password;
            ID = id;
        }

        public void deleteOperation(Dictionary<int, string> d, int key)
        {
            try
            {
                d.Remove(key);
            }
            catch
            {}
        }

        public bool addOperation(Dictionary<int, string> d, int key, string value)
        {
            try {
                if (d.ContainsKey(key))
                    return false;
                d.Add(key, value);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
