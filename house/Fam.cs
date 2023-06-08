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
    public partial class Fam : Form
    {
        public Fam()
        {
            InitializeComponent();
        }
        config o = new config();
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtname.Text = "";
            txtRole.Text = "";
            txtAge.Text = "";
            txtWork.Text = "";
            txtIncome.Text = "";
            txtSearch.Text = "";
            txtLID.Text = "0";
        }

        DataTable dtLedger;

        public void loadgrid()
        {
            string sql = "select * from Family_Details";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, o.con);
            dtLedger = new DataTable();
            da.Fill(dtLedger);
            dataGridView1.DataSource = dtLedger;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {


                if (string.IsNullOrEmpty(txtname.Text))
                {
                    errorProvider1.SetError(txtname, "Enter The Fam Member Name");
                    txtname.Focus();
                    return;
                }
                string name = MySqlHelper.EscapeString(txtname.Text);
                string role = MySqlHelper.EscapeString(txtRole.Text);
                string age = MySqlHelper.EscapeString(txtAge.Text);
                string work = MySqlHelper.EscapeString(txtWork.Text);
                string income = MySqlHelper.EscapeString(txtIncome.Text);
                string lid = MySqlHelper.EscapeString(txtLID.Text);


                errorProvider1.Clear();
                string sql;
                if(lid=="0")
                {
                    sql = "insert into Family_Details (NAME,ROLE,AGE,WORK,INCOME) values ('" + name +
                   "','" + role + "','" + age + "','" + work + "','" + income + "')";
                }
                else
                {
                    sql= "update Family_Details set NAME='" + name + "',ROLE='" + role + "',AGE='" + age + "'," +
                        "WORK='" + work + "',INCOME ='" + income + "' where LID='"+lid+"'";
                }

                o.con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, o.con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Family Member Details Added Successfully");
                loadgrid();
                btnClear_Click(sender, e);
            }
            catch(Exception ex)
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

        private void Ledger_Load(object sender, EventArgs e)
        {
            loadgrid();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dtLedger);
            dv.RowFilter = "NAME like '%" + txtSearch.Text + "%'";
            dataGridView1.DataSource = dv;
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex!=-1)
            {
                txtLID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtRole.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtAge.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtWork.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtIncome.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(txtLID.Text!="0")
            {
               if( MessageBox.Show("Are U Sure To Delete","Delete",MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Information)==DialogResult.OK)
                    {
                    try
                    {

                        string lid = MySqlHelper.EscapeString(txtLID.Text);

                        string sql="delete from Family_Details where LID='"+lid+"'";
                        o.con.Open();
                        MySqlCommand cmd = new MySqlCommand(sql, o.con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Family Details Deleted Successfully");
                        loadgrid();
                        btnClear_Click(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        if (o.con.State == ConnectionState.Open)
                        {
                            o.con.Close();

                        }
                    }


                }
            }
            else
            {
                MessageBox.Show("Select Record to Delete ");
            }
        }
    }
}
