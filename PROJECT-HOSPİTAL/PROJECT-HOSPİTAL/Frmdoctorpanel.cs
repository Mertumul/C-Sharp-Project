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

namespace PROJECT_HOSPİTAL
{
    public partial class Frmdoctorpanel : Form
    {
        public Frmdoctorpanel()
        {
            InitializeComponent();
        }
        Sqlconnection cnt = new Sqlconnection();
        private void btnadd_Click(object sender, EventArgs e)
        {
            SqlCommand command1 = new SqlCommand("insert into Tbl_Doctor (DoctorName,DoctorSurname,DoctorSpecialty,DoctorTC,DoctorPassword) values(@d1,@d2,@d3,@d4,@d5)",cnt.connection());
            command1.Parameters.AddWithValue("@d1", txtname.Text);
            command1.Parameters.AddWithValue("@d2", txtsurname.Text);
            command1.Parameters.AddWithValue("@d3", cmbspecialty.Text);
            command1.Parameters.AddWithValue("@d4", msktc.Text);
            command1.Parameters.AddWithValue("@d5", txtpassword.Text);
            command1.ExecuteNonQuery();
            cnt.connection().Close();
            MessageBox.Show("Doctor added!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Frmdoctorpanel_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from Tbl_Doctor ", cnt.connection());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            //Transfer to specialty to cmbbox
            SqlCommand command4 = new SqlCommand("select SpecialtyName from Tbl_Specialty2",cnt.connection());
            SqlDataReader drs = command4.ExecuteReader();
            while (drs.Read())
            {
                cmbspecialty.Items.Add(drs[0]);
            }

        }

        private void cmbspecialty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void msktc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView1.SelectedCells[0].RowIndex;
            txtname.Text = dataGridView1.Rows[chosen].Cells[1].Value.ToString();
            txtsurname.Text = dataGridView1.Rows[chosen].Cells[2].Value.ToString();
            cmbspecialty.Text = dataGridView1.Rows[chosen].Cells[3].Value.ToString();
            msktc.Text = dataGridView1.Rows[chosen].Cells[4].Value.ToString();
            txtpassword.Text = dataGridView1.Rows[chosen].Cells[5].Value.ToString();

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            SqlCommand command2 = new SqlCommand("delete from Tbl_Doctor where DoctorTc=@d1", cnt.connection());
            command2.Parameters.AddWithValue("@d1", msktc.Text);
            command2.ExecuteNonQuery();
            cnt.connection().Close();
            MessageBox.Show("Records Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            SqlCommand command3 = new SqlCommand("update Tbl_Doctor set DoctorName=@d1,DoctorSurname=@d2,DoctorSpecialty=@d3,DoctorPassword=@d5 where DoctorTc=@d4", cnt.connection());
            command3.Parameters.AddWithValue("@d1", txtname.Text);
            command3.Parameters.AddWithValue("@d2", txtsurname.Text);
            command3.Parameters.AddWithValue("@d3", cmbspecialty.Text);
            command3.Parameters.AddWithValue("@d4", msktc.Text);
            command3.Parameters.AddWithValue("@d5", txtpassword.Text);
            command3.ExecuteNonQuery();
            cnt.connection().Close();
            MessageBox.Show("Record Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
