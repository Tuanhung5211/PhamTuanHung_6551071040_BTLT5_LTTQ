using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bai4_Chuong4
{
    public partial class frmLichHen : Form
    {
        private List<string> danhSachLichHen = new List<string>();
        public frmLichHen()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnDatLich_Click(object sender, EventArgs e)
        {
            string tenBN = txtTenBN.Text.Trim();
            string ngayGio = dtpNgayGio.Value.ToString("dd/MM/yyyy HH:mm");

            if (string.IsNullOrEmpty(tenBN))
            {
                MessageBox.Show("Vui lòng nhập tên bệnh nhân!");
                return;
            }

            string thongTin = $"Bệnh nhân: {tenBN} - Hẹn lúc: {ngayGio}";

            danhSachLichHen.Add(thongTin);
            lstLichHen.Items.Add(thongTin);

            txtTenBN.Clear();
            txtTenBN.Focus();
        }
    }
}
