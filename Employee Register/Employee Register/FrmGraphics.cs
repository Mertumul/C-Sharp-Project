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
    public partial class FrmGraphics : Form
    {
        public FrmGraphics()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=*******;Initial Catalog=EmployeeDataBase;Integrated Security=True");

        private void FrmGraphics_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command1 = new SqlCommand("select Employee_city,count(*) from Tbl_Employee group by Employee_city", connection);
            SqlDataReader rd1 = command1.ExecuteReader();
            while (rd1.Read())
            {
                chart1.Series["Cities"].Points.AddXY(rd1[0], rd1[1]);
            }
            connection.Close();

            connection.Open();
            SqlCommand command2 = new SqlCommand("select Employee_Job,Avg(Employee_salary) From Tbl_Employee group by Employee_job",connection);
            SqlDataReader rd2 = command2.ExecuteReader();
            while (rd2.Read())
            {
                chart2.Series["Salaries"].Points.AddXY(rd2[0], rd2[1]);
            }
            connection.Close();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
