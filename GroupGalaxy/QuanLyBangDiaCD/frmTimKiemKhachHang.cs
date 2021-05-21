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
    public partial class frmTimKiemKhachHang : Form
    {
        public frmTimKiemKhachHang()
        {
            InitializeComponent();
        }

        clsKhachHang kh;
        clsPhieuThue pt;

        private void frmTimKiemKhachHang_Load(object sender, EventArgs e)
        {
            radMaKH.Checked = true;
            kh = new clsKhachHang();
            pt = new clsPhieuThue();
            lvwDSPhieuThue.LargeImageList = imgLonKH;
            lvwDSPhieuThue.SmallImageList = imgNhoKH;
            TaoTieuDeCotKH(lvwDSKhachHang);
            TaoTieuDeCotPT(lvwDSPhieuThue);
            IEnumerable<KhachHang> dsKH = kh.GetAllKhachHang();
            loadDuLieuVaoListViewKH(dsKH, lvwDSKhachHang);
            txtTimKiem.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTimKiem.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void loadDuLieuVaoListViewKH(IEnumerable<KhachHang> dsKH, ListView lvw)
        {
            lvw.Items.Clear();
            ListViewItem item;
            foreach (KhachHang kh in dsKH)
            {
                item = GreateItemKH(kh);
                lvw.Items.Add(item);
            }
        }

        ListViewItem GreateItemKH(KhachHang kh)
        {
            ListViewItem lvwItem;
            lvwItem = new ListViewItem(kh.maKH);
            lvwItem.SubItems.Add(kh.hoTenKH);
            lvwItem.SubItems.Add(kh.gioiTinh);
            lvwItem.SubItems.Add(kh.SDT);
            lvwItem.SubItems.Add(kh.diaChi);
            lvwItem.Tag = kh;
            lvwItem.ImageIndex = 0;
            return lvwItem;
        }


        private void TaoTieuDeCotPT(ListView lvw)
        {
            lvw.Columns.Add("Mã Phiếu thuê", 100);
            lvw.Columns.Add("Mã khách hàng", 100);
            lvw.Columns.Add("Mã Nhân viên", 200);
            lvw.Columns.Add("Ngày mượn", 200);
            lvw.Columns.Add("Ngày Trả", 100);

            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
        }

        private void TaoTieuDeCotKH(ListView lvw)
        {
            lvw.Columns.Add("Mã khách hàng", 100);
            lvw.Columns.Add("Họ tên", 100);
            lvw.Columns.Add("Giới tính", 200);
            lvw.Columns.Add("Số điện thoại", 200);
            lvw.Columns.Add("Địa chỉ", 100);

            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
        }

        private void lvwDSKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maKH;
            if (lvwDSKhachHang.SelectedItems.Count > 0)
            {
                KhachHang k = (KhachHang)lvwDSKhachHang.SelectedItems[lvwDSKhachHang.SelectedItems.Count - 1].Tag;
                maKH = k.maKH;
                IEnumerable<dynamic> dsPT;

                dsPT = pt.GetPhieuThueThuocKhachHang(maKH);
                loadPhieuVaoListView(lvwDSPhieuThue, dsPT);
            }
        }

        private void loadPhieuVaoListView(ListView lvw, IEnumerable<dynamic> dsPT)
        {
            lvw.Items.Clear();
            ListViewItem item;
            foreach (dynamic p in dsPT)
            {
                item = GreateItemPT(p);
                lvw.Items.Add(item);
            }
        }

        private ListViewItem GreateItemPT(dynamic p)
        {
            ListViewItem lvwItem;
            lvwItem = new ListViewItem(p.maPhieu);
            lvwItem.SubItems.Add(p.maKH);
            lvwItem.SubItems.Add(p.maNV);
            lvwItem.SubItems.Add(p.ngayMuon.ToString());
            lvwItem.SubItems.Add(p.ngayTra.ToString());
            lvwItem.Tag = p;
            lvwItem.ImageIndex = 0;
            return lvwItem;
        }

        private void radMaKH_CheckedChanged(object sender, EventArgs e)
        {
            clsKhachHang kh = new clsKhachHang();
            IEnumerable<KhachHang> d = kh.GetAllKhachHang();
            XuLyHoTroAutocomlet(d);
        }

        private void radTenKH_CheckedChanged(object sender, EventArgs e)
        {
            clsKhachHang kh = new clsKhachHang();
            IEnumerable<KhachHang> dsKH = kh.GetAllKhachHang();
            XuLyHoTroAutocomlet(dsKH);
        }

        private void XuLyHoTroAutocomlet(IEnumerable<KhachHang> ds)
        {
            if (ds != null)
            {
                txtTimKiem.AutoCompleteCustomSource.Clear();
                if (radMaKH.Checked)
                {
                    foreach (KhachHang p in ds)
                    {
                        txtTimKiem.AutoCompleteCustomSource.Add(p.maKH);
                    }
                }
                else if (radTenKH.Checked)
                {
                    foreach (KhachHang p in ds)
                    {
                        txtTimKiem.AutoCompleteCustomSource.Add(p.hoTenKH);
                    }
                }
            }
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            string strThongTinTim = txtTimKiem.Text;
            int viTriTim = TimKiem(strThongTinTim);
            int viTriChonTruoc;
            //if(viTriTim!=-1)//tim thay
            if (viTriTim >= 0)
            {
                if (lvwDSKhachHang.SelectedItems.Count > 0)
                {
                    viTriChonTruoc = lvwDSKhachHang.SelectedIndices[0];
                    lvwDSKhachHang.Items[viTriChonTruoc].Selected = false;
                }
                lvwDSKhachHang.Items[viTriTim].Selected = true;
                lvwDSKhachHang.Focus();
            }
        }

        private int TimKiem(string strGiaTriTim)
        {
            KhachHang k;
            for (int i = 0; i < lvwDSKhachHang.Items.Count; i++)
            {
                k = (KhachHang)lvwDSKhachHang.Items[i].Tag;
                if (radMaKH.Checked)
                {
                    if (k.maKH.Equals(strGiaTriTim))
                        return i;
                }
                else
                {
                    if (k.hoTenKH.Equals(strGiaTriTim))
                        return i;
                }
            }
            return -1;
        }

        
    }
}
