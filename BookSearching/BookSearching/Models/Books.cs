using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using BookSearching.Models;

namespace BookSearching.Models
{
    
    class Books
    {
        public int c;
        
        public string textbox;
       public DataTable dtTable = new DataTable();
        Database objDBaccess = new Database();
        public void Show()
        {
            string query = "SELECT * FROM Books";
            objDBaccess.readDatathroughAdapter(query,dtTable);
        }
        public void Close()
        {
            objDBaccess.closeConn();
        }

        public void performOperation()
        {
            string query = "SELECT * fROM Books";
             c = objDBaccess.executeDataAdapter(dtTable,query);
            
        }

        public void searchOpen()
        {

            string query = "SELECT * FROM Books where Name='"+textbox+"'";
            objDBaccess.readDatathroughAdapter(query, dtTable);
        }
        public void earchClose()
        {
            objDBaccess.closeConn();
        }
       public void information()
        {
            
        }



    }
}
