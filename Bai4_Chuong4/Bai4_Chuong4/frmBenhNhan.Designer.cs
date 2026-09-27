namespace Bai4_Chuong4
{
    partial class frmBenhNhan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nudTuoi = new NumericUpDown();
            txtHoTen = new TextBox();
            txtTrieuChung = new TextBox();
            btnLuuTam = new Button();
            lstBenhNhan = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudTuoi).BeginInit();
            SuspendLayout();
            // 
            // nudTuoi
            // 
            nudTuoi.Location = new Point(306, 171);
            nudTuoi.Name = "nudTuoi";
            nudTuoi.Size = new Size(150, 27);
            nudTuoi.TabIndex = 0;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(306, 45);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(229, 27);
            txtHoTen.TabIndex = 1;
            // 
            // txtTrieuChung
            // 
            txtTrieuChung.Location = new Point(306, 102);
            txtTrieuChung.Name = "txtTrieuChung";
            txtTrieuChung.Size = new Size(229, 27);
            txtTrieuChung.TabIndex = 2;
            // 
            // btnLuuTam
            // 
            btnLuuTam.Location = new Point(320, 395);
            btnLuuTam.Name = "btnLuuTam";
            btnLuuTam.Size = new Size(94, 29);
            btnLuuTam.TabIndex = 3;
            btnLuuTam.Text = "Lưu tạm";
            btnLuuTam.UseVisualStyleBackColor = true;
            btnLuuTam.Click += btnLuuTam_Click;
            // 
            // lstBenhNhan
            // 
            lstBenhNhan.FormattingEnabled = true;
            lstBenhNhan.Location = new Point(320, 234);
            lstBenhNhan.Name = "lstBenhNhan";
            lstBenhNhan.Size = new Size(302, 144);
            lstBenhNhan.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(240, 48);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 5;
            label1.Text = "Họ Tên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(212, 109);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 6;
            label2.Text = "Triệu Chứng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(258, 171);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 7;
            label3.Text = "Tuổi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(164, 234);
            label4.Name = "label4";
            label4.Size = new Size(153, 20);
            label4.TabIndex = 8;
            label4.Text = "Danh sách bệnh nhân:";
            // 
            // frmBenhNhan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstBenhNhan);
            Controls.Add(btnLuuTam);
            Controls.Add(txtTrieuChung);
            Controls.Add(txtHoTen);
            Controls.Add(nudTuoi);
            Name = "frmBenhNhan";
            Text = "frmBenhNhan";
            ((System.ComponentModel.ISupportInitialize)nudTuoi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nudTuoi;
        private TextBox txtHoTen;
        private TextBox txtTrieuChung;
        private Button btnLuuTam;
        private ListBox lstBenhNhan;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}