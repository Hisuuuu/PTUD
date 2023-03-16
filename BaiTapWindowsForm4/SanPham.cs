using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace BaiTapWindowsForm4
{
    internal class SanPham
    {
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string loaiSanPham { get; set; }
        public string NgaySanXuat { get; set; }

        public SanPham()
        {

        }

        public int NamHetHan()
        {
            string ngaySanXuat = NgaySanXuat.Trim();
            int firstIndex = ngaySanXuat.LastIndexOf('/') + 1;
            string namSanXuat = ngaySanXuat.Substring(firstIndex, ngaySanXuat.Length - firstIndex);

            int namHetHan;
            namHetHan = int.Parse(namSanXuat) + 3;
            return namHetHan;
        }
    }
}
