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
    public partial class FrmMain : Form
    {
        void clear()
        {
            txtname.Text = "";
            txtsurname.Text = "";
            cmbcity.Text = "";
            mskdtxtsalary.Text = "";
            rdbtnsingle.Checked = false;
            rdbtnmarried.Checked = false;
            txtjob.Text = "";
            txtname.Focus();

        }
        public FrmMain()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-0ENUTSG;Initial Catalog=EmployeeDataBase;Integrated Security=True");

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          

        }

        private void btnlist_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeDataBaseDataSet.Tbl_Employee' table. You can move, or remove it, as needed.
            this.tbl_EmployeeTableAdapter.Fill(this.employeeDataBaseDataSet.Tbl_Employee);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Tbl_Employee (Employee_name,Employee_surname,Employee_city,Employee_salary,Employee_Job,Employee_MarriageStatus) values (@e1,@e2,@e3,@e4,@e5,@e6)",connection);
            command.Parameters.AddWithValue("@e1", txtname.Text);
            command.Parameters.AddWithValue("@e2", txtsurname.Text);
            command.Parameters.AddWithValue("@e3", cmbcity.Text);
            command.Parameters.AddWithValue("@e4", mskdtxtsalary.Text);
            command.Parameters.AddWithValue("@e5", txtjob.Text);
            command.Parameters.AddWithValue("@e6", label8.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Employee Added");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rdbtnmarried_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "True";

        }

        private void rdbtnsingle_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = "False";

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView1.SelectedCells[0].RowIndex;
            txtemployeeid.Text = dataGridView1.Rows[chosen].Cells[0].Value.ToString();
            txtname.Text = dataGridView1.Rows[chosen].Cells[1].Value.ToString();
            txtsurname.Text = dataGridView1.Rows[chosen].Cells[2].Value.ToString();
            cmbcity.Text = dataGridView1.Rows[chosen].Cells[3].Value.ToString();
            mskdtxtsalary.Text = dataGridView1.Rows[chosen].Cells[4].Value.ToString();
            label8.Text = dataGridView1.Rows[chosen].Cells[5].Value.ToString();
            if (label8.Text == "True")
            {
                rdbtnmarried.Select();
            }
            else if (label8.Text == "False")
            {
                rdbtnsingle.Select();
            }
            txtjob.Text = dataGridView1.Rows[chosen].Cells[6].Value.ToString();


        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand deletecommand = new SqlCommand("Delete From Tbl_Employee Where Employee_id=@d1",connection);
            deletecommand.Parameters.AddWithValue("@d1", txtemployeeid.Text);
            deletecommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Record Deleted");
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand updatecommand = new SqlCommand("Update Tbl_Employee Set Employee_name=@a1,Employee_surname=@a2,Employee_city=@a3,Employee_salary=@a4,Employee_Job=@a5,Employee_MarriageStatus=@a6 where Employee_id=@a7 ",connection);
            updatecommand.Parameters.AddWithValue("@a1", txtname.Text);
            updatecommand.Parameters.AddWithValue("@a2", txtsurname.Text);
            updatecommand.Parameters.AddWithValue("@a3", cmbcity.Text);
            updatecommand.Parameters.AddWithValue("@a4", mskdtxtsalary.Text);
            updatecommand.Parameters.AddWithValue("@a5", txtjob.Text);
            updatecommand.Parameters.AddWithValue("@a6", label8.Text);
            updatecommand.Parameters.AddWithValue("@a7", txtemployeeid.Text);
            updatecommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Record Updated");
        }

        private void btnstatistics_Click(object sender, EventArgs e)
        {
            Statistics fs1 = new Statistics();
            fs1.Show();
        }

        private void btngraphics_Click(object sender, EventArgs e)
        {
            FrmGraphics fr1 = new FrmGraphics();
            fr1.Show();
        }
    }
}
