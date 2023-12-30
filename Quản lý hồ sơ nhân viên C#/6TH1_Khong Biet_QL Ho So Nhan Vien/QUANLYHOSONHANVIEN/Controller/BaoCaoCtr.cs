using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QUANLYHOSONHANVIEN.Controller;
using QUANLYHOSONHANVIEN.DataLayer;
using System.Data;
using System.Windows.Forms;

namespace QUANLYHOSONHANVIEN.Controller
{
    public class BaoCaoCtr
    {
        PhongBanData data_pb = new PhongBanData();
        NgoaiNguData data_nngu = new NgoaiNguData();
        DotDaoTaoData data_ddt = new DotDaoTaoData();
        DotDanhGiaData data_ddg = new DotDanhGiaData();
        ChuyenNganhData data_chuyennganh = new ChuyenNganhData();
        NgheNghiepData data_nnghiep = new NgheNghiepData();

        public void HienThiPhongBanComBoBox(DevComponents.DotNetBar.Controls.ComboBoxEx cmb)
        {
            string[] Fisrt = { "%", "Tất Cả" };
            DataTable tbl = data_pb.DanhsachPhongBan();
            tbl.Rows.Add(Fisrt);
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TENPB";
            cmb.ValueMember = "MAPB";
        }
        public void HienThiAutoComboboxNGOAINGU(ComboBox cmb)
        {
            string[] Fisrt = { "%", "Tất Cả" };
            DataTable tbl = data_nngu.DanhsachNGOAINGU();
            tbl.Rows.Add(Fisrt);
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TENNN";
            cmb.ValueMember = "MANN";
        }
        public void HienThiAutoComboboxDotDaoTao(ComboBox cmb)
        {
            string[] Fisrt = { "%", "Tất Cả" };
            DataTable tbl = data_ddt.DanhsachDOTDAOTAO();
            cmb.DataSource = tbl;
            tbl.Rows.Add(Fisrt);
            cmb.DisplayMember = "TENDDT";
            cmb.ValueMember = "MADDT";
        }
        public void HienThiAutoComboboxDotDanhGia(ComboBox cmb)
        {
            string[] Fisrt = { "%", "Tất Cả" };
            DataTable tbl = data_ddg.DanhsachDOTDANHGIA();
            cmb.DataSource = tbl;
            tbl.Rows.Add(Fisrt);
            cmb.DisplayMember = "TENDDG";
            cmb.ValueMember = "MADDG";
        }
        public void HienThiAutoComboboxChuyenMon(ComboBox cmb)
        {
            string[] Fisrt = { "%", "Tất Cả" };
            DataTable tbl = data_chuyennganh.DanhsachChuyenNganh();
            cmb.DataSource = tbl;
            tbl.Rows.Add(Fisrt);
            cmb.DisplayMember = "NGANHDAOTAO";
            cmb.ValueMember = "MACHUYENNGANH";
        }
        public void HienThiAutoComboboxNgheNghiep(ComboBox cmb)
        {
            string[] Fisrt = { "%", "Tất Cả" };
            DataTable tbl = data_nnghiep.DanhsachNGHENGHIEP();
            cmb.DataSource = tbl;
            tbl.Rows.Add(Fisrt);
            cmb.DisplayMember = "TENNN";
            cmb.ValueMember = "MANN";
        }
        public void HienThiAutoComboboxPHONGBAN(ComboBox cmb)
        {
            string[] Fisrt = { "%", "Tất Cả" };
            DataTable tbl = data_pb.DanhsachPhongBan();
            tbl.Rows.Add(Fisrt);
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TENPB";
            cmb.ValueMember = "MAPB";
        }
    }
    
}
