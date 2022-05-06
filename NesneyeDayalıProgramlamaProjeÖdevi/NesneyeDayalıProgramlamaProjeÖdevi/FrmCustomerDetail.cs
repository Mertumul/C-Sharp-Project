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
    public partial class FrmCustomerDetail : Form
    {
        public FrmCustomerDetail()
        {
            InitializeComponent();
        }
        public string tc;
        sqlconnenction cnt = new sqlconnenction();

        private void FrmCustomerDetail_Load(object sender, EventArgs e)
        {
            lblTC.Text = tc;
            //Name and Surname
            lblTC.Text = tc;
            SqlCommand command = new SqlCommand("select CustomerName,CustomerSurname from Tbl_Customer where CustomerTC=@c1", cnt.connection());
            command.Parameters.AddWithValue("@c1", lblTC.Text);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                lblnamesurname.Text = dr[0] + " " + dr[1];
            }
            cnt.connection().Close();
            //datatable Products
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select ProductCode,ProductName,ProductNumber,ProductBrand,ProductPrice,ProductCategory," +
                "ProductGender,ProductSize,ProductColour from Tbl_Stock ", cnt.connection());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = dataGridView1.SelectedCells[0].RowIndex;
            txtproductcode.Text = dataGridView1.Rows[chosen].Cells[0].Value.ToString();
            txtproductname.Text = dataGridView1.Rows[chosen].Cells[1].Value.ToString();
            txtproductbrand.Text = dataGridView1.Rows[chosen].Cells[3].Value.ToString();
            txtproductprice.Text = dataGridView1.Rows[chosen].Cells[4].Value.ToString();
            cmbproductcatagory.Text = dataGridView1.Rows[chosen].Cells[5].Value.ToString();
            cmbproductgender.Text = dataGridView1.Rows[chosen].Cells[6].Value.ToString();
            cmbproductsize.Text = dataGridView1.Rows[chosen].Cells[7].Value.ToString();
            txtproductcolour.Text = dataGridView1.Rows[chosen].Cells[8].Value.ToString();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FrmCustomerDetail fr = new FrmCustomerDetail();
            fr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command1 = new SqlCommand("select ProductWhere,ProductNumber,ProductPurchasePrice from Tbl_Stock where ProductCode=@d1", cnt.connection());
            command1.Parameters.AddWithValue("@d1", txtproductcode.Text);
            SqlDataReader dr = command1.ExecuteReader();
            while (dr.Read())
            {
                cmbProductWhere.Text = dr[0].ToString();
                txtnumberact.Text = dr[1].ToString();
                txtproductpurchase.Text = dr[2].ToString();
            }
            int actnum = Convert.ToInt32(txtnumberact.Text);
            int num_that_you_want = Convert.ToInt32(txtproductnumber.Text);
            int remain = actnum - num_that_you_want;
            if (actnum >num_that_you_want)
            {
                //update the stock table(products)
                SqlCommand command2 = new SqlCommand("update Tbl_Stock set ProductWhere=@d1,ProductNumber=@d2,ProductName=@d3,ProductPrice=@d4,ProductPurchasePrice=@d6,ProductBrand=@d7," +
                "ProductCategory=@d8,ProductGender=@d9,ProductSize=@d10,ProductColour=@d11 where ProductCode=@d5", cnt.connection());
                command2.Parameters.AddWithValue("@d1", cmbProductWhere.Text);
                command2.Parameters.AddWithValue("@d2", remain.ToString());
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
                //transfer to sales table
                SqlCommand command3 = new SqlCommand("insert into Tbl_Sales (SalesProductCustomer,SalesProductCustomerTC,SalesProductCode,SalesProductName,SalesProductBrand,SalesProductPrice," +
                    "SalesProductCategory,SalesProductGender,SalesProductSize,SalesProductColour,SalesProductNumber,SalesProductWhere) values(@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10,@d11,@d12)", cnt.connection());
                command3.Parameters.AddWithValue("@d1", lblnamesurname.Text);
                command3.Parameters.AddWithValue("@d2", lblTC.Text);
                command3.Parameters.AddWithValue("@d3", txtproductcode.Text);
                command3.Parameters.AddWithValue("@d4", txtproductname.Text);
                command3.Parameters.AddWithValue("@d5", txtproductbrand.Text);
                command3.Parameters.AddWithValue("@d6", txtproductprice.Text);
                command3.Parameters.AddWithValue("@d7", cmbproductcatagory.Text);
                command3.Parameters.AddWithValue("@d8", cmbproductgender.Text);
                command3.Parameters.AddWithValue("@d9", cmbproductsize.Text);
                command3.Parameters.AddWithValue("@d10", txtproductcolour.Text);
                command3.Parameters.AddWithValue("@d11", num_that_you_want.ToString());
                command3.Parameters.AddWithValue("@d12", cmbProductWhere.Text);
                command3.ExecuteNonQuery();
                cnt.connection().Close();


                MessageBox.Show(" Purchase Succesful...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            else if (actnum == num_that_you_want)
            {
                SqlCommand command2 = new SqlCommand("delete from Tbl_Stock where ProductCode=@d1", cnt.connection());
                command2.Parameters.AddWithValue("@d1", txtproductcode.Text);
                command2.ExecuteNonQuery();
                SqlCommand command3 = new SqlCommand("insert into Tbl_Sales (SalesProductCustomer,SalesProductCustomerTC,SalesProductCode,SalesProductName,SalesProductBrand,SalesProductPrice," +
                      "SalesProductCategory,SalesProductGender,SalesProductSize,SalesProductColour,SalesProductNumber,SalesProductWhere) values(@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10,@d11,@d12)", cnt.connection());
                command3.Parameters.AddWithValue("@d1", lblnamesurname.Text);
                command3.Parameters.AddWithValue("@d2", lblTC.Text);
                command3.Parameters.AddWithValue("@d3", txtproductcode.Text);
                command3.Parameters.AddWithValue("@d4", txtproductname.Text);
                command3.Parameters.AddWithValue("@d5", txtproductbrand.Text);
                command3.Parameters.AddWithValue("@d6", txtproductprice.Text);
                command3.Parameters.AddWithValue("@d7", cmbproductcatagory.Text);
                command3.Parameters.AddWithValue("@d8", cmbproductgender.Text);
                command3.Parameters.AddWithValue("@d9", cmbproductsize.Text);
                command3.Parameters.AddWithValue("@d10", txtproductcolour.Text);
                command3.Parameters.AddWithValue("@d11", num_that_you_want.ToString());
                command3.Parameters.AddWithValue("@d12", cmbProductWhere.Text);
                command3.ExecuteNonQuery();

                MessageBox.Show(" Purchase Succesful...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                cnt.connection().Close();

            }
            else
            {
                MessageBox.Show("Please enter the correct amount because we don't have enough", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


            cnt.connection().Close();


        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        //update personel ınfo
        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand command1 = new SqlCommand("update Tbl_Customer set CustomerName=@d1,CustomerSurname=@d2,CustomerTel=@d3,CustomerPassword=@d5,CustomerGender=@d6 where CustomerTC=@d4", cnt.connection());
            command1.Parameters.AddWithValue("@d1", txtname.Text);
            command1.Parameters.AddWithValue("@d2", txtsurname.Text);
            command1.Parameters.AddWithValue("@d3", mskdTel.Text);
            command1.Parameters.AddWithValue("@d5", txtpassword.Text);
            command1.Parameters.AddWithValue("@d4", lblTC.Text);
            command1.Parameters.AddWithValue("@d6", cmbgender.Text);
            command1.ExecuteNonQuery();
            cnt.connection().Close();
            MessageBox.Show("Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
