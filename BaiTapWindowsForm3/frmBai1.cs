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
    public partial class frmBai1 : Form
    {
        List<NhanVien> danhSachNhanVien = new List<NhanVien>();
        public frmBai1()
        {
            InitializeComponent();
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            NhanVien nhanVienMoi = new NhanVien(tbMaNV.Text,tbHoTen.Text,tbNgaySinh.Text,
                double.Parse(tbHeSoLuong.Text), double.Parse(tbHeSoPhuCap.Text));

            danhSachNhanVien.Add(nhanVienMoi);
        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            NhanVien nhanVienMoi = new NhanVien(tbMaNV.Text, tbHoTen.Text, tbNgaySinh.Text,
                double.Parse(tbHeSoLuong.Text), double.Parse(tbHeSoPhuCap.Text));

            lblKetQuaTongLuong.Text = nhanVienMoi.TinhTongLuong().ToString();
        }

        private void btnHienThiThongTin_Click(object sender, EventArgs e)
        {
            foreach(NhanVien item in danhSachNhanVien)
            {
                if(item.MaNV == tbNhapMaNV.Text)
                {
                    tbMaNV.Text = item.MaNV;
                    tbHoTen.Text = item.HoTen;
                    tbNgaySinh.Text = item.NgaySinh;
                    tbHeSoLuong.Text = item.HeSoLuong.ToString();
                    tbHeSoPhuCap.Text = item.HeSoPhuCap.ToString();
                    break;
                }
            }
        }
    }
}
