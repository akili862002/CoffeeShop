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

        public SqlDataAdapter getAllOrdersAdapter(string selectString = "*")
        {
            SqlCommand command = new SqlCommand($@"
                SELECT	
                    {selectString}
                FROM [order]
                LEFT JOIN bill ON [order].order_number = bill.order_number
                JOIN [user] ON [user].id = [order].buyer_id
            ");
            return this.executeAdapterCommand(command);
        }
    }
}
