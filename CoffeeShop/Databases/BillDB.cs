using CoffeeShop.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Databases
{
    class BillDB : ConnectDB
    {
        string tableName = "[bill]";

        public bool create(BillEntity bill)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = $"INSERT INTO {this.tableName} (order_number, customer_pay, total_price, description) values (@order_number, @customer_pay, @total_price, @description)";
            cmd.Parameters.AddWithValue("@order_number", bill.order_number);
            cmd.Parameters.AddWithValue("@customer_pay", bill.customer_pay);
            cmd.Parameters.AddWithValue("@total_price", bill.total_price);
            cmd.Parameters.AddWithValue("@description", bill.description);
            return this.executeCommand(cmd);
        }
    }
}
