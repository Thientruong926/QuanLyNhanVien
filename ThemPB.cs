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
    public partial class ThemPB : Form
    {
        public ThemPB()
        {
            InitializeComponent();
        }
        public string getMaPhg() => txtMaPhg.Text;

        public string getTenPhg() => txtTenPhg.Text;

        public string getMTP() => txtMTP.Text;

        public string getTTP() => txtTTP.Text;
        public bool kiemtra()
        {

            if (string.IsNullOrWhiteSpace(txtMaPhg.Text) || string.IsNullOrWhiteSpace(txtTenPhg.Text) || string.IsNullOrWhiteSpace(txtMTP.Text) || string.IsNullOrWhiteSpace(txtTTP.Text))
            {
                return false;
            }
            if (KiemTraTonTaiPhongBan(txtMaPhg.Text))
            {
                MessageBox.Show("Mã đề án đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // KiemTra Database
            return true;
        }

        private bool KiemTraTonTaiPhongBan(string maPhongBan)
        {
            using (databaseDataContext db = new databaseDataContext())
            {
                return db.PHONGBANs.Any(n => n.MaPhg == maPhongBan);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (kiemtra())
            {
                MessageBox.Show("Thông tin hợp lệ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thông tin không hợp lệ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
