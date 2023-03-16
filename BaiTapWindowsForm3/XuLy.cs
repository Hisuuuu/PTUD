using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWindowsForm3
{
    internal class XuLy
    {
        public static void TachChuoi(string hoten, ref string s1, ref string s2)
        {
            int firstIndexOfName = hoten.LastIndexOf(' ') + 1;

            //s1 store surname
            s1 = hoten.Substring(0, firstIndexOfName);

            //s2 store name
            s2 = hoten.Substring(firstIndexOfName, hoten.Length-firstIndexOfName);

        }

        public static bool ThuTu(int n1, int n2)
        {
            bool kQ = true;

            if(n2 == n1 + 1)
            {
                kQ = true;
            }    
            else
            {
                kQ = false;
            }

            return kQ;
        }
    }
}
