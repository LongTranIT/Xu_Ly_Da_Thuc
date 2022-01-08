using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xu_Ly_Da_Thuc
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnMotDaThuc_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frm1DaThuc frm1 = new frm1DaThuc();
            frm1.ShowDialog();
            this.Visible = true;
        }

        private void btnNhieuDaThuc_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frm2DaThuc frm2 = new frm2DaThuc();
            frm2.ShowDialog();
            this.Visible = true;
        }
    }
}
