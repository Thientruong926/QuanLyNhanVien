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
    public partial class ThemDA : Form
    {
        public ThemDA()
        {
            InitializeComponent();
        }
        public string getMaDA() => txtMaDA.Text;

        public string getTenDA() => txtTenDA.Text;

        public string getStart() => txtStart.Text;

        public string getEnd() => txtEnd.Text;
        public bool kiemtra()
        {

            if (string.IsNullOrWhiteSpace(txtStart.Text) || string.IsNullOrWhiteSpace(txtEnd.Text) || string.IsNullOrWhiteSpace(txtMaDA.Text) || string.IsNullOrWhiteSpace(txtTenDA.Text))
            {
                return false;
            }
            if (KiemTraTonTaiDeAn(txtMaDA.Text))
            {
                MessageBox.Show("Mã đề án đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // KiemTra Database
            return true;
        }

        private bool KiemTraTonTaiDeAn(string maDeAn)
        {
            using (databaseDataContext db = new databaseDataContext())
            {
                return db.DEANs.Any(d => d.MaDeAn == maDeAn);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXacNhan_Click_1(object sender, EventArgs e)
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
