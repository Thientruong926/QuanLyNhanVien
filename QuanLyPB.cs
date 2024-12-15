using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace QuanLyNhanVien
{
    public partial class frmPB : Form
    {
        public frmPB()
        {
            InitializeComponent();
        }

        private void frmPB_Load(object sender, EventArgs e)
        {
            loadDuLieu();
        }

        private void loadDuLieu()
        {
            dgvPB.AutoGenerateColumns = false;
            dgvNVfromPB.AutoGenerateColumns = false;
            databaseDataContext db = new databaseDataContext();
            dgvPB.DataSource = db.PHONGBANs.OrderBy(p => p.MaPhg);
            if (db.PHONGBANs.ToList().Count > 0)
            {
                hienthiPB(0);
            }
        }
        private void hienthiPB(int id)
        {
            if (id < 0 || id >= dgvPB.Rows.Count)
            {
                return;
            }

            string maphg = dgvPB.Rows[id].Cells[0].Value?.ToString();
            if (string.IsNullOrEmpty(maphg))
            {
                return;
            }

            databaseDataContext db = new databaseDataContext();
            var nhanviens = db.NHANVIENs.Where(nv => nv.MaPhong == maphg).ToList();
            dgvNVfromPB.DataSource = nhanviens;


            if (nhanviens.Count > 0)
            {
                hienthiNV(0);
            }

        }

        private void dgvPB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = e.RowIndex;

            if (id < 0 || id >= dgvPB.Rows.Count)
            {
                return;
            }

            hienthiPB(id);
        }

        private void hienthiNV(int v)
        {
            if (v < 0 || v >= dgvNVfromPB.Rows.Count)
            {
                return;
            }

            string manv = dgvNVfromPB.Rows[v].Cells[0].Value?.ToString();
            if (string.IsNullOrEmpty(manv))
            {
                return;
            }

            databaseDataContext db = new databaseDataContext();
            NHANVIEN nv = db.NHANVIENs.Where(p => p.MaNV == manv).SingleOrDefault();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemPB themPBForm = new ThemPB();
            themPBForm.FormClosed += (s, args) => this.Show();
            this.Hide();
            themPBForm.ShowDialog();

            if (themPBForm.kiemtra())
            {
                try
                {

                    databaseDataContext db = new databaseDataContext();
                    PHONGBAN newDepartment = new PHONGBAN
                    {
                        MaPhg = themPBForm.getMaPhg(),
                        TenPhg = themPBForm.getTenPhg(),
                        MaTrgPhong = themPBForm.getMTP(),
                        TenTrgPhong = themPBForm.getTTP(),
                    };

                    db.PHONGBANs.InsertOnSubmit(newDepartment);
                    db.SubmitChanges();
                    loadDuLieu();
                    MessageBox.Show("Thêm phòng ban thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi thêm phòng ban: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Thêm phòng ban thất bại. Vui lòng kiểm tra các thuộc tính.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void xóaPhòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvPB.CurrentRow != null)
            {
                string maphg = txtMaPBCanTim.Text;

                DialogResult dialogResult = MessageBox.Show(
                    "Xóa phòng ban sẽ xóa toàn bộ dữ liệu liên quan trong bảng phân công, đề án, và nhân viên. Bạn có chắc chắn muốn tiếp tục?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        databaseDataContext db = new databaseDataContext();

                        // 1. Xóa các phân công liên quan đến đề án của phòng ban
                        var deans = db.DEANs.Where(d => d.MaPhong == maphg).Select(d => d.MaDeAn).ToList();
                        var phancongsLienQuanDeAn = db.PHANCONGs.Where(pc => deans.Contains(pc.MaDeAn)).ToList();
                        if (phancongsLienQuanDeAn.Any()) db.PHANCONGs.DeleteAllOnSubmit(phancongsLienQuanDeAn);

                        // 2. Xóa các đề án liên quan đến phòng ban
                        var deansToDelete = db.DEANs.Where(d => d.MaPhong == maphg).ToList();
                        if (deansToDelete.Any()) db.DEANs.DeleteAllOnSubmit(deansToDelete);

                        // 3. Xóa các phân công liên quan đến nhân viên của phòng ban
                        var nhanviens = db.NHANVIENs.Where(nv => nv.MaPhong == maphg).Select(nv => nv.MaNV).ToList();
                        var phancongs = db.PHANCONGs.Where(pc => nhanviens.Contains(pc.MaNV)).ToList();
                        if (phancongs.Any()) db.PHANCONGs.DeleteAllOnSubmit(phancongs);

                        // 4. Xóa các nhân viên trong phòng ban
                        var nhanviensToDelete = db.NHANVIENs.Where(nv => nv.MaPhong == maphg).ToList();
                        if (nhanviensToDelete.Any()) db.NHANVIENs.DeleteAllOnSubmit(nhanviensToDelete);

                        // 5. Xóa phòng ban
                        var phongBan = db.PHONGBANs.SingleOrDefault(pb => pb.MaPhg == maphg);
                        if (phongBan != null) db.PHONGBANs.DeleteOnSubmit(phongBan);

                        // Lưu thay đổi vào cơ sở dữ liệu
                        db.SubmitChanges();
                        loadDuLieu();

                        MessageBox.Show("Phòng ban đã được xóa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi xóa phòng ban: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void sửaPhòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedId = txtMaPBCanTim.Text;

            if (string.IsNullOrWhiteSpace(selectedId))
            {
                MessageBox.Show("Vui lòng nhập mã phòng ban hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SuaPB editForm = new SuaPB(selectedId);
            editForm.FormClosed += (s, args) => this.Show();
            this.Hide();
            editForm.ShowDialog();
            loadDuLieu();
        }

        private void tìmKiếmPhòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedId = txtMaPBCanTim.Text;
            if (string.IsNullOrWhiteSpace(selectedId))
            {
                MessageBox.Show("Vui lòng nhập mã phòng ban hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                databaseDataContext db = new databaseDataContext();
                dgvPB.DataSource = db.PHONGBANs.Where(p => p.MaPhg == selectedId).ToList();

                databaseDataContext db1 = new databaseDataContext();
                dgvNVfromPB.DataSource = db1.NHANVIENs.Where(p => p.MaPhong == selectedId).ToList();

            }
        }

        private void thêmNhânViênVàoPbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedId = txtMaPBCanTim.Text;

            if (string.IsNullOrWhiteSpace(selectedId))
            {
                MessageBox.Show("Vui lòng nhập mã phòng ban hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            databaseDataContext db = new databaseDataContext();
            PHONGBAN selectedDepartment = db.PHONGBANs.SingleOrDefault(p => p.MaPhg == selectedId);

            if (selectedDepartment == null)
            {
                MessageBox.Show("Không tìm thấy phòng ban.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string mtp = selectedDepartment.MaTrgPhong;

            ThemNV themNVForm = new ThemNV();
            themNVForm.FormClosed += (s, args) => this.Show();
            this.Hide();
            themNVForm.ShowDialog();

            if (themNVForm.kiemtra())
            {
                try
                {
                    NHANVIEN newEmployee = new NHANVIEN
                    {
                        MaNV = themNVForm.getMaNV(),
                        HoTenNV = themNVForm.getTenNV(),
                        dchi = themNVForm.getDC(),
                        GioiTinh = themNVForm.getGT(),
                        NgSinh = DateTime.Parse(themNVForm.getNS()),
                        MaPhong = selectedId,
                        MaTrgPhong = mtp,
                        MucLuong = int.Parse(themNVForm.getLuong())
                    };

                    db.NHANVIENs.InsertOnSubmit(newEmployee);
                    db.SubmitChanges();
                    loadDuLieu();
                    MessageBox.Show("Thêm nhân viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi thêm nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại. Vui lòng kiểm tra các thuộc tính!.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvNVfromPB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = e.RowIndex;

            if (id < 0 || id >= dgvNVfromPB.Rows.Count)
            {
                return;
            }

            hienthiPB(id);
        }
        private void xóaNhânViênKhỏiPbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedId = txtMaPBCanTim.Text;

            if (string.IsNullOrWhiteSpace(selectedId))
            {
                MessageBox.Show("Vui lòng nhập mã phòng ban hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            databaseDataContext db = new databaseDataContext();
            PHONGBAN selectedDepartment = db.PHONGBANs.SingleOrDefault(p => p.MaPhg == selectedId);

            if (selectedDepartment == null)
            {
                MessageBox.Show("Không tìm thấy mã phòng ban.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maNhanVienCanXoa = txtMaNVCanTim.Text;

            if (string.IsNullOrWhiteSpace(maNhanVienCanXoa))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NHANVIEN employeeToDelete = db.NHANVIENs.SingleOrDefault(nv => nv.MaNV == maNhanVienCanXoa && nv.MaPhong == selectedId);

            if (employeeToDelete == null)
            {
                MessageBox.Show("Không tìm thấy mã nhân viên trong phòng ban được chọn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                db.NHANVIENs.DeleteOnSubmit(employeeToDelete);
                db.SubmitChanges();
                loadDuLieu();
                MessageBox.Show("Xóa nhân viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xóa nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void quayLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}