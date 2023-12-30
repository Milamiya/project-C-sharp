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
    public partial class frmHocKi : Form
    {
        HocKiCtrl control = new HocKiCtrl();
        public frmHocKi()
        {
            InitializeComponent();
        }

        
        private void frmHocKi_Load(object sender, EventArgs e)
        {
            control.HienThi(dataDSHocKi, binHocKi,txtMaHocKi,txtTenHocKi,cmbNamHoc);
        }

        
        private void btnCapNhat_Click(object sender, EventArgs e)
        {            
            control.Update();

            dataDSHocKi.Refresh();
            dataDSHocKi.Rows[dataDSHocKi.Rows.Count - 1].Selected = true;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            txtMaHocKi.Text = control.GetMaSo(dataDSHocKi).ToString();
        }

        private void btnThemNamHoc_Click(object sender, EventArgs e)
        {
            frmNamHoc namhoc = new frmNamHoc();
            namhoc.ShowDialog();
            control.HienThi(dataDSHocKi, binHocKi, txtMaHocKi, txtTenHocKi, cmbNamHoc);
        }

       
    }
}