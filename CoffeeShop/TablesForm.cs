using CoffeeShop.Databases;
using CoffeeShop.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class TablesForm : Form
    {
        TableEntity tableSelected = new TableEntity();
        public TablesForm()
        {
            InitializeComponent();
            this.initTableListView();
            actionTablePanel.Enabled = false;
        }

        private void TablesForm_Load(object sender, EventArgs e)
        {

        }

        public void loadTableDataOfCurrentTable()
        {
            if (tableSelected == null)
                return;

            OrderItemDB db = new OrderItemDB();
            DataTable dt = new DataTable();
            db.getAllAdapterByTable(this.tableSelected.table_id,
                @"
                order_item.id as [Id đơn],
                product.name as [Tên món],
                menu.menu_name as [Danh mục],
                quantity as [Số lượng],
                order_item.updated_at as [Cập nhật lúc],
                FORMAT(product.price, 'c', 'vi-VN') as [Đơn giá],
                FORMAT(product.price * quantity , 'c', 'vi-VN')  as [Tổng giá] "
                ).Fill(dt);
            this.orderItemsTable.DataSource = dt;
        }


        public void initTableListView()
        {
            TableDB db = new TableDB();
            DataTable dt = new DataTable();
            db.getAllAdapter(@"
                [table].table_id,
                [name], 
                CASE WHEN [order].order_number IS NULL THEN 0 ELSE 1 END AS is_busy, 
                [order].order_number
            ").Fill(dt);

            if (dt.Rows.Count <= 0) return;

            this.tableListView.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                this.tableListView.Items.Add(new ListViewItem()
                {
                    Text = row.Field<string>(1),
                    ImageIndex = row.Field<int>(2),
                    Position = Point.Empty,
                    Font = new Font("Segoe UI", 12, FontStyle.Bold),
                });
            }
        }

        private void addOrderItemButton_Click(object sender, EventArgs e)
        {
            int order_number = this.tableSelected.order_number;

            if (!tableSelected.is_busy)
            {
                OrderDB db = new OrderDB();
                OrderEntity order = new OrderEntity();
                order
                    .setDescription("")
                    .setTableItd(this.tableSelected.table_id);
                order_number = db.create(order);
            }

            using (AddOrderItem addOrderItem = new AddOrderItem(order_number, this.tableSelected.name))
            {
                addOrderItem.ShowDialog();

                this.loadTableDataOfCurrentTable();
                this.initTableListView();
                this.tableListView_SelectedIndexChanged(null, null);
                this.updatePrice();
            }
        }

        private void deleteOrderItemButton_Click(object sender, EventArgs e)
        {
            if (this.orderItemsTable.CurrentCell == null) return;
            int currentIndex = this.orderItemsTable.CurrentCell.RowIndex;
            if (currentIndex < 0) return;

            DataGridViewRow row = this.orderItemsTable.Rows[currentIndex];

            DialogResult confirm = MessageBox.Show($"Bạn có chắc muốn xóa [{row.Cells["Tên món"].Value.ToString()}]?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            OrderItemDB db = new OrderItemDB();

            if (confirm == DialogResult.No) return;

            db.delete(Int32.Parse(row.Cells["Id đơn"].Value.ToString()));
            MessageBox.Show("Xóa thành công!");

            this.loadTableDataOfCurrentTable();
            this.initTableListView();
            this.tableListView_SelectedIndexChanged(null, null);
            this.updatePrice();
        }

        private void tableListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tableListView.SelectedIndices.Count <= 0)
                return;

            int intselectedindex = this.tableListView.SelectedIndices[0];
            if (intselectedindex < 0) return;

            string text = tableListView.Items[intselectedindex].Text;
            TableDB db = new TableDB();
            DataTable dt = new DataTable();
            db.getAllAdapter(@"
                [table].table_id,
                [name], 
                CASE WHEN [order].order_number IS NULL THEN 0 ELSE 1 END AS is_busy, 
                [table].description,
                [order].order_number
            ").Fill(dt);

            if (dt.Rows.Count <= 0) return;

            foreach (DataRow row in dt.Rows)
            {
                if (row.Field<string>(1) == text)
                {
                    this.tableSelected = new TableEntity();
                    this.tableSelected
                        .setId(row.Field<int>(0))
                        .setName(row.Field<string>(1))
                        .setIsBusy(row.Field<int>(2) == 1)
                        .setDescription(row.Field<string>(3));
                    if (this.tableSelected.is_busy)
                        this.tableSelected.setOrderNumber(row.Field<int>(4));
                    break;
                }
            }

            this.currTableLabel.Text = this.tableSelected.name;
            actionTablePanel.Enabled = true;
            if (this.tableSelected.is_busy)
            {
                this.deleteOrderItemButton.Enabled = true;
            }
            else
            {
                this.deleteOrderItemButton.Enabled = false;
            }
            this.loadTableDataOfCurrentTable();
            this.updatePrice();
        }

        private void updatePrice()
        {
            OrderDB db = new OrderDB();

            if (this.tableSelected == null)
            {
                this.totalPriceLabel.Text = Currency.formatPrice(0);
                return;
            }

            int order_number = this.tableSelected.order_number;

            if (order_number <= 0)
            {
                this.totalPriceLabel.Text = Currency.formatPrice(0);
                return;
            }

            this.totalPriceLabel.Text = Currency.formatPrice(db.getTotalPriceOfOrder(this.tableSelected.order_number));
        }
    }
}
