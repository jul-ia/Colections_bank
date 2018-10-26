using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_collections
{
    [Serializable]
    public partial class Form1 : Form
    {
        public Dictionary<int, string> operation = new Dictionary<int, string>();
        public List<Worker> workers;  
        public List<Client> clients;
        public Client client;   //current client
        public Worker worker;   //current worker
        BinaryFormatter formatter = new BinaryFormatter();

        public Form1()
        {
            InitializeComponent();
            workers = new List<Worker>();
            workers.Add(new Worker("worker1", "w1ID", "w1234"));
            clients = new List<Client>();
            clients.Add(new Client("Oleg", "oleg", "12345"));
            try
            {
                using (FileStream fs = new FileStream("operations.dat", FileMode.OpenOrCreate))
                {
                    operation = (Dictionary<int, string>)formatter.Deserialize(fs);
                }
            }
            catch { }
        }

        private void registerW_Click(object sender, EventArgs e)
        {
            RegisterWorkerForm r = new RegisterWorkerForm();
            r.label2.Text = "ID:";
            r.ShowDialog();
            if (r.textBox1.Text.Length > 0 && r.textBox2.Text.Length > 0 && r.textBox3.Text.Length > 0)
            {
                worker = new Worker(r.textBox2.Text, r.textBox1.Text, r.textBox3.Text);
                workers.Add(worker);
            }
        }

        private void loginW_Click(object sender, EventArgs e)
        {
            LogInForm l = new LogInForm();
            l.ShowDialog();
            foreach(Worker t in workers)
            {
                if (t.Login == l.textBox1.Text && t.Password == l.textBox2.Text)
                {
                    worker = t;
                    WorkerForm wf = new WorkerForm();
                    wf.worker = worker;
                    wf.operation = operation;
                    wf.ShowDialog();

                    this.operation = wf.operation;

                    using (FileStream fs = new FileStream("operations.dat", FileMode.OpenOrCreate))
                    {
                        formatter.Serialize(fs, operation);
                    }
                    return;
                }
            }
            MessageBox.Show("Incorrect login or password", "Error", MessageBoxButtons.OK);
        }

        private void loginC_Click(object sender, EventArgs e)
        {
            LogInForm l = new LogInForm();
            l.ShowDialog();
            foreach (Client t in clients)
            {
                if (t.Login == l.textBox1.Text && t.Password == l.textBox2.Text)
                {
                    client = t;
                    ClientForm cw = new ClientForm();
                    cw.operation = operation;
                    cw.client = client;
                    cw.ShowDialog();

                    return;
                }
            }
            MessageBox.Show("Incorrect login or password", "Error", MessageBoxButtons.OK);
        }

        private void registerC_Click(object sender, EventArgs e)
        {
            RegisterWorkerForm r = new RegisterWorkerForm();
            r.label2.Text = "Name:";
            r.ShowDialog();
            if (r.textBox1.Text.Length > 0 && r.textBox2.Text.Length > 0 && r.textBox3.Text.Length > 0)
            {
                client = new Client(r.textBox1.Text, r.textBox2.Text, r.textBox3.Text);
                clients.Add(client);
            }
        }

    }
}
