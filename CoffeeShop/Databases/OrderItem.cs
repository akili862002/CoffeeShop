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
    class OrderItemDB : ConnectDB
    {
        public string table = "[order_item]";

        public bool create(OrderItemEntity orderItem)
        {
            bool isOk = false;
            Cursor.Current = Cursors.WaitCursor;
            SqlTransaction trans = null;
            try
            {
                SqlConnection connection = new SqlConnection(sqlConnectionString);
                connection.Open();

                trans = connection.BeginTransaction();

                // Check login
                if (Program.Global.isAuth == false)
                {
                    trans.Rollback();
                }

                // Insert new order number
                using (SqlCommand createOrderItemCommand = new SqlCommand("", connection, trans))
                {
                    createOrderItemCommand.CommandText = $@"
                    INSERT INTO {table} (order_number, product_id, quantity)
                        VALUES (@order_number, @product_id, @quantity)";
                    createOrderItemCommand.Parameters.AddWithValue("@order_number", orderItem.order_number);
                    createOrderItemCommand.Parameters.AddWithValue("@product_id", orderItem.product_id);
                    createOrderItemCommand.Parameters.AddWithValue("@quantity", orderItem.quantity);
                    createOrderItemCommand.ExecuteNonQuery();
                }

                // Update stock of product
                using (SqlCommand updateProductCmd = new SqlCommand("", connection, trans))
                {
                    updateProductCmd.CommandText = $"UPDATE product SET stock = stock - {orderItem.quantity} WHERE id = {orderItem.product_id}";
                    updateProductCmd.ExecuteNonQuery();
                };

                trans.Commit();
                connection.Close();
                isOk = true;
            }
            catch (SqlException ex)
            {
                trans?.Rollback();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;
            return isOk;
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
            bool isOk = false;
            Cursor.Current = Cursors.WaitCursor;
            SqlTransaction trans = null;
            try
            {
                SqlConnection connection = new SqlConnection(sqlConnectionString);
                connection.Open();

                trans = connection.BeginTransaction();

                // Check login
                if (Program.Global.isAuth == false)
                {
                    trans.Rollback();
                }

                // Insert new order number
                using (SqlCommand updateOrderItemCommand = new SqlCommand("", connection, trans))
                {
                    updateOrderItemCommand.CommandText = $"UPDATE {table} SET order_number = @order_number, product_id = @product_id, quantity = @quantity WHERE id = {id}";
                    updateOrderItemCommand.Parameters.AddWithValue("@order_number", orderItem.order_number);
                    updateOrderItemCommand.Parameters.AddWithValue("@product_id", orderItem.product_id);
                    updateOrderItemCommand.Parameters.AddWithValue("@quantity", orderItem.quantity);
                    updateOrderItemCommand.ExecuteNonQuery();
                }

                // Update stock of product
                using (SqlCommand updateProduct = new SqlCommand("", connection, trans))
                {
                    updateProduct.CommandText = $"UPDATE product SET stock = stock - {orderItem.quantity} WHERE id = {orderItem.product_id}";
                    updateProduct.ExecuteNonQuery();
                };

                trans.Commit();
                connection.Close();
                isOk = true;
            }
            catch (SqlException ex)
            {
                trans?.Rollback();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;
            return isOk;
        }

        public OrderItemEntity getById(int orderItemId)
        {
            DataTable dt = new DataTable();
            this.executeAdapterQuery($@"
                SELECT order_item.id, order_number, product_id, quantity, product.menu_id 
                FROM order_item JOIN product ON order_item.product_id = product.id
                WHERE order_item.id = {orderItemId}
            ").Fill(dt);
            DataRow row = dt.Rows[0];
            if (row == null) return null;

            OrderItemEntity orderItem = new OrderItemEntity();

            orderItem
                .setId(row.Field<int>(0))
                .setOrderNumber(row.Field<int>(1))
                .setProductId(row.Field<int>(2))
                .setQuantity(Int32.Parse(row.Field<object>(3).ToString()))
                .setMenuId(row.Field<int>(4));

            // MessageBox.Show($"Found orderItem: id = {orderItem.id}, orderNumber={orderItem.order_number}, productId={orderItem.product_id}, quantity={orderItem.quantity}");

            return orderItem;
        }
    }
}
