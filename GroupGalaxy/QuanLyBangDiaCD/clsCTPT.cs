using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBangDiaCD
{
    class clsCTPT:clsKetNoi
    {
        qlCDDataContext dt;
        public clsCTPT()
        {
            dt = GetDataContext();
        }
        public IEnumerable<ChiTietPhieuThue> GetAllCongTy()
        {
            IEnumerable<ChiTietPhieuThue> q = from n in dt.ChiTietPhieuThues
                                    select n;
            return q;
        }
        public String getPhatSinhMa()
        {
            return dt.PhatSinhMa();
        }
        public ChiTietPhieuThue GetCTPhieuThue(string maCTPT)
        {
            ChiTietPhieuThue pt = (from n in dt.ChiTietPhieuThues
                            where n.maCTPT.Equals(maCTPT)
                            select n).FirstOrDefault();
            if (pt != null)
            {
                return pt;
            }
            return null;
        }
        public bool themCTPhieu(ChiTietPhieuThue pt)
        {
            System.Data.Common.DbTransaction item = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = item;
                if (GetCTPhieuThue(pt.maCTPT) != null)
                {
                    return false;
                }
                else
                {
                    dt.ChiTietPhieuThues.InsertOnSubmit(pt);
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
        public bool suaThongTinCTPT(ChiTietPhieuThue pt)
        {
            System.Data.Common.DbTransaction item = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = item;
                IEnumerable<ChiTietPhieuThue> q = (from n in dt.ChiTietPhieuThues
                                            where n.maPhieu.Equals(pt.maPhieu)
                                            select n);
               q.First().maBangDia = pt.maBangDia;
                q.First().soLuong = pt.soLuong;
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
