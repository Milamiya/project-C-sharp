using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GiaoDienCuaHang.Controller;

namespace GiaoDienCuaHang
{
    public partial class frmDonViTinh : Form
    {
        DonViTinhController ctrl = new DonViTinhController();
        public frmDonViTinh()
        {
            InitializeComponent();
        }

        private void frmDonViTinh_Load(object sender, EventArgs e)
        {
            ctrl.HienThi(textBox1,textBox2,dataGridView1, bindingNavigator1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ctrl.Update();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ctrl.Update();
        }
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban chac chan muon xoa khong?", "Đơn Vị Tính", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            
            {
                IEnumerator ie = dataGridView1.SelectedRows.GetEnumerator();
                while (ie.MoveNext())
                {
                    DataGridViewRow row = (DataGridViewRow)ie.Current;
                    dataGridView1.Rows.Remove(row);
                }
            }
            
        }
        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Đơn Vị Tính", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
         }

        private void toolStripButtonLuu_Click(object sender, EventArgs e)
        {
            ctrl.Update();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmTimKiemDVT tdvt = new frmTimKiemDVT();
            tdvt.Show();
        }

    }
}