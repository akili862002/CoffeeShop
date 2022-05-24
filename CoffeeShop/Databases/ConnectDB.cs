using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop.Databases
{
    class ConnectDB
    {
        // Dung Databse
        //public static string dbServerName = Program.Global.serverName;
        // Quang Databse
         public static string dbServerName = "(localdb)\\MSSQLLocalDB";

        public static string sqlConnectionString = $"Server={dbServerName};Database=CoffeeShop;Trusted_Connection=True;";

        protected bool executeQuery(string query)
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

        protected bool executeCommand(SqlCommand command)
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

        protected int executeCommandAndTakeReturn(SqlCommand command)
        {
            int id = -1;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                SqlConnection connection = new SqlConnection(sqlConnectionString);
                connection.Open();
                command.Connection = connection;
                 id = (int)command.ExecuteScalar();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;
            return id;
        }

        protected int executeCountQuery(string query)
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


        protected SqlDataAdapter executeAdapterQuery(string query)
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

        protected SqlDataReader executeReaderQuery(string query)
        {
            SqlDataReader reader = null;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                SqlConnection connection = new SqlConnection(sqlConnectionString);
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                reader = command.ExecuteReader();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;

            return reader;
        }
    }
}
