using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using QuanLyNhanVien;

namespace QuanLyNhanVien
{
    public partial class frmForgotPass : Form
    {
        private string otpGenerated;
        private string emailEntered;
        
        //Ket noi CSDL
        public frmForgotPass()
        {
            InitializeComponent();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btVerify_Click(object sender, EventArgs e)
        {
            string otpEntered = txtOTP.Text.Trim();
            if (string.IsNullOrWhiteSpace(emailEntered) || string.IsNullOrWhiteSpace(otpEntered))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (otpGenerated == otpEntered)
            {
                databaseDataContext db = new databaseDataContext();
                NGUOIDUNG nd = db.NGUOIDUNGs.SingleOrDefault(p => p.Email == emailEntered);
                if ((DateTime.Now - (DateTime)nd.OTPDateSend).TotalMinutes <= 1)
                {
                    nd.OTP = otpEntered;
                    nd.DateActive = DateTime.Now;
                    nd.Active = true;
                    db.SubmitChanges();
                    MessageBox.Show("Xác thực thành công! Vui lòng đặt lại mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmResetPass resetPasswordForm = new frmResetPass(emailEntered);
                    resetPasswordForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mã OTP quá thời gian hiệu lực! Vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Mã OTP không đúng! Vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSendCode_Click(object sender, EventArgs e)
        {
            emailEntered = txtEmail.Text.Trim();
            if (string.IsNullOrWhiteSpace(emailEntered))
            {
                MessageBox.Show("Vui lòng nhập email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (CheckEmailExists(emailEntered))
            {
                databaseDataContext db = new databaseDataContext();
                otpGenerated = GenerateOTP();
                SendOTPEmail(emailEntered, otpGenerated);
                NGUOIDUNG nd = db.NGUOIDUNGs.SingleOrDefault(p => p.Email == emailEntered);
                nd.OTPDateSend = nd.OTPCreated = DateTime.Now;
                db.SubmitChanges();
                MessageBox.Show("Mã OTP đã được gửi tới email của bạn! Mã có hiệu lực trong vòng một phút! Vui lòng kiểm tra và nhập mã OTP để xác thực.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Email không tồn tại trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool CheckEmailExists(string email)
        {
            // Ket noi SQL
            databaseDataContext db = new databaseDataContext();
            NGUOIDUNG nd = db.NGUOIDUNGs.SingleOrDefault(p => p.Email == email);
            return nd != null;
        }
        private string GenerateOTP()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString();
        }

        private void SendOTPEmail(string email, string otp)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("kibayuji0812@gmail.com");
                mail.To.Add(email);
                mail.Subject = "Mã OTP khôi phục mật khẩu";
                mail.Body = $"Mã OTP của bạn là: {otp}";

                smtpServer.Port = 587;
                smtpServer.Credentials = new NetworkCredential("kibayuji0812@gmail.com", "shzmgpaxmaztuuyu");
                smtpServer.EnableSsl = true;

                smtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể gửi email! Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtOTP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
