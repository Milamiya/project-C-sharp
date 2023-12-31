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
    public class DuAn_Ctrl
    {
        DuAn_Data data = new DuAn_Data();
        public void DanhsachDuAn(GridControl dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = data.ChitietDuAn();
            bn.BindingSource = bs;
            dg.DataSource = bs;
        }
        public void Update()
        {
            data.Update();
        }
        //
        public void ListDuAn_Doanhnghiep(DataGridViewX dg, BindingNavigator bn, ComboBoxEx doanhnghiep)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = data.ChitietDuAn_Doanhnghiep(doanhnghiep.SelectedValue.ToString());
            bn.BindingSource = bs;
            dg.DataSource = bs;
        }
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
        public bool CheckInput(TextBoxX tenloaiduan, TextBoxX diadiem, TextBoxX thoigian, TextBoxX nangluc, TextBoxX tongvon)
        {
            if (tenloaiduan.Text == "")
            {
                MessageBox.Show("Chưa nhập tên dự án !", "Chú ý", MessageBoxButtons.OK);
                tenloaiduan.Focus();
                return false;
            }
            else
            {
                if (tenloaiduan.Text.Length > 200)
                {
                    MessageBox.Show("Nhập tên loại dự án không quá 50 ký tự ", "Chú ý", MessageBoxButtons.OK);
                    tenloaiduan.Focus();
                    return false;
                }
            }

            if (diadiem.Text == "")
            {
                MessageBox.Show("Chưa nhập địa điểm xây dựng !", "Chú ý", MessageBoxButtons.OK);
                diadiem.Focus();
                return false;
            }

            if (nangluc.Text == "")
            {
                MessageBox.Show("Chưa nhập năng lực thiết kế !", "Chú ý", MessageBoxButtons.OK);
                nangluc.Focus();
                return false;
            }

            if (thoigian.Text == "")
            {
                MessageBox.Show("Chưa nhập thời gian từ lúc khởi công đến lúc hoàn thành !", "Chú ý", MessageBoxButtons.OK);
                thoigian.Focus();
                return false;
            }

            if (tongvon.Text == "")
            {
                MessageBox.Show("Chưa nhập tổng mức vốn đầu tư được phê duyệt !", "Chú ý", MessageBoxButtons.OK);
                tongvon.Focus();
                return false;
            }

            return true;
        }
        public void Them(QL_DuAn_InFo duan)
        {
            data.Them(duan);
        }
        public void Xoa(QL_DuAn_InFo duan)
        {
            data.Xoa(duan);
        }
        public void Sua(QL_DuAn_InFo duan)
        {
            data.Sua(duan);
        }
        //
        public int GetLastID()
        {
            if (this.data == null)
            {
                this.data = new DuAn_Data();
            }
            return Convert.ToInt32(this.data.GetLastID());
        }

    }
}
