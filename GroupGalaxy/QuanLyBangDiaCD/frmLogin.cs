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
            if (txtMatKhau.Text.Equals("123") && txtTenDangNhap.Text.Equals("ABC"))
                this.DialogResult = DialogResult.OK;
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
