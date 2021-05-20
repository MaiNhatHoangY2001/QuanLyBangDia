
namespace QuanLyBangDiaCD
{
    partial class frmTimKiemKhachHang
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimKiemKhachHang));
            this.imgNhoKH = new System.Windows.Forms.ImageList(this.components);
            this.imgLonKH = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvwDSPhieuThue = new System.Windows.Forms.ListView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvwDSKhachHang = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radTenKH = new System.Windows.Forms.RadioButton();
            this.radMaKH = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgNhoKH
            // 
            this.imgNhoKH.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgNhoKH.ImageStream")));
            this.imgNhoKH.TransparentColor = System.Drawing.Color.Transparent;
            this.imgNhoKH.Images.SetKeyName(0, "customer.png");
            // 
            // imgLonKH
            // 
            this.imgLonKH.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLonKH.ImageStream")));
            this.imgLonKH.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLonKH.Images.SetKeyName(0, "customers.png");
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1030, 573);
            this.splitContainer1.SplitterDistance = 295;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvwDSPhieuThue);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1030, 295);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phiếu thuê";
            // 
            // lvwDSPhieuThue
            // 
            this.lvwDSPhieuThue.HideSelection = false;
            this.lvwDSPhieuThue.Location = new System.Drawing.Point(12, 29);
            this.lvwDSPhieuThue.Name = "lvwDSPhieuThue";
            this.lvwDSPhieuThue.Size = new System.Drawing.Size(1006, 260);
            this.lvwDSPhieuThue.TabIndex = 0;
            this.lvwDSPhieuThue.UseCompatibleStateImageBehavior = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer2.Size = new System.Drawing.Size(1030, 274);
            this.splitContainer2.SplitterDistance = 591;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.lvwDSKhachHang);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(591, 274);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách khách hàng";
            // 
            // lvwDSKhachHang
            // 
            this.lvwDSKhachHang.HideSelection = false;
            this.lvwDSKhachHang.Location = new System.Drawing.Point(6, 29);
            this.lvwDSKhachHang.Name = "lvwDSKhachHang";
            this.lvwDSKhachHang.Size = new System.Drawing.Size(576, 233);
            this.lvwDSKhachHang.TabIndex = 0;
            this.lvwDSKhachHang.UseCompatibleStateImageBehavior = false;
            this.lvwDSKhachHang.SelectedIndexChanged += new System.EventHandler(this.lvwDSKhachHang_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnThucHien);
            this.groupBox3.Controls.Add(this.txtTimKiem);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.radTenKH);
            this.groupBox3.Controls.Add(this.radMaKH);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(435, 274);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // btnThucHien
            // 
            this.btnThucHien.Location = new System.Drawing.Point(178, 203);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(120, 36);
            this.btnThucHien.TabIndex = 3;
            this.btnThucHien.Text = "Thực hiện";
            this.btnThucHien.UseVisualStyleBackColor = true;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(126, 148);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(288, 30);
            this.txtTimKiem.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm:";
            // 
            // radTenKH
            // 
            this.radTenKH.AutoSize = true;
            this.radTenKH.Location = new System.Drawing.Point(104, 96);
            this.radTenKH.Name = "radTenKH";
            this.radTenKH.Size = new System.Drawing.Size(294, 29);
            this.radTenKH.TabIndex = 0;
            this.radTenKH.TabStop = true;
            this.radTenKH.Text = "Tìm kiếm theo tên khách hàng";
            this.radTenKH.UseVisualStyleBackColor = true;
            this.radTenKH.CheckedChanged += new System.EventHandler(this.radTenKH_CheckedChanged);
            // 
            // radMaKH
            // 
            this.radMaKH.AutoSize = true;
            this.radMaKH.Location = new System.Drawing.Point(104, 61);
            this.radMaKH.Name = "radMaKH";
            this.radMaKH.Size = new System.Drawing.Size(248, 29);
            this.radMaKH.TabIndex = 0;
            this.radMaKH.TabStop = true;
            this.radMaKH.Text = "Tìm theo mã khách hàng";
            this.radMaKH.UseVisualStyleBackColor = true;
            this.radMaKH.CheckedChanged += new System.EventHandler(this.radMaKH_CheckedChanged);
            // 
            // frmTimKiemKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 573);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTimKiemKhachHang";
            this.Text = "Tìm kiếm khách hàng";
            this.Load += new System.EventHandler(this.frmTimKiemKhachHang_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imgNhoKH;
        private System.Windows.Forms.ImageList imgLonKH;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvwDSPhieuThue;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvwDSKhachHang;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radTenKH;
        private System.Windows.Forms.RadioButton radMaKH;
    }
}