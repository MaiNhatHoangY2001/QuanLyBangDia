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
    public partial class frmCongTy : Form
    {
        BindingSource bsCT;
        IEnumerable<CongTy> listCongTy;
        clsCongTy p;
        public frmCongTy()
        {
            InitializeComponent();
            p = new clsCongTy();
            bsCT = new BindingSource();
        }

        private void frmCongTy_Load(object sender, EventArgs e)
        {
            listCongTy = p.GetAllCongTy();
            bsCT.DataSource = listCongTy;
            dgrCongTy.DataSource = bsCT;
            bindingNavigatorCongTy.BindingSource = bsCT;
            tieuDe(dgrCongTy);
        }

        private void tieuDe(DataGridView dgrCongTy)
        {
            dgrCongTy.Columns["maCongTy"].HeaderText = "Mã công ty";
            dgrCongTy.Columns["tenCongTy"].HeaderText = "Tên công ty";
            dgrCongTy.Columns["tenCongTy"].Width = 150;
            dgrCongTy.Columns["diaChi"].HeaderText = "Địa chỉ";
            dgrCongTy.Columns["diaChi"].Width = 350;
            dgrCongTy.Columns["soDienThoai"].HeaderText = "Số điện thoại";
            dgrCongTy.Columns["soDienThoai"].Width = 150;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            dgrCongTy.EndEdit();
            p.LuuTru();
            this.DialogResult = DialogResult.OK;
        }

        private void frmCongTy_FormClosing(object sender, FormClosingEventArgs e)
        {
            dgrCongTy.EndEdit();
            p.LuuTru();
            this.DialogResult = DialogResult.OK;
        }
    }
}
