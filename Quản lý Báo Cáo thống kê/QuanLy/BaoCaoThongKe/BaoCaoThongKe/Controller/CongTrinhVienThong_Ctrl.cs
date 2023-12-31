using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using BaoCaoThongKe.DataLayer;
using BaoCaoThongKe.BusinessObject;
using DevComponents.DotNetBar.Controls;
using DevExpress.XtraGrid;

namespace BaoCaoThongKe.Controller
{
    public class CongTrinhVienThong_Ctrl
    {
        CongTrinhVienThong_Data data = new CongTrinhVienThong_Data();
        public void DanhsachCongTrinhVienThong(GridControl dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = data.Show_DS_CacCongTrinh();
            bn.BindingSource = bs;
            dg.DataSource = bs;
        }
        public void Update()
        {
            data.Update();
        }
        public void ListCongTrinh_Doanhnghiep(DataGridViewX dg, BindingNavigator bn, ComboBoxEx doanhnghiep, ComboBoxEx loaicongtrinh)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = data.ChitietCongTrinh_Doanhnghiep(doanhnghiep.SelectedValue.ToString(), loaicongtrinh.SelectedValue.ToString());
            bn.BindingSource = bs;
            dg.DataSource = bs;
        }
        public int LayMaMax()
        {
            CongTrinhVienThong_Data congtrinh = new CongTrinhVienThong_Data();
            DataTable table = congtrinh.LayMaMax();
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
        public bool CheckInput(TextBoxX tencongtrinh)
        {
            if (tencongtrinh.Text == "")
            {
                MessageBox.Show("Chưa nhập tên công trình !", "Chú ý", MessageBoxButtons.OK);
                tencongtrinh.Focus();
                return false;
            }
            else
            {
                if (tencongtrinh.Text.Length > 50)
                {
                    MessageBox.Show("Nhập tên công trình không quá 50 ký tự ", "Chú ý", MessageBoxButtons.OK);
                    tencongtrinh.Focus();
                    return false;
                }
            }
            return true;
        }
        public void Them(CongTrinhVienThong_InFo ct)
        {
            data.Them(ct);
        }

        public void Xoa(CongTrinhVienThong_InFo ct)
        {
            data.Xoa(ct);
        }

        public void Sua(CongTrinhVienThong_InFo ct)
        {
            data.Sua(ct);
        }
        public void ComboBoxCTVT(ComboBoxEx cmbCTVT)
        {
            cmbCTVT.DataSource = data.Show_DS_CacCongTrinh();
            cmbCTVT.DisplayMember = "TenCongTrinh";
            cmbCTVT.ValueMember = "MaCongTrinh";
        }
        //
        public int GetLastID()
        {
            if (this.data == null)
            {
                this.data = new CongTrinhVienThong_Data();
            }
            return Convert.ToInt32(this.data.GetLastID());
        }
    }
}
