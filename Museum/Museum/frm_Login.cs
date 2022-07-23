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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(
                "server=(local);database=Museum;integrated security=true");
            con1.Open();
            SqlCommand c1 = new SqlCommand();
            c1.CommandText = "select * from Users where U_Id='" + txt_Username.Text + "' and Pass='" + txt_Password.Text + "'";
            c1.Connection = con1;
            SqlDataReader dr = c1.ExecuteReader();
            object[] x = new object[3];
            if (dr.Read())
            {
                frm_Main f = new frm_Main();
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong");
            }
            con1.Close();
        }
    }
}
