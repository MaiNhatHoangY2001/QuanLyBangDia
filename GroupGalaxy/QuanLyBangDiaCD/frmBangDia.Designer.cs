
namespace QuanLyBangDiaCD
{
    partial class frmBangDia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBangDia));
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treCongTy = new System.Windows.Forms.TreeView();
            this.btnThemCongTy = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lvwDSBangDia = new System.Windows.Forms.ListView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.dtpNgaySX = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnXoaRong = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.radTreHan = new System.Windows.Forms.RadioButton();
            this.radDungHan = new System.Windows.Forms.RadioButton();
            this.txtMaBangDia = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTenBangDia = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTheLoai = new System.Windows.Forms.TextBox();
            this.txtCongTy = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.imgLon = new System.Windows.Forms.ImageList(this.components);
            this.imgNho = new System.Windows.Forms.ImageList(this.components);
            this.imgTree = new System.Windows.Forms.ImageList(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1172, 103);
            this.label1.TabIndex = 11;
            this.label1.Text = "QUẢN LÝ BĂNG ĐĨA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 103);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treCongTy);
            this.splitContainer1.Panel1.Controls.Add(this.btnThemCongTy);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1172, 602);
            this.splitContainer1.SplitterDistance = 286;
            this.splitContainer1.TabIndex = 12;
            // 
            // treCongTy
            // 
            this.treCongTy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treCongTy.Location = new System.Drawing.Point(0, 0);
            this.treCongTy.Name = "treCongTy";
            this.treCongTy.Size = new System.Drawing.Size(282, 564);
            this.treCongTy.TabIndex = 1;
            this.treCongTy.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treCongTy_AfterSelect);
            // 
            // btnThemCongTy
            // 
            this.btnThemCongTy.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnThemCongTy.Location = new System.Drawing.Point(0, 564);
            this.btnThemCongTy.Name = "btnThemCongTy";
            this.btnThemCongTy.Size = new System.Drawing.Size(282, 34);
            this.btnThemCongTy.TabIndex = 0;
            this.btnThemCongTy.Text = "Thêm công ty";
            this.btnThemCongTy.UseVisualStyleBackColor = true;
            this.btnThemCongTy.Click += new System.EventHandler(this.btnThemCongTy_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lvwDSBangDia);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox6);
            this.splitContainer2.Size = new System.Drawing.Size(882, 602);
            this.splitContainer2.SplitterDistance = 256;
            this.splitContainer2.TabIndex = 0;
            // 
            // lvwDSBangDia
            // 
            this.lvwDSBangDia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwDSBangDia.HideSelection = false;
            this.lvwDSBangDia.Location = new System.Drawing.Point(0, 0);
            this.lvwDSBangDia.Name = "lvwDSBangDia";
            this.lvwDSBangDia.Size = new System.Drawing.Size(878, 252);
            this.lvwDSBangDia.TabIndex = 2;
            this.lvwDSBangDia.UseCompatibleStateImageBehavior = false;
            this.lvwDSBangDia.SelectedIndexChanged += new System.EventHandler(this.lvwDSBangDia_SelectedIndexChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cboLoai);
            this.groupBox6.Controls.Add(this.dtpNgaySX);
            this.groupBox6.Controls.Add(this.groupBox4);
            this.groupBox6.Controls.Add(this.radTreHan);
            this.groupBox6.Controls.Add(this.radDungHan);
            this.groupBox6.Controls.Add(this.txtMaBangDia);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.txtTenBangDia);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.txtGia);
            this.groupBox6.Controls.Add(this.txtTheLoai);
            this.groupBox6.Controls.Add(this.txtCongTy);
            this.groupBox6.Controls.Add(this.txtGhiChu);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.label21);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(3, -2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(872, 344);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Thông tin băng đĩa";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // cboLoai
            // 
            this.cboLoai.FormattingEnabled = true;
            this.cboLoai.Items.AddRange(new object[] {
            "CD",
            "VCD",
            "DVD",
            "CD-ROM"});
            this.cboLoai.Location = new System.Drawing.Point(143, 181);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(280, 37);
            this.cboLoai.TabIndex = 15;
            // 
            // dtpNgaySX
            // 
            this.dtpNgaySX.Location = new System.Drawing.Point(595, 140);
            this.dtpNgaySX.Name = "dtpNgaySX";
            this.dtpNgaySX.Size = new System.Drawing.Size(213, 35);
            this.dtpNgaySX.TabIndex = 14;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnXoaRong);
            this.groupBox4.Controls.Add(this.btnThem);
            this.groupBox4.Controls.Add(this.btnLuu);
            this.groupBox4.Controls.Add(this.btnXoa);
            this.groupBox4.Controls.Add(this.btnSua);
            this.groupBox4.Location = new System.Drawing.Point(19, 261);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(845, 77);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tác vụ";
            // 
            // btnXoaRong
            // 
            this.btnXoaRong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaRong.Location = new System.Drawing.Point(407, 25);
            this.btnXoaRong.Name = "btnXoaRong";
            this.btnXoaRong.Size = new System.Drawing.Size(91, 34);
            this.btnXoaRong.TabIndex = 4;
            this.btnXoaRong.Text = "Xóa rỗng";
            this.btnXoaRong.UseVisualStyleBackColor = true;
            this.btnXoaRong.Click += new System.EventHandler(this.btnXoaRong_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(141, 25);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(91, 34);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(540, 25);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(91, 34);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(673, 25);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(91, 34);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(274, 25);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(91, 34);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // radTreHan
            // 
            this.radTreHan.AutoSize = true;
            this.radTreHan.Location = new System.Drawing.Point(727, 185);
            this.radTreHan.Name = "radTreHan";
            this.radTreHan.Size = new System.Drawing.Size(121, 33);
            this.radTreHan.TabIndex = 4;
            this.radTreHan.TabStop = true;
            this.radTreHan.Text = "Trễ hạn";
            this.radTreHan.UseVisualStyleBackColor = true;
            // 
            // radDungHan
            // 
            this.radDungHan.AutoSize = true;
            this.radDungHan.Location = new System.Drawing.Point(596, 185);
            this.radDungHan.Name = "radDungHan";
            this.radDungHan.Size = new System.Drawing.Size(140, 33);
            this.radDungHan.TabIndex = 4;
            this.radDungHan.TabStop = true;
            this.radDungHan.Text = "Đúng hạn";
            this.radDungHan.UseVisualStyleBackColor = true;
            // 
            // txtMaBangDia
            // 
            this.txtMaBangDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaBangDia.Location = new System.Drawing.Point(143, 38);
            this.txtMaBangDia.Name = "txtMaBangDia";
            this.txtMaBangDia.Size = new System.Drawing.Size(282, 40);
            this.txtMaBangDia.TabIndex = 0;
            this.txtMaBangDia.TextChanged += new System.EventHandler(this.txtMaBangDia_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(17, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(145, 29);
            this.label14.TabIndex = 2;
            this.label14.Text = "Mã băng đĩa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Loại đĩa";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(17, 140);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 29);
            this.label15.TabIndex = 2;
            this.label15.Text = "Giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(461, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sản xuất";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(461, 95);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 29);
            this.label16.TabIndex = 2;
            this.label16.Text = "Ghi chú";
            // 
            // txtTenBangDia
            // 
            this.txtTenBangDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenBangDia.Location = new System.Drawing.Point(595, 38);
            this.txtTenBangDia.Name = "txtTenBangDia";
            this.txtTenBangDia.Size = new System.Drawing.Size(271, 40);
            this.txtTenBangDia.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(17, 86);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(101, 29);
            this.label18.TabIndex = 2;
            this.label18.Text = "Thể loại";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(461, 38);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(155, 29);
            this.label19.TabIndex = 2;
            this.label19.Text = "Tên băng đĩa";
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(143, 131);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(282, 40);
            this.txtGia.TabIndex = 2;
            // 
            // txtTheLoai
            // 
            this.txtTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTheLoai.Location = new System.Drawing.Point(143, 86);
            this.txtTheLoai.Name = "txtTheLoai";
            this.txtTheLoai.Size = new System.Drawing.Size(282, 40);
            this.txtTheLoai.TabIndex = 2;
            // 
            // txtCongTy
            // 
            this.txtCongTy.Enabled = false;
            this.txtCongTy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCongTy.Location = new System.Drawing.Point(344, 226);
            this.txtCongTy.Name = "txtCongTy";
            this.txtCongTy.ReadOnly = true;
            this.txtCongTy.Size = new System.Drawing.Size(290, 40);
            this.txtCongTy.TabIndex = 3;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(596, 86);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(270, 40);
            this.txtGhiChu.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(226, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Công ty";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(461, 187);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(121, 29);
            this.label21.TabIndex = 2;
            this.label21.Text = "Tình trạng";
            // 
            // imgLon
            // 
            this.imgLon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLon.ImageStream")));
            this.imgLon.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLon.Images.SetKeyName(0, "folderCD.ico");
            // 
            // imgNho
            // 
            this.imgNho.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgNho.ImageStream")));
            this.imgNho.TransparentColor = System.Drawing.Color.Transparent;
            this.imgNho.Images.SetKeyName(0, "cd.ico");
            // 
            // imgTree
            // 
            this.imgTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgTree.ImageStream")));
            this.imgTree.TransparentColor = System.Drawing.Color.Transparent;
            this.imgTree.Images.SetKeyName(0, "icons8-company-open.ico");
            this.imgTree.Images.SetKeyName(1, "icons8-company-close.ico");
            // 
            // frmBangDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 705);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmBangDia";
            this.Text = "Quản lý băng đĩa";
            this.Load += new System.EventHandler(this.frmBangDia_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treCongTy;
        private System.Windows.Forms.Button btnThemCongTy;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListView lvwDSBangDia;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton radTreHan;
        private System.Windows.Forms.RadioButton radDungHan;
        private System.Windows.Forms.TextBox txtMaBangDia;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTenBangDia;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtTheLoai;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnXoaRong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtCongTy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ImageList imgLon;
        private System.Windows.Forms.ImageList imgNho;
        private System.Windows.Forms.ImageList imgTree;
        private System.Windows.Forms.DateTimePicker dtpNgaySX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboLoai;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}