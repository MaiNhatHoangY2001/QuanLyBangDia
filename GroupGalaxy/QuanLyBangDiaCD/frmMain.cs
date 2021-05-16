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
    public partial class frmMain : Form
    {
        public frmMain(Login user)
        {
            InitializeComponent();
            this.Text = "Bạn đã đăng nhập tên " + user.TenDN + " mật khẩu là " + user.MatKhau;
        }
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuChucNangQLBD_Click(object sender, EventArgs e)
        {
            if (kiemTraTonTaiForm("frmBangDia") == false)
            {
                frmBangDia frm = new frmBangDia();
                frm.MdiParent = this;
                frm.Name = "frmBangDia";
                frm.Show();
            }
        }
        private bool kiemTraTonTaiForm(String tenForm)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name.Equals(tenForm))
                {
                    frm.Activate();
                    return true;
                }

            }
            return false;
        }

        private void mnuChucNangQLNV_Click(object sender, EventArgs e)
        {
            if (kiemTraTonTaiForm("frmNhanVien") == false)
            {
                frmNhanVien frm = new frmNhanVien();
                frm.MdiParent = this;
                frm.Name = "frmNhanVien";
                frm.Show();
            }
        }
    }
}

