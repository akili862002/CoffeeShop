using CoffeeShop.Entities;
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
            string query = $"SELECT COUNT(*) FROM {table} WHERE phone = {phone}";
            return executeCountQuery(query) > 0;


        }
        public SqlDataAdapter getAllAdapter(string select = "*", string search = "")
        {
            string query = $"SELECT {select} FROM {table} WHERE 1 = 1 AND fullname LIKE '%{search}%'";
            return this.executeAdapterQuery(query);
        }

        public int countMenu()
        {
            return this.executeCountQuery("SELECT COUNT(*) FROM {table}");
        }

        public bool delete(int id)
        {
            return this.executeQuery($"DELETE FROM {table} WHERE id = {id}");
        }
        public int count()
        {
            return this.executeCountQuery($"SELECT COUNT(*) FROM {table}");
        }

        public bool update(int userId, UserEntity user)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = $"UPDATE {table} SET fullname = @fullname, phone = @phone, birthdate = @birthdate, gender = @gender, address = @address, salary = @salary, avatar = @avatar WHERE id = {userId}";
            command.Parameters.AddWithValue("@fullname", user.fullname);
            command.Parameters.AddWithValue("@phone", user.phone);
            command.Parameters.AddWithValue("@birthdate", user.birthdate);
            command.Parameters.AddWithValue("@gender", user.gender);
            command.Parameters.AddWithValue("@address", user.address);
            command.Parameters.AddWithValue("@salary", user.salary);
            command.Parameters.AddWithValue("@avatar", user.avatar);

            return this.executeCommand(command);
        }

        public UserEntity getById(int userid)
        {
            DataTable dt = new DataTable();
            this.executeAdapterQuery($"SELECT id, fullname, phone, avatar, is_admin FROM [user]").Fill(dt);
            DataRow row = dt.Rows[0];
            if (row == null) return null;

            UserEntity user = new UserEntity();

            user
                .setId(row.Field<int>(0))
                .setFullName(row.Field<string>(1))
                .setPhone(row.Field<string>(2))
                .setAvatar(row.Field<string>(3))
                .setIs_admin(row.Field<bool>(4));

            return user;
        }

        public UserEntity loginUser(string phone, string password)
        {
            DataTable dt = new DataTable();
            this.executeAdapterQuery($"SELECT id, fullname, phone, avatar, is_admin FROM [user] WHERE phone = '{phone}' AND password = '{password}'").Fill(dt);
            DataRow row = dt.Rows[0];
            if (row == null) return null;

            UserEntity user = new UserEntity();

            user
                .setId(row.Field<int>(0))
                .setFullName(row.Field<string>(1))
                .setPhone(row.Field<string>(2))
                .setAvatar(row.Field<string>(3))
                .setIs_admin(row.Field<bool>(4));

            return user;
        }

        public SqlDataAdapter getStatisticsAdapter()
        {
            SqlCommand command = new SqlCommand("statistic_by_staff");
            command.CommandType = CommandType.StoredProcedure;
            return this.executeAdapterCommand(command);
        }
    }
}
