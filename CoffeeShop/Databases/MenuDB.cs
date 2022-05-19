using CoffeeShop.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop.Databases
{
    class MenuDB : ConnectDB
    {
        public string table = "[menu]";
        public bool createMenu(MenuEntity menu)
        {
            bool isOk = false;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                using (SqlConnection connection = new SqlConnection(sqlConnectionString))
                {
                    connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    command.CommandText = $"INSERT INTO {menu} (menu_name, created_by) values ('{menu.menu_name}', {menu.created_by})";
                    SqlDataReader dr = command.ExecuteReader();
                    isOk = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;
            return isOk;
        }

        public SqlDataAdapter getAllMenuAdapter(string select = "*", string search = "")
        {
            SqlDataAdapter adapter = null;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                SqlConnection connection = new SqlConnection(sqlConnectionString);
                connection.Open();
                string query = $"SELECT {select} FROM {table} JOIN [user] ON menu.created_by = [user].id WHERE 1 = 1 AND menu_name LIKE '%{search}%'";
                adapter = new SqlDataAdapter(query, connection);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;

            return adapter;
        }
        public int countMenu()
        {
            int totalCount = 0;
            Cursor.Current = Cursors.WaitCursor;
            SqlConnection connection = new SqlConnection(sqlConnectionString);
            connection.Open();

            try
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = String.Format($"SELECT COUNT(*) FROM {table}");
                    var reader = command.ExecuteScalar();
                    totalCount = Int32.Parse(reader.ToString());
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Cursor.Current = Cursors.Default;
            return totalCount;
        }

        public bool deleteMenu(int id)
        {
            Cursor.Current = Cursors.WaitCursor;
            bool isOk = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(sqlConnectionString))
                {
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = String.Format($"DELETE FROM {table} WHERE id = @id");
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                        isOk = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;
            return isOk;
        }

        public bool updateMenu(string id, MenuEntity menu)
        {
            Cursor.Current = Cursors.WaitCursor;
            bool isOk = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(sqlConnectionString))
                {
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = $"UPDATE {table} SET menu_name = @menu_name " + 
                            $"WHERE id = '{id}'";
                        command.Parameters.AddWithValue("@menu_name", menu.menu_name);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;
            return isOk;
        }
    }
}
