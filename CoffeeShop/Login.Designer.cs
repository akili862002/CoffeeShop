
namespace CoffeeShop
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginButton = new Guna.UI.WinForms.GunaButton();
            this.phoneTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.passwordTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.showPasswordCheckbox = new Guna.UI.WinForms.GunaCheckBox();
            this.registerButton = new Guna.UI.WinForms.GunaLinkLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginButton.Animated = true;
            this.loginButton.AnimationHoverSpeed = 0.07F;
            this.loginButton.AnimationSpeed = 0.03F;
            this.loginButton.BackColor = System.Drawing.Color.Transparent;
            this.loginButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.loginButton.BorderColor = System.Drawing.Color.Black;
            this.loginButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.loginButton.FocusedColor = System.Drawing.Color.Empty;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Image = null;
            this.loginButton.ImageSize = new System.Drawing.Size(20, 20);
            this.loginButton.Location = new System.Drawing.Point(480, 492);
            this.loginButton.Name = "loginButton";
            this.loginButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.loginButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.loginButton.OnHoverForeColor = System.Drawing.Color.White;
            this.loginButton.OnHoverImage = null;
            this.loginButton.OnPressedColor = System.Drawing.Color.Black;
            this.loginButton.Radius = 4;
            this.loginButton.Size = new System.Drawing.Size(516, 50);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Đăng nhập";
            this.loginButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneTextBox.BackColor = System.Drawing.Color.Transparent;
            this.phoneTextBox.BaseColor = System.Drawing.Color.White;
            this.phoneTextBox.BorderColor = System.Drawing.Color.Silver;
            this.phoneTextBox.BorderSize = 1;
            this.phoneTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.phoneTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.phoneTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.phoneTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.phoneTextBox.Location = new System.Drawing.Point(479, 261);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Padding = new System.Windows.Forms.Padding(5);
            this.phoneTextBox.PasswordChar = '\0';
            this.phoneTextBox.Radius = 4;
            this.phoneTextBox.SelectedText = "";
            this.phoneTextBox.Size = new System.Drawing.Size(516, 50);
            this.phoneTextBox.TabIndex = 1;
            this.phoneTextBox.Text = "0123456789";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(467, 78);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(295, 70);
            this.gunaLabel1.TabIndex = 4;
            this.gunaLabel1.Text = "Đăng nhập";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(475, 225);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(133, 28);
            this.gunaLabel2.TabIndex = 5;
            this.gunaLabel2.Text = "Số điện thoại";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(475, 337);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(98, 28);
            this.gunaLabel3.TabIndex = 7;
            this.gunaLabel3.Text = "Mật khẩu";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextBox.BackColor = System.Drawing.Color.Transparent;
            this.passwordTextBox.BaseColor = System.Drawing.Color.White;
            this.passwordTextBox.BorderColor = System.Drawing.Color.Silver;
            this.passwordTextBox.BorderSize = 1;
            this.passwordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.passwordTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.passwordTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordTextBox.Location = new System.Drawing.Point(479, 369);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Padding = new System.Windows.Forms.Padding(5);
            this.passwordTextBox.PasswordChar = '•';
            this.passwordTextBox.Radius = 4;
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.Size = new System.Drawing.Size(516, 50);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.Tag = "";
            this.passwordTextBox.Text = "123456";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.gunaLabel4.Location = new System.Drawing.Point(478, 154);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(333, 25);
            this.gunaLabel4.TabIndex = 8;
            this.gunaLabel4.Text = "Xin chào, vui lòng đăng nhập để tiếp tục";
            // 
            // showPasswordCheckbox
            // 
            this.showPasswordCheckbox.BaseColor = System.Drawing.Color.White;
            this.showPasswordCheckbox.CheckedOffColor = System.Drawing.Color.Gray;
            this.showPasswordCheckbox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.showPasswordCheckbox.FillColor = System.Drawing.Color.White;
            this.showPasswordCheckbox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPasswordCheckbox.Location = new System.Drawing.Point(480, 439);
            this.showPasswordCheckbox.Name = "showPasswordCheckbox";
            this.showPasswordCheckbox.Size = new System.Drawing.Size(195, 31);
            this.showPasswordCheckbox.TabIndex = 3;
            this.showPasswordCheckbox.Text = "Hiển thị mật khẩu";
            this.showPasswordCheckbox.CheckedChanged += new System.EventHandler(this.showPasswordCheckbox_CheckedChanged);
            // 
            // registerButton
            // 
            this.registerButton.AutoSize = true;
            this.registerButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.LinkColor = System.Drawing.Color.Black;
            this.registerButton.Location = new System.Drawing.Point(778, 585);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(132, 28);
            this.registerButton.TabIndex = 5;
            this.registerButton.TabStop = true;
            this.registerButton.Text = "Đăng kí ngay";
            this.registerButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerButton_LinkClicked);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.gunaLabel5.Location = new System.Drawing.Point(549, 585);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(212, 28);
            this.gunaLabel5.TabIndex = 11;
            this.gunaLabel5.Text = "Bạn chưa có tài khoản?";
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::CoffeeShop.Properties.Resources.coffee_icon;
            this.gunaPictureBox1.Location = new System.Drawing.Point(16, 109);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(445, 483);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 3;
            this.gunaPictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1023, 707);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.showPasswordCheckbox);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.loginButton);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaButton loginButton;
        private Guna.UI.WinForms.GunaTextBox phoneTextBox;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaTextBox passwordTextBox;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaCheckBox showPasswordCheckbox;
        private Guna.UI.WinForms.GunaLinkLabel registerButton;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
    }
}

