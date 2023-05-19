using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;


namespace Lab6_Basic_Command {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void lvCategory_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            // Tạo đối tượng kết nối
            string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true; ";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            // Tạo đối tượng thực thi lệnh 
            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            // Thiết lập lệnh truy vấn cho đối tượng Command
            sqlCommand.CommandText = "UPDATE Category SET Name = N' " + txtName.Text +
                                                    "', [Type] = " + txtType.Text +
                                                    " WHERE ID = " + txtID.Text;

            sqlConnection.Open();

            // Thực thi lệnh bằng phương thức ExcuteReader 
            int numOfRowsEffected = sqlCommand.ExcuteNonQuery();

            // Đóng kết nối
            sqlConnection.Close();

            if (numOfRowsEffected == 1) {
                // Cập nhật lại dữ liệu trên Listview 
                ListViewItem item = lvCategory.SelectedItems[0];

                item.SubItems[1].Text = txtName.Text;
                item.SubItems[2].Text = txtType.Text;

                // Xóa các ô nhập 
                txtID.Text = "";
                txtName.Text = "";
                txtType.Text = "";

                // Vô hiệu hóa các nút xóa và cập nhập
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;

                MessageBox.Show("Cập nhật nhóm món ăn thành công");
            }

            else {
                MessageBox.Show("Đã có lỗi xảy ra, Vui lòng thử lại");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e) {
            // Tạo chuỗi kết nối tới CSDL RestaurantManagement
            string connectionString = "server=.; database = RestaurantManagement; Intergrated Security = true; ";

            // Tạo đối tượng kết nối
            SqlConnection sqlConnection = new SqlConnection(connectionString);


            // Tạo đối tượng thực thi
            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            // Thiết lập lệnh truy vấn cho đối tượng Command 
            string query = "SELECT ID, Name, Type FROM Category";
            sqlCommand.CommandText = query;

            // Mở kết nối tới cơ sở dữ liệu
            sqlConnection.Open();

            // Thực thi lệnh bằng phương thức ExcuteReader 
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            // Gọi hàm hiển thị dữ liệu lên màn hình 
            this.DisplayCategory(sqlDataReader);

            // Đóng kết nối
            sqlConnection.Close();

        }

        private void DisplayCategory(SqlDataReader reader) {
            // Xóa tất cả các dòng hiện tại
            lvCategory.Items.Clear();

            // Đọc một dòng dữ liệu
            while (reader.Read()) {
                // Tạo một dòng mới trong ListView
                ListViewItem item = new ListViewItem(reader["ID"].ToString());

                // Thêm dòng mới vào ListView
                lvCategory.Items.Add(item);

                // Bổ sung các thông tin khác cho ListViewItem
                item.SubItems.Add(reader["Name"].ToString());
                item.SubItems.Add(reader["Type"].ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            // Tạo đối tượng kết nối
            string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true; ";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            // Tạo đối tượng thực thi lệnh
            SqlCommand sqlCommand = sqlConnection.CreateCommand();


            // Thiết lập lệnh truy vấn cho đối tượng Command
            sqlCommand.CommandText = "INSERT INTO Category(Name, [Type])" +
                "VALUES (N'" + txtName.Text + "', " + txtType.Text + ")";

            sqlConnection.Open();

            // Thực thi lệnh bằng phương thức ExcuteReader 
            int numOfRowsEffected = sqlCommand.ExcuteNonQuery();

            // Đóng kết nối
            sqlConnection.Close();

            if (numOfRowsEffected == 1) {
                MessageBox.Show("Thêm nhóm ăn món ăn thành công");

                // Tải lại dữ liệu
                btnLoad.PerformClick();

                // Xóa các ô nhập
                txtName.Text = "";
                txtType.Text = "";
            }
            else {
                MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại");
            }

        }

        private void lvCategory_Click(object sender, EventArgs e) {
            // Lấy dòng được chọn trong Listview
            ListViewItem item = lvCategory.SelectedItems[0];


            // Hiển thị dữ liệu trên Textbox
            txtID.Text = item.Text;
            txtName.Text = item.SubItems[1].Text;
            txtType.Text = item.SubItems[1].Text == "0" ? "Thức uống" : "Đồ ăn";

            // Hiện thị xóa và cập nhập
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            // Tạo đối tượng kết nối
            string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true; ";
            SqlConnection sqlConnection = new SqlConnection(connectionString);


            // Tạo đối tượng thực thi lệnh
            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            // Thiết lập lệnh truy vấn cho đối tượng Command
            sqlCommand.CommandText = "DELETE FROM Category" +
                "WHERE ID = " + txtID.Text;

            sqlConnection.Open();

            int numOfRowsEffected = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            if (numOfRowsEffected == 1) {
                //Cập nhật lại dữ liệu trên ListView
                ListViewItem item = lvCategory.SelectedItems[0];
                lvCategory.Items.Remove(item);

                // Xóa các ô nhập
                txtID.Text = "";
                txtName.Text = "";
                txtType.Text = "";

                // Disabled các nút xóa và cập nhập
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;

                MessageBox.Show("Xóa nhóm món ăn thành công");
            }
            else {
                MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại");
            }
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e) {

        }

        private void tsmDelete_Click(object sender, EventArgs e) {
            if (lvCategory.SelectedItems.Count > 0) {
                btnDelete.PerformClick();
            }
        }

        private void tsmViewfood_Click(object sender, EventArgs e) {
            if (txtID.Text != "") {
                FoodForm foodForm = new FoodForm();
                foodForm.Show(this);
                foodForm.LoadFood(Convert.ToInt32(txtID.Text));
            }
        }
    }
}