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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        clsNhanVien dtnv;
        private void TaoTieuDeCotNV(ListView lvw)
        {
            lvw.Columns.Add("Mã nhân viên", 100);
            lvw.Columns.Add("Họ tên", 100);
            lvw.Columns.Add("giới tính", 50);
            lvw.Columns.Add("Địa chỉ", 300);
            lvw.Columns.Add("Số điện thoại", 200);
            lvw.Columns.Add("Ca làm việc", 50);
            lvw.Columns.Add("Lương", 150);
            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
        }

        private void loadPhieuVaoListView(ListView lvwNhanVien, IEnumerable<NhanVien> dsNV)
        {
            lvwNhanVien.Items.Clear();
            ListViewItem lvw;
            foreach (NhanVien nv in dsNV)
            {
                lvw = new ListViewItem(nv.maNV);
                lvw.SubItems.Add(nv.hoTenNV);
                lvw.SubItems.Add(nv.gioiTinh);
                lvw.SubItems.Add(nv.diaChi);
                lvw.SubItems.Add(nv.SDT);
                lvw.SubItems.Add(nv.caLamViec.ToString());
                lvw.SubItems.Add(nv.luong.ToString());
                lvw.Tag = nv;
                lvw.ImageIndex = 0;
                lvwNhanVien.Items.Add(lvw);
            }
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {

            dtnv = new clsNhanVien();
            TaoTieuDeCotNV(lvwNhanVien);
            IEnumerable<NhanVien> dsNV = dtnv.GetAllNhanVien();
            loadPhieuVaoListView(lvwNhanVien, dsNV);
            txtTim.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTim.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void cboLoaiTim_SelectedIndexChanged(object sender, EventArgs e)
        {
            XuLyHoTroAutocomlet();
        }

        private void XuLyHoTroAutocomlet()
        {
            string maNV;
            IEnumerable<NhanVien> dsNV;

            dsNV = dtnv.GetAllNhanVien();
            txtTim.AutoCompleteCustomSource.Clear();
            if(cboLoaiTim.Text=="Tìm theo mã nhân viên")
            {
                foreach (NhanVien nv in dsNV)
                {
                    txtTim.AutoCompleteCustomSource.Add(nv.maNV);
                }
            }
            else
            {
                foreach (NhanVien nv in dsNV)
                {
                    txtTim.AutoCompleteCustomSource.Add(nv.hoTenNV);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lvwNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {

            NhanVien nv = null;
            if (lvwNhanVien.SelectedItems.Count > 0)
            {
                nv = (NhanVien)lvwNhanVien.SelectedItems[0].Tag;
                txtMaNV.Text = nv.maNV;
                txtHoTenNV.Text = nv.hoTenNV;
                radCa1.Checked = true;
                if (nv.gioiTinh.Trim().Equals("Nam"))
                {
                    radNamNV.Checked = true;
                    radNuNV.Checked = false;
                }
                else
                {
                    radNamNV.Checked = false;
                    radNuNV.Checked = true;
                }
                txtDiaChiNV.Text = nv.diaChi;
                txtLuongNV.Text = nv.luong.ToString();

            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (lvwNhanVien.SelectedItems.Count > 0)
            {
                DialogResult ketQua;
                NhanVien nv;
                ketQua = MessageBox.Show("Bạn có chắc xóa dòng này không?", "Hỏi xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (ketQua == DialogResult.Yes)
                {
                    int viTri = 0;
                    for (int i = 0; i < lvwNhanVien.SelectedItems.Count; i++)
                    {
                        viTri = lvwNhanVien.SelectedIndices[i];
                        nv = (NhanVien)lvwNhanVien.Items[viTri].Tag;
                        
                    }
                    IEnumerable<NhanVien> dsNV = dtnv.GetAllNhanVien();
                    loadPhieuVaoListView(lvwNhanVien, dsNV);
                }

            }
        }


        private void btnthem_Click(object sender, EventArgs e)
        {

            frmNhanVien frm = new QuanLyBangDiaCD.frmNhanVien();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                IEnumerable<NhanVien> dsNV = dtnv.GetAllNhanVien();
                loadPhieuVaoListView(lvwNhanVien, dsNV);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string strThongTinTim = txtTim.Text;
            int viTriTim = TimKiem(strThongTinTim);
            int viTriChonTruoc;
            if (viTriTim >= 0)
            {
                if (lvwNhanVien.SelectedItems.Count > 0)
                {
                    viTriChonTruoc = lvwNhanVien.SelectedIndices[0];
                    lvwNhanVien.Items[viTriChonTruoc].Selected = false;
                }
                lvwNhanVien.Items[viTriTim].Selected = true;
                lvwNhanVien.Focus();
            }
        }

        private int TimKiem(string strThongTinTim)
        {
            NhanVien nv;
            for (int i = 0; i < lvwNhanVien.Items.Count; i++)
            {
                nv = (NhanVien)lvwNhanVien.Items[i].Tag;
                if (cboLoaiTim.Text=="Tìm theo mã nhân viên")
                {
                    if (nv.maNV.Equals(strThongTinTim))
                        return i;
                }
                else
                {
                    if (nv.hoTenNV.Equals(strThongTinTim))
                        return i;
                }
            }
            return -1;
        }
    }
}
