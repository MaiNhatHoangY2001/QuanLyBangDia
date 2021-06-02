using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBangDiaCD
{
    public static class clsStaticSapXep
    {
        public static string FirstWord(this string s)
        {
            //s="Le Thi Tu"
            if (s != null && s.Length > 0)
            {
                //tach chuoi theo chuan 
                String[] list = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                return list[0];
            }
            return null;
        }
        public static String LastWordCuaTui(this string s)
        {
            if (s != null && s.Length > 0)
            {
                String[] list = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                return list[list.Length - 1];
            }
            return null;
        }
    }
}
