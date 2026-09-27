namespace bai2_Chuong5
{
    public partial class Form1 : Form
    {
        private bool isDrawing = false;
        private Point previousPoint;
        public Form1()
        {
            InitializeComponent();
            lblTrangThai.Text = "Sẵn sàng";
            lblViTri.Text = "X: 0, Y: 0";
        }

        private void pnlCanvas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                previousPoint = e.Location; // Lưu tọa độ bắt đầu
                lblTrangThai.Text = "Đang vẽ..."; // Cập nhật trạng thái
            }
        }

        private void pnlCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            lblViTri.Text = $"X: {e.X}, Y: {e.Y}";

            // Nếu đang giữ chuột trái thì thực hiện vẽ
            if (isDrawing && e.Button == MouseButtons.Left)
            {
                using (Graphics g = pnlCanvas.CreateGraphics())
                {
                    // Tạo bút vẽ màu đen, độ dày 2, bo tròn đầu cọ cho mượt
                    using (Pen pen = new Pen(Color.Black, 2f))
                    {
                        pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                        pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

                        // Vẽ một đoạn thẳng từ điểm cũ tới điểm hiện tại của chuột
                        g.DrawLine(pen, previousPoint, e.Location);
                    }
                }
                // Cập nhật lại điểm trước đó thành điểm hiện tại để nối tiếp nét vẽ
                previousPoint = e.Location;
            }
        }

        private void pnlCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = false;
                lblTrangThai.Text = "Sẵn sàng"; // Đổi lại trạng thái
            }
        }

        private void pnlCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Invalidate() sẽ yêu cầu Panel vẽ lại, qua đó xóa toàn bộ các 
                // đối tượng Graphics tạm thời đã vẽ lên bề mặt trước đó.
                pnlCanvas.Invalidate();
            }
        }
    }
}
