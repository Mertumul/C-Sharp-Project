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
    public partial class Supplier : Form
    {
        public Supplier()
        {
            InitializeComponent();
        }
        sqlconnenction cnt = new sqlconnenction();


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            SqlCommand command1 = new SqlCommand("insert into Tbl_Supplier (SupplierName,SupplierSurname,SupplierGender,SupplierTel,SupplierTC) values(@d1,@d2,@d3,@d4,@d5)", cnt.connection());
            command1.Parameters.AddWithValue("@d1", txtname.Text);
            command1.Parameters.AddWithValue("@d2", txtsurname.Text);
            command1.Parameters.AddWithValue("@d3", cmbgender.Text);
            command1.Parameters.AddWithValue("@d4", mskdTel.Text);
            command1.Parameters.AddWithValue("@d5", mskdTC.Text);
            command1.ExecuteNonQuery();
            cnt.connection().Close();
            MessageBox.Show("Supplier added!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            SqlCommand command2 = new SqlCommand("delete from Tbl_Supplier where SupplierTC=@d1", cnt.connection());
            command2.Parameters.AddWithValue("@d1", mskdTC.Text);
            command2.ExecuteNonQuery();
            cnt.connection().Close();
            MessageBox.Show(" Suppliers Records Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            SqlCommand command3 = new SqlCommand("update Tbl_Supplier set SupplierName=@d1,SupplierSurname=@d2,SupplierGender=@d3,SupplierTel=@d5 where SupplierTC=@d4", cnt.connection());
            command3.Parameters.AddWithValue("@d1", txtname.Text);
            command3.Parameters.AddWithValue("@d2", txtsurname.Text);
            command3.Parameters.AddWithValue("@d3", cmbgender.Text);
            command3.Parameters.AddWithValue("@d4", mskdTC.Text);
            command3.Parameters.AddWithValue("@d5", mskdTel.Text);
            command3.ExecuteNonQuery();
            cnt.connection().Close();
            MessageBox.Show(" Suppliers Record Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from Tbl_Supplier ", cnt.connection());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select * from Tbl_Order ", cnt.connection());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView1.SelectedCells[0].RowIndex;
            txtname.Text = dataGridView1.Rows[chosen].Cells[1].Value.ToString();
            txtsurname.Text = dataGridView1.Rows[chosen].Cells[2].Value.ToString();
            cmbgender.Text = dataGridView1.Rows[chosen].Cells[3].Value.ToString();
            mskdTel.Text = dataGridView1.Rows[chosen].Cells[4].Value.ToString();
            mskdTC.Text = dataGridView1.Rows[chosen].Cells[5].Value.ToString();
            txtordersuppliername.Text = dataGridView1.Rows[chosen].Cells[1].Value.ToString();
            txtordersuppliersurname.Text = dataGridView1.Rows[chosen].Cells[2].Value.ToString();
            mskdordersuppliertc.Text = dataGridView1.Rows[chosen].Cells[5].Value.ToString();



        }

        private void button2_Click(object sender, EventArgs e)
        { }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlCommand command1 = new SqlCommand("insert into Tbl_Order (OrderSupplierName,OrderSupplierSurname,OrderSupplierTC,OrderProductName,OrderProductNumber,OrderProductWhere,OrderProductPrice,OrderProductCode,OrderProductPurchasePrice," +
                "OrderProductBrand,OrderProductCategory,OrderProductGender,OrderProductSize,OrderProductColour) values(@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10,@d11,@d12,@d13,@d14)", cnt.connection());
            command1.Parameters.AddWithValue("@d1", txtordersuppliername.Text);
            command1.Parameters.AddWithValue("@d2", txtordersuppliersurname.Text);
            command1.Parameters.AddWithValue("@d3", mskdordersuppliertc.Text);
            command1.Parameters.AddWithValue("@d4", txtproductname.Text);
            command1.Parameters.AddWithValue("@d5", txtproductnumber.Text);
            command1.Parameters.AddWithValue("@d6", cmbProductWhere.Text);
            command1.Parameters.AddWithValue("@d7", txtproductprice.Text);
            command1.Parameters.AddWithValue("@d8", txtproductcode.Text);
            command1.Parameters.AddWithValue("@d9", txtproductpurchase.Text);
            command1.Parameters.AddWithValue("@d10", txtproductbrand.Text);
            command1.Parameters.AddWithValue("@d11", cmbproductcatagory.Text);
            command1.Parameters.AddWithValue("@d12", cmbproductgender.Text);
            command1.Parameters.AddWithValue("@d13", cmbproductsize.Text);
            command1.Parameters.AddWithValue("@d14", txtproductcolour.Text);



            command1.ExecuteNonQuery();
            MessageBox.Show("Order added!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            SqlCommand command2 = new SqlCommand("insert into Tbl_Stock (ProductWhere,ProductNumber,ProductName,ProductPrice,ProductCode,ProductPurchasePrice,ProductBrand,ProductCategory,ProductGender,ProductSize,ProductColour) " +
                "values(@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10,@d11)", cnt.connection());
            command2.Parameters.AddWithValue("@d1", cmbProductWhere.Text);
            command2.Parameters.AddWithValue("@d2", txtproductnumber.Text);
            command2.Parameters.AddWithValue("@d3", txtproductname.Text);
            command2.Parameters.AddWithValue("@d4", txtproductprice.Text);
            command2.Parameters.AddWithValue("@d5", txtproductcode.Text);
            command2.Parameters.AddWithValue("@d6", txtproductpurchase.Text);
            command2.Parameters.AddWithValue("@d7", txtproductbrand.Text);
            command2.Parameters.AddWithValue("@d8", cmbproductcatagory.Text);
            command2.Parameters.AddWithValue("@d9", cmbproductgender.Text);
            command2.Parameters.AddWithValue("@d10", cmbproductsize.Text);
            command2.Parameters.AddWithValue("@d11", txtproductcolour.Text);



            command2.ExecuteNonQuery();
            cnt.connection().Close();
        }

        private void btn_orderdelete_Click(object sender, EventArgs e)
        {
            SqlCommand command1 = new SqlCommand("delete from Tbl_Order where OrderProductCode=@d1", cnt.connection());
            command1.Parameters.AddWithValue("@d1", txtproductcode.Text);
            command1.ExecuteNonQuery();
            MessageBox.Show(" Orders Records Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            SqlCommand command2 = new SqlCommand("delete from Tbl_Stock where ProductCode=@d1", cnt.connection());
            command2.Parameters.AddWithValue("@d1", txtproductcode.Text);
            command2.ExecuteNonQuery();
            cnt.connection().Close();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView2.SelectedCells[0].RowIndex;
            txtordersuppliername.Text = dataGridView2.Rows[chosen].Cells[1].Value.ToString();
            txtordersuppliersurname.Text = dataGridView2.Rows[chosen].Cells[2].Value.ToString();
            mskdordersuppliertc.Text = dataGridView2.Rows[chosen].Cells[3].Value.ToString();
            txtproductname.Text = dataGridView2.Rows[chosen].Cells[4].Value.ToString();
            txtproductnumber.Text = dataGridView2.Rows[chosen].Cells[5].Value.ToString();
            cmbProductWhere.Text = dataGridView2.Rows[chosen].Cells[6].Value.ToString();
            txtproductprice.Text = dataGridView2.Rows[chosen].Cells[7].Value.ToString();
            txtproductcode.Text = dataGridView2.Rows[chosen].Cells[8].Value.ToString();
            txtproductpurchase.Text = dataGridView2.Rows[chosen].Cells[9].Value.ToString();
            txtproductbrand.Text = dataGridView2.Rows[chosen].Cells[10].Value.ToString();
            cmbproductcatagory.Text = dataGridView2.Rows[chosen].Cells[11].Value.ToString();
            cmbproductgender.Text = dataGridView2.Rows[chosen].Cells[12].Value.ToString();
            cmbproductsize.Text = dataGridView2.Rows[chosen].Cells[13].Value.ToString();
            txtproductcolour.Text = dataGridView2.Rows[chosen].Cells[14].Value.ToString();


        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command1 = new SqlCommand("update Tbl_Order set OrderSupplierName=@d1,OrderSupplierSurname=@d2,OrderSupplierTC=@d3,OrderProductName=@d4,OrderProductNumber=@d5,OrderProductWhere=@d6,OrderProductPrice=@d7," +
                "OrderProductPurchasePrice=@d9,OrderProductBrand=@d10,OrderProductCategory=@d11,OrderProductGender=@d12,OrderProductSize=@d13,OrderProductColour=@d14 where OrderProductCode=@d8 ", cnt.connection());
            command1.Parameters.AddWithValue("@d1", txtordersuppliername.Text);
            command1.Parameters.AddWithValue("@d2", txtordersuppliersurname.Text);
            command1.Parameters.AddWithValue("@d3", mskdordersuppliertc.Text);
            command1.Parameters.AddWithValue("@d4", txtproductname.Text);
            command1.Parameters.AddWithValue("@d5", txtproductnumber.Text);
            command1.Parameters.AddWithValue("@d6", cmbProductWhere.Text);
            command1.Parameters.AddWithValue("@d7", txtproductprice.Text);
            command1.Parameters.AddWithValue("@d8", txtproductcode.Text);
            command1.Parameters.AddWithValue("@d9", txtproductpurchase.Text);
            command1.Parameters.AddWithValue("@d10", txtproductbrand.Text);
            command1.Parameters.AddWithValue("@d11", cmbproductcatagory.Text);
            command1.Parameters.AddWithValue("@d12", cmbproductgender.Text);
            command1.Parameters.AddWithValue("@d13", cmbproductsize.Text);
            command1.Parameters.AddWithValue("@d14", txtproductcolour.Text);



            command1.ExecuteNonQuery();
            MessageBox.Show(" Orders Record Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            SqlCommand command2 = new SqlCommand("update Tbl_Stock set ProductWhere=@d1,ProductNumber=@d2,ProductName=@d3,ProductPrice=@d4,ProductPurchasePrice=@d6,ProductBrand=@d7," +
                "ProductCategory=@d8,ProductGender=@d9,ProductSize=@d10,ProductColour=@d11 where ProductCode=@d5", cnt.connection());
            command2.Parameters.AddWithValue("@d1", cmbProductWhere.Text);
            command2.Parameters.AddWithValue("@d2", txtproductnumber.Text);
            command2.Parameters.AddWithValue("@d3", txtproductname.Text);
            command2.Parameters.AddWithValue("@d4", txtproductprice.Text);
            command2.Parameters.AddWithValue("@d5", txtproductcode.Text);
            command2.Parameters.AddWithValue("@d6", txtproductpurchase.Text);
            command2.Parameters.AddWithValue("@d7", txtproductbrand.Text);
            command2.Parameters.AddWithValue("@d8", cmbproductcatagory.Text);
            command2.Parameters.AddWithValue("@d9", cmbproductgender.Text);
            command2.Parameters.AddWithValue("@d10", cmbproductsize.Text);
            command2.Parameters.AddWithValue("@d11", txtproductcolour.Text);




            command2.ExecuteNonQuery();
            cnt.connection().Close();

        }
    }
}
