namespace Bai4_Chuong4
{
    partial class FrmParent
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
            menuStrip1 = new MenuStrip();
            nghiệpVụToolStripMenuItem = new ToolStripMenuItem();
            thôngTinBệnhNhânToolStripMenuItem = new ToolStripMenuItem();
            đặtLichHẹnToolStripMenuItem = new ToolStripMenuItem();
            cửaSổToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { nghiệpVụToolStripMenuItem, cửaSổToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.MdiWindowListItem = cửaSổToolStripMenuItem;
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // nghiệpVụToolStripMenuItem
            // 
            nghiệpVụToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinBệnhNhânToolStripMenuItem, đặtLichHẹnToolStripMenuItem });
            nghiệpVụToolStripMenuItem.Name = "nghiệpVụToolStripMenuItem";
            nghiệpVụToolStripMenuItem.Size = new Size(91, 24);
            nghiệpVụToolStripMenuItem.Text = "Nghiệp vụ";
            // 
            // thôngTinBệnhNhânToolStripMenuItem
            // 
            thôngTinBệnhNhânToolStripMenuItem.Name = "thôngTinBệnhNhânToolStripMenuItem";
            thôngTinBệnhNhânToolStripMenuItem.Size = new Size(228, 26);
            thôngTinBệnhNhânToolStripMenuItem.Text = "Thông tin bệnh nhân";
            thôngTinBệnhNhânToolStripMenuItem.Click += thôngTinBệnhNhânToolStripMenuItem_Click;
            // 
            // đặtLichHẹnToolStripMenuItem
            // 
            đặtLichHẹnToolStripMenuItem.Name = "đặtLichHẹnToolStripMenuItem";
            đặtLichHẹnToolStripMenuItem.Size = new Size(228, 26);
            đặtLichHẹnToolStripMenuItem.Text = "Đặt lich hẹn";
            đặtLichHẹnToolStripMenuItem.Click += đặtLichHẹnToolStripMenuItem_Click;
            // 
            // cửaSổToolStripMenuItem
            // 
            cửaSổToolStripMenuItem.Name = "cửaSổToolStripMenuItem";
            cửaSổToolStripMenuItem.Size = new Size(68, 24);
            cửaSổToolStripMenuItem.Text = "Cửa sổ";
            // 
            // FrmParent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmParent";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem nghiệpVụToolStripMenuItem;
        private ToolStripMenuItem thôngTinBệnhNhânToolStripMenuItem;
        private ToolStripMenuItem đặtLichHẹnToolStripMenuItem;
        private ToolStripMenuItem cửaSổToolStripMenuItem;
    }
}
