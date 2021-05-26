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

        private void loadNhanVienListView(ListView lvwNhanVien, IEnumerable<NhanVien> dsNV)
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
                lvw.SubItems.Add(string.Format("{0:#,000} VNĐ", Convert.ToDecimal(nv.luong.ToString()))); 
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
            loadNhanVienListView(lvwNhanVien, dsNV);
            txtTim.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTim.AutoCompleteSource = AutoCompleteSource.CustomSource;

            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            radNamNV.Checked = true;
            radCa1.Checked = true;
        }

        private void cboLoaiTim_SelectedIndexChanged(object sender, EventArgs e)
        {
            XuLyHoTroAutocomlet();
        }

        private void XuLyHoTroAutocomlet()
        {
            IEnumerable<NhanVien> dsNV;

            dsNV = dtnv.GetAllNhanVien();
            txtTim.AutoCompleteCustomSource.Clear();
            if (cboLoaiTim.Text == "Tìm theo mã nhân viên")
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


        private void lvwNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {

            NhanVien nv = null;
            if (lvwNhanVien.SelectedItems.Count > 0)
            {
                nv = (NhanVien)lvwNhanVien.SelectedItems[0].Tag;
                txtMaNV.Text = nv.maNV;
                txtHoTenNV.Text = nv.hoTenNV;
                int ca = (int)nv.caLamViec;
                if (ca == 1)
                {
                    radCa1.Checked = true;
                    radCa2.Checked = false;
                    radCa3.Checked = false;
                }
                else if (ca == 2)
                {
                    radCa1.Checked = false;
                    radCa2.Checked = true;
                    radCa3.Checked = false;
                }
                else
                {
                    radCa1.Checked = false;
                    radCa2.Checked = false;
                    radCa3.Checked = true;
                }
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
                txtSDT.Text = nv.SDT;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
            else
            {
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
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
                        dtnv.RemoveNhanVien(nv);
                    }
                    IEnumerable<NhanVien> dsNV = dtnv.GetAllNhanVien();
                    loadNhanVienListView(lvwNhanVien, dsNV);
                }
                btnXoa.Enabled = false;
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            NhanVien nv = TaoThongTinNhanVien();
            if (dtnv.AddNhanVien(nv))
            {
                IEnumerable<NhanVien> dsNV = dtnv.GetAllNhanVien();
                loadNhanVienListView(lvwNhanVien, dsNV);
            }
            else
            {
                MessageBox.Show("Trùng mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private NhanVien TaoThongTinNhanVien()
        {
            NhanVien nv = new NhanVien();
            nv.maNV = txtMaNV.Text;
            nv.luong = decimal.Parse(txtLuongNV.Text);
            nv.hoTenNV = txtHoTenNV.Text;
            if (radNamNV.Checked)
                nv.gioiTinh = "Nam";
            else
                nv.gioiTinh = "Nữ";
            nv.SDT = txtSDT.Text;
            nv.diaChi = txtDiaChiNV.Text;
            if (radCa1.Checked)
                nv.caLamViec = 1;
            else if (radCa2.Checked)
                nv.caLamViec = 2;
            else
                nv.caLamViec = 3;
            return nv;
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
                if (cboLoaiTim.Text == "Tìm theo mã nhân viên")
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            NhanVien nv = TaoThongTinNhanVien();
            dtnv.UpdateNhanVien(nv);
            IEnumerable<NhanVien> dsNV = dtnv.GetAllNhanVien();
            loadNhanVienListView(lvwNhanVien, dsNV);
            btnSua.Enabled = false;
        }

        private void btnXoaRong_Click(object sender, EventArgs e)
        {
            txtDiaChiNV.Clear();
            txtHoTenNV.Clear();
            txtLuongNV.Clear();
            txtMaNV.Clear();
            txtSDT.Clear();
            txtTim.Clear();
            
        }

        private void txtMaNV_Leave(object sender, EventArgs e)
        {
            string ma = txtMaNV.Text;
            if (!clsRegex.RegexMaNV(ma))
            {
                txtMaNV.SelectAll();
                txtMaNV.Focus();
                MessageBox.Show("Lỗi! Phải nhập đúng định dạng mã NVXXX (ví dụ: NV000)",
                    "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtHoTenNV_Leave(object sender, EventArgs e)
        {
            string ten = txtHoTenNV.Text;
            if (!clsRegex.FulNameCheck(ten))
            {
                txtHoTenNV.SelectAll();
                txtHoTenNV.Focus();
                MessageBox.Show("Lỗi! Phải nhập đúng định dạng tên \n tên phải viết Hoa chử cái đầu (ví dụ: Nguyễn Công phượng)",
                    "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtLuongNV_Leave(object sender, EventArgs e)
        {
            string gia = txtLuongNV.Text;
            if (!clsRegex.kiemTraSoDouble(gia))
            {

                txtLuongNV.SelectAll();
                txtLuongNV.Focus();
                MessageBox.Show("Không được nhập chữ", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double so = Convert.ToDouble(gia);
                if (so < 0)
                {

                    txtLuongNV.SelectAll();
                    txtLuongNV.Focus();
                    MessageBox.Show("Không được nhập số bé hơn 0", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtDiaChiNV_Leave(object sender, EventArgs e)
        {
            string diaChi = txtDiaChiNV.Text;
            if (!clsRegex.CheckDiaChi(diaChi))
            {
                txtDiaChiNV.SelectAll();
                txtDiaChiNV.Focus();
                MessageBox.Show("Địa chỉ không hợp lệ", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSDT_Leave(object sender, EventArgs e)
        {
            string sdt = txtSDT.Text;
            if (!clsRegex.PhoneCheck(sdt))
            {
                txtSDT.SelectAll();
                txtSDT.Focus();
                MessageBox.Show("Phải nhập đúng định dạng số điện thoại 0XX-XXXXXXX", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
