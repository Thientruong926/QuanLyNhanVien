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
    public partial class SuaNV : Form
    {
        public SuaNV(string mnv)
        {
            InitializeComponent();

            databaseDataContext db = new databaseDataContext();
            NHANVIEN nv = db.NHANVIENs.Where(p => p.MaNV == mnv).SingleOrDefault();

            if (nv != null)
            {
                txtMaNV.Text = nv.MaNV;
                txtMaNV.Enabled = false;
                txtLuong.Text = nv.MucLuong.ToString();
                txtLuong.Enabled = false;
                txtTenNV.Text = nv.HoTenNV;
                txtDchi.Text = nv.dchi;
                txtGT.Text = nv.GioiTinh;
                txtMaPhongCT.Text = nv.MaPhong;
                txtMaTrgPhong.Text = nv.MaTrgPhong;
                txtNS.Text = nv.NgSinh.ToString();
            }
            else
            {
                MessageBox.Show("Employee not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }



        private void SuaNV_Load(object sender, EventArgs e)
        {
        }

        public string getTenNV() => txtTenNV.Text;

        public string getNS() => txtNS.Text;

        public string getGT() => txtGT.Text;

        public string getDC() => txtDchi.Text;

        public string getMaPCT() => txtMaPhongCT.Text;

        public string getMaTP() => txtMaTrgPhong.Text;


        public bool kiemtra()
        {
            Console.WriteLine($"MaNV: {txtMaNV.Text}, TenNV: {txtTenNV.Text}, NS: {txtNS.Text}, GT: {txtGT.Text}, DC: {txtDchi.Text}");

            if (string.IsNullOrWhiteSpace(txtMaNV.Text) || string.IsNullOrWhiteSpace(txtTenNV.Text) || string.IsNullOrWhiteSpace(txtNS.Text) || string.IsNullOrWhiteSpace(txtGT.Text) || string.IsNullOrWhiteSpace(txtDchi.Text))
            {
                return false;
            }

            return true;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (kiemtra())
            {
                try
                {
                    databaseDataContext db = new databaseDataContext();
                    string manv = txtMaNV.Text;


                    NHANVIEN nv = db.NHANVIENs.Where(p => p.MaNV == manv).SingleOrDefault();

                    if (nv != null)
                    {

                        nv.HoTenNV = txtTenNV.Text;
                        nv.dchi = txtDchi.Text;
                        nv.GioiTinh = txtGT.Text;
                        nv.MaPhong = txtMaPhongCT.Text;
                        nv.MaTrgPhong = txtMaTrgPhong.Text;
                        nv.NgSinh = DateTime.Parse(txtNS.Text);
                        db.SubmitChanges();
                        MessageBox.Show("Employee updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Employee not found, please check the ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating employee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid information. Please check all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}

