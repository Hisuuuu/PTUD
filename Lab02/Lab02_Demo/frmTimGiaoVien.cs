using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_Demo
{
    public partial class frmTimGiaoVien : Form
    {
        KieuTim temp;
        public frmTimGiaoVien()
        {
            InitializeComponent();
        }

        private void rdMaGV_CheckedChanged(object sender, EventArgs e)
        {
            if (rdMaGV.Checked)
                lblTimTheo.Text = "Mã GV";
            temp = KieuTim.TheoMa;
        }

        private void rdTen_CheckedChanged(object sender, EventArgs e)
        {
            if (rdTen.Checked)
                lblTimTheo.Text = "Tên";
            temp = KieuTim.TheoHoten;
        }

        private void rdSoDT_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSoDT.Checked)
                lblTimTheo.Text = "Số ĐT";
            temp = KieuTim.TheoSDT;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
        }

        void TimKiem(KieuTim a)
        {
            
        }
    }
}
