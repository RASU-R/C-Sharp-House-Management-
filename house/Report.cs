using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace House
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }
        config o = new config();

        private void btnView_Click(object sender, EventArgs e)
        {
            string frdate = Fdate.Value.ToString("yyyy-MM-dd");
            string todate = Tdate.Value.ToString("yyyy-MM-dd");

            try
            {
                string sql = "SELECT f.NAME ,DATE_FORMAT(s.TDATE,'%d-%m-%Y') as" +
                    "`DATE`, s.ITEM,s.QUANTITY,s.RATE,s.PTYPE as `PAYMENT TYPE` ,s.DETAILS from Shopping_Details s inner join " +
                    "Family_Details f on f.LID=s.LID where tdate between '" + frdate + "' and '" + todate + "' order by s.TDATE;";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, o.con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Not Available");
            }
        }
    }
}
