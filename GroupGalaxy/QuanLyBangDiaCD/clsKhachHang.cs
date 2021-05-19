using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace QuanLyBangDiaCD
{
    class clsKhachHang : clsKetNoi
    {
        qlCDDataContext dt;

        public clsKhachHang()
        {
            dt = GetDataContext();
        }

        public IEnumerable<KhachHang> GetAllKhachHang()
        {
            IEnumerable<KhachHang> q = from n in dt.KhachHangs
                                       select n;
            return q;
        }

        public IEnumerable<KhachHang> GetKhachHangThuocPhieuThue(string maPhieuThue)
        {
            IEnumerable<KhachHang> kh;
            if (maPhieuThue.Trim().Equals(""))
            {
                kh = from n in dt.KhachHangs
                     select n;
            }
            else
            {
                kh = from n in dt.KhachHangs
                     where n.maKH.Equals(maPhieuThue)
                     select n;
            }
            return kh;
        }

        public KhachHang GetKhachHang(string maKhachHang)
        {
            KhachHang kh = (from n in dt.KhachHangs
                            where n.maKH.Equals(maKhachHang)
                            select n).FirstOrDefault();
            if (kh != null)
            {
                return kh;
            }
            return null;
        }

        public bool UpdateKhachHang(KhachHang kh)
        {
            DbTransaction item = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = item;
                IEnumerable<KhachHang> q = (from n in dt.KhachHangs
                                                  where n.maKH.Equals(kh.maKH)
                                                  select n);
                dt.SubmitChanges();
                dt.Transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                dt.Transaction.Rollback();
                throw new Exception("Lỗi sửa thông tin khách hàng " + ex.Message);
                return false;
            }
        }

        public bool AddKhachHang(KhachHang kh)
        {
            DbTransaction item = dt.Connection.BeginTransaction();
            dt.Transaction = item;
            try
            {
                if (GetKhachHang(kh.maKH) != null)
                {
                    return false;
                }
                else
                {
                    dt.SubmitChanges();
                    dt.Transaction.Commit();
                    return true;
                }
            }
            catch (Exception e)
            {
                dt.Transaction.Rollback();
                throw new Exception("Lỗi thêm " + e.Message);
            }

        }

        public bool RemoveKhachHang(KhachHang kh)
        {
            DbTransaction item = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = item;
                if (GetKhachHang(kh.maKH) != null)
                {
                    dt.KhachHangs.DeleteOnSubmit(kh);
                    dt.SubmitChanges();
                    dt.Transaction.Commit();
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                dt.Transaction.Rollback();
                throw new Exception("Lỗi không xóa được " + e.Message);
            }
        }
    }
}
