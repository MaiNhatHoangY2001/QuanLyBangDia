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
            LoadCongTyToTree(treCongTy, dsCongTy);
            cboLoai.SelectedIndex = 0;
        }

        private void LoadCongTyToTree(TreeView treCongTy, IEnumerable<CongTy> dsCongTy)
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
            lvwDSBangDia.Columns.Add("Loại băng", 100);
            lvwDSBangDia.Columns.Add("Ngày sản xuất", 150);
            lvwDSBangDia.Columns.Add("Ghi chú", 100);
            lvwDSBangDia.Columns.Add("Giá", 100);


        }
        int i = 0;
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
            i = 1;
        }

        private void LoadBangDiaToLvw(ListView lvwDSBangDia, IEnumerable<ThongTinBangDia> dsBangDia)
        {
            lvwDSBangDia.Items.Clear();
            ListViewItem lvw;
            String ten = "";
            foreach (ThongTinBangDia dia in dsBangDia)
            {
                lvw = new ListViewItem(dia.maBangDia);
                lvw.SubItems.Add(dia.tenBangDia);
                lvw.SubItems.Add(dia.theLoai);

                if (dia.maLoai.Equals("ML001"))
                    ten = "CD";
                else if (dia.maLoai.Equals("ML002"))
                    ten = "VCD";
                else if (dia.maLoai.Equals("ML003"))
                    ten = "DVD";
                else if (dia.maLoai.Equals("ML004"))
                    ten = "CD-ROM";
                lvw.SubItems.Add(ten);
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
                cboLoai.SelectedItem = dia.LoaiBangDia.tenLoai;
                dtpNgaySX.Text = dia.ngaySX.ToString();
                txtGhiChu.Text = dia.ghiChu;
                txtGia.Text = dia.gia.ToString();
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
            if (i == 1)
            {
                if (kiemtra())
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
            else
            {
                MessageBox.Show("Bạn chưa chọn công ty để thêm", "Thông báo");
            }
        }

        private bool kiemtra()
        {
            if (txtMaBangDia.Equals(""))
            {
                return false;
            }
            if (txtTenBangDia.Equals(""))
            {
                return false;
            }
            if (txtTheLoai.Equals(""))
            {
                return false;
            }
            if (txtGhiChu.Equals(""))
            {
                return false;
            }
            if (txtGia.Equals(""))
            {
                return false;
            }
            return true;
        }



        private void btnThemCongTy_Click(object sender, EventArgs e)
        {
            frmCongTy frm = new QuanLyBangDiaCD.frmCongTy();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                IEnumerable<CongTy> dsCT = dtCongTy.GetAllCongTy();
                LoadCongTyToTree(treCongTy, dsCT);
            }
        }

        ThongTinBangDia TaoThongTinBangDia()
        {

            ThongTinBangDia dia = new ThongTinBangDia();
            dia.maBangDia = txtMaBangDia.Text;
            dia.tenBangDia = txtTenBangDia.Text;
            dia.theLoai = txtTheLoai.Text;
            dia.ngaySX = DateTime.Parse(dtpNgaySX.Text.ToString());
            dia.ghiChu = txtGhiChu.Text;
            dia.gia = decimal.Parse(txtGia.Text);

            string ma = "";
            if (cboLoai.SelectedItem.ToString().Equals("CD"))
                ma = "ML001";
            else if (cboLoai.SelectedItem.ToString().Equals("VCD"))
                ma = "ML002";
            else if (cboLoai.SelectedItem.ToString().Equals("DVD"))
                ma = "ML003";
            else if (cboLoai.SelectedItem.ToString().Equals("CD-ROM"))
                ma = "ML004";
            dia.maLoai = ma;
            dia.maCongTy = treCongTy.SelectedNode.Tag.ToString();
            return dia;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (treCongTy.SelectedNode.Level == 1)
            {
                ThongTinBangDia dia = TaoThongTinBangDia();
                if (dtDia.themDia(dia))
                {
                    IEnumerable<ThongTinBangDia> dsDia = dtDia.GetBangDiaThuocCongTy(treCongTy.SelectedNode.Tag.ToString());
                    LoadBangDiaToLvw(lvwDSBangDia, dsDia);
                    btnThem.Text = "Thêm";
                    btnLuu.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Trùng mã băng đĩa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvwDSBangDia.SelectedItems.Count > 0)
            {
                DialogResult ketQua;
                ThongTinBangDia dia;
                ketQua = MessageBox.Show("Bạn có chắc xóa dòng này không?", "Hỏi xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (ketQua == DialogResult.Yes)
                {
                    int viTri = 0;
                    for (int i = 0; i < lvwDSBangDia.SelectedItems.Count; i++)
                    {
                        viTri = lvwDSBangDia.SelectedIndices[i];
                        dia = (ThongTinBangDia)lvwDSBangDia.Items[viTri].Tag;
                        dtDia.xoaDia(dia);
                    }
                    IEnumerable<ThongTinBangDia> dsDia = dtDia.GetBangDiaThuocCongTy(treCongTy.SelectedNode.Tag.ToString());
                    LoadBangDiaToLvw(lvwDSBangDia, dsDia);
                    btnXoa.Enabled = false;
                }

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (treCongTy.SelectedNode.Level == 1)
            {
                
                ThongTinBangDia dia = TaoThongTinBangDia();
                dtDia.themDia(dia);
                IEnumerable<ThongTinBangDia> dsDia = dtDia.GetBangDiaThuocCongTy(treCongTy.SelectedNode.Tag.ToString());
                LoadBangDiaToLvw(lvwDSBangDia, dsDia);
                btnThem.Text = "Thêm";
                btnLuu.Enabled = false;
            }
        }

        private void btnXoaRong_Click(object sender, EventArgs e)
        {
            txtMaBangDia.Text = "";
            txtTenBangDia.Text = "";
            txtTheLoai.Text = "";
            txtGhiChu.Text = "";
            txtGia.Text = "";
            txtMaBangDia.Focus();
        }

        private void txtMaBangDia_Leave(object sender, EventArgs e)
        {
            string strma = txtMaBangDia.Text;
            if (!clsRegex.RegexMaBD(strma))
            {
                txtMaBangDia.SelectAll();
                txtMaBangDia.Focus();
                MessageBox.Show("Lỗi! Phải nhập đúng định dạng mã BDXXX (ví dụ: BD000)", 
                    "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if(kiemTraTrungMa())
            {
                txtMaBangDia.SelectAll();
                txtMaBangDia.Focus();
                MessageBox.Show("Đã trùng mã băng đĩa\nVui lòng nhập mã khác",
                    "Thông báo lỗi Trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool kiemTraTrungMa()
        {
            dtDia = new clsBangDia();
            IEnumerable<ThongTinBangDia> ds = dtDia.GetAllBangDia();
            foreach (ThongTinBangDia dia in ds)
            {
                if (dia.maBangDia.Equals(txtMaBangDia.Text))
                {
                    return true;
                }
            }
            return false;
        }

        private void txtTenBangDia_Leave(object sender, EventArgs e)
        {
            string name = txtTenBangDia.Text;
            if (!clsRegex.NameCheckCoSo(name))
            {
                txtTenBangDia.SelectAll();
                txtTenBangDia.Focus();
                MessageBox.Show("Lỗi! Phải nhập đúng định dạng tên \n tên phải viết Hoa chử cái đầu (ví dụ: Tây Du ký)",
                    "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTheLoai_Leave(object sender, EventArgs e)
        {
            string name = txtTheLoai.Text;
            if (!clsRegex.NameCheck(name))
            {
                txtTheLoai.SelectAll();
                txtTheLoai.Focus();
                MessageBox.Show("Lỗi! Phải nhập đúng định dạng thể loại \n tên phải viết Hoa chử cái đầu (ví dụ: Phim hành động)",
                    "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtGia_Leave(object sender, EventArgs e)
        {
            string gia = txtGia.Text;
            if (!clsRegex.kiemTraSoDouble(gia))
            {
                
                txtGia.SelectAll();
                txtGia.Focus();
                MessageBox.Show("Không được nhập chữ", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else 
            {
                double so = Convert.ToDouble(gia);
                if (so < 0)
                {
                    
                    txtGia.SelectAll();
                    txtGia.Focus();
                    MessageBox.Show("Không được nhập số bé hơn 0", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dtpNgaySX_Leave(object sender, EventArgs e)
        {
            DateTime ngay = dtpNgaySX.Value;
            DateTime now = DateTime.Now;
            if (!(ngay < now))
            {
                MessageBox.Show("Lỗi! ngày sản xuất phải trước ngày hiện tại",
                    "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
