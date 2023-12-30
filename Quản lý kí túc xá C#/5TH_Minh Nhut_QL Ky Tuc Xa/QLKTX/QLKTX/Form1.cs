using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLKTX.Controller;
namespace QLKTX
{
    public partial class Form1 : Form
    {
        NamHocCtrl control = new NamHocCtrl();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //control.HienThi(dataNamHoc, binNamHoc, txtMa, txtTen, dateNgayBatDau, dateNgayKetThuc);
        }

       

        
    }
}