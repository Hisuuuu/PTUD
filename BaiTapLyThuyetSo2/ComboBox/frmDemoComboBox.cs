using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class frmDemoComboBox : Form
    {
        public frmDemoComboBox()
        {
            InitializeComponent();
        }

        private void frmDemoComboBox_Load(object sender, EventArgs e)
        {
            string[] datas = {"","Tiếng Anh", "Tiếng Pháp", "Tiếng Nhật" }; //"" is for not select anything on load
            this.cboNgoaiNgu.DataSource = datas;
        }

        private void cboNgoaiNgu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboNgoaiNgu.SelectedItem != "") 
            {
                MessageBox.Show(cboNgoaiNgu.SelectedItem.ToString());
            }
        }
    }
}
