using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    class Database
    {
        public static string dbServerName = "DESKTOP-7TB6IV3";
        public static string sqlConnectionString = $"Server={dbServerName};Database=CoffeeShop;Trusted_Connection=True;";

        public class TableDB
        {
            public bool createTable(Table table)
            {
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    using (SqlConnection connection = new SqlConnection(sqlConnectionString))
                    {
                        connection.Open();
                        SqlCommand command = connection.CreateCommand();
                        command.CommandText = $"INSERT INTO [table] (is_busy, name, description) values ({table.is_busy}, {table.name}, {table.description})";
                        SqlDataReader dr = command.ExecuteReader();
                        return dr.HasRows;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Cursor.Current = Cursors.Default;
                return false;
            }
        }

        // public class 
    }
}
