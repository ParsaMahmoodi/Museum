using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Museum
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void artToolStripMenuItem_Click(object sender, EventArgs e)
        {
            q na1 = new q();
            na1.ShowDialog();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Users nu1 = new frm_Users();
            nu1.ShowDialog();
        }

        private void collectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Collections nc1 = new frm_Collections();
            nc1.ShowDialog();
        }

        private void artistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Artists na1 = new frm_Artists();
            na1.ShowDialog();
        }

        private void exhibitionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Exhibitions ne1 = new frm_Exhibitions();
            ne1.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Report nr1 = new frm_Report();
            nr1.ShowDialog();
        }

        private void userToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection();
            con1.ConnectionString = "server = (local); database = Museum ; integrated security= true; ";
            con1.Open();
            SqlCommand c1 = new SqlCommand();
            c1.Connection = con1;
            c1.CommandText = "BACKUP DATABASE Museum TO DISK = 'D:\\Museum.bak' WITH FORMAT";
            c1.ExecuteNonQuery();
            con1.Close();
        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con1 = new SqlConnection();
                con1.ConnectionString = "server = (local); integrated security= true; ";
                con1.Open();
                SqlCommand c1 = new SqlCommand();
                c1.Connection = con1;
                c1.CommandText = "RESTORE DATABASE Museum FROM DISK =  'D:\\Museum.bak' WITH REPLACE";
                c1.ExecuteNonQuery();
                con1.Close();
            }
            catch { }
        }

        private void queryToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}
