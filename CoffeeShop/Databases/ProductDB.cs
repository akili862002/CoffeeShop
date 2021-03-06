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
    class ProductDB : ConnectDB
    {
        public string table = "[product]";

        public bool createProduct(ProductEntity product)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = $"INSERT INTO {table} (name, profit, price, stock, unit, menu_id, created_by) values (@name, @profit, @price, @stock, @unit, @menu_id, @created_by)";
            cmd.Parameters.AddWithValue("@name", product.name);
            cmd.Parameters.AddWithValue("@profit", product.profit);
            cmd.Parameters.AddWithValue("@price", product.price);
            cmd.Parameters.AddWithValue("@stock", product.stock);
            cmd.Parameters.AddWithValue("@unit", product.unit);
            cmd.Parameters.AddWithValue("@menu_id", product.menu_id);
            cmd.Parameters.AddWithValue("@created_by", product.created_by);

            return this.executeCommand(cmd);
        }

        public SqlDataAdapter getAllAdapter(string select = "*", string search = "", string filterString = "")
        {
            string query = $"SELECT {select} FROM {table} JOIN [menu] ON product.menu_id = menu.id WHERE 1 = 1 ";
            if (!string.IsNullOrEmpty(search))
                query += $"AND name LIKE '%{search}%' ";
            if (!string.IsNullOrEmpty(filterString))
                query += filterString;
            return this.executeAdapterQuery(query);
        }

        public SqlDataAdapter getStatisticsAdapter()
        {
            SqlCommand command = new SqlCommand("statistic_by_product");
            command.CommandType = CommandType.StoredProcedure;
            return this.executeAdapterCommand(command);
        }

        public int count()
        {
            return this.executeCountQuery($"SELECT COUNT(*) FROM {table}");
        }
        public bool delete(int id)
        {
            return this.executeQuery($"DELETE FROM {table} WHERE id = {id}");
        }

        public bool update(int id, ProductEntity product)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = $"UPDATE {table} SET name = @name, profit = @profit, price = @price, stock = @stock, unit = @unit, menu_id = @menu_id, created_by = @created_by WHERE id = {id}";
            cmd.Parameters.AddWithValue("@name", product.name);
            cmd.Parameters.AddWithValue("@profit", product.profit);
            cmd.Parameters.AddWithValue("@price", product.price);
            cmd.Parameters.AddWithValue("@stock", product.stock);
            cmd.Parameters.AddWithValue("@unit", product.unit);
            cmd.Parameters.AddWithValue("@menu_id", product.menu_id);
            cmd.Parameters.AddWithValue("@created_by", product.created_by);

            return this.executeCommand(cmd);
        }
    }
}
