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
    public partial class frmbai2 : Form
    {
        public frmbai2()
        {
            InitializeComponent();
        }

        private void btnXemKetQua_Click(object sender, EventArgs e)
        {
            if(rdTinhTong.Checked)
            {
                lblKetQua.Text = TinhToan.TinhTong(int.Parse(tbSoN.Text)).ToString();
            }
            else if(rdTinhNGiaiThua.Checked)
            {
                lblKetQua.Text = TinhToan.TinhGiaiThua(int.Parse(tbSoN.Text)).ToString();
            }
            else
            {
                lblKetQua.Text = "error";
            }
        }
    }
}
