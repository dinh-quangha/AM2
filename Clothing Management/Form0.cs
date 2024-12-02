using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clothing_Management
{
    public partial class Form0 : Form
    {
        public Form0()
        {
            InitializeComponent();
        }

        private void Form0_Load(object sender, EventArgs e)
        {

        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=MSI;Initial Catalog=ASM2@;Integrated Security=True;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Lấy giới tính từ Radio Buttons
                string gender = "";
                if (rdMale.Checked)
                {
                    gender = "Male";
                }
                else if (rdFemale.Checked)
                {
                    gender = "Female";
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn giới tính.");
                    return; // Dừng lại nếu chưa chọn giới tính
                }
                // Thêm thông tin khách hàng vào bảng Customer
                string insertCustomerQuery = "INSERT INTO Customer (CustomerName, Gender, BirthofDate, Phone, Gmail) " +
                                             "VALUES (@CustomerName, @Gender, @BirthofDate, @Phone, @Gmail); " +
                                             "SELECT SCOPE_IDENTITY();";

                SqlCommand command = new SqlCommand(insertCustomerQuery, connection);
                command.Parameters.AddWithValue("@CustomerName", txtNameCus.Text);
                command.Parameters.AddWithValue("@Gender", gender);
                command.Parameters.AddWithValue("@BirthofDate", dTPBirth.Value);
                command.Parameters.AddWithValue("@Phone", txtPhone.Text);
                command.Parameters.AddWithValue("@Gmail", txtEmail.Text);

                // Lấy CustomerID mới thêm
                int customerId = Convert.ToInt32(command.ExecuteScalar());

                // Thêm tài khoản đăng nhập vào bảng Users
                string salt = GenerateSalt();
                string hashedPassword = HashPassword(txtPass.Text, salt);
                string insertUserQuery = "INSERT INTO Users (UserName, PasswordHash, Salt, Role, CustomerID) " +
                                         "VALUES (@UserName, @PasswordHash, @Salt, 'User', @CustomerID)";

                SqlCommand userCommand = new SqlCommand(insertUserQuery, connection);
                userCommand.Parameters.AddWithValue("@UserName", txtUser.Text);
                userCommand.Parameters.AddWithValue("@PasswordHash", hashedPassword); // Hàm HashPassword cần được cài đặt
                userCommand.Parameters.AddWithValue("@Salt", salt); // Hàm GenerateSalt cần được cài đặt
                userCommand.Parameters.AddWithValue("@CustomerID", customerId);

                userCommand.ExecuteNonQuery();
                if (txtPass.Text.Length < 6)
                {
                    MessageBox.Show("Password must be at least 6 characters!");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNameCus.Text) ||
                    string.IsNullOrWhiteSpace(txtUser.Text) ||
                    string.IsNullOrWhiteSpace(txtPass.Text) ||
                    string.IsNullOrWhiteSpace(txtPhone.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Please fill in all information!");
                    return;
                }
                else
                {
                    MessageBox.Show("Register Successfull!");
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide(); // Ẩn form hiện tại (Form0)
                }
                
            }
        }
        private static string GenerateSalt()
        {
            // Tạo mảng byte ngẫu nhiên để làm salt
            byte[] saltBytes = new byte[16];
            using (var rng = new System.Security.Cryptography.RNGCryptoServiceProvider())
            {
                rng.GetBytes(saltBytes);
            }
            // Chuyển đổi mảng byte sang chuỗi Base64
            return Convert.ToBase64String(saltBytes);
        }
        private static string HashPassword(string password, string salt)
        {
            // Kết hợp mật khẩu với salt
            string saltedPassword = password + salt;

            // Chuyển đổi chuỗi mật khẩu đã kết hợp thành 1 mảng byte
            byte[] saltedPasswordBytes = Encoding.UTF8.GetBytes(saltedPassword);

            // Sử dụng SHA256 để . mật khẩu
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(saltedPasswordBytes);
                // Chuyển đổi mảng byte thành chuỗi Base64
                return Convert.ToBase64String(hashBytes);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();                   //ADMIN
            this.Hide();
        }
    }
}
