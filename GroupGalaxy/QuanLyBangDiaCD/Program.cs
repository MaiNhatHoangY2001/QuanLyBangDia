using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBangDiaCD
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //frmLogin frm = new frmLogin();
            //if (frm.ShowDialog() == DialogResult.OK)
            //{
            //    Login user = new Login(frm.txtTenDangNhap.Text, frm.txtMatKhau.Text);
            //    Application.Run(new frmMain(user));
            //}

            Application.Run(new frmTimKiemKhachHang());
        }
    }
}
