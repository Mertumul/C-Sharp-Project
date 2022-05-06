using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NesneyeDayalıProgramlamaProjeÖdevi
{
    public partial class CustomerInfo : Form

    {
        sqlconnenction cnt = new sqlconnenction();

        public CustomerInfo()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CustomerInfo_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from Tbl_Customer ", cnt.connection());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView1.SelectedCells[0].RowIndex;
            txtname.Text = dataGridView1.Rows[chosen].Cells[1].Value.ToString();
            txtsurname.Text = dataGridView1.Rows[chosen].Cells[2].Value.ToString();
            mskdTel.Text = dataGridView1.Rows[chosen].Cells[3].Value.ToString();
            txtpassword.Text= dataGridView1.Rows[chosen].Cells[4].Value.ToString();
            cmbgender.Text = dataGridView1.Rows[chosen].Cells[5].Value.ToString();
            mskdTC.Text = dataGridView1.Rows[chosen].Cells[6].Value.ToString();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command1 = new SqlCommand("update Tbl_Customer set CustomerName=@d1,CustomerSurname=@d2,CustomerTel=@d3,CustomerPassword=@d5,CustomerGender=@d6 where CustomerTC=@d4", cnt.connection());
            command1.Parameters.AddWithValue("@d1", txtname.Text);
            command1.Parameters.AddWithValue("@d2", txtsurname.Text);
            command1.Parameters.AddWithValue("@d3", mskdTel.Text);
            command1.Parameters.AddWithValue("@d5", txtpassword.Text);
            command1.Parameters.AddWithValue("@d4", mskdTC.Text);
            command1.Parameters.AddWithValue("@d6", cmbgender.Text);
            command1.ExecuteNonQuery();
            cnt.connection().Close();
            MessageBox.Show(" Customer Record Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand command2 = new SqlCommand("delete from Tbl_Customer where CustomerTC=@d1", cnt.connection());
            command2.Parameters.AddWithValue("@d1", mskdTC.Text);
            command2.ExecuteNonQuery();
            cnt.connection().Close();
            MessageBox.Show(" Customer Records Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
