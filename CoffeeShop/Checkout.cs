using CoffeeShop.Databases;
using CoffeeShop.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class Checkout : Form
    {
        int tableId;
        int orderNumber;
        long price;
        public Checkout(int tableId, string tableName, int orderNumber)
        {
            InitializeComponent();
            this.tableId = tableId;
            this.orderNumber = orderNumber;

            this.titleLablel.Text = $"Thanh toán {tableName}";
            this.orderLabel.Text = $"Đơn hàng #{orderNumber}";

            this.loadTableOrderItems();
            this.updatePrice();
        }

        private void loadTableOrderItems()
        {
            OrderItemDB db = new OrderItemDB();
            DataTable dt = new DataTable();

            db.getAllAdapterByTable(this.tableId,
               @"
                product.name as [Tên món],
                menu.menu_name as [Danh mục],
                quantity as [Số lượng],
                FORMAT(product.price, 'c', 'vi-VN') as [Đơn giá],
                FORMAT(product.price * quantity , 'c', 'vi-VN')  as [Tổng giá] "
               ).Fill(dt);
            this.orderItemsTable.DataSource = dt;
        }

        private void updatePrice()
        {
            OrderDB db = new OrderDB();
            this.price = db.getTotalPriceOfOrder(this.orderNumber);
            this.totalPriceLabel.Text = Currency.formatPrice(this.price);
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            BillDB db = new BillDB();
            BillEntity bill = new BillEntity();
            bill
                .setCustomerPay(this.price)
                .setTotalPrice(this.price)
                .setDescription(this.descTextBox.Text)
                .setOrderNumber(this.orderNumber);
            if (db.create(bill)) {
                MessageBox.Show("Thanh toán thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            };
        }
    }
}
