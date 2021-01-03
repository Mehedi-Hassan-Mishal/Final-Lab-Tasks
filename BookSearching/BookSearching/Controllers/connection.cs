using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookSearching.Models;
using BookSearching.Views;
using System.Data;
using System.Data.SqlClient;

namespace BookSearching.Controllers
{
    class connection
    {
        public DataTable dtTable = new DataTable();
        public int chng;

        
        Books ob=new Books();
       
        public void Show()
        {
            ob.Show();
            dtTable = ob.dtTable;
        }
        public void Close()
        {
            ob.Close();
        }
        public void performOperation()
        {
            ob.performOperation();
            dtTable = ob.dtTable;
            chng = ob.c;
        }
        public void searchOpen()
        {
            ob.searchOpen();
            dtTable = ob.dtTable;

        }
        public void earchClose()
        {
            ob.earchClose();
        }
    }
}
