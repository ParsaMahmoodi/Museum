using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Museum
{
    public partial class frm_Collections : Form
    {
        public frm_Collections()
        {
            InitializeComponent();
        }

        private void Show_Data()
        {
            MyData md = new MyData();
            md.strsql = "select * from Collection";
            dgv_Collections.DataSource = md.ShowData().DefaultView;
        }

        private void frm_Collections_Load(object sender, EventArgs e)
        {
            Show_Data();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            MyData md = new MyData();
            md.strsql = "INSERT INTO Collection VALUES('" + txt_Name.Text + "','" + txt_Type.Text + "','" + txt_Description.Text + "','" +
                txt_Address.Text + "','" + txt_Phone.Text + "','" + txt_Contact.Text + "')";
            md.ManData();
            Show_Data();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            MyData md = new MyData();
            md.strsql = "update Collection set C_Name='" + txt_Name.Text + "',Type='" + txt_Type.Text + "',Description='" + txt_Description.Text +
                "',Address='" + txt_Address.Text + "',Phone='" + txt_Phone.Text  + "',Contact_Person='" + txt_Contact.Text +
                "' where C_Name='" + dgv_Collections.CurrentRow.Cells[0].Value.ToString() + "'";
            md.ManData();
            Show_Data();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            MyData md = new MyData();
            md.strsql = "select * from Collection where C_Name like '" + txt_Name.Text + "%' and Type like '" + txt_Type.Text +
                "%' and Contact_Person like '" + txt_Contact.Text + "%'";
            dgv_Collections.DataSource = md.ShowData().DefaultView;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            MyData md = new MyData();
            md.strsql = "Delete from Collection where C_Name = '" + txt_Name.Text + "'";
            md.ManData();
            Show_Data();
        }

        private void dgv_Collections_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Name.Text = dgv_Collections.CurrentRow.Cells[0].Value.ToString();
            txt_Type.Text = dgv_Collections.CurrentRow.Cells[1].Value.ToString();
            txt_Address.Text = dgv_Collections.CurrentRow.Cells[3].Value.ToString();
            txt_Contact.Text = dgv_Collections.CurrentRow.Cells[5].Value.ToString();
            txt_Description.Text = dgv_Collections.CurrentRow.Cells[2].Value.ToString();
            txt_Phone.Text = dgv_Collections.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
