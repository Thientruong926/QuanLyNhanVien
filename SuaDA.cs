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
    public partial class SuaDA : Form
    {
        public SuaDA(string mda)
        {
            InitializeComponent();
            databaseDataContext db = new databaseDataContext();
            DEAN da = db.DEANs.Where(p => p.MaDeAn == mda).SingleOrDefault();

            if (da != null)
            {
                txtMaDA.Text = da.MaDeAn;
                txtTenDA.Text = da.TenDeAn;
                txtStart.Text = da.Ng_BatDauDeAn.ToString();
                txtEnd.Text = da.Ng_KetThucDean.ToString();
            }
            else
            {
                MessageBox.Show("Department not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
        public string getMaDA() => txtMaDA.Text;

        public string getTenDA() => txtTenDA.Text;

        public string getStart() => txtStart.Text;

        public string getEnd() => txtEnd.Text;
        public bool kiemtra()
        {
            Console.WriteLine($"MaNV: {txtMaDA.Text}, TenNV: {txtTenDA.Text}, NS: {txtStart.Text}, GT: {txtEnd.Text}");

            if (string.IsNullOrWhiteSpace(txtMaDA.Text) || string.IsNullOrWhiteSpace(txtTenDA.Text) || string.IsNullOrWhiteSpace(txtStart.Text) || string.IsNullOrWhiteSpace(txtEnd.Text))
            {
                return false;
            }

            return true;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (kiemtra())
            {
                try
                {
                    databaseDataContext db = new databaseDataContext();
                    string mada = txtMaDA.Text;


                    DEAN pb = db.DEANs.Where(p => p.MaDeAn == mada).SingleOrDefault();

                    if (pb != null)
                    {
                        pb.MaDeAn = txtMaDA.Text;
                        pb.TenDeAn = txtTenDA.Text;
                        pb.Ng_BatDauDeAn = DateTime.Parse(txtStart.Text);
                        pb.Ng_KetThucDean = DateTime.Parse(txtEnd.Text);

                        db.SubmitChanges();
                        MessageBox.Show("DeAn updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("DeAn not found, please check the ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating DeAn: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid information. Please check all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
