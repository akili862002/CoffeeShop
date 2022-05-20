
namespace CoffeeShop
{
    partial class TablesForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TablesForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.tableListView = new System.Windows.Forms.ListView();
            this.currTableLabel = new Guna.UI.WinForms.GunaLabel();
            this.orderItemsTable = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.totalPriceLabel = new Guna.UI.WinForms.GunaLabel();
            this.checkoutButton = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.addOrderItemButton = new Guna.UI.WinForms.GunaButton();
            this.editOrderItemButton = new Guna.UI.WinForms.GunaButton();
            this.deleteOrderItemButton = new Guna.UI.WinForms.GunaButton();
            this.actionTablePanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsTable)).BeginInit();
            this.actionTablePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(8, 6);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(432, 47);
            this.gunaLabel1.TabIndex = 21;
            this.gunaLabel1.Text = "Sơ đồ bàn và Thanh toán";
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.White;
            this.imageList.Images.SetKeyName(0, "table-empty.png");
            this.imageList.Images.SetKeyName(1, "table-empty.png");
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(13, 77);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(62, 21);
            this.gunaLabel2.TabIndex = 37;
            this.gunaLabel2.Text = "Bàn ăn";
            // 
            // tableListView
            // 
            this.tableListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableListView.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableListView.HideSelection = false;
            this.tableListView.LargeImageList = this.imageList;
            this.tableListView.Location = new System.Drawing.Point(16, 103);
            this.tableListView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableListView.Name = "tableListView";
            this.tableListView.Size = new System.Drawing.Size(453, 478);
            this.tableListView.TabIndex = 38;
            this.tableListView.UseCompatibleStateImageBehavior = false;
            this.tableListView.SelectedIndexChanged += new System.EventHandler(this.tableListView_SelectedIndexChanged);
            // 
            // currTableLabel
            // 
            this.currTableLabel.AutoSize = true;
            this.currTableLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currTableLabel.Location = new System.Drawing.Point(488, 55);
            this.currTableLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currTableLabel.Name = "currTableLabel";
            this.currTableLabel.Size = new System.Drawing.Size(253, 32);
            this.currTableLabel.TabIndex = 40;
            this.currTableLabel.Text = "Chọn bàn để tiếp tục";
            // 
            // orderItemsTable
            // 
            this.orderItemsTable.AllowDrop = true;
            this.orderItemsTable.AllowUserToAddRows = false;
            this.orderItemsTable.AllowUserToDeleteRows = false;
            this.orderItemsTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.orderItemsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.orderItemsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
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
            this.orderItemsTable.Location = new System.Drawing.Point(2, 58);
            this.orderItemsTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.orderItemsTable.Name = "orderItemsTable";
            this.orderItemsTable.ReadOnly = true;
            this.orderItemsTable.RowHeadersVisible = false;
            this.orderItemsTable.RowHeadersWidth = 62;
            this.orderItemsTable.RowTemplate.Height = 28;
            this.orderItemsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderItemsTable.Size = new System.Drawing.Size(771, 377);
            this.orderItemsTable.TabIndex = 41;
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
            // gunaLabel3
            // 
            this.gunaLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(382, 446);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(139, 32);
            this.gunaLabel3.TabIndex = 42;
            this.gunaLabel3.Text = "Tổng tiền: ";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.totalPriceLabel.Location = new System.Drawing.Point(521, 446);
            this.totalPriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(44, 32);
            this.totalPriceLabel.TabIndex = 43;
            this.totalPriceLabel.Text = "0đ";
            this.totalPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.checkoutButton.Location = new System.Drawing.Point(661, 445);
            this.checkoutButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.checkoutButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.checkoutButton.OnHoverForeColor = System.Drawing.Color.White;
            this.checkoutButton.OnHoverImage = null;
            this.checkoutButton.OnPressedColor = System.Drawing.Color.Black;
            this.checkoutButton.Radius = 4;
            this.checkoutButton.Size = new System.Drawing.Size(111, 32);
            this.checkoutButton.TabIndex = 44;
            this.checkoutButton.Text = "Thanh toán";
            this.checkoutButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(2, 30);
            this.gunaLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(162, 21);
            this.gunaLabel6.TabIndex = 45;
            this.gunaLabel6.Text = "Danh sách thực đơn";
            // 
            // addOrderItemButton
            // 
            this.addOrderItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addOrderItemButton.Animated = true;
            this.addOrderItemButton.AnimationHoverSpeed = 0.07F;
            this.addOrderItemButton.AnimationSpeed = 0.03F;
            this.addOrderItemButton.BackColor = System.Drawing.Color.Transparent;
            this.addOrderItemButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.addOrderItemButton.BorderColor = System.Drawing.Color.Black;
            this.addOrderItemButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addOrderItemButton.FocusedColor = System.Drawing.Color.Empty;
            this.addOrderItemButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addOrderItemButton.ForeColor = System.Drawing.Color.White;
            this.addOrderItemButton.Image = null;
            this.addOrderItemButton.ImageSize = new System.Drawing.Size(20, 20);
            this.addOrderItemButton.Location = new System.Drawing.Point(505, 18);
            this.addOrderItemButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addOrderItemButton.Name = "addOrderItemButton";
            this.addOrderItemButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.addOrderItemButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.addOrderItemButton.OnHoverForeColor = System.Drawing.Color.White;
            this.addOrderItemButton.OnHoverImage = null;
            this.addOrderItemButton.OnPressedColor = System.Drawing.Color.Black;
            this.addOrderItemButton.Radius = 4;
            this.addOrderItemButton.Size = new System.Drawing.Size(87, 32);
            this.addOrderItemButton.TabIndex = 53;
            this.addOrderItemButton.Text = "Thêm";
            this.addOrderItemButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.addOrderItemButton.Click += new System.EventHandler(this.addOrderItemButton_Click);
            // 
            // editOrderItemButton
            // 
            this.editOrderItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editOrderItemButton.Animated = true;
            this.editOrderItemButton.AnimationHoverSpeed = 0.07F;
            this.editOrderItemButton.AnimationSpeed = 0.03F;
            this.editOrderItemButton.BackColor = System.Drawing.Color.Transparent;
            this.editOrderItemButton.BaseColor = System.Drawing.Color.White;
            this.editOrderItemButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.editOrderItemButton.BorderSize = 1;
            this.editOrderItemButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.editOrderItemButton.FocusedColor = System.Drawing.Color.Empty;
            this.editOrderItemButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editOrderItemButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.editOrderItemButton.Image = null;
            this.editOrderItemButton.ImageSize = new System.Drawing.Size(20, 20);
            this.editOrderItemButton.Location = new System.Drawing.Point(595, 18);
            this.editOrderItemButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.editOrderItemButton.Name = "editOrderItemButton";
            this.editOrderItemButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(252)))));
            this.editOrderItemButton.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.editOrderItemButton.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.editOrderItemButton.OnHoverImage = null;
            this.editOrderItemButton.OnPressedColor = System.Drawing.Color.Black;
            this.editOrderItemButton.Radius = 4;
            this.editOrderItemButton.Size = new System.Drawing.Size(87, 32);
            this.editOrderItemButton.TabIndex = 54;
            this.editOrderItemButton.Text = "Sửa";
            this.editOrderItemButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.editOrderItemButton.Click += new System.EventHandler(this.editOrderItemButton_Click);
            // 
            // deleteOrderItemButton
            // 
            this.deleteOrderItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteOrderItemButton.Animated = true;
            this.deleteOrderItemButton.AnimationHoverSpeed = 0.07F;
            this.deleteOrderItemButton.AnimationSpeed = 0.03F;
            this.deleteOrderItemButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteOrderItemButton.BaseColor = System.Drawing.Color.Red;
            this.deleteOrderItemButton.BorderColor = System.Drawing.Color.Black;
            this.deleteOrderItemButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.deleteOrderItemButton.FocusedColor = System.Drawing.Color.Empty;
            this.deleteOrderItemButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteOrderItemButton.ForeColor = System.Drawing.Color.White;
            this.deleteOrderItemButton.Image = null;
            this.deleteOrderItemButton.ImageSize = new System.Drawing.Size(20, 20);
            this.deleteOrderItemButton.Location = new System.Drawing.Point(686, 18);
            this.deleteOrderItemButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteOrderItemButton.Name = "deleteOrderItemButton";
            this.deleteOrderItemButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteOrderItemButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.deleteOrderItemButton.OnHoverForeColor = System.Drawing.Color.White;
            this.deleteOrderItemButton.OnHoverImage = null;
            this.deleteOrderItemButton.OnPressedColor = System.Drawing.Color.Black;
            this.deleteOrderItemButton.Radius = 4;
            this.deleteOrderItemButton.Size = new System.Drawing.Size(87, 32);
            this.deleteOrderItemButton.TabIndex = 55;
            this.deleteOrderItemButton.Text = "Xóa";
            this.deleteOrderItemButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deleteOrderItemButton.Click += new System.EventHandler(this.deleteOrderItemButton_Click);
            // 
            // actionTablePanel
            // 
            this.actionTablePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.actionTablePanel.Controls.Add(this.orderItemsTable);
            this.actionTablePanel.Controls.Add(this.deleteOrderItemButton);
            this.actionTablePanel.Controls.Add(this.gunaLabel3);
            this.actionTablePanel.Controls.Add(this.editOrderItemButton);
            this.actionTablePanel.Controls.Add(this.totalPriceLabel);
            this.actionTablePanel.Controls.Add(this.addOrderItemButton);
            this.actionTablePanel.Controls.Add(this.checkoutButton);
            this.actionTablePanel.Controls.Add(this.gunaLabel6);
            this.actionTablePanel.Location = new System.Drawing.Point(493, 103);
            this.actionTablePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.actionTablePanel.Name = "actionTablePanel";
            this.actionTablePanel.Size = new System.Drawing.Size(783, 497);
            this.actionTablePanel.TabIndex = 56;
            // 
            // TablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1275, 595);
            this.Controls.Add(this.actionTablePanel);
            this.Controls.Add(this.currTableLabel);
            this.Controls.Add(this.tableListView);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TablesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tables Form";
            this.Load += new System.EventHandler(this.TablesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsTable)).EndInit();
            this.actionTablePanel.ResumeLayout(false);
            this.actionTablePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ListView tableListView;
        private Guna.UI.WinForms.GunaLabel currTableLabel;
        private Guna.UI.WinForms.GunaDataGridView orderItemsTable;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel totalPriceLabel;
        private Guna.UI.WinForms.GunaButton checkoutButton;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaButton addOrderItemButton;
        private Guna.UI.WinForms.GunaButton editOrderItemButton;
        private Guna.UI.WinForms.GunaButton deleteOrderItemButton;
        private System.Windows.Forms.Panel actionTablePanel;
    }
}