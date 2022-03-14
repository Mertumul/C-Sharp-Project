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
    public partial class frmannouncement : Form
    {
        public frmannouncement()
        {
            InitializeComponent();
        }
        Sqlconnection cnt = new Sqlconnection();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            


        }

        private void frmannouncement_Load(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Announcement", cnt.connection());
            da.Fill(tb);
            dataGridView1.DataSource = tb;
        }
    }
}
