using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLKTX.BusinessObject;
using QLKTX.Controller;
namespace QLKTX.Dialog
{
    public partial class DiaLog_HoatDong : Form
    {
        bool Adding = false;
        bool Updating = false;
        HoatDongCtrl ctrl = new HoatDongCtrl();
        public HoatDongInfo HoatDong =new HoatDongInfo();
        public DiaLog_HoatDong()
        {
            InitializeComponent();
        }

        private void DiaLog_HoatDong_Load(object sender, EventArgs e)
        {
            ctrl.LayLenListView(listHoatDong);            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (Adding)
            {
                Adding = false;
                btnThem.Text = "Thêm";
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                btnKetThuc.Visible = true;
                btnLuu_Sua.Visible = false;
                btnLuu_Them.Visible = false;

                listHoatDong.Enabled = true;

                txtMa.Enabled = false;
                txtTen.Enabled = false;

            }
            else
            {
                Adding = true;
                btnThem.Text = "Bỏ qua";
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
                btnKetThuc.Visible = false;
                btnLuu_Sua.Visible = false;
                btnLuu_Them.Visible = true;
                btnLuu_Them.Location = btnKetThuc.Location;

                listHoatDong.Enabled = false;

                txtMa.Enabled = false;
                txtTen.Enabled = true;
                txtMa.Text = ctrl.LayMaLonNhat().ToString();
                txtTen.Text = "";

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Hoạt Động", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ctrl.KiemTra(txtMa, txtTen))
                {
                    HoatDongInfo hoatdong = ctrl.ControlToInfo(txtMa, txtTen);
                    ctrl.Xoa(hoatdong);
                    ctrl.LayLenListView(listHoatDong);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (Updating)
            {
                Updating = false;
                btnSua.Text = "Sửa";
                btnXoa.Enabled = true;
                btnThem.Enabled = true;
                btnKetThuc.Visible = true;
                btnLuu_Sua.Visible = false;
                btnLuu_Them.Visible = false;

                listHoatDong.Enabled = true;

                txtMa.Enabled = false;
                txtTen.Enabled = false;
            }
            else
            {
                Updating = true;
                btnSua.Text = "Bỏ qua";
                btnXoa.Enabled = false;
                btnThem.Enabled = false;
                btnKetThuc.Visible = false;
                btnLuu_Them.Visible = false;
                btnLuu_Sua.Visible = true;
                btnLuu_Sua.Location = btnKetThuc.Location;

                listHoatDong.Enabled = false;

                txtMa.Enabled = false;
                txtTen.Enabled = true;

            }
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            if (listHoatDong.Items.Count > 0)
            {
                txtMa.Text = listHoatDong.Items[listHoatDong.Items.Count - 1].SubItems[0].Text;
                txtTen.Text = listHoatDong.Items[listHoatDong.Items.Count - 1].SubItems[1].Text;

                HoatDong = ctrl.ControlToInfo(txtMa, txtTen);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                txtMa.Text = "";
                txtTen.Text = "";

                HoatDong = ctrl.ControlToInfo(txtMa, txtTen);
                this.DialogResult = DialogResult.Cancel;
            }
            
        }

        private void btnLuu_Them_Click(object sender, EventArgs e)
        {
            if (ctrl.KiemTra(txtMa, txtTen))
            {
                HoatDongInfo hoatdong = ctrl.ControlToInfo(txtMa, txtTen);
                ctrl.Them(hoatdong);
                ctrl.LayLenListView(listHoatDong);


                Adding = false;
                btnThem.Text = "Thêm";
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                btnKetThuc.Visible = true;
                btnLuu_Sua.Visible = false;
                btnLuu_Them.Visible = false;

                listHoatDong.Enabled = true;

                txtMa.Enabled = false;
                txtTen.Enabled = false;
            }
        }

        private void btnLuu_Sua_Click(object sender, EventArgs e)
        {


            if (ctrl.KiemTra(txtMa, txtTen))
            {
                HoatDongInfo phong = ctrl.ControlToInfo(txtMa, txtTen);
                ctrl.Sua(phong);
                ctrl.LayLenListView(listHoatDong);

                Updating = false;
                btnSua.Text = "Sửa";
                btnXoa.Enabled = true;
                btnThem.Enabled = true;
                btnKetThuc.Visible = true;
                btnLuu_Them.Visible = false;
                btnLuu_Sua.Visible = false;

                listHoatDong.Enabled = true;

                txtMa.Enabled = false;
                txtTen.Enabled = false;
            }
        }

        private void listHoatDong_SelectedIndexChanged(object sender, EventArgs e)
        {
            ctrl.ListViewToControl(listHoatDong, txtMa, txtTen);
        }

        
    }
}