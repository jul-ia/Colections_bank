using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;

namespace Bank_collections
{
    [Serializable]
    [DataContract]
    public class Client : Authorization
    {
        public string Name { get; set; }
        public string Account { get; set; }
        [DataMember]
        public List<string> operations;

        public Client(string name, string login, string password)
        {
            Name = name;
            Login = login;
            Password = password;
            Account = "account_" + login;
            operations = new List<string>();
        }

        public void doOperation(string op)
        {
            try
            {
                operations.Add(op);
            }
            catch{ }
        }
        public void writeOp()
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<string>));

            using (FileStream fs = new FileStream(Login + ".json", FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs, operations);
            }
        }

        public void readOp()
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<string>));

            using (FileStream fs = new FileStream(Login + ".json", FileMode.OpenOrCreate))
            {
                operations = (List<string>)jsonFormatter.ReadObject(fs);
            }

        }
    }
}
