﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyDaoTao.UserControls
{
    partial class NamTiet : UserControl
    {
        public NamTiet()
        {
            InitializeComponent();
        }

        public string MonHoc
        {
            get { return lblMonHoc.Text; }
            set { lblMonHoc.Text = value; }
        }

        public string PhongHoc
        {
            get { return lblPhong.Text; }
            set { lblPhong.Text = value; }
        }
    }
}
