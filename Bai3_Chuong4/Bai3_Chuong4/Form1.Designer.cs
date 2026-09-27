namespace Bai3_Chuong4
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            txtCongViecMoi = new TextBox();
            lstCongViec = new ListBox();
            cmsCongViec = new ContextMenuStrip(components);
            đánhDấuHoànThànhToolStripMenuItem = new ToolStripMenuItem();
            xóaCôngViệcNàyToolStripMenuItem = new ToolStripMenuItem();
            xóaTấtCảToolStripMenuItem = new ToolStripMenuItem();
            btnThem = new Button();
            label1 = new Label();
            cmsCongViec.SuspendLayout();
            SuspendLayout();
            // 
            // txtCongViecMoi
            // 
            txtCongViecMoi.Location = new Point(135, 170);
            txtCongViecMoi.Name = "txtCongViecMoi";
            txtCongViecMoi.Size = new Size(125, 27);
            txtCongViecMoi.TabIndex = 0;
            // 
            // lstCongViec
            // 
            lstCongViec.ContextMenuStrip = cmsCongViec;
            lstCongViec.Dock = DockStyle.Right;
            lstCongViec.FormattingEnabled = true;
            lstCongViec.Location = new Point(293, 0);
            lstCongViec.Name = "lstCongViec";
            lstCongViec.Size = new Size(507, 450);
            lstCongViec.TabIndex = 1;
            // 
            // cmsCongViec
            // 
            cmsCongViec.ImageScalingSize = new Size(20, 20);
            cmsCongViec.Items.AddRange(new ToolStripItem[] { đánhDấuHoànThànhToolStripMenuItem, xóaCôngViệcNàyToolStripMenuItem, xóaTấtCảToolStripMenuItem });
            cmsCongViec.Name = "cmsCongViec";
            cmsCongViec.Size = new Size(221, 76);
            // 
            // đánhDấuHoànThànhToolStripMenuItem
            // 
            đánhDấuHoànThànhToolStripMenuItem.Name = "đánhDấuHoànThànhToolStripMenuItem";
            đánhDấuHoànThànhToolStripMenuItem.Size = new Size(220, 24);
            đánhDấuHoànThànhToolStripMenuItem.Text = "Đánh dấu hoàn thành";
            đánhDấuHoànThànhToolStripMenuItem.Click += mnuHoanThanh_Click;
            // 
            // xóaCôngViệcNàyToolStripMenuItem
            // 
            xóaCôngViệcNàyToolStripMenuItem.Name = "xóaCôngViệcNàyToolStripMenuItem";
            xóaCôngViệcNàyToolStripMenuItem.Size = new Size(220, 24);
            xóaCôngViệcNàyToolStripMenuItem.Text = "Xóa công việc này";
            xóaCôngViệcNàyToolStripMenuItem.Click += mnuXoa_Click;
            // 
            // xóaTấtCảToolStripMenuItem
            // 
            xóaTấtCảToolStripMenuItem.Name = "xóaTấtCảToolStripMenuItem";
            xóaTấtCảToolStripMenuItem.Size = new Size(220, 24);
            xóaTấtCảToolStripMenuItem.Text = "Xóa tất cả";
            xóaTấtCảToolStripMenuItem.Click += mnuXoaTatCa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(115, 224);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 170);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 4;
            label1.Text = "Công việc mới:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnThem);
            Controls.Add(lstCongViec);
            Controls.Add(txtCongViecMoi);
            Name = "Form1";
            Text = " ";
            cmsCongViec.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCongViecMoi;
        private ListBox lstCongViec;
        private ContextMenuStrip cmsCongViec;
        private ToolStripMenuItem đánhDấuHoànThànhToolStripMenuItem;
        private ToolStripMenuItem xóaCôngViệcNàyToolStripMenuItem;
        private ToolStripMenuItem xóaTấtCảToolStripMenuItem;
        private Button btnThem;
        private Label label1;
    }
}
