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
    public class KyLuatSinhVienCtrl
    {
        public void LayDSSVThuocKTX(ComboBoxEx com,DataGridViewX dgv)
        {
            if (com.SelectedIndex >= 0)
            {
                KyLuatSinhVienData data = new KyLuatSinhVienData();
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
                KyLuatSinhVienData data = new KyLuatSinhVienData();
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
                KyLuatSinhVienData data = new KyLuatSinhVienData();
                dgv.DataSource = data.LayDSSVThuocDay(com.SelectedValue.ToString());
                dgv.Columns["MAKTX"].Visible = false;
                dgv.Columns["MAPHG"].Visible = false;
                dgv.Columns["GIOITINH"].Visible = false;
            }
        }
        public void DanhGia(string MAKTX,string MAHOCKI,string MADANHGIA,string Tichcuc,string Tieucuc,string GhiChu)
        {
            KyLuatSinhVienData data = new KyLuatSinhVienData();
          //  data.DanhGia(MAKTX, MAHOCKI, MADANHGIA,Tichcuc,Tieucuc,GhiChu);
        }

        public void TimSinhVien_HocKi(ComboBoxEx comHocKi,TextBoxX ten, DataGridViewX dgv)
        {
            if (comHocKi.SelectedIndex >= 0)
            {
                KyLuatSinhVienData data = new KyLuatSinhVienData();
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
        public void KyLuat(LabelX maktx,DateTimePicker ngay,TextBoxX quyetdinhso,ComboBoxEx kl,ComboBoxEx cap, ComboBoxEx cb, TextBoxX lydo)
        {
            if (KiemTra(maktx, ngay, quyetdinhso, kl, cap, cb, lydo))
            {
                KyLuatSVInfo info = new KyLuatSVInfo();
                KyLuatSinhVienData kldata = new KyLuatSinhVienData();
                info.SinhVien.MaKTX = maktx.Text;
                info.Ngay = ngay.Value;
                info.QuyetDinhSo = quyetdinhso.Text;
                info.MaKyLuat = Convert.ToInt32(kl.SelectedValue.ToString());
                info.Cap.MaCap = Convert.ToInt32(cap.SelectedValue.ToString());
                info.CanBo.MaSo = Convert.ToInt32(cb.SelectedValue.ToString());
                info.LyDo = lydo.Text;
                kldata.KyLuat(info);
            }

        }
        public void SuaKyLuat(LabelX maktx, DateTimePicker ngay, TextBoxX quyetdinhso, ComboBoxEx kl, ComboBoxEx cap, ComboBoxEx cb, TextBoxX lydo,string maktxcau,int makyluatcu,DateTime ngaycu)
        {
            if (KiemTra(maktx,ngay,quyetdinhso,kl,cap,cb,lydo))
            {
                KyLuatSVInfo info = new KyLuatSVInfo();
                KyLuatSinhVienData kldata = new KyLuatSinhVienData();
                info.SinhVien.MaKTX = maktx.Text;
                info.Ngay = ngay.Value;
                info.QuyetDinhSo = quyetdinhso.Text;
                info.MaKyLuat = Convert.ToInt32(kl.SelectedValue.ToString());
                info.Cap.MaCap = Convert.ToInt32(cap.SelectedValue.ToString());
                info.CanBo.MaSo = Convert.ToInt32(cb.SelectedValue.ToString());
                info.LyDo = lydo.Text;
                kldata.SuaKyLuat(info,maktxcau,makyluatcu,ngaycu);
            }

        }
        public void XoaKyLuat(string maktxcau, int makyluatcu, DateTime ngaycu)
        {
            KyLuatSinhVienData kldata = new KyLuatSinhVienData();
            kldata.XoaKyLuat(maktxcau, makyluatcu, ngaycu);
        }


        private bool KiemTra(LabelX maktx, DateTimePicker ngay, TextBoxX quyetdinhso, 
            ComboBoxEx kl, ComboBoxEx cap, ComboBoxEx cb, TextBoxX lydo)
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
            if (quyetdinhso.Text == "")
            {
                MessageBox.Show("Chưa nhập số quyết định kỹ luật", "ky Luat");
                quyetdinhso.Focus();
                return false;
            }
            if (kl.SelectedIndex < 0)
            {
                MessageBox.Show("Chưa chọn hình thức kỹ luật", "ky Luat");
                kl.Focus();
                return false;
            }
            if (cap.SelectedIndex < 0)
            {
                MessageBox.Show("Chưa chọn cấp kỹ luật", "ky Luat");
                cap.Focus();
                return false;
            }
            if (cb.SelectedIndex < 0)
            {
                MessageBox.Show("Chưa chọn Bán bộ", "ky Luat");
                cb.Focus();
                return false;
            }
            if (lydo.Text == "")
            {
                MessageBox.Show("Chưa nhập Lý do kỹ luật", "ky Luat");
                lydo.Focus();
                return false;
            }
            return true;
        }
        public void LayKyLuatSinhVien_Theo_MAKTX(string maktx, DataGridViewX data)
        {
            KyLuatSinhVienData kldata = new KyLuatSinhVienData();
            data.DataSource = kldata.LayKyLuatSinhVien_Theo_MAKTX(maktx);

        }
    }
}
