using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class frmListBox : Form
    {
        public frmListBox()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int itemsSelect = lbDanhSach.SelectedItems.Count - 1;
            for(int i = 0; i < itemsSelect; i++)
            {
                lbDanhSachChon.Items.Add(lbDanhSach.SelectedItems[i]);
                lbDanhSach.Items.Remove(lbDanhSach.SelectedItems[i]);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int i = lbDanhSachChon.SelectedItems.Count - 1;
            while (i >= 0)
            {
                lbDanhSachChon.Items.RemoveAt(lbDanhSachChon.SelectedIndices[i] );
                i--;
            }
        }
    }
}
