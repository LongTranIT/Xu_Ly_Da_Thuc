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
    public partial class frm2DaThuc : Form
    {
        public frm2DaThuc()
        {
            InitializeComponent();
        }
        daThuc l1 = new daThuc();
        daThuc l2 = new daThuc();
        private void btnNhap1_Click(object sender, EventArgs e)
        {
            try
            {
                double heSo = double.Parse(txtHeSo1.Text);
                int soMu = int.Parse(txtSoMu1.Text);

                //Lưu trữ đa thức
                Node donThuc = new Node(heSo, soMu);
                l1.AddLast(donThuc);
                //Thu gọn đa thức
                l1.thuGon();
                //Sắp xếp đa thức giảm dần
                l1.sapGiam();

                txtDaThuc1.Clear();
                txtDaThuc1.Text = l1.printList();

                txtHeSo1.Clear();
                txtSoMu1.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        } private void btnNhap2_Click(object sender, EventArgs e)
        {
            try
            {
                double heSo = double.Parse(txtHeSo2.Text);
                int soMu = int.Parse(txtSoMu2.Text);

                //Lưu trữ đa thức
                Node donThuc = new Node(heSo, soMu);
                l2.AddLast(donThuc);
                //Thu gọn đa thức
                l2.thuGon();
                //Sắp xếp đa thức giảm dần
                l2.sapGiam();

                txtDaThuc2.Clear();
                txtDaThuc2.Text = l2.printList();

                txtHeSo2.Clear();
                txtSoMu2.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            txtKetQuaTong.Clear();
            txtKetQuaTong.Text = l1.tinhTong(l2).printList();
        }


        private void btnNhan_Click(object sender, EventArgs e)
        {
            txtKetQuaNhan.Clear();
            txtKetQuaNhan.Text = l1.tinhNhan(l2).printList();
        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            txtKetQuaHieu.Clear();
            txtKetQuaHieu.Text = l1.tinhHieu(l2).printList();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            txtKQChia.Clear();
            txtKQChia.Text = l1.tinhChia(l2)[0].printList();
            txtPhanDu.Text = l1.tinhChia(l2)[1].printList();
        }

        private void btnClear1_Click(object sender, EventArgs e)
        {
            l1.Clear();
            txtDaThuc1.Clear();

            txtKetQuaTong.Clear();
            txtKetQuaHieu.Clear();
            txtKetQuaNhan.Clear();
            txtKQChia.Clear();
            txtPhanDu.Clear();
        }

        private void btnClear2_Click(object sender, EventArgs e)
        {
            l2.Clear();
            txtDaThuc2.Clear();

            txtKetQuaTong.Clear();
            txtKetQuaHieu.Clear();
            txtKetQuaNhan.Clear();
            txtKQChia.Clear();
            txtPhanDu.Clear();
        }
    }
}
