using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using BaoCaoThongKe.DataLayer;
using BaoCaoThongKe.Controller;
using BaoCaoThongKe.BusinessObject;
using DevComponents.DotNetBar.Controls;
using DevExpress.XtraGrid;

namespace BaoCaoThongKe.Controller
{
    public class DaiLyBuuDienVHX_Ctrl
    {
        DaiLyBuuDienVHX_Data data = new DaiLyBuuDienVHX_Data();
        public void DanhsachVanHoaXa(GridControl dg, BindingNavigator bn, TextBoxX mabuudien, TextBoxX tendiem, ComboBoxEx cmbhuyen, ComboBoxEx cmbxa, TextBoxX diachi, ComboBoxEx cmbDN)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = data.ChitietBDVanHoaXa();
            bn.BindingSource = bs;
            dg.DataSource = bs;

            Huyen_Thi_Data db = new Huyen_Thi_Data();
            cmbhuyen.DataSource = db.HienThiDanhSachHuyen();
            cmbhuyen.DisplayMember = "TenHuyen";
            cmbhuyen.ValueMember = "MaHuyen";

            Xa_Phuong_Data dbxa = new Xa_Phuong_Data();
            cmbxa.DataSource = dbxa.DanhSach_Xa_Phuong();
            cmbxa.DisplayMember = "TenXa";
            cmbxa.ValueMember = "MaXa";

            QL_DoanhNghiep_Data dbDN = new QL_DoanhNghiep_Data();
            cmbDN.DataSource = dbDN.Show_DoanhNghiep();
            cmbDN.DisplayMember = "TenDoanhNghiep";
            cmbDN.ValueMember = "MaDoanhNghiep";

            if (mabuudien.DataBindings.Count > 0)
            {
                mabuudien.DataBindings.Clear();
                tendiem.DataBindings.Clear();
                cmbhuyen.DataBindings.Clear();
                cmbxa.DataBindings.Clear();
                diachi.DataBindings.Clear();
                cmbDN.DataBindings.Clear();
            }
            mabuudien.DataBindings.Add("Text", bs, "MaDaiLyBuuDienVHX");
            tendiem.DataBindings.Add("Text", bs, "TenDaiLyBuuDienVHX");
            cmbhuyen.DataBindings.Add("SelectedValue", bs, "MaHuyen");
            cmbxa.DataBindings.Add("SelectedValue", bs, "MaXa");
            diachi.DataBindings.Add("Text", bs, "DiaChi");
            cmbDN.DataBindings.Add("SelectedValue", bs, "MaDoanhNghiep");
        }

        public void Update()
        {
            data.Update();
        }

        //
        public bool Kiemtra(TextBoxX tenBDVHX, ComboBoxEx cmbhuyen, ComboBoxEx cmbxa, TextBoxX diachi, ComboBoxEx cmbDN)
        {
            if (tenBDVHX.Text == "")
            {
                MessageBox.Show("Chưa nhập tên điểm bưu điện văn hóa xã !", "Chú ý", MessageBoxButtons.OK);
                tenBDVHX.Focus();
                return false;
            }
            else
            {
                if (tenBDVHX.Text.Length > 50)
                {
                    MessageBox.Show("Nhập tên điểm bưu điện văn hóa xã không quá 50 ký tự !", "Chú ý", MessageBoxButtons.OK);
                    tenBDVHX.Focus();
                    return false;
                }
            }

            if (cmbhuyen.SelectedIndex < 0)
            {
                cmbhuyen.Focus();
                MessageBox.Show("Chưa chọn Huyện !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cmbxa.SelectedIndex < 0)
            {
                cmbxa.Focus();
                MessageBox.Show("Chưa chọn Xã !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (diachi.Text == "")
            {
                MessageBox.Show("Chưa nhập địa chỉ !", "Chú ý", MessageBoxButtons.OK);
                diachi.Focus();
                return false;
            }
            else
            {
                if (diachi.Text.Length > 50)
                {
                    MessageBox.Show("Nhập địa chỉ không quá 50 ký tự !", "Chú ý", MessageBoxButtons.OK);
                    diachi.Focus();
                    return false;
                }
            }

            if (cmbDN.SelectedIndex < 0)
            {
                cmbDN.Focus();
                MessageBox.Show("Chưa chọn Doanh nghiệp !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        //bao cao
        public void ListDaiLy_Huyen_vhx(DataGridViewX dg, BindingNavigator bn, ComboBoxEx huyen, ComboBoxEx doanhnghiep)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = data.ChitietDaiLy_Huyen(huyen.SelectedValue.ToString(), doanhnghiep.SelectedValue.ToString());
            bn.BindingSource = bs;
            dg.DataSource = bs;
        }

        public void ListDaiLy_Doanhnghiep_vhx(DataGridViewX dg, BindingNavigator bn, ComboBoxEx doanhnghiep)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = data.ChitietDaiLy_Doanhnghiep(doanhnghiep.SelectedValue.ToString());
            bn.BindingSource = bs;
            dg.DataSource = bs;
        }
        //bao cao
        public int LayMaMax()
        {
            DaiLyBuuDienVHX_Data Buudien = new DaiLyBuuDienVHX_Data();
            DataTable table = Buudien.LayMaMax();
            try
            {
                int i = Convert.ToInt32(table.Rows[0][0].ToString());
                return ++i;
            }
            catch (Exception e)
            {
                e.ToString();
                return 1;
            }
        }
        //
        public bool CheckInput(TextBoxX tendaily, ComboBoxEx cmbxa, TextBoxX diachi)
        {
            if (tendaily.Text == "")
            {
                MessageBox.Show("Chưa nhập tên đại lý !", "Chú ý", MessageBoxButtons.OK);
                tendaily.Focus();
                return false;
            }
            else
            {
                if (tendaily.Text.Length > 50)
                {
                    MessageBox.Show("Nhập tên đại lý không quá 50 ký tự !", "Chú ý", MessageBoxButtons.OK);
                    tendaily.Focus();
                    return false;
                }
            }

            if (cmbxa.SelectedIndex < 0)
            {
                cmbxa.Focus();
                MessageBox.Show("Chưa chọn Xã !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (diachi.Text == "")
            {
                MessageBox.Show("Chưa nhập địa chỉ !", "Chú ý", MessageBoxButtons.OK);
                diachi.Focus();
                return false;
            }
            else
            {
                if (diachi.Text.Length > 200)
                {
                    MessageBox.Show("Nhập địa chỉ không quá 200 ký tự ", "Chú ý", MessageBoxButtons.OK);
                    diachi.Focus();
                    return false;
                } return true;
            }
        }
        //
        public void Xoa_vhx(DaiLyBuuDienVHX_InFo Buudien)
        {
            data.Xoa_vhx(Buudien);
        }

        public void Them_vhx(DaiLyBuuDienVHX_InFo Buudien)
        {
            data.Them_vhx(Buudien);
        }

        public void Sua_vhx(DaiLyBuuDienVHX_InFo Buudien)
        {
            data.Sua_vhx(Buudien);
        }
        //
        public int GetLastID()
        {
            if (this.data == null)
            {
                this.data = new DaiLyBuuDienVHX_Data();
            }
            return Convert.ToInt32(this.data.GetLastID());
        }
    }
}
