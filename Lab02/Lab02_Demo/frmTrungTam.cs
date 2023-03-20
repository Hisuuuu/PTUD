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
    public partial class frmTrungTam : Form
    {
        public frmTrungTam()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Reset();
        }

        void Reset()
        {
            this.cboMaHV.Text = "";
            this.txtHoTen.Text = "";
            this.dtpNgayDangKy.Value = DateTime.Now;
            this.rdNam.Checked = true;
            this.chkTiengAnhA.Checked = false;
            this.chkTiengAnhB.Checked = false;
            this.chkTinHocA.Checked = false;
            this.chkTinHocB.Checked = false;
            this.txtTongTien.Text = "";
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int s = 0;
            if (chkTinHocA.Checked)
            {
                s += int.Parse(lblTHA.Text.Split('.')[0]);
            }
            if (chkTinHocB.Checked)
            {
                s += int.Parse(lblTHB.Text.Split('.')[0]);
            }
            if (chkTiengAnhA.Checked)
            {
                s += int.Parse(lblTAA.Text.Split('.')[0]);
            }
            if (chkTiengAnhB.Checked)
            {
                s += int.Parse(lblTAB.Text.Split('.')[0]);
            }
            txtTongTien.Text = s.ToString() + ".000 đồng";
        }
    }
}
