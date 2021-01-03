using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookSearching.Models;
using BookSearching.Controllers;

namespace BookSearching.Views
{
    public partial class AllBooks : Form
    {
        public string STextBox;
        connection obj = new connection();
        public AllBooks()
        {
            InitializeComponent();
        }
        private void AllBooks_Load(object sender, EventArgs e)
        {
           
            obj.Show();
            dataGridView1.DataSource = obj.dtTable;
            obj.Close();
            

        }
        private void button1_Click(object sender, EventArgs e)
        {
            obj.performOperation();
            MessageBox.Show("Count: "+obj.chng);
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            Books obj2= new Books();
            STextBox = SearchTextBox1.Text;
            obj2.textbox = STextBox;
            obj2.searchOpen();
            dataGridView1.DataSource = obj2.dtTable;
            obj2.earchClose();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BookDetails ob = new BookDetails();
            DataGridViewRow row=this.dataGridView1.Rows[e.RowIndex];
            ob.name = row.Cells["Name"].Value.ToString();
            ob.id=row.Cells["ID"].Value.ToString();
            ob.author= row.Cells["Author"].Value.ToString();
            ob.edition= row.Cells["Edition"].Value.ToString();          
            ob.Show();
        }
    }
}
