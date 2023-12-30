using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using GiaoDienCuaHang.Controller;
using System.Windows.Forms;

namespace GiaoDienCuaHang
{
    public partial class frmLapPhieuNhanHang : Form
    {
        int tongtien = 0;
        PhieuNhanHangController ctrl = new PhieuNhanHangController();
        ChiTietPhieuNhanHangController ctrlchitiet = new ChiTietPhieuNhanHangController();
        
        public frmLapPhieuNhanHang()
        {
            InitializeComponent();
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void frmLapPhieuNhanHang_Load(object sender, EventArgs e)
        {
            ctrl.HienThiComboBox(comboBoxMANCC, comboBoxMANV, comboBoxMASP,comboBoxMPDH);
            ctrl.HienThiListView(listViewpnh);

        }

       

        private void listViewpnh_SelectedIndexChanged(object sender, EventArgs e)
        {
            IEnumerator ie = listViewpnh.SelectedItems.GetEnumerator();
            if (ie.MoveNext())
            {
                ListViewItem item = (ListViewItem)ie.Current;

                textBox1.Text = item.SubItems[1].Text;
                comboBoxMANCC.Text = item.SubItems[2].Text;
                comboBoxMANV.Text = item.SubItems[3].Text;
                dateTimePicker1.Text = item.SubItems[4].Text;
                textBox5.Text = item.SubItems[5].Text;

                ctrlchitiet.HienThiListView(listView2, item.SubItems[1].Text);

            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            IEnumerator ie = listView2.SelectedItems.GetEnumerator();
            if (ie.MoveNext())
            {
                ListViewItem item = (ListViewItem)ie.Current;

                textBox6.Text = item.SubItems[1].Text;
                comboBoxMASP.Text = item.SubItems[2].Text;
                textBox2.Text = item.SubItems[3].Text;
                textBox3.Text = item.SubItems[4].Text;
                //textBox4.Text = item.SubItems[5].Text;
                comboBoxMPDH.Text = item.SubItems[6].Text;
            }
        }

        private void buttonThemCTPNH_Click(object sender, EventArgs e)
        {
            if(textBox6.Text!="" && comboBoxMASP.Text!="")
            {
                if(ctrl.KiemTraTTChiTietPhieuNhanHang(listView2,textBox6.Text,comboBoxMASP.Text))
                
                {
                    ListViewItem item = new ListViewItem();

                    int i = listView2.Items.Count;
                    i++;
                    item.Text = i.ToString();
                    item.SubItems.Add(textBox6.Text);
                    item.SubItems.Add(comboBoxMASP.Text);
                    item.SubItems.Add(textBox2.Text);
                    item.SubItems.Add(textBox3.Text);
                    int dg = Convert.ToInt32(textBox2.Text);
                    int sl = Convert.ToInt32(textBox3.Text);
                    int thanhtien = dg * sl;
                    tongtien += thanhtien;
                    textBox5.Text = tongtien.ToString();
                    
                    item.SubItems.Add(thanhtien.ToString());
                    item.SubItems.Add(comboBoxMPDH.Text);
                    item.SubItems.Add(comboBoxMASP.SelectedValue.ToString());

                    listView2.Items.Add(item);
                    
                }
                this.comboBoxMASP.Text = "";
                this.textBox2.Text = "";
                this.textBox3.Text = "";
                this.comboBoxMPDH.Text = "";
            }
            else MessageBox.Show("Bạn chưa chọn mã phiếu và mã sản phẩm hoặc chưa chọn mã phiếu hoặc chưa chọn mã sản phẩm. Vui lòng kiểm tra lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
        }

        private void buttonXoaCTPNH_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn xóa phải không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                IEnumerator ie = listView2.SelectedItems.GetEnumerator();

                while (ie.MoveNext())
                {
                    ListViewItem item = (ListViewItem)ie.Current;
                    listView2.Items.Remove(item);
                }
            }
        }

        private void taskItemXoaPNH_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn xóa phải không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                IEnumerator ie = listViewpnh.SelectedItems.GetEnumerator();

                while (ie.MoveNext())
                {
                    ListViewItem item = (ListViewItem)ie.Current;
                    listViewpnh.Items.Remove(item);
                }
            }
        }

        private void taskItemLuuPNH_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn lưu thông tin này phải không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ctrl.Luu_PhieuNhanHang(textBox1, comboBoxMANCC, comboBoxMANV, dateTimePicker1, textBox5);
                ctrl.HienThiListView(listViewpnh);
                ctrl.Luu_CTPhieuNhanHang(listView2);
            }

        }

       
        private void taskItemInPNH_Click(object sender, EventArgs e)
        {
            PrintDialog print = new PrintDialog();
            print.ShowDialog();
        }

        private void taskItemThemPNH_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.comboBoxMANCC.Text = "";
            this.comboBoxMANV.Text = "";
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            this.textBox6.Text = this.textBox1.Text;
        }

        private void taskItemTimPDH_Click(object sender, EventArgs e)
        {
            frmTimKiemPhieuDatHang TKPDH = new frmTimKiemPhieuDatHang();
            TKPDH.Show();
        }

        private void taskItemTimPNH_Click(object sender, EventArgs e)
        {
            frmTimKiemPhieuNhanHang tkpnh = new frmTimKiemPhieuNhanHang();
            tkpnh.Show();
        }
        

        
    }
}