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
    public partial class frmspecialtpanel : Form
    {
        public frmspecialtpanel()
        {
            InitializeComponent();
        }
        Sqlconnection cnt = new Sqlconnection();
        private void frmspecialtpanel_Load(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Specialty2", cnt.connection());
            da.Fill(tb);
            dataGridView1.DataSource = tb;


        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            SqlCommand command1 = new SqlCommand("insert into Tbl_Specialty2 (SpecialtyName) values(@s)", cnt.connection());
            command1.Parameters.AddWithValue("@s",textBox2.Text);
            command1.ExecuteNonQuery();
            cnt.connection().Close();
            MessageBox.Show("Specialty Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[chosen].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[chosen].Cells[1].Value.ToString();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            SqlCommand command2 = new SqlCommand("update Tbl_Specialty2  set SpecialtyName=@u1 where Specialtyid=@u2 ", cnt.connection());
            command2.Parameters.AddWithValue("@u2", textBox1.Text);
            command2.Parameters.AddWithValue("@u1", textBox2.Text);
            command2.ExecuteNonQuery();
            cnt.connection().Close();
            MessageBox.Show("Records Updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            SqlCommand command3 = new SqlCommand("delete from Tbl_Specialty2 where Specialtyid=@d1", cnt.connection());
            command3.Parameters.AddWithValue("@d1", textBox1.Text);
            command3.ExecuteNonQuery();
            cnt.connection().Close();
            MessageBox.Show("Records Deleted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
