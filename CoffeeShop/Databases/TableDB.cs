using CoffeeShop.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Databases
{
    class TableDB : ConnectDB
    {
        public string tableName = "[table]";

        public bool create(TableEntity table)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = $"INSERT INTO {this.tableName} (name, description, is_busy) values (@name, @description, @is_busy)";
            cmd.Parameters.AddWithValue("@name", table.name);
            cmd.Parameters.AddWithValue("@description", table.description);
            cmd.Parameters.AddWithValue("@is_busy", table.is_busy);
            return this.executeCommand(cmd);
        }

        public SqlDataAdapter getAllAdapter(string select = "*", string search = "")
        {
            string query = $"SELECT {select} FROM {tableName} WHERE 1 = 1 ";
            if (!string.IsNullOrEmpty(search))
            {
                query += " AND name LIKE '%{search}%'";
            }
            return this.executeAdapterQuery(query);
        }
        public SqlDataReader getAllReader(string select = "*", string search = "")
        {
            string query = $"SELECT {select} FROM {tableName} WHERE 1 = 1 ";
            if (!string.IsNullOrEmpty(search))
            {
                query += " AND name LIKE '%{search}%'";
            }
            return this.executeReaderQuery(query);
        }

        public int count()
        {
            return this.executeCountQuery($"SELECT COUNT(*) FROM {tableName}");
        }

        public bool delete(int id)
        {
            return this.executeQuery($"DELETE FROM {tableName} WHERE table_id = {id}");
        }

        public bool update(int id, TableEntity table)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = $"UPDATE {tableName} SET name = @name, description = @description, is_busy = @is_busy WHERE table_id = {id}";
            command.Parameters.AddWithValue("@name", table.name);
            command.Parameters.AddWithValue("@description", table.description);
            command.Parameters.AddWithValue("@is_busy", table.is_busy);
            return this.executeCommand(command);
        }
    }
}
