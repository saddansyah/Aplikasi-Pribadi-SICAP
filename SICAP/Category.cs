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
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }

        private static SqlCommand cmd;
        private static SqlDataReader rd;

        public Category(int id, string name, string desc)
        {
            ID = id;
            Name = name;
            Desc = desc;
        }

        public static void AddCategory(Category category)
        {
            string query = "INSERT INTO TBL_Kategori VALUES (@CtgID, @CtgName, @CtgDesc)";
            string check_query = "SELECT * FROM TBL_Kategori WHERE IDKategori = '" + category.ID + "'";

            SqlConnection conn = Connection.GetConn();
            conn.Open();

            SqlCommand check = new SqlCommand(check_query, conn);
            check.ExecuteNonQuery();
            rd = check.ExecuteReader();

            if (rd.Read() == true && category.ID.ToString() == rd[0].ToString())
            {
                MessageBox.Show("Category ID '" + category.ID + "' already taken");
                rd.Close();
            }
            else
            {
                rd.Close();

                try
                {
                    cmd = new SqlCommand(query, conn);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.Add("@CtgID", SqlDbType.Int).Value = category.ID;
                    cmd.Parameters.Add("@CtgName", SqlDbType.VarChar).Value = category.Name;
                    cmd.Parameters.Add("@CtgDesc", SqlDbType.VarChar).Value = category.Desc;

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

        public static void UpdateCategory(Category category, int id)
        {
            string query = "UPDATE TBL_Kategori SET NamaKategori = @CtgName, DeskripsiKategori = @CtgDesc WHERE IDKategori = @CtgID";

            SqlConnection conn = Connection.GetConn();
            conn.Open();

            var cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@CtgID", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@CtgName", SqlDbType.VarChar).Value = category.Name;
            cmd.Parameters.Add("@CtgDesc", SqlDbType.VarChar).Value = category.Desc;

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

        public static void DeleteCategory(int id)
        {
            string query = "DELETE FROM TBL_Kategori WHERE IDKategori = @CtgID";

            SqlConnection conn = Connection.GetConn();
            conn.Open();

            var cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@CtgID", SqlDbType.Int).Value = id;

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
