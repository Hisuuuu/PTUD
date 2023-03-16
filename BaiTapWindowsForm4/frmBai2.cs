using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWindowsForm4
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnXepLoai_Click(object sender, EventArgs e)
        {
            float diemLyThuyet = float.Parse(tbDiemLyThuyet.Text);
            float diemThucHanh = float.Parse(tbDiemThucHanh.Text);
            float diemTrungBinh = (diemLyThuyet + diemThucHanh) / 2;

            if(diemLyThuyet < 5 || diemThucHanh < 5)
            {
                lblKetQuaXepLoai.Text = "Yếu";
            }
            else if(diemTrungBinh < 7)
            {
                lblKetQuaXepLoai.Text = "Trung Bình";
            }
            else if(7 <= diemTrungBinh && diemTrungBinh < 8)
            {
                lblKetQuaXepLoai.Text = "Khá";
            }
            else if (8 <= diemTrungBinh && diemTrungBinh < 9)
            {
                lblKetQuaXepLoai.Text = "Giỏi";
            }
            else if (diemTrungBinh >= 9)
            {
                lblKetQuaXepLoai.Text = "Xuất sắc";
            }
        }
    }
}
