using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace House
{
    internal class config
    {
        public MySqlConnection con;
        public config() 
        {
            try
            {
                string str = "server=localhost;User Id=root;pwd=root;database=house";
                con= new MySqlConnection(str);
               // con.Open();
              // MessageBox.Show("Good");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }
    }
}
