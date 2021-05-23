using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBangDiaCD
{
    class clsHonloanKhachHang : clsKetNoi
    {
        qlCDDataContext dt;
        public clsHonloanKhachHang()
        {
            dt = GetDataContext();
        }
        public IEnumerable<dynamic> GetKhachhangcuaphieuthueHonLoan()
        {

            var q = from n in dt.KhachHangs
                    join x in dt.PhieuThues
                    on n.maKH equals x.maKH
                    select new { n.maKH, x.maPhieu, n.hoTenKH, x.ngayMuon, x.ngayTra, n.gioiTinh, n.diaChi, n.SDT };
            return q;
        }
        public IEnumerable<dynamic> GetTenDauKhachhangHonLoan(string strTenDau)
        {

            var q = from n in dt.KhachHangs.AsEnumerable()
                    join x in dt.PhieuThues
                    on n.maKH equals x.maKH
                    where n.hoTenKH.FirstWord().Equals(strTenDau)
                    select new { n.maKH, x.maPhieu, n.hoTenKH, x.ngayMuon, x.ngayTra, n.gioiTinh, n.diaChi, n.SDT };
            return q.ToList();
        }
        public IEnumerable<dynamic> GetTenCuoikhachanghonloan(string strTenCuoi)
        {

            var q = from n in dt.KhachHangs.AsEnumerable()
                    join x in dt.PhieuThues
                    on n.maKH equals x.maKH
                    where n.hoTenKH.LastWordCuaTui().Equals(strTenCuoi)
                    select new { n.maKH, x.maPhieu, n.hoTenKH, x.ngayMuon, x.ngayTra, n.gioiTinh, n.diaChi, n.SDT };
            return q.ToList();
        }
        public IEnumerable<dynamic> Getmakhachhanghonloan(string strmakhachhang)
        {

            var q = from n in dt.KhachHangs
                    where n.maKH == strmakhachhang
                    join x in dt.PhieuThues
                    on n.maKH equals x.maKH


                    select new { n.maKH, x.maPhieu, n.hoTenKH, x.ngayMuon, x.ngayTra, n.gioiTinh, n.diaChi, n.SDT };

            return q.ToList();
        }
        public IEnumerable<dynamic> GetOrdermakhachhang(string strmakhachhang)
        {

            var q = from n in dt.KhachHangs
                    where n.maKH == strmakhachhang
                    join x in dt.PhieuThues
                    on n.maKH equals x.maKH

                    orderby x.maKH
                    select new { n.maKH, x.maPhieu, n.hoTenKH, x.ngayMuon, x.ngayTra, n.gioiTinh, n.diaChi, n.SDT }
                    ;
            return q;
        }
        public IEnumerable<dynamic> GettenchuadauKH(string strTenStart)
        {

            var q = from n in dt.KhachHangs
                    join x in dt.PhieuThues
                    on n.maKH equals x.maKH
                    where n.hoTenKH.StartsWith(strTenStart)
                    select new { n.maKH, x.maPhieu, n.hoTenKH, x.ngayMuon, x.ngayTra, n.gioiTinh, n.diaChi, n.SDT };
            return q;
        }
        public IEnumerable<dynamic> GetCoChuatenKH(string strChua)
        {

            var q = from n in dt.KhachHangs
                    join x in dt.PhieuThues
                    on n.maKH equals x.maKH
                    where n.hoTenKH.Contains(strChua)
                    select new { n.maKH, x.maPhieu, n.hoTenKH, x.ngayMuon, x.ngayTra, n.gioiTinh, n.diaChi, n.SDT };
            return q;
        }

    }
}
