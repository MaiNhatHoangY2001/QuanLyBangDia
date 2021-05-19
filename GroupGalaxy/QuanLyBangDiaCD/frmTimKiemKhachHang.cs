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
            if (lvwDSKhachHang.SelectedItems.Count > 0)//co chon
            {

                if (lvwDSKhachHang.SelectedItems.Count > 0)
                {
                    KhachHang k = (KhachHang)lvwDSKhachHang.SelectedItems[lvwDSKhachHang.SelectedItems.Count - 1].Tag;
                    maKH = k.maKH;
                    IEnumerable<PhieuThue> dsPT;

                    dsPT = pt.GetPhieuThueThuocKhachHang(maKH);
                    loadPhieuVaoListView(lvwDSPhieuThue, dsPT);
                    XuLyHoTroAutocomlet();

                }
            }
        }

        private void XuLyHoTroAutocomlet()
        {
            string maKH;
            IEnumerable<PhieuThue> dsPhieuThue;

            if (lvwDSKhachHang.SelectedItems.Count > 0)
            {
                KhachHang k = (KhachHang)lvwDSKhachHang.SelectedItems[lvwDSKhachHang.SelectedItems.Count - 1].Tag;
                maKH = k.maKH;
                dsPhieuThue = pt.GetPhieuThueThuocKhachHang(maKH);
                txtTimKiem.AutoCompleteCustomSource.Clear();
                if (radMaKH.Checked)
                {
                    foreach (PhieuThue p in dsPhieuThue)
                    {
                        txtTimKiem.AutoCompleteCustomSource.Add(p.maKH);
                    }
                }
                else if(radMaPT.Checked)
                {
                    foreach (PhieuThue p in dsPhieuThue)
                    {
                        txtTimKiem.AutoCompleteCustomSource.Add(p.maPhieu);
                    }
                }
            }
        }

        private void loadPhieuVaoListView(ListView lvw, IEnumerable<PhieuThue> dsPT)
        {
            lvw.Items.Clear();
            ListViewItem item;
            foreach (PhieuThue p in dsPT)
            {
                item = GreateItemPT(p);
                lvw.Items.Add(item);
            }
        }

        private ListViewItem GreateItemPT(PhieuThue p)
        {
            ListViewItem lvwItem;
            lvwItem = new ListViewItem(p.maPhieu);
            lvwItem.SubItems.Add(p.maKH);
            lvwItem.SubItems.Add(p.maNV);
            lvwItem.SubItems.Add(p.ngayMuon.ToString());
            lvwItem.SubItems.Add(p.ngayTra.ToString());
            lvwItem.Tag = kh;
            lvwItem.ImageIndex = 0;
            return lvwItem;
        }

        private void radMaKH_CheckedChanged(object sender, EventArgs e)
        {
            XuLyHoTroAutocomlet();
        }

        private void radMaPT_CheckedChanged(object sender, EventArgs e)
        {
            XuLyHoTroAutocomlet();
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            
        }
    }
}
