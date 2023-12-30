using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLKTX.Controller;
using QLKTX.DataLayer;
using QLKTX.BusinessObject;

namespace QLKTX.Dialog
{
    public partial class DiaLog_Them_Sua_NgheNghiep : Form
    {
        NgheNghiepCtrl ctrl = new NgheNghiepCtrl();
        public int Index = 0;
        bool boolThem = false;
        bool boolSua = false;
        public DiaLog_Them_Sua_NgheNghiep()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!boolThem)//Chua chon
            {
                btnThem.Text = "Lưu";
                QLKTX.Controller.NgheNghiepCtrl qh = new NgheNghiepCtrl();
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
                    NgheNghiepInfo nn = new NgheNghiepInfo();
                    nn.MaNgheNghiep = Convert.ToInt32(txtMa.Text);
                    nn.TenNgheNghep = txtTen.Text;

                    //Lưu
                    ctrl.ThemNgheNghiep(nn);
                    boolThem = false;
                    ctrl.DataTableToListView(listNgheNghiep);


                    btnThem.Text = "Thêm";
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnKetThuc.Text = "Kết thúc";
                    boolThem = false;
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listNgheNghiep.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Thật sự muốn xóa không?", "Quan hệ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    IEnumerator row = listNgheNghiep.SelectedItems.GetEnumerator();
                    if (row.MoveNext())
                    {
                        ListViewItem l = (ListViewItem)row.Current;
                        ctrl.XoaNgheNghiep((NgheNghiepInfo)l.Tag);
                        ctrl.DataTableToListView(listNgheNghiep);
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
                QLKTX.Controller.NgheNghiepCtrl qh = new NgheNghiepCtrl();

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
                    NgheNghiepInfo qh = new NgheNghiepInfo();
                    qh.MaNgheNghiep = Convert.ToInt32(txtMa.Text);
                    qh.TenNgheNghep = txtTen.Text;

                    //Lưu
                    ctrl.SuaNgheNghiep(qh);
                    ctrl.DataTableToListView(listNgheNghiep);
                    boolSua = false;


                    btnSua.Text = "Sửa";
                    btnThem.Enabled = true;
                    btnXoa.Enabled = true;
                    btnKetThuc.Text = "Kết thúc";
                    boolSua = false;
                }
            }
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
                if (listNgheNghiep.Items.Count > 0)
                {
                    for (int i = 0; i < listNgheNghiep.Items.Count; i++)
                    {
                        if (listNgheNghiep.Items[i].Selected == true)
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

        private void DiaLog_Them_Sua_NgheNghiep_Load(object sender, EventArgs e)
        {
            ctrl.DataTableToListView(listNgheNghiep);
        }

        private void listNgheNghiep_SelectedIndexChanged(object sender, EventArgs e)
        {
            IEnumerator ro = listNgheNghiep.Items.GetEnumerator();
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