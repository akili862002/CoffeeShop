
namespace CoffeeShop
{
    partial class StaffsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchButton = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.staffsTable = new Guna.UI.WinForms.GunaDataGridView();
            this.searchTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.deleteButton = new Guna.UI.WinForms.GunaButton();
            this.editButton = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.salaryTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.famaleRadio = new Guna.UI.WinForms.GunaRadioButton();
            this.maleRadio = new Guna.UI.WinForms.GunaRadioButton();
            this.birthdatePicker = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.addressTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.fullnameTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel10 = new Guna.UI.WinForms.GunaLabel();
            this.phoneTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.avatarPicture = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.uploadButton = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.avatar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.staffsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Animated = true;
            this.searchButton.AnimationHoverSpeed = 0.07F;
            this.searchButton.AnimationSpeed = 0.03F;
            this.searchButton.BackColor = System.Drawing.Color.Transparent;
            this.searchButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.searchButton.BorderColor = System.Drawing.Color.Black;
            this.searchButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.searchButton.FocusedColor = System.Drawing.Color.Empty;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Image = null;
            this.searchButton.ImageSize = new System.Drawing.Size(20, 20);
            this.searchButton.Location = new System.Drawing.Point(1689, 158);
            this.searchButton.Name = "searchButton";
            this.searchButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.searchButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.searchButton.OnHoverForeColor = System.Drawing.Color.White;
            this.searchButton.OnHoverImage = null;
            this.searchButton.OnPressedColor = System.Drawing.Color.Black;
            this.searchButton.Radius = 4;
            this.searchButton.Size = new System.Drawing.Size(100, 48);
            this.searchButton.TabIndex = 111;
            this.searchButton.Text = "Search";
            this.searchButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(506, 174);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(230, 32);
            this.gunaLabel6.TabIndex = 101;
            this.gunaLabel6.Text = "Danh sách nhân sự";
            // 
            // staffsTable
            // 
            this.staffsTable.AllowDrop = true;
            this.staffsTable.AllowUserToAddRows = false;
            this.staffsTable.AllowUserToDeleteRows = false;
            this.staffsTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.staffsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.staffsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.staffsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.staffsTable.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.staffsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.staffsTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.staffsTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.staffsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.staffsTable.ColumnHeadersHeight = 50;
            this.staffsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.avatar});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.staffsTable.DefaultCellStyle = dataGridViewCellStyle6;
            this.staffsTable.EnableHeadersVisualStyles = false;
            this.staffsTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.staffsTable.Location = new System.Drawing.Point(525, 215);
            this.staffsTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.staffsTable.Name = "staffsTable";
            this.staffsTable.ReadOnly = true;
            this.staffsTable.RowHeadersVisible = false;
            this.staffsTable.RowHeadersWidth = 62;
            this.staffsTable.RowTemplate.Height = 28;
            this.staffsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.staffsTable.Size = new System.Drawing.Size(1264, 829);
            this.staffsTable.TabIndex = 100;
            this.staffsTable.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.staffsTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.staffsTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.staffsTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.staffsTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.staffsTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.staffsTable.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.staffsTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.staffsTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.staffsTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.staffsTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffsTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.staffsTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.staffsTable.ThemeStyle.HeaderStyle.Height = 50;
            this.staffsTable.ThemeStyle.ReadOnly = true;
            this.staffsTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.staffsTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.staffsTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffsTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.staffsTable.ThemeStyle.RowsStyle.Height = 28;
            this.staffsTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.staffsTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.staffsTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.staffsTable_CellDoubleClick);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.BackColor = System.Drawing.Color.Transparent;
            this.searchTextBox.BaseColor = System.Drawing.Color.White;
            this.searchTextBox.BorderColor = System.Drawing.Color.Silver;
            this.searchTextBox.BorderSize = 1;
            this.searchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.searchTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.searchTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchTextBox.Location = new System.Drawing.Point(1413, 158);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.searchTextBox.PasswordChar = '\0';
            this.searchTextBox.Radius = 4;
            this.searchTextBox.SelectedText = "";
            this.searchTextBox.Size = new System.Drawing.Size(268, 48);
            this.searchTextBox.TabIndex = 108;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(12, 22);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(423, 70);
            this.gunaLabel1.TabIndex = 99;
            this.gunaLabel1.Text = "Quản lý nhân sự";
            // 
            // deleteButton
            // 
            this.deleteButton.Animated = true;
            this.deleteButton.AnimationHoverSpeed = 0.07F;
            this.deleteButton.AnimationSpeed = 0.03F;
            this.deleteButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteButton.BaseColor = System.Drawing.Color.Red;
            this.deleteButton.BorderColor = System.Drawing.Color.Black;
            this.deleteButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.deleteButton.FocusedColor = System.Drawing.Color.Empty;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Image = null;
            this.deleteButton.ImageSize = new System.Drawing.Size(20, 20);
            this.deleteButton.Location = new System.Drawing.Point(202, 975);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.deleteButton.OnHoverForeColor = System.Drawing.Color.White;
            this.deleteButton.OnHoverImage = null;
            this.deleteButton.OnPressedColor = System.Drawing.Color.Black;
            this.deleteButton.Radius = 4;
            this.deleteButton.Size = new System.Drawing.Size(138, 52);
            this.deleteButton.TabIndex = 98;
            this.deleteButton.Text = "Xóa";
            this.deleteButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Animated = true;
            this.editButton.AnimationHoverSpeed = 0.07F;
            this.editButton.AnimationSpeed = 0.03F;
            this.editButton.BackColor = System.Drawing.Color.Transparent;
            this.editButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.editButton.BorderColor = System.Drawing.Color.Black;
            this.editButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.editButton.FocusedColor = System.Drawing.Color.Empty;
            this.editButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.Image = null;
            this.editButton.ImageSize = new System.Drawing.Size(20, 20);
            this.editButton.Location = new System.Drawing.Point(350, 975);
            this.editButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editButton.Name = "editButton";
            this.editButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.editButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.editButton.OnHoverForeColor = System.Drawing.Color.White;
            this.editButton.OnHoverImage = null;
            this.editButton.OnPressedColor = System.Drawing.Color.Black;
            this.editButton.Radius = 4;
            this.editButton.Size = new System.Drawing.Size(134, 52);
            this.editButton.TabIndex = 97;
            this.editButton.Text = "Sửa";
            this.editButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(20, 157);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(192, 32);
            this.gunaLabel3.TabIndex = 103;
            this.gunaLabel3.Text = "Cài đặt nhân sự";
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel9.Location = new System.Drawing.Point(27, 860);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(70, 28);
            this.gunaLabel9.TabIndex = 126;
            this.gunaLabel9.Text = "Lương";
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.BackColor = System.Drawing.Color.Transparent;
            this.salaryTextBox.BaseColor = System.Drawing.Color.White;
            this.salaryTextBox.BorderColor = System.Drawing.Color.Silver;
            this.salaryTextBox.BorderSize = 1;
            this.salaryTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.salaryTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.salaryTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.salaryTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.salaryTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.salaryTextBox.Location = new System.Drawing.Point(24, 894);
            this.salaryTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.salaryTextBox.PasswordChar = '\0';
            this.salaryTextBox.Radius = 4;
            this.salaryTextBox.SelectedText = "";
            this.salaryTextBox.Size = new System.Drawing.Size(459, 52);
            this.salaryTextBox.TabIndex = 125;
            // 
            // famaleRadio
            // 
            this.famaleRadio.BaseColor = System.Drawing.SystemColors.Control;
            this.famaleRadio.CheckedOffColor = System.Drawing.Color.Gray;
            this.famaleRadio.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.famaleRadio.FillColor = System.Drawing.Color.White;
            this.famaleRadio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.famaleRadio.Location = new System.Drawing.Point(183, 711);
            this.famaleRadio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.famaleRadio.Name = "famaleRadio";
            this.famaleRadio.Size = new System.Drawing.Size(60, 31);
            this.famaleRadio.TabIndex = 117;
            this.famaleRadio.Text = "Nữ";
            // 
            // maleRadio
            // 
            this.maleRadio.BaseColor = System.Drawing.SystemColors.Control;
            this.maleRadio.Checked = true;
            this.maleRadio.CheckedOffColor = System.Drawing.Color.Gray;
            this.maleRadio.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.maleRadio.FillColor = System.Drawing.Color.White;
            this.maleRadio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleRadio.Location = new System.Drawing.Point(36, 711);
            this.maleRadio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maleRadio.Name = "maleRadio";
            this.maleRadio.Size = new System.Drawing.Size(76, 31);
            this.maleRadio.TabIndex = 116;
            this.maleRadio.Text = "Nam";
            // 
            // birthdatePicker
            // 
            this.birthdatePicker.BackColor = System.Drawing.Color.Transparent;
            this.birthdatePicker.BaseColor = System.Drawing.Color.White;
            this.birthdatePicker.BorderColor = System.Drawing.Color.Silver;
            this.birthdatePicker.BorderSize = 1;
            this.birthdatePicker.CustomFormat = null;
            this.birthdatePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.birthdatePicker.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.birthdatePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.birthdatePicker.ForeColor = System.Drawing.Color.Black;
            this.birthdatePicker.Location = new System.Drawing.Point(24, 622);
            this.birthdatePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.birthdatePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.birthdatePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.birthdatePicker.Name = "birthdatePicker";
            this.birthdatePicker.OnHoverBaseColor = System.Drawing.Color.White;
            this.birthdatePicker.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.birthdatePicker.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.birthdatePicker.OnPressedColor = System.Drawing.Color.Black;
            this.birthdatePicker.Radius = 4;
            this.birthdatePicker.Size = new System.Drawing.Size(459, 49);
            this.birthdatePicker.TabIndex = 115;
            this.birthdatePicker.Text = "Tuesday, May 17, 2022";
            this.birthdatePicker.Value = new System.DateTime(2022, 5, 17, 14, 30, 22, 650);
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.Location = new System.Drawing.Point(22, 766);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(73, 28);
            this.gunaLabel8.TabIndex = 124;
            this.gunaLabel8.Text = "Địa chỉ";
            // 
            // addressTextBox
            // 
            this.addressTextBox.BackColor = System.Drawing.Color.Transparent;
            this.addressTextBox.BaseColor = System.Drawing.Color.White;
            this.addressTextBox.BorderColor = System.Drawing.Color.Silver;
            this.addressTextBox.BorderSize = 1;
            this.addressTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addressTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.addressTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.addressTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.addressTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addressTextBox.Location = new System.Drawing.Point(24, 800);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.addressTextBox.PasswordChar = '\0';
            this.addressTextBox.Radius = 4;
            this.addressTextBox.SelectedText = "";
            this.addressTextBox.Size = new System.Drawing.Size(459, 52);
            this.addressTextBox.TabIndex = 118;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.Location = new System.Drawing.Point(22, 675);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(90, 28);
            this.gunaLabel7.TabIndex = 123;
            this.gunaLabel7.Text = "Giới tính";
            this.gunaLabel7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(22, 588);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(103, 28);
            this.gunaLabel2.TabIndex = 122;
            this.gunaLabel2.Text = "Ngày sinh";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(20, 492);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(103, 28);
            this.gunaLabel5.TabIndex = 121;
            this.gunaLabel5.Text = "Họ và Tên";
            this.gunaLabel5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // fullnameTextBox
            // 
            this.fullnameTextBox.BackColor = System.Drawing.Color.Transparent;
            this.fullnameTextBox.BaseColor = System.Drawing.Color.White;
            this.fullnameTextBox.BorderColor = System.Drawing.Color.Silver;
            this.fullnameTextBox.BorderSize = 1;
            this.fullnameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fullnameTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.fullnameTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.fullnameTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.fullnameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fullnameTextBox.Location = new System.Drawing.Point(24, 526);
            this.fullnameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fullnameTextBox.Name = "fullnameTextBox";
            this.fullnameTextBox.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.fullnameTextBox.PasswordChar = '\0';
            this.fullnameTextBox.Radius = 4;
            this.fullnameTextBox.SelectedText = "";
            this.fullnameTextBox.Size = new System.Drawing.Size(459, 52);
            this.fullnameTextBox.TabIndex = 114;
            // 
            // gunaLabel10
            // 
            this.gunaLabel10.AutoSize = true;
            this.gunaLabel10.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel10.Location = new System.Drawing.Point(20, 403);
            this.gunaLabel10.Name = "gunaLabel10";
            this.gunaLabel10.Size = new System.Drawing.Size(133, 28);
            this.gunaLabel10.TabIndex = 119;
            this.gunaLabel10.Text = "Số điện thoại";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.BackColor = System.Drawing.Color.Transparent;
            this.phoneTextBox.BaseColor = System.Drawing.Color.White;
            this.phoneTextBox.BorderColor = System.Drawing.Color.Silver;
            this.phoneTextBox.BorderSize = 1;
            this.phoneTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.phoneTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.phoneTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.phoneTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.phoneTextBox.Location = new System.Drawing.Point(24, 437);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.phoneTextBox.PasswordChar = '\0';
            this.phoneTextBox.Radius = 4;
            this.phoneTextBox.SelectedText = "";
            this.phoneTextBox.Size = new System.Drawing.Size(459, 52);
            this.phoneTextBox.TabIndex = 112;
            // 
            // avatarPicture
            // 
            this.avatarPicture.BaseColor = System.Drawing.Color.White;
            this.avatarPicture.ErrorImage = global::CoffeeShop.Properties.Resources.cleaning_staff;
            this.avatarPicture.Image = global::CoffeeShop.Properties.Resources.cleaning_staff;
            this.avatarPicture.InitialImage = global::CoffeeShop.Properties.Resources.cleaning_staff;
            this.avatarPicture.Location = new System.Drawing.Point(24, 238);
            this.avatarPicture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.avatarPicture.Name = "avatarPicture";
            this.avatarPicture.Size = new System.Drawing.Size(150, 149);
            this.avatarPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarPicture.TabIndex = 127;
            this.avatarPicture.TabStop = false;
            this.avatarPicture.UseTransfarantBackground = false;
            // 
            // uploadButton
            // 
            this.uploadButton.Animated = true;
            this.uploadButton.AnimationHoverSpeed = 0.07F;
            this.uploadButton.AnimationSpeed = 0.03F;
            this.uploadButton.BackColor = System.Drawing.Color.Transparent;
            this.uploadButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.uploadButton.BorderColor = System.Drawing.Color.Black;
            this.uploadButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.uploadButton.FocusedColor = System.Drawing.Color.Empty;
            this.uploadButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadButton.ForeColor = System.Drawing.Color.White;
            this.uploadButton.Image = null;
            this.uploadButton.ImageSize = new System.Drawing.Size(20, 20);
            this.uploadButton.Location = new System.Drawing.Point(212, 288);
            this.uploadButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.uploadButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.uploadButton.OnHoverForeColor = System.Drawing.Color.White;
            this.uploadButton.OnHoverImage = null;
            this.uploadButton.OnPressedColor = System.Drawing.Color.Black;
            this.uploadButton.Radius = 4;
            this.uploadButton.Size = new System.Drawing.Size(184, 52);
            this.uploadButton.TabIndex = 128;
            this.uploadButton.Text = "Tải ảnh lên";
            this.uploadButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(20, 205);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(128, 28);
            this.gunaLabel4.TabIndex = 129;
            this.gunaLabel4.Text = "Ảnh đại diện";
            // 
            // avatar
            // 
            this.avatar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.avatar.DataPropertyName = "avatar";
            this.avatar.HeaderText = "avatar";
            this.avatar.MinimumWidth = 8;
            this.avatar.Name = "avatar";
            this.avatar.ReadOnly = true;
            this.avatar.Visible = false;
            this.avatar.Width = 150;
            // 
            // StaffsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1808, 1062);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.avatarPicture);
            this.Controls.Add(this.gunaLabel9);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.famaleRadio);
            this.Controls.Add(this.maleRadio);
            this.Controls.Add(this.birthdatePicker);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.fullnameTextBox);
            this.Controls.Add(this.gunaLabel10);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.staffsTable);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.gunaLabel3);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StaffsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StaffsForm";
            this.Load += new System.EventHandler(this.StaffsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.staffsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton searchButton;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaDataGridView staffsTable;
        private Guna.UI.WinForms.GunaTextBox searchTextBox;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton deleteButton;
        private Guna.UI.WinForms.GunaButton editButton;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaTextBox salaryTextBox;
        private Guna.UI.WinForms.GunaRadioButton famaleRadio;
        private Guna.UI.WinForms.GunaRadioButton maleRadio;
        private Guna.UI.WinForms.GunaDateTimePicker birthdatePicker;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaTextBox addressTextBox;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaTextBox fullnameTextBox;
        private Guna.UI.WinForms.GunaLabel gunaLabel10;
        private Guna.UI.WinForms.GunaTextBox phoneTextBox;
        private Guna.UI.WinForms.GunaCirclePictureBox avatarPicture;
        private Guna.UI.WinForms.GunaButton uploadButton;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn avatar;
    }
}