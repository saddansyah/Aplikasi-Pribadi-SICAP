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
    public class Order
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public int Price { get; set; }
        public int Qty { get; set; }
        public int Total { get; set; }
        public int Profit { get; set; }
        public string Seller { get; set; }
        public string Date { get; set; }

        public Order(int id, string name, int price, int qty, string seller)
        {
            ItemID = id;
            ItemName = name;
            Price = price;
            Qty = qty;
            Seller = seller;
            Date = DateTime.Now.ToString("dd") + "-" + DateTime.Now.ToString("MMMM") + "-" + DateTime.Today.Year.ToString();
        }

        public Order()
        {

        }

        public void AddToCart(Order item, DataGridView dgv)
        {
            int Total = 0;
            int MPrice = 0;
            bool isFound = false;

            if (dgv.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (Convert.ToInt32(row.Cells[0].Value) == item.ItemID && Convert.ToString(row.Cells[1].Value) == item.ItemName && Convert.ToInt32(row.Cells[2].Value) == item.Price)
                    {
                        row.Cells[3].Value = Convert.ToString(Convert.ToInt32(row.Cells[3].Value) + Convert.ToInt32(item.Qty));
                        isFound = true;
                    }
                }
                if (!isFound)
                {
                    dgv.Rows.Add(item.ItemID, item.ItemName, item.Price, item.Qty);
                }
            }
            else
            {
                dgv.Rows.Add(item.ItemID, item.ItemName, item.Price, item.Qty);
            }

            foreach (DataGridViewRow row in dgv.Rows)
            {                     
                row.Cells[4].Value = (Convert.ToInt32(row.Cells[2].Value)) * (Convert.ToInt32(row.Cells[3].Value));
                Total += (Convert.ToInt32(row.Cells[4].Value));
                MPrice += GetMPrice(Convert.ToInt32(row.Cells[0].Value.ToString()), (Convert.ToInt32(row.Cells[3].Value)));
            }
       
            GetTotal(Total);
            GetProfit(MPrice);
        }

        public void UpdateCart(DataGridView dgv)
        {
            int Total = 0;
            int MPrice = 0;

            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.Cells[4].Value = (Convert.ToInt32(row.Cells[2].Value)) * (Convert.ToInt32(row.Cells[3].Value));
                Total += (Convert.ToInt32(row.Cells[4].Value));
                MPrice += GetMPrice(Convert.ToInt32(row.Cells[0].Value.ToString()), (Convert.ToInt32(row.Cells[3].Value)));
            }

            GetTotal(Total);
            GetProfit(MPrice);
        }

        public void DeleteFromCart(DataGridView dgv)
        {
            int Total = 0;
            int MPrice = 0;

            int deletedIndex = dgv.CurrentCell.RowIndex;
            dgv.Rows.RemoveAt(deletedIndex);

            foreach (DataGridViewRow row in dgv.Rows)
            {
                Total += (Convert.ToInt32(row.Cells[4].Value));
                MPrice += GetMPrice(Convert.ToInt32(row.Cells[0].Value.ToString()), (Convert.ToInt32(row.Cells[3].Value)));
            }

            GetTotal(Total);
            GetProfit(MPrice);
        }

        public void ClearCart(DataGridView dgv)
        {
            dgv.Rows.Clear();
        }

        private void GetTotal(int total)
        {
            if (this.Total != 0)
            {
                this.Total = 0;
                this.Total = total;
            }
            else
            {
                this.Total = total;
            }
        }

        private void GetProfit(int mprice)
        {
            if (this.Profit != 0)
            {
                this.Profit = 0;
                this.Profit = this.Total - mprice;
            }
            else
            {
                this.Profit = this.Total - mprice;
            }
        }

        public void Buy()
        {
            string query = "INSERT INTO TBL_Transaksi(NamaKasir, TanggalTransaksi, TotalTransaksi, TotalUntung) VALUES (@SellerName, @Date, @Total, @Profit)";

            SqlConnection conn = Connection.GetConn();
            conn.Open();

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.Text;

            try
            {
                cmd.Parameters.Add("@SellerName", SqlDbType.VarChar).Value = this.Seller;
                cmd.Parameters.Add("@Date", SqlDbType.VarChar).Value = this.Date;
                cmd.Parameters.Add("@Total", SqlDbType.Int).Value = this.Total;
                cmd.Parameters.Add("@Profit", SqlDbType.Int).Value = this.Profit;

                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
        }

        private int GetMPrice(int id, int qty)
        {
            int mprice = 0;
            string query = "SELECT HargaBeli FROM TBL_Barang WHERE IDBarang =" + id + "";

            SqlConnection conn = Connection.GetConn();

            conn.Open();

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            SqlDataReader rd = cmd.ExecuteReader();

            if (rd.Read())
            {
                mprice = Convert.ToInt32(rd[0].ToString()) * qty;
            }

            conn.Close();

            return mprice;
        }
    }
}
