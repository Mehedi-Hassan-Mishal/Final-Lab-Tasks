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
    public partial class Registration : Form
    {
        public static string FirstName, LastName, EMAIL, ADDRESS, PHONE, SECURITYANSWER, ZIPCODE, City;
        public Registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FirstName = FirstNametextBox1.Text;
            LastName = LastNametextBox2.Text;
            EMAIL = MailTextBox3.Text;
            ADDRESS = AddressTextbox.Text;
            PHONE = PhoneTextBox.Text;
            SECURITYANSWER = SecurityAnswerTextBox.Text;
            ZIPCODE = ZipCodeTextBox5.Text;
            City = CityextBox.Text;
            ShowDetails f = new ShowDetails();
            f.Show();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
