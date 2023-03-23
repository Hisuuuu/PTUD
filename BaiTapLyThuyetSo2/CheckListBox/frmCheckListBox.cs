using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckListBox
{
    public partial class frmCheckListBox : Form
    {
        public frmCheckListBox()
        {
            InitializeComponent();
        }

        private void clbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection items;
            items = this.clbMonHoc.CheckedItems;
            string s = "";
            foreach (object ob in items) 
            {
                s += ob.ToString()+ " ,";
            }
            if (s != "") //prevents on load
            {
                MessageBox.Show("Danh sách môn học: " + s);
            }
        }
    }
}
