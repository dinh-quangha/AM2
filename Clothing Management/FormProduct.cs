using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clothing_Management
{
    public partial class FormProduct : Form
    {
        private readonly string connectString = @"Data Source=MSI;Initial Catalog=ASM2@;Integrated Security=True;TrustServerCertificate=True";
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter adt;
        private DataTable dt = new DataTable();
        public FormProduct()
        {
            InitializeComponent();
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }
        private void LoadProducts()
        {
            dt.Clear();
            using (SqlConnection con = new SqlConnection(connectString))
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("SELECT * FROM Products", con);
                    adt = new SqlDataAdapter(cmd);
                    adt.Fill(dt);
                    GridV_hienthi6.DataSource = dt; // Liên kết nguồn dữ liệu
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading products: {ex.Message}");
                }
            }
        }

        private void GridV_hienthi6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow selectedRow = GridV_hienthi6.Rows[e.RowIndex];

                    txt_ID.Text = selectedRow.Cells["ProductID"].Value?.ToString() ?? string.Empty;
                    txt_Name.Text = selectedRow.Cells["ProductName"].Value?.ToString() ?? string.Empty;
                    cbb_Size.Text = selectedRow.Cells["SizeProduct"].Value?.ToString() ?? string.Empty;
                    txt_Price.Text = selectedRow.Cells["SellingPrice"].Value?.ToString() ?? string.Empty;
                    txt_Inven.Text = selectedRow.Cells["InventoryPrice"].Value?.ToString() ?? string.Empty;

                    // Hiển thị hình ảnh
                    if (selectedRow.Cells["ProductImage"].Value != DBNull.Value)
                    {
                        byte[] imageData = (byte[])selectedRow.Cells["ProductImage"].Value;
                        picB_imageProduct.Image = ConvertByteArrayToImage(imageData);
                    }
                    else
                    {
                        picB_imageProduct.Image = null; // Xóa ảnh nếu không có dữ liệu
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error displaying product details: {ex.Message}");
                }
            }
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                MessageBox.Show("Please fill in all fields correctly.");
                return;
            }

            byte[] productImage = GetImageAsByteArray(picB_imageProduct.Image);

            using (SqlConnection con = new SqlConnection(connectString))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Products (ProductID, ProductName, SizeProduct, ProductImage, InventoryPrice, SellingPrice) VALUES (@ProductID, @ProductName, @SizeProduct, @ProductImage, @InventoryPrice, @SellingPrice)", con))
                    {
                        cmd.Parameters.AddWithValue("@ProductID", int.Parse(txt_ID.Text));
                        cmd.Parameters.AddWithValue("@ProductName", txt_Name.Text);
                        cmd.Parameters.AddWithValue("@ProductImage", productImage != null ? (object)productImage : DBNull.Value);
                        cmd.Parameters.AddWithValue("@SizeProduct", cbb_Size.Text);
                        cmd.Parameters.AddWithValue("@InventoryPrice", decimal.Parse(txt_Inven.Text));
                        cmd.Parameters.AddWithValue("@SellingPrice", decimal.Parse(txt_Price.Text));

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Product added successfully!");
                    LoadProducts();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Database error: {ex.Message}");
                }
            }

        }
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txt_ID.Text))
            {
                MessageBox.Show("Product ID cannot be empty.");
                return false;
            }
            if (!int.TryParse(txt_ID.Text, out _))
            {
                MessageBox.Show("Product ID must be a valid integer.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_Name.Text))
            {
                MessageBox.Show("Product Name cannot be empty.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(cbb_Size.Text))
            {
                MessageBox.Show("Please select a Product Size.");
                return false;
            }
            if (!decimal.TryParse(txt_Price.Text, out _))
            {
                MessageBox.Show("Selling Price must be a valid number.");
                return false;
            }
            if (!decimal.TryParse(txt_Inven.Text, out _))
            {
                MessageBox.Show("Inventory must be a valid number.");
                return false;
            }
            return true;
        }

        private byte[] GetImageAsByteArray(Image image)
        {
            if (image == null) return null;
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        private Image ConvertByteArrayToImage(byte[] byteArray)
        {
            if (byteArray == null || byteArray.Length == 0) return null;
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        private void picB_imageProduct_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp",
                Title = "Select a Product Image"
            };

            if (open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    picB_imageProduct.Image = Image.FromFile(open.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image: {ex.Message}");
                }
            }
        }

        private void bt_Update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Name.Text) ||
                string.IsNullOrWhiteSpace(cbb_Size.Text) ||
                string.IsNullOrWhiteSpace(txt_ID.Text) || // Kiểm tra ProductID
                !decimal.TryParse(txt_Price.Text, out decimal SellingPrice) ||
                !decimal.TryParse(txt_Inven.Text, out decimal InventoryPrice))
            {
                MessageBox.Show("Please enter valid values for Product ID, Product Name, Size, Inventory Price, and Selling Price.");
                return; // Thoát nếu dữ liệu không hợp lệ
            }

            // Chuyển đổi đường dẫn hình ảnh thành mảng byte
            byte[] productImage = PathToByteArray(this.Text); // Đảm bảo this.Text chứa đường dẫn hình ảnh

            using (SqlConnection con = new SqlConnection(connectString)) // Tạo kết nối mới
            {
                try
                {
                    con.Open(); // Mở kết nối

                    // Tạo câu lệnh UPDATE để sửa đổi thông tin sản phẩm
                    using (SqlCommand cmd = new SqlCommand("UPDATE Products SET ProductName = @ProductName, SizeProduct = @SizeProduct, ProductImage = @ProductImage, InventoryPrice = @InventoryPrice, SellingPrice = @SellingPrice WHERE ProductID = @ProductID", con))
                    {
                        cmd.Parameters.AddWithValue("@ProductID", int.Parse(txt_ID.Text)); // Lấy giá trị ProductID từ textbox
                        cmd.Parameters.AddWithValue("@ProductName", txt_Name.Text); // Lấy tên sản phẩm
                        cmd.Parameters.AddWithValue("@SizeProduct", cbb_Size.Text); // Lấy kích thước sản phẩm
                        cmd.Parameters.AddWithValue("@ProductImage", productImage); // Lấy hình ảnh
                        cmd.Parameters.AddWithValue("@InventoryPrice", InventoryPrice); // Lấy số lượng tồn kho
                        cmd.Parameters.AddWithValue("@SellingPrice", SellingPrice); // Lấy giá bán

                        cmd.ExecuteNonQuery(); // Thực thi câu lệnh UPDATE
                    }

                    MessageBox.Show("Product updated successfully!"); // Thông báo thành công
                    LoadProducts(); // Tải lại danh sách sản phẩm
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Database error: {ex.Message}"); // Hiển thị lỗi cơ sở dữ liệu nếu có
                }
                cmd.Parameters.AddWithValue("@ProductImage", productImage != null ? (object)productImage : DBNull.Value);

            }
        }
        private byte[] PathToByteArray(string path)
        {
            if (!string.IsNullOrEmpty(path) && File.Exists(path)) // Kiểm tra xem đường dẫn không rỗng và file tồn tại
            {
                return File.ReadAllBytes(path); // Đọc toàn bộ nội dung file thành mảng byte
            }
            else
            {
                MessageBox.Show("Image file not found or invalid path!");
                return null; // Trả về null nếu file không hợp lệ
            }
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            if (GridV_hienthi6.SelectedRows.Count > 0) // Kiểm tra xem có dòng nào được chọn không
            {
                // Lấy dòng được chọn
                var selectedRow = GridV_hienthi6.SelectedRows[0];
                int productIdToDelete = Convert.ToInt32(selectedRow.Cells["ProductID"].Value); // Lấy ProductID từ dòng đã chọn

                using (SqlConnection con = new SqlConnection(connectString)) // Tạo kết nối mới
                {
                    try
                    {
                        con.Open(); // Mở kết nối
                                    // Tạo câu lệnh DELETE để xóa sản phẩm
                        using (SqlCommand cmd = new SqlCommand("DELETE FROM Products WHERE ProductID = @ProductID", con))
                        {
                            cmd.Parameters.AddWithValue("@ProductID", productIdToDelete); // Thêm tham số ProductID
                            cmd.ExecuteNonQuery(); // Thực thi câu lệnh DELETE
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"Database error: {ex.Message}"); // Hiển thị lỗi cơ sở dữ liệu nếu có
                    }
                }

                // Xóa dòng khỏi DataGridView
                GridV_hienthi6.Rows.RemoveAt(selectedRow.Index);
            }
            else
            {
                MessageBox.Show("Please select a row to delete."); // Thông báo nếu không có dòng nào được chọn
            }
        }
    }
}
