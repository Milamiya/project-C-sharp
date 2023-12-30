using System;
using System.Collections.Generic;
using System.Text;
using QLKTX.DataLayer;
using QLKTX.BusinessObject;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar;

namespace QLKTX.Controller
{
    public class HoatDongSinhVienCtrl
    {
        public void LayDSSVThuocKTX(ComboBoxEx com,DataGridViewX dgv)
        {
            if (com.SelectedIndex >= 0)
            {
                HoatDongSinhVienData data = new HoatDongSinhVienData();
                dgv.DataSource = data.LayDSSVThuocKTX(com.SelectedValue.ToString());
                dgv.Columns["MAKTX"].Visible = false;
                dgv.Columns["MAPHG"].Visible = false;
                dgv.Columns["GIOITINH"].Visible = false;                
            }
        }
        public void LayDSSVThuocPhong(ComboBoxEx com, DataGridViewX dgv)
        {
            if (com.SelectedIndex >= 0)
            {
                HoatDongSinhVienData data = new HoatDongSinhVienData();
                dgv.DataSource = data.LayDSSVThuocPhong(com.SelectedValue.ToString());
                dgv.Columns["MAKTX"].Visible = false;
                dgv.Columns["MAPHG"].Visible = false;
                dgv.Columns["GIOITINH"].Visible = false;
            }
        }
        public void LayDSSVThuocDay(ComboBoxEx com,DataGridViewX dgv)
        {
            if (com.SelectedIndex >= 0)
            {
                HoatDongSinhVienData data = new HoatDongSinhVienData();
                dgv.DataSource = data.LayDSSVThuocDay(com.SelectedValue.ToString());
                dgv.Columns["MAKTX"].Visible = false;
                dgv.Columns["MAPHG"].Visible = false;
                dgv.Columns["GIOITINH"].Visible = false;
            }
        }
        public void DanhGia(string MAKTX,string MAHOCKI,string MADANHGIA,string Tichcuc,string Tieucuc,string GhiChu)
        {
            HoatDongSinhVienData data = new HoatDongSinhVienData();
          //  data.DanhGia(MAKTX, MAHOCKI, MADANHGIA,Tichcuc,Tieucuc,GhiChu);
        }

        public void TimSinhVien_HocKi(ComboBoxEx comHocKi,TextBoxX ten, DataGridViewX dgv)
        {
            if (comHocKi.SelectedIndex >= 0)
            {
                HoatDongSinhVienData data = new HoatDongSinhVienData();
                dgv.DataSource = data.TimSinhVien_HocKi( comHocKi.SelectedValue.ToString(),ten.Text);
                dgv.Columns["MAKTX"].Visible = false;
                dgv.Columns["MAPHG"].Visible = false;
                dgv.Columns["GIOITINH"].Visible = false;
            }
        }
        public bool KiemTra(ComboBoxEx danhgia,TextBoxX tichcuc,TextBoxX tieucuc,TextBoxX ghichu)
        {
            if (danhgia.SelectedIndex < 0)
            {
                MessageBox.Show("Chưa chọn đánh giá","Loi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                danhgia.Focus();
                return false;
            }
            if (tichcuc.Text == "")
            {
                DialogResult re = MessageBox.Show("Bạn chưa nhập \"tích cực\" của sinh viên\nBạn có muốn nhập không?", "Danh gia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (re == DialogResult.Yes)
                {
                    tichcuc.Focus();
                    return false;
                }
            }
            if (tieucuc.Text == "")
            {
                DialogResult re = MessageBox.Show("Bạn chưa nhập \"tiêu cực\" của sinh viên\nBạn có muốn nhập không?", "Danh gia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (re == DialogResult.Yes)
                {
                    tieucuc.Focus();
                    return false;
                }
            }
            if (ghichu.Text == "")
            {
                DialogResult re = MessageBox.Show("Bạn chưa nhập \"Ghi chú\" của sinh viên\nBạn có muốn nhập không?", "Danh gia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (re == DialogResult.Yes)
                {
                    ghichu.Focus();
                    return false;
                }
            }
            return true;
        }
        public void HoatDong(LabelX maktx,DateTimePicker ngay,ComboBoxEx hoatdong, TextBoxX ghichu)
        {
            if (KiemTra(maktx, ngay, hoatdong, ghichu))
            {
                HoatDongSVInfo info = new HoatDongSVInfo();
                HoatDongSinhVienData hddata = new HoatDongSinhVienData();
                info.SinhVien.MaKTX = maktx.Text;
                info.Ngay = ngay.Value;                
                info.GhiChu = ghichu.Text;
                info.HoatDong.MaHoatDong = Convert.ToInt32(hoatdong.SelectedValue);
                hddata.HoatDong(info);
            }

        }
        public void SuaHoatDong(LabelX maktx, DateTimePicker ngay, ComboBoxEx hoatdong, TextBoxX ghichu,string maktxcu,int mahdcu)
        {
            if (KiemTra(maktx, ngay, hoatdong, ghichu))
            {
                HoatDongSVInfo info = new HoatDongSVInfo();
                HoatDongSinhVienData hddata = new HoatDongSinhVienData();
                info.SinhVien.MaKTX = maktx.Text;
                info.Ngay = ngay.Value;
                info.GhiChu = ghichu.Text;
                info.HoatDong.MaHoatDong = Convert.ToInt32(hoatdong.SelectedValue);
                hddata.SuaHoatDong(info,maktxcu,mahdcu);
            }

        }
        public void XoaHoatDong(string maktxcu, int maHoatDongcu)
        {
            HoatDongSinhVienData hddata = new HoatDongSinhVienData();
            hddata.XoaHoatDong(maktxcu, maHoatDongcu);
        }


        private bool KiemTra(LabelX maktx, DateTimePicker ngay, ComboBoxEx hoatdong, TextBoxX ghichu)
        {
            if (maktx.Text == "")
            {
                MessageBox.Show("Mã KTX không hợp lệ","ky Luat");
                return false;
            }
            if(ngay.Value>DateTime.Now)
            {
                MessageBox.Show("Ngày không hợp lệ", "ky Luat");
                ngay.Value = DateTime.Now;
                ngay.Focus();
                return false;
            }
            
            if (hoatdong.SelectedIndex < 0)
            {
                MessageBox.Show("Chưa chọn Hoạt động", "ky Luat");
                hoatdong.Focus();
                return false;
            }
            if (ghichu.Text == "")
            {
                MessageBox.Show("Chưa nhập Lý do kỹ luật", "ky Luat");
                ghichu.Focus();
                return false;
            }
            return true;
        }
        public void LayHoatDongSinhVien_Theo_MAKTX(string maktx, DataGridViewX data)
        {
            HoatDongSinhVienData kldata = new HoatDongSinhVienData();
            data.DataSource = kldata.LayHoatDongSinhVien_Theo_MAKTX(maktx);

        }
    }
}
