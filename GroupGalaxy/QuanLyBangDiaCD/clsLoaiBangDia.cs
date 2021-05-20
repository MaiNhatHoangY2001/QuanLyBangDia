using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBangDiaCD
{
    class clsLoaiBangDia : clsKetNoi
    {
        qlCDDataContext dt;
        public clsLoaiBangDia()
        {
            dt = GetDataContext();
        }
        public IEnumerable<LoaiBangDia> GetAllLoaiBangDia()
        {
            IEnumerable<LoaiBangDia> q = from n in dt.LoaiBangDias
                                         select n;
            return q;
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
