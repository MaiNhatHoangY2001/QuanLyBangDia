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
    public partial class frmTimKiemBangDia : Form
    {
        public frmTimKiemBangDia()
        {
            InitializeComponent();
        }

        clsCongTy city;
        clsBangDia bd;

        private void frmTimKiemNhanVien_Load(object sender, EventArgs e)
        {
            radMaBD.Checked = true;
            city = new clsCongTy();
            bd = new clsBangDia();
            lvwBangDia.LargeImageList = imgLon;
            lvwBangDia.SmallImageList = imgNho;
            TaoTieuDeCot(lvwBangDia);
            IEnumerable<CongTy> dsCT = city.GetAllCongTy();
            lstCongTy.DisplayMember = "tenCongTy";
            lstCongTy.ValueMember = "maCongTy";
            lstCongTy.DataSource = dsCT;
            txtTimKiem.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTimKiem.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void TaoTieuDeCot(ListView lvw)
        {
            lvw.Columns.Add("Mã Băng đĩa", 100);
            lvw.Columns.Add("Mã Loại", 100);
            lvw.Columns.Add("Mã Công ty", 100);
           // lvw.Columns.Add("mã CTPT", 200);
            lvw.Columns.Add("Tựa", 200);
            lvw.Columns.Add("Thể loại", 100);
            lvw.Columns.Add("Tình trạng", 100);
            lvw.Columns.Add("Ngày sản xuất", 100);
            lvw.Columns.Add("Ghi chú", 100);
            lvw.Columns.Add("Giá", 100);

            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
        }

        private void lstCongTy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maCongTY;
            if (lstCongTy.SelectedIndex >= 0)
            {
                maCongTY = lstCongTy.SelectedValue.ToString();
                IEnumerable<ThongTinBangDia> dsBD;

                dsBD = bd.GetBangDiaThuocCongTy(maCongTY);
                loadDuLieuVaoListView(lvwBangDia, dsBD);
                XuLyHoTroAutocomlet();
            }
        }

        private void loadDuLieuVaoListView(ListView lvw, IEnumerable<ThongTinBangDia> dsBD)
        {
            lvw.Items.Clear();
            ListViewItem item;
            foreach (ThongTinBangDia bd in dsBD)
            {
                item = GreateItem(bd);
                lvw.Items.Add(item);
            }
        }

        private ListViewItem GreateItem(ThongTinBangDia bd)
        {
            ListViewItem lvwItem;
            lvwItem = new ListViewItem(bd.maBangDia);
            lvwItem.SubItems.Add(bd.maLoai);
            lvwItem.SubItems.Add(bd.maCongTy);
            lvwItem.SubItems.Add(bd.tenBangDia);
            lvwItem.SubItems.Add(bd.theLoai);
            lvwItem.SubItems.Add(bd.ngaySX.ToString());
            lvwItem.SubItems.Add(bd.ghiChu);
            lvwItem.SubItems.Add(bd.gia.ToString());
            lvwItem.Tag = bd;//nhet vao de su dung muc dich khac (mu dich 1)
            lvwItem.ImageIndex = 0;
            return lvwItem;
        }

        private void radMaNV_CheckedChanged(object sender, EventArgs e)
        {
            XuLyHoTroAutocomlet();
        }

        //private void radTenNhanVien_CheckedChanged(object sender, EventArgs e)
        //{
        //    XuLyHoTroAutocomlet();
        //}

        private void XuLyHoTroAutocomlet()
        {
            string maBD;

            IEnumerable<ThongTinBangDia> dsBD;
            if (lstCongTy.SelectedIndex >= 0)
            {
                maBD = lstCongTy.SelectedValue.ToString();
                dsBD = bd.GetBangDiaThuocCongTy(maBD);
                txtTimKiem.AutoCompleteCustomSource.Clear();
                if (radMaBD.Checked)
                {
                    foreach (ThongTinBangDia bd in dsBD)
                    {
                        txtTimKiem.AutoCompleteCustomSource.Add(bd.maBangDia);
                    }
                }
                else
                {
                    foreach (ThongTinBangDia bd in dsBD)
                    {
                        txtTimKiem.AutoCompleteCustomSource.Add(bd.tenBangDia);
                    }
                }
            }
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            string strThongTinTim = txtTimKiem.Text;
            int viTriTim = TimKiem(strThongTinTim);
            int viTriChonTruoc;
            if (viTriTim >= 0)
            {
                if (lvwBangDia.SelectedItems.Count > 0)
                {
                    viTriChonTruoc = lvwBangDia.SelectedIndices[0];
                    lvwBangDia.Items[viTriChonTruoc].Selected = false;
                }
                lvwBangDia.Items[viTriTim].Selected = true;
                lvwBangDia.Focus();
            }
        }

        private int TimKiem(string strThongTinTim)
        {
            ThongTinBangDia bd;
            for (int i = 0; i < lvwBangDia.Items.Count; i++)
            {
                bd = (ThongTinBangDia)lvwBangDia.Items[i].Tag;
                if (radMaBD.Checked)
                {
                    if (bd.maBangDia.Equals(strThongTinTim))
                        return i;
                }
                else
                {
                    if (bd.tenBangDia.Equals(strThongTinTim))
                        return i;
                }
            }
            return -1;
        }
    }
}
