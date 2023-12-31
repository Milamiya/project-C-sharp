using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DevExpress.XtraGrid;
using DevComponents.DotNetBar.Controls;
using BaoCaoThongKe.DataLayer;
using BaoCaoThongKe.BusinessObject;
using System.Windows.Forms;


namespace BaoCaoThongKe.Controller
{
    public class DichVuBuuChinhVT_Ctrl
    {
        DichVuBuuChinhVT_Data data = new DichVuBuuChinhVT_Data();
        public void DanhsachDichVuBuuChinhVT(GridControl dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = data.Show_CacDichVu();
            bn.BindingSource = bs;
            dg.DataSource = bs;
        }
        public void Update()
        {
            data.Update();
        }
        //
        public int GetLastID()
        {
            if (this.data == null)
            {
                this.data = new DichVuBuuChinhVT_Data();
            }
            return Convert.ToInt32(this.data.GetLastID());
        }
        //bao cao
        public void ListDichVu_Doanhnghiep(DataGridViewX dg, BindingNavigator bn, ComboBoxEx doanhnghiep)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = data.ChitietDichVu_Doanhnghiep(doanhnghiep.SelectedValue.ToString());
            bn.BindingSource = bs;
            dg.DataSource = bs;
        }
        //
        public int LayMaMax()
        {
            DataTable table = data.LayMaMax();
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
        public bool CheckInput(TextBoxX tendichvu, ComboBoxEx cmb)
        {
            if (tendichvu.Text == "")
            {
                MessageBox.Show("Chưa nhập tên dịch vụ bưu chính viễn thông !", "Chú ý", MessageBoxButtons.OK);
                tendichvu.Focus();
                return false;
            }
            else
            {
                if (tendichvu.Text.Length > 200)
                {
                    MessageBox.Show("Nhập tên dịch vụ bưu chính viễn thông không quá 50 ký tự ", "Chú ý", MessageBoxButtons.OK);
                    tendichvu.Focus();
                    return false;
                }
            }

            if (cmb.SelectedIndex < 0)
            {
                cmb.Focus();
                MessageBox.Show("Chưa chọn Doanh Nghiệp !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool CheckInput(TextBoxX tendichvu)
        {
            if (tendichvu.Text == "")
            {
                MessageBox.Show("Chưa nhập tên dịch vụ bưu chính viễn thông !", "Chú ý", MessageBoxButtons.OK);
                tendichvu.Focus();
                return false;
            }
            else
            {
                if (tendichvu.Text.Length > 200)
                {
                    MessageBox.Show("Nhập tên dịch vụ bưu chính viễn thông không quá 50 ký tự ", "Chú ý", MessageBoxButtons.OK);
                    tendichvu.Focus();
                    return false;
                }
            }

            return true;
        }

        public void Them(DichVuBuuChinh_VienThong_InFo dichvu)
        {
            data.Them(dichvu);
        }

        public void Xoa(DichVuBuuChinh_VienThong_InFo dichvu)
        {
            data.Xoa(dichvu);
        }

        public void Sua(DichVuBuuChinh_VienThong_InFo dichvu)
        {
            data.Sua(dichvu);
        }
    }
}
