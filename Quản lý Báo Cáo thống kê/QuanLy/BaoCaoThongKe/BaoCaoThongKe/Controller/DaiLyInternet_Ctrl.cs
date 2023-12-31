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
    public class DaiLyInternet_Ctrl
    {
        DaiLyInternet_Data data = new DaiLyInternet_Data();
        public void DanhsachDaiLyInternet(GridControl dg, BindingNavigator bn, TextBoxX madaily, TextBoxX tendaily, ComboBoxEx cmbhuyen, ComboBoxEx cmbxa, TextBoxX diachi, TextBoxX sohieu, ComboBoxEx cmbDn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = data.ChiTietDaiLyInternet();
            bn.BindingSource = bs;
            dg.DataSource = bs;

            Huyen_Thi_Ctrl huyen = new Huyen_Thi_Ctrl();
            huyen.ComboBoxHuyen(cmbhuyen);

            Xa_Phuong_CTrl xa = new Xa_Phuong_CTrl();
            xa.ComboBoxXa(cmbxa);

            QL_DoanhNghiep_Ctrl dn = new QL_DoanhNghiep_Ctrl();
            dn.ComboBoxDN(cmbDn);

            if (madaily.DataBindings.Count > 0)
            {
                madaily.DataBindings.Clear();
                tendaily.DataBindings.Clear();
                cmbhuyen.DataBindings.Clear();
                cmbxa.DataBindings.Clear();
                diachi.DataBindings.Clear();
                sohieu.DataBindings.Clear();
                cmbDn.DataBindings.Clear();
            }
            madaily.DataBindings.Add("Text", bs, "MaDaiLyInt");
            cmbhuyen.DataBindings.Add("SelectedValue", bs, "MaHuyen");
            cmbxa.DataBindings.Add("SelectedValue", bs, "MaXa");
            tendaily.DataBindings.Add("Text", bs, "TenChuDaiLy");
            diachi.DataBindings.Add("Text", bs, "DiaChi");
            sohieu.DataBindings.Add("Text", bs, "SoHieuDaiLy");
            cmbDn.DataBindings.Add("SelectedValue", bs, "MaDoanhNghiep");
        }


        public void Update()
        {
            data.Update();
        }

        //
        public bool Kiemtra(TextBoxX tendaily, ComboBoxEx cmbhuyen, ComboBoxEx cmbxa, TextBoxX diachi, ComboBoxEx comDn)
        {
            if (tendaily.Text == "")
            {
                MessageBox.Show("Chưa nhập tên đại lý !", "Chú ý", MessageBoxButtons.OK);
                tendaily.Focus();
                return false;
            }
            else
            {
                if (tendaily.Text.Length > 255)
                {
                    MessageBox.Show("Nhập tên đại lý không quá 255 ký tự !", "Chú ý", MessageBoxButtons.OK);
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

            if (comDn.SelectedIndex < 0)
            {
                comDn.Focus();
                MessageBox.Show("Chưa chọn Doanh nghiệp !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        //bao cao

        public void ListInt_Huyen(DataGridViewX dg, BindingNavigator bn, ComboBoxEx huyen, ComboBoxEx doanhnghiep)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = data.ChitietInt_Huyen(huyen.SelectedValue.ToString(), doanhnghiep.SelectedValue.ToString());
            bn.BindingSource = bs;
            dg.DataSource = bs;
        }

        public void ListInt_Doanhnghiep(DataGridViewX dg, BindingNavigator bn, ComboBoxEx doanhnghiep)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = data.ChitietInt_Doanhnghiep(doanhnghiep.SelectedValue.ToString());
            bn.BindingSource = bs;
            dg.DataSource = bs;
        }
        public int LayMaMax()
        {
            DaiLyInternet_Data Int = new DaiLyInternet_Data();
            DataTable table = Int.LayMaMax();
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
        public void Xoa_Int(DaiLyInternet_InFo Int)
        {
            data.Xoa_Int(Int);
        }

        public void Them_Int(DaiLyInternet_InFo Int)
        {
            data.Them_Int(Int);
        }

        public void Sua_Int(DaiLyInternet_InFo Int)
        {
            data.Sua_Int(Int);
        }
        public bool CheckInput(TextBoxX tendaily, ComboBoxEx cmbxa, TextBoxX diachi, TextBox sohieu)
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
                if (diachi.Text.Length > 50)
                {
                    MessageBox.Show("Nhập địa chỉ không quá 50 ký tự ", "Chú ý", MessageBoxButtons.OK);
                    diachi.Focus();
                    return false;
                } return true;
            }
            if (sohieu.Text == "")
            {
                MessageBox.Show("Chưa nhập số hiệu!", "chú ý", MessageBoxButtons.OK);
                sohieu.Focus();
                return false;
            }
        }
        //
        public int GetLastID()
        {
            if (this.data == null)
            {
                this.data = new DaiLyInternet_Data();
            }
            return Convert.ToInt32(this.data.GetLastID());
        }
    }
}
