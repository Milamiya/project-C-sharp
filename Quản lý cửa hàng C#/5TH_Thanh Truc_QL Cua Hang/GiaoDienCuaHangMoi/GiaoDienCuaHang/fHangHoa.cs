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
    public partial class fHangHoa : Form
    {
        HangHoaController ctrl = new HangHoaController();
        public fHangHoa()
        {
            InitializeComponent();
        }

        private void fHangHoa_Load(object sender, EventArgs e)
        {
            ctrl.HienThiDataGridView(textBox1, textBox2, textBox4,comboBox1,dateTimePicker1,textBox3,textBox5, dataGridView1, bindingNavigator1);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ctrl.Update();
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                IEnumerator ie = dataGridView1.SelectedRows.GetEnumerator();

                while (ie.MoveNext())
                {
                    DataGridViewRow row = (DataGridViewRow)ie.Current;
                    dataGridView1.Rows.Remove(row);
                }
            }
            ctrl.Update();
        }

        private void bindingNavigator1_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmTimKiemHangHoa tkh = new frmTimKiemHangHoa();
            tkh.Show();
        }

        private void buttonReportHH_Click(object sender, EventArgs e)
        {
            frmThongKeHangHoatheoDVT tkhh2 = new frmThongKeHangHoatheoDVT();
            tkhh2.Show();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (!textBox1.Text.Substring(0, 2).Equals("HH"))
            {
                MessageBox.Show("Mã Hàng hóa bị sai. Phải nhập HH đầu!!!!!!!");
                e.Cancel = true;
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}