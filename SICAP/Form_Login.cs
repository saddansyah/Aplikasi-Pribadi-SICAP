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
    public partial class Form_Login : Form
    {    
        // frontend field
        private int panelx, panely;
        private bool isMaximizied;

        //backend field
        private Form_SignUp frmSignUp;
        private SqlCommand cmd;
        private SqlDataReader rd;
        private string validation_name;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text == "" || tbUsername.Text == "")
            {
                MessageBox.Show("Username and/or password cannot be blank!");
            }
            else
            {
                SqlConnection conn = Connection.GetConn();
                {
                    conn.Open();
                    cmd = new SqlCommand("SELECT * FROM TBL_Kasir WHERE Username='" + tbUsername.Text + "' AND PasswordKasir='" + tbPassword.Text + "'");
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    rd = cmd.ExecuteReader();

                    if (rd.Read())
                    {
                        validation_name = tbUsername.Text;
                        Form_Homepage homepage = new Form_Homepage(validation_name.ToString());
                        homepage.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Username and/or password does not correct");
                    }
                }
            }
            
        }

        private void lblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSignUp = new Form_SignUp();
            frmSignUp.ShowDialog();
        }

        public Form_Login()
        {
            InitializeComponent();
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            this.panelx = guna2Panel2.Location.X; this.panely = guna2Panel2.Location.Y;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (isMaximizied == false)
            {
                guna2Panel2.Location = new Point(203, 268);
                this.isMaximizied = true;
            }
            else
            {
                guna2Panel2.Location = new Point(panelx, panely);
                this.isMaximizied = false;
            }

        }

    }
}
