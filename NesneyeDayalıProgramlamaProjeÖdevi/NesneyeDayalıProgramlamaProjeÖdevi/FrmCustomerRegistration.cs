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
    public partial class FrmCustomerRegistration : Form
    {
        public FrmCustomerRegistration()
        {
            InitializeComponent();
        }

        sqlconnenction cnt = new sqlconnenction();


        private void btnsignup_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into Tbl_Customer (CustomerName,CustomerSurname,CustomerTel,CustomerPassword,CustomerGender,CustomerTC) values (@p1,@p2,@p3,@p4,@p5,@p6)", cnt.connection());
            command.Parameters.AddWithValue("@p1", txtname.Text);
            command.Parameters.AddWithValue("@p2", txtsurname.Text);
            command.Parameters.AddWithValue("@p3", msktel.Text);
            command.Parameters.AddWithValue("@p4", txtpassword.Text);
            command.Parameters.AddWithValue("@p5", cmbgender.Text);
            command.Parameters.AddWithValue("@p6", mskdCno.Text);
            command.ExecuteNonQuery();
            cnt.connection().Close();
            MessageBox.Show("Registration is done ,Your Password:" + txtpassword.Text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmCustomerRegistration_Load(object sender, EventArgs e)
        {
            txtname.Focus();
        }
    }
}
