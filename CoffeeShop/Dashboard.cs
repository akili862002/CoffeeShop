using CoffeeShop.Databases;
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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            this.welcomeUserLabel.Text = $"Xin chào, {Program.Global.user.fullname}";
            string avatarBase64 = Program.Global.user.avatar;
            if (!string.IsNullOrEmpty(avatarBase64))
            {
                this.avatarPicture.Image = Helper.ConvertBase64ToImage(avatarBase64);
            }
        }

        private void tablesButton_Click(object sender, EventArgs e)
        {
            using (TablesForm tf = new TablesForm())
            {
                tf.ShowDialog();
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void menusButton_Click(object sender, EventArgs e)
        {
            using (MenusForm menuForm = new MenusForm())
            {
                menuForm.ShowDialog();
            }
        }

        private void staffManagerButton_Click(object sender, EventArgs e)
        {
            using (StaffsForm staffForm = new StaffsForm())
            {
                staffForm.ShowDialog();
            }
        }

        private void statisticButton_Click(object sender, EventArgs e)
        {
            using (StatisticForm statisticForm = new StatisticForm())
            {
                statisticForm.ShowDialog();
            }
        }
        OrderDB order = new OrderDB();
        UserDB user = new UserDB();

        private void Dashboard_Load(object sender, EventArgs e)
        {
            loadOrderTable();
            orderTodayLabel.Text = order.getCountOder().ToString();
            revenueTodayLabel.Text = order.getCountRevenue().ToString();
            costTodayLabel.Text = order.getCountCost().ToString();
            totalStaffLabel.Text = user.countUser().ToString();
        }
        private void loadOrderTable()
        {
            OrderDB db = new OrderDB();
            DataTable dt = new DataTable();
            db.getAllOrdersAdapter(
                @"
                    [order].order_number as [Mã đơn],
                    FORMAT(bill.total_price, 'c', 'vi-VN') as [Tổng tiền],
                    [user].fullname as [Người bán],
                    CASE WHEN bill.order_number IS NULL THEN N'Chưa tính tiền' ELSE N'Đã thanh toán' END AS [Tình trạng],
                    [order].created_at as [Tạo lúc]
                "
                ).Fill(dt);
            this.recentOrdersDataGridView.DataSource = dt;
        }
    }
}
