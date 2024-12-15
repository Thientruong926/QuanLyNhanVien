using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace QuanLyNhanVien
{
    public partial class frmNV : Form
    {
        public frmNV()
        {
            InitializeComponent();
        }

        private void frmNV_Load(object sender, EventArgs e)
        {
            loadDuLieu();
        }

        private void loadDuLieu()
        {
            dgvNV.AutoGenerateColumns = false;
            databaseDataContext db = new databaseDataContext();
            dgvNV.DataSource = db.NHANVIENs.OrderBy(p => p.MaNV);
            if (db.PHONGBANs.ToList().Count > 0)
            {
                hienthi(0);
            }
            try
            {
                NGUOIDUNG nd = db.NGUOIDUNGs.Single(p => p.Username == frmMain.infor);
                if (nd != null)
                {
                    if (nd.LeaveID == 2)
                    {
                        selectAllToolStripMenuItem.Enabled = false;
                        xóaNhânViênToolStripMenuItem.Enabled = false;
                        sửaNhânViênToolStripMenuItem.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi phân quyền người dùng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = e.RowIndex;

            if (id < 0)
            {
                return;
            }
            hienthi(id);
        }



        private void hienthi(int id)
        {
            databaseDataContext db = new databaseDataContext();
            string manv = dgvNV.Rows[id].Cells[0].Value.ToString();
            NHANVIEN nv = db.NHANVIENs.Where(p => p.MaNV == manv).SingleOrDefault();
            if (nv != null)
            {
                txtTenNV.Text = nv.HoTenNV.ToString();
                txtDiaChi.Text = nv.dchi.ToString();
                txtGioiTinh.Text = nv.GioiTinh.ToString();
                txtMaNV.Text = nv.MaNV.ToString();
                txtNS.Text = nv.NgSinh.ToString();
                txtPhongCT.Text = nv.MaPhong.ToString();

            }
        }

        //chua rangbuoc due lieu them 
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ThemNV themNVForm = new ThemNV();
            themNVForm.FormClosed += (s, args) => this.Show();
            this.Hide();
            themNVForm.ShowDialog();

            if (themNVForm.kiemtra())
            {
                try
                {

                    databaseDataContext db = new databaseDataContext();
                    NHANVIEN newEmployee = new NHANVIEN
                    {
                        MaNV = themNVForm.getMaNV(),
                        HoTenNV = themNVForm.getTenNV(),
                        dchi = themNVForm.getDC(),
                        GioiTinh = themNVForm.getGT(),
                        NgSinh = DateTime.Parse(themNVForm.getNS()),
                        MaPhong = themNVForm.getMaPCT(),
                        MaTrgPhong = themNVForm.getMaTP(),
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
                MessageBox.Show("Thêm nhân viên thất bại. Vui lòng kiểm tra các thuộc tính.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //chua xoa duoc nhan vien do nhan vien co lien ket voi bang khac
        private void xóaNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            databaseDataContext db = new databaseDataContext();
            try
            {
                string manv = txtMaNVCanTim.Text;

                if (string.IsNullOrWhiteSpace(manv))
                {
                    MessageBox.Show("Vui lòng nhập mã nhân viên hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                NHANVIEN nv = db.NHANVIENs.Where(p => p.MaNV == manv).SingleOrDefault();
                if (nv != null)
                {
                    db.NHANVIENs.DeleteOnSubmit(nv);
                    db.SubmitChanges();
                    loadDuLieu();
                    MessageBox.Show("Xóa nhân viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên, vui lòng kiểm tra lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể xóa nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //chua rangbuoc due lieu sua 
        private void sửaNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedEmployeeId = txtMaNVCanTim.Text;

            if (string.IsNullOrWhiteSpace(selectedEmployeeId))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SuaNV editForm = new SuaNV(selectedEmployeeId);
            editForm.FormClosed += (s, args) => this.Show();
            this.Hide();
            editForm.ShowDialog();
            loadDuLieu();

        }

        //done
        private void tìmKiếmNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedEmployeeId = txtMaNVCanTim.Text;
            if (string.IsNullOrWhiteSpace(selectedEmployeeId))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                databaseDataContext db = new databaseDataContext();
                dgvNV.DataSource = db.NHANVIENs.Where(p => p.MaNV == selectedEmployeeId).ToList();
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
            this.Close();
        }

        private void quayLạiToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
