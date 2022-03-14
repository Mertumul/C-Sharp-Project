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
    public partial class Frmdoctorlogin : Form
    {
        public Frmdoctorlogin()
        {
            InitializeComponent();
        }
        Sqlconnection cnt = new Sqlconnection();
        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from Tbl_Doctor where DoctorTC=@d1 and DoctorPassword=@d2", cnt.connection());
            command.Parameters.AddWithValue("@d1", mskTC.Text);
            command.Parameters.AddWithValue("@d2", txtpassword.Text);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                frmdoctordetail frd = new frmdoctordetail();
                frd.TC = mskTC.Text;
                frd.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Login Failed Try Again0", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            cnt.connection().Close();
        }
    }
}
