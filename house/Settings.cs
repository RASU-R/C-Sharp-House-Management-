using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace House
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }
        config o = new config();
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCurrentPass.Text = "";
            txtNewPass.Text = "";
            txtConfirmPass.Text="";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(txtCurrentPass.Text))
                {
                    errorProvider1.SetError(txtCurrentPass, "Enter current password");
                    txtCurrentPass.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtNewPass.Text))
                {
                    errorProvider1.SetError(txtNewPass, "Enter current password");
                    txtCurrentPass.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtConfirmPass.Text))
                {
                    errorProvider1.SetError(txtConfirmPass, "Enter current password");
                    txtCurrentPass.Focus();
                    return;
                }
                errorProvider1.Clear();
                string currPass = MySqlHelper.EscapeString(txtCurrentPass.Text);
                string newPass = MySqlHelper.EscapeString(txtNewPass.Text);
                string confPass = MySqlHelper.EscapeString(txtConfirmPass.Text);

                string sql = "select * from admin_logs where upass='" + currPass + "' and ID=1";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, o.con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if(dt.Rows.Count==1)
                {
                    if(newPass==confPass)
                    {
                        o.con.Open();
                        sql = "update admin_logs set upass'" + newPass + "'where ID=1";
                        MySqlCommand cmd = new MySqlCommand(sql, o.con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Password Update Successfully");
                    }
                    else
                    {
                        MessageBox.Show("MisMatch Password");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid paasword");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if(o.con.State==ConnectionState.Open)
                {
                    o.con.Close();
                }
            }

        }
    }
}
