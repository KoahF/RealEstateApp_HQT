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
    public partial class NhanVienSale : Form
    {
        public NhanVienSale()
        {
            InitializeComponent();
            CBB_S_Y.SelectedIndex = 0;
            CBB_S_N.SelectedIndex = 0;
        }

        private void BTN_View_Y_Click(object sender, EventArgs e)
        {
            String value = CBB_S_Y.SelectedItem.ToString();
            
            if(value == "Khách Hàng")
            {
                Sale_KhachHang_Y formSKHY = new Sale_KhachHang_Y();
                formSKHY.Show();
            }
            else if(value == "Chủ Nhà")
            {
                Sale_ChuNha_Y formSCNY = new Sale_ChuNha_Y();
                formSCNY.Show();
            }
        }
    }
}
