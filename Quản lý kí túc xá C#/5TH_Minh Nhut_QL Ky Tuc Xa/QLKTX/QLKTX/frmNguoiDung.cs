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
using QLKTX.Day;

namespace QLKTX
{
    public partial class frmNguoiDung : Form
    {
        NguoiDungCtrl ctrl=new NguoiDungCtrl();
        bool updating = false;
        bool adding = false;
        public frmNguoiDung()
        {
            InitializeComponent();
        }

        private void frmNguoiDung_Load(object sender, EventArgs e)
        {
            ctrl.HienThi(listDSNguoiDung);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NguoiDungCtrl ctr = new NguoiDungCtrl();
            group.Enabled = true;
            txtMa.Enabled = true;

            txtMa.Text = ctrl.LayMaMax().ToString();
            txtuser.Text = "";
            txtHoTen.Text = "";
            txtpas.Text = "";           


            cmbQuyen.SelectedIndex = (cmbQuyen.Items.Count > 0 ? 0 : -1);

            listDSNguoiDung.Enabled = false;



            adding = true;
            updating = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = true;
            btnBoQua.Visible = true;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {            
                if (MessageBox.Show("Bạn có muốn xóa " + (listDSNguoiDung.SelectedItems.Count > 1 ? listDSNguoiDung.SelectedItems.Count.ToString() + " " : "") + "dòng này không?", "Phòng", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    IEnumerator list = listDSNguoiDung.SelectedItems.GetEnumerator();
                    while (list.MoveNext())
                    {
                        ListViewItem item= (ListViewItem)list.Current;
                        NguoiDungInfo NguoiDung = (NguoiDungInfo)item.Tag;
                        ctrl.Xoa(NguoiDung);
                    }
                }
                ctrl.HienThi(listDSNguoiDung);
         
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (listDSNguoiDung.SelectedItems.Count > 0)
            {
                group.Enabled = true;
                txtMa.Enabled = false;

                listDSNguoiDung.Enabled = false;


                updating = true;
                adding = false;
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
                btnCapNhat.Enabled = true;
                btnBoQua.Visible = true;
            }
            else
            {
                MessageBox.Show("Chưa chọn phòng cần sửa!", "Phòng");
            }
            
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (ctrl.KiemTra(txtHoTen,txtuser,txtpas,txtrepas,cmbQuyen ))
            {
                group.Enabled = false;

                listDSNguoiDung.Enabled = true;

                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                btnCapNhat.Enabled = false;
                btnBoQua.Visible = false;
                if (adding == true)
                {
                    NguoiDungInfo NguoiDung = ctrl.ControlToInfo(txtMa, txtHoTen, txtuser, txtpas, cmbQuyen);
                    if (ctrl.Them(NguoiDung))//Thêm thành công thì thêm một dòng trên LISTVIEW
                    {
                        listDSNguoiDung.Items.Add(ctrl.InfoToItem(NguoiDung)); 
                    }
                }
                else if (updating == true)
                {
                    NguoiDungInfo NguoiDung = ctrl.ControlToInfo(txtMa, txtHoTen, txtuser, txtpas, cmbQuyen);
                    if (ctrl.Sua(NguoiDung))//Sửa thành công thì sửa một dòng trên LISTVIEW
                    {
                        ctrl.SuaListView(listDSNguoiDung, NguoiDung);
                    }
                }
                ctrl.HienThi(listDSNguoiDung);
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            group.Enabled = false;

            listDSNguoiDung.Enabled = true;

            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnCapNhat.Enabled = false;
            btnBoQua.Visible = false;
            if (listDSNguoiDung.SelectedItems.Count > 0)
            {
                ctrl.RowToControl(listDSNguoiDung, txtMa, txtHoTen, txtuser, txtpas, cmbQuyen);
            }
        }

       

        
        private void listDSNguoiDung_SelectedIndexChanged(object sender, EventArgs e)
        {
            ctrl.RowToControl(listDSNguoiDung, txtMa, txtHoTen, txtuser, txtpas, cmbQuyen);
        }

        
        
    }
}