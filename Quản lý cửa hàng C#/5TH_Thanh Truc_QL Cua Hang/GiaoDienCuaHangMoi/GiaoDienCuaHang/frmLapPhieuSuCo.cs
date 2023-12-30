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
    public partial class frmLapPhieuSuCo : Form
    {
        PhieuSuCoController ctrller = new PhieuSuCoController();
        public frmLapPhieuSuCo()
        {
            InitializeComponent();
        }

        private void frmLapPhieuSuCo_Load(object sender, EventArgs e)
        {            
            ctrller.HienThiComboBox(comboBoxMSP);
            ctrller.HienThiListView(listView1);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            IEnumerator ie = listView1.SelectedItems.GetEnumerator();
            if (ie.MoveNext())
            {
                ListViewItem item = (ListViewItem)ie.Current;
                textBoxMPSC.Text = item.SubItems[1].Text;
                comboBoxMSP.Text = item.SubItems[2].Text;
                dateTimePicker1.Text = item.SubItems[3].Text;
                textBoxLD.Text = item.SubItems[4].Text;
                textBoxSL.Text = item.SubItems[5].Text;
                textBoxDG.Text = item.SubItems[6].Text;
                textBoxTT.Text = item.SubItems[7].Text;

            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            this.textBoxMPSC.Text = "";
            this.comboBoxMSP.Text = "";
            this.textBoxSL.Text = "";
            this.textBoxLD.Text = "";
            this.textBoxDG.Text = "";
            this.textBoxTT.Text = "";
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                IEnumerator ie = listView1.SelectedItems.GetEnumerator();

                while (ie.MoveNext())
                {
                    ListViewItem item = (ListViewItem)ie.Current;
                    listView1.Items.Remove(item);
                }
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int dg = Convert.ToInt32(textBoxDG.Text);
            int sl = Convert.ToInt32(textBoxSL.Text);
            int thanhtien = dg * sl;
            this.textBoxTT.Text = thanhtien.ToString();

            if (MessageBox.Show("Bạn muốn lưu thông tin này phải không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ctrller.Luu_PhieuSuCo(textBoxMPSC, comboBoxMSP, dateTimePicker1, textBoxLD, textBoxSL, textBoxDG, textBoxTT);
                ctrller.HienThiListView(listView1);
                
            }
        }

        private void buttonIn_Click(object sender, EventArgs e)
        {
            PrintDialog print = new PrintDialog();
            print.ShowDialog();
        }

             
    }
}