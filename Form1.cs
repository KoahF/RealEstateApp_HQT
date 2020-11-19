using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstateApp_HQT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenNVGD_Click(object sender, EventArgs e)
        {
            NhanVienGiaoDich formNVGD = new NhanVienGiaoDich();
            formNVGD.Show();
        }

        private void btnOpenNVLT_Click(object sender, EventArgs e)
        {
            NhanVienLeTan formNVLT = new NhanVienLeTan();
            formNVLT.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOpenNVQLCN_Click(object sender, EventArgs e)
        {
            NhanVienQuanLy formNVQL = new NhanVienQuanLy();
            formNVQL.Show();
        }

        private void btnOpenNVS_Click(object sender, EventArgs e)
        {
            NhanVienSale formNVS = new NhanVienSale();
            formNVS.Show();
        }
    }
}
