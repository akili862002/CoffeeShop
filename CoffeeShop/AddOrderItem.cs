using CoffeeShop.Databases;
using CoffeeShop.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class AddOrderItem : Form
    {
        int order_number;
        string table_name;
        // Edit
        bool isEdit = false;
        OrderItemEntity orderItem;

        public AddOrderItem(int order_number, string table_name, bool isEdit = false, int orderItemId = -1)
        {
            InitializeComponent();
            this.order_number = order_number;
            this.table_name = table_name;
            this.isEdit = isEdit;

            this.LoadMenuTableData();

            if (isEdit)
            {
                this.titleLabel.Text = $"Chỉnh sửa món {table_name}";
                OrderItemDB db = new OrderItemDB();
                this.orderItem = db.getById(orderItemId);
                // MessageBox.Show(orderItem.id.);
            }
            else
            {
                this.titleLabel.Text = $"Thêm món {table_name}";
            }
        }

        public void LoadMenuTableData()
        {
            MenuDB db = new MenuDB();
            DataTable dt = new DataTable();
            db.getAllMenuAdapter(
                    "menu.id as [ID], menu_name"
                )
            .Fill(dt);

            this.menuComboBox.DataSource = dt;
            this.menuComboBox.DisplayMember = "menu_name";

            if (this.isEdit)
            {
                DataRow[] rows = dt.Select($"id = {this.orderItem.menu_id}");
                this.productComboBox.SelectedIndex = dt.Rows.IndexOf(rows[0]);
            }

            this.LoadProductTableData();
        }

        public void LoadProductTableData()
        {
            DataRowView row = (DataRowView)this.menuComboBox.SelectedItem;
            ProductDB db = new ProductDB();
            DataTable dt = new DataTable();
            db.getAllAdapter("product.id as id, name, price", "", $" AND menu_id = {row["ID"].ToString()}")
            .Fill(dt);

            this.productComboBox.DataSource = dt;
            this.productComboBox.DisplayMember = "name";

            if (this.isEdit)
            {
                DataRow[] rows = dt.Select($"id = {this.orderItem.product_id}");
                this.productComboBox.SelectedIndex = dt.Rows.IndexOf(rows[0]);
            }
        }

        private void menuComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadProductTableData();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)this.productComboBox.SelectedItem;
            int product_id = Int32.Parse(row["id"].ToString());
            OrderItemEntity orderItem = new OrderItemEntity();
            orderItem
                .setOrderNumber(this.order_number)
                .setProductId(product_id)
                .setQuantity((int)this.quantityNumberic.Value);
            OrderItemDB db = new OrderItemDB();
            if (db.create(orderItem))
                DialogResult = DialogResult.OK;
        }

        private void AddOrderItem_Load(object sender, EventArgs e)
        {

        }

        private void quantityNumberic_ValueChanged(object sender, EventArgs e)
        {
            this.calcTotalPrice();
        }
        private void productComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.calcTotalPrice();
        }

        public void calcTotalPrice()
        {
            DataRowView row = (DataRowView)this.productComboBox.SelectedItem;
            long price = Int32.Parse(row["price"].ToString());
            int quantity = (int)this.quantityNumberic.Value;

            long totalPrice = price * quantity;
            this.totalPriceLabel.Text = Currency.formatPrice(totalPrice);
        }

    }
}
