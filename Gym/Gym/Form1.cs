using System;
using System.Windows.Forms;

namespace Gym
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if(txtHoTen.Text == "" || txtSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Họ tên và Số điện thoại");
            }    
            else
            {
                MessageBox.Show("Họ tên: " + txtHoTen.Text + "\nSố điện thoại: " + txtSDT.Text + "\nSố buổi/ tuần: " + numSoBuoiTuan.Value.ToString());
            }    
        }
    }
}
