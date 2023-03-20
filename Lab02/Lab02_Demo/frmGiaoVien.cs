using System;
using System.Diagnostics;
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
    public partial class frmGiaoVien : Form
    {
        QuanLyGiaoVien dsGiaoVien;
        public frmGiaoVien()
        {
            InitializeComponent();
        }

        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            string lienhe = "http://it.dlu.edu.vn/e-learning/Default.aspx";
            this.linklblLienHe.Links.Add(0, lienhe.Length, lienhe);
            this.cboMaSo.SelectedItem = this.cboMaSo.Items[0];
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int i = this.lbDanhSachMH.SelectedItems.Count - 1;
            while (i >= 0)
            {
                this.lbMonHocDay.Items.Add(lbDanhSachMH.SelectedItems[i]);
                this.lbDanhSachMH.Items.Remove(lbDanhSachMH.SelectedItems[i]);
                i--;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = this.lbMonHocDay.SelectedItems.Count - 1;
            while (i >= 0)
            {
                this.lbDanhSachMH.Items.Add(lbMonHocDay.SelectedItems[i]);
                this.lbMonHocDay.Items.Remove(lbMonHocDay.SelectedItems[i]);
                i--;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            this.cboMaSo.Text = "";
            this.txtHoTen.Text = "";
            this.txtMail.Text = "";
            this.mtxtSoDT.Text = "";
            this.rdNam.Checked = true;
            for(int i = 0; i < chklbNgoaiNgu.Items.Count; i++)
            {
                chklbNgoaiNgu.SetItemChecked(i, false);
            }
            foreach(object ob in this.lbMonHocDay.Items)
            {
                this.lbDanhSachMH.Items.Add(ob);
            }
            this.lbMonHocDay.Items.Clear();
        }

        private void linklblLienHe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string s = e.Link.LinkData.ToString();
            Process.Start(s); //Process nằm trong thư viện System.Diagnostics
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            frmTBGiaoVien frm = new frmTBGiaoVien();
            frm.SetText(GetGiaoVien().ToString());
            frm.ShowDialog();
        }

        private GiaoVien GetGiaoVien()
        {
            string gt = "Nam";
            if (rdNu.Checked)
            {
                gt = "Nữ";
            }
            GiaoVien gv = new GiaoVien();
            gv.MaSo = this.cboMaSo.Text;
            gv.HoTen = this.txtHoTen.Text;
            gv.GioiTinh = gt;
            gv.NgaySinh = this.dtpNgaySinh.Value;
            gv.Mail = txtMail.Text;
            gv.SoDT = mtxtSoDT.Text;
            string ngoaingu = "";
            for(int i = 0; i < chklbNgoaiNgu.Items.Count; i++)
            {
                if(chklbNgoaiNgu.GetItemChecked(i))
                    ngoaingu += chklbNgoaiNgu.Items[i] + ";";
            }
            gv.NgoaiNgu = ngoaingu.Split(';');
            DanhMucMonHoc mh = new DanhMucMonHoc();
            foreach(object ob in lbMonHocDay.Items)
            {
                mh.Them(new MonHoc(ob.ToString()));
            }
            gv.dsMonHoc = mh;
            return gv;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            frmTimGiaoVien form = new frmTimGiaoVien();
            form.ShowDialog();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            GiaoVien gv = new GiaoVien();
            gv = GetGiaoVien();
            dsGiaoVien.Them(gv);
            if()
        }
        
    }
}
