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
    class OrderItemDB : ConnectDB
    {
        public string table = "[order_item]";

        public bool create(OrderItemEntity orderItem)
        {

            SqlCommand command = new SqlCommand();
            command.CommandText = $"insert into {table} (order_number, product_id, quantity) " +
                        "values (@order_number, @product_id, @quantity)";
            command.Parameters.AddWithValue("@order_number", orderItem.order_number);
            command.Parameters.AddWithValue("@product_id", orderItem.product_id);
            command.Parameters.AddWithValue("@quantity", orderItem.quantity);

            return this.executeCommand(command);
        }
        public SqlDataAdapter getAllAdapterByTable(int table_id, string select = "*", string search = "")
        {
            string query = $@"
                SELECT 
                    {select}
                FROM [order_item]
                JOIN product ON order_item.product_id = product.id
                JOIN [menu] ON menu.id = product.menu_id
                JOIN [order] ON [order].order_number = [order_item].order_number
                LEFT JOIN [bill] ON [bill].order_number = [order_item].order_number
                WHERE [order].table_id = {table_id}";
            return this.executeAdapterQuery(query);
        }

        public int count()
        {
            return this.executeCountQuery($"SELECT COUNT(*) FROM {table}");
        }

        public bool delete(int id)
        {
            return this.executeQuery($"DELETE FROM {table} WHERE id = {id}");
        }

        public bool update(int id, OrderItemEntity orderItem)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = $"UPDATE {table} SET order_number = @order_number, product_id = @product_id, quantity = @quantity WHERE id = {id}";
            command.Parameters.AddWithValue("@order_number", orderItem.order_number);
            command.Parameters.AddWithValue("@product_id", orderItem.product_id);
            command.Parameters.AddWithValue("@quantity", orderItem.quantity);

            return this.executeCommand(command);
        }

    }
}
