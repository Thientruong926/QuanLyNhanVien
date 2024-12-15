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
    public partial class SuaPB : Form
    {
        public SuaPB(string mphg)
        {
            InitializeComponent();
            databaseDataContext db = new databaseDataContext();
            PHONGBAN pb = db.PHONGBANs.Where(p => p.MaPhg == mphg).SingleOrDefault();

            if (pb != null)
            {
                txtMaPhg.Text = pb.MaPhg;
                txtTenPhg.Text = pb.TenPhg;
                txtMTP.Text = pb.MaTrgPhong;
                txtTTP.Text = pb.TenTrgPhong;
            }
            else
            {
                MessageBox.Show("Department not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }


        public string getMaPhg() => txtMaPhg.Text;

        public string getTenPhg() => txtTenPhg.Text;

        public string getMTP() => txtMTP.Text;

        public string getTTP() => txtTTP.Text;




        public bool kiemtra()
        {
            Console.WriteLine($"MaNV: {txtMaPhg.Text}, TenNV: {txtTenPhg.Text}, NS: {txtMTP.Text}, GT: {txtTTP.Text}");

            if (string.IsNullOrWhiteSpace(txtMaPhg.Text) || string.IsNullOrWhiteSpace(txtTenPhg.Text) || string.IsNullOrWhiteSpace(txtMTP.Text) || string.IsNullOrWhiteSpace(txtTTP.Text))
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
                    string maphg = txtMaPhg.Text;


                    PHONGBAN pb = db.PHONGBANs.Where(p => p.MaPhg == maphg).SingleOrDefault();

                    if (pb != null)
                    {
                        pb.MaPhg = txtMaPhg.Text;
                        pb.TenPhg = txtTenPhg.Text;
                        pb.MaTrgPhong = txtMTP.Text;
                        pb.TenTrgPhong = txtTTP.Text;

                        db.SubmitChanges();
                        MessageBox.Show("Department updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Department not found, please check the ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating Department: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid information. Please check all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
