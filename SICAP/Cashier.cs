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
    class Cashier
    {
        public string Username { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Level { get; set; }

        private static SqlCommand cmd;
        private static SqlDataReader rd;

        public Cashier(string username, string name, string password, string level)
        {
            Username = username;
            Name = name;
            Password = password;
            Level = level;
        }

        public static void AddCashier(Cashier cashier)
        {
            string query = "INSERT INTO TBL_Kasir VALUES (@Username, @CashierName, @CashierPass, @CashierLevel)";
            string check_query = "SELECT * FROM TBL_Kasir WHERE Username = '"+ cashier.Username +"'";

            SqlConnection conn = Connection.GetConn();
            conn.Open();

            SqlCommand check = new SqlCommand(check_query, conn);
            check.ExecuteNonQuery();
            rd = check.ExecuteReader();

            if (rd.Read() == true && cashier.Username == rd[0].ToString())
            {
                MessageBox.Show("Username '" + cashier.Username + "' already taken!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rd.Close();
            }
            else
            {
                rd.Close();

                try
                {
                    cmd = new SqlCommand(query, conn);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = cashier.Username;
                    cmd.Parameters.Add("@CashierName", SqlDbType.VarChar).Value = cashier.Name;
                    cmd.Parameters.Add("@CashierPass", SqlDbType.VarChar).Value = cashier.Password;
                    cmd.Parameters.Add("@CashierLevel", SqlDbType.VarChar).Value = cashier.Level;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            conn.Close();
        }

        public static void UpdateCashier(Cashier cashier, string username)
        {
            string query = "UPDATE TBL_Kasir SET NamaKasir = @CashierName, PasswordKasir = @CashierPass, LevelKasir = @CashierLevel WHERE Username = @Username";
           
            SqlConnection conn = Connection.GetConn();
            conn.Open();

            var cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = username;
            cmd.Parameters.Add("@CashierName", SqlDbType.VarChar).Value = cashier.Name;
            cmd.Parameters.Add("@CashierPass", SqlDbType.VarChar).Value = cashier.Password;
            cmd.Parameters.Add("@CashierLevel", SqlDbType.VarChar).Value = cashier.Level;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
        }

        public static void DeleteCashier(string username)
        {
            string query = "DELETE FROM TBL_Kasir WHERE Username = @CUsername";

            SqlConnection conn = Connection.GetConn();
            conn.Open();

            var cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@CUsername", SqlDbType.VarChar).Value = username;

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

    }
}
