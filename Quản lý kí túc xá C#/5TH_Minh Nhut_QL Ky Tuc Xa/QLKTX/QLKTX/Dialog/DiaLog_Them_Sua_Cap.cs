using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLKTX.Controller;
using QLKTX.BusinessObject;

namespace QLKTX.Dialog
{
    public partial class DiaLog_Them_Sua_Cap : Form
    {
        CapCtrl ctrl = new CapCtrl();
        public int Index = 0;
        private bool boolThem = false;      
        private bool boolSua = false;
        public DiaLog_Them_Sua_Cap()
        {
            InitializeComponent();
        }

        private void DiaLog_Them_Sua_Cap_Load(object sender, EventArgs e)
        {
            ctrl.DataTableToListView(listCap);
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            if (boolSua==true || boolThem==true)
            {
                btnKetThuc.Text = "Kết thúc";
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThem.Enabled = true;

                btnThem.Text = "Thêm";
                btnXoa.Text = "Xóa";
                btnSua.Text = "Sửa";
                txtTen.Enabled = false;

                boolSua = boolThem = false;
            }
            else
            {
                if (listCap.Items.Count > 0)
                {
                    for (int i = 0; i < listCap.Items.Count; i++)
                    {
                        if (listCap.Items[i].Selected == true)
                        {
                            Index = i;
                            break;

                        }
                    }
                }
                else
                    Index = -1;
                this.DialogResult = DialogResult.Yes;
            }
        }

        private void listCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            IEnumerator ro = listCap.Items.GetEnumerator();
            while (ro.MoveNext()) 
            {
                
                ListViewItem it = (ListViewItem)ro.Current;
                if (it.Selected == true)
                {
                    txtMa.Text = it.Text;
                    txtTen.Text = it.SubItems[1].Text;
                }
            }
        }

        
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!boolThem)//Chua chon
            {
                btnThem.Text = "Lưu";
                QLKTX.Controller.CapCtrl cap = new CapCtrl();
                txtMa.Text = cap.LayMaMax().ToString();
                txtTen.Enabled = true;

                btnSua.Enabled = false;
                btnXoa.Enabled = false;

                btnKetThuc.Text = "Bỏ qua";
                txtTen.Text = "";
                txtTen.Focus();
                boolThem = true;
            }
            else
            {
                if (txtTen.Text == "")
                {
                    MessageBox.Show("Nhập Tên! Nhâp lại", "Luu", MessageBoxButtons.OK);
                    txtTen.Focus();                    
                }
                else
                {
                    //Goi ham cap nhat
                    CapInfo qh =new CapInfo();
                    qh.MaCap =Convert.ToInt32(txtMa.Text);
                    qh.TenCap =txtTen.Text;

                    //Lưu
                    ctrl.ThemCap(qh);
                    boolThem = false;
                    ctrl.DataTableToListView(listCap);


                    btnThem.Text = "Thêm";
                    btnSua.Enabled=true;
                    btnXoa.Enabled =true;
                    btnKetThuc.Text = "Kết thúc";
                    boolThem = false;
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listCap.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Thật sự muốn xóa không?", "Quan hệ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    IEnumerator row = listCap.SelectedItems.GetEnumerator();
                    if (row.MoveNext())
                    {
                        ListViewItem l = (ListViewItem)row.Current;
                        ctrl.XoaCap((CapInfo)l.Tag);
                        ctrl.DataTableToListView(listCap);
                        //Xoa
                    }
                }
            }
            

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!boolSua)//Chua chon
            {
                btnSua.Text = "Lưu";
                QLKTX.Controller.CapCtrl qh = new CapCtrl();
                
                txtTen.Enabled = true;

                btnThem.Enabled = false;
                btnXoa.Enabled = false;

                btnKetThuc.Text = "Bỏ qua";
                txtTen.Text = "";
                txtTen.Focus();
                boolSua = true;
            }
            else
            {
                if (txtTen.Text == "")
                {
                    MessageBox.Show("Nhập Tên! Nhâp lại", "Luu", MessageBoxButtons.OK);
                    txtTen.Focus();
                }
                else
                {
                    //Goi ham cap nhat
                    CapInfo qh = new CapInfo();
                    qh.MaCap = Convert.ToInt32(txtMa.Text);
                    qh.TenCap = txtTen.Text;

                    //Lưu
                    ctrl.SuaCap(qh);
                    ctrl.DataTableToListView(listCap);
                    boolSua = false;


                    btnSua.Text = "Sửa";
                    btnThem.Enabled = true;
                    btnXoa.Enabled = true;
                    btnKetThuc.Text = "Kết thúc";
                    boolSua = false;
                }
            }
        }

        private void DiaLog_Them_Sua_Cap_Load_1(object sender, EventArgs e)
        {

        }

        private void listCap_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            IEnumerator ro = listCap.Items.GetEnumerator();
            while (ro.MoveNext())
            {

                ListViewItem it = (ListViewItem)ro.Current;
                if (it.Selected == true)
                {
                    txtMa.Text = it.Text;
                    txtTen.Text = it.SubItems[1].Text;
                }
            }
        }

        
    }
}