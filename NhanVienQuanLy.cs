﻿using System;
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
    public partial class NhanVienQuanLy : Form
    {
        public NhanVienQuanLy()
        {
            InitializeComponent();
            cbxSelectTable.SelectedIndex = 1;
        }

        private void cbxSelectTable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
