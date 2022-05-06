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
    public partial class FrmCustomerLogin : Form
    {
        public FrmCustomerLogin()
        {
            InitializeComponent();
        }

        private void lnksignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmCustomerRegistration fr = new FrmCustomerRegistration();
            fr.Show();
        }

        private void FrmCustomerLogin_Load(object sender, EventArgs e)
        {

        }
        sqlconnenction cnt = new sqlconnenction();


        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from Tbl_Customer where CustomerTC=@c1 and CustomerPassword=@c2", cnt.connection());
            command.Parameters.AddWithValue("@c1", mskdTc.Text);
            command.Parameters.AddWithValue("@c2", txtpassword.Text);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                FrmCustomerDetail fr = new FrmCustomerDetail();
                fr.tc = mskdTc.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed Please Try Again");
                mskdTc.Focus();
            }

        }
    }
}
