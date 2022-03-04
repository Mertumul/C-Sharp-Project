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
namespace Employee_Register
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=******;Initial Catalog=EmployeeDataBase;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select * from Tbl_Admin where Username=@c1 and Password=@c2", connection);

            command.Parameters.AddWithValue("@c1", txtusername.Text);
            command.Parameters.AddWithValue("@c2", txtpassword.Text);
            SqlDataReader dr1 = command.ExecuteReader();
            if (dr1.Read())
            {
                FrmMain f1 = new FrmMain();
                f1.Show();
                this.Hide();
      
            }
            else
            {
                MessageBox.Show("Login Failed Try again","Information",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtusername.Text = "";
                txtpassword.Text = "";
                txtusername.Focus();
            }
            connection.Close();
        }
    }
}
