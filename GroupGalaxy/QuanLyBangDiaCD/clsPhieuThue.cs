using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBangDiaCD
{
    class clsPhieuThue : clsKetNoi
    {
        qlCDDataContext dt;

        public clsPhieuThue()
        {
            dt = GetDataContext();
        }

        public IEnumerable<dynamic> GetAllPhieuThue()
        {
            var q = from pt in dt.PhieuThues
                    join ctpt in dt.ChiTietPhieuThues on pt.maPhieu equals ctpt.maPhieu
                    join kh in dt.KhachHangs on pt.maKH equals kh.maKH
                    join nv in dt.NhanViens on pt.maNV equals nv.maNV
                    join bd in dt.ThongTinBangDias on ctpt.maBangDia equals bd.maBangDia
                    select new { pt.maPhieu, bd.tenBangDia, bd.LoaiBangDia, ctpt.soLuong, pt.ngayMuon, pt.ngayTra, nv.maNV };
            return q;
        }

        public IEnumerable<dynamic> GetPhieuThueThuocKhachHang(string maKhachHang)
        {
            if (maKhachHang.Trim().Equals(""))
            {
                var q = from pt in dt.PhieuThues
                        join ctpt in dt.ChiTietPhieuThues on pt.maPhieu equals ctpt.maPhieu
                        join kh in dt.KhachHangs on pt.maKH equals kh.maKH
                        join nv in dt.NhanViens on pt.maNV equals nv.maNV
                        join bd in dt.ThongTinBangDias on ctpt.maBangDia equals bd.maBangDia
                        join lbd in dt.LoaiBangDias on bd.maLoai equals lbd.maLoai
                        select new { pt.maPhieu, bd.tenBangDia, lbd.tenLoai, ctpt.soLuong, pt.ngayMuon, pt.ngayTra, nv.hoTenNV, bd.gia};
                return q;
            }
            else
            {
                var q = from pt in dt.PhieuThues
                        join ctpt in dt.ChiTietPhieuThues on pt.maPhieu equals ctpt.maPhieu
                        join kh in dt.KhachHangs on pt.maKH equals kh.maKH
                        join nv in dt.NhanViens on pt.maNV equals nv.maNV
                        join bd in dt.ThongTinBangDias on ctpt.maBangDia equals bd.maBangDia
                        join lbd in dt.LoaiBangDias on bd.maLoai equals lbd.maLoai
                        where pt.maKH.Equals(maKhachHang)
                        select new { pt.maPhieu, bd.tenBangDia, lbd.tenLoai, ctpt.soLuong, pt.ngayMuon, pt.ngayTra, nv.hoTenNV, bd.gia };
                return q;
            }

        }

        public PhieuThue GetPhieuThue(string maPhieu)
        {
            PhieuThue pt = (from n in dt.PhieuThues
                            where n.maPhieu.Equals(maPhieu)
                            select n).FirstOrDefault();
            if (pt != null)
            {
                return pt;
            }
            return null;
        }

        public bool themPhieu(PhieuThue pt)
        {
            System.Data.Common.DbTransaction item = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = item;
                if (GetPhieuThue(pt.maPhieu) != null)
                {
                    return false;
                }
                else
                {
                    dt.PhieuThues.InsertOnSubmit(pt);
                    dt.SubmitChanges();
                    dt.Transaction.Commit();
                    return true;
                }

            }
            catch (Exception ex)
            {
                dt.Transaction.Rollback();
                throw new Exception("Lỗi thêm " + ex.Message);
            }
        }
        public bool xoaPhieu(PhieuThue pt)
        {
            System.Data.Common.DbTransaction item = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = item;
                if (GetPhieuThue(pt.maPhieu) != null)
                {
                    dt.PhieuThues.DeleteOnSubmit(pt);
                    dt.SubmitChanges();
                    dt.Transaction.Commit();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                dt.Transaction.Rollback();
                throw new Exception("Lỗi Không xóa được " + ex.Message);
            }
        }
        public bool suaThongTinPT(PhieuThue pt)
        {
            System.Data.Common.DbTransaction item = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = item;
                IEnumerable<PhieuThue> q = (from n in dt.PhieuThues
                                            where n.maPhieu.Equals(pt.maPhieu)
                                            select n);
                q.First().maNV = pt.maNV;
                q.First().ngayMuon = pt.ngayMuon;
                q.First().ngayTra = pt.ngayTra;
                dt.SubmitChanges();
                dt.Transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                dt.Transaction.Rollback();
                throw new Exception("Lỗi sửa cd " + ex.Message);
            }
        }
   
    }
}
