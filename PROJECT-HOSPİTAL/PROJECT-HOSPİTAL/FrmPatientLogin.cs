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
    public partial class FrmPatientLogin : Form
    {
        public FrmPatientLogin()
        {
            InitializeComponent();
        }

        private void lnksignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmpatientregistration fr = new frmpatientregistration();
            fr.Show();
            this.Hide();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

           
        }
        Sqlconnection cnt = new Sqlconnection();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from Tbl_patient where PatientTc=@c1 and PatientPassword=@c2", cnt.connection());
            command.Parameters.AddWithValue("@c1", mskTC.Text);
            command.Parameters.AddWithValue("@c2", txtpassword.Text);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                FrmPatientDetail fr = new FrmPatientDetail();
                fr.tc = mskTC.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed Please Try Again");
                mskTC.Focus();
            }
            
        }
    }
}
