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
    public partial class frm_Users : Form
    {
        public frm_Users()
        {
            InitializeComponent();
        }

        private void frm_Users_Load(object sender, EventArgs e)
        {
            show_data();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            MyData md = new MyData();
            md.strsql = "insert into Users values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            md.ManData();
            show_data();
        }

        private void show_data()
        {
            MyData md = new MyData();
            md.strsql = "select * from Users";
            dataGridView1.DataSource = md.ShowData().DefaultView;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            MyData md = new MyData();
            md.strsql = "delete from Users where U_Id = '" + textBox1.Text + "'";
            md.ManData();
            show_data();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            MyData md = new MyData();
            md.strsql = "update Users set U_Id='" + textBox1.Text + "',Pass='" + textBox2.Text + "',First_Name='" + textBox3.Text + "',Last_Name='" + textBox4.Text + "' where U_Id='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
            md.ManData();
            show_data();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            MyData md = new MyData();
            md.strsql = "select * from Users where U_Id like '" + textBox1.Text + "%' and First_Name like'" + textBox3.Text + "%' and Last_Name like '" + textBox4.Text + "%'";
            dataGridView1.DataSource = md.ShowData().DefaultView;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
