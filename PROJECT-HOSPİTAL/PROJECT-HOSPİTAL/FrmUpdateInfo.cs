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
    public partial class FrmUpdateInfo : Form
    {
        public string TCnumber;
        public FrmUpdateInfo()
        {
            InitializeComponent();
        }
        Sqlconnection cnt = new Sqlconnection();
        
        private void FrmUpdateInfo_Load(object sender, EventArgs e)
        {
            mskdCno.Text = TCnumber;
            SqlCommand command1 = new SqlCommand("select * from Tbl_Patient where PatientTC=@p1",cnt.connection());
            command1.Parameters.AddWithValue("@p1", mskdCno.Text);
            SqlDataReader dr = command1.ExecuteReader();
            while (dr.Read())
            {
                txtname.Text = dr[1].ToString();
                txtsurname.Text = dr[2].ToString();
                msktel.Text = dr[3].ToString();
                msktel.Text = dr[4].ToString();
                txtpassword.Text = dr[5].ToString();
                cmbgender.Text = dr[6].ToString();
                
            }
            cnt.connection().Close();
            




        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlCommand command2 = new SqlCommand("update  Tbl_Patient set PatientName=@p1,PatientSurname=@p2,PatienttTel=@p3,PatientPassword=@p4,PatienGender=@p5 where PatientTC=@p6", cnt.connection());
            command2.Parameters.AddWithValue("@p1", txtname.Text);
            command2.Parameters.AddWithValue("@p2", txtsurname.Text);
            command2.Parameters.AddWithValue("@p3", msktel.Text);
            command2.Parameters.AddWithValue("@p4", txtpassword.Text);
            command2.Parameters.AddWithValue("@p5", cmbgender.Text);
            command2.Parameters.AddWithValue("@p6", mskdCno.Text);
            command2.ExecuteNonQuery();
            cnt.connection().Close();
            MessageBox.Show("Rocords  Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
