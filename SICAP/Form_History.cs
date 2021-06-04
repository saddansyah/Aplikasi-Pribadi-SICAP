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
using System.Globalization;

namespace SICAP
{
    public partial class Form_History : Form
    {
        CultureInfo culture = new CultureInfo("id-ID");

        public Form_History()
        {
            InitializeComponent();
        }

        public void DisplayCountTransaction()
        {
            string query = "SELECT COUNT(TotalTransaksi) FROM TBL_Transaksi WHERE TanggalTransaksi = '" + DateTime.Today.Day.ToString() + "-" + DateTime.Today.ToString("MMMM") + "-" + DateTime.Today.Year.ToString() + "'";

            SqlConnection conn = Connection.GetConn();
            conn.Open();

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            SqlDataReader rd = cmd.ExecuteReader();

            if (rd.Read())
            {
                if(rd[0].ToString() == "")
                    lblTransactionCount.Text = "0";
                else
                    lblTransactionCount.Text = rd[0].ToString();

                rd.Close();
            }
            conn.Close();
        }

        public void DisplaySumTransaction()
        {
            string query = "SELECT SUM(TotalTransaksi) FROM TBL_Transaksi WHERE TanggalTransaksi = '" + DateTime.Today.Day.ToString() + "-" + DateTime.Today.ToString("MMMM") + "-" + DateTime.Today.Year.ToString() + "'";

            SqlConnection conn = Connection.GetConn();
            conn.Open();

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            SqlDataReader rd = cmd.ExecuteReader();

            if (rd.Read())
            {
                string sum = int.Parse(rd[0].ToString()).ToString("C", culture);

                if (sum.ToString() == "")
                    lblIncome.Text = "0";
                else
                    lblIncome.Text = sum;

                rd.Close();
            }
            conn.Close();
        }

        public void Display()
        {
            GetData.ShowData("SELECT IDTransaksi, NamaKasir, TanggalTransaksi, TotalTransaksi FROM TBL_Transaksi", dgvHistory);
        }

        private void Form_History_Load(object sender, EventArgs e)
        {
            Display();
            DisplayCountTransaction();
            DisplaySumTransaction();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (dgvHistory.Rows.Count == 0)
            {
                MessageBox.Show("The table is already empty", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("Are you sure to delete all of these?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SqlConnection conn = Connection.GetConn();
                    SqlCommand cmd = new SqlCommand("DELETE FROM TBL_Transaksi", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    Display();
                }
            }
        }
    }
}
