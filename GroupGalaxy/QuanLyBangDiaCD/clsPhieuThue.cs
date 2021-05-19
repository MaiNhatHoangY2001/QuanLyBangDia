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
    }
}
