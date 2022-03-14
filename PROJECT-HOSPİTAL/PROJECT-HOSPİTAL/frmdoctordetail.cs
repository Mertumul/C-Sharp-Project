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
    public partial class frmdoctordetail : Form
    {
        public frmdoctordetail()
        {
            InitializeComponent();
        }
        Sqlconnection cnt = new Sqlconnection();
        public string TC;
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmdoctordetail_Load(object sender, EventArgs e)   
        {
            lblTC.Text = TC;
            SqlCommand command = new SqlCommand("select DoctorName,DoctorSurname from Tbl_Doctor where DoctorTC=@a1",cnt.connection());
            command.Parameters.AddWithValue("@a1", lblTC.Text);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                lblnamesurname.Text = dr[0] + " " + dr[1];
            }
            cnt.connection().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Appointment where AppointmentDoctor='"+lblnamesurname.Text+"'", cnt.connection());
            da.Fill(dt);
            dataGridView1.DataSource= dt;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btneditinfo_Click(object sender, EventArgs e)
        {
            FrmDoctorInfoUpdate frd = new FrmDoctorInfoUpdate();
            frd.TC = lblTC.Text;
            frd.Show();
        }

        private void btnaanouncement_Click(object sender, EventArgs e)
        {
            frmannouncement fra = new frmannouncement();
            fra.Show();
        }

        private void btnquit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView1.SelectedCells[0].RowIndex;
            rchcomplaint.Text = dataGridView1.Rows[chosen].Cells[7].Value.ToString();
        }
    }
}
