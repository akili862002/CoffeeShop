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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void showPasswordCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.showPasswordCheckbox.Checked)
            {
                this.passwordTextBox.PasswordChar = '\0';
            }
            else
            {
                this.passwordTextBox.PasswordChar = '•';
            }
        }

        private void registerButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (Register registerForm = new Register())
            {
                registerForm.ShowDialog();
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            UserDB DB = new UserDB();
            string phone = this.phoneTextBox.Text;
            string password = this.passwordTextBox.Text;

            if (DB.login(phone, password))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Username or password is not correct!", "Login error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
