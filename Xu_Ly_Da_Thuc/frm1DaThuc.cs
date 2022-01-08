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
    public partial class frm1DaThuc : Form
    {
        public frm1DaThuc()
        {
            InitializeComponent();
        }
        daThuc l1 = new daThuc();
        private void btnNhap_Click(object sender, EventArgs e)
        {
            try
            {
                double heSo = double.Parse(txtHeSo.Text);
                int soMu = int.Parse(txtSoMu.Text);

                //Lưu trữ đa thức
                Node donThuc = new Node(heSo, soMu);
                l1.AddLast(donThuc);
                //Thu gọn đa thức
                l1.thuGon();
                //Sắp xếp đa thức giảm dần
                l1.sapGiam();

                txtKetQua.Clear();
                txtKetQua.Text = l1.printList();

                txtHeSo.Clear();
                txtSoMu.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void frm1DaThuc_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btnDaoHam_Click(object sender, EventArgs e)
        {
            txtKetQuaDaoHam.Clear();
            txtKetQuaDaoHam.Text = l1.daoHam(int.Parse(nudBacDaoHam.Text)).printList();
        }

        private void btnNguyenHam_Click(object sender, EventArgs e)
        {
            txtKQNguyenHam.Clear();
            txtKQNguyenHam.Text = l1.nguyenHam().printList();
        }

        private void btnTinhTri_Click(object sender, EventArgs e)
        {
            double x=0;
            try
            {
                 x= double.Parse(txtX.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
          
            lblTinhTri.Text = "Giá trị của đa thức: " + Math.Round(l1.tinhTri(x), 2);
        }

        private void btnBac_Click(object sender, EventArgs e)
        {
            lblBacDaThuc.Text = "Bậc: " +l1.Head.SoMu.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtKetQua.Clear();
            txtKetQuaDaoHam.Clear();
            txtKQNguyenHam.Clear();
            txtX.Clear();

            nudBacDaoHam.Value = 1;
            lblBacDaThuc.Text = "Bậc: ";
            lblTinhTri.Text = "Giá trị của đa thức: ";

            l1.Clear();
        }

        private void txtSoMu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHeSo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKetQua_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
