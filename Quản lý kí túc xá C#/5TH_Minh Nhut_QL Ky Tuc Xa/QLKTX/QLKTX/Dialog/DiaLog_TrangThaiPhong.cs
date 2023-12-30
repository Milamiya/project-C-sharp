using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLKTX.Controller;
using QLKTX.BusinessObject;

namespace QLKTX.Dialog
{
    public partial class DiaLog_TrangThaiPhong : Form
    {
        bool Adding = false;
        bool Updating = false;
        public TrangThaiPhongInfo TTPhong = new TrangThaiPhongInfo();
        TrangThaiPhongCtrl ctrl = new TrangThaiPhongCtrl();
        public DiaLog_TrangThaiPhong()
        {
            InitializeComponent();
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

                listTrangThaiPhong.Enabled = true;

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

                listTrangThaiPhong.Enabled = false;

                txtMa.Enabled = false;
                txtTen.Enabled = true;
                txtMa.Text = ctrl.LayMaLonNhat().ToString();
                txtTen.Text = "";

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

                listTrangThaiPhong.Enabled = true;

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

                listTrangThaiPhong.Enabled = false;

                txtMa.Enabled = false;
                txtTen.Enabled = true;

            }
        }

        private void btnLuu_Them_Click(object sender, EventArgs e)
        {
            if (ctrl.KiemTra(txtMa, txtTen))
            {
                TrangThaiPhongInfo phong = ctrl.ControlToInfo(txtMa, txtTen);
                ctrl.Them(phong);
                ctrl.LayLenListView(listTrangThaiPhong);


                Adding = false;
                btnThem.Text = "Thêm";
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                btnKetThuc.Visible = true;
                btnLuu_Sua.Visible = false;
                btnLuu_Them.Visible = false;

                listTrangThaiPhong.Enabled = true;

                txtMa.Enabled = false;
                txtTen.Enabled = false;
            }
                 
        }

        private void btnLuu_Sua_Click(object sender, EventArgs e)
        {
            

            if (ctrl.KiemTra(txtMa, txtTen))
            {
                TrangThaiPhongInfo phong = ctrl.ControlToInfo(txtMa, txtTen);
                ctrl.Sua(phong);
                ctrl.LayLenListView(listTrangThaiPhong);

                Updating = false;
                btnSua.Text = "Sửa";
                btnXoa.Enabled = true;
                btnThem.Enabled = true;
                btnKetThuc.Visible = true;
                btnLuu_Them.Visible = false;
                btnLuu_Sua.Visible = false;

                listTrangThaiPhong.Enabled = true;

                txtMa.Enabled = false;
                txtTen.Enabled = false;
            }
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            if (ctrl.KiemTra(txtMa, txtTen))
            {
                TTPhong = ctrl.ControlToInfo(txtMa, txtTen);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void listTrangThaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            ctrl.ListViewToControl(listTrangThaiPhong, txtMa, txtTen);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Hoạt Động", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ctrl.KiemTra(txtMa, txtTen))
                {
                    TrangThaiPhongInfo phong = ctrl.ControlToInfo(txtMa, txtTen);
                    ctrl.Xoa(phong);
                    ctrl.LayLenListView(listTrangThaiPhong);
                }
            }
        }

        private void DiaLog_TrangThaiPhong_Load(object sender, EventArgs e)
        {
            ctrl.LayLenListView(listTrangThaiPhong);
        }

    }
}