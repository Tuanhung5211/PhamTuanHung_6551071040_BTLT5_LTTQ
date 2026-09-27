namespace Bai4_Chuong4
{
    partial class frmLichHen
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
            components = new System.ComponentModel.Container();
            dtpNgayGio = new DateTimePicker();
            btnDatLich = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            txtTenBN = new TextBox();
            lstLichHen = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // dtpNgayGio
            // 
            dtpNgayGio.Location = new Point(389, 145);
            dtpNgayGio.Name = "dtpNgayGio";
            dtpNgayGio.Size = new Size(250, 27);
            dtpNgayGio.TabIndex = 0;
            // 
            // btnDatLich
            // 
            btnDatLich.Location = new Point(389, 367);
            btnDatLich.Name = "btnDatLich";
            btnDatLich.Size = new Size(94, 29);
            btnDatLich.TabIndex = 1;
            btnDatLich.Text = "Đặt lịch";
            btnDatLich.UseVisualStyleBackColor = true;
            btnDatLich.Click += btnDatLich_Click;
            // 
            // txtTenBN
            // 
            txtTenBN.Location = new Point(389, 99);
            txtTenBN.Name = "txtTenBN";
            txtTenBN.Size = new Size(250, 27);
            txtTenBN.TabIndex = 2;
            // 
            // lstLichHen
            // 
            lstLichHen.FormattingEnabled = true;
            lstLichHen.Location = new Point(417, 202);
            lstLichHen.Name = "lstLichHen";
            lstLichHen.Size = new Size(276, 144);
            lstLichHen.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(264, 99);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 4;
            label1.Text = "Tên Bệnh Nhân";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(267, 145);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 5;
            label2.Text = "Ngày Đặt Lịch:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(267, 202);
            label3.Name = "label3";
            label3.Size = new Size(144, 20);
            label3.TabIndex = 6;
            label3.Text = "Danh sách lịch khám";
            // 
            // frmLichHen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstLichHen);
            Controls.Add(txtTenBN);
            Controls.Add(btnDatLich);
            Controls.Add(dtpNgayGio);
            Name = "frmLichHen";
            Text = "frmLichHen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpNgayGio;
        private Button btnDatLich;
        private System.Windows.Forms.Timer timer1;
        private TextBox txtTenBN;
        private ListBox lstLichHen;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}