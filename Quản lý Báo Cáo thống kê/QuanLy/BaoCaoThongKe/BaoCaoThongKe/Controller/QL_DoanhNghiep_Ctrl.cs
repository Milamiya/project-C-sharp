using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using BaoCaoThongKe.DataLayer;
using BaoCaoThongKe.BusinessObject;

namespace BaoCaoThongKe.Controller
{
    public class QL_DoanhNghiep_Ctrl
    {
        QL_DoanhNghiep_Data data = new QL_DoanhNghiep_Data();
        public void DanhsachDoanhNghiep(GridControl dg, BindingNavigator bn, TextBoxX madoanhnghiep,
                TextBoxX ten, ComboBoxEx cmbhuyen, ComboBoxEx cmbxa, TextBoxX diachi, TextBoxX dienthoai, TextBoxX fax, TextBoxX email, TextBoxX trangweb)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = data.Show_DoanhNghiep();
            bn.BindingSource = bs;
            dg.DataSource = bs;

            Huyen_Thi_Ctrl huyen = new Huyen_Thi_Ctrl();
            huyen.ComboBoxHuyen(cmbhuyen);

            Xa_Phuong_CTrl xa = new Xa_Phuong_CTrl();
            xa.ComboBoxXa(cmbxa);

            if (madoanhnghiep.DataBindings.Count > 0)
            {
                madoanhnghiep.DataBindings.Clear();
                ten.DataBindings.Clear();
                cmbhuyen.DataBindings.Clear();
                cmbxa.DataBindings.Clear();
                diachi.DataBindings.Clear();
                dienthoai.DataBindings.Clear();
                fax.DataBindings.Clear();
                email.DataBindings.Clear();
                trangweb.DataBindings.Clear();
            }
            madoanhnghiep.DataBindings.Add("Text", bs, "MaDoanhNghiep");
            ten.DataBindings.Add("Text", bs, "TenDoanhNghiep");
            cmbhuyen.DataBindings.Add("SelectedValue", bs, "MaHuyen");
            cmbxa.DataBindings.Add("SelectedValue", bs, "MaXa");
            diachi.DataBindings.Add("Text", bs, "DiaChi");
            dienthoai.DataBindings.Add("Text", bs, "DienThoai");
            fax.DataBindings.Add("Text", bs, "Fax");
            email.DataBindings.Add("Text", bs, "Email");
            trangweb.DataBindings.Add("Text", bs, "TrangWeb");


        }
        public void ListDoanhNghiep(DataGridViewX dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = data.Show_DoanhNghiep();
            bn.BindingSource = bs;
            dg.DataSource = bs;
        }
        public void Update()
        {
            data.Update();
        }
        //baocao
        public void ComboBoxDN(ComboBoxEx cmbDN)
        {
            cmbDN.DataSource = data.Show_DoanhNghiep();
            cmbDN.DisplayMember = "TenDoanhNghiep";
            cmbDN.ValueMember = "MaDoanhNghiep";
        }
        
        //
        public bool Kiemtra(TextBoxX ten, TextBoxX diachi, TextBoxX dienthoai, TextBoxX fax, TextBoxX email, TextBoxX trangweb, ComboBoxEx cmbhuyen, ComboBoxEx cmbxa)
        {
            if (ten.Text == "")
            {
                MessageBox.Show("Chưa nhập tên doanh nghiệp !", "Chú ý", MessageBoxButtons.OK);
                ten.Focus();
                return false;
            }
            else
            {
                if (ten.Text.Length > 255)
                {
                    MessageBox.Show("Tên Doanh nghiệp đã quá chiều dài quy định !", "Chú ý", MessageBoxButtons.OK);
                    ten.Focus();
                    return false;
                }
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
                    MessageBox.Show("Địa chỉ không quá 50 kí tự !", "Chú ý", MessageBoxButtons.OK);
                    diachi.Focus();
                    return false;
                }
            }

            if (dienthoai.Text != "")
            {
                if (dienthoai.Text.Length != 10 && dienthoai.Text.Length != 11 && dienthoai.Text.Length != 6 && dienthoai.Text.Length != 9)
                {
                    MessageBox.Show("Số điện thoại không hợp lệ !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dienthoai.Focus();
                    return false;
                }
                else
                {
                    char[] arr = dienthoai.Text.ToCharArray();
                    string s = "0123456789";
                    foreach (char c in arr)
                    {
                        if (!s.Contains(c.ToString()))
                        {
                            MessageBox.Show("Số điện thoại không được có ký tự !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dienthoai.Focus();
                            return false;
                        }

                    }
                }
            }
            else
            {
                dienthoai.Focus();
                MessageBox.Show("Chưa nhập số điện thoại !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            return true;
        }
        //tim trong form bao cao
        public QL_DoanhNghiep_InFo timdoanhnghiep_baocao(string ten)
        {
            DataTable table = data.Timdoanhnghiep_baocao(ten);
            QL_DoanhNghiep_InFo dn = new QL_DoanhNghiep_InFo();
            if (table.Rows.Count > 0)
            {
                dn.MaDoanhNghiep = Convert.ToInt32(table.Rows[0]["MaDoanhNghiep"]);
                dn.TenDoanhNghiep = Convert.ToString(table.Rows[0]["TenDoanhNghiep"]);
                dn.DiaChi = Convert.ToString(table.Rows[0]["DiaChi"]);
                dn.DienThoai = Convert.ToString(table.Rows[0]["DienThoai"]);
                dn.Email = Convert.ToString(table.Rows[0]["Email"]);
                dn.Fax = Convert.ToString(table.Rows[0]["Fax"]);
                dn.TrangWeb = Convert.ToString(table.Rows[0]["TrangWeb"]);
            }
            return dn;
        }
        //
        public int GetLastID()
        {
            if (this.data == null)
            {
                this.data = new QL_DoanhNghiep_Data();
            }
            return Convert.ToInt32(this.data.GetLastID());
        }
    }
}
