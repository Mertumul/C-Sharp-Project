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
    public partial class Frmsecretarylogin : Form
    {
        public Frmsecretarylogin()
        {
            InitializeComponent();
        }
        Sqlconnection cnt =  new Sqlconnection();
        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlCommand command1 = new SqlCommand("select * from Tbl_Secretary where SecretaryTC=@p1 and SecretaryPassword=@p2", cnt.connection());
            command1.Parameters.AddWithValue("@p1", mskTC.Text);
            command1.Parameters.AddWithValue("@p2", txtpassword.Text);
            SqlDataReader dr = command1.ExecuteReader();
            if (dr.Read())
            {
                Frmsecretarydetail frs = new Frmsecretarydetail();
                frs.TCNO = mskTC.Text;
                frs.Show();
                
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Login!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void Frmsecretarylogin_Load(object sender, EventArgs e)
        {

        }
    }
}
