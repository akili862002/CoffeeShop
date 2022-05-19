using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeShop.Databases;
using CoffeeShop.Entities;

namespace CoffeeShop
{
    public partial class MenusForm : Form
    {
        public MenusForm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            this.initCreateMenu();
            this.initCreateProduct();
            this.initCreateTable();
        }
        private void MenusForm_Load(object sender, EventArgs e)
        {
            this.LoadMenuTableData();
            this.LoadProductTableData();
            this.LoadTableTableData();
        }

        #region Product controller
        bool isEditProduct = false;
        ProductEntity product = null;


        private void initEditProduct()
        {
            this.isEditProduct = true;
            this.submitProductButton.Text = "Cập nhật";
            this.productActionLabel.Text = $"Chỉnh sửa thực đơn id: {product.id}";
            this.deleteProductButton.Show();

            this.nameProductTextBox.Text = this.product.name;
            this.menuComboBox.SelectedIndex = this.menuComboBox.FindStringExact(this.product.menu_name);
            this.unitProductTextBox.Text = this.product.unit;
            this.stockProductTextBox.Text = this.product.stock.ToString();
            this.priceProductTextBox.Text = this.product.price.ToString();
            this.profitProductTextBox.Text = this.product.profit.ToString();
        }

        private void initCreateProduct()
        {
            this.isEditProduct = false;
            this.submitProductButton.Text = "Tạo";
            this.productActionLabel.Text = "Thêm danh mục";
            this.deleteProductButton.Hide();

            this.nameProductTextBox.Text = "";
            this.menuComboBox.SelectedIndex = -1;
            this.unitProductTextBox.Text = "";
            this.stockProductTextBox.Text = "0";
            this.priceProductTextBox.Text = "0";
            this.profitProductTextBox.Text = "0";
            this.tableEmptyRadio.Checked = false;
            this.deleteProductButton.Show();
        }

        public void LoadProductTableData()
        {
            ProductDB db = new ProductDB();
            new Thread(() =>
            {
                DataTable dt = new DataTable();
                db.getAllAdapter(
                        "product.id as ID, name as [Tên thực đơn], menu.menu_name as [Thuộc danh mục], menu.id as [Danh mục id], price as [Giá bán], profit as [Lợi nhuận], unit as [Đơn vị], stock as [Hàng tồn], is_in_stock as [Trạng thái]",
                        this.searchProductTextBox.Text
                    )
                .Fill(dt);

                this.Invoke(new MethodInvoker(delegate
                {
                    this.productTable.DataSource = dt;
                }));

            }).Start();
            new Thread(() =>
            {
                int totalCount = db.count();
                this.productTableLabel.Text = $"Danh sách thực đơn ({totalCount})";
            }).Start();
        }

        private void productTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentIndex = this.productTable.CurrentCell.RowIndex;
            if (currentIndex < 0) return;

            DataGridViewRow row = this.productTable.Rows[currentIndex];
            this.product = new ProductEntity();
            this.product
                .setId(Int32.Parse(row.Cells["ID"].Value.ToString()))
                .setName(row.Cells["Tên thực đơn"].Value.ToString())
                .setMenuId(Int32.Parse(row.Cells["Danh mục id"].Value.ToString()))
                .setMenuName((row.Cells["Thuộc danh mục"].Value.ToString()))
                .setUnit(row.Cells["Đơn vị"].Value.ToString())
                .setStock(Int32.Parse(row.Cells["Hàng tồn"].Value.ToString()))
                .setPrice(Int64.Parse(row.Cells["Giá bán"].Value.ToString()))
                .setProfit(Int64.Parse(row.Cells["Lợi nhuận"].Value.ToString()));

