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
    public partial class frm_Exhibitions : Form
    {
        public frm_Exhibitions()
        {
            InitializeComponent();
        }

         private void Show_Data()
        {
            MyData md = new MyData();
            md.strsql = "select * from Exhibition";
            dgv_Exhibition.DataSource = md.ShowData().DefaultView;
        }

        private void frm_Exhibitions_Load(object sender, EventArgs e)
        {
            Show_Data();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            MyData md = new MyData();
            md.strsql = "INSERT INTO Exhibition (Name, Start_Date, End_Date) VALUES('" + txt_Name.Text + "','" + txt_Start_Date.Text + "','" + txt_End_Date.Text + "')";
            md.ManData();
            Show_Data();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            MyData md = new MyData();
            md.strsql = "update Exhibition set Name='" + txt_Name.Text + "',Start_Date='" + txt_Start_Date.Text + "',End_Date='" + txt_End_Date.Text + "' where E_Id='" + dgv_Exhibition.CurrentRow.Cells[0].Value.ToString() + "'";
            md.ManData();
            Show_Data();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            MyData md = new MyData();
            md.strsql = "select * from Exhibition where Name like '" + txt_Name.Text + "%'";
            dgv_Exhibition.DataSource = md.ShowData().DefaultView;
        }

        private void dgv_Exhibition_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Name.Text = dgv_Exhibition.CurrentRow.Cells[1].Value.ToString();
            txt_Start_Date.Text = dgv_Exhibition.CurrentRow.Cells[2].Value.ToString();
            txt_End_Date.Text = dgv_Exhibition.CurrentRow.Cells[3].Value.ToString();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            MyData md = new MyData();
            md.strsql = "Delete from Exhibition where Name = '" + txt_Name.Text + "'";
            md.ManData();
            Show_Data();
        }
    }
}
