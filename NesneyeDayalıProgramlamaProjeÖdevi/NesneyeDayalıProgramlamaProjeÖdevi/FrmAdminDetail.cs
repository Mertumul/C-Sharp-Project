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
    public partial class FrmAdminDetail : Form
    {
        public FrmAdminDetail()
        {
            InitializeComponent();
        }
        sqlconnenction cnt = new sqlconnenction();

        private void button1_Click(object sender, EventArgs e)
        {
            Supplier fr = new Supplier();
            fr.Show();
        }

        private void FrmAdminDetail_Load(object sender, EventArgs e)
        {
            //product ordered daily list
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from Tbl_Order ", cnt.connection());
            da1.Fill(dt1);
            dataGridView2.DataSource = dt1;

            //product in warehouse
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select * from Tbl_Order where OrderProductWhere='Warehouse'", cnt.connection());
            da2.Fill(dt2);
            dataGridView3.DataSource = dt2;

            //product in Shelf
            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter("select * from Tbl_Order where OrderProductWhere='Shelf'", cnt.connection());
            da3.Fill(dt3);
            dataGridView4.DataSource = dt3;

            //product sold daily list
            DataTable dt4 = new DataTable();
            SqlDataAdapter da4 = new SqlDataAdapter("select * from Tbl_Sales ", cnt.connection());
            da4.Fill(dt4);
            dataGridView1.DataSource = dt4;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CustomerInfo fr = new CustomerInfo();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmProducts fr = new FrmProducts();
            fr.Show();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
        //passing  the  income and expenses page
        private void button2_Click(object sender, EventArgs e)
        {
            
            FrmIncomeExpenses fr = new FrmIncomeExpenses();
            fr.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
