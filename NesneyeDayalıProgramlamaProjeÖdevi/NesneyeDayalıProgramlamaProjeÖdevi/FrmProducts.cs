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
    public partial class FrmProducts : Form
    {
        sqlconnenction cnt = new sqlconnenction();

        public FrmProducts()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
        //update the product information
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command1 = new SqlCommand("update Tbl_Stock set ProductWhere=@d1,ProductNumber=@d2,ProductName=@d3,ProductPrice=@d4,ProductPurchasePrice=@d6,ProductBrand=@d7," +
                "ProductCategory=@d8,ProductGender=@d9,ProductSize=@d10,ProductColour=@d11 where ProductCode=@d5", cnt.connection());
            command1.Parameters.AddWithValue("@d1", cmbProductWhere.Text);
            command1.Parameters.AddWithValue("@d2", txtproductnumber.Text);
            command1.Parameters.AddWithValue("@d3", txtproductname.Text);
            command1.Parameters.AddWithValue("@d4", txtproductprice.Text);
            command1.Parameters.AddWithValue("@d5", txtproductcode.Text);
            command1.Parameters.AddWithValue("@d6", txtproductpurchase.Text);
            command1.Parameters.AddWithValue("@d7", txtproductbrand.Text);
            command1.Parameters.AddWithValue("@d8", cmbproductcatagory.Text);
            command1.Parameters.AddWithValue("@d9", cmbproductgender.Text);
            command1.Parameters.AddWithValue("@d10", cmbproductsize.Text);
            command1.Parameters.AddWithValue("@d11", txtproductcolour.Text);



            MessageBox.Show(" Products Record Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            command1.ExecuteNonQuery();
            cnt.connection().Close();
        }
        //delete the product info
        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand command1 = new SqlCommand("delete from Tbl_Stock where ProductCode=@d1", cnt.connection());
            command1.Parameters.AddWithValue("@d1", txtproductcode.Text);
            command1.ExecuteNonQuery();
            MessageBox.Show(" Products Record Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            cnt.connection().Close();

        }

        private void FrmProducts_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from Tbl_Stock ", cnt.connection());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView1.SelectedCells[0].RowIndex;
            cmbProductWhere.Text = dataGridView1.Rows[chosen].Cells[1].Value.ToString();
            txtproductnumber.Text = dataGridView1.Rows[chosen].Cells[2].Value.ToString();
            txtproductname.Text = dataGridView1.Rows[chosen].Cells[3].Value.ToString();
            txtproductprice.Text = dataGridView1.Rows[chosen].Cells[4].Value.ToString();
            txtproductcode.Text = dataGridView1.Rows[chosen].Cells[5].Value.ToString();
            txtproductpurchase.Text = dataGridView1.Rows[chosen].Cells[6].Value.ToString();
            txtproductbrand.Text = dataGridView1.Rows[chosen].Cells[7].Value.ToString();
            cmbproductcatagory.Text = dataGridView1.Rows[chosen].Cells[8].Value.ToString();
            cmbproductgender.Text = dataGridView1.Rows[chosen].Cells[9].Value.ToString();
            cmbproductsize.Text = dataGridView1.Rows[chosen].Cells[10].Value.ToString();
            txtproductcolour.Text = dataGridView1.Rows[chosen].Cells[11].Value.ToString();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
