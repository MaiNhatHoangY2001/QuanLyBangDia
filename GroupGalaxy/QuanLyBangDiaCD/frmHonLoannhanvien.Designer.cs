
namespace QuanLyBangDiaCD
{
    partial class frmHonLoannhanvien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btntencochua = new System.Windows.Forms.Button();
            this.btntenchuadau = new System.Windows.Forms.Button();
            this.txtgiatri = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKHtencuoi = new System.Windows.Forms.Button();
            this.btnKHtendau = new System.Windows.Forms.Button();
            this.dgrhonloanNV = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrhonloanNV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btntencochua);
            this.groupBox1.Controls.Add(this.btntenchuadau);
            this.groupBox1.Controls.Add(this.btnKHtencuoi);
            this.groupBox1.Controls.Add(this.btnKHtendau);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtgiatri);
            this.groupBox1.Location = new System.Drawing.Point(12, 300);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 185);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tác Vụ";
            // 
            // btntencochua
            // 
            this.btntencochua.Location = new System.Drawing.Point(533, 46);
            this.btntencochua.Name = "btntencochua";
            this.btntencochua.Size = new System.Drawing.Size(232, 48);
            this.btntencochua.TabIndex = 3;
            this.btntencochua.Text = "Reset";
            this.btntencochua.UseVisualStyleBackColor = true;
            this.btntencochua.Click += new System.EventHandler(this.btntencochua_Click);
            // 
            // btntenchuadau
            // 
            this.btntenchuadau.Location = new System.Drawing.Point(33, 128);
            this.btntenchuadau.Name = "btntenchuadau";
            this.btntenchuadau.Size = new System.Drawing.Size(232, 48);
            this.btntenchuadau.TabIndex = 3;
            this.btntenchuadau.Text = "Tên có chứa";
            this.btntenchuadau.UseVisualStyleBackColor = true;
            this.btntenchuadau.Click += new System.EventHandler(this.btntenchuadau_Click);
            // 
            // txtgiatri
            // 
            this.txtgiatri.Location = new System.Drawing.Point(174, 57);
            this.txtgiatri.Name = "txtgiatri";
            this.txtgiatri.Size = new System.Drawing.Size(330, 26);
            this.txtgiatri.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Đầu/Cuối";
            // 
            // btnKHtencuoi
            // 
            this.btnKHtencuoi.Location = new System.Drawing.Point(283, 128);
            this.btnKHtencuoi.Name = "btnKHtencuoi";
            this.btnKHtencuoi.Size = new System.Drawing.Size(232, 48);
            this.btnKHtencuoi.TabIndex = 0;
            this.btnKHtencuoi.Text = "Họ tên nhân viên có tên cuối";
            this.btnKHtencuoi.UseVisualStyleBackColor = true;
            this.btnKHtencuoi.Click += new System.EventHandler(this.btnKHtencuoi_Click);
            // 
            // btnKHtendau
            // 
            this.btnKHtendau.Location = new System.Drawing.Point(533, 128);
            this.btnKHtendau.Name = "btnKHtendau";
            this.btnKHtendau.Size = new System.Drawing.Size(232, 48);
            this.btnKHtendau.TabIndex = 0;
            this.btnKHtendau.Text = "Họ tên nhân viên có tên đầu";
            this.btnKHtendau.UseVisualStyleBackColor = true;
            this.btnKHtendau.Click += new System.EventHandler(this.btnKHtendau_Click);
            // 
            // dgrhonloanNV
            // 
            this.dgrhonloanNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrhonloanNV.Location = new System.Drawing.Point(12, 12);
            this.dgrhonloanNV.Name = "dgrhonloanNV";
            this.dgrhonloanNV.RowHeadersWidth = 62;
            this.dgrhonloanNV.RowTemplate.Height = 28;
            this.dgrhonloanNV.Size = new System.Drawing.Size(794, 253);
            this.dgrhonloanNV.TabIndex = 2;
            // 
            // frmHonLoannhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 526);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgrhonloanNV);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Name = "frmHonLoannhanvien";
            this.Text = "frmHonLoannhanvien";
            this.Load += new System.EventHandler(this.frmHonLoannhanvien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrhonloanNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btntencochua;
        private System.Windows.Forms.Button btntenchuadau;
        private System.Windows.Forms.TextBox txtgiatri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKHtencuoi;
        private System.Windows.Forms.Button btnKHtendau;
        private System.Windows.Forms.DataGridView dgrhonloanNV;
    }
}