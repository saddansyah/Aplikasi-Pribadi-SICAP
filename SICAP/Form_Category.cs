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
    public partial class Form_Category : Form
    {
        public Form_Category()
        {
            InitializeComponent();
        }

        private void Form_Category_Load(object sender, EventArgs e)
        {
            Clear();
            Display();

            //Initializing tbID 
            int count = dgvCategory.Rows.Count;
            tbCtgID.Text = (++count).ToString();
        }

        public void Clear()
        {
            tbCtgID.Text = tbCtgName.Text = tbCtgDesc.Text = string.Empty;
        }

        public void Display()
        {
            GetData.ShowData("SELECT IDKategori, NamaKategori, DeskripsiKategori FROM TBL_Kategori", dgvCategory);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            int count = dgvCategory.Rows.Count;

            btnAdd.Text = "Add";
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(146)))), ((int)(((byte)(84)))));
            Clear();
            tbCtgID.Text = (++count).ToString();
            tbCtgID.Focus();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            GetData.ShowData("SELECT IDKategori, NamaKategori, DeskripsiKategori FROM TBL_Kategori WHERE NamaKategori LIKE '%" + tbSearch.Text + "%'", dgvCategory); ;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category new_category;
            if (tbCtgID.Text == "" || tbCtgName.Text == "" || tbCtgDesc.Text == "")
            {
                MessageBox.Show("Fill out the blank textbox!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Clear();
            }
            else if (btnAdd.Text == "Add")
            {
                new_category = new Category(Convert.ToInt32(tbCtgID.Text.Trim()), tbCtgName.Text.Trim(), tbCtgDesc.Text.Trim());
                Category.AddCategory(new_category);
                Clear();
                Display();
            }
            else if (btnAdd.Text == "Update")
            {
                new_category = new Category(Convert.ToInt32(tbCtgID.Text.Trim()), tbCtgName.Text.Trim(), tbCtgDesc.Text.Trim());
                Category.UpdateCategory(new_category, Convert.ToInt32(tbCtgID.Text.Trim()));
                Clear();
                Display();
                btnAddItem_Click(sender, e);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                btnAdd.Text = "Update";
                this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(239)))));
                tbCtgID.Text = dgvCategory.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbCtgName.Text = dgvCategory.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbCtgDesc.Text = dgvCategory.Rows[e.RowIndex].Cells[4].Value.ToString();

                tbCtgID.Focus();
            }
            else if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Are you want to delete this ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Category.DeleteCategory(Convert.ToInt32(dgvCategory.Rows[e.RowIndex].Cells[2].Value.ToString()));
                    Display();
                    Clear();
                    btnAddItem_Click(sender, e);
                }
            }
        }
    }
}