            this.isEditProduct = true;
            initEditProduct();
        }

        private void clearProductButton_Click(object sender, EventArgs e)
        {
            this.initCreateProduct();
        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show($"Bạn có chắc muốn xóa [{this.product.name}]?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) return;

            ProductDB db = new ProductDB();
            new Thread(() =>
            {
                db.delete(this.product.id);
                this.LoadProductTableData();
                this.initCreateProduct();
            }).Start();
        }

        private void searchProductButton_Click(object sender, EventArgs e)
        {
            this.LoadProductTableData();
        }

        private void submitProductButton_Click(object sender, EventArgs e)
        {
            ProductEntity newProduct = new ProductEntity();

            DataRowView menuRow = (DataRowView)this.menuComboBox.SelectedItem;

            newProduct
                .setName(this.nameProductTextBox.Text)
                .setMenuId(Int32.Parse(menuRow["id"].ToString()))
                .setUnit(this.unitProductTextBox.Text)
                .setStock(Int32.Parse(this.stockProductTextBox.Text))
                .setPrice(Int32.Parse(this.priceProductTextBox.Text))
                .setProfit(Int32.Parse(this.profitProductTextBox.Text));

            ProductDB db = new ProductDB();
            new Thread(() =>
            {
                if (isEditProduct)
                {
                    db.update(this.product.id, newProduct);
                    MessageBox.Show("Cập nhật thực đơn thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    db.createProduct(newProduct);
                    MessageBox.Show("Tạo thực đơn thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.initCreateProduct();
                }
                this.LoadProductTableData();
            }).Start();
        }
        #endregion

        #region Menu controller
        bool isEditMenu = false;
        MenuEntity menu = null;
        private void initEditMenu()
        {
            this.isEditMenu = true;
            this.submitMenuButton.Text = "Cập nhật";
            this.menuActionLabel.Text = $"Chỉnh sửa bàn id: {menu.id}";

            this.menuNameTextBox.Text = this.menu.menu_name;
            this.deleteMenuButton.Show();
        }

        private void initCreateMenu()
        {
            this.isEditMenu = false;
            this.submitMenuButton.Text = "Tạo";
            this.menuActionLabel.Text = "Thêm danh mục";

            this.menuNameTextBox.Text = "";
            this.deleteMenuButton.Hide();
        }

        public void LoadMenuTableData()
        {
            MenuDB db = new MenuDB();
            new Thread(() =>
            {
                DataTable dt = new DataTable();
                db.getAllMenuAdapter(
                        "menu.id as [ID], menu_name as [Tên danh mục], [user].id as [ID người tạo], fullname as [Tên người tạo], menu.created_at as [Tạo lúc], menu.updated_at as [cập nhật lúc]",
                        this.searchMenuTextBox.Text
                    )
                .Fill(dt);

                this.Invoke(new MethodInvoker(delegate
                {
                    this.menuTable.DataSource = dt;
                    this.menuComboBox.DataSource = dt;
                    this.menuComboBox.DisplayMember = "Tên danh mục";
                }));

            }).Start();
            new Thread(() =>
            {
                int totalCount = db.countMenu();
                this.menuTableLabel.Text = $"Danh sách danh mục ({totalCount})";
            }).Start();
        }

        private void submitMenuButton_Click(object sender, EventArgs e)
        {
            MenuEntity newMenu = new MenuEntity();
            newMenu.setName(this.menuNameTextBox.Text);
            MenuDB db = new MenuDB();
            new Thread(() =>
            {
                if (isEditMenu)
                {
                    db.updateMenu(menu.id, newMenu);
                    MessageBox.Show("Cập nhật thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    db.createMenu(newMenu);
                    MessageBox.Show("Tạo thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.LoadMenuTableData();
            }).Start();
        }

        private void menuTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentIndex = this.menuTable.CurrentCell.RowIndex;
            if (currentIndex < 0) return;

            DataGridViewRow row = this.menuTable.Rows[currentIndex];
            this.menu = new MenuEntity();
            this.menu.setId(Int32.Parse(row.Cells["ID"].Value.ToString())).setName(row.Cells["Tên danh mục"].Value.ToString());
            this.isEditMenu = true;
            initEditMenu();
        }

        private void clearMenuButton_Click(object sender, EventArgs e)
        {
            this.initCreateMenu();
        }

        private void deleteMenuButton_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show($"Bạn có chắc muốn xóa [{menu.menu_name}]?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) return;

            MenuDB db = new MenuDB();
            new Thread(() =>
            {
                db.deleteMenu(this.menu.id);
                this.LoadMenuTableData();
                this.initCreateMenu();
            }).Start();
        }

        private void searchMenuButton_Click(object sender, EventArgs e)
        {
            this.LoadMenuTableData();
        }
        #endregion

        #region Table controller
        bool isEditTable = false;
        TableEntity table = null;
        private void initEditTable()
        {
            this.isEditTable = true;
            this.submitTableButton.Text = "Cập nhật";
            this.tableTableLabel.Text = $"Chỉnh sửa bàn id: {table.table_id}";

            this.tableNameTextBox.Text = this.table.name;
            this.tableDescTextBox.Text = this.table.description;
            this.tableEmptyRadio.Checked = this.table.is_busy;
            this.tableBusyRadio.Checked = !this.table.is_busy;

            this.deleteTableButton.Show();
        }

        private void initCreateTable()
        {
            this.isEditTable = false;
            this.submitTableButton.Text = "Thêm";
            this.actionTableLabel.Text = "Thêm bàn";

            this.tableNameTextBox.Text = "";
            this.tableDescTextBox.Text = "";
            this.tableEmptyRadio.Checked = true;
            this.tableBusyRadio.Checked = false;

            this.tableNameTextBox.Text = "";
            this.deleteMenuButton.Hide();
        }

        public void LoadTableTableData()
        {
            TableDB db = new TableDB();
            new Thread(() =>
            {
                DataTable dt = new DataTable();
                db.getAllAdapter(
                        "table_id as [ID], [name] as [Tên bàn], description as [Nội dung], CASE WHEN is_busy = 1 THEN N'Có khách' ELSE N'Trống' END as [Tình trạng]",
                        this.searchMenuTextBox.Text
                    )
                .Fill(dt);

                this.Invoke(new MethodInvoker(delegate
                {
                    this.tableTable.DataSource = dt;
                }));

            }).Start();
            new Thread(() =>
            {
                int totalCount = db.count();
                this.tableTableLabel.Text = $"Danh sách bàn ({totalCount})";
            }).Start();
        }

        private void submitTableButton_Click(object sender, EventArgs e)
        {
            TableEntity newTable = new TableEntity();
            newTable
                .setName(this.tableNameTextBox.Text)
                .setDescription(this.tableDescTextBox.Text)
                .setIsBusy(this.tableBusyRadio.Checked);
            TableDB db = new TableDB();
            new Thread(() =>
            {
                if (isEditTable)
                {
                    db.update(table.table_id, newTable);
                    MessageBox.Show("Cập nhật thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    db.create(newTable);
                    MessageBox.Show("Tạo thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.LoadTableTableData();
            }).Start();
        }

        private void tableTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentIndex = this.tableTable.CurrentCell.RowIndex;
            if (currentIndex < 0) return;

            DataGridViewRow row = this.tableTable.Rows[currentIndex];
            this.table = new TableEntity();
            this.table
                .setId(Int32.Parse(row.Cells["ID"].Value.ToString()))
                .setName(row.Cells["Tên bàn"].Value.ToString())
                .setDescription(row.Cells["Nội dung"].Value.ToString())
                .setIsBusy(row.Cells["Tình trạng"].Value.ToString() == "Trống");
            initEditTable();
        }

        private void clearTableButton_Click(object sender, EventArgs e)
        {
            this.initCreateTable();
        }

        private void deleteTableButton_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show($"Bạn có chắc muốn xóa [{table.name}]?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) return;

            TableDB db = new TableDB();
            new Thread(() =>
            {
                db.delete(this.table.table_id);
                this.LoadTableTableData();
                this.initCreateTable();
            }).Start();
        }

        private void searchTableButton_Click(object sender, EventArgs e)
        {
            this.LoadTableTableData();
        }
        #endregion
    }
}
