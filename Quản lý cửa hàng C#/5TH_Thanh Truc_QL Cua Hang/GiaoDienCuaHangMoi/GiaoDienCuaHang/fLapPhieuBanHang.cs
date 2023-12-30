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
    public partial class fLapPhieuBanHang : Form
    {
        int tongtien=0;
        PhieuBanHangController ctrl = new PhieuBanHangController();
        ChiTietPhieuBanHangController ctrlCT = new ChiTietPhieuBanHangController();
        public fLapPhieuBanHang()
        {
            InitializeComponent();
        }

        private void fLapPhieuBanHang_Load(object sender, EventArgs e)
        {
            ctrl.HienThiComboBox(comboBoxMKH, comboBoxMNV, comboBoxMSP);
            ctrl.HienThiListView(listView2);
           
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            IEnumerator ie = listView2.SelectedItems.GetEnumerator();
            listView1.Items.Clear();
            textBoxmp.Text = "";
            comboBoxMKH.Text = "";
            comboBoxMNV.Text = "";
            dateTimePicker1.Text = "";
            textBoxTT.Text = "";
            if (ie.MoveNext())
            {
                ListViewItem item = (ListViewItem)ie.Current;

                textBoxmp.Text = item.SubItems[1].Text;
                comboBoxMKH.Text=item.SubItems[2].Text;
                comboBoxMNV.Text = item.SubItems[3].Text;
                dateTimePicker1.Text = item.SubItems[4].Text;
                textBoxTT.Text = item.SubItems[5].Text;
                
                ctrlCT.HienThiListView(listView1,item.SubItems[1].Text);
            }
        }

        

        

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            IEnumerator ie = listView1.SelectedItems.GetEnumerator();
            if (ie.MoveNext())
            {
                ListViewItem item = (ListViewItem)ie.Current;
                textBoxCTMP.Text = item.SubItems[1].Text;
                comboBoxMSP.Text = item.SubItems[2].Text;
                textBoxDG.Text = item.SubItems[3].Text;
                textBoxSL.Text = item.SubItems[4].Text;
               
            }
        }

        private void buttonxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                IEnumerator ie = listView2.SelectedItems.GetEnumerator();

                while (ie.MoveNext())
                {
                    ListViewItem item = (ListViewItem)ie.Current;
                    listView2.Items.Remove(item);
                }
            }

        }
        

        private void buttonthem_Click(object sender, EventArgs e)
        {
            this.textBoxmp.Text = " ";            
            this.comboBoxMKH.Text=" ";
            this.comboBoxMNV.Text =" ";
            
        }

        private void buttonThemCT_Click(object sender, EventArgs e)
        {
            if (comboBoxMSP.Text!="" && textBoxCTMP.Text!="")
            {
               
                if (ctrl.KiemTraTTChiTietPhieuBanHang(listView1,textBoxCTMP.Text,comboBoxMSP.Text))
               {
                    ListViewItem item = new ListViewItem();

                    int i = listView1.Items.Count;
                    i++;
                    item.Text = i.ToString();
                    item.SubItems.Add(textBoxCTMP.Text);
                    item.SubItems.Add(comboBoxMSP.Text);
                    
                    item.SubItems.Add(textBoxDG.Text);
                    item.SubItems.Add(textBoxSL.Text);
                    int dg = Convert.ToInt32(textBoxDG.Text);
                    int sl = Convert.ToInt32(textBoxSL.Text);
                    int thanhtien = dg * sl;
                    tongtien += thanhtien;
                    textBoxTT.Text = tongtien.ToString();
                    item.SubItems.Add(thanhtien.ToString());
                    item.SubItems.Add(comboBoxMSP.SelectedValue.ToString());
                    listView1.Items.Add(item);
               }
               this.comboBoxMSP.Text = "";
               this.textBoxDG.Text = "";
               this.textBoxSL.Text = "";
               this.textBoxDG.Focus();
            }
            else MessageBox.Show("Bạn chưa chọn mã phiếu và mã sản phẩm hoặc chưa chọn mã phiếu hoặc chưa chọn mã sản phẩm. Vui lòng chọn lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
        }

        private void buttonxoaCT_Click(object sender, EventArgs e)
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

        private void buttonluu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn lưu thông tin này phải không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               ctrl.Luu_PhieuBanHang(textBoxmp, comboBoxMKH, comboBoxMNV, dateTimePicker1,textBoxTT);
               ctrl.HienThiListView(listView2);
               ctrl.Luu_CTPhieuBanHang(listView1);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //private void textBoxmp_Validating(object sender, CancelEventArgs e)
        //{
        //    if (!textBoxmp.Text.Substring(0, 3).Equals("PBH") || textBoxmp.Text.Substring(0, 3)==" ")
            
        //    {
        //        MessageBox.Show("Mã phiếu bán hàng bị sai. Phải nhập PBH đầu mã phiếu!!!!!!!");
        //        e.Cancel = true;
        //    }
        //}

        //private void textBoxCTMP_Validating(object sender, CancelEventArgs e)
        //{
        //    if(!textBoxCTMP.Text.Substring(0,3).Equals("PBH"))
            
        //    {
        //        MessageBox.Show("Mã chi tiet phieu ban hàng bị sai. Phải nhập PBH đầu mã phiếu!!!!!!!");
        //        e.Cancel = true;
        //    }
        //}

        private void buttonTKiem_Click(object sender, EventArgs e)
        {
            frmTimKiemPhieuBanHang tpbh = new frmTimKiemPhieuBanHang();
            tpbh.Show();
        }

        private void buttonin_Click(object sender, EventArgs e)
        {
            PrintDialog print = new PrintDialog();
            print.ShowDialog();
        }

        private void textBoxmp_Validating(object sender, CancelEventArgs e)
        {
            this.textBoxCTMP.Text = this.textBoxmp.Text;
        }

        private void buttonsua_Click(object sender, EventArgs e)
        {

        }

        
        

        
        

       
        
    }
}