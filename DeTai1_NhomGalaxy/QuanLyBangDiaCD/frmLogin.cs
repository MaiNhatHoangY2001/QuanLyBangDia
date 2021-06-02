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
    public partial class frmLogin : Form
    {
        frmMain main = new frmMain();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int dem = 0;
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.Text.Equals("admin") && txtTenDangNhap.Text.Equals("admin"))
            {
                this.Hide();
                frmMain frm = new frmMain();
                frm.ShowDialog();
            }
            else if (txtMatKhau.Text.Equals("khachhang") && txtTenDangNhap.Text.Equals("khachhang"))
            {
                this.Hide();
                frmMain frm = new frmMain();
                frmMain.quyen = "khachhang";
                frm.ShowDialog();
            }
            else
            {
                dem++;
                MessageBox.Show("Sai thông tin");
            }
            if (dem >= 3)
            {
                MessageBox.Show("Quá số lần nhập thông tin");
                this.Close();
            }
        }

    }
}
