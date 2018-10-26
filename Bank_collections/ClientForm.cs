using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_collections
{
    public partial class ClientForm : Form
    {
        public Dictionary<int, string> operation;
        public Client client;

        public ClientForm()
        {
            InitializeComponent();
            operation = new Dictionary<int, string>();

        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            label1.Text += client.Name;
            label2.Text += client.Login;
            label3.Text += client.Account;
            try
            {
                client.readOp();
            }
            catch { }

            listBox1.DataSource = new BindingSource(client.operations, null);

            comboBox1.DataSource = new BindingSource(operation, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            client.doOperation(comboBox1.SelectedItem.ToString());

            listBox1.DataSource = new BindingSource(client.operations, null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                client.writeOp();
                MessageBox.Show("Operations have been saved into \"" + client.Login + ".json\"");
            }
            catch { }
        }
    }
}
