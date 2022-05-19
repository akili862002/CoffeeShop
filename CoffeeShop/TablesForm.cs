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
            for (int i = 0; i < 19; i++)
            {
                this.tableListView.Items.Add(new ListViewItem()
                {
                    Text = $"Table {i}",
                    ImageIndex = i % 3 == 0 ? 1 : 0,
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
           DialogResult confirm =  MessageBox.Show("Bạn có chắc muốn xóa món này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                MessageBox.Show("Xóa thành công!");
            }
        }
    }
}
