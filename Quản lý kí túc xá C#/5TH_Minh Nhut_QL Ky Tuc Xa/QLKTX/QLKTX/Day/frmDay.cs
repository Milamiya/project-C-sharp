using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLKTX.Controller;
using QLKTX.BusinessObject;
using QLKTX.KTX;

namespace QLKTX.Day
{
    public partial class frmDay : Form
    {
        DayCtrl ctrl = new DayCtrl();
        /// <summary>
        /// Xác định trạng thái đang sửa
        /// </summary>
        bool updating = false;
        /// <summary>
        /// Xác định trạng thái đang thêm
        /// </summary>
        bool adding = false;

        public frmDay()
        {
            InitializeComponent();
        }

        private void frmDay_Load(object sender, EventArgs e)
        {
            ctrl.HienThi(dataDay, binDay,txtMa,txtTen,txtSoLuongPhong,cmbKTX,cmbCoDo);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            updating = false;
            adding = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThemKTX.Enabled = true;

            btnCapNhat.Enabled = true;
            btnBoQua.Visible = true;

            dataDay.Enabled = false;//vo hieu hoa DataGrid
            

            txtMa.Enabled = true;
            txtTen.Enabled = true;
            txtSoLuongPhong.Enabled = true;
            cmbCoDo.Enabled = true;
            cmbKTX.Enabled = true;

            txtMa.Clear();
            txtSoLuongPhong.Clear();
            txtTen.Clear();
            cmbCoDo.SelectedIndex = ((cmbCoDo.Items.Count>0)?0:-1);
            cmbKTX.SelectedIndex = ((cmbKTX.Items.Count > 0) ? 0 : -1);


            //Ngắt BinDing
            if (txtMa.DataBindings.Count > 0)
            {
                txtMa.DataBindings.RemoveAt(0);
                txtTen.DataBindings.RemoveAt(0);
                txtSoLuongPhong.DataBindings.RemoveAt(0);
                cmbCoDo.DataBindings.RemoveAt(0);
                cmbKTX.DataBindings.RemoveAt(0);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {            
            updating = true;
            adding = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThemKTX.Enabled = true;

            btnCapNhat.Enabled = true;
            btnBoQua.Visible = true;
                       

            txtMa.Enabled = false;
            txtTen.Enabled = true;
            txtSoLuongPhong.Enabled = true;
            cmbCoDo.Enabled = true;
            cmbKTX.Enabled = true;

            dataDay.Enabled = false;//khong vo hieu hoa DataGrid            


            //Ngắt BinDing
            if (txtMa.DataBindings.Count > 0)
            {
                txtMa.DataBindings.RemoveAt(0);
                txtTen.DataBindings.RemoveAt(0);
                txtSoLuongPhong.DataBindings.RemoveAt(0);
                cmbCoDo.DataBindings.RemoveAt(0);
                cmbKTX.DataBindings.RemoveAt(0);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (ctrl.KiemTra(txtMa, txtTen, txtSoLuongPhong, cmbKTX, cmbCoDo))
            {
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThemKTX.Enabled = false;

                btnCapNhat.Enabled = false;
                btnBoQua.Visible = false;

                dataDay.Enabled = true;//khong vo hieu hoa DataGrid
                colMaDay.ReadOnly = false;

                txtMa.Enabled = false;
                txtTen.Enabled = false;
                txtSoLuongPhong.Enabled = false;
                cmbCoDo.Enabled = false;
                cmbKTX.Enabled = false;

                DayInfo day = ctrl.DuLieuToDay(txtMa, txtTen, txtSoLuongPhong, cmbKTX, cmbCoDo);


                if (adding)//đang thêm
                {
                    ctrl.Them(day);
                }
                else
                {
                    if (updating)//đang sửa
                    {
                        ctrl.Sua(day);
                    }
                }

                ctrl.HienThi(dataDay, binDay, txtMa, txtTen, txtSoLuongPhong, cmbKTX, cmbCoDo);
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            updating = adding = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThemKTX.Enabled = false;

            btnCapNhat.Enabled = false;
            btnBoQua.Visible = false;

            dataDay.Enabled = true;//khong vo hieu hoa DataGrid
            colMaDay.ReadOnly = false;

            txtMa.Enabled = false;
            txtTen.Enabled = false;
            txtSoLuongPhong.Enabled = false;
            cmbCoDo.Enabled = false;
            cmbKTX.Enabled = false;

            //dien lai du lieu            
            ctrl.HienThi(dataDay, binDay, txtMa, txtTen, txtSoLuongPhong, cmbKTX, cmbCoDo);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataDay.SelectedRows.Count > 0)
            {
                DayInfo day = ctrl.DuLieuToDay(txtMa, txtTen, txtSoLuongPhong, cmbKTX, cmbCoDo);
                if (MessageBox.Show("xóa dãy: " + day.TenDay + " không?", "Dãy", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ctrl.Xoa(day);
                    ctrl.HienThi(dataDay, binDay, txtMa, txtTen, txtSoLuongPhong, cmbKTX, cmbCoDo);
                }
            }
            else
            {
                MessageBox.Show("Chọn Dãy cần xóa!", "Dãy", MessageBoxButtons.OK);
            }

        }

        private void btnThemKTX_Click(object sender, EventArgs e)
        {
            frmKTX ktx = new frmKTX();
            ktx.ShowDialog();            
            KTXCtrl ktxctrl = new KTXCtrl();
            ktxctrl.LayDSKTXLenComboBox(cmbKTX);
            cmbKTX.Text = (ktx.ktxInfo.TenKTX!=null?ktx.ktxInfo.TenKTX:"");
        }
                
    }
}