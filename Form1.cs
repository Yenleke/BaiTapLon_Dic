using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLTC3
{
    public partial class Form1: Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void TinhToan(string phepToan)
        {
            int ts1 = int.Parse(txtTuso1.Text);
            int ms1 = int.Parse(txtMauso1.Text);
            int ts2 = int.Parse(txtTuso2.Text);
            int ms2 = int.Parse(txtMauso2.Text);

            Phanso ps1 = new Phanso(ts1, ms1);
            Phanso ps2 = new Phanso(ts2, ms2);
            Phanso kq = null;

            switch (phepToan)
            {
                case "+":
                    {
                        lbPheptinh.Text = "+";
                        kq = ps1.Cong(ps2);
                        break;
                    }
                case "-":
                    {
                        lbPheptinh.Text = "-";
                        kq = ps1.Tru(ps2);
                        break;
                    }
                case "*":
                    {
                        lbPheptinh.Text = "*";
                        kq = ps1.Nhan(ps2);
                        break;
                    }
                case "/":
                    {
                        lbPheptinh.Text = "/";
                        kq = ps1.Chia(ps2);
                        break;
                    }
            }

            txtTuso3.Text =kq.Tuso.ToString();
            txtMauso3.Text = kq.Mauso.ToString();
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            TinhToan("+");
        }

        private void btTru_Click(object sender, EventArgs e)
        {
            TinhToan("-");
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            TinhToan("*");
        }

        private void btChia_Click(object sender, EventArgs e)
        {
            TinhToan("/");
        }
    }
}
