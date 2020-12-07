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
    public partial class ShowDetails : Form
    {
        public ShowDetails()
        {
            InitializeComponent();
        }

        private void ShowDetails_Load(object sender, EventArgs e)
        {
            Registration ob = new Registration();

            FNLABEL3.Text = Registration.FirstName;
            LNLABEL4.Text = Registration.LastName;
            EMAILLABEL10.Text = Registration.EMAIL;
            SECURITYANSWERlabel12.Text = Registration.SECURITYANSWER;

            ADDRESSlabel13.Text = Registration.ADDRESS;
            ZIPCODElabel15.Text = Registration.ZIPCODE;
            PHONElabel16.Text = Registration.PHONE;
            CITYlabel14.Text = Registration.City;
        }
    }
}
