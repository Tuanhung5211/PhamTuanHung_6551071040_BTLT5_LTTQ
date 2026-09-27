using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bai4_Chuong4
{
    public partial class frmBenhNhan : Form
    {
        private List<string> danhSachBenhNhan = new List<string>();
        public frmBenhNhan()
        {
            InitializeComponent();
        }

        private void btnLuuTam_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();
            string tuoi = nudTuoi.Value.ToString();
            string trieuChung = txtTrieuChung.Text.Trim();

            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(trieuChung))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            // Định dạng thông tin
            string thongTin = $"{hoTen} - {tuoi} tuổi - Triệu chứng: {trieuChung}";

            // Thêm vào List và ListBox
            danhSachBenhNhan.Add(thongTin);
            lstBenhNhan.Items.Add(thongTin);

            // Xóa form sau khi lưu
            txtHoTen.Clear();
            nudTuoi.Value = 0;
            txtTrieuChung.Clear();
            txtHoTen.Focus();
        }
    }
}
