using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using BaoCaoThongKe.BusinessObject;
using BaoCaoThongKe.Controller;

namespace BaoCaoThongKe.Desktop
{
    public partial class DialogDoanhNghiep : Office2007Form
    {
        public DialogDoanhNghiep()
        {
            InitializeComponent();
        }

        public QL_DoanhNghiep_InFo DNInfo = new QL_DoanhNghiep_InFo();

        private void btn_chon_Click(object sender, EventArgs e)
        {
            if (dataGridViewX1.SelectedRows.Count > 0)
            {
                DNInfo.MaDoanhNghiep = Convert.ToInt32(dataGridViewX1.SelectedRows[0].Cells["MaDoanhNghiep"].Value.ToString());
                DNInfo.TenDoanhNghiep = dataGridViewX1.SelectedRows[0].Cells["TenDoanhNghiep"].Value.ToString();
                DNInfo.DiaChi = dataGridViewX1.SelectedRows[0].Cells["DiaChi"].Value.ToString();
                DNInfo.DienThoai = dataGridViewX1.SelectedRows[0].Cells["DienThoai"].Value.ToString();
                DNInfo.Fax = dataGridViewX1.SelectedRows[0].Cells["Fax"].Value.ToString();
                DNInfo.Email = dataGridViewX1.SelectedRows[0].Cells["Email"].Value.ToString();
                DNInfo.TrangWeb = dataGridViewX1.SelectedRows[0].Cells["TrangWeb"].Value.ToString();

                DialogResult = DialogResult.OK;
            }
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DialogDoanhNghiep_Load(object sender, EventArgs e)
        {
            QL_DoanhNghiep_Ctrl Dialog = new QL_DoanhNghiep_Ctrl();
            Dialog.ListDoanhNghiep(dataGridViewX1, bindingNavigator1);
        }

        private void dataGridViewX1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewX1.SelectedRows.Count > 0)
            {
                DNInfo.MaDoanhNghiep = Convert.ToInt32(dataGridViewX1.SelectedRows[0].Cells["MaDoanhNghiep"].Value.ToString());
                DNInfo.TenDoanhNghiep = dataGridViewX1.SelectedRows[0].Cells["TenDoanhNghiep"].Value.ToString();
                DNInfo.DiaChi = dataGridViewX1.SelectedRows[0].Cells["DiaChi"].Value.ToString();
                DNInfo.DienThoai = dataGridViewX1.SelectedRows[0].Cells["DienThoai"].Value.ToString();
                DNInfo.Fax = dataGridViewX1.SelectedRows[0].Cells["Fax"].Value.ToString();
                DNInfo.Email = dataGridViewX1.SelectedRows[0].Cells["Email"].Value.ToString();
                DNInfo.TrangWeb = dataGridViewX1.SelectedRows[0].Cells["TrangWeb"].Value.ToString();

                DialogResult = DialogResult.OK;
            }

        }
    }
}