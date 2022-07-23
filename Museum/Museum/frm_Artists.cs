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
    public partial class frm_Artists : Form
    {
        public frm_Artists()
        {
            InitializeComponent();
        }

        private void Show_Data()
        {
            MyData md = new MyData();
            md.strsql = "select * from Artist";
            dgv_Artists.DataSource = md.ShowData().DefaultView;
        }

        private void frm_Artists_Load(object sender, EventArgs e)
        {
            Show_Data();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            MyData md = new MyData();
            md.strsql = "INSERT INTO Artist VALUES('" + txt_Name.Text + "','" + txt_Date_Born.Text + "','" + txt_Date_Died.Text + "','" +
                txt_Country.Text + "','" + txt_Epoch.Text + "','" + txt_Main_Style.Text + "','" + txt_Description.Text + "')";
            md.ManData();
            Show_Data();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            MyData md = new MyData();
            md.strsql = "update Artist set A_Name='" + txt_Name.Text + "',Date_Born='" + txt_Date_Born.Text + "',Date_Died='" + txt_Date_Died.Text +
                "',CountryofOrigin='" + txt_Country.Text + "',Epoch='" + txt_Epoch.Text + "',Main_Style='" + txt_Main_Style.Text + "',Description='"
                + txt_Description.Text + "' where A_Name='" + dgv_Artists.CurrentRow.Cells[0].Value.ToString() + "'";
            md.ManData();
            Show_Data();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            MyData md = new MyData();
            md.strsql = "select * from Artist where A_Name like '" + txt_Name.Text + "%' and Date_Born like '" + txt_Date_Born.Text +
                "%' and Date_Died like '" + txt_Date_Died.Text + "%' and CountryofOrigin like '" + txt_Country.Text + "%' and Epoch like '" +
                txt_Epoch.Text + "%' and Main_Style like '" + txt_Main_Style.Text + "%'";
            dgv_Artists.DataSource = md.ShowData().DefaultView;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            MyData md = new MyData();
            md.strsql = "Delete from Artist where A_Name = '" + txt_Name.Text + "'";
            md.ManData();
            Show_Data();
        }

        private void dgv_Artists_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Name.Text = dgv_Artists.CurrentRow.Cells[0].Value.ToString();
            txt_Date_Born.Text = dgv_Artists.CurrentRow.Cells[1].Value.ToString();
            txt_Date_Died.Text = dgv_Artists.CurrentRow.Cells[2].Value.ToString();
            txt_Country.Text = dgv_Artists.CurrentRow.Cells[3].Value.ToString();
            txt_Epoch.Text = dgv_Artists.CurrentRow.Cells[4].Value.ToString();
            txt_Main_Style.Text = dgv_Artists.CurrentRow.Cells[5].Value.ToString();
            txt_Description.Text = dgv_Artists.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
