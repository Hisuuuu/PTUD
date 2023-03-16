using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWindowsForm4
{
    internal class XuLy
    {
        public static string ChaoHoi(string hoTen, bool GioiTinh)
        {
            string thongBao = "Chào ";
            if (GioiTinh == true)
            {
                thongBao += "Ông " + hoTen;
            }
            else
            {
                thongBao += "Bà " + hoTen;
            }

            return thongBao;
        }

        public static int USCLN(int a, int b)
        {
            if (b == 0) return a;
            return USCLN(b, a % b);
        }
    }
}
