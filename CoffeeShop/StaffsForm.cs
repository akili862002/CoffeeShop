using CoffeeShop.Databases;
using CoffeeShop.Entities;
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
    public partial class StaffsForm : Form
    {
        public StaffsForm()
        {
            InitializeComponent();
        }
        UserEntity user = new UserEntity();
        private bool isEditStaff;

        private void StaffsForm_Load(object sender, EventArgs e)
        {
            this.LoadStaffTableData();
            birthdatePicker.Format = DateTimePickerFormat.Custom;
            birthdatePicker.CustomFormat = "MM/dd/yyyy"; 
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;)|*.jpg;*.jpeg;";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                Image img = new Bitmap(opnfd.FileName);
                Console.WriteLine("w: " + img.Width);
                Console.WriteLine("h: " + img.Height);
                if (img.Width != img.Height)
                {
                    MessageBox.Show(String.Format("Please select a square image! ({0}x{1})", img.Width, img.Height), "Error");
                    return;
                }
                this.avatarPicture.Image = img;
            }
        }
        public void LoadStaffTableData()
        {
            UserDB db = new UserDB();
            new Thread(() =>
            {
                DataTable dt = new DataTable();
                db.getAllAdapter(
                        @"id as [ID], fullname as [Họ Và Tên],phone as [Điện Thoại],birthdate as [Ngày Sinh],CASE WHEN gender = 1  THEN N'Nam' ELSE N'Nữ' END as [Giới Tính],address as [Địa Chỉ],salary as [Lương]",
                        this.searchTextBox.Text
                    )
                .Fill(dt);

                this.Invoke(new MethodInvoker(delegate
                {
                    this.staffsTable.DataSource = dt;
                }));

            }).Start();
            new Thread(() =>
            {
                int totalCount = db.count();
                this.gunaLabel6.Text = $"Danh sách nhân viên ({totalCount})";
            }).Start();
        }
        private void initCreateUser()
        {
            this.isEditStaff = true;
            this.editButton.Text = "Cập nhật";
            this.gunaLabel3.Text = $"Chỉnh sửa thông tin nhân sự: {user.id}";
            this.deleteButton.Show();

            this.fullnameTextBox.Text = "";
            this.phoneTextBox.Text = "";
            this.birthdatePicker.Value = DateTime.Today;
            this.maleRadio.Checked = true;
            this.addressTextBox.Text = "";
            this.salaryTextBox.Text = "";
        }
        private void initEditUser()
        {
            this.isEditStaff = true;
            this.editButton.Text = "Cập nhật";
            this.gunaLabel3.Text = $"Chỉnh sửa thông tin nhân sự: {user.id}";
            this.deleteButton.Show();

            this.fullnameTextBox.Text = this.user.fullname;
            this.phoneTextBox.Text = this.user.phone;
            this.birthdatePicker.Value = this.user.birthdate.Date;
            if (this.user.gender)
            {
                maleRadio.Checked = true;
            }
            else
            {
                famaleRadio.Checked = true;
            }
            this.addressTextBox.Text = this.user.address.ToString();
            this.salaryTextBox.Text = this.user.salary.ToString();
        }
        private void staffsTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentIndex = this.staffsTable.CurrentCell.RowIndex;
            if (currentIndex < 0) return;

            DataGridViewRow row = this.staffsTable.Rows[currentIndex];
            this.user = new UserEntity();
            this.user
                .setId(Int32.Parse(row.Cells["ID"].Value.ToString()))
                .setFullName(row.Cells["Họ Và Tên"].Value.ToString())
                .setPhone(row.Cells["Điện Thoại"].Value.ToString())
                .setBirthdate( DateTime.Parse(row.Cells["Ngày Sinh"].Value.ToString()))
                .setAddress(row.Cells["Địa Chỉ"].Value.ToString())
                .setSalary(Int64.Parse(row.Cells["Lương"].Value.ToString()));
            if (row.Cells["Giới Tính"].Value.ToString() == "Nam")
            {
                user.setGender(true);
            }
            if(row.Cells["Giới Tính"].Value.ToString() == "Nữ")
            {
                user.setGender(false);
            }
            this.isEditStaff = true;
            initEditUser();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            this.LoadStaffTableData();
        }

        private void editButton_Click(object sender, EventArgs e)
        {

            UserEntity user= new UserEntity();
            UserDB DB = new UserDB();


            if (DB.checkPhone(phoneTextBox.Text))
            {
                MessageBox.Show("Phone number already exits", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                user
                .setFullName(this.fullnameTextBox.Text)
                .setPhone(this.phoneTextBox.Text)
                .setBirthdate(this.birthdatePicker.Value)
                .setAddress(this.addressTextBox.Text)
                .setSalary(Int64.Parse(this.salaryTextBox.Text));

                if (maleRadio.Checked == true)
                {
                    user.setGender(true);
                }
                if (famaleRadio.Checked == true)
                {
                    user.setGender(false);
                }
                DB.update(user);
                this.LoadStaffTableData();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show($"Bạn có chắc muốn xóa [{this.user.fullname}]?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) return;

            UserDB db = new UserDB();
            new Thread(() =>
            {
                db.delete(this.user.id);
                this.LoadStaffTableData();
                this.initCreateUser();
            }).Start();
        }

        
    }
}
