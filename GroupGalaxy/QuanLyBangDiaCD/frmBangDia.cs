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
    public partial class frmBangDia : Form
    {
        public frmBangDia()
        {
            InitializeComponent();
        }
        clsBangDia dtDia;
        clsCongTy dtCongTy;
        TreeNode tree;

        private void frmBangDia_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            dtpNgaySX.Format = DateTimePickerFormat.Custom;
            dtpNgaySX.CustomFormat = "dd/MM/yyyy";

            lvwDSBangDia.LargeImageList = imgLon;
            lvwDSBangDia.SmallImageList = imgNho;
            TieuDeLvw(lvwDSBangDia);
            tree = new TreeNode("Danh sách công ty");
            dtDia = new clsBangDia();
            dtCongTy = new clsCongTy();
            treCongTy.ImageList = imgTree;
            IEnumerable<CongTy> dsCongTy = dtCongTy.GetAllCongTy();
            LoadPhongToTree(treCongTy, dsCongTy);
        }

        private void LoadPhongToTree(TreeView treCongTy, IEnumerable<CongTy> dsCongTy)
        {
            treCongTy.Nodes.Clear();
            tree.Nodes.Clear();
            TreeNode treeCon;
            foreach (CongTy congTy in dsCongTy)
            {
                treeCon = new TreeNode();
                treeCon.Text = congTy.tenCongTy;
                treeCon.ImageIndex = 0;
                treeCon.SelectedImageIndex = 1;
                treeCon.Tag = congTy.maCongTy;
                tree.Nodes.Add(treeCon);
            }
            treCongTy.Nodes.Add(tree);
            treCongTy.ExpandAll();
        }

        private void TieuDeLvw(ListView lvwDSBangDia)
        {
            lvwDSBangDia.View = View.Details;
            lvwDSBangDia.GridLines = true;
            lvwDSBangDia.FullRowSelect = true;
            lvwDSBangDia.Columns.Add("Mã băng đĩa", 100);
            lvwDSBangDia.Columns.Add("Tên băng đĩa", 200);
            lvwDSBangDia.Columns.Add("Thể loại", 150);
            lvwDSBangDia.Columns.Add("Tình trạng", 100);
            lvwDSBangDia.Columns.Add("Ngày sản xuất", 150);
            lvwDSBangDia.Columns.Add("Ghi chú", 100);
            lvwDSBangDia.Columns.Add("Giá", 100);


        }

        private void treCongTy_AfterSelect(object sender, TreeViewEventArgs e)
        {
            IEnumerable<ThongTinBangDia> dsBangDia;
            string strMaPhong = "";
            string strtenPhong = "";
            if (treCongTy.SelectedNode != null)
            {
                if (treCongTy.SelectedNode.Level == 0)
                {
                    strMaPhong = "";
                }
                else
                {
                    strMaPhong = treCongTy.SelectedNode.Tag.ToString();
                }
                dsBangDia = dtDia.GetBangDiaThuocCongTy(strMaPhong);
                strtenPhong = treCongTy.SelectedNode.Text;
                if (strtenPhong.Equals("Danh sách công ty"))
                {
                    txtCongTy.Text = "Tất cả công ty";
                }
                else
                    txtCongTy.Text = strtenPhong;

                LoadBangDiaToLvw(lvwDSBangDia, dsBangDia);
            }
        }

        private void LoadBangDiaToLvw(ListView lvwDSBangDia, IEnumerable<ThongTinBangDia> dsBangDia)
        {
            lvwDSBangDia.Items.Clear();
            ListViewItem lvw;
            foreach (ThongTinBangDia dia in dsBangDia)
            {
                lvw = new ListViewItem(dia.maBangDia);
                lvw.SubItems.Add(dia.tenBangDia);
                lvw.SubItems.Add(dia.theLoai);
                lvw.SubItems.Add(dia.tinhTrang);
                DateTime dateTime = DateTime.Parse(dia.ngaySX.ToString());
                lvw.SubItems.Add(dateTime.ToString("dd/MM/yyyy"));
                lvw.SubItems.Add(dia.ghiChu);
                lvw.SubItems.Add(string.Format("{0:#,000} VNĐ", Convert.ToDecimal(dia.gia.ToString())));
                lvw.Tag = dia;
                lvw.ImageIndex = 0;
                lvwDSBangDia.Items.Add(lvw);
            }
        }

        private void lvwDSBangDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            ThongTinBangDia dia = null;
            if (lvwDSBangDia.SelectedItems.Count > 0)
            {
                dia = (ThongTinBangDia)lvwDSBangDia.SelectedItems[0].Tag;
                txtMaBangDia.Text = dia.maBangDia;
                txtTenBangDia.Text = dia.tenBangDia;
                txtTheLoai.Text = dia.theLoai;
                if (dia.tinhTrang.Trim().Equals("Đúng hạn"))
                {
                    radDungHan.Checked = true;
                    radTreHan.Checked = false;
                }
                else
                {
                    radDungHan.Checked = false;
                    radTreHan.Checked = true;
                }
                dtpNgaySX.Text = dia.ngaySX.ToString();
                txtGhiChu.Text = dia.ghiChu;
                txtGia.Text = string.Format("{0:#,000}", Convert.ToDecimal(dia.gia.ToString()));
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
    }
}
