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
    public partial class NhanVienGiaoDich : Form
    {
        public NhanVienGiaoDich()
        {
            InitializeComponent();
            CBB_S_Y.SelectedIndex = 0;
            CBB_S_N.SelectedIndex = 0;
        }

        private void btnView_Click(object sender, EventArgs e)
        {

        }
    }
}
