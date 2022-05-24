
namespace CoffeeShop
{
    partial class Checkout
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.titleLablel = new Guna.UI.WinForms.GunaLabel();
            this.descTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel18 = new Guna.UI.WinForms.GunaLabel();
            this.checkoutButton = new Guna.UI.WinForms.GunaButton();
            this.orderItemsTable = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.totalPriceLabel = new Guna.UI.WinForms.GunaLabel();
            this.orderLabel = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLablel
            // 
            this.titleLablel.AutoSize = true;
            this.titleLablel.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLablel.Location = new System.Drawing.Point(-2, 20);
            this.titleLablel.Name = "titleLablel";
            this.titleLablel.Size = new System.Drawing.Size(305, 70);
            this.titleLablel.TabIndex = 5;
            this.titleLablel.Text = "Thanh toán";
            // 
            // descTextBox
            // 
            this.descTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descTextBox.BackColor = System.Drawing.Color.Transparent;
            this.descTextBox.BaseColor = System.Drawing.Color.White;
            this.descTextBox.BorderColor = System.Drawing.Color.Silver;
            this.descTextBox.BorderSize = 1;
            this.descTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.descTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.descTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.descTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.descTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.descTextBox.Location = new System.Drawing.Point(12, 600);
            this.descTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descTextBox.Multiline = true;
            this.descTextBox.Name = "descTextBox";
            this.descTextBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.descTextBox.PasswordChar = '\0';
            this.descTextBox.Radius = 4;
            this.descTextBox.SelectedText = "";
            this.descTextBox.Size = new System.Drawing.Size(823, 101);
            this.descTextBox.TabIndex = 104;
            // 
            // gunaLabel18
            // 
            this.gunaLabel18.AutoSize = true;
            this.gunaLabel18.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel18.Location = new System.Drawing.Point(8, 564);
            this.gunaLabel18.Name = "gunaLabel18";
            this.gunaLabel18.Size = new System.Drawing.Size(82, 28);
            this.gunaLabel18.TabIndex = 105;
            this.gunaLabel18.Text = "Ghi chú";
            // 
            // checkoutButton
            // 
            this.checkoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkoutButton.Animated = true;
            this.checkoutButton.AnimationHoverSpeed = 0.07F;
            this.checkoutButton.AnimationSpeed = 0.03F;
            this.checkoutButton.BackColor = System.Drawing.Color.Transparent;
            this.checkoutButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.checkoutButton.BorderColor = System.Drawing.Color.Black;
            this.checkoutButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.checkoutButton.FocusedColor = System.Drawing.Color.Empty;
            this.checkoutButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutButton.ForeColor = System.Drawing.Color.White;
            this.checkoutButton.Image = null;
            this.checkoutButton.ImageSize = new System.Drawing.Size(20, 20);
            this.checkoutButton.Location = new System.Drawing.Point(606, 806);
            this.checkoutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.checkoutButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.checkoutButton.OnHoverForeColor = System.Drawing.Color.White;
            this.checkoutButton.OnHoverImage = null;
            this.checkoutButton.OnPressedColor = System.Drawing.Color.Black;
            this.checkoutButton.Radius = 4;
            this.checkoutButton.Size = new System.Drawing.Size(229, 62);
            this.checkoutButton.TabIndex = 106;
            this.checkoutButton.Text = "Thanh toán";
            this.checkoutButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.checkoutButton.Click += new System.EventHandler(this.checkoutButton_Click);
            // 
            // orderItemsTable
            // 
            this.orderItemsTable.AllowDrop = true;
            this.orderItemsTable.AllowUserToAddRows = false;
            this.orderItemsTable.AllowUserToDeleteRows = false;
            this.orderItemsTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.orderItemsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.orderItemsTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderItemsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderItemsTable.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.orderItemsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderItemsTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.orderItemsTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderItemsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.orderItemsTable.ColumnHeadersHeight = 50;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.orderItemsTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.orderItemsTable.EnableHeadersVisualStyles = false;
            this.orderItemsTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.orderItemsTable.Location = new System.Drawing.Point(19, 209);
            this.orderItemsTable.Name = "orderItemsTable";
            this.orderItemsTable.ReadOnly = true;
            this.orderItemsTable.RowHeadersVisible = false;
            this.orderItemsTable.RowHeadersWidth = 62;
            this.orderItemsTable.RowTemplate.Height = 28;
            this.orderItemsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderItemsTable.Size = new System.Drawing.Size(816, 279);
            this.orderItemsTable.TabIndex = 107;
            this.orderItemsTable.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.orderItemsTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.orderItemsTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.orderItemsTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.orderItemsTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.orderItemsTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.orderItemsTable.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.orderItemsTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.orderItemsTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.orderItemsTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.orderItemsTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.orderItemsTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.orderItemsTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.orderItemsTable.ThemeStyle.HeaderStyle.Height = 50;
            this.orderItemsTable.ThemeStyle.ReadOnly = true;
            this.orderItemsTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.orderItemsTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.orderItemsTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.orderItemsTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.orderItemsTable.ThemeStyle.RowsStyle.Height = 28;
            this.orderItemsTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.orderItemsTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(14, 178);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(98, 28);
            this.gunaLabel2.TabIndex = 108;
            this.gunaLabel2.Text = "Thực đơn";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(396, 510);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(202, 48);
            this.gunaLabel3.TabIndex = 109;
            this.gunaLabel3.Text = "Tổng tiền: ";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalPriceLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.totalPriceLabel.Location = new System.Drawing.Point(593, 510);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(241, 48);
            this.totalPriceLabel.TabIndex = 110;
            this.totalPriceLabel.Text = "0đ";
            this.totalPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // orderLabel
            // 
            this.orderLabel.AutoSize = true;
            this.orderLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderLabel.Location = new System.Drawing.Point(8, 90);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(165, 45);
            this.orderLabel.TabIndex = 111;
            this.orderLabel.Text = "Đơn hàng";
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(852, 879);
            this.Controls.Add(this.orderLabel);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.orderItemsTable);
            this.Controls.Add(this.checkoutButton);
            this.Controls.Add(this.descTextBox);
            this.Controls.Add(this.gunaLabel18);
            this.Controls.Add(this.titleLablel);
            this.Name = "Checkout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Checkout";
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel titleLablel;
        private Guna.UI.WinForms.GunaTextBox descTextBox;
        private Guna.UI.WinForms.GunaLabel gunaLabel18;
        private Guna.UI.WinForms.GunaButton checkoutButton;
        private Guna.UI.WinForms.GunaDataGridView orderItemsTable;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel totalPriceLabel;
        private Guna.UI.WinForms.GunaLabel orderLabel;
    }
}