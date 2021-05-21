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
    public partial class frmKhachHang : Form
    {
        BindingSource bsCT;
        IEnumerable<KhachHang> listKhachHang;
        clsKhachHang p;
        public frmKhachHang()
        {
            InitializeComponent();
            p = new clsKhachHang();
            bsCT = new BindingSource();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            listKhachHang = p.GetAllKhachHang();
            bsCT.DataSource = listKhachHang;
            dgrKhachHang.DataSource = bsCT;
            bindingNavigatorKhachHang.BindingSource = bsCT;
            tieuDe(dgrKhachHang);
        }

        private void tieuDe(DataGridView dgrKhachHang)
        {
            dgrKhachHang.Columns["maKH"].HeaderText = "Mã khách hàng";
            dgrKhachHang.Columns["hoTenKH"].HeaderText = "Họ tên khách hàng";
            dgrKhachHang.Columns["hoTenKH"].Width = 250;
            dgrKhachHang.Columns["gioiTinh"].HeaderText = "Giới tính";
            dgrKhachHang.Columns["SDT"].HeaderText = "Số điện thoại";
            dgrKhachHang.Columns["diaChi"].HeaderText = "Địa chỉ";
            dgrKhachHang.Columns["diaChi"].Width = 550;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            dgrKhachHang.EndEdit();
            p.LuuTru();
            this.DialogResult = DialogResult.OK;
        }

        private void frmCongTy_FormClosing(object sender, FormClosingEventArgs e)
        {
            dgrKhachHang.EndEdit();
            p.LuuTru();
            this.DialogResult = DialogResult.OK;
        }
    }
}
