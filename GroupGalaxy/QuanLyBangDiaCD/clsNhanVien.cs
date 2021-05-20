using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace QuanLyBangDiaCD
{
    class clsNhanVien : clsKetNoi
    {
        qlCDDataContext dt;

        public clsNhanVien()
        {
            dt = GetDataContext();
        }

        public IEnumerable<NhanVien> GetNhanVienTheoPhieuThue(string maPhieuThue)
        {
            IEnumerable<NhanVien> nv;
            if (maPhieuThue.Trim().Equals(""))
            {
                nv = from n in dt.NhanViens
                     select n;
            }
            else
            {
                nv = from n in dt.NhanViens
                     where n.maNV.Equals(maPhieuThue)
                     select n;
            }
            return nv;
        }

        public NhanVien GetNhaVien(string maNhanVien)
        {
            NhanVien nv = (from n in dt.NhanViens
                            where n.maNV.Equals(maNhanVien)
                            select n).FirstOrDefault();
            if (nv != null)
            {
                return nv;
            }
            return null;
        }

        public bool AddNhanVien(NhanVien nv)
        {
            DbTransaction item = dt.Connection.BeginTransaction();
            dt.Transaction = item;
            try
            {
                if (GetNhaVien(nv.maNV) != null)
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

        public bool UpdateNhanVien(NhanVien nv)
        {
            DbTransaction item = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = item;
                IEnumerable<NhanVien> q = (from n in dt.NhanViens
                                            where n.maNV.Equals(nv.maNV)
                                            select n);
                dt.SubmitChanges();
                dt.Transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                dt.Transaction.Rollback();
                throw new Exception("Lỗi sửa thông tin nhân viên " + ex.Message);
            }
        }

        public bool RemoveNhanVien(NhanVien nv)
        {
            DbTransaction item = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = item;
                if (GetNhaVien(nv.maNV) != null)
                {
                    dt.NhanViens.DeleteOnSubmit(nv);
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
