using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBangDiaCD
{
    class clsBangDia : clsKetNoi
    {
        qlCDDataContext dt;
        public clsBangDia()
        {
            dt = GetDataContext();
        }
        public IEnumerable<ThongTinBangDia> GetBangDiaThuocCongTy(String maCongTy)
        {

            IEnumerable<ThongTinBangDia> q;
            if (maCongTy.Trim().Equals(""))
            {
                q = from n in dt.ThongTinBangDias
                    select n;
            }
            else
            {
                q = from n in dt.ThongTinBangDias
                    where n.maCongTy.Equals(maCongTy)
                    select n;
            }
                
            return q;
        }
        public ThongTinBangDia layThongTinDia(String maBangDia)
        {
            ThongTinBangDia dia = (from n in dt.ThongTinBangDias
                                   where n.maBangDia.Equals(maBangDia)
                                   select n).FirstOrDefault();
            if (dia != null)
            {
                return dia;
            }
            return null;
        }
        public bool themDia(ThongTinBangDia dia)
        {
            System.Data.Common.DbTransaction item = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = item;
                if (layThongTinDia(dia.maBangDia) != null)
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
            catch (Exception ex)
            {
                dt.Transaction.Rollback();
                throw new Exception("Lỗi thêm " + ex.Message);
            }
        }
        public bool suaThongTinDia(ThongTinBangDia diaSua)
        {
            System.Data.Common.DbTransaction item = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = item;
                IEnumerable<ThongTinBangDia> q = (from n in dt.ThongTinBangDias
                                                  where n.maBangDia.Equals(diaSua.maBangDia)
                                                  select n);
                dt.SubmitChanges();
                dt.Transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                dt.Transaction.Rollback();
                throw new Exception("Lỗi sửa cd " + ex.Message);
                return false;
            }
        }
        public bool xoaDia(ThongTinBangDia diaXoa)
        {
            System.Data.Common.DbTransaction item = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = item;
                if (layThongTinDia(diaXoa.maBangDia) != null)
                {
                    dt.ThongTinBangDias.DeleteOnSubmit(diaXoa);
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
    }
}
