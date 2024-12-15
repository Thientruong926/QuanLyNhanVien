using System;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace QuanLyNhanVien
{
    public partial class frmActive : Form
    {
        private string _email;
        private string _username;
        private string _password;
        private string otp;
        private DateTime otpdatesend;
        public frmActive(string email, string username, string password)
        {
            InitializeComponent();
            _email = email;
            _username = username;
            _password = password;
            otpdatesend = DateTime.Now;
            lbNotice.Text = $"Xác thực tài khoản cho email: {_email}";
            otp = GenerateOTP();
            SendOTPEmail(_email, otp);
        }

        private void btVerify_Click(object sender, EventArgs e)
        {
            string inputOTP = txtOTP.Text;

            if (string.IsNullOrWhiteSpace(inputOTP))
            {
                MessageBox.Show("Vui lòng nhập mã OTP.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                //Ket noi SQL
                
                if(inputOTP == otp)
                {
                    if((DateTime.Now - otpdatesend).TotalMinutes <= 1)
                    {
                        databaseDataContext db = new databaseDataContext();
                        NGUOIDUNG nd = new NGUOIDUNG()
                        {
                            Username = _username,
                            Password = _password,
                            Email = _email,
                            OTP = otp,
                            OTPDateSend = otpdatesend,
                            OTPCreated = otpdatesend,
                            Active = true,
                            DateActive = DateTime.Now,
                            LeaveID = 2,
                        };
                        db.NGUOIDUNGs.InsertOnSubmit(nd);
                        db.SubmitChanges();
                        MessageBox.Show("Xác minh tài khoản thành công. Vui lòng đăng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        frmLogin frm = new frmLogin();
                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show("mã OTP hết hiệu lực. Vui lòng gửi lại mã OTP để xác minh", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("mã OTP không đúng. Vui lòng nhập lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi kết nối cơ sở dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        private void btAgain_Click(object sender, EventArgs e)
        {
            otp = GenerateOTP();
            otpdatesend = DateTime.Now;
            try
            {
                SendOTP(_email, otp);
                MessageBox.Show("OTP mới đã được gửi đến email của bạn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi gửi lại OTP: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GenerateOTP()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString();
        }

        private void SendOTP(string email, string otp)
        {
            try
            {
                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("kibayuji0812@gmail.com", "shzmgpaxmaztuuyu"),
                    EnableSsl = true,
                };

                smtpClient.Send("kibayuji0812@gmail.com", email, "Mã OTP mới", $"Mã OTP của bạn là: {otp}. OTP có hiệu lực trong 5 phút.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi gửi OTP: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtOTP_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
