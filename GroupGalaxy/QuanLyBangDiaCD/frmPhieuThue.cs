using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBangDiaCD
{
    public partial class frmPhieuThue : Form
    {
        public frmPhieuThue()
        {
            InitializeComponent();
        }
        clsPhieuThue dtPhieuThue;
        clsKhachHang dtKhachHang;
        clsBangDia dtBangDia;
        clsNhanVien dtNhanVien;
        clsCTPT dtCTPT;
        TreeNode tree;

        private void frmBangDia_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            dtpNgayMuon.Format = DateTimePickerFormat.Custom;
            dtpNgayMuon.CustomFormat = "dd/MM/yyyy";
            dtpNgayTra.Format = DateTimePickerFormat.Custom;
            dtpNgayTra.CustomFormat = "dd/MM/yyyy";

            lvwDSPhieuThue.LargeImageList = imgLon;
            lvwDSPhieuThue.SmallImageList = imgNho;
            TieuDeLvw(lvwDSPhieuThue);
            tree = new TreeNode("Danh sách phiếu thuê");

            dtPhieuThue = new clsPhieuThue();
            dtKhachHang = new clsKhachHang();
            dtBangDia = new clsBangDia();
            dtNhanVien = new clsNhanVien();
            dtCTPT = new clsCTPT();

            treKhachHang.ImageList = imgTree;

            IEnumerable<ThongTinBangDia> dsBangDia = dtBangDia.GetAllBangDia();
            truyenVaoCboTenBangDia(cboTenBangDia,dsBangDia);
            IEnumerable<NhanVien> dsNhanVien = dtNhanVien.GetAllNhanVien();
            truyenVaoCboTenNhanVien(cboTenNV, dsNhanVien);

            IEnumerable<KhachHang> dsKhachHang = dtKhachHang.GetAllKhachHang();
            LoadKhachHangToTree(treKhachHang, dsKhachHang);
        }

        private void truyenVaoCboTenNhanVien(ComboBox cboTenNV, IEnumerable<NhanVien> dsNhanVien)
        {
            foreach (NhanVien dia in dsNhanVien)
            {
                cboTenNV.Items.Add(dia.hoTenNV);
            }
        }

        private void truyenVaoCboTenBangDia(ComboBox cboTenBangDia, IEnumerable<ThongTinBangDia> dsBangDia)
        {
            foreach (ThongTinBangDia dia in dsBangDia)
            {
                cboTenBangDia.Items.Add(dia.tenBangDia);
            }
        }

        private void LoadKhachHangToTree(TreeView treCongTy, IEnumerable<KhachHang> dsKhachHang)
        {
            treCongTy.Nodes.Clear();
            tree.Nodes.Clear();
            TreeNode treeCon;
            foreach (KhachHang kh in dsKhachHang)
            {
                treeCon = new TreeNode();
                treeCon.Text = kh.hoTenKH;
                treeCon.ImageIndex = 0;
                treeCon.SelectedImageIndex = 1;
                treeCon.Tag = kh.maKH;
                tree.Nodes.Add(treeCon);
            }
            treCongTy.Nodes.Add(tree);
            treCongTy.ExpandAll();
        }

        private void TieuDeLvw(ListView lvwDSPhieuThue)
        {
            lvwDSPhieuThue.View = View.Details;
            lvwDSPhieuThue.GridLines = true;
            lvwDSPhieuThue.FullRowSelect = true;
            lvwDSPhieuThue.Columns.Add("Mã phiếu thuê", 150);
            lvwDSPhieuThue.Columns.Add("Tên băng đĩa", 200);
            lvwDSPhieuThue.Columns.Add("Loại băng đĩa", 150);
            lvwDSPhieuThue.Columns.Add("Số lượng", 100);
            lvwDSPhieuThue.Columns.Add("Ngày mượn", 100);
            lvwDSPhieuThue.Columns.Add("Ngày trả", 100);
            lvwDSPhieuThue.Columns.Add("Nhân viên lập phiếu", 150);



        }

        private void treKhachHang_AfterSelect(object sender, TreeViewEventArgs e)
        {
            IEnumerable<dynamic> dsPhieuThue;
            string strMaKH = "";
            string strtenKH = "";
            if (treKhachHang.SelectedNode != null)
            {
                if (treKhachHang.SelectedNode.Level == 0)
                {
                    strMaKH = "";
                }
                else
                {
                    strMaKH = treKhachHang.SelectedNode.Tag.ToString();
                }
                dsPhieuThue = dtPhieuThue.GetPhieuThueThuocKhachHang(strMaKH);
                strtenKH = treKhachHang.SelectedNode.Text;
                if (strtenKH.Equals("Danh sách Khách hàng"))
                {
                    txtKhachHang.Text = "Tất cả khách hàng";
                }
                else
                    txtKhachHang.Text = strtenKH;
                LoadPhieuThueToLvw(lvwDSPhieuThue, dsPhieuThue);
            }
        }

        private void LoadPhieuThueToLvw(ListView lvwDSPhieuThue, IEnumerable<dynamic> dsPhieuThue)
        {
            lvwDSPhieuThue.Items.Clear();
            ListViewItem lvw;
            foreach (dynamic pt in dsPhieuThue)
            {
                lvw = new ListViewItem(pt.maPhieu);
                lvw.SubItems.Add(pt.tenBangDia.ToString());
                lvw.SubItems.Add(pt.tenLoai.ToString());
                lvw.SubItems.Add(pt.soLuong.ToString());
                DateTime dateTime1 = DateTime.Parse(pt.ngayMuon.ToString());
                lvw.SubItems.Add(dateTime1.ToString("dd/MM/yyyy"));
                DateTime dateTime2 = DateTime.Parse(pt.ngayTra.ToString());
                lvw.SubItems.Add(dateTime2.ToString("dd/MM/yyyy"));
                lvw.SubItems.Add(pt.hoTenNV.ToString());
                lvw.Tag = pt;
                lvw.ImageIndex = 0;
                lvwDSPhieuThue.Items.Add(lvw);
            }
        }
        private void lvwDSPhieuThue_SelectedIndexChanged(object sender, EventArgs e)
        {
            dynamic pt = null;
            if (lvwDSPhieuThue.SelectedItems.Count > 0)
            {
                pt = (dynamic)lvwDSPhieuThue.SelectedItems[0].Tag;
                txtMaPhieuThue.Text = pt.maPhieu;
                cboTenNV.SelectedItem = pt.hoTenNV;
                cboTenBangDia.SelectedItem = pt.tenBangDia;
                txtSoLuong.Text = pt.soLuong.ToString();
                dtpNgayMuon.Text = pt.ngayMuon.ToString();
                dtpNgayTra.Text = pt.ngayTra.ToString();
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
            }
            else
            {
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!btnThem.Text.Equals("Hủy Thêm"))
            {
                btnLuu.Enabled = true;
                btnThem.Text = "Hủy Thêm";
            }
            else
            {
                btnLuu.Enabled = false;
                btnThem.Text = "Thêm";

            }
        }
        PhieuThue TaoThongTinPhieuThue()
        {

            PhieuThue pt = new PhieuThue();
            pt.maPhieu = txtMaPhieuThue.Text;
            pt.ngayMuon = DateTime.Parse(dtpNgayMuon.Text.ToString());
            pt.ngayTra = DateTime.Parse(dtpNgayTra.Text.ToString());
            pt.maNV = dtNhanVien.layMaNVTuTenNV(cboTenNV.Text).maNV;
            pt.maKH = treKhachHang.SelectedNode.Tag.ToString();
            return pt;
        }
        ChiTietPhieuThue TaoThongTinChiTietPhieuThue()
        {
            ChiTietPhieuThue ctpt = new ChiTietPhieuThue();
            ctpt.maCTPT = dtCTPT.getPhatSinhMa();
            ctpt.maPhieu = txtMaPhieuThue.Text;
            ctpt.soLuong = Int32.Parse(txtSoLuong.Text);
            ctpt.maBangDia = dtBangDia.layMaDiaTuTenDia(cboTenBangDia.Text).maBangDia;
            return ctpt;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (treKhachHang.SelectedNode.Level == 1)
            {
                PhieuThue pt = TaoThongTinPhieuThue();
                ChiTietPhieuThue ctpt = TaoThongTinChiTietPhieuThue();
                dtPhieuThue.themPhieu(pt);
                dtCTPT.themCTPhieu(ctpt);
                IEnumerable<dynamic> dsPhieuThue = dtPhieuThue.GetPhieuThueThuocKhachHang(treKhachHang.SelectedNode.Tag.ToString());
                LoadPhieuThueToLvw(lvwDSPhieuThue, dsPhieuThue);
                btnThem.Text = "Thêm";
                btnLuu.Enabled = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvwDSPhieuThue.SelectedItems.Count > 0)
            {
                DialogResult ketQua;
                dynamic pt;
                PhieuThue ptXoa;
                ketQua = MessageBox.Show("Bạn có chắc xóa dòng này không?", "Hỏi xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (ketQua == DialogResult.Yes)
                {
                    int viTri = 0;
                    for (int i = 0; i < lvwDSPhieuThue.SelectedItems.Count; i++)
                    {
                        viTri = lvwDSPhieuThue.SelectedIndices[i];
                        pt = (dynamic)lvwDSPhieuThue.Items[viTri].Tag;
                        ptXoa = dtPhieuThue.GetPhieuThue(pt.maPhieu);
                        dtPhieuThue.xoaPhieu(ptXoa);
                    }
                    IEnumerable<dynamic> dsDia = dtPhieuThue.GetPhieuThueThuocKhachHang(treKhachHang.SelectedNode.Tag.ToString());
                    LoadPhieuThueToLvw(lvwDSPhieuThue, dsDia);
                    btnXoa.Enabled = false;
                }

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvwDSPhieuThue.SelectedItems.Count > 0)
            {
                PhieuThue pt = TaoThongTinPhieuThue();
                dtPhieuThue.suaThongTinPT(pt);
                ChiTietPhieuThue ctpt = TaoThongTinChiTietPhieuThue();
                dtCTPT.suaThongTinCTPT(ctpt);
                IEnumerable<dynamic> dsDia = dtPhieuThue.GetPhieuThueThuocKhachHang(treKhachHang.SelectedNode.Tag.ToString());
                LoadPhieuThueToLvw(lvwDSPhieuThue, dsDia);
                btnSua.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMaBangDia_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void btnXoaRong_Click(object sender, EventArgs e)
        {
            txtMaPhieuThue.Clear();
            txtSoLuong.Clear();
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang frm = new QuanLyBangDiaCD.frmKhachHang();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                IEnumerable<KhachHang> dsKH = dtKhachHang.GetAllKhachHang();
                LoadKhachHangToTree(treKhachHang, dsKH);
            }
        }
    }
}
