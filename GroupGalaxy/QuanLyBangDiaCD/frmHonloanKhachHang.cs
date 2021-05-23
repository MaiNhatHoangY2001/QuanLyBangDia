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
    public partial class frmHonloanKhachHang : Form
    {
        string strmaKhachhang = "";
        clsHonloanKhachHang hLoanKH;
        public frmHonloanKhachHang()
        {
            InitializeComponent();
        }
        /*  public frmhonloanKhachHang(string strMa)// thêm vào
          {
              strmaKhachhang = strMa;
              InitializeComponent();
              this.Text = "Bạn vừa truyền vào " + strMa;
              btntheomaKH.Text = "Theo mã " + strMa;
          }*/
        private void frmhonloanKhachHang_Load(object sender, EventArgs e)
        {
            hLoanKH = new clsHonloanKhachHang();
            dgrhonloanKH.DataSource = hLoanKH.GetKhachhangcuaphieuthueHonLoan();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btntheomaKH_Click(object sender, EventArgs e)
        {
            dgrhonloanKH.DataSource = hLoanKH.Getmakhachhanghonloan(strmaKhachhang);
        }

        private void btnordermaKH_Click(object sender, EventArgs e)
        {
            dgrhonloanKH.DataSource = hLoanKH.GetOrdermakhachhang(strmaKhachhang);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKHtendau_Click(object sender, EventArgs e)
        {
            string strkhtendau = txtThongTin.Text;
            dgrhonloanKH.DataSource = hLoanKH.GetTenDauKhachhangHonLoan(strkhtendau);
        }

        private void btnKHtencuoi_Click(object sender, EventArgs e)
        {
            string strkhtencuoi = txtThongTin.Text;
            dgrhonloanKH.DataSource = hLoanKH.GetTenCuoikhachanghonloan(strkhtencuoi);
        }

        private void btntenchuadau_Click(object sender, EventArgs e)
        {
            string strtenchuaDau = txtThongTin.Text;
            dgrhonloanKH.DataSource = hLoanKH.GettenchuadauKH(strtenchuaDau);
        }

        private void btntencochua_Click(object sender, EventArgs e)
        {
            string strtenCoChua = "";
            dgrhonloanKH.DataSource = hLoanKH.GetCoChuatenKH(strtenCoChua);
            txtThongTin.Text = "";
            txtThongTin.Focus();
        }
    }
}
