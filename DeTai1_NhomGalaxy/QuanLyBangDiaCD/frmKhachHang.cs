using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTimKiemKhachHang frm = new frmTimKiemKhachHang();
            frm.ShowDialog();
        }
        private string regexCongTy = "^(KH[0-9]{3})$";

        private void ValidateByRow(Object sender, DataGridViewCellCancelEventArgs data)
        {
            DataGridViewRow row = dgrKhachHang.Rows[data.RowIndex];
            DataGridViewCell trackMa = row.Cells[dgrKhachHang.Columns["maKH"].Index];
            DataGridViewCell trackTen = row.Cells[dgrKhachHang.Columns["hoTenKH"].Index];
            DataGridViewCell trackGioiTinh = row.Cells[dgrKhachHang.Columns["gioiTinh"].Index];
            DataGridViewCell trackSDT = row.Cells[dgrKhachHang.Columns["SDT"].Index];
            DataGridViewCell trackDiaChi = row.Cells[dgrKhachHang.Columns["diaChi"].Index];
            if (!(checkKhachHang(trackMa) && checkTenKH(trackTen) && checkDiaChi(trackDiaChi) && checkSDT(trackSDT)) && checkGioiTinh(trackGioiTinh))
            {

                btnLuu.Enabled = false;
            }
            else
            {
                btnLuu.Enabled = true;
            }

        }

        private bool checkGioiTinh(DataGridViewCell trackGioiTinh)
        {
            if (trackGioiTinh.Value == null)
            {
                trackGioiTinh.ErrorText = "Không được để trống giới tính";
                return false;
            }
            else if (!(trackGioiTinh.Value.ToString().Equals("Nam") || trackGioiTinh.Value.ToString().Equals("nam") || trackGioiTinh.Value.ToString().Equals("Nữ") || trackGioiTinh.Value.ToString().Equals("nữ")))
            {
                trackGioiTinh.ErrorText = "Nhập giới tính không đúng (VD: phải nhập Nam hoặc Nữ)";
                return false;
            }
            else
            {
                trackGioiTinh.ErrorText = "";
                return true;
            }
        }

        private bool checkSDT(DataGridViewCell trackSDT)
        {
            if (trackSDT.Value == null)
            {
                trackSDT.ErrorText = "Không được để trống số điện thoại";
                return false;
            }
            else if (!clsRegex.PhoneCheck(trackSDT.Value.ToString()))
            {
                trackSDT.ErrorText = "Nhập số điện thoại không đúng (VD: phải nhập 0986435223)";
                return false;
            }
            else
            {
                trackSDT.ErrorText = "";
                return true;
            }
        }

        private bool checkDiaChi(DataGridViewCell trackDiaChi)
        {
            if (trackDiaChi.Value == null)
            {
                trackDiaChi.ErrorText = "Không được để trống địa chỉ";
                return false;
            }
            else if (!clsRegex.CheckDiaChi(trackDiaChi.Value.ToString()))
            {
                trackDiaChi.ErrorText = "Nhập địa chỉ không đúng (VD: phải nhập Hà Nội)";
                return false;
            }
            else
            {
                trackDiaChi.ErrorText = "";
                return true;
            }
        }

        private bool checkTenKH(DataGridViewCell trackTen)
        {
            if (trackTen.Value == null)
            {
                trackTen.ErrorText = "Không được để trống tên công ty";
                return false;
            }
            else if (!clsRegex.NameCheck(trackTen.Value.ToString()))
            {
                trackTen.ErrorText = "Nhập tên công ty không đúng (VD: phải nhập Hòa Bình)";
                return false;
            }
            else
            {
                trackTen.ErrorText = "";
                return true;
            }
        }

        private Boolean checkKhachHang(DataGridViewCell cell)
        {
            if (cell.Value == null)
            {
                cell.ErrorText = "Không được để trống mã công ty";
                return false;
            }
            else if (!Regex.Match(cell.Value.ToString(), regexCongTy).Success)
            {
                cell.ErrorText = "Nhập mã công ty không đúng (VD: phải nhập CT006)";
                return false;
            }
            else
            {
                cell.ErrorText = "";
                return true;
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dgrKhachHang.EndEdit();
            dgrKhachHang.ClearSelection();
            for (int i = dgrKhachHang.Rows.Count - 1; i > -1; i--)
            {
                DataGridViewRow row = dgrKhachHang.Rows[i];
                if (!row.IsNewRow && row.Cells[0].Value == null)
                {
                    dgrKhachHang.Rows.RemoveAt(i);
                }
            }
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            dgrKhachHang.EndEdit();
            dgrKhachHang.ClearSelection();
            for (int i = dgrKhachHang.Rows.Count - 1; i > -1; i--)
            {
                DataGridViewRow row = dgrKhachHang.Rows[i];
                if (!row.IsNewRow && row.Cells[0].Value == null)
                {
                    dgrKhachHang.Rows.RemoveAt(i);
                }
            }

        }
    }
}
