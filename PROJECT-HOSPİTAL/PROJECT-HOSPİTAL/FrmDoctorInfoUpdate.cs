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
    public partial class FrmDoctorInfoUpdate : Form
    {
        public FrmDoctorInfoUpdate()
        {
            InitializeComponent();
        }
        Sqlconnection cnt=new Sqlconnection();
        public string TC;
        private void FrmDoctorInfoUpdate_Load(object sender, EventArgs e)
        {
            mskdCno.Text = TC;
            SqlCommand command = new SqlCommand("select * from Tbl_Doctor where DoctorTC=@d1", cnt.connection());
            command.Parameters.AddWithValue("@d1", mskdCno.Text);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                txtname.Text = dr[1].ToString();
                txtsurname.Text = dr[2].ToString();
                cmbdocspecialty.Text = dr[3].ToString();
                txtpassword.Text = dr[5].ToString();

            }
            cnt.connection().Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlCommand command1 = new SqlCommand("update Tbl_Doctor set DoctorName=@d1,DoctorSurname=@d2,DoctorSpecialty=@d3,DoctorPassword=@d4 where DoctorTC=@d5", cnt.connection());
            command1.Parameters.AddWithValue("@d1", txtname.Text);
            command1.Parameters.AddWithValue("@d2", txtsurname.Text);
            command1.Parameters.AddWithValue("@d3", cmbdocspecialty.Text);
            command1.Parameters.AddWithValue("@d4", txtpassword.Text);
            command1.Parameters.AddWithValue("@d5", mskdCno.Text);
            command1.ExecuteNonQuery();
            cnt.connection().Close();
            MessageBox.Show("Record Updated!!!");
        }
    }
}
