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
    public partial class frmXepLoai : Form
    {
        XepLoaiCtrl control = new XepLoaiCtrl();
        bool Adding = false;//Dang su dung phuong thuc Them
        bool Deleting = false;//Dang su dung phuong thuc Xoa
        bool Updating = false;//Dang su dung phuong thuc Sua
        public frmXepLoai()
        {
            InitializeComponent();
        }
        private void frmXepLoai_Load(object sender, EventArgs e)
        {
            control.HienThi(dataDSXepLoai, binXepLoai,txtMa,txtTen,txtCanTren,txtCanDuoi);

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

            //txtMa.ReadOnly = false;
            txtTen.Enabled = true;
            txtCanTren.Enabled = true;
            txtCanDuoi.Enabled = true;
            dataDSXepLoai.Enabled = true;
            //
            txtMa.Clear();
            txtTen.Clear();
            txtCanTren.Text = "";
            txtCanTren.Text = "";
            txtMa.Text = control.LayMaMax().ToString();

            
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            XepLoaiInfo nam = new XepLoaiInfo();
            nam.MaXepLoai = Convert.ToInt32(txtMa.Text);
            nam.TenXepLoai = txtTen.Text;
            nam.DiemCanTren = Convert.ToDecimal(txtCanTren.Text);
            nam.DiemCanDuoi = Convert.ToDecimal(txtCanDuoi.Text);
            if (Adding)
            {
                control.ThemXepLoai(nam);
                Adding = false;
            }
            else
            {
                if (Deleting)
                {
                    control.XoaXepLoai(nam);
                    Deleting = false;
                }
                else
                {
                    if (Updating)
                    {
                        control.SuaXepLoai(nam);
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
            txtMa.Enabled = false;
            txtTen.Enabled = false;
            txtCanTren.Enabled = false;
            txtCanDuoi.Enabled = false;
            dataDSXepLoai.Enabled = true;
            //
            control.HienThi(dataDSXepLoai, binXepLoai, txtMa, txtTen, txtCanTren, txtCanDuoi);
            
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

            txtMa.Enabled =false;
            txtTen.Enabled = true;
            txtCanTren.Enabled = true;
            txtCanDuoi.Enabled = true;
            dataDSXepLoai.Enabled = false;
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
            txtMa.Enabled = false;
            txtTen.Enabled = false;
            txtCanTren.Enabled = false;
            txtCanDuoi.Enabled = false;
            dataDSXepLoai.Enabled = true;
            //
            control.HienThi(dataDSXepLoai, binXepLoai, txtMa, txtTen, txtCanTren, txtCanDuoi);
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

        private void frmXepLoai_FormClosing(object sender, FormClosingEventArgs e)
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