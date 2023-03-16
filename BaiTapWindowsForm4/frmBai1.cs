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
    public partial class frmBai1 : Form
    {
        List<SanPham> danhSachSanPham = new List<SanPham>();
        public frmBai1()
        {
            InitializeComponent();
        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            SanPham sanPhamMoi = new SanPham();
            sanPhamMoi.MaSanPham = tbMaSP.Text;
            sanPhamMoi.TenSanPham = tbTenSP.Text;
            sanPhamMoi.loaiSanPham = tbLoaiSP.Text;
            sanPhamMoi.NgaySanXuat = tbNgaySX.Text;

            danhSachSanPham.Add(sanPhamMoi);
        }

        private void btnHienThiThongTin_Click(object sender, EventArgs e)
        {
            foreach (SanPham item in danhSachSanPham)
            {
                if(tbMaSanPhamCanTim.Text == item.MaSanPham)
                {
                    tbMaSP.Text = item.MaSanPham;
                    tbTenSP.Text = item.TenSanPham;
                    tbLoaiSP.Text = item.loaiSanPham;
                    tbNgaySX.Text = item.NgaySanXuat;

                    break;
                }
            }
        }

        private void btnXemNamHetHanSD_Click(object sender, EventArgs e)
        {
            SanPham sanPhamMoi = new SanPham();
            sanPhamMoi.MaSanPham = tbMaSP.Text;
            sanPhamMoi.TenSanPham = tbTenSP.Text;
            sanPhamMoi.loaiSanPham = tbLoaiSP.Text;
            sanPhamMoi.NgaySanXuat = tbNgaySX.Text;

            lblNamHetHan.Text = sanPhamMoi.NamHetHan().ToString();
        }
    }
}
