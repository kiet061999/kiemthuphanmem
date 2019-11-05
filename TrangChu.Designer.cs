namespace KiemThuPhanMem
{
    partial class TrangChu
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
            this.quanLyHêThôngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CapNhatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyMươnTraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MuonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyTraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đoiTaiKhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hôTrơToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // quanLyHêThôngToolStripMenuItem
            // 
            this.quanLyHêThôngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.SaveToolStripMenuItem,
            this.CapNhatToolStripMenuItem});
            this.quanLyHêThôngToolStripMenuItem.Name = "quanLyHêThôngToolStripMenuItem";
            this.quanLyHêThôngToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.quanLyHêThôngToolStripMenuItem.Text = "Quản Lý Hệ Thống";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBox1.Text = "Thoát";
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.SaveToolStripMenuItem.Text = "Lưu dữ liệu";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // CapNhatToolStripMenuItem
            // 
            this.CapNhatToolStripMenuItem.Name = "CapNhatToolStripMenuItem";
            this.CapNhatToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.CapNhatToolStripMenuItem.Text = "Cập nhật sách";
            this.CapNhatToolStripMenuItem.Click += new System.EventHandler(this.CapNhatToolStripMenuItem_Click);
            // 
            // quanLyMươnTraToolStripMenuItem
            // 
            this.quanLyMươnTraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MuonToolStripMenuItem,
            this.quanLyTraToolStripMenuItem});
            this.quanLyMươnTraToolStripMenuItem.Name = "quanLyMươnTraToolStripMenuItem";
            this.quanLyMươnTraToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.quanLyMươnTraToolStripMenuItem.Text = "Quản Lý Mượn Trả";
            // 
            // MuonToolStripMenuItem
            // 
            this.MuonToolStripMenuItem.Name = "MuonToolStripMenuItem";
            this.MuonToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.MuonToolStripMenuItem.Text = "Quản Lý Mượn";
            this.MuonToolStripMenuItem.Click += new System.EventHandler(this.MuonToolStripMenuItem_Click);
            // 
            // quanLyTraToolStripMenuItem
            // 
            this.quanLyTraToolStripMenuItem.Name = "quanLyTraToolStripMenuItem";
            this.quanLyTraToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.quanLyTraToolStripMenuItem.Text = "Quản Lý Trả";
            // 
            // đoiTaiKhoanToolStripMenuItem
            // 
            this.đoiTaiKhoanToolStripMenuItem.Name = "đoiTaiKhoanToolStripMenuItem";
            this.đoiTaiKhoanToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.đoiTaiKhoanToolStripMenuItem.Text = "Đổi Tài Khoản";
            // 
            // hôTrơToolStripMenuItem
            // 
            this.hôTrơToolStripMenuItem.Name = "hôTrơToolStripMenuItem";
            this.hôTrơToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.hôTrơToolStripMenuItem.Text = "Hỗ Trợ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLyHêThôngToolStripMenuItem,
            this.quanLyMươnTraToolStripMenuItem,
            this.đoiTaiKhoanToolStripMenuItem,
            this.hôTrơToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang Chủ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TrangChu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem quanLyHêThôngToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CapNhatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyMươnTraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MuonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyTraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đoiTaiKhoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hôTrơToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}