using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWindowsForm3
{
    public partial class frmBai3 : Form
    {
        string s1;
        string s2;

        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnXemKetQua_Click(object sender, EventArgs e)
        {
            if(rdTachHoTen.Checked)
            {
                XuLy.TachChuoi(tbHoVaTen.Text, ref s1, ref s2);
                tbHo.Text = s1;
                tbTen.Text = s2;
            }
            else if(rdKiemTraHaiSoNguyenCoLienTiep.Checked)
            {
                if(XuLy.ThuTu(int.Parse(tbSoN1.Text), int.Parse(tbSoN2.Text)) == true)
                {
                    lbKetQua.Text = "Đây là hai số nguyên liên tiếp";
                }
                else
                {
                    lbKetQua.Text = "N1 và N2 không phải là hai số nguyên liên tiếp";
                }
            }
            else
            {
                lbKetQua.Text = "Khong co du lieu";
            }
        }
    }
}
