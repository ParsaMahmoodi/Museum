using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Museum
{
    public partial class q : Form
    {
        public q()
        {
            InitializeComponent();
        }

        private void Show_Data()
        {
            MyData md = new MyData();
            md.strsql = "select * from ((((((Art_Obj full join Painting on Art_Obj.AO_Id = Painting.AO_Id) full join Sculpture on " +
                "Art_Obj.AO_Id = Sculpture.AO_Id) full join Statue on Art_Obj.AO_Id = Statue.AO_Id) full join Other on Art_Obj.AO_Id = Other.AO_Id) " +
                "full join Permanent on Art_Obj.AO_Id = Permanent.AO_Id) full join Borrowed on Art_Obj.AO_Id = Borrowed.AO_Id)";
            dgv_Art.DataSource = md.ShowData().DefaultView;
        }

        private void update()
        {
            string constr = "server=(local);database=Museum;integrated security=true";

            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter("SELECT A_Name FROM Artist", con))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    DataRow row = dt.NewRow();
                    dt.Rows.InsertAt(row, 0);
                    cb_Artist.DataSource = dt;
                    cb_Artist.DisplayMember = "A_Name";
                }
            }

            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter("SELECT C_Name FROM Collection", con))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    DataRow row = dt.NewRow();
                    dt.Rows.InsertAt(row, 0);
                    cb_Collection.DataSource = dt;
                    cb_Collection.DisplayMember = "C_Name";
                }
            }
        }

        private void frm_Art_Load(object sender, EventArgs e)
        {
            update();
            Show_Data();
        }

        private void btn_Artist_Add_Click(object sender, EventArgs e)
        {
            frm_Artists na2 = new frm_Artists();
            na2.ShowDialog();
            update();
        }

        private void btn_Collection_Add_Click(object sender, EventArgs e)
        {
            frm_Collections nc2 = new frm_Collections();
            nc2.ShowDialog();
            update();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            MyData md = new MyData();
            md.strsql = "INSERT INTO Art_Obj(AO_Id,Title,Year,Style,Description,Epoch,CountryOfOrigin,A_Name,C_Name,Type,Status) VALUES(" +
                txt_Id.Text + ",'" + txt_Title.Text + "','" + txt_Year.Text + "','" + txt_Style.Text + "','" + txt_Description.Text + "','" +
                txt_Epoch.Text + "','" + txt_Country.Text + "','" + cb_Artist.Text + "','" +
                cb_Collection.Text + "','" + cb_Type.Text + "','" + cb_Status.Text + "')";
            md.ManData();

            if (cb_Type.Text == "Painting")
            {
                md.strsql = "INSERT INTO Painting VALUES(" + txt_Id.Text + ",'" +
                    txt_Paint_Type.Text + "','" + txt_Material.Text + "')";
                md.ManData();
            }

            if (cb_Type.Text == "Statue" || cb_Type.Text == "Sculpture")
            {
                md.strsql = "INSERT INTO " + cb_Type.Text + " VALUES(" + txt_Id.Text + ",'" + txt_Material.Text +
                    "','" + txt_Height.Text + "','" + txt_Weight.Text + "')";
                md.ManData();
            }

            if (cb_Type.Text == "Other")
            {
                md.strsql = "INSERT INTO Other VALUES(" + txt_Id.Text + ",'" + txt_Other_Type.Text + "')";
                md.ManData();
            }

            if (cb_Status.Text == "Permanent")
            {
                md.strsql = "INSERT INTO Permanent VALUES(" + txt_Id.Text + ",'" + txt_Date_Acquired.Text +
                   "','" + txt_Permanent_Status.Text + "','" + txt_Cost.Text + "')";
                md.ManData();
            }

            if (cb_Status.Text == "Borrowed")
            {
                md.strsql = "INSERT INTO Borrowed VALUES(" + txt_Id.Text + ",'" + txt_Date_Borrowed.Text +
                   "','" + txt_Date_Returned.Text + "')";
                md.ManData();
            }

            Show_Data();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            MyData md = new MyData();
            md.strsql = "select * from ((((((Art_Obj full join Painting on Art_Obj.AO_Id = Painting.AO_Id) full join Sculpture on " +
                "Art_Obj.AO_Id = Sculpture.AO_Id) full join Statue on Art_Obj.AO_Id = Statue.AO_Id) full join Other on Art_Obj.AO_Id = Other.AO_Id) " +
                "full join Permanent on Art_Obj.AO_Id = Permanent.AO_Id) full join Borrowed on Art_Obj.AO_Id = Borrowed.AO_Id) where" +
                " Title like '" + txt_Title.Text + "%'";
            dgv_Art.DataSource = md.ShowData().DefaultView;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            MyData md = new MyData();

            md.strsql = "Delete from Borrowed where AO_Id = '" + txt_Id.Text + "'";
            md.ManData();

            md.strsql = "Delete from Permanent where AO_Id = '" + txt_Id.Text + "'";
            md.ManData();

            md.strsql = "Delete from Painting where AO_Id = '" + txt_Id.Text + "'";
            md.ManData();

            md.strsql = "Delete from Sculpture where AO_Id = '" + txt_Id.Text + "'";
            md.ManData();

            md.strsql = "Delete from Statue where AO_Id = '" + txt_Id.Text + "'";
            md.ManData();

            md.strsql = "Delete from Other where AO_Id = '" + txt_Id.Text + "'";
            md.ManData();

            md.strsql = "Delete from Art_Obj where AO_Id = '" + txt_Id.Text + "'";
            md.ManData();

            Show_Data();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            txt_Id.Text = dgv_Art.CurrentRow.Cells[0].Value.ToString();

            MyData md = new MyData();

            md.strsql = "Delete from Borrowed where AO_Id = '" + txt_Id.Text + "'";
            md.ManData();

            md.strsql = "Delete from Permanent where AO_Id = '" + txt_Id.Text + "'";
            md.ManData();

            md.strsql = "Delete from Painting where AO_Id = '" + txt_Id.Text + "'";
            md.ManData();

            md.strsql = "Delete from Sculpture where AO_Id = '" + txt_Id.Text + "'";
            md.ManData();

            md.strsql = "Delete from Statue where AO_Id = '" + txt_Id.Text + "'";
            md.ManData();

            md.strsql = "Delete from Other where AO_Id = '" + txt_Id.Text + "'";
            md.ManData();

            md.strsql = "Delete from Art_Obj where AO_Id = '" + txt_Id.Text + "'";
            md.ManData();

            md.strsql = "INSERT INTO Art_Obj(AO_Id,Title,Year,Style,Description,Epoch,CountryOfOrigin,A_Name,C_Name,Type,Status) VALUES(" +
                txt_Id.Text + ",'" + txt_Title.Text + "','" + txt_Year.Text + "','" + txt_Style.Text + "','" + txt_Description.Text + "','" +
                txt_Epoch.Text + "','" + txt_Country.Text + "','" + cb_Artist.Text + "','" +
                cb_Collection.Text + "','" + cb_Type.Text + "','" + cb_Status.Text + "')";
            md.ManData();

            if (cb_Type.Text == "Painting")
            {
                md.strsql = "INSERT INTO Painting VALUES(" + txt_Id.Text + ",'" +
                    txt_Paint_Type.Text + "','" + txt_Material.Text + "')";
                md.ManData();
            }

            if (cb_Type.Text == "Statue")
            {
                md.strsql = "INSERT INTO " + cb_Type.Text + " VALUES(" + txt_Id.Text + ",'" + txt_Material.Text +
                    "','" + txt_Height.Text + "','" + txt_Weight.Text + "')";
                md.ManData();
            }

            if (cb_Type.Text == "Sculpture")
            {
                md.strsql = "INSERT INTO " + cb_Type.Text + " VALUES(" + txt_Id.Text + ",'" + txt_Material.Text +
                    "','" + txt_Height.Text + "','" + txt_Weight.Text + "')";
                md.ManData();
            }

            if (cb_Type.Text == "Other")
            {
                md.strsql = "INSERT INTO Other VALUES(" + txt_Id.Text + ",'" + txt_Other_Type.Text + "')";
                md.ManData();
            }

            if (cb_Status.Text == "Permanent")
            {
                md.strsql = "INSERT INTO Permanent VALUES(" + txt_Id.Text + ",'" + txt_Date_Acquired.Text +
                   "','" + txt_Permanent_Status.Text + "','" + txt_Cost.Text + "')";
                md.ManData();
            }

            if (cb_Status.Text == "Borrowed")
            {
                md.strsql = "INSERT INTO Borrowed VALUES(" + txt_Id.Text + ",'" + txt_Date_Borrowed.Text +
                   "','" + txt_Date_Returned.Text + "')";
                md.ManData();
            }

            Show_Data();

        }
    }
}
