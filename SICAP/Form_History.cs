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

        private void DeleteHistory(int id)
        {
            string query = "DELETE FROM TBL_Transaksi WHERE IDTransaksi = @ID";

            SqlConnection conn = Connection.GetConn();
            conn.Open();

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            conn.Close();
        }

        public void DisplayCountTransaction(string query)
        { 
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

        public void DisplaySumTransaction(string query)
        {

            SqlConnection conn = Connection.GetConn();
            conn.Open();

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            SqlDataReader rd = cmd.ExecuteReader();

            if (rd.Read())
            {
                string sum = rd[0].ToString();

                if (sum.ToString() == "")
                    lblIncome.Text = "0";
                else
                    lblIncome.Text = int.Parse(sum).ToString("C", culture);

                rd.Close();
            }
            conn.Close();
        }

        public void DisplayProfit(string query)
        {

            SqlConnection conn = Connection.GetConn();
            conn.Open();

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            SqlDataReader rd = cmd.ExecuteReader();

            if (rd.Read())
            {
                string sum = rd[0].ToString();

                if (sum.ToString() == "")
                    lblProfit.Text = "0";
                else
                    lblProfit.Text = int.Parse(sum).ToString("C", culture);

                rd.Close();
            }
            conn.Close();
        }

        public void Display()
        {
            GetData.ShowData("SELECT IDTransaksi, NamaKasir, TanggalTransaksi, TotalTransaksi, TotalUntung FROM TBL_Transaksi", dgvHistory);
        }

        public void DisplayAll()
        {
            Display();
            DisplayCountTransaction("SELECT COUNT(TotalTransaksi) FROM TBL_Transaksi WHERE TanggalTransaksi = '" + DateTime.Now.ToString("dd") + "-" + DateTime.Today.ToString("MMMM") + "-" + DateTime.Today.Year.ToString() + "'");
            DisplaySumTransaction("SELECT SUM(TotalTransaksi) FROM TBL_Transaksi WHERE TanggalTransaksi = '" + DateTime.Now.ToString("dd") + "-" + DateTime.Today.ToString("MMMM") + "-" + DateTime.Today.Year.ToString() + "'");
            DisplayProfit("SELECT SUM(TotalUntung) FROM TBL_Transaksi WHERE TanggalTransaksi = '" + DateTime.Now.ToString("dd") + "-" + DateTime.Today.ToString("MMMM") + "-" + DateTime.Today.Year.ToString() + "'");
            cbMonth.Text = "All";
            cbTransaction.Text = "This Day";
        }

        private void Form_History_Load(object sender, EventArgs e)
        {
            DisplayAll();
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
                    DisplayAll();
                }
            }
        }

        private void dgvHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (MessageBox.Show("Are you sure to delete this?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    DeleteHistory(Convert.ToInt32(dgvHistory.CurrentRow.Cells[1].Value.ToString()));
                    DisplayAll();
                }
            }
        }

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMonth.Text == "All")
            {
                Display();
            }
            else
            {
                GetData.ShowData("SELECT IDTransaksi, NamaKasir, TanggalTransaksi, TotalTransaksi, TotalUntung FROM TBL_Transaksi WHERE TanggalTransaksi LIKE '%" + cbMonth.Text + "%'", dgvHistory);
            }
                
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (cbMonth.Text == "All")
            {
                GetData.ShowData("SELECT IDTransaksi, NamaKasir, TanggalTransaksi, TotalTransaksi FROM TBL_Transaksi WHERE TanggalTransaksi LIKE '%" + tbSearch.Text + "%'", dgvHistory);
            }
            else
            {
                GetData.ShowData("SELECT IDTransaksi, NamaKasir, TanggalTransaksi, TotalTransaksi FROM TBL_Transaksi WHERE TanggalTransaksi LIKE '%" + tbSearch.Text + "%' AND TanggalTransaksi LIKE '%" + cbMonth.Text + "%'", dgvHistory);
            }
        }

        private void cbTransaction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTransaction.Text == "This Day")
            {
                DisplayCountTransaction("SELECT COUNT(TotalTransaksi) FROM TBL_Transaksi WHERE TanggalTransaksi = '" + DateTime.Now.ToString("dd") + "-" + DateTime.Today.ToString("MMMM") + "-" + DateTime.Today.Year.ToString() + "'");
                DisplaySumTransaction("SELECT SUM(TotalTransaksi) FROM TBL_Transaksi WHERE TanggalTransaksi = '" + DateTime.Now.ToString("dd") + "-" + DateTime.Today.ToString("MMMM") + "-" + DateTime.Today.Year.ToString() + "'");
                DisplayProfit("SELECT SUM(TotalUntung) FROM TBL_Transaksi WHERE TanggalTransaksi = '" + DateTime.Now.ToString("dd") + "-" + DateTime.Today.ToString("MMMM") + "-" + DateTime.Today.Year.ToString() + "'");
            }
            else if (cbTransaction.Text == "This Month")
            {
                DisplayCountTransaction("SELECT COUNT(TotalTransaksi) FROM TBL_Transaksi WHERE TanggalTransaksi LIKE '%"+ DateTime.Today.ToString("MMMM") + "-" + DateTime.Today.Year.ToString() + "'");
                DisplaySumTransaction("SELECT SUM(TotalTransaksi) FROM TBL_Transaksi WHERE TanggalTransaksi LIKE '%" + DateTime.Today.ToString("MMMM") + "-" + DateTime.Today.Year.ToString() + "'");
                DisplayProfit("SELECT SUM(TotalUntung) FROM TBL_Transaksi WHERE TanggalTransaksi LIKE '%" + DateTime.Today.ToString("MMMM") + "-" + DateTime.Today.Year.ToString() + "'");
            }
            else if (cbTransaction.Text == "This Year")
            {
                DisplayCountTransaction("SELECT COUNT(TotalTransaksi) FROM TBL_Transaksi WHERE TanggalTransaksi LIKE '%" + DateTime.Today.Year.ToString() + "'");
                DisplaySumTransaction("SELECT SUM(TotalTransaksi) FROM TBL_Transaksi WHERE TanggalTransaksi LIKE '%" + DateTime.Today.Year.ToString() + "'");
                DisplayProfit("SELECT SUM(TotalUntung) FROM TBL_Transaksi WHERE TanggalTransaksi LIKE '%" + DateTime.Today.Year.ToString() + "'");
            }
            else if (cbTransaction.Text == "All")
            {
                DisplayCountTransaction("SELECT COUNT(TotalTransaksi) FROM TBL_Transaksi ");
                DisplaySumTransaction("SELECT SUM(TotalTransaksi) FROM TBL_Transaksi");
                DisplayProfit("SELECT SUM(TotalUntung) FROM TBL_Transaksi");
            }
        }
    }
}
