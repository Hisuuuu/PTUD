using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWindowsForm3
{
    internal class TinhToan
    {
        public static long TinhTong(int n)
        {
            long kQ = 0;
            for(int i = 1; i <= n; i++)
            {
                kQ += i;
            }

            return kQ;
        }

        public static long TinhGiaiThua(int n)
        {
            long kQ = 1;
            for (int i = 1; i <= n; i++)
            {
                kQ *= i;
            }

            return kQ;
        }
    }
}
