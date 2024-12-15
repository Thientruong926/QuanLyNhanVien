using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace QuanLyNhanVien
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public static string infor = "Trạng thái: Chưa đăng nhập";
        public static bool isLoggedIn = false;
        private void frmMain_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            UpdateLoginStatus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelTime.Text = DateTime.Now.ToString("dddd, dd/MM/yyyy - HH:mm:ss");
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void UpdateLoginStatus()
        {
            if (isLoggedIn)
            {
                toolStripStatusLabelLoginStatus.Text = $"Xin chào: {infor}";
                btnLogin.Visible = false;
                btnLogout.Visible = true;
                labelQ.Visible = false;
                labelSignUp.Visible = false;
                đăngXuấtToolStripMenuItem.Enabled = true;
                đăngNhậpToolStripMenuItem.Enabled = false;
                groupBoxQuanLy.Enabled = true;
                this.ActiveControl = btnQLNhanVien;
                quảnLýToolStripMenuItem.Enabled = true;
                databaseDataContext db = new databaseDataContext();
                NGUOIDUNG nd = db.NGUOIDUNGs.SingleOrDefault(p => p.Username == infor);
                if(nd.LeaveID == 0)
                {
                    toolStripStatusLabelLoginLevel.Text = "Quyền: Admin";
                }
                else if(nd.LeaveID == 1)
                {
                    toolStripStatusLabelLoginLevel.Text = "Quyền: Trưởng phòng";
                }
                else
                {
                    toolStripStatusLabelLoginLevel.Text = "Quyền: Nhân viên";
                }
            }
            else
            {
                toolStripStatusLabelLoginStatus.Text = infor;
                btnLogin.Visible = true;
                btnLogout.Visible = false;
                labelQ.Visible = true;
                labelSignUp.Visible = true;
                đăngXuấtToolStripMenuItem.Enabled = false;
                đăngNhậpToolStripMenuItem.Enabled = true;
                groupBoxQuanLy.Enabled = false;
                quảnLýToolStripMenuItem.Enabled = false;
                toolStripStatusLabelLoginLevel.Text = "Quyền: Khách";
            }
        }

        private void chươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGTCT frm = new frmGTCT();
            this.Hide();
            frm.Show();
        }

        private void thànhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGTTV frm = new frmGTTV();
            this.Hide();
            frm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void labelSignUp_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            frmRegister frm = new frmRegister();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn đăng xuất không?",
                "Xác nhận đăng xuất",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (result == DialogResult.Yes)
            {
                isLoggedIn = false;
                infor = "Trạng thái: Chưa đăng nhập";
                UpdateLoginStatus();
            }
        }

        private void btnQLNhanVien_Click(object sender, EventArgs e)
        {
            frmNV frm = new frmNV();
            this.Hide();
            frm.Show();
        }

        private void btnQLPhongBan_Click(object sender, EventArgs e)
        {
            frmPB frm = new frmPB();
            this.Hide();
            frm.Show();
        }

        private void btnQLDeAn_Click(object sender, EventArgs e)
        {
            frmDA frm = new frmDA();
            this.Hide();
            frm.Show();
        }
    }
}