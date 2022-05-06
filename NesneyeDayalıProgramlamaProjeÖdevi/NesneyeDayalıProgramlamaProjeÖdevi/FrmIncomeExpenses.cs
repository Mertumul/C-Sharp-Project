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
    public partial class FrmIncomeExpenses : Form
    {
        public FrmIncomeExpenses()
        {
            InitializeComponent();
        }
        sqlconnenction cnt = new sqlconnenction();

        private void label5_Click(object sender, EventArgs e)
        {

        }
        //Adding Expenses to database
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command1 = new SqlCommand("insert into Tbl_Expenses (ExpenseCode,Personnel,Electricity,Water,Heating,Rent,Meal,Tea) values(@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8)", cnt.connection());
            command1.Parameters.AddWithValue("@d1", txtexpensecode.Text);
            command1.Parameters.AddWithValue("@d2", txtpersonnel.Text);
            command1.Parameters.AddWithValue("@d3", txtelectricity.Text);
            command1.Parameters.AddWithValue("@d4", txtwater.Text);
            command1.Parameters.AddWithValue("@d5", txtHeating.Text);
            command1.Parameters.AddWithValue("@d6", txtrent.Text);
            command1.Parameters.AddWithValue("@d7", txtmeal.Text);
            command1.Parameters.AddWithValue("@d8", txttea.Text);
            command1.ExecuteNonQuery();
            cnt.connection().Close();
            MessageBox.Show("Expenses added!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void FrmIncomeExpenses_Load(object sender, EventArgs e)
        {
            //showing the expense table from database
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from Tbl_Expenses ", cnt.connection());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            //showing sold product table from database
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select SalesProductCode,SalesProductName,SalesProductBrand,SalesProductPrice,SalesProductCategory,SalesProductGender,SalesProductSize,SalesProductColour,SalesProductNumber,SalesProductWhere from Tbl_Sales ", cnt.connection());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

        }
        //deleting the spesific expense recors from database 
        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand command2 = new SqlCommand("delete from Tbl_Expenses where ExpenseCode=@d1", cnt.connection());
            command2.Parameters.AddWithValue("@d1", txtexpensecode.Text);
            command2.ExecuteNonQuery();
            cnt.connection().Close();
            MessageBox.Show(" Expense Records Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int chosen = dataGridView1.SelectedCells[0].RowIndex;
            txtexpensecode.Text = dataGridView1.Rows[chosen].Cells[1].Value.ToString();
            txtpersonnel.Text = dataGridView1.Rows[chosen].Cells[2].Value.ToString();
            txtelectricity.Text = dataGridView1.Rows[chosen].Cells[3].Value.ToString();
            txtwater.Text = dataGridView1.Rows[chosen].Cells[4].Value.ToString();
            txtHeating.Text = dataGridView1.Rows[chosen].Cells[5].Value.ToString();
            txtrent.Text = dataGridView1.Rows[chosen].Cells[6].Value.ToString();
            txtmeal.Text = dataGridView1.Rows[chosen].Cells[7].Value.ToString();
            txttea.Text = dataGridView1.Rows[chosen].Cells[8].Value.ToString();
            
        }

        //editing the spesific expense from database
        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand command3 = new SqlCommand("update Tbl_Expenses set Personnel=@d2,Electricity=@d3,Water=@d4,Heating=@d5,Rent=@d6,Meal=@d7,Tea=@d8 where ExpenseCode=@d1", cnt.connection());
            command3.Parameters.AddWithValue("@d1", txtexpensecode.Text);
            command3.Parameters.AddWithValue("@d2", txtpersonnel.Text);
            command3.Parameters.AddWithValue("@d3", txtelectricity.Text);
            command3.Parameters.AddWithValue("@d4", txtwater.Text);
            command3.Parameters.AddWithValue("@d5", txtHeating.Text);
            command3.Parameters.AddWithValue("@d6", txtrent.Text);
            command3.Parameters.AddWithValue("@d7", txtmeal.Text);
            command3.Parameters.AddWithValue("@d8", txttea.Text);
            command3.ExecuteNonQuery();
            cnt.connection().Close();
            MessageBox.Show(" Expenses Record Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
        //calculating the total price that you have to pay
        private void button4_Click(object sender, EventArgs e)
        {

            double personnelwage = 0.0;
            double electricityprice = 0.0;
            double waterprice = 0.0;
            double heatingprice = 0.0;
            double rentprice = 0.0;
            double mealprice = 0.0;
            double teaprice = 0.0;
            double totalexpense = 0.0;
            double income = 0.0;
            double profit = 0.0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                personnelwage+= Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
                electricityprice += Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
                waterprice += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
                heatingprice += Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                rentprice += Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);
                mealprice += Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value);
                teaprice += Convert.ToDouble(dataGridView1.Rows[i].Cells[8].Value);
            }
            for(int i = 0; i < dataGridView2.Rows.Count; ++i)
            {
                income += Convert.ToDouble(dataGridView2.Rows[i].Cells[3].Value) * Convert.ToDouble(dataGridView2.Rows[i].Cells[8].Value);
            }
            
            totalexpense = personnelwage + electricityprice + waterprice + heatingprice + rentprice + mealprice + teaprice;
            profit = income - totalexpense;
            lbltotalexpenses.Text = totalexpense.ToString();
            lblPersonelwage.Text = personnelwage.ToString();
            lblelectricityprice.Text = electricityprice.ToString();
            lblwaterprice.Text = waterprice.ToString();
            lblheatingprice.Text = heatingprice.ToString();
            lblrentprice.Text = rentprice.ToString();
            lblmealprice.Text = mealprice.ToString();
            lblteaprice.Text = teaprice.ToString();
            lblincome.Text = income.ToString();
            if (profit >= 0)
            {
                lbltotalloss.Visible = false;
                label18.Visible = false;
                lblprofit.Text = profit.ToString();
            }
            else
            {
                lblprofit.Visible = false;
                label8.Visible = false;
                lbltotalloss.Text = profit.ToString();
            }
        }
    }
}
