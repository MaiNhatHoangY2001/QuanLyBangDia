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
