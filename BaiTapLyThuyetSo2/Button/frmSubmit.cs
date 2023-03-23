using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Button
{
    public partial class frmSubmit : Form
    {
        public frmSubmit()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã nhập thành công!");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtPassword.Clear();
            txtDescription.Clear();
        }
    }
}
