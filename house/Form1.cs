using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace House
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        config o = new config();
       
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are U Sure To Exit", "Exit",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtUserName.Text))
            {
                errorProvider1.SetError(txtUserName, "enter the user name");
                txtUserName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, "enter the password");
                txtPassword.Focus();
                return;
            }
            string uname = MySqlHelper.EscapeString(txtUserName.Text);
            string upass = MySqlHelper.EscapeString(txtPassword.Text);

            string sql = "select * from admin_logs where UNAME='" + uname + "' and UPASS='" + upass + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, o.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count==1)
            {
                this.Hide();
                Home frm = new Home(dt.Rows[0][1].ToString());
                frm.Show();
               
            }
            else
            {
                MessageBox.Show("Invalid cretential", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtUserName.Focus();    
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
