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

        public IEnumerable<PhieuThue> GetAllPhieuThue()
        {
            IEnumerable<PhieuThue> q = from n in dt.PhieuThues
                                    select n;
            return q;
        }

        public IEnumerable<PhieuThue> GetPhieuThueThuocKhachHang(string maKhachHang)
        {
            IEnumerable<PhieuThue> pt;
            if (maKhachHang.Trim().Equals(""))
            {
                pt = from n in dt.PhieuThues
                     select n;
            }
            else
            {
                pt = from n in dt.PhieuThues
                     where n.maKH.Equals(maKhachHang)
                     select n;
            }
            return pt;
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
