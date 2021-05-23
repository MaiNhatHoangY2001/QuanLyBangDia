using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBangDiaCD
{
    class clsHonloannhanvien : clsKetNoi
    {
        qlCDDataContext dt;
        public clsHonloannhanvien()
        {
            dt = GetDataContext();
        }
        public IEnumerable<dynamic> GetnhanviencuaphieuthueHonLoan()
        {

            var q = from n in dt.NhanViens
                    join x in dt.PhieuThues
                    on n.maNV equals x.maNV
                    select new { NvPT = n.maNV, x.maPhieu, n.hoTenNV, x.ngayMuon, x.ngayTra, n.gioiTinh, n.diaChi, n.SDT, n.luong, n.caLamViec };
            return q;
        }
        public IEnumerable<dynamic> GetTenDauNhanvienHonLoan(string strTenDau)
        {

            var q = from n in dt.NhanViens.AsEnumerable()
                    join x in dt.PhieuThues
                     on n.maNV equals x.maNV
                    where n.hoTenNV.FirstWord().Equals(strTenDau)
                    select new { n.maNV, x.maPhieu, n.hoTenNV, x.ngayMuon, x.ngayTra, n.gioiTinh, n.diaChi, n.SDT, n.luong, n.caLamViec };
            return q.ToList();
        }
        public IEnumerable<dynamic> GetTenCuoiNhanvienHonLoan(string strTenCuoi)
        {

            var q = from n in dt.NhanViens.AsEnumerable()
                    join x in dt.PhieuThues
                     on n.maNV equals x.maNV
                    where n.hoTenNV.LastWordCuaTui().Equals(strTenCuoi)
                    select new { n.maNV, x.maPhieu, n.hoTenNV, x.ngayMuon, x.ngayTra, n.gioiTinh, n.diaChi, n.SDT, n.luong, n.caLamViec };
            return q.ToList();
        }
        public IEnumerable<dynamic> Getmanhanvienhonloan(string strmanhanvien)
        {

            var q = from n in dt.NhanViens
                    where n.maNV == strmanhanvien
                    join x in dt.PhieuThues
                    on n.maNV equals x.maNV

                    select new { n.maNV, x.maPhieu, n.hoTenNV, x.ngayMuon, x.ngayTra, n.gioiTinh, n.diaChi, n.SDT, n.luong, n.caLamViec }
                    ;
            return q;
        }
        public IEnumerable<dynamic> GetOrdermanhanvien(string strmanhanvien)
        {
            var q = from n in dt.NhanViens
                    where n.maNV == strmanhanvien
                    join x in dt.PhieuThues
                    on n.maNV equals x.maNV

                    orderby x.maNV
                    select new { n.maNV, x.maPhieu, n.hoTenNV, x.ngayMuon, x.ngayTra, n.gioiTinh, n.diaChi, n.SDT, n.luong, n.caLamViec }
                    ;
            return q;
        }
        public IEnumerable<dynamic> Gettenchuadau(string strTenStart)
        {

            var q = from n in dt.NhanViens
                    join x in dt.PhieuThues
                    on n.maNV equals x.maNV
                    where n.hoTenNV.StartsWith(strTenStart)
                    select new { n.maNV, x.maPhieu, n.hoTenNV, x.ngayMuon, x.ngayTra, n.gioiTinh, n.diaChi, n.SDT, n.luong, n.caLamViec };
            return q;
        }
        public IEnumerable<dynamic> GetCoChuaten(string strChua)
        {

            var q = from n in dt.NhanViens
                    join x in dt.PhieuThues
                    on n.maNV equals x.maNV
                    where n.hoTenNV.Contains(strChua)
                    select new { n.maNV, x.maPhieu, n.hoTenNV, x.ngayMuon, x.ngayTra, n.gioiTinh, n.diaChi, n.SDT, n.luong, n.caLamViec };
            return q;
        }

    }
}
