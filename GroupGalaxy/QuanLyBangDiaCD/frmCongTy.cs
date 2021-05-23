using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            this.DialogResult = DialogResult.OK;
        }

        private void dgrCongTy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgrCongTy_CellLeave(object sender, DataGridViewCellEventArgs e)
        {

        }

        private string regexCongTy = "^(CT[0-9]{3})$";

        private void ValidateByRow(Object sender, DataGridViewCellCancelEventArgs data)
        {
            DataGridViewRow row = dgrCongTy.Rows[data.RowIndex];
            DataGridViewCell trackMa = row.Cells[dgrCongTy.Columns["maCongTy"].Index];
            DataGridViewCell trackTen = row.Cells[dgrCongTy.Columns["tenCongTy"].Index];
            DataGridViewCell trackDiaChi = row.Cells[dgrCongTy.Columns["diaChi"].Index];
            DataGridViewCell trackSDT = row.Cells[dgrCongTy.Columns["soDienThoai"].Index];
            if (!(checkMaCongTy(trackMa) && checkTenCongTy(trackTen) && checkDiaChi(trackDiaChi) && checkSDT(trackSDT)))
            {

                btnLuu.Enabled = false;
            }
            else
            {
                btnLuu.Enabled = true;
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

        private bool checkTenCongTy(DataGridViewCell trackTen)
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

        private Boolean checkMaCongTy(DataGridViewCell cell)
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
            dgrCongTy.EndEdit();
            dgrCongTy.ClearSelection();
            for (int i = dgrCongTy.Rows.Count - 1; i > -1; i--)
            {
                DataGridViewRow row = dgrCongTy.Rows[i];
                if (!row.IsNewRow && row.Cells[0].Value == null)
                {
                    dgrCongTy.Rows.RemoveAt(i);
                }
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
        }
    }
}
