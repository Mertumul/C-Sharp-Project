using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PROJECT_HOSPİTAL
{
    class Sqlconnection
    {
        public SqlConnection connection()
        {
            SqlConnection connection1 = new SqlConnection("Data Source=DESKTOP-0ENUTSG;Initial Catalog=Hospital Project;Integrated Security=True");
            connection1.Open();
            return connection1;
        }
        
    }
}
