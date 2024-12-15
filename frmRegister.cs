using System;
using System.Net;
using System.Net.Mail;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Security.Cryptography;
using static System.Net.WebRequestMethods;
using QuanLyNhanVien;

namespace QuanLyNhanVien
{
    public partial class frmRegister : Form
    {

        public frmRegister()
        {
            InitializeComponent();
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
            if (ShowPass.Checked)
            {
                txtConfirmPass.PasswordChar = '\0';
            }
            else
            {
                txtConfirmPass.PasswordChar = '*';
            }
        }

        private void lbLinkLogin_Click(object sender, EventArgs e)
        {
            frmLogin LoginForm = new frmLogin();
            LoginForm.Show();
            this.Close();
        }
        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string email = textEmail.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPass.Text;
            if (username == "" || password == "" || email == "" || confirmPassword == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Email không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu và Xác nhận mật khẩu không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            databaseDataContext db = new databaseDataContext();
            string hashedPassword = HashPassword(password);
            NGUOIDUNG nd1 = db.NGUOIDUNGs.Where(p => p.Email == email).FirstOrDefault();
            if (nd1 != null)
            {
                MessageBox.Show("Email đã tồn tại! Vui lòng chọn email khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            NGUOIDUNG nd2 = db.NGUOIDUNGs.Where(p => p.Username == username).FirstOrDefault();
            if (nd2 != null)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại! Vui lòng chọn tên khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Mã OTP sẽ được gửi đến bạn. Vui lòng nhập mã OTP vào form sau để kích hoạt tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmActive frm = new frmActive(email, username, hashedPassword);
            frm.ShowDialog();
        }
        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                return Regex.IsMatch(email, emailPattern, RegexOptions.IgnoreCase);
            }
            catch
            {
                return false;
            }
        }
        // Hàm mã hóa mật khẩu
        private string HashPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
