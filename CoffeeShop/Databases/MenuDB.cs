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
            return this.executeQuery($"INSERT INTO {table} (menu_name, created_by) values ('{menu.menu_name}', {menu.created_by})");
        }

        public SqlDataAdapter getAllMenuAdapter(string select = "*", string search = "")
        {
            string query = $"SELECT {select} FROM {table} JOIN [user] ON menu.created_by = [user].id WHERE 1 = 1 AND menu_name LIKE '%{search}%'";
            return this.executeAdapterQuery(query);
        }

        public int countMenu()
        {
            return this.executeCountQuery("SELECT COUNT(*) FROM {table}");
        }

        public bool deleteMenu(int id)
        {
            return this.executeQuery($"DELETE FROM {table} WHERE id = @id");
        }

        public bool updateMenu(int id, MenuEntity menu)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = $"UPDATE {table} SET menu_name = @menu_name WHERE id = {id}";
            command.Parameters.AddWithValue("@menu_name", menu.menu_name);

            return this.executeCommand(command);
        }
    }
}
