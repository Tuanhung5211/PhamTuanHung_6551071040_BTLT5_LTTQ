namespace Bai3_Chuong4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtCongViecMoi != null && txtCongViecMoi.Text != "")
            {
                lstCongViec.Items.Add(txtCongViecMoi.Text);
                txtCongViecMoi.Clear();
            }
        }
        private void mnuHoanThanh_Click(object sender, EventArgs e)
        {
            if (lstCongViec.SelectedItem != null)
            {
                string congViec = lstCongViec.SelectedItem.ToString();

                if (!congViec.StartsWith("[Hoàn thành] "))
                {
                    int viTri = lstCongViec.SelectedIndex;

                    lstCongViec.Items[viTri] =
                        "[Hoàn thành] " + congViec;
                }
            }
        }

        private void mnuXoa_Click(object sender, EventArgs e)
        {
            if (lstCongViec.SelectedItem != null)
            {
                lstCongViec.Items.Remove(lstCongViec.SelectedItem);
            }
        }

        //Xóa tất cả
        private void mnuXoaTatCa_Click(object sender, EventArgs e)
        {
            lstCongViec.Items.Clear();
        }
    }
}
