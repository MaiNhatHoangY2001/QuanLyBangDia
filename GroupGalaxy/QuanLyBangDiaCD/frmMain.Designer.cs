
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
            this.mnuTimKiemBD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChucNangTimKiemKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChucNangSapXepKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChucNangSapXepNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChucNang});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1501, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuChucNang
            // 
            this.mnuChucNang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChucNangQLBD,
            this.mnuChucNangQLNV,
            this.mnuChucNangQuanLyPhieuThue,
            this.mnuTimKiemBD,
            this.mnuChucNangTimKiemKhachHang,
            this.mnuChucNangSapXepKhachHang,
            this.mnuChucNangSapXepNhanVien});
            this.mnuChucNang.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mnuChucNang.Name = "mnuChucNang";
            this.mnuChucNang.Size = new System.Drawing.Size(96, 25);
            this.mnuChucNang.Text = "Chức năng";
            // 
            // mnuChucNangQLBD
            // 
            this.mnuChucNangQLBD.Name = "mnuChucNangQLBD";
            this.mnuChucNangQLBD.Size = new System.Drawing.Size(229, 26);
            this.mnuChucNangQLBD.Text = "Quản lý băng đĩa";
            this.mnuChucNangQLBD.Click += new System.EventHandler(this.mnuChucNangQLBD_Click);
            // 
            // mnuChucNangQLNV
            // 
            this.mnuChucNangQLNV.Name = "mnuChucNangQLNV";
            this.mnuChucNangQLNV.Size = new System.Drawing.Size(229, 26);
            this.mnuChucNangQLNV.Text = "Quản lý nhân viên";
            this.mnuChucNangQLNV.Click += new System.EventHandler(this.mnuChucNangQLNV_Click);
            // 
            // mnuChucNangQuanLyPhieuThue
            // 
            this.mnuChucNangQuanLyPhieuThue.Name = "mnuChucNangQuanLyPhieuThue";
            this.mnuChucNangQuanLyPhieuThue.Size = new System.Drawing.Size(229, 26);
            this.mnuChucNangQuanLyPhieuThue.Text = "Quản lý phiếu thuê";
            this.mnuChucNangQuanLyPhieuThue.Click += new System.EventHandler(this.mnuChucNangQuanLyPhieuThue_Click);
            // 
            // mnuTimKiemBD
            // 
            this.mnuTimKiemBD.Name = "mnuTimKiemBD";
            this.mnuTimKiemBD.Size = new System.Drawing.Size(229, 26);
            this.mnuTimKiemBD.Text = "Tìm kiếm băng đĩa";
            this.mnuTimKiemBD.Click += new System.EventHandler(this.mnuTimKiemBD_Click);
            // 
            // mnuChucNangTimKiemKhachHang
            // 
            this.mnuChucNangTimKiemKhachHang.Name = "mnuChucNangTimKiemKhachHang";
            this.mnuChucNangTimKiemKhachHang.Size = new System.Drawing.Size(229, 26);
            this.mnuChucNangTimKiemKhachHang.Text = "Tìm Kiếm khách hàng";
            this.mnuChucNangTimKiemKhachHang.Click += new System.EventHandler(this.mnuChucNangTimKiemKhachHang_Click);
            // 
            // mnuChucNangSapXepKhachHang
            // 
            this.mnuChucNangSapXepKhachHang.Name = "mnuChucNangSapXepKhachHang";
            this.mnuChucNangSapXepKhachHang.Size = new System.Drawing.Size(229, 26);
            this.mnuChucNangSapXepKhachHang.Text = "Sắp xếp khách hàng";
            this.mnuChucNangSapXepKhachHang.Click += new System.EventHandler(this.mnuChucNangSapXepKhachHang_Click);
            // 
            // mnuChucNangSapXepNhanVien
            // 
            this.mnuChucNangSapXepNhanVien.Name = "mnuChucNangSapXepNhanVien";
            this.mnuChucNangSapXepNhanVien.Size = new System.Drawing.Size(229, 26);
            this.mnuChucNangSapXepNhanVien.Text = "Sắp xếp nhân viên";
            this.mnuChucNangSapXepNhanVien.Click += new System.EventHandler(this.mnuChucNangSapXepNhanVien_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1501, 789);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmMain";
            this.Text = "Quản lý băng đĩa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.ToolStripMenuItem mnuTimKiemBD;
        private System.Windows.Forms.ToolStripMenuItem mnuChucNangTimKiemKhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnuChucNangSapXepKhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnuChucNangSapXepNhanVien;
    }
}