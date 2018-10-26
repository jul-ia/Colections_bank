using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_collections
{
    [Serializable]
    public partial class WorkerForm : Form
    {
        public Dictionary<int, string> operation;
        public Worker worker;

        public WorkerForm()
        {
            InitializeComponent();
            operation = new Dictionary<int, string>();

        }

        private void WorkerForm_Load(object sender, EventArgs e)
        {
            label1.Text += worker.Login;
            label2.Text += worker.ID;

            comboBox1.DataSource = new BindingSource(operation, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;

            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    textBox2.Focus();
                return;
            }

            e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    button1.Focus();
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0 && textBox2.Text.Length > 0)
            {
                if (worker.addOperation(operation, int.Parse(textBox1.Text), textBox2.Text))
                {
                    comboBox1.DataSource = new BindingSource(operation, null);
                    comboBox1.DisplayMember = "Value";
                    comboBox1.ValueMember = "Key";

                    textBox1.Text = "";
                    textBox2.Text = "";
                }
                else
                    MessageBox.Show("ID is already taken");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            worker.deleteOperation(operation, int.Parse(comboBox1.SelectedValue.ToString()));
            comboBox1.DataSource = new BindingSource(operation, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";
        }
    }
}
