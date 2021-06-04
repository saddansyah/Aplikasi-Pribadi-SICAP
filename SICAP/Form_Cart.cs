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

namespace SICAP
{
    public partial class Form_Cart : Form
    {
        Order new_order;
        private string sellerName;

        public Form_Cart(string sellername)
        {
            this.sellerName = sellername;
            InitializeComponent();
        }

        public void Display()
        {
            GetData.ShowData("SELECT TBL_Barang.IDBarang, TBL_Barang.NamaBarang, TBL_Barang.HargaJual, TBL_Kategori.NamaKategori FROM TBL_Barang INNER JOIN TBL_Kategori ON TBL_Barang.IDKategori = TBL_Kategori.IDKategori", dgvInventory);
        }

        public void FillCBSearchCtg()
        {
            SqlConnection conn = Connection.GetConn();
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM TBL_Kategori", conn);
            SqlDataReader rd = cmd.ExecuteReader();

            cbSearchCategory.Items.Add("All");

            while (rd.Read())
            {
                string items = rd["NamaKategori"].ToString();
                cbSearchCategory.Items.Add(items);
            }

            cbSearchCategory.Text = "All";

            conn.Close();
        }

        private void Form_Cart_Load(object sender, EventArgs e)
        {
            Display();
            FillCBSearchCtg();
            btnBuy.Enabled = false;
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (cbSearchCategory.Text == "All")
            {
                GetData.ShowData("SELECT TBL_Barang.IDBarang, TBL_Barang.NamaBarang, TBL_Barang.HargaJual, TBL_Kategori.NamaKategori " +
                    "FROM TBL_Barang INNER JOIN TBL_Kategori ON TBL_Barang.IDKategori = TBL_Kategori.IDKategori " +
                    "WHERE TBL_Barang.NamaBarang LIKE '%" + tbSearch.Text + "%'", dgvInventory);
            }
            else
            {
                GetData.ShowData("SELECT TBL_Barang.IDBarang, TBL_Barang.NamaBarang, TBL_Barang.HargaJual, TBL_Kategori.NamaKategori " +
                    "FROM TBL_Barang INNER JOIN TBL_Kategori ON TBL_Barang.IDKategori = TBL_Kategori.IDKategori " +
                    "WHERE TBL_Barang.NamaBarang LIKE '%" + tbSearch.Text + "%' AND TBL_Kategori.NamaKategori ='" + cbSearchCategory.Text + "'", dgvInventory);
            }
        }

        private void cbSearchCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSearchCategory.Text == "All")
                GetData.ShowData("SELECT TBL_Barang.IDBarang, TBL_Barang.NamaBarang, TBL_Barang.HargaJual, TBL_Kategori.NamaKategori " +
                    "FROM TBL_Barang INNER JOIN TBL_Kategori ON TBL_Barang.IDKategori = TBL_Kategori.IDKategori", dgvInventory);
            else
                GetData.ShowData("SELECT TBL_Barang.IDBarang, TBL_Barang.NamaBarang, TBL_Barang.HargaJual, TBL_Kategori.NamaKategori " +
                    "FROM TBL_Barang INNER JOIN TBL_Kategori ON TBL_Barang.IDKategori = TBL_Kategori.IDKategori " +
                    "WHERE TBL_Kategori.NamaKategori = '" + cbSearchCategory.Text + "'", dgvInventory);
        }

        private void dgvInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                try
                {
                    new_order = new Order(Convert.ToInt32(dgvInventory.Rows[e.RowIndex].Cells[1].Value.ToString()),
                    dgvInventory.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    Convert.ToInt32(dgvInventory.Rows[e.RowIndex].Cells[3].Value.ToString()),
                    1,
                    this.sellerName);

                    new_order.AddToCart(new_order, dgvCart);

                    lblTotal.Text = new_order.Total.ToString();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }       
            }
        }

        private void dgvCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                int qty = Convert.ToInt32(dgvCart.Rows[e.RowIndex].Cells[3].Value.ToString());

                if (qty > 1)
                    dgvCart.Rows[e.RowIndex].Cells[3].Value = --qty;
                else
                    new_order.DeleteFromCart(dgvCart);

                lblTotal.Text = new_order.Total.ToString();
            }
            else if(e.ColumnIndex == 6)
            {
                if (MessageBox.Show("Are you want to delete this ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    new_order.DeleteFromCart(dgvCart);

                lblTotal.Text = new_order.Total.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you want to delete this ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes && new_order != null)
                new_order.ClearCart(dgvCart);
        }

        private void tbPayment_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbPayment.Text == "" || dgvCart.Rows.Count == 0)
                {
                    lblReturn.Text = "-";
                    btnBuy.Enabled = false;
                }
                else if (Convert.ToInt32(tbPayment.Text) >= Convert.ToInt32(lblTotal.Text))
                {
                    lblReturn.Text = (Convert.ToInt32(tbPayment.Text) - Convert.ToInt32(lblTotal.Text)).ToString();
                    btnBuy.Enabled = true;
                }
                else
                {
                    lblReturn.Text = "Your money isn't enough!";
                    btnBuy.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                tbPayment.Text = "";
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new_order.Buy(new_order);

                dgvCart.Rows.Clear();
                tbPayment.Text = lblTotal.Text = lblReturn.Text = tbSearch.Text = string.Empty;
            }                    
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            tbPayment.Text = lblTotal.Text;
        }
    }
}
