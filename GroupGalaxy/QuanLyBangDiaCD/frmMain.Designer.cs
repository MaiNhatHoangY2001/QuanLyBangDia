
namespace QuanLyBangDiaCD
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuChucNang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChucNangQLBD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChucNangQLNV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChucNangQuanLyPhieuThue = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimKiemBD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChucNangTimKiemKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSapXep = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChucNangSapXepNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChucNangSapXepKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChucNang,
            this.mnuTimKiem,
            this.mnuSapXep,
            this.aboutToolStripMenuItem,
            this.mnuThoat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1501, 44);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuChucNang
            // 
            this.mnuChucNang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChucNangQLBD,
            this.mnuChucNangQLNV,
            this.mnuChucNangQuanLyPhieuThue});
            this.mnuChucNang.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mnuChucNang.Image = global::QuanLyBangDiaCD.Properties.Resources.admin;
            this.mnuChucNang.Name = "mnuChucNang";
            this.mnuChucNang.Size = new System.Drawing.Size(134, 36);
            this.mnuChucNang.Text = "Quản lý";
            // 
            // mnuChucNangQLBD
            // 
            this.mnuChucNangQLBD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mnuChucNangQLBD.Image = global::QuanLyBangDiaCD.Properties.Resources.cdicon;
            this.mnuChucNangQLBD.Name = "mnuChucNangQLBD";
            this.mnuChucNangQLBD.Size = new System.Drawing.Size(236, 40);
            this.mnuChucNangQLBD.Text = "Băng đĩa";
            this.mnuChucNangQLBD.Click += new System.EventHandler(this.mnuChucNangQLBD_Click);
            // 
            // mnuChucNangQLNV
            // 
            this.mnuChucNangQLNV.Image = global::QuanLyBangDiaCD.Properties.Resources.employee;
            this.mnuChucNangQLNV.Name = "mnuChucNangQLNV";
            this.mnuChucNangQLNV.Size = new System.Drawing.Size(236, 40);
            this.mnuChucNangQLNV.Text = "Nhân viên";
            this.mnuChucNangQLNV.Click += new System.EventHandler(this.mnuChucNangQLNV_Click);
            // 
            // mnuChucNangQuanLyPhieuThue
            // 
            this.mnuChucNangQuanLyPhieuThue.Image = global::QuanLyBangDiaCD.Properties.Resources.bill;
            this.mnuChucNangQuanLyPhieuThue.Name = "mnuChucNangQuanLyPhieuThue";
            this.mnuChucNangQuanLyPhieuThue.Size = new System.Drawing.Size(236, 40);
            this.mnuChucNangQuanLyPhieuThue.Text = "Phiếu thuê";
            this.mnuChucNangQuanLyPhieuThue.Click += new System.EventHandler(this.mnuChucNangQuanLyPhieuThue_Click);
            // 
            // mnuTimKiem
            // 
            this.mnuTimKiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTimKiemBD,
            this.mnuChucNangTimKiemKhachHang});
            this.mnuTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuTimKiem.Image = global::QuanLyBangDiaCD.Properties.Resources.search;
            this.mnuTimKiem.Name = "mnuTimKiem";
            this.mnuTimKiem.Size = new System.Drawing.Size(150, 36);
            this.mnuTimKiem.Text = "Tìm kiếm";
            // 
            // mnuTimKiemBD
            // 
            this.mnuTimKiemBD.Image = global::QuanLyBangDiaCD.Properties.Resources.cdicon;
            this.mnuTimKiemBD.Name = "mnuTimKiemBD";
            this.mnuTimKiemBD.Size = new System.Drawing.Size(246, 40);
            this.mnuTimKiemBD.Text = "Băng đĩa";
            this.mnuTimKiemBD.Click += new System.EventHandler(this.mnuTimKiemBD_Click);
            // 
            // mnuChucNangTimKiemKhachHang
            // 
            this.mnuChucNangTimKiemKhachHang.Image = global::QuanLyBangDiaCD.Properties.Resources.customers;
            this.mnuChucNangTimKiemKhachHang.Name = "mnuChucNangTimKiemKhachHang";
            this.mnuChucNangTimKiemKhachHang.Size = new System.Drawing.Size(246, 40);
            this.mnuChucNangTimKiemKhachHang.Text = "Khách hàng";
            this.mnuChucNangTimKiemKhachHang.Click += new System.EventHandler(this.mnuChucNangTimKiemKhachHang_Click);
            // 
            // mnuSapXep
            // 
            this.mnuSapXep.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChucNangSapXepNhanVien,
            this.mnuChucNangSapXepKhachHang});
            this.mnuSapXep.Image = global::QuanLyBangDiaCD.Properties.Resources.sắp_xếp;
            this.mnuSapXep.Name = "mnuSapXep";
            this.mnuSapXep.Size = new System.Drawing.Size(135, 36);
            this.mnuSapXep.Text = "Sắp xếp";
            // 
            // mnuChucNangSapXepNhanVien
            // 
            this.mnuChucNangSapXepNhanVien.Image = global::QuanLyBangDiaCD.Properties.Resources.employee;
            this.mnuChucNangSapXepNhanVien.Name = "mnuChucNangSapXepNhanVien";
            this.mnuChucNangSapXepNhanVien.Size = new System.Drawing.Size(246, 40);
            this.mnuChucNangSapXepNhanVien.Text = "Nhân viên";
            this.mnuChucNangSapXepNhanVien.Click += new System.EventHandler(this.mnuChucNangSapXepNhanVien_Click);
            // 
            // mnuChucNangSapXepKhachHang
            // 
            this.mnuChucNangSapXepKhachHang.Image = global::QuanLyBangDiaCD.Properties.Resources.customers;
            this.mnuChucNangSapXepKhachHang.Name = "mnuChucNangSapXepKhachHang";
            this.mnuChucNangSapXepKhachHang.Size = new System.Drawing.Size(246, 40);
            this.mnuChucNangSapXepKhachHang.Text = "Khách hàng";
            this.mnuChucNangSapXepKhachHang.Click += new System.EventHandler(this.mnuChucNangSapXepKhachHang_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::QuanLyBangDiaCD.Properties.Resources.about;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 36);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Image = global::QuanLyBangDiaCD.Properties.Resources.exit1;
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(112, 36);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1501, 789);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý băng đĩa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuChucNang;
        private System.Windows.Forms.ToolStripMenuItem mnuChucNangQLBD;
        private System.Windows.Forms.ToolStripMenuItem mnuChucNangQLNV;
        private System.Windows.Forms.ToolStripMenuItem mnuChucNangQuanLyPhieuThue;
        private System.Windows.Forms.ToolStripMenuItem mnuTimKiem;
        private System.Windows.Forms.ToolStripMenuItem mnuTimKiemBD;
        private System.Windows.Forms.ToolStripMenuItem mnuChucNangTimKiemKhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnuSapXep;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuChucNangSapXepNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuChucNangSapXepKhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
    }
}