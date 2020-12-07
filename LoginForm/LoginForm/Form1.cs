using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        string UserName = "19-40030-1";
        string password = "mishal";
        string UN;
        string Pass;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UN = txtName.Text;
            Pass = txtPass.Text;

            if (string.Equals(UN, UserName) == true && string.Equals(Pass, password))
            {
                this.Hide();
                label1.Text = "ok";
                AddUser f = new AddUser();
                f.Show();

            }
            else
            {
                MessageBox.Show("incorrect password or username");
            }

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
