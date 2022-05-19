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
    }
}
