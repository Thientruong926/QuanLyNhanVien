using QuanLyNhanVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanVien
{

    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbLogin_Click(object sender, EventArgs e)
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
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbPassword_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            frmRegister registerForm = new frmRegister();
            registerForm.Show();
            this.Close();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // kET NOIS sql
            else
            {
                databaseDataContext db = new databaseDataContext();
                NGUOIDUNG nd = db.NGUOIDUNGs.SingleOrDefault(p => p.Username == username);
                if (nd == null)
                {
                    MessageBox.Show("Không tìm thấy tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string hashpassword = HashPassword(password);
                    if (nd.Password == hashpassword)
                    {
                        if (nd.LeaveID == 0)
                        {
                            MessageBox.Show($"Đăng nhập thành công! Chức vụ: Admin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (nd.LeaveID == 1)
                        {
                            MessageBox.Show($"Đăng nhập thành công! Chức vụ: Trưởng phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (nd.LeaveID == 2)
                        {
                            MessageBox.Show($"Đăng nhập thành công! Chức vụ: Nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        frmMain.infor = nd.Username;
                        frmMain.isLoggedIn = true;
                        frmMain frm = new frmMain();
                        frm.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            this.Hide();
            frmMain.Show();
        }

        private void LinkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmForgotPass ForgotPasswordForm = new frmForgotPass();
            ForgotPasswordForm.ShowDialog();
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
