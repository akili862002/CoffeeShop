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
    public partial class StatisticForm : Form
    {
        public StatisticForm()
        {
            InitializeComponent();
        }

        private void productFilterCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            this.productfilterPanel.Enabled = this.productFilterCheckbox.Checked;
        }

        private void staffUseFilterCheckbox_CheckedChanged(object sender, EventArgs e)
        {

            this.staffFilterPanel.Enabled = this.staffUseFilterCheckbox.Checked;
        }

        private void orderFilterCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            this.orderFilterPanel.Enabled  = this.orderFilterCheckbox.Checked;
        }
    }
}
