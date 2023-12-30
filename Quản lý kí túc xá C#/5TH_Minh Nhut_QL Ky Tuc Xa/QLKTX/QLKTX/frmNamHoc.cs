using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLKTX.Controller;
using QLKTX.BusinessObject;

namespace QLKTX
{
    public partial class frmNamHoc : Form
    {
        NamHocCtrl control = new NamHocCtrl();
        bool Adding = false;//Dang su dung phuong thuc Them
        bool Deleting = false;//Dang su dung phuong thuc Xoa
        bool Updating = false;//Dang su dung phuong thuc Sua
        public frmNamHoc()
        {
            InitializeComponent();
        }
        private void frmNamHoc_Load(object sender, EventArgs e)
        {
            control.HienThi(dataDSNamHoc, binNamHoc,txtMa,txtTen,dateBatDau,dateKetThuc);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Adding = true;
            Deleting = false;
            Updating = false;

            //
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnBoQua.Visible = true;
            btnCapNhat.Enabled = true;

            //

            txtMa.ReadOnly = false;
            txtTen.ReadOnly = false;
            dateBatDau.Enabled = true;
            dateKetThuc.Enabled = true;
            //
            txtMa.Clear();
            txtTen.Clear();
            dateBatDau.Text = "";
            dateBatDau.Text = "";

            
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            NamHocInfo nam = new NamHocInfo();
            nam.MaNamHoc = txtMa.Text;
            nam.TenNamHoc = txtTen.Text;
            nam.NgayBatDau = dateBatDau.Value;
            nam.NgayKetThuc = dateKetThuc.Value;
            if (Adding)
            {
                control.ThemNamHoc(nam);
                Adding = false;
            }
            else
            {
                if (Deleting)
                {
                    control.XoaNamHoc(nam);
                    Deleting = false;
                }
                else
                {
                    if (Updating)
                    {
                        control.SuaNamHoc(nam);
                        Updating = false;
                    }
                }
            }

            //
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;

            btnBoQua.Visible = false;

            btnCapNhat.Enabled = false;
            //
            txtMa.ReadOnly = true;
            txtTen.ReadOnly = true;
            dateBatDau.Enabled = false;
            dateKetThuc.Enabled = false;
            //
            control.HienThi(dataDSNamHoc, binNamHoc, txtMa, txtTen, dateBatDau, dateKetThuc);
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa không?", "Năm học", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Adding = false;
                Deleting = true;
                Updating = false;
                //
                btnCapNhat_Click(sender, e);
               
                //
                
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Adding = false;
            Deleting = false;
            Updating = true;
            //
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnBoQua.Visible = true;
            btnCapNhat.Enabled = true;

            //

            txtMa.ReadOnly = true;
            txtTen.ReadOnly = false;
            dateBatDau.Enabled = true;
            dateKetThuc.Enabled = true;
            //
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Visible = false;
            btnCapNhat.Enabled = false;

            //
            txtMa.ReadOnly = true;
            txtTen.ReadOnly = true;
            dateBatDau.Enabled = false;
            dateKetThuc.Enabled = false;
            //
        }

        private void mnuThem_Click(object sender, EventArgs e)
        {
            btnThem_Click(sender, e);
        }

        private void mnuXoa_Click(object sender, EventArgs e)
        {
            btnXoa_Click(sender, e);
        }

        private void mnuSua_Click(object sender, EventArgs e)
        {
            btnSua_Click(sender, e);
        }

        private void frmNamHoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!(Adding==false && Deleting==false && Updating==false))//khi chua nhan nut luu
            {
                if(MessageBox.Show("bạn chưa lưu!,\n Bạn đóng cửa sổ không","Năm học",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.No)
                {
                    e.Cancel =true;
                }

            }
        }

        
    }
}