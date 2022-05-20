
namespace CoffeeShop
{
    partial class AddOrderItem
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
            this.submitButton = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.quantityNumberic = new Guna.UI.WinForms.GunaNumeric();
            this.productComboBox = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.menuComboBox = new Guna.UI.WinForms.GunaComboBox();
            this.titleLabel = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.totalPriceLabel = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.submitButton.Animated = true;
            this.submitButton.AnimationHoverSpeed = 0.07F;
            this.submitButton.AnimationSpeed = 0.03F;
            this.submitButton.BackColor = System.Drawing.Color.Transparent;
            this.submitButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.submitButton.BorderColor = System.Drawing.Color.Black;
            this.submitButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.submitButton.FocusedColor = System.Drawing.Color.Empty;
            this.submitButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.ForeColor = System.Drawing.Color.White;
            this.submitButton.Image = null;
            this.submitButton.ImageSize = new System.Drawing.Size(20, 20);
            this.submitButton.Location = new System.Drawing.Point(22, 472);
            this.submitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submitButton.Name = "submitButton";
            this.submitButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.submitButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.submitButton.OnHoverForeColor = System.Drawing.Color.White;
            this.submitButton.OnHoverImage = null;
            this.submitButton.OnPressedColor = System.Drawing.Color.Black;
            this.submitButton.Radius = 4;
            this.submitButton.Size = new System.Drawing.Size(513, 52);
            this.submitButton.TabIndex = 59;
            this.submitButton.Text = "Thêm món";
            this.submitButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel9.Location = new System.Drawing.Point(18, 310);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(94, 28);
            this.gunaLabel9.TabIndex = 58;
            this.gunaLabel9.Text = "Số lượng";
            // 
            // quantityNumberic
            // 
            this.quantityNumberic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quantityNumberic.BaseColor = System.Drawing.Color.White;
            this.quantityNumberic.BorderColor = System.Drawing.Color.Silver;
            this.quantityNumberic.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.quantityNumberic.ButtonForeColor = System.Drawing.Color.White;
            this.quantityNumberic.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.quantityNumberic.ForeColor = System.Drawing.Color.Black;
            this.quantityNumberic.Location = new System.Drawing.Point(22, 341);
            this.quantityNumberic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quantityNumberic.Maximum = ((long)(9999999));
            this.quantityNumberic.Minimum = ((long)(0));
            this.quantityNumberic.Name = "quantityNumberic";
            this.quantityNumberic.Size = new System.Drawing.Size(503, 30);
            this.quantityNumberic.TabIndex = 57;
            this.quantityNumberic.Text = "quantityNumberic";
            this.quantityNumberic.Value = ((long)(1));
            this.quantityNumberic.ValueChanged += new System.EventHandler(this.quantityNumberic_ValueChanged);
            // 
            // productComboBox
            // 
            this.productComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productComboBox.BackColor = System.Drawing.Color.Transparent;
            this.productComboBox.BaseColor = System.Drawing.Color.White;
            this.productComboBox.BorderColor = System.Drawing.Color.Silver;
            this.productComboBox.BorderSize = 1;
            this.productComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.productComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.productComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.productComboBox.ForeColor = System.Drawing.Color.Black;
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.ItemHeight = 25;
            this.productComboBox.Location = new System.Drawing.Point(22, 252);
            this.productComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.productComboBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.productComboBox.Radius = 4;
            this.productComboBox.Size = new System.Drawing.Size(502, 31);
            this.productComboBox.TabIndex = 56;
            this.productComboBox.SelectedIndexChanged += new System.EventHandler(this.productComboBox_SelectedIndexChanged);
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.Location = new System.Drawing.Point(18, 221);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(108, 28);
            this.gunaLabel8.TabIndex = 55;
            this.gunaLabel8.Text = "Chọn món";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.Location = new System.Drawing.Point(18, 125);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(105, 28);
            this.gunaLabel7.TabIndex = 54;
            this.gunaLabel7.Text = "Danh mục";
            // 
            // menuComboBox
            // 
            this.menuComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuComboBox.BackColor = System.Drawing.Color.Transparent;
            this.menuComboBox.BaseColor = System.Drawing.Color.White;
            this.menuComboBox.BorderColor = System.Drawing.Color.Silver;
            this.menuComboBox.BorderSize = 1;
            this.menuComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.menuComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menuComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.menuComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuComboBox.ForeColor = System.Drawing.Color.Black;
            this.menuComboBox.FormattingEnabled = true;
            this.menuComboBox.ItemHeight = 25;
            this.menuComboBox.Location = new System.Drawing.Point(22, 156);
            this.menuComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuComboBox.Name = "menuComboBox";
            this.menuComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.menuComboBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.menuComboBox.Radius = 4;
            this.menuComboBox.Size = new System.Drawing.Size(502, 31);
            this.menuComboBox.TabIndex = 53;
            this.menuComboBox.SelectedIndexChanged += new System.EventHandler(this.menuComboBox_SelectedIndexChanged);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(143, 30);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(375, 48);
            this.titleLabel.TabIndex = 60;
            this.titleLabel.Text = "Thêm món bàn số 14";
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.ErrorImage = global::CoffeeShop.Properties.Resources.coffee_icon;
            this.gunaPictureBox1.Image = global::CoffeeShop.Properties.Resources.coffee_icon;
            this.gunaPictureBox1.Location = new System.Drawing.Point(35, 12);
            this.gunaPictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(102, 80);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 61;
            this.gunaPictureBox1.TabStop = false;
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.totalPriceLabel.Location = new System.Drawing.Point(321, 402);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.totalPriceLabel.Size = new System.Drawing.Size(204, 38);
            this.totalPriceLabel.TabIndex = 63;
            this.totalPriceLabel.Text = "0đ";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(178, 402);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(159, 38);
            this.gunaLabel3.TabIndex = 62;
            this.gunaLabel3.Text = "Tổng tiền: ";
            // 
            // AddOrderItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(549, 550);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.gunaLabel9);
            this.Controls.Add(this.quantityNumberic);
            this.Controls.Add(this.productComboBox);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.menuComboBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddOrderItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddOrderItem";
            this.Load += new System.EventHandler(this.AddOrderItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton submitButton;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaNumeric quantityNumberic;
        private Guna.UI.WinForms.GunaComboBox productComboBox;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaComboBox menuComboBox;
        private Guna.UI.WinForms.GunaLabel titleLabel;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaLabel totalPriceLabel;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
    }
}