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
        bool isEditProduct = false;
        bool isEditMenu = false;
        bool isEditTable = false;
        MenuEntity menu = null;

        public MenusForm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            this.initCreateMenu();
        }
        private void MenusForm_Load(object sender, EventArgs e)
        {
            this.LoadTableTableData();
        }

        private void initEditMenu()
        {
            this.submitMenuButton.Text = "Cập nhật";
            this.menuActionLabel.Text = $"Chỉnh sửa bàn id: {menu.id}";

            this.menuNameTextBox.Text = this.menu.menu_name;
            this.deleteMenuButton.Show();
        }

        private void initCreateMenu()
        {
            this.submitMenuButton.Text = "Tạo";
            this.menuActionLabel.Text = "Thêm danh mục";

            this.menuNameTextBox.Text = "";
            this.deleteMenuButton.Hide();
        }

        public void LoadTableTableData()
        {
            new Thread(() =>
            {
                MenuDB db = new MenuDB();
                DataTable dt = new DataTable();
                db.getAllMenuAdapter(" menu.id as [ID], menu_name as [Tên danh mục], [user].id as [ID người tạo], fullname as [Tên người tạo], menu.created_at as [Tạo lúc], menu.updated_at as [cập nhật lúc]")
                .Fill(dt);

                this.Invoke(new MethodInvoker(delegate
                {
                    this.menuTable.DataSource = dt;
                }));

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
                }
                else
                {
                    db.createMenu(newMenu);
                }
                this.LoadTableTableData();
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
                this.LoadTableTableData();
            }).Start();
        }
    }
}
