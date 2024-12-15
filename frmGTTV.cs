using QuanLyNhanVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanVien
{
    public partial class frmGTTV : Form
    {
        public frmGTTV()
        {
            InitializeComponent();
        }

        private void frmGTVT_Load(object sender, EventArgs e)
        {
            this.ActiveControl = labelTen1;
            update();
        }

        private void update()
        {
            if (frmMain.isLoggedIn)
            {
                đăngNhậpToolStripMenuItem.Enabled = false;
                đăngXuấtToolStripMenuItem.Enabled = true;
                quảnLýToolStripMenuItem.Enabled = true;
            }
            else
            {
                đăngNhậpToolStripMenuItem.Enabled = true;
                đăngXuấtToolStripMenuItem.Enabled = false;
                quảnLýToolStripMenuItem.Enabled = false;
            }
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            this.Close();
            frm.Show();
        }

        private void quayLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            this.Close();
            frm.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn đăng xuất không?",
                "Xác nhận đăng xuất",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                frmMain.infor = "Trạng thái: Chưa đăng nhập";
                frmMain.isLoggedIn = false;
                frmMain frm = new frmMain();
                this.Close();
                frm.Show();
            }
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

        private void chươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGTCT frm = new frmGTCT();
            this.Close();
            frm.Show();
        }

        private void btnQLNhanVien_Click(object sender, EventArgs e)
        {
            frmNV frm = new frmNV();
            this.Close();
            frm.Show();
        }

        private void btnQLPhongBan_Click(object sender, EventArgs e)
        {
            frmPB frm = new frmPB();
            this.Close();
            frm.Show();
        }

        private void btnQLDeAn_Click(object sender, EventArgs e)
        {
            frmDA frm = new frmDA();
            this.Close();
            frm.Show();
        }
    }
}
