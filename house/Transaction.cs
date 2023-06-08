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
    public partial class Transaction : Form
    {
        public Transaction()
        {
            InitializeComponent();
        }
        config o = new config();

       
        private void button4_Click(object sender, EventArgs e)
        {
            //delete
            if(txtTID.Text!="0")
            {
                if (MessageBox.Show("Are U Sure To Delete", "Delete", MessageBoxButtons.OKCancel,
                   MessageBoxIcon.Information) == DialogResult.OK)
                {
                    try
                    {

                        string tid = MySqlHelper.EscapeString(txtTID.Text);

                        string sql = "delete from Shopping_Details where TID='" + tid + "'";
                        o.con.Open();
                        MySqlCommand cmd = new MySqlCommand(sql, o.con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Shopping details Deleted Successfully");
                        loadgrid();
                        button3_Click(sender, e);
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
        

        private void button3_Click(object sender, EventArgs e)
        {
            //clear function
           // comboRole.SelectedIndex = -1;
            comboLid.SelectedIndex = -1;
            comboPay_Type.SelectedIndex = -1;
            txtTID.Text = "0";
            txtRate.Text = "";
            txtQuantity.Text = "";
            textDes.Text = "";
            textDes.Text = "";
            textItem.Text = "";
            txtSearch.Text = "";
        }

      
        DataTable dtTrans;
        private void Transaction_Load(object sender, EventArgs e)
        {
            string sql = "SELECT LID,NAME from Family_Details";
            MySqlDataAdapter da = new MySqlDataAdapter(sql,o.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboLid.DataSource = dt;
            comboLid.DisplayMember = "NAME";
            comboLid.ValueMember = "LID";
            comboLid.SelectedIndex = -1;

            loadgrid();
        }
        public void loadgrid()
        {
            string sql="SELECT s.TID,f.NAME,s.ITEM,s.QUANTITY,s.RATE,s.PTYPE,s.DETAILS,s.TDATE as `DATE` FROM Shopping_Details s inner join Family_Details f on f.LID=s.LID order by TDATE desc";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, o.con);
            dtTrans = new DataTable();
            da.Fill(dtTrans);
            dataGridView1.DataSource=dtTrans;
 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
               
                if(comboLid.SelectedIndex==-1)
                {
                    errorProvider1.SetError(comboLid, "Please select Family Mem");
                    comboLid.Focus();
                    return;
                }
                if (comboPay_Type.SelectedIndex == -1)
                {
                    errorProvider1.SetError(comboPay_Type, "Please select payment type");
                    comboPay_Type.Focus();
                    return;
                }
                if(string.IsNullOrEmpty(txtRate.Text))
                {
                    errorProvider1.SetError(txtRate, "Enter the Amount");
                    txtRate.Focus();
                    return;
                }
                errorProvider1.Clear();
               // string name = MySqlHelper.EscapeString(comboLid.Text);
                string tdate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string lid = MySqlHelper.EscapeString(comboLid.SelectedValue.ToString());
                string pay_type = MySqlHelper.EscapeString(comboPay_Type.Text);
                string description = MySqlHelper.EscapeString(textDes.Text);
                string item = MySqlHelper.EscapeString(textItem.Text);
                string quantity = MySqlHelper.EscapeString(txtQuantity.Text);
                string amt= MySqlHelper.EscapeString(txtRate.Text);
                string tid = MySqlHelper.EscapeString(txtTID.Text);
               
               
                string sql;
                if(tid=="0")
                {
                    sql = "insert into Shopping_Details (TDATE,LID,PTYPE,DETAILS,ITEM,QUANTITY,RATE) values "+
                        "('"+tdate+"','"+lid+"','"+pay_type+"','"+description+"','"+item+
                        "','"+quantity+"','"+amt+"')";
                          
                }
                else
                {
                    sql = "update shopping_Details set TDATE='"+tdate+ "',LID= '"+lid+"',PTYPE=" +
                        "'"+pay_type+ "',DETAILS= '"+description+ "',ITEM= '"+item+"'," +
                        "QUANTITY='"+quantity+ "',RATE=,'"+amt+"' where TID='"+tid+"'";
                }
                o.con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, o.con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Shopping details added successfully");
                loadgrid();
                button3_Click(sender, e);//clear function

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

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex!=-1)
            {
                txtTID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                comboLid.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textItem.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtQuantity.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtRate.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                comboPay_Type.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                textDes.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
               
               
            
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dtTrans);
            dv.RowFilter = "NAME like '%" + txtSearch.Text + "%' or ITEM like '%" + txtSearch.Text + "%'";
            dataGridView1.DataSource = dv;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboTTYPE_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textDes_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textItem_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboPay_Type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
