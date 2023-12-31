using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using BaoCaoThongKe.DataLayer;
using BaoCaoThongKe.BusinessObject;
using DevExpress.XtraGrid;
using DevComponents.DotNetBar.Controls;


namespace BaoCaoThongKe.Controller
{
    public class DaiLyBuuDien_Ctrl
    {
        DaiLyBuuDien_Data data = new DaiLyBuuDien_Data();
        public void DanhsachDaiLyBuuDien(GridControl dg, BindingNavigator bn, TextBoxX mabuudien, TextBoxX tendaily, ComboBoxEx cmbhuyen, ComboBoxEx cmbxa, ComboBoxEx cmbDoanhnghiep, TextBoxX diachi)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = data.ChiTietDaiLyBuuDien();
            bn.BindingSource = bs;
            dg.DataSource = bs;
            //
            Huyen_Thi_Ctrl huyen = new Huyen_Thi_Ctrl();
            huyen.ComboBoxHuyen(cmbhuyen);

            Xa_Phuong_CTrl xa = new Xa_Phuong_CTrl();
            xa.ComboBoxXa(cmbxa);

            QL_DoanhNghiep_Ctrl dn = new QL_DoanhNghiep_Ctrl();
            dn.ComboBoxDN(cmbDoanhnghiep);

            if (mabuudien.DataBindings.Count > 0)
            {
                mabuudien.DataBindings.Clear();
                tendaily.DataBindings.Clear();
                cmbhuyen.DataBindings.Clear();
                cmbxa.DataBindings.Clear();
                diachi.DataBindings.Clear();
                cmbDoanhnghiep.DataBindings.Clear();
            }
            mabuudien.DataBindings.Add("Text", bs, "MaDaiLyBuuDien");
            tendaily.DataBindings.Add("Text", bs, "TenDaiLy");
            cmbhuyen.DataBindings.Add("SelectedValue", bs, "MaHuyen");
            cmbxa.DataBindings.Add("SelectedValue", bs, "MaXa");
            diachi.DataBindings.Add("Text", bs, "DiaChi");
            cmbDoanhnghiep.DataBindings.Add("SelectedValue", bs, "MaDoanhNghiep");
        }
        public void Update()
        {
            data.Update();
        }
        //
        public bool Kiemtra(TextBoxX tendaily, ComboBoxEx cmbhuyen, ComboBoxEx cmbxa, TextBoxX diachi, ComboBoxEx cmbDn)
        {
            if (tendaily.Text == "")
            {
                MessageBox.Show("Chưa nhập tên chủ đại lý !", "Chú ý", MessageBoxButtons.OK);
                tendaily.Focus();
                return false;
            }
            else
            {
                if (tendaily.Text.Length > 50)
                {
                    MessageBox.Show("Nhập tên chủ đại lý không quá 255 ký tự !", "Chú ý", MessageBoxButtons.OK);
                    tendaily.Focus();
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
                    MessageBox.Show("Nhập địa chỉ không quá 50 ký tự ", "Chú ý", MessageBoxButtons.OK);
                    diachi.Focus();
                    return false;
                }
            }

            if (cmbDn.SelectedIndex < 0)
            {
                cmbxa.Focus();
                MessageBox.Show("Chưa chọn Doanh Nghiệp !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        //bao coa
        public void ListDaiLy_Huyen(DataGridViewX dg, BindingNavigator bn, ComboBoxEx huyen, ComboBoxEx doanhnghiep)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = data.ChitietDaiLy_Huyen(huyen.SelectedValue.ToString(), doanhnghiep.SelectedValue.ToString());
            bn.BindingSource = bs;
            dg.DataSource = bs;
        }
        public void ListDaiLy_Doanhnghiep(DataGridViewX dg, BindingNavigator bn, ComboBoxEx doanhnghiep)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = data.ChitietDaiLy_Doanhnghiep(doanhnghiep.SelectedValue.ToString());
            bn.BindingSource = bs;
            dg.DataSource = bs;
        }
        //ma tu tang
        public int LayMaMax()
        {
            MauBaoCaoDaiLyBuuDien_Data dbmaubaocao = new MauBaoCaoDaiLyBuuDien_Data();
            DataTable table = dbmaubaocao.LayMaMax();
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
        public bool Kiemtra(TextBoxX tendaily, ComboBoxEx cmbxa, TextBoxX diachi)
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
        //them daily trong form bao cao
        public void Them(DaiLyBuuDien_InFo Buudien)
        {
            data.Them(Buudien);
        }
        //
        public int GetLastID()
        {
            if (this.data == null)
            {
                this.data = new DaiLyBuuDien_Data();
            }
            return Convert.ToInt32(this.data.GetLastID());
        }

    }
}
