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
    public partial class fLoaiNhanVien : Form
    {
        LoaiNhanVienController ctrl=new LoaiNhanVienController();
        public fLoaiNhanVien()
        {
            InitializeComponent();
        }

        private void fLoaiNhanVien_Load(object sender, EventArgs e)
        {
            ctrl.HienThi(textBox1,textBox2,dataGridView1,bindingNavigator1);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
           if (MessageBox.Show("Bạn chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                IEnumerator ie = dataGridView1.SelectedRows.GetEnumerator();
                while (ie.MoveNext())
                {
                    DataGridViewRow rows = (DataGridViewRow)ie.Current;
                    dataGridView1.Rows.Remove(rows);
                }
            }
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void toolStripButtonLuu_Click(object sender, EventArgs e)
        {
            ctrl.Update();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (!textBox1.Text.Substring(0, 3).Equals("MNV"))
            {
                MessageBox.Show("Mã loại nhân viên bị sai. Phải nhập MNV ở đầu mã loại!!!!!!!");
                e.Cancel = true;
            }
        }

        
    }
}