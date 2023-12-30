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
    public partial class DiaLog_Them_Sua_QuanHe : Form
    {
        QuanHeCtrl ctrl = new QuanHeCtrl();
        public int Index = 0;
        private bool boolThem = false;      
        private bool boolSua = false;
        public DiaLog_Them_Sua_QuanHe()
        {
            InitializeComponent();
        }

        private void DiaLog_Them_Sua_QuanHe_Load(object sender, EventArgs e)
        {
            ctrl.DataTableToListView(listQuanHe);
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
                if (listQuanHe.Items.Count > 0)
                {
                    for (int i = 0; i < listQuanHe.Items.Count; i++)
                    {
                        if (listQuanHe.Items[i].Selected == true)
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

        private void listQuanHe_SelectedIndexChanged(object sender, EventArgs e)
        {
            IEnumerator ro = listQuanHe.Items.GetEnumerator();
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
                QLKTX.Controller.QuanHeCtrl qh = new QuanHeCtrl();
                txtMa.Text = qh.LayMaMax().ToString();
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
                    QuanHeInfo qh =new QuanHeInfo();
                    qh.MaQuanHe =Convert.ToInt32(txtMa.Text);
                    qh.TenQuanHe =txtTen.Text;

                    //Lưu
                    ctrl.ThemQuanHe(qh);
                    boolThem = false;
                    ctrl.DataTableToListView(listQuanHe);


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
            if (listQuanHe.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Thật sự muốn xóa không?", "Quan hệ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    IEnumerator row = listQuanHe.SelectedItems.GetEnumerator();
                    if (row.MoveNext())
                    {
                        ListViewItem l = (ListViewItem)row.Current;
                        ctrl.XoaQuanHe((QuanHeInfo)l.Tag);
                        ctrl.DataTableToListView(listQuanHe);
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
                QLKTX.Controller.QuanHeCtrl qh = new QuanHeCtrl();
                
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
                    QuanHeInfo qh = new QuanHeInfo();
                    qh.MaQuanHe = Convert.ToInt32(txtMa.Text);
                    qh.TenQuanHe = txtTen.Text;

                    //Lưu
                    ctrl.SuaQuanHe(qh);
                    ctrl.DataTableToListView(listQuanHe);
                    boolSua = false;


                    btnSua.Text = "Sửa";
                    btnThem.Enabled = true;
                    btnXoa.Enabled = true;
                    btnKetThuc.Text = "Kết thúc";
                    boolSua = false;
                }
            }
        }

        
    }
}