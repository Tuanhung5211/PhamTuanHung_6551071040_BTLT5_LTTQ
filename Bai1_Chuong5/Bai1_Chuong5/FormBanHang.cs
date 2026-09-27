namespace Bai1_Chuong5
{
    public partial class FormBanHang : Form
    {
        public FormBanHang()
        {
            InitializeComponent();
            txtSoLuong.KeyPress += new KeyPressEventHandler(ChiNhapSo_KeyPress);
            txtDonGia.KeyPress += new KeyPressEventHandler(ChiNhapSo_KeyPress);
        }

        private void ChiNhapSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra nếu ký tự không phải là số (Digit) và không phải phím điều khiển (như Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Từ chối ký tự
            }
        }

        private void FormBanHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                // Nhấn F2 -> Kích hoạt nút Thêm
                btnThem.PerformClick();
            }
            else if (e.KeyCode == Keys.F5)
            {
                // Nhấn F5 -> Kích hoạt nút Xóa trắng
                btnXoaTrang.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                // Nhấn Escape -> Hỏi xác nhận thoát
                DialogResult rs = MessageBox.Show("Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void FormBanHang_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaSP.Text) && !string.IsNullOrEmpty(txtSoLuong.Text) && !string.IsNullOrEmpty(txtDonGia.Text))
            {
                string ketQua = $"{txtMaSP.Text} | {txtSoLuong.Text} | {txtDonGia.Text}";
                lstKetQua.Items.Add(ketQua);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            txtMaSP.Clear();
            txtSoLuong.Clear();
            txtDonGia.Clear();

            // Focus về txtMaSP
            txtMaSP.Focus();
        }

        private void btnXoaTrang_Click_1(object sender, EventArgs e)
        {
            txtMaSP.Clear();
            txtSoLuong.Clear();
            txtDonGia.Clear();

            // Focus về txtMaSP
            txtMaSP.Focus();
        }

        private void FormBanHang_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                btnThem.PerformClick();
            }

            else if (e.KeyCode == Keys.Escape)
            {
                DialogResult luaChon = MessageBox.Show(
                    "Bạn có muốn thoát?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (luaChon == DialogResult.Yes)
                {
                    this.Close();
                }
                else if (e.KeyCode == Keys.F5)
                {
                    btnXoaTrang.PerformClick();
                }
            }
        }
    }
}
