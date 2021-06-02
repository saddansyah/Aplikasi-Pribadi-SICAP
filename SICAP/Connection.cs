using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SICAP
{
    class Connection
    {
        public static SqlConnection GetConn()
        {
            //ConnectionString depends on your own datasource

            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\[code] C#\\Sicap\\remastered\\SICAP\\SICAP\\Database_UNTUNK.mdf;Integrated Security=True";
            return Conn;
        }
    }
}
