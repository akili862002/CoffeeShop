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
        bool isEdit = false;
        public MenusForm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        private void MenusForm_Load(object sender, EventArgs e)
        {
            this.LoadTableTableData();
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
            newMenu.setName(this.menuNameTextBox.Text).setCreatedBy(Program.Global.user.id);
            MenuDB db = new MenuDB();
            new Thread(() =>
            {

                if (isEdit)
                {
                }
                else
                {
                    bool isOk = db.createMenu(newMenu);
                    if (isOk)
                    {
                        this.LoadTableTableData();
                    } 
                }
            }).Start();
        }

    }
}
