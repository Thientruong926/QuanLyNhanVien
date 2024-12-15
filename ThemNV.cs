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
    public partial class ThemNV : Form
    {
        public ThemNV()
        {
            InitializeComponent();
        }

        private void ThemNV_Load(object sender, EventArgs e)
        {

        }

        public string getMaNV() => txtMaNV.Text;

        public string getTenNV() => txtTenNV.Text;

        public string getNS() => txtNS.Text;

        public string getGT() => txtGT.Text;

        public string getDC() => txtDchi.Text;

        public string getMaPCT() => txtMaPhongCT.Text;

        public string getMaTP() => txtMaTrgPhong.Text;

        public string getLuong() => txtLuong.Text;

        public bool kiemtra()
        {

            if (string.IsNullOrWhiteSpace(txtMaNV.Text) || string.IsNullOrWhiteSpace(txtTenNV.Text) || string.IsNullOrWhiteSpace(txtNS.Text) || string.IsNullOrWhiteSpace(txtGT.Text) || string.IsNullOrWhiteSpace(txtDchi.Text))
            {
                return false;
            }
            if (KiemTraTonTaiNhanVien(txtMaNV.Text))
            {
                MessageBox.Show("Mã đề án đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // KiemTra Database
            return true;
        }

        private bool KiemTraTonTaiNhanVien(string maNhanVien)
        {
            using (databaseDataContext db = new databaseDataContext())
            {
                return db.NHANVIENs.Any(n => n.MaNV == maNhanVien);
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
