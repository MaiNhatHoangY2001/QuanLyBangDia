using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBangDiaCD
{
    public partial class frmHonLoannhanvien : Form
    {
        string strmanhanvien = "";
        clsHonloannhanvien hLoanNV;
        public frmHonLoannhanvien()
        {
            InitializeComponent();
        }
        public frmHonLoannhanvien(string strMa)// thêm vào
        {
            strmanhanvien = strMa;
            InitializeComponent();
            this.Text = "Bạn vừa truyền vào " + strMa;
        }
        private void frmHonLoannhanvien_Load(object sender, EventArgs e)
        {
            hLoanNV = new clsHonloannhanvien();
            dgrhonloanNV.DataSource = hLoanNV.GetnhanviencuaphieuthueHonLoan();
            tieuDe(dgrhonloanNV);
        }

        private void tieuDe(DataGridView dgrhonloanNV)
        {
            dgrhonloanNV.Columns["NvPT"].HeaderText = "Mã nhân viên";
            dgrhonloanNV.Columns["NvPT"].Width = 180;
            dgrhonloanNV.Columns["maPhieu"].HeaderText = "Mã phiếu";
            dgrhonloanNV.Columns["hoTenNV"].HeaderText = "Họ tên nhân viên";
            dgrhonloanNV.Columns["hoTenNV"].Width = 180;
            dgrhonloanNV.Columns["ngayMuon"].HeaderText = "Ngày mượn";
            dgrhonloanNV.Columns["ngayMuon"].Width = 150;
            dgrhonloanNV.Columns["ngayTra"].HeaderText = "Ngày trả";
            dgrhonloanNV.Columns["gioiTinh"].HeaderText = "Giới tính";
            dgrhonloanNV.Columns["diaChi"].HeaderText = "Địa chỉ";
            dgrhonloanNV.Columns["diaChi"].Width = 500;
            dgrhonloanNV.Columns["SDT"].HeaderText = "Số điện thoại";
            dgrhonloanNV.Columns["luong"].HeaderText = "Lương";
            dgrhonloanNV.Columns["caLamViec"].HeaderText = "Ca làm việc";
        }

        private void btntheomaNV_Click(object sender, EventArgs e)
        {
            dgrhonloanNV.DataSource = hLoanNV.Getmanhanvienhonloan(strmanhanvien);
        }

        private void btnordermaNV_Click(object sender, EventArgs e)
        {
            dgrhonloanNV.DataSource = hLoanNV.GetOrdermanhanvien(strmanhanvien);
        }

        private void btnKHtendau_Click(object sender, EventArgs e)
        {
            string strnvtendau = txtgiatri.Text;
            dgrhonloanNV.DataSource = hLoanNV.GetTenDauNhanvienHonLoan(strnvtendau);
        }

        private void btnKHtencuoi_Click(object sender, EventArgs e)
        {
            string strnvtencuoi = txtgiatri.Text;
            dgrhonloanNV.DataSource = hLoanNV.GetTenCuoiNhanvienHonLoan(strnvtencuoi);
        }

        private void btntenchuadau_Click(object sender, EventArgs e)
        {
            string strtenchuaDau = txtgiatri.Text;
            dgrhonloanNV.DataSource = hLoanNV.Gettenchuadau(strtenchuaDau);
        }

        private void btntencochua_Click(object sender, EventArgs e)
        {
            string strtenCoChua = "";
            dgrhonloanNV.DataSource = hLoanNV.GetCoChuaten(strtenCoChua);
            txtgiatri.Text = "";
            txtgiatri.Focus();
        }
    }
}
