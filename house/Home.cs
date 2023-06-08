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
    public partial class Home : Form
    {
        public Home(string name)
        {
            InitializeComponent();
            lblWelcome.Text = "Welcome " + name;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }

        private void ledgersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Form f in Application.OpenForms)
            {
                if(f.GetType()==typeof(Fam))
                {
                    f.Activate();
                    return;
                }
            }
            Fam frm = new Fam();
            frm.MdiParent = this;
            frm.Show();
        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(Transaction))
                {
                    f.Activate();
                    return;
                }
            }
            Transaction frm = new Transaction();
            frm.MdiParent = this;
            frm.Show();
        }

        private void itToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form[] child = this.MdiChildren;
            foreach(Form f in child)
            {
                f.Close();
            }
        }

        private void masterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(Settings))
                {
                    f.Activate();
                    return;
                }
            }
            Settings frm = new Settings();
            frm.MdiParent = this;
            frm.Show();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(Report))
                {
                    f.Activate();
                    return;
                }
            }
            Report frm = new Report();
            frm.MdiParent = this;
            frm.Show();

        }
    }
}
