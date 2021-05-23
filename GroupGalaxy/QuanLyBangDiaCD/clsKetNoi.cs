using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBangDiaCD
{
    public class clsKetNoi
    {
        qlCDDataContext dt;
        public qlCDDataContext GetDataContext()
        {
            // Data Source=DESKTOP-OAA28K1\SQLEXPRESS;Initial Catalog=QuanLyBangDia;User ID=sa;Password=sapassword
            string str = @"Data Source=DESKTOP-5MHUIA8\SQLEXPRESS2019;Initial Catalog=QuanLyBangDia;User ID=sa;Password=sapassword";
            //string str = @"Data Source=DESKTOP-OAA28K1\SQLEXPRESS;Initial Catalog=QuanLyBangDia;User ID=sa;Password=sapassword";
            //string str = @"Data Source=LAPTOP-40N5OBEP;Initial Catalog=QuanLyBangDia;Integrated Security=True";
            dt = new qlCDDataContext(str);
            dt.Connection.Open();
            return dt;
        }
    }
}
