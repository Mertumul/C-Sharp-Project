using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NesneyeDayalıProgramlamaProjeÖdevi
{
    public partial class FrmAdminLogin : Form
    {
        public FrmAdminLogin()
        {
            InitializeComponent();
        }

        private void FrmAdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if((txtusername.Text=="admin") && (txtpassword.Text == "admin"))
            {
                FrmAdminDetail fr = new FrmAdminDetail();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed Please Try Again");
                txtusername.Focus();
            }
        }
    }
}
