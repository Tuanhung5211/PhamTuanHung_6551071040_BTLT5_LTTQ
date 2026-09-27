using System;
using System.Drawing;
using System.Windows.Forms;

namespace CafeStatusDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Thiết lập Timer
            timer1.Interval = 1000;
            timer1.Enabled = true;

            // Cập nhật trạng thái ngay khi mở chương trình
            CapNhatTrangThai();
        }

        // Timer chạy mỗi 1 giây
        private void timer1_Tick(object sender, EventArgs e)
        {
            CapNhatTrangThai();
        }

        // Cập nhật giờ và trạng thái quán
        private void CapNhatTrangThai()
        {
            // Hiển thị giờ hiện tại
            lblGioHienTai.Text = DateTime.Now.ToString("HH:mm:ss");

            // Lấy giờ hiện tại
            int gio = DateTime.Now.Hour;

            // Kiểm tra thời gian mở cửa: từ 06:00 đến trước 22:00
            if (gio >= 6 && gio < 22)
            {
                lblTrangThai.Text = "Đang mở cửa";
                lblTrangThai.ForeColor = Color.Green;
            }
            else
            {
                lblTrangThai.Text = "Đã đóng cửa";
                lblTrangThai.ForeColor = Color.Red;
            }
        }

        // Xử lý menu Đổi màu nền
        private void menuDoiMauNen_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    this.BackColor = colorDialog.Color;
                }
            }
        }

        // Xử lý menu Thoát
        private void menuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
