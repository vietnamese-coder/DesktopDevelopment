using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_Basic_Command {
    public partial class FoodForm : Form {
        public FoodForm() {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        public void LoadFood(int categoryID) {
            // Tạo đối tượng kết nối
            string connectionString = "server=., database = RestaurantManagement; Integrated Security = true; ";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            // Tạo đối tượng thực thi lệnh
            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            // Thiết lập lệnh truy vấn đối tượng Command
            sqlCommand.CommandText = "SELECT Name FROM Category where ID = " + categoryID;

            // Mở kết nối tới cơ sở dữ liệu
            sqlConnection.Open();

            // Gán tên nhóm sản phẩm cho tiêu đề
            string catName = sqlCommand.ExecuteScalar().ToString(); ;
            this.Text = "Danh sách các ón ăn thuộc nhóm: " + catName;

            sqlCommand.CommandText = "SELECT * FROM Food WHERE FoodCategoryID = " + categoryID;

            // Tao DataTable để chứa dữ liệu
            DataTable dt = new DataTable("Food");
            da.Fill(dt);

            // Hiển thị danh sách món ăn lên Form 
            dgvFood.DataSource = dt;

            // Đóng kết nôi và giải phóng bộ nhớ
            sqlConnection.Close();
            sqlConnection.Dispose();
            da.Dispose();
        }
    }
}
