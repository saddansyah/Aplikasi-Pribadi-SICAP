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
    public partial class Form_SignUp : Form
    {

        private SqlCommand cmd, check_cmd;
        private SqlDataReader rd;
        private Connection Konn = new Connection();

        public Form_SignUp()
        {
            InitializeComponent();
        }

        private void lblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "" || tbNama.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Fill out all these form!");
            }
            else
            {
                rd = null;
                SqlConnection conn = Connection.GetConn();
                conn.Open();
                cmd = new SqlCommand("INSERT INTO TBL_Kasir VALUES ('" + tbUsername.Text + "','" + tbNama.Text + "','" + tbPassword.Text + "','User')", conn);

                check_cmd = new SqlCommand("SELECT * FROM TBL_Kasir WHERE Username='" + tbUsername.Text + "'", conn);
                check_cmd.ExecuteNonQuery();
                rd = check_cmd.ExecuteReader();

                if (rd.Read())
                {
                    MessageBox.Show("Username '" + tbUsername.Text + "' already taken!", "Information", MessageBoxButtons.OK ,MessageBoxIcon.Information);
                    rd.Close();
                }
                else
                {
                    rd.Close();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Your new user account has been signed up!");

                    this.Close();
                }
                conn.Close();
            }
        }


    }
}
