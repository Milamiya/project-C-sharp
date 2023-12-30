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

namespace QLKTX.Phong
{
    public partial class frmPhong : Form
    {
        PhongCtrl ctrl=new PhongCtrl();
        bool updating = false;
        bool adding = false;
        public frmPhong()
        {
            InitializeComponent();
        }

        private void frmPhong_Load(object sender, EventArgs e)
        {
            ctrl.HienThi(listDSPhong,cmbDay,cmbTrangThai);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            group.Enabled = true;
            txtMa.Enabled = true;

            txtMa.Text = "";
            txtSoLuong.Text = "";
            txtTen.Text = "";
            chkPhongNam.Checked = false;
            cmbDay.SelectedIndex =( cmbDay.Items.Count>0?0:-1);
            cmbTrangThai.SelectedIndex = (cmbTrangThai.Items.Count > 0 ? 0 : -1);

            listDSPhong.Enabled = false;



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
                if (MessageBox.Show("Bạn có muốn xóa " + (listDSPhong.SelectedItems.Count > 1 ? listDSPhong.SelectedItems.Count.ToString() + " " : "") + "dòng này không?", "Phòng", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    IEnumerator list = listDSPhong.SelectedItems.GetEnumerator();
                    while (list.MoveNext())
                    {
                        ListViewItem item= (ListViewItem)list.Current;
                        PhongInfo phong = (PhongInfo)item.Tag;
                        ctrl.Xoa(phong);
                    }
                }
                ctrl.HienThi(listDSPhong, cmbDay, cmbTrangThai);
         
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (listDSPhong.SelectedItems.Count > 0)
            {
                group.Enabled = true;
                txtMa.Enabled = false;

                listDSPhong.Enabled = false;


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
            if (ctrl.KiemTra(txtMa, txtTen, txtSoLuong, chkPhongNam, cmbDay, cmbTrangThai))
            {
                group.Enabled = false;

                listDSPhong.Enabled = true;

                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                btnCapNhat.Enabled = false;
                btnBoQua.Visible = false;
                if (adding == true)
                {
                    PhongInfo phong = ctrl.ControlToInfo(txtMa, txtTen, txtSoLuong, chkPhongNam, cmbDay, cmbTrangThai);
                    if (ctrl.Them(phong))//Thêm thành công thì thêm một dòng trên LISTVIEW
                    {
                        listDSPhong.Items.Add(ctrl.InfoToItem(phong)); 
                    }
                }
                else if (updating == true)
                {
                    PhongInfo phong = ctrl.ControlToInfo(txtMa, txtTen, txtSoLuong, chkPhongNam, cmbDay, cmbTrangThai);
                    if (ctrl.Sua(phong))//Sửa thành công thì sửa một dòng trên LISTVIEW
                    {
                        ctrl.SuaListView(listDSPhong, phong);
                    }
                }
               // ctrl.HienThi(listDSPhong, cmbDay, cmbTrangThai);
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            group.Enabled = false;

            listDSPhong.Enabled = true;

            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnCapNhat.Enabled = false;
            btnBoQua.Visible = false;
            if (listDSPhong.SelectedItems.Count > 0)
            {
                ctrl.RowToControl(listDSPhong, txtMa, txtTen, txtSoLuong, chkPhongNam, cmbDay, cmbTrangThai);
            }
        }

       

        private void btnThemDay_Click(object sender, EventArgs e)
        {
            frmDay day = new frmDay();
            day.ShowDialog();
            DayCtrl ctrlday = new DayCtrl();
            ctrlday.LayDuLieuLenComboBox(cmbDay);
        }

        private void listDSPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            ctrl.RowToControl(listDSPhong, txtMa, txtTen, txtSoLuong, chkPhongNam, cmbDay, cmbTrangThai);
        }

        private void btnThemTrangThai_Click(object sender, EventArgs e)
        {
            QLKTX.Dialog.DiaLog_TrangThaiPhong ttp = new QLKTX.Dialog.DiaLog_TrangThaiPhong();
            ttp.StartPosition = FormStartPosition.Manual;
            ttp.Left = this.Location.X + group.Location.X + btnThemTrangThai.Location.X + btnThemTrangThai.Width +10;
            ttp.Top = this.Location.Y + group.Location.Y + btnThemTrangThai.Location.Y + btnThemTrangThai.Height;
            ttp.ShowDialog();
            if (ttp.DialogResult == DialogResult.OK)
            {
                QLKTX.Controller.TrangThaiPhongCtrl ctr = new TrangThaiPhongCtrl();
                ctr.LayDuLieuLenComboBox(cmbTrangThai);
                cmbTrangThai.SelectedValue = ttp.TTPhong.MaTrangThai;
            }
        }

        
    }
}