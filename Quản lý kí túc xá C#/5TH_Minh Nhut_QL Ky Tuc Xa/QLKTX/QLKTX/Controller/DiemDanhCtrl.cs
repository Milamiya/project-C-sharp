using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using QLKTX.DataLayer;
using QLKTX.BusinessObject;

namespace QLKTX.Controller
{
    public class DiemDanhCtrl
    {
        public void Tim_DiemDanh_Dk_KTX(DataGridViewX dgv,ComboBoxEx comKTX)
        {
            DiemDanhData data = new DiemDanhData();
             dgv.DataSource =  data.Tim_DiemDanh_DK_KTX(comKTX.SelectedValue.ToString());

             dgv.Columns["MAKTX"].Visible = false;
             dgv.Columns["MAPHG"].Visible = false;
        }
        public void Tim_DiemDanh_Dk_Day(DataGridViewX dgv, ComboBoxEx comDay)
        {
            DiemDanhData data = new DiemDanhData();
            dgv.DataSource = data.Tim_DiemDanh_DK_Day(comDay.SelectedValue.ToString());

            dgv.Columns["MAKTX"].Visible = false;
            dgv.Columns["MAPHG"].Visible = false;
        }
        public void Tim_DiemDanh_Dk_Phong(DataGridViewX dgv, ComboBoxEx comPHG)
        {
            DiemDanhData data = new DiemDanhData();
            dgv.DataSource = data.Tim_DiemDanh_DK_Phong(comPHG.SelectedValue.ToString());

            dgv.Columns["MAKTX"].Visible = false;
            dgv.Columns["MAPHG"].Visible = false;
        }
        public void Tim_DiemDanh_Dk_MaKTX(DataGridViewX dgv, string MAKTX)
        {
            DiemDanhData data = new DiemDanhData();
            dgv.DataSource = data.Tim_DiemDanh_DK_MAKTX(MAKTX);

            dgv.Columns["MAKTX"].Visible = false;
            dgv.Columns["MAPHG"].Visible = false;
        }
        public DiemDanhInfo DataToInfo(DataGridViewRow r ,DateTime ngay, bool cophep)
        {
            DiemDanhInfo dd = new DiemDanhInfo();
            dd.CoPhep = cophep;
            dd.NgayVang = ngay;
            PhongInfo p=new PhongInfo();
            p.MaPhong=r.Cells["MAPHG"].Value.ToString();
            dd.Phong = p;
            SinhVienInfo sv=new SinhVienInfo();
            sv.MaKTX=r.Cells["MAKTX"].Value.ToString();
            sv.HoTen = r.Cells["HOTEN"].Value.ToString();
            dd.SinhVien = sv;            
            return dd;
        }
        public void Them(DiemDanhInfo info)
        {
            DiemDanhData data = new DiemDanhData();
            data.Them(info);
        }
    }
}
