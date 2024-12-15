using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanVien
{
    public partial class frmDA : Form
    {
        private databaseDataContext _db;

        public frmDA()
        {
            InitializeComponent();
            _db = new databaseDataContext();

        }


        private void frmDA_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDuLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgvDA.CellClick += dgvDeAn_CellClick;
        }

        private void LoadDuLieu()
        {
            databaseDataContext db = new databaseDataContext();
            dgvDA.AutoGenerateColumns = false;
            dgvNVfromDA.AutoGenerateColumns = false;

            var danhSachDeAn = db.DEANs.OrderBy(p => p.MaDeAn).ToList();
            dgvDA.DataSource = danhSachDeAn;

            if (danhSachDeAn.Count > 0)
            {
                HienThiDuAn(0);
            }
            try
            {
                NGUOIDUNG nd = db.NGUOIDUNGs.Single(p => p.Username == frmMain.infor);
                if (nd != null)
                {
                    if (nd.LeaveID == 1)
                    {
                        selectAllToolStripMenuItem.Enabled = false;
                        sửaĐềÁnToolStripMenuItem.Enabled = false;
                        xóaĐềÁnToolStripMenuItem.Enabled = false;
                    }
                    if (nd.LeaveID == 2)
                    {
                        selectAllToolStripMenuItem.Enabled = false;
                        sửaĐềÁnToolStripMenuItem.Enabled = false;
                        xóaĐềÁnToolStripMenuItem.Enabled = false;
                        thêmNhânViênVàoĐềAnToolStripMenuItem.Enabled = false;
                        xóaNhânViênKhỏiĐềÁnToolStripMenuItem.Enabled=false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi phân quyền người dùng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HienThiDuAn(int index)
        {
            if (index < 0 || index >= dgvDA.Rows.Count) return;

            // Lấy mã đề án từ DataGridView
            string maDeAn = dgvDA.Rows[index].Cells[0].Value?.ToString();
            if (string.IsNullOrEmpty(maDeAn)) return;

            using (databaseDataContext context = new databaseDataContext())
            {
                // Truy vấn lấy thông tin nhân viên tham gia đề án
                var nhanVienPhanCong = (from pc in context.PHANCONGs
                                        join nv in context.NHANVIENs on pc.MaNV equals nv.MaNV
                                        where pc.MaDeAn == maDeAn
                                        select nv).ToList();

                if (nhanVienPhanCong.Count > 0)
                {
                    dgvNVfromDA.DataSource = nhanVienPhanCong;
                }
                else
                {
                    dgvNVfromDA.DataSource = null;

                }
            }

        }


        private void dgvDeAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex < 0 || rowIndex >= dgvDA.Rows.Count) return;

            HienThiDuAn(rowIndex);
        }

        //Chua kiem tra mada nhap vao
        private void xóaĐềÁnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // xoa de an
            if (dgvDA.CurrentRow != null)
            {
                string maDeAn = dgvDA.CurrentRow.Cells[0].Value?.ToString();

                if (string.IsNullOrEmpty(maDeAn))
                {
                    MessageBox.Show("Không tìm thấy mã đề án để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult dialogResult = MessageBox.Show(
                    "Xóa đề án này sẽ xóa toàn bộ dữ liệu liên quan trong bảng phân công và đề án. Bạn có chắc chắn muốn tiếp tục?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        using (databaseDataContext db = new databaseDataContext())
                        {
                            // Xóa các phân công liên quan đến đề án
                            var phanCongLienQuan = db.PHANCONGs.Where(pc => pc.MaDeAn == maDeAn).ToList();
                            if (phanCongLienQuan.Any())
                            {
                                db.PHANCONGs.DeleteAllOnSubmit(phanCongLienQuan);
                            }

                            // Xóa đề án
                            var deAn = db.DEANs.SingleOrDefault(d => d.MaDeAn == maDeAn);
                            if (deAn != null)
                            {
                                db.DEANs.DeleteOnSubmit(deAn);
                            }

                            // Lưu thay đổi vào cơ sở dữ liệu
                            db.SubmitChanges();

                            // Tải lại dữ liệu sau khi xóa
                            LoadDuLieu();

                            MessageBox.Show("Đề án đã được xóa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi xóa đề án: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một đề án để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void sửaĐềÁnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // sua de an
            string selectedId = txtMaDACanTim.Text;

            if (string.IsNullOrWhiteSpace(selectedId))
            {
                MessageBox.Show("Vui lòng nhập mã đề án hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SuaDA editForm = new SuaDA(selectedId);
            editForm.FormClosed += (s, args) => this.Show();
            this.Hide();
            editForm.ShowDialog();
            LoadDuLieu();
        }

        private void tìmKiếmĐềÁnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // tim kiem de an
            string selectedId = txtMaDACanTim.Text;
            if (string.IsNullOrWhiteSpace(selectedId))
            {
                MessageBox.Show("Vui lòng nhập mã đề án hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                databaseDataContext db = new databaseDataContext();
                dgvDA.DataSource = db.DEANs.Where(p => p.MaDeAn == selectedId).ToList();

                using (databaseDataContext context = new databaseDataContext())
                {
                    // Truy vấn lấy thông tin nhân viên tham gia đề án
                    var nhanVienPhanCong = (from pc in context.PHANCONGs
                                            join nv in context.NHANVIENs on pc.MaNV equals nv.MaNV
                                            where pc.MaDeAn == selectedId
                                            select nv).ToList();

                    if (nhanVienPhanCong.Count > 0)
                    {
                        dgvNVfromDA.DataSource = nhanVienPhanCong;
                    }
                    else
                    {
                        dgvNVfromDA.DataSource = null;

                    }
                }

            }
        }

        private void thêmNhânViênVàoĐềAnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Lấy mã đề án đang chọn
            if (txtMaDACanTim == null)
            {
                MessageBox.Show("Vui lòng chọn một đề án để thêm nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maDeAn = txtMaDACanTim.Text;
            if (string.IsNullOrEmpty(maDeAn))
            {
                MessageBox.Show("Không tìm thấy mã đề án để thêm nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Hiển thị form thêm nhân viên
            ThemNV themNVForm = new ThemNV();
            themNVForm.FormClosed += (s, args) => this.Show();
            this.Hide();
            themNVForm.ShowDialog();

            // Nếu form thêm nhân viên trả về trạng thái hợp lệ
            if (themNVForm.kiemtra())
            {
                try
                {
                    using (databaseDataContext db = new databaseDataContext())
                    {
                        // Thêm nhân viên mới vào bảng NHANVIEN
                        NHANVIEN newEmployee = new NHANVIEN
                        {
                            MaNV = themNVForm.getMaNV(),
                            HoTenNV = themNVForm.getTenNV(),
                            dchi = themNVForm.getDC(),
                            GioiTinh = themNVForm.getGT(),
                            NgSinh = DateTime.Parse(themNVForm.getNS()),
                            MaPhong = themNVForm.getMaPCT(),
                            MucLuong = int.Parse(themNVForm.getLuong())
                        };
                        db.NHANVIENs.InsertOnSubmit(newEmployee);

                        // Thêm bản ghi vào bảng PHANCONG để liên kết nhân viên với đề án
                        PHANCONG newPhanCong = new PHANCONG
                        {
                            MaNV = newEmployee.MaNV,
                            MaDeAn = maDeAn,

                        };
                        db.PHANCONGs.InsertOnSubmit(newPhanCong);

                        // Lưu thay đổi vào cơ sở dữ liệu
                        db.SubmitChanges();

                        // Tải lại dữ liệu để hiển thị nhân viên mới trong DataGridView
                        HienThiDuAn(dgvDA.CurrentRow.Index);

                        MessageBox.Show("Nhân viên đã được thêm vào đề án thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi thêm nhân viên vào đề án: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại. Vui lòng kiểm tra thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void xóaNhânViênKhỏiĐềÁnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Kiểm tra các giá trị đầu vào
            if (string.IsNullOrEmpty(txtMaDACanTim.Text) || string.IsNullOrEmpty(lbl1.Text))
            {
                MessageBox.Show("Vui lòng cung cấp mã đề án và mã nhân viên để thực hiện xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy mã đề án và mã nhân viên cần xóa
            string maDeAn = txtMaDACanTim.Text.Trim();
            string maNhanVien = txtMaNVCanTim.Text.Trim();

            // Xác nhận từ người dùng trước khi xóa
            DialogResult dialogResult = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa nhân viên có mã {maNhanVien} khỏi đề án {maDeAn}?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    using (databaseDataContext db = new databaseDataContext())
                    {
                        // Bước 1: Truy vấn phân công cần xóa
                        var phanCong = db.PHANCONGs.SingleOrDefault(pc => pc.MaNV == maNhanVien && pc.MaDeAn == maDeAn);

                        if (phanCong == null)
                        {
                            MessageBox.Show("Không tìm thấy phân công cần xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Bước 2: Xóa phân công khỏi bảng PHANCONGs
                        db.PHANCONGs.DeleteOnSubmit(phanCong);

                        // Bước 3: Xóa nhân viên khỏi bảng NHANVIENs (nếu cần thiết)
                        var nhanVien = db.NHANVIENs.SingleOrDefault(nv => nv.MaNV == maNhanVien);
                        if (nhanVien != null)
                        {
                            db.NHANVIENs.DeleteOnSubmit(nhanVien);
                        }

                        // Lưu thay đổi vào cơ sở dữ liệu
                        db.SubmitChanges();

                        // Bước 4: Cập nhật lại DataGridView
                        HienThiDuAn(dgvDA.CurrentRow.Index);

                        MessageBox.Show("Nhân viên đã được xóa khỏi đề án thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //them de an 
            ThemDA themDAForm = new ThemDA();
            themDAForm.FormClosed += (s, args) => this.Show();
            this.Hide();
            themDAForm.ShowDialog();

            if (themDAForm.kiemtra())
            {
                try
                {

                    databaseDataContext db = new databaseDataContext();
                    DEAN newDeAn = new DEAN
                    {
                        MaDeAn = themDAForm.getMaDA(),
                        TenDeAn = themDAForm.getTenDA(),
                        Ng_BatDauDeAn = DateTime.Parse(themDAForm.getStart()),
                        Ng_KetThucDean = DateTime.Parse(themDAForm.getEnd())
                    };

                    db.DEANs.InsertOnSubmit(newDeAn);
                    db.SubmitChanges();
                    LoadDuLieu();
                    MessageBox.Show("Thêm đề án thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi thêm đề án: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Thêm đề án thất bại! Vui lòng kiểm tra các thuộc tính.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void quayLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
            this.Close();
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
    }



}
