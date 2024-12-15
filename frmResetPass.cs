using QuanLyNhanVien;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace QuanLyNhanVien
{
    public partial class frmResetPass : Form
    {
        private string emailEntered;

        public frmResetPass(string emailEntered)
        {
            InitializeComponent();
            this.emailEntered = emailEntered;
        }

        private void ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPass.Checked)
            {
                txtNewPassword.PasswordChar = '\0';
            }
            else
            {
                txtNewPassword.PasswordChar = '*';
            }
            if (ShowPass.Checked)
            {
                txtConfirmNewPass.PasswordChar = '\0';
            }
            else
            {
                txtConfirmNewPass.PasswordChar = '*';
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonCofirm_Click(object sender, EventArgs e)
        {
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmNewPass.Text;

            if (newPassword == confirmPassword)
            {
                MessageBox.Show("Reset mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Mật khẩu không trùng khớp. Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Mã hóa mật khẩu mới
            string hashedPassword = HashPassword(newPassword);
            databaseDataContext db = new databaseDataContext();
            try
            {
                NGUOIDUNG nd = db.NGUOIDUNGs.SingleOrDefault(p => p.Email == emailEntered);
                nd.Password = hashedPassword;

                db.SubmitChanges();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kết nối cơ sở dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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

        private void txtConfirmNewPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
