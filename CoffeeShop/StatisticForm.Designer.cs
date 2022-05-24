
namespace CoffeeShop
{
    partial class StatisticForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.productChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.staffChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.tab3 = new System.Windows.Forms.TabPage();
            this.gunaLabel11 = new Guna.UI.WinForms.GunaLabel();
            this.orderTable = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaLabel10 = new Guna.UI.WinForms.GunaLabel();
            this.searchButton = new Guna.UI.WinForms.GunaButton();
            this.orderFilterCheckbox = new Guna.UI.WinForms.GunaCheckBox();
            this.orderToDatePicker = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.filterOrderButton = new Guna.UI.WinForms.GunaButton();
            this.orderFromDatePicker = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.orderFilterPanel = new Guna.UI.WinForms.GunaPanel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productChart)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffChart)).BeginInit();
            this.tab3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderTable)).BeginInit();
            this.orderFilterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(11, 23);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(256, 70);
            this.gunaLabel1.TabIndex = 17;
            this.gunaLabel1.Text = "Thống kê";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tab3);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(200, 50);
            this.tabControl1.Location = new System.Drawing.Point(12, 111);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1716, 924);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 67;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gunaLabel2);
            this.tabPage1.Controls.Add(this.productChart);
            this.tabPage1.Location = new System.Drawing.Point(4, 54);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1708, 866);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Theo sản phẩm";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(24, 24);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(437, 48);
            this.gunaLabel2.TabIndex = 68;
            this.gunaLabel2.Text = "Thống kê theo sản phẩm";
            // 
            // productChart
            // 
            chartArea1.BorderColor = System.Drawing.Color.Silver;
            chartArea1.Name = "ChartArea1";
            this.productChart.ChartAreas.Add(chartArea1);
            legend1.ForeColor = System.Drawing.Color.WhiteSmoke;
            legend1.Name = "Legend1";
            this.productChart.Legends.Add(legend1);
            this.productChart.Location = new System.Drawing.Point(7, 65);
            this.productChart.Name = "productChart";
            this.productChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Benefit";
            series1.ShadowColor = System.Drawing.Color.Gray;
            this.productChart.Series.Add(series1);
            this.productChart.Size = new System.Drawing.Size(1677, 785);
            this.productChart.TabIndex = 0;
            this.productChart.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Top 10 sản phẩm lợi nhuận cao nhất";
            this.productChart.Titles.Add(title1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gunaLabel7);
            this.tabPage2.Controls.Add(this.staffChart);
            this.tabPage2.Controls.Add(this.gunaButton1);
            this.tabPage2.Location = new System.Drawing.Point(4, 54);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1708, 866);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nhân viên";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.Location = new System.Drawing.Point(24, 24);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(440, 48);
            this.gunaLabel7.TabIndex = 90;
            this.gunaLabel7.Text = "Thống kê theo nhân viên";
            // 
            // staffChart
            // 
            chartArea2.Name = "ChartArea1";
            this.staffChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.staffChart.Legends.Add(legend2);
            this.staffChart.Location = new System.Drawing.Point(7, 67);
            this.staffChart.Name = "staffChart";
            this.staffChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Order";
            this.staffChart.Series.Add(series2);
            this.staffChart.Size = new System.Drawing.Size(1677, 785);
            this.staffChart.TabIndex = 89;
            this.staffChart.Text = "chart2";
            title2.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "Top 10 nhân viên bán nhiều đơn hàng nhất";
            this.staffChart.Titles.Add(title2);
            // 
            // gunaButton1
            // 
            this.gunaButton1.Animated = true;
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(1717, 172);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 4;
            this.gunaButton1.Size = new System.Drawing.Size(99, 48);
            this.gunaButton1.TabIndex = 88;
            this.gunaButton1.Text = "Search";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tab3
            // 
            this.tab3.Controls.Add(this.orderFilterPanel);
            this.tab3.Controls.Add(this.orderFilterCheckbox);
            this.tab3.Controls.Add(this.gunaLabel11);
            this.tab3.Controls.Add(this.orderTable);
            this.tab3.Controls.Add(this.gunaLabel10);
            this.tab3.Controls.Add(this.searchButton);
            this.tab3.Location = new System.Drawing.Point(4, 54);
            this.tab3.Name = "tab3";
            this.tab3.Size = new System.Drawing.Size(1708, 866);
            this.tab3.TabIndex = 2;
            this.tab3.Text = "Đơn hàng";
            this.tab3.UseVisualStyleBackColor = true;
            // 
            // gunaLabel11
            // 
            this.gunaLabel11.AutoSize = true;
            this.gunaLabel11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel11.Location = new System.Drawing.Point(26, 239);
            this.gunaLabel11.Name = "gunaLabel11";
            this.gunaLabel11.Size = new System.Drawing.Size(171, 32);
            this.gunaLabel11.TabIndex = 108;
            this.gunaLabel11.Text = "Các đơn hàng";
            // 
            // orderTable
            // 
            this.orderTable.AllowUserToAddRows = false;
            this.orderTable.AllowUserToDeleteRows = false;
            this.orderTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.orderTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.orderTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderTable.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.orderTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.orderTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.orderTable.ColumnHeadersHeight = 60;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.orderTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.orderTable.EnableHeadersVisualStyles = false;
            this.orderTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.orderTable.Location = new System.Drawing.Point(31, 281);
            this.orderTable.Name = "orderTable";
            this.orderTable.ReadOnly = true;
            this.orderTable.RowHeadersVisible = false;
            this.orderTable.RowHeadersWidth = 62;
            this.orderTable.RowTemplate.Height = 28;
            this.orderTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderTable.Size = new System.Drawing.Size(1669, 570);
            this.orderTable.TabIndex = 107;
            this.orderTable.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.orderTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.orderTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.orderTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.orderTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.orderTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.orderTable.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.orderTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.orderTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.orderTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.orderTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.orderTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.orderTable.ThemeStyle.HeaderStyle.Height = 60;
            this.orderTable.ThemeStyle.ReadOnly = true;
            this.orderTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.orderTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.orderTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.orderTable.ThemeStyle.RowsStyle.Height = 28;
            this.orderTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.orderTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // gunaLabel10
            // 
            this.gunaLabel10.AutoSize = true;
            this.gunaLabel10.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel10.Location = new System.Drawing.Point(24, 24);
            this.gunaLabel10.Name = "gunaLabel10";
            this.gunaLabel10.Size = new System.Drawing.Size(437, 48);
            this.gunaLabel10.TabIndex = 100;
            this.gunaLabel10.Text = "Thống kê theo đơn hàng";
            // 
            // searchButton
            // 
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
            this.searchButton.Location = new System.Drawing.Point(1720, 177);
            this.searchButton.Name = "searchButton";
            this.searchButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.searchButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.searchButton.OnHoverForeColor = System.Drawing.Color.White;
            this.searchButton.OnHoverImage = null;
            this.searchButton.OnPressedColor = System.Drawing.Color.Black;
            this.searchButton.Radius = 4;
            this.searchButton.Size = new System.Drawing.Size(99, 48);
            this.searchButton.TabIndex = 99;
            this.searchButton.Text = "Search";
            this.searchButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // orderFilterCheckbox
            // 
            this.orderFilterCheckbox.BaseColor = System.Drawing.Color.White;
            this.orderFilterCheckbox.CheckedOffColor = System.Drawing.Color.Gray;
            this.orderFilterCheckbox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.orderFilterCheckbox.FillColor = System.Drawing.Color.White;
            this.orderFilterCheckbox.Location = new System.Drawing.Point(31, 85);
            this.orderFilterCheckbox.Name = "orderFilterCheckbox";
            this.orderFilterCheckbox.Size = new System.Drawing.Size(96, 22);
            this.orderFilterCheckbox.TabIndex = 109;
            this.orderFilterCheckbox.Text = "Dùng lọc";
            this.orderFilterCheckbox.CheckedChanged += new System.EventHandler(this.orderFilterCheckbox_CheckedChanged);
            // 
            // orderToDatePicker
            // 
            this.orderToDatePicker.BackColor = System.Drawing.Color.Transparent;
            this.orderToDatePicker.BaseColor = System.Drawing.Color.White;
            this.orderToDatePicker.BorderColor = System.Drawing.Color.Silver;
            this.orderToDatePicker.BorderSize = 1;
            this.orderToDatePicker.CustomFormat = null;
            this.orderToDatePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.orderToDatePicker.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.orderToDatePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.orderToDatePicker.ForeColor = System.Drawing.Color.Black;
            this.orderToDatePicker.Location = new System.Drawing.Point(353, 31);
            this.orderToDatePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.orderToDatePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.orderToDatePicker.Name = "orderToDatePicker";
            this.orderToDatePicker.OnHoverBaseColor = System.Drawing.Color.White;
            this.orderToDatePicker.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.orderToDatePicker.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.orderToDatePicker.OnPressedColor = System.Drawing.Color.Black;
            this.orderToDatePicker.Radius = 4;
            this.orderToDatePicker.Size = new System.Drawing.Size(321, 50);
            this.orderToDatePicker.TabIndex = 71;
            this.orderToDatePicker.Text = "Tuesday, May 17, 2022";
            this.orderToDatePicker.Value = new System.DateTime(2022, 5, 17, 14, 30, 22, 650);
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel9.Location = new System.Drawing.Point(349, 0);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(99, 28);
            this.gunaLabel9.TabIndex = 72;
            this.gunaLabel9.Text = "Đến ngày";
            // 
            // filterOrderButton
            // 
            this.filterOrderButton.Animated = true;
            this.filterOrderButton.AnimationHoverSpeed = 0.07F;
            this.filterOrderButton.AnimationSpeed = 0.03F;
            this.filterOrderButton.BackColor = System.Drawing.Color.Transparent;
            this.filterOrderButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.filterOrderButton.BorderColor = System.Drawing.Color.Black;
            this.filterOrderButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.filterOrderButton.FocusedColor = System.Drawing.Color.Empty;
            this.filterOrderButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterOrderButton.ForeColor = System.Drawing.Color.White;
            this.filterOrderButton.Image = null;
            this.filterOrderButton.ImageSize = new System.Drawing.Size(20, 20);
            this.filterOrderButton.Location = new System.Drawing.Point(699, 31);
            this.filterOrderButton.Name = "filterOrderButton";
            this.filterOrderButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.filterOrderButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.filterOrderButton.OnHoverForeColor = System.Drawing.Color.White;
            this.filterOrderButton.OnHoverImage = null;
            this.filterOrderButton.OnPressedColor = System.Drawing.Color.Black;
            this.filterOrderButton.Radius = 4;
            this.filterOrderButton.Size = new System.Drawing.Size(154, 50);
            this.filterOrderButton.TabIndex = 73;
            this.filterOrderButton.Text = "Lọc";
            this.filterOrderButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // orderFromDatePicker
            // 
            this.orderFromDatePicker.BackColor = System.Drawing.Color.Transparent;
            this.orderFromDatePicker.BaseColor = System.Drawing.Color.White;
            this.orderFromDatePicker.BorderColor = System.Drawing.Color.Silver;
            this.orderFromDatePicker.BorderSize = 1;
            this.orderFromDatePicker.CustomFormat = null;
            this.orderFromDatePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.orderFromDatePicker.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.orderFromDatePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.orderFromDatePicker.ForeColor = System.Drawing.Color.Black;
            this.orderFromDatePicker.Location = new System.Drawing.Point(7, 31);
            this.orderFromDatePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.orderFromDatePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.orderFromDatePicker.Name = "orderFromDatePicker";
            this.orderFromDatePicker.OnHoverBaseColor = System.Drawing.Color.White;
            this.orderFromDatePicker.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.orderFromDatePicker.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.orderFromDatePicker.OnPressedColor = System.Drawing.Color.Black;
            this.orderFromDatePicker.Radius = 4;
            this.orderFromDatePicker.Size = new System.Drawing.Size(321, 50);
            this.orderFromDatePicker.TabIndex = 69;
            this.orderFromDatePicker.Text = "Friday, December 17, 1999";
            this.orderFromDatePicker.Value = new System.DateTime(1999, 12, 17, 0, 0, 0, 0);
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.Location = new System.Drawing.Point(3, 0);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(85, 28);
            this.gunaLabel8.TabIndex = 70;
            this.gunaLabel8.Text = "Từ ngày";
            // 
            // orderFilterPanel
            // 
            this.orderFilterPanel.Controls.Add(this.gunaLabel8);
            this.orderFilterPanel.Controls.Add(this.orderFromDatePicker);
            this.orderFilterPanel.Controls.Add(this.filterOrderButton);
            this.orderFilterPanel.Controls.Add(this.gunaLabel9);
            this.orderFilterPanel.Controls.Add(this.orderToDatePicker);
            this.orderFilterPanel.Enabled = false;
            this.orderFilterPanel.Location = new System.Drawing.Point(50, 123);
            this.orderFilterPanel.Name = "orderFilterPanel";
            this.orderFilterPanel.Size = new System.Drawing.Size(1642, 100);
            this.orderFilterPanel.TabIndex = 110;
            // 
            // StatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1740, 1047);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.gunaLabel1);
            this.Name = "StatisticForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StatisticForm";
            this.Load += new System.EventHandler(this.StatisticForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productChart)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffChart)).EndInit();
            this.tab3.ResumeLayout(false);
            this.tab3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderTable)).EndInit();
            this.orderFilterPanel.ResumeLayout(false);
            this.orderFilterPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart productChart;
        private System.Windows.Forms.TabPage tabPage2;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private System.Windows.Forms.TabPage tab3;
        private Guna.UI.WinForms.GunaButton searchButton;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private System.Windows.Forms.DataVisualization.Charting.Chart staffChart;
        private Guna.UI.WinForms.GunaDataGridView orderTable;
        private Guna.UI.WinForms.GunaLabel gunaLabel10;
        private Guna.UI.WinForms.GunaLabel gunaLabel11;
        private Guna.UI.WinForms.GunaPanel orderFilterPanel;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaDateTimePicker orderFromDatePicker;
        private Guna.UI.WinForms.GunaButton filterOrderButton;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaDateTimePicker orderToDatePicker;
        private Guna.UI.WinForms.GunaCheckBox orderFilterCheckbox;
    }
}