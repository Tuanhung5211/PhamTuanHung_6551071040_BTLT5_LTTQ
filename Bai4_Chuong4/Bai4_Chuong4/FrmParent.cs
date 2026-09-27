namespace Bai4_Chuong4
{
    public partial class FrmParent : Form
    {
        public FrmParent()
        {
            InitializeComponent();
        }

        private void thôngTinBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng HOÀN TOÀN MỚI mỗi lần click
            frmBenhNhan fBenhNhan = new frmBenhNhan();

            // Gán MdiParent
            fBenhNhan.MdiParent = this;

            // Đặt tên Text có thêm thời gian để dễ phân biệt trong menu Cửa sổ
            fBenhNhan.Text = "Bệnh nhân - " + DateTime.Now.ToString("HH:mm:ss");

            fBenhNhan.Show();
        }

        private void đặtLịchHẹnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLichHen fLichHen = new frmLichHen();
            fLichHen.MdiParent = this;
            fLichHen.Text = "Lịch hẹn - " + DateTime.Now.ToString("HH:mm:ss");
            fLichHen.Show();
        }

        private void đặtLichHẹnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLichHen fLichHen = new frmLichHen();
            fLichHen.MdiParent = this;
            fLichHen.Text = "Lịch hẹn - " + DateTime.Now.ToString("HH:mm:ss");
            fLichHen.Show();
        }
    }
}
