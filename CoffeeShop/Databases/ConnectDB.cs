using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop.Databases
{
    class ConnectDB
    {
        public static string dbServerName = "(localdb)\\MSSQLLocalDB";
        public static string sqlConnectionString = $"Server={dbServerName};Database=CoffeeShop;Trusted_Connection=True;";

        public bool executeQuery(string query)
        {
            bool isOk = false;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                SqlConnection connection = new SqlConnection(sqlConnectionString);
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = query;
                SqlDataReader dr = command.ExecuteReader();
                isOk = true;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;
            return isOk;
        }

        public bool executeCommand(SqlCommand command)
        {
            bool isOk = false;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                SqlConnection connection = new SqlConnection(sqlConnectionString);
                connection.Open();
                command.Connection = connection;
                SqlDataReader dr = command.ExecuteReader();
                connection.Close();
                isOk = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;
            return isOk;
        }

        public int executeCountQuery(string query)
        {
            int totalCount = 0;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                SqlConnection connection = new SqlConnection(sqlConnectionString);
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = query;
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

        public SqlDataAdapter executeAdapterQuery(string query)
        {
            SqlDataAdapter adapter = null;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                SqlConnection connection = new SqlConnection(sqlConnectionString);
                connection.Open();
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
    }
}
