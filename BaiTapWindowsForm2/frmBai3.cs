using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWindowsForm2
{
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnXemKetQua_Click(object sender, EventArgs e)
        {
            string ho = tbHo.Text;
            string ten = tbTen.Text;
            int soN = int.Parse(tbSoN.Text);

            string kq = "Chưa có dữ liệu";

            if(rdXemHoTen.Checked)
            {
                XuLy.NoiChuoi(ho, ten, ref kq);
                lblKetQua.Text = kq;
            }
            else if(rdTinhGiaiThuaCuaN.Checked)
            {
                lblKetQua.Text = XuLy.GiaiThua(soN).ToString();
            }
            else
            {
                lblKetQua.Text = kq;
            }
        }
    }
}
