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
    public partial class Form_Cashier : Form
    {

        public Form_Cashier()
        {
            InitializeComponent();
        }

        private void Form_Cashier_Load(object sender, EventArgs e)
        {
            Clear();
            Display();
        }

        public void Clear()
        {
            tbUsername.Text = tbCashierName.Text = tbCashierPassword.Text = cbCashierLevel.Text = string.Empty;
        }

        public void Display()
        {
            GetData.ShowData("SELECT Username, NamaKasir, PasswordKasir, LevelKasir FROM TBL_Kasir", dgvCashier);
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            Cashier new_cashier;
            if (tbUsername.Text == "" || tbCashierName.Text == "" || tbCashierPassword.Text == "" || cbCashierLevel.Text == "")
            {
                MessageBox.Show("Fill out the blank textbox!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Clear();
            }
            else if(btnAdd.Text == "Add")
            {
                new_cashier = new Cashier(tbUsername.Text.Trim(), tbCashierName.Text.Trim(), tbCashierPassword.Text.Trim(), cbCashierLevel.Text.Trim());
                Cashier.AddCashier(new_cashier);
                Clear();
                Display();
            }
            else if(btnAdd.Text == "Update")
            {
                new_cashier = new Cashier(tbUsername.Text.Trim(), tbCashierName.Text.Trim(), tbCashierPassword.Text.Trim(), cbCashierLevel.Text.Trim());
                Cashier.UpdateCashier(new_cashier, tbUsername.Text.Trim());
                Clear();
                Display();
                btnAddItem_Click(sender, e);
            }
        }
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            btnAdd.Text = "Add";
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(146)))), ((int)(((byte)(84)))));
            Clear();
            tbUsername.Focus();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            GetData.ShowData("SELECT Username, NamaKasir, PasswordKasir, LevelKasir FROM TBL_Kasir WHERE Username LIKE '%" + tbSearch.Text + "%' OR NamaKasir LIKE '%" + tbSearch.Text + "%'", dgvCashier);
        }

        private void dgvCashier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                btnAdd.Text = "Update";
                this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(239)))));
                tbUsername.Text = dgvCashier.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbCashierName.Text = dgvCashier.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbCashierPassword.Text = dgvCashier.Rows[e.RowIndex].Cells[4].Value.ToString();
                cbCashierLevel.Text = dgvCashier.Rows[e.RowIndex].Cells[5].Value.ToString();

                tbUsername.Focus();
            }
            else if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Are you want to delete this ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Cashier.DeleteCashier(dgvCashier.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                    Clear();
                    btnAddItem_Click(sender, e);
                }
            }
        }
    }
}
