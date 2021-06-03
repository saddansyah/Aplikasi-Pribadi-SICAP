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
    public partial class Form_Homepage : Form
    {
        private SqlCommand cmd;
        private SqlDataReader rd;
        private string usernameValidation, sellerName;


        public Form_Homepage(string valid)
        {
            InitializeComponent();
            pnlSubManagement.Visible = false;

            this.usernameValidation = valid.ToString();     
        }

        private void Form_Homepage_Load(object sender, EventArgs e)
        {
            SqlConnection conn = Connection.GetConn();
            cmd = new SqlCommand("SELECT NamaKasir, LevelKasir FROM TBL_Kasir WHERE Username = '" + usernameValidation + "'", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            rd = cmd.ExecuteReader();

            if (rd.Read())
            {
                sellerName = rd[0].ToString();
                lblCashierName.Text = "Hello, " + sellerName;
                lblCashierLevel.Text = "as " + rd[1].ToString();

                if (rd[1].ToString() == "Admin")
                {
                    btnManagement.Enabled = true;
                    btnCart.Enabled = true;
                    btnHistory.Enabled = true;
                    btnAbout.Enabled = true;
                    btnLogout.Enabled = true;
                }
                else
                {
                    btnManagement.Enabled = false;
                    btnCart.Enabled = true;
                    btnHistory.Enabled = true;
                    btnAbout.Enabled = true;
                    btnLogout.Enabled = true;
                }
            }

            rd.Close();
            conn.Close();
        }

        private void HideSubMenu()
        {
            if (pnlSubManagement.Visible == true)
                pnlSubManagement.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private Form activeForm = null;
        Guna.UI2.WinForms.Guna2Button oldButton = null;

        private void OpenChildForm(Form childForm, Guna.UI2.WinForms.Guna2Button currentButton)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                oldButton.Checked = false;
                currentButton.Checked = false;
            } 

            activeForm = childForm;
            oldButton = currentButton;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            currentButton.Checked = true;
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSubManagement);
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                oldButton.Checked = false;
            }
                
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_Cashier(), btnCashier);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_Inventory(), btnInventory);
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_Category(), btnCategory);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_Login form_Login = new Form_Login();
            form_Login.Show();    
        }
    }
}
