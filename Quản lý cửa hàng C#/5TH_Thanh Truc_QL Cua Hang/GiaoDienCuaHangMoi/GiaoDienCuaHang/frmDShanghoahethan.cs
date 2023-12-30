using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using GiaoDienCuaHang.Controller;
namespace GiaoDienCuaHang
{
    public partial class frmDShanghoahethan : Form
    {
        HangHoaController ctrl = new HangHoaController();   
        public frmDShanghoahethan()
        {
            InitializeComponent();
        }

        private void frmDShanghoahethan_Load(object sender, EventArgs e)
        {
            ctrl.HienThiDataGridViewHHsaphethan(dataGridView1, bindingNavigator1);
        }
    }
}