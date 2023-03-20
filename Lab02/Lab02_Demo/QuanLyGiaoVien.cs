using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_Demo
{
    class QuanLyGiaoVien
    {
        List<GiaoVien> dsGiaoVien = new List<GiaoVien>();
        bool[] KiemTraDuyNhat;
        public GiaoVien this[int index]
        {
            get { return dsGiaoVien[index] as GiaoVien; }
            set { dsGiaoVien[index] = value; }
        }

        public QuanLyGiaoVien()
        {

        }
       /* public void SapXep(SoSanh ss)
        {
            dsGiaoVien.Sort(ss.GetType());
        }*/

        public bool Them (GiaoVien gv)
        {

            dsGiaoVien.Add(gv);
            return KiemTraDuyNhat[gv] = true;
        }

        public void Xoa(object temp, SoSanh ss)
        {

        }
        
    }
}
