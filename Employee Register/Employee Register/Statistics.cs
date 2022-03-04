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
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=******;Initial Catalog=EmployeeDataBase;Integrated Security=True");
        private void Statistics_Load(object sender, EventArgs e)
        {
            //total employee num
            connection.Open();
            SqlCommand command1 = new SqlCommand("Select Count(*) from Tbl_Employee", connection);
            SqlDataReader dr1 = command1.ExecuteReader();
            while (dr1.Read())
            {
                lbltotalemployeenum.Text = dr1[0].ToString();
            }
            connection.Close();

            //Married Employee Number
            connection.Open();
            SqlCommand command2 = new SqlCommand("select count(*) from Tbl_Employee where Employee_MarriageStatus=1",connection);
            SqlDataReader dr2 = command2.ExecuteReader();
            while (dr2.Read())
            {
                lblmarriedemployeenum.Text = dr2[0].ToString();
            }
            connection.Close();
            //Single Employee Number
            connection.Open();
            SqlCommand command3 = new SqlCommand("select count(*) from Tbl_Employee where Employee_MarriageStatus=0", connection);
            SqlDataReader dr3 = command3.ExecuteReader();
            while (dr3.Read())
            {
                lblsingleemployeenum.Text = dr3[0].ToString();
            }
            connection.Close();
            // Number of Different citties
            connection.Open();
            SqlCommand command4 = new SqlCommand("Select Count(distinct(Employee_city)) from Tbl_Employee", connection);
            SqlDataReader dr4 = command4.ExecuteReader();
            while (dr4.Read())
            {
                lblnumofcities.Text = dr4[0].ToString();
            }

            connection.Close();
            // Number of different professions
            connection.Open();
            SqlCommand command5 = new SqlCommand("Select count(distinct(Employee_Job)) from Tbl_Employee",connection);
            SqlDataReader dr5 = command5.ExecuteReader();
            while (dr5.Read())
            {
                lblnumofdiffproffessions.Text = dr5[0].ToString();
            }
            connection.Close();
            //total salary
            connection.Open();
            SqlCommand command6 = new SqlCommand("Select Sum(Employee_salary) From Tbl_Employee",connection);
            SqlDataReader dr6 = command6.ExecuteReader();
            while (dr6.Read())
            {
                lbltotoalsalary.Text = dr6[0].ToString();
            }
            connection.Close();
            //Avarage Salary
            connection.Open();
            SqlCommand command7 = new SqlCommand("select Avg(Employee_salary) from Tbl_Employee", connection);
            SqlDataReader dr7 = command7.ExecuteReader();
            while (dr7.Read())
            {
                lblavaragesalary.Text = dr7[0].ToString();
                    }

            connection.Close();
        }

    }
}
