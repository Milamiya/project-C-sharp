using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using BaoCaoThongKe.DataLayer;
using DevComponents.DotNetBar.Controls;
using BaoCaoThongKe.BusinessObject;


namespace BaoCaoThongKe.Controller
{
    public class LoaiCongTrinh_Ctrl
    {
        LoaiCongTrinh_Data DATA = new LoaiCongTrinh_Data();

        public void Show_DS_LoaiCongTrinh(BindingNavigator bdn,GridControl dgv)
        {
            DataTable DTT = DATA.Show_LoaiCongTrinh();            
            BindingSource BD_S = new BindingSource();
            BD_S.DataSource = DTT;
            bdn.BindingSource = BD_S;
            dgv.DataSource = BD_S;
        }
        public void Update()
        {
            DATA.Update();
        }
        //bao cao

        public bool CheckInput(TextBoxX congtrinh)
        {
            if (congtrinh.Text == "")
            {
                MessageBox.Show("Chưa nhập Loại công trình !", "Chú ý", MessageBoxButtons.OK);
                congtrinh.Focus();
                return false;
            }
            else
            {
                if (congtrinh.Text.Length > 200)
                {
                    MessageBox.Show("Nhập tên loại công trình không quá 200 ký tự ", "Chú ý", MessageBoxButtons.OK);
                    congtrinh.Focus();
                    return false;
                }
            }
            return true;
        }

        public void Them(LoaiCongTrinh_InFo loaicongtrinh)
        {
            DATA.Them(loaicongtrinh);
        }

        public void Xoa(LoaiCongTrinh_InFo loaicongtrinh)
        {
            DATA.Xoa(loaicongtrinh);
        }

        public void Sua(LoaiCongTrinh_InFo loaicongtrinh)
        {
            DATA.Sua(loaicongtrinh);
        }

        public void ComboBoxLoaiCongTrinh(ComboBox cb)
        {
            cb.DataSource = DATA.Show_LoaiCongTrinh();
            cb.DisplayMember = "TenLoaiCongTrinh";
            cb.ValueMember = "MaLoaiCongTrinh";
        }
        //
        public int GetLastID()
        {
            if (this.DATA == null)
            {
                this.DATA = new LoaiCongTrinh_Data();
            }
            return Convert.ToInt32(this.DATA.GetLastID());
        }
    }
}
