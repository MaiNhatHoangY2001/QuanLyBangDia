
namespace QuanLyBangDiaCD
{
    partial class frmHonloanKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHonloanKhachHang));
            this.dgrhonloanKH = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btntencochua = new System.Windows.Forms.Button();
            this.btntenchuadau = new System.Windows.Forms.Button();
            this.txtThongTin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKHtencuoi = new System.Windows.Forms.Button();
            this.btnKHtendau = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrhonloanKH)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgrhonloanKH
            // 
            this.dgrhonloanKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrhonloanKH.Location = new System.Drawing.Point(12, 12);
            this.dgrhonloanKH.Name = "dgrhonloanKH";
            this.dgrhonloanKH.RowHeadersWidth = 62;
            this.dgrhonloanKH.RowTemplate.Height = 28;
            this.dgrhonloanKH.Size = new System.Drawing.Size(833, 248);
            this.dgrhonloanKH.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btntencochua);
            this.groupBox1.Controls.Add(this.btntenchuadau);
            this.groupBox1.Controls.Add(this.txtThongTin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnKHtencuoi);
            this.groupBox1.Controls.Add(this.btnKHtendau);
            this.groupBox1.Location = new System.Drawing.Point(12, 279);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(833, 166);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tác Vụ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btntencochua
            // 
            this.btntencochua.Location = new System.Drawing.Point(558, 25);
            this.btntencochua.Name = "btntencochua";
            this.btntencochua.Size = new System.Drawing.Size(255, 48);
            this.btntencochua.TabIndex = 1;
            this.btntencochua.Text = "&Reset";
            this.btntencochua.UseVisualStyleBackColor = true;
            this.btntencochua.Click += new System.EventHandler(this.btntencochua_Click);
            // 
            // btntenchuadau
            // 
            this.btntenchuadau.Location = new System.Drawing.Point(6, 91);
            this.btntenchuadau.Name = "btntenchuadau";
            this.btntenchuadau.Size = new System.Drawing.Size(255, 48);
            this.btntenchuadau.TabIndex = 2;
            this.btntenchuadau.Text = "&Tên có chứa";
            this.btntenchuadau.UseVisualStyleBackColor = true;
            this.btntenchuadau.Click += new System.EventHandler(this.btntenchuadau_Click);
            // 
            // txtThongTin
            // 
            this.txtThongTin.Location = new System.Drawing.Point(164, 36);
            this.txtThongTin.Name = "txtThongTin";
            this.txtThongTin.Size = new System.Drawing.Size(374, 35);
            this.txtThongTin.TabIndex = 0;
            this.txtThongTin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Đầu/Cuối";
            // 
            // btnKHtencuoi
            // 
            this.btnKHtencuoi.Location = new System.Drawing.Point(558, 91);
            this.btnKHtencuoi.Name = "btnKHtencuoi";
            this.btnKHtencuoi.Size = new System.Drawing.Size(255, 48);
            this.btnKHtencuoi.TabIndex = 4;
            this.btnKHtencuoi.Text = "Họ tên khách hàng có tên &cuối";
            this.btnKHtencuoi.UseVisualStyleBackColor = true;
            this.btnKHtencuoi.Click += new System.EventHandler(this.btnKHtencuoi_Click);
            // 
            // btnKHtendau
            // 
            this.btnKHtendau.Location = new System.Drawing.Point(283, 91);
            this.btnKHtendau.Name = "btnKHtendau";
            this.btnKHtendau.Size = new System.Drawing.Size(255, 48);
            this.btnKHtendau.TabIndex = 3;
            this.btnKHtendau.Text = "Họ tên khách hàng có tên &đầu";
            this.btnKHtendau.UseVisualStyleBackColor = true;
            this.btnKHtendau.Click += new System.EventHandler(this.btnKHtendau_Click);
            // 
            // frmHonloanKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(857, 455);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgrhonloanKH);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Name = "frmHonloanKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmhonloanKhachHang";
            this.Load += new System.EventHandler(this.frmhonloanKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrhonloanKH)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrhonloanKH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKHtencuoi;
        private System.Windows.Forms.Button btnKHtendau;
        private System.Windows.Forms.TextBox txtThongTin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btntencochua;
        private System.Windows.Forms.Button btntenchuadau;
    }
}