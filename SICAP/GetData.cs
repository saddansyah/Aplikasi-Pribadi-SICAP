using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace SICAP
{
    class GetData
    {
        private static SqlCommand cmd;
        private static SqlDataAdapter da;
        private static DataTable dt;

        public static void ShowData(string _query, DataGridView dgv)
        {
            string query = _query;

            SqlConnection conn = Connection.GetConn();
            conn.Open();

            cmd = new SqlCommand(query, conn);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;

            conn.Close();
        }

    }
}
