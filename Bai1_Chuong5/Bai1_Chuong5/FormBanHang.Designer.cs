namespace Bai1_Chuong5
{
    partial class FormBanHang
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtMaSP = new TextBox();
            txtSoLuong = new TextBox();
            txtDonGia = new TextBox();
            btnXoaTrang = new Button();
            btnThem = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lstKetQua = new ListBox();
            SuspendLayout();
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(344, 80);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(253, 27);
            txtMaSP.TabIndex = 0;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(344, 142);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(253, 27);
            txtSoLuong.TabIndex = 1;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(344, 202);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(253, 27);
            txtDonGia.TabIndex = 2;
            // 
            // btnXoaTrang
            // 
            btnXoaTrang.Location = new Point(434, 250);
            btnXoaTrang.Name = "btnXoaTrang";
            btnXoaTrang.Size = new Size(94, 29);
            btnXoaTrang.TabIndex = 3;
            btnXoaTrang.Text = "Xóa Trang";
            btnXoaTrang.UseVisualStyleBackColor = true;
            btnXoaTrang.Click += btnXoaTrang_Click_1;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(277, 250);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(207, 87);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 5;
            label1.Text = "Mã Sản Phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(207, 149);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 6;
            label2.Text = "Số Lượng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(216, 209);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 7;
            label3.Text = "Đơn Giá";
            // 
            // lstKetQua
            // 
            lstKetQua.FormattingEnabled = true;
            lstKetQua.Location = new Point(0, 296);
            lstKetQua.Name = "lstKetQua";
            lstKetQua.Size = new Size(799, 164);
            lstKetQua.TabIndex = 8;
            // 
            // FormBanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstKetQua);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnThem);
            Controls.Add(btnXoaTrang);
            Controls.Add(txtDonGia);
            Controls.Add(txtSoLuong);
            Controls.Add(txtMaSP);
            KeyPreview = true;
            Name = "FormBanHang";
            Text = "Form1";
            Load += FormBanHang_Load;
            KeyDown += FormBanHang_KeyDown_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaSP;
        private TextBox txtSoLuong;
        private TextBox txtDonGia;
        private Button btnXoaTrang;
        private Button btnThem;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox lstKetQua;
    }
}
