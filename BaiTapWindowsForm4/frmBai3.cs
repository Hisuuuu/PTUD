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
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnXuatThongBao_Click(object sender, EventArgs e)
        {
            if(rdNam.Checked)
            {
                lblThongBao.Text = XuLy.ChaoHoi(tbHoTen.Text, true);
            }
            else
            {
                lblThongBao.Text = XuLy.ChaoHoi(tbHoTen.Text, false);
            }
        }

        private void btnTimUSCLN_Click(object sender, EventArgs e)
        {
            int soM = int.Parse(tbSoM.Text);
            int soN = int.Parse(tbSoM.Text);
            lblKetQua.Text = XuLy.USCLN(soM,soN).ToString();
        }
    }
}
