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
    public partial class Frmsecretarydetail : Form
    {
        public Frmsecretarydetail()
        {
            InitializeComponent();
        }
         public string TCNO;
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        Sqlconnection cnt = new Sqlconnection();
        private void Frmsecretarydetail_Load(object sender, EventArgs e)
        {
            lblTC.Text = TCNO;

            // Name Surname
            SqlCommand command1 = new SqlCommand("select SecretaryNameSurname from Tbl_Secretary where SecretaryTC=@p1", cnt.connection());
            command1.Parameters.AddWithValue("@p1", lblTC.Text);
            SqlDataReader dr = command1.ExecuteReader();
            while (dr.Read())
            {
                lblnamesurname.Text = dr[0].ToString();
            }
            cnt.connection().Close();
            //transfer branches datagriedview
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Specialty2 ",cnt.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            //transfer doctors datagriedview
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select(DoctorName+' '+DoctorSurname) as 'Doctors',DoctorSpecialty from Tbl_Doctor", cnt.connection());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
            //transfer specialty to cmbbox
            SqlCommand command3 = new SqlCommand("select SpecialtyName from Tbl_Specialty2",cnt.connection());
            SqlDataReader drb = command3.ExecuteReader();
            while (drb.Read())
            {
                cmbspecialty.Items.Add(drb[0]);
            }
           
        }

        private void btnappointmentsave_Click(object sender, EventArgs e)
        {
            SqlCommand command2 = new SqlCommand("insert into Tbl_Appointment (AppointmentDate,AppointmentTime,AppointmentSpecialty,AppointmentDoctor) values(@r1,@r2,@r3,@r4)", cnt.connection());
            command2.Parameters.AddWithValue("@r1", mskappointmentdate.Text);
            command2.Parameters.AddWithValue("@r2", mskappointmenttime.Text);
            command2.Parameters.AddWithValue("@r3", cmbspecialty.Text);
            command2.Parameters.AddWithValue("@r4", cmbdoctor.Text);
            command2.ExecuteNonQuery();
            cnt.connection().Close();
            MessageBox.Show("Appointment Created.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void cmbspecialty_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoctor.Items.Clear();
            //transfer doctor to cmbbox
            SqlCommand command4 = new SqlCommand("select (DoctorName+' '+DoctorSurname) from Tbl_Doctor where DoctorSpecialty=@s1", cnt.connection());
            command4.Parameters.AddWithValue("@s1", cmbspecialty.Text);
            SqlDataReader drd = command4.ExecuteReader();
            while (drd.Read())
            {
                cmbdoctor.Items.Add(drd[0]);

            }
            cnt.connection().Close();

        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            SqlCommand command5 = new SqlCommand("insert into Tbl_Announcement (Announcement) values (@a1)", cnt.connection());
            command5.Parameters.AddWithValue("@a1", rchannouncement.Text);
            command5.ExecuteNonQuery();
            cnt.connection().Close();
            MessageBox.Show("Announcement was made", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btndocpanel_Click(object sender, EventArgs e)
        {
            Frmdoctorpanel drp = new Frmdoctorpanel();
            drp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmspecialtpanel frs = new frmspecialtpanel();
            frs.Show();
        }

        private void btnappointmentlist_Click(object sender, EventArgs e)
        {
            FrmAppointmentList frl = new FrmAppointmentList();
            frl.Show();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmannouncement fra = new frmannouncement();
            fra.Show();

        }
    }
}
