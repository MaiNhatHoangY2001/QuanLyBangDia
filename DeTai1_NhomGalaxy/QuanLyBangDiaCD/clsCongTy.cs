using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBangDiaCD
{
    class clsCongTy : clsKetNoi
    {
        qlCDDataContext dt;
        public clsCongTy()
        {
            dt = GetDataContext();
        }
        public IEnumerable<CongTy> GetAllCongTy()
        {
            IEnumerable<CongTy> q = from n in dt.CongTies
                                    select n;
            return q;
        }
        public bool checkCongTy(string maCT)
        {
            CongTy pt = (from n in dt.CongTies
                                   where n.maCongTy.Equals(maCT)
                                   select n).FirstOrDefault();
            if (pt != null)
            {
                return true;
            }
            return false;
        }
        public bool LuuTru()
        {
            System.Data.Common.DbTransaction item = dt.Connection.BeginTransaction();

            try
            {
                dt.Transaction = item;
                dt.SubmitChanges();
                dt.Transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                dt.Transaction.Rollback();
                throw new Exception("Lỗi cập nhật " + ex.Message);
            }
        }
    }
}
