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
    class OrderDB : ConnectDB
    {
        string table = "[order]";
        public int create(OrderEntity order)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = $"INSERT INTO {table} (description, table_id, buyer_id) OUTPUT INSERTED.order_number values (@description, @table_id, @buyer_id)";
            cmd.Parameters.AddWithValue("@description", order.description);
            cmd.Parameters.AddWithValue("@table_id", order.table_id);
            cmd.Parameters.AddWithValue("@buyer_id", order.buyer_id);
            return this.executeCommandAndTakeReturn(cmd);
        }

        public int getOrderNumberOfCurrentTable(int table_id)
        {
            string query = $@"
                SELECT [order].order_number
                FROM [order] LEFT JOIN bill ON [order].order_number = bill.order_number
                WHERE [order].table_id = {table_id}
            ";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;

            return this.executeCommandAndTakeReturn(cmd);
        }

        public int getTotalPriceOfOrder(int order_number)
        {
            return this.executeCountQuery($"SELECT dbo.get_total_price_of_order({order_number})");
        }
        public int getCountOder()
        {
            string query = $"SELECT COUNT(*) FROM {table} WHERE created_at >= CONVERT(varchar(10),GETDATE(),101)";
            return executeCountQuery(query);
        }
        public int getCountRevenue()
        {
            string query = $"SELECT SUM([order_item].quantity*product.price) FROM [product] " +
                $"INNER JOIN [order_item] ON [product].id = [order_item].product_id INNER JOIN [order] ON [order_item].order_number=[order].order_number " +
                $"WHERE [order].created_at >= CONVERT(varchar(10),GETDATE(),101)";
            return executeCountQuery(query);
        }
        public int getCountCost()
        {
            string query = $"SELECT SUM([order_item].quantity*(product.price - product.profit)) FROM [product] " +
                $"INNER JOIN [order_item] ON [product].id = [order_item].product_id INNER JOIN [order] ON [order_item].order_number=[order].order_number " +
                $"WHERE [order].created_at >= CONVERT(varchar(10),GETDATE(),101)";
            return executeCountQuery(query);
        }
    }
}
