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
    class UserDB : ConnectDB
    {
        public string table = "[user]";

        public bool create(UserEntity user)
        {

            SqlCommand command = new SqlCommand();
            command.CommandText = $"insert into {table} (fullname, phone, password, birthdate, gender, address, salary) " +
                        "values (@fullname, @phone, @password, @birthdate, @gender, @address, @salary)";
            command.Parameters.AddWithValue("@fullname", user.fullname);
            command.Parameters.AddWithValue("@phone", user.phone);
            command.Parameters.AddWithValue("@password", user.password);
            command.Parameters.AddWithValue("@birthdate", user.birthdate);
            command.Parameters.AddWithValue("@gender", user.gender);
            command.Parameters.AddWithValue("@address", user.address);
            command.Parameters.AddWithValue("@salary", user.salary);

            return this.executeCommand(command);
        }
        public bool login(string phone, string password)
        {
            Cursor.Current = Cursors.WaitCursor;

            SqlConnection connection = new SqlConnection(sqlConnectionString);
            connection.Open();
            using (SqlCommand command = connection.CreateCommand())
            {
                try
                {
                    command.CommandText = $"SELECT * FROM {table} WHERE phone = @phone AND password = @password";
                    command.Parameters.Add("@phone", phone);
                    command.Parameters.Add("@password", password);
                    SqlDataReader dr = command.ExecuteReader();
                    return dr.HasRows;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }
            connection.Close();
            return false;
        }

        public bool checkPhone(string phone)
        {
            string query = $"SELECT * FROM {table} WHERE phone = {phone}";
            return executeCountQuery(query)>0;


        }
        public SqlDataAdapter getAllAdapter(string select = "*", string search = "")
        {
            string query = $"SELECT {select} FROM {table} JOIN [user] ON menu.created_by = [user].id WHERE 1 = 1 AND menu_name LIKE '%{search}%'";
            return this.executeAdapterQuery(query);
        }

        public int countMenu()
        {
            return this.executeCountQuery("SELECT COUNT(*) FROM {table}");
        }

        public bool delete(int id)
        {
            return this.executeQuery($"DELETE FROM {table} WHERE id = @id");
        }

        public bool update(int id, MenuEntity menu)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = $"UPDATE {table} SET menu_name = @menu_name WHERE id = {id}";
            command.Parameters.AddWithValue("@menu_name", menu.menu_name);

            return this.executeCommand(command);
        }

    }
}
