using CoffeeShop.Entities;
using CoffeeShop.Databases;
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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {

            UserDB DB = new UserDB();

            UserEntity user = new UserEntity();

            if (DB.checkPhone(phoneTextBox.Text))
            {
                MessageBox.Show("ERROR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                user
                .setFullName(this.fullnameTextBox.Text)
                .setPhone(this.phoneTextBox.Text)
                .setPassword(this.passwordTextBox.Text)
                .setBirthdate(this.birthdatePicker.Value)
                .setAddress(this.addressTextBox.Text)
                .setSalary(Convert.ToInt64(salaryTextBox.Text));
                if (this.maleRadio.Checked)
                    user.setGender(true);
                if (this.famaleRadio.Checked)
                    user.setGender(false);

                new Thread(() =>
                {
                    Cursor.Current = Cursors.WaitCursor;
                    if (DB.create(user))
                    {
                        Cursor.Current = Cursors.Default;
                        MessageBox.Show("Add user successfully!", "Success");
                    }
                }).Start();
            }

            
        }
    }
}


