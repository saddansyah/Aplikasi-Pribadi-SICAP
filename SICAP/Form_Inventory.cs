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
    public partial class Form_Inventory : Form
    {
        private int selectedID;
        public Form_Inventory()
        {
            InitializeComponent();
        }
        
        public void Clear()
        {
            tbItemID.Text = tbItemName.Text = tbItemMPrice.Text = tbItemSPrice.Text = cbItemCategory.Text = string.Empty;
        }

        public void Display()
        {
            GetData.ShowData("SELECT TBL_Barang.IDBarang, TBL_Barang.NamaBarang, TBL_Barang.HargaBeli, TBL_Barang.HargaJual, TBL_Kategori.NamaKategori FROM TBL_Barang INNER JOIN TBL_Kategori ON TBL_Barang.IDKategori = TBL_Kategori.IDKategori", dgvInventory);
        }

        public void FillCBItemCtg()
        {
            SqlConnection conn = Connection.GetConn();
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM TBL_Kategori", conn);
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                string items = rd["NamaKategori"].ToString();
                cbItemCategory.Items.Add(items);
            }

            conn.Close();
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

        private void Form_Inventory_Load(object sender, EventArgs e)
        {
            Clear();
            Display();
            FillCBItemCtg();
            FillCBSearchCtg();

            //Initializing tbID 
            int count = dgvInventory.Rows.Count;
            tbItemID.Text = (++count).ToString();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (cbSearchCategory.Text == "All")
            {
                GetData.ShowData("SELECT TBL_Barang.IDBarang, TBL_Barang.NamaBarang, TBL_Barang.HargaBeli, TBL_Barang.HargaJual, TBL_Kategori.NamaKategori FROM TBL_Barang INNER JOIN TBL_Kategori ON TBL_Barang.IDKategori = TBL_Kategori.IDKategori WHERE TBL_Barang.NamaBarang LIKE '%" + tbSearch.Text + "%'", dgvInventory);
            }
            else
            {
                GetData.ShowData("SELECT TBL_Barang.IDBarang, TBL_Barang.NamaBarang, TBL_Barang.HargaBeli, TBL_Barang.HargaJual, TBL_Kategori.NamaKategori FROM TBL_Barang INNER JOIN TBL_Kategori ON TBL_Barang.IDKategori = TBL_Kategori.IDKategori WHERE TBL_Barang.NamaBarang LIKE '%" + tbSearch.Text + "%' AND TBL_Kategori.NamaKategori ='" + cbSearchCategory.Text +"'", dgvInventory);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Inventory inventory; 
            if (tbItemID.Text == "" || tbItemName.Text == "" || tbItemMPrice.Text == "" || tbItemSPrice.Text == "" || cbItemCategory.Text == "")
            {
                MessageBox.Show("Fill out the blank textbox!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Clear();
            }
            else if (btnAdd.Text == "Add")
            {
                try
                {
                    inventory = new Inventory(Convert.ToInt32(tbItemID.Text.Trim()), tbItemName.Text.Trim(), Convert.ToInt32(tbItemMPrice.Text.Trim()), Convert.ToInt32(tbItemSPrice.Text.Trim()), selectedID);
                    Inventory.AddItem(inventory);
                    Clear();
                    Display();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK , MessageBoxIcon.Warning);
                }
   
            }
            else if (btnAdd.Text == "Update")
            {
                try
                {
                    inventory = new Inventory(Convert.ToInt32(tbItemID.Text.Trim()), tbItemName.Text.Trim(), Convert.ToInt32(tbItemMPrice.Text.Trim()), Convert.ToInt32(tbItemSPrice.Text.Trim()), selectedID);
                    Inventory.UpdateItem(inventory, Convert.ToInt32(tbItemID.Text));
                    Clear();
                    Display();
                    btnAddItem_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } 
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            int count = dgvInventory.Rows.Count;

            btnAdd.Text = "Add";
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(146)))), ((int)(((byte)(84)))));
            Clear();
            tbItemID.Text = (++count).ToString();
            tbItemID.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dgvInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                btnAdd.Text = "Update";
                this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(239)))));
                tbItemID.Text = dgvInventory.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbItemName.Text = dgvInventory.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbItemMPrice.Text = dgvInventory.Rows[e.RowIndex].Cells[4].Value.ToString();
                tbItemSPrice.Text = dgvInventory.Rows[e.RowIndex].Cells[5].Value.ToString();
                cbItemCategory.Text = dgvInventory.Rows[e.RowIndex].Cells[6].Value.ToString();

                tbItemID.Focus();
            }
            else if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Are you want to delete this ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Inventory.DeleteItem(Convert.ToInt32(dgvInventory.Rows[e.RowIndex].Cells[2].Value));
                    Display();
                    Clear();
                    btnAddItem_Click(sender, e);
                }
            }
        }

        private void cbItemCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = Connection.GetConn();
            SqlCommand cmd = new SqlCommand("SELECT IDKategori, DeskripsiKategori FROM TBL_Kategori WHERE NamaKategori ='" + cbItemCategory.Text + "'", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            SqlDataReader rd = cmd.ExecuteReader();

            if (rd.Read())
            {
                this.selectedID = Convert.ToInt32(rd[0].ToString());
                lblCategoryName.Text = rd[1].ToString();
            }
            else
            {
                lblCategoryName.Text = "Not Found";
            }
            conn.Close();
        }

        private void cbSearchCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbSearchCategory.Text == "All")
                GetData.ShowData("SELECT TBL_Barang.IDBarang, TBL_Barang.NamaBarang, TBL_Barang.HargaBeli, TBL_Barang.HargaJual, TBL_Kategori.NamaKategori FROM TBL_Barang INNER JOIN TBL_Kategori ON TBL_Barang.IDKategori = TBL_Kategori.IDKategori", dgvInventory);
            else
                GetData.ShowData("SELECT TBL_Barang.IDBarang, TBL_Barang.NamaBarang, TBL_Barang.HargaBeli, TBL_Barang.HargaJual, TBL_Kategori.NamaKategori FROM TBL_Barang INNER JOIN TBL_Kategori ON TBL_Barang.IDKategori = TBL_Kategori.IDKategori WHERE TBL_Kategori.NamaKategori = '" + cbSearchCategory.Text +"'", dgvInventory);
        }

        private void lblCategoryName_Click(object sender, EventArgs e)
        {

        }
    }
}
