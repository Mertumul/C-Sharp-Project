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
    public partial class FrmPatientDetail : Form
    {
        public FrmPatientDetail()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmUpdateInfo fr = new FrmUpdateInfo();
            fr.TCnumber = lblTC.Text;

            fr.Show();
            this.Hide();
            
        }
        public string tc;
        Sqlconnection cnt = new Sqlconnection();
        private void FrmPatientDetail_Load(object sender, EventArgs e)
        {
            //Name and Surname
            lblTC.Text = tc;
            SqlCommand command = new SqlCommand("select PatientName,PatientSurname from Tbl_Patient where PatientTC=@c1", cnt.connection());
            command.Parameters.AddWithValue("@c1", lblTC.Text);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                lblnamesurname.Text = dr[0] + " " + dr[1];
            }
            cnt.connection().Close();
            //Appointment History

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Appointment where PatientTC=" + tc, cnt.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            //specialty
            SqlCommand command1 = new SqlCommand("select SpecialtyName from Tbl_Specialty2", cnt.connection());
            SqlDataReader dr2 = command1.ExecuteReader();
            while (dr2.Read())
            {
                vmbspecialty.Items.Add(dr2[0]);
            }
            cnt.connection().Close();

            
        }

        private void vmbspecialty_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoctor.Items.Clear();
            SqlCommand command3 = new SqlCommand("select DoctorName,DoctorSurname from Tbl_Doctor where DoctorSpecialty=@p1", cnt.connection());
            command3.Parameters.AddWithValue("@p1", vmbspecialty.Text);
            SqlDataReader dr3 = command3.ExecuteReader();
            while (dr3.Read())
            {
                cmbdoctor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            cnt.connection().Close();
        }
        //data gridwieve veri çekme

        private void cmbdoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Appointment where AppointmentSpecialty='" + vmbspecialty.Text + "'and AppointmentDoctor='"+cmbdoctor.Text+"' and AppointmentStatus=0", cnt.connection());
            da.Fill(tb);
            dataGridView2.DataSource = tb;
        }

        private void btnmakeappointment_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("update Tbl_Appointment set AppointmentStatus=1,PatientTC=@a1,PatientCompliment=@a2 where Appointmentid=@a3", cnt.connection());
            command.Parameters.AddWithValue("@a1", lblTC.Text);
            command.Parameters.AddWithValue("@a2", richtxtcomplaint.Text);
            command.Parameters.AddWithValue("@a3", txtid.Text);
            command.ExecuteNonQuery();
            cnt.connection().Close();
            MessageBox.Show("Appointment Made!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen2 = dataGridView2.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView2.Rows[chosen2].Cells[0].Value.ToString();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
