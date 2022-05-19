using CoffeeShop.Databases;
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
        public TablesForm()
        {
            InitializeComponent();
            this.initTableListView();
        }

        public void loadTableData()
        {

        }

        public void initTableListView()
        {
            TableDB db = new TableDB();
            DataTable dt = new DataTable();
            db.getAllAdapter("table_id, name, is_busy").Fill(dt);


            if (dt.Rows.Count <= 0) return;

            foreach (DataRow row in dt.Rows)
            {
                this.tableListView.Items.Add(new ListViewItem()
                {
                    Text = row.Field<string>(1),
                    ImageIndex = row.Field<bool>(2) ? 1 : 0,
                    Position = Point.Empty,
                    Font = new Font("Segoe UI", 12, FontStyle.Bold),
                });
            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            using (AddOrderItem addOrderItem = new AddOrderItem())
            {
                addOrderItem.ShowDialog();
            }
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Bạn có chắc muốn xóa món này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                MessageBox.Show("Xóa thành công!");
            }
        }

        private void TablesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
