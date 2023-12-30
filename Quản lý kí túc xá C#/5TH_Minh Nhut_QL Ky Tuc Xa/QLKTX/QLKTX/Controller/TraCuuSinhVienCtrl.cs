using System;
using System.Collections.Generic;
using System.Text;
using DevComponents.DotNetBar.Controls;
using System.Windows.Forms;
using System.Data;

using QLKTX.DataLayer;
namespace QLKTX.Controller
{
    public class TraCuuSinhVienCtrl
    {
        TraCuuSinhVienData tracuudata = new TraCuuSinhVienData();
        public void TraCuu(DataGridViewX data,TextBoxX HoTen
                           ,ComboBoxEx DKDiaChi,TextBoxX DiaChi
                           ,ComboBoxEx DKGioiTinh,CheckBoxX GioiTinh
                           , ComboBoxEx DKMSSV, TextBoxX MSSV
                           , ComboBoxEx DKQuocTich, ComboBoxEx QuocTich
                           , ComboBoxEx DKDanToc, ComboBoxEx DanToc
                           , ComboBoxEx DKTonGiao, ComboBoxEx TonGiao
                           , ComboBoxEx DKCMND, TextBoxX CMND)
        {
            if (KT(DKDiaChi, DiaChi, "Địa chỉ")
               && KT(DKMSSV, MSSV, "Mã số Sinh viên") && KT(DKQuocTich, QuocTich, "Quốc Tịch")
               && KT(DKDanToc, DanToc, "Dân tộc") && KT(DKTonGiao, TonGiao, "Tôn Giáo") && KT(DKCMND, CMND, "số Chứng minh nhân dân"))
            {
                //MessageBox.Show("đúng");
             DataTable table =   tracuudata.TraCuu(HoTen.Text,DKDiaChi.SelectedItem.ToString(),DiaChi.Text,
                    DKGioiTinh.SelectedItem.ToString(),(GioiTinh.Checked==true?"true":"false"),
                    DKMSSV.SelectedItem.ToString(),MSSV.Text,DKQuocTich.SelectedItem.ToString(),QuocTich.SelectedValue.ToString(),
                    DKDanToc.SelectedItem.ToString(),DanToc.SelectedValue.ToString(),
                    DKTonGiao.SelectedItem.ToString(),TonGiao.SelectedValue.ToString(),
                    DKCMND.SelectedItem.ToString(),CMND.Text
                );
             data.DataSource = table;
            }

        }
        /// <summary>
        /// Kiểm tra combobox có chon chưa
        /// </summary>
        /// <param name="cmb"></param>
        /// <param name="ThongBao"></param>
        /// <returns></returns>
        public bool CoChon(ComboBoxEx cmb,string ThongBao)
        {
            if (cmb.SelectedIndex >= 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Chưa chọn " + ThongBao);
                cmb.Focus();
            }
            return false;
        }
        /// <summary>
        /// Lấy Dữ Liệu đã chọn
        /// </summary>
        /// <param name="cmb"></param>
        /// <returns></returns>
        public string LayDuLieu(ComboBoxEx cmb)
        {
            if (cmb.SelectedIndex >= 0)
            {
                return cmb.SelectedItem.ToString();
            }
            else
            {
                return "";
            }            
        }
        public bool KT(ComboBoxEx cmb, TextBoxX text,string ThongBao)
        {
            if (cmb.SelectedIndex >= 0)
            {
                if (cmb.SelectedItem.ToString() != "None")
                {
                    if (text.Text == "" || text == null)
                    {
                        MessageBox.Show("Chưa nhập " + ThongBao);
                        text.Focus();
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }else
            {
                MessageBox.Show("Chưa chọn " + ThongBao);
                cmb.Focus();
                return false;
            }
            return true;
        }
        public bool KT(ComboBoxEx cmb, ComboBoxEx com1, string ThongBao)
        {
            if (cmb.SelectedIndex >= 0)
            {
                if (cmb.SelectedItem.ToString() != "None")
                {
                    if (com1.SelectedIndex<0)
                    {
                        MessageBox.Show("Chưa chọn " + ThongBao);
                        com1.Focus();
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn Điều kiện " + ThongBao);
                cmb.Focus();
                return false;
            }
            return true;
        }
        /// <summary>
        /// Lấy Dữ Liệu đã chọn
        /// </summary>
        /// <param name="cmb"></param>
        /// <returns></returns>
        public string LayDuLieu(ComboBoxEx cmb,TextBoxX text)
        {
            if (text.Text!="")
            {               
                
                    return text.Text;
            }
            else
            {
                if (cmb.SelectedItem.ToString() != "None")
                {
                    return "";
                }
                else
                {
                    return "";
                }
            }
        }
        public void TraCuuTheoPhong(DataGridViewX data,string tenphong)
        {
            TraCuuSinhVienData tracuu = new TraCuuSinhVienData();
            data.DataSource = tracuu.TraCuuTheoPhong(tenphong);
        }
        public void TraCuuTheoDay(DataGridViewX data, string tenday)
        {
            TraCuuSinhVienData tracuu = new TraCuuSinhVienData();
            data.DataSource = tracuu.TraCuuTheoDay(tenday);
        }
    
}
}
