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
    public partial class frmTimKiemNhanVien : Form
    {
        public frmTimKiemNhanVien()
        {
            InitializeComponent();
        }

        clsCongTy city;
        clsNhanVien nv;

        private void frmTimKiemNhanVien_Load(object sender, EventArgs e)
        {
            radMaNV.Checked = true;
            city = new clsCongTy();
            nv = new clsNhanVien();
            lvwNhanVien.LargeImageList = imgLon;
            lvwNhanVien.SmallImageList = imgNho;
            TaoTieuDeCot(lvwNhanVien);
            IEnumerable<CongTy> dsCT = city.GetAllCongTy();
            lstCongTy.DisplayMember = "TenPhong";
            lstCongTy.ValueMember = "msPhong";
            lstCongTy.DataSource = dsCT;
            txtTimKiem.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTimKiem.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void TaoTieuDeCot(ListView lvw)
        {
            lvw.Columns.Add("Mã nhân viên", 100);
            lvw.Columns.Add("Họ tên", 100);
            lvw.Columns.Add("Số điện thoại", 200);
            lvw.Columns.Add("giới tính", 200);
            lvw.Columns.Add("Địa chỉ", 100);
            lvw.Columns.Add("Lương", 100);
            lvw.Columns.Add("Ca làm việc", 100);

            lvw.View = View.Details;
            lvw.GridLines = true;
            lvw.FullRowSelect = true;
        }

        private void lstCongTy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maCongTY;
            if (lstCongTy.SelectedIndex >= 0)//co chon
            {
                maCongTY = lstCongTy.SelectedValue.ToString();
                IEnumerable<NhanVien> dsMay;

                dsMay = nv.(strMaPhong);
                LoadMayToListView(lvwDSMay, dsMay);
                XuLyHoTroAutocomlet();
            }
        }
    }
}
