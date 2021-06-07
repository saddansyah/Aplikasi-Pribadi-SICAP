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
    public class Inventory
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MPrice { get; set; }
        public int SPrice { get; set; }
        public int Category_ID { get; set; }

        private static SqlCommand cmd;
        private static SqlDataReader rd;

        public Inventory(int id, string name, int mprice, int sprice, int ctg_id)
        {
            ID = id;
            Name = name;
            MPrice = mprice;
            SPrice = sprice;
            Category_ID = ctg_id;
        }

        public static void AddItem(Inventory inventory)
        {
            string query = "INSERT INTO TBL_Barang VALUES (@ID, @ItemName, @ItemMPrice, @ItemSPrice, @IDCtg)";
            string check_query = "SELECT * FROM TBL_Barang WHERE IDBarang = '" + inventory.ID + "'";

            SqlConnection conn = Connection.GetConn();
            conn.Open();

            SqlCommand check = new SqlCommand(check_query, conn);
            check.ExecuteNonQuery();
            rd = check.ExecuteReader();

            if (rd.Read() == true && inventory.ID.ToString() == rd[0].ToString())
            {
                MessageBox.Show("Item ID '" + inventory.ID + "' already exist!");
                rd.Close();
            }
            else
            {
                rd.Close();

                try
                {
                    cmd = new SqlCommand(query, conn);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = inventory.ID;
                    cmd.Parameters.Add("@ItemName", SqlDbType.VarChar).Value = inventory.Name;
                    cmd.Parameters.Add("@ItemMPrice", SqlDbType.Int).Value = inventory.MPrice;
                    cmd.Parameters.Add("@ItemSPrice", SqlDbType.Int).Value = inventory.SPrice;
                    cmd.Parameters.Add("@IDCtg", SqlDbType.Int).Value = inventory.Category_ID;

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

        public static void UpdateItem(Inventory inventory, int id)
        {
            string query = "UPDATE TBL_Barang SET NamaBarang = @ItemName, HargaBeli = @ItemMPrice, HargaJual = @ItemSPrice, IDKategori = @IDCtg WHERE IDBarang = @ID";     

            SqlConnection conn = Connection.GetConn();
            conn.Open();

            cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@ItemName", SqlDbType.VarChar).Value = inventory.Name;
            cmd.Parameters.Add("@ItemMPrice", SqlDbType.Int).Value = inventory.MPrice;
            cmd.Parameters.Add("@ItemSPrice", SqlDbType.Int).Value = inventory.SPrice;
            cmd.Parameters.Add("@IDCtg", SqlDbType.Int).Value = inventory.Category_ID;

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

        public static void DeleteItem(int id)
        {
            string query = "DELETE FROM TBL_Barang WHERE IDBarang = @ID";

            SqlConnection conn = Connection.GetConn();
            conn.Open();

            cmd = new SqlCommand(query, conn);
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
    }
}
