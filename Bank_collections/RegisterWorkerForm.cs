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
    public partial class RegisterWorkerForm : Form
    {
        public RegisterWorkerForm()
        {
            InitializeComponent();
            button1.Enabled = false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    textBox2.Focus();
                return;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    textBox3.Focus();
                return;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (textBox3.Text.Length < 5)
                    {
                        label5.Text = "Password should be min 5 charactes length.";
                        label5.ForeColor = Color.Red;
                    }
                    else
                    {
                        if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0)
                        {
                            label5.Text = "";
                            button1.Enabled = true;
                            button1.Focus();
                        }
                    }
                }
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length >= 5 && textBox2.Text.Length > 0 && textBox1.Text.Length > 0)
                button1.Enabled = true;
        }
    }
}
