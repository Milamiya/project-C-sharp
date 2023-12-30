using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using QLKTX.DataLayer;
using QLKTX.BusinessObject;
namespace QLKTX.Controller
{
    public class XepLoaiCtrl
    {
        XepLoaiData Data = new XepLoaiData();
        public XepLoaiCtrl()
        {
        }
        public void LayDSXepLoai(DataGridView dg)
        {
            dg.DataSource = Data.LayDSXepLoai();
        }
       
        public int LayMaMax()
        {
            QLKTX.DataLayer.XepLoaiData data = new XepLoaiData();
            DataTable table = data.LayMaLonNhat();

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
        public void Them(QLKTX.BusinessObject.XepLoaiInfo info)
        {
            XepLoaiData data = new XepLoaiData();
            data.Them(info);
        }
        public void Xoa(QLKTX.BusinessObject.XepLoaiInfo info)
        {
            XepLoaiData data = new XepLoaiData();
            data.Xoa(info);
        }
        public void Sua(QLKTX.BusinessObject.XepLoaiInfo info)
        {
            XepLoaiData data = new XepLoaiData();
            data.Sua(info);
        }
        public bool KiemTra(TextBox ma, TextBox ten, TextBox cantren, TextBox canduoi)
        {
            if (ma.Text == "")
            {
                MessageBox.Show("Chưa nhập Mã số!", "Xếp loại", MessageBoxButtons.OK);
                ma.Focus();
                return false;
            }
            else
            {
                
                decimal i = 0;
                try
                {
                    i = Convert.ToInt32(ma.Text);                    
                }
                catch (Exception e)
                {
                    MessageBox.Show("Mã số không được nhập kí tự!", "Xếp loại", MessageBoxButtons.OK);
                    ma.Focus();
                    return false;
                }
            }
            if (ten.Text == "")
            {
                MessageBox.Show("Chưa nhập Tên!", "Xếp loại", MessageBoxButtons.OK);
                ten.Focus();
                return false;
            }
            else
            {
                if (ten.Text.Length > 30)
                {
                    MessageBox.Show("Tên không quá 30 kí tự!", "Xếp loại", MessageBoxButtons.OK);
                    ten.Focus();
                    return false;
                }
            }
            if (cantren.Text == "")
            {
                MessageBox.Show("Chưa nhập Điểm!", "Xếp loại", MessageBoxButtons.OK);
                cantren.Focus();
                return false;
            }
            else
            {
                decimal i = 0;
                try
                {
                    i = Convert.ToDecimal(cantren.Text);
                    if (i > 10 ||i<0)
                    {
                        MessageBox.Show("Điểm không được lớn hơn 10 và nhỏ hơn 0!", "Xếp loại", MessageBoxButtons.OK);
                        ma.Focus();
                        return false;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Mã số không được nhập kí tự!", "Xếp loại", MessageBoxButtons.OK);
                    ma.Focus();
                    return false;
                }
            }
            if (canduoi.Text == "")
            {
                MessageBox.Show("Chưa nhập Điểm!", "Xếp loại", MessageBoxButtons.OK);
                canduoi.Focus();
                return false;
            }
            else
            {
                decimal i = 0;
                try
                {
                    i = Convert.ToDecimal(canduoi.Text);
                    if (i > 10 || i < 0)
                    {
                        MessageBox.Show("Điểm không được lớn hơn 10 và nhỏ hơn 0!", "Xếp loại", MessageBoxButtons.OK);
                        canduoi.Focus();
                        return false;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Mã số không được nhập kí tự!", "Xếp loại", MessageBoxButtons.OK);
                    canduoi.Focus();
                    return false;
                }
            }
            if (Convert.ToDecimal(cantren.Text) < Convert.ToDecimal(canduoi.Text))
            {
                MessageBox.Show("Điểm cận trên phải lớn hơn điểm cận dưới!", "Xếp loại", MessageBoxButtons.OK);
                canduoi.Focus();
                return false;
            }
            return true;
        }
        ///////////////////////
        public void HienThi(DataGridView dg, BindingNavigator bn, TextBox ma, TextBox ten, TextBox cantren, TextBox canduoi)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = Data.LayDSXepLoai();
            bn.BindingSource = bs;
            dg.DataSource = bs;

            if (ma.DataBindings.Count > 0)
            {
                ma.DataBindings.RemoveAt(0);
                ten.DataBindings.RemoveAt(0);
                cantren.DataBindings.RemoveAt(0);
                canduoi.DataBindings.RemoveAt(0);

            }
            ma.DataBindings.Add("Text", bs, "MAXEPLOAI");
            ten.DataBindings.Add("Text", bs, "TENXEPLOAI");

            cantren.DataBindings.Add("Text", bs, "DIEMCANTREN");
            canduoi.DataBindings.Add("Text", bs, "DIEMCANDUOI");

        }
        public void HienThiLai(DataGridView dg, BindingNavigator bn, TextBox ma, TextBox ten, DateTimePicker batdau, DateTimePicker ketthuc)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = Data.LayDSXepLoai();
            bn.BindingSource = bs;
            dg.DataSource = bs;

        }
        public void ThemXepLoai(XepLoaiInfo nam)
        {
            Data.ThemXepLoai(nam);
        }
        public void XoaXepLoai(XepLoaiInfo nam)
        {
            Data.XoaXepLoai(nam);
        }
        public void SuaXepLoai(XepLoaiInfo nam)
        {
            Data.SuaXepLoai(nam);
        }
    }
}
