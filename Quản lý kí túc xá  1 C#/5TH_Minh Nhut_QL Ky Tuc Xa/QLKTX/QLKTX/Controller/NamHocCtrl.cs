using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QLKTX.DataLayer;
using QLKTX.BusinessObject;
using DevComponents.DotNetBar.Controls;

namespace QLKTX.Controller
{
    public class NamHocCtrl
    {
        NamHocData Data = new NamHocData();
        public NamHocCtrl()
        {
        }

        public DataGridViewComboBoxColumn ColumnNamHoc()
        {
            DataGridViewComboBoxColumn c = new DataGridViewComboBoxColumn();
            c.DataSource = Data.LayDSNamHoc();
            c.DisplayMember = "TENNAMHOC";
            c.ValueMember = "MANAMHOC";

            c.DataPropertyName = "MANAM";
            return c;
        } 

        public void HienThi(DataGridView dg, BindingNavigator bn,TextBox ma,TextBox ten,DateTimePicker batdau,DateTimePicker ketthuc)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = Data.LayDSNamHoc();
            bn.BindingSource = bs;
            dg.DataSource = bs;

            if (ma.DataBindings.Count > 0)
            {
                ma.DataBindings.RemoveAt(0);
                ten.DataBindings.RemoveAt(0);
                batdau.DataBindings.RemoveAt(0);
                ketthuc.DataBindings.RemoveAt(0);

            }
            ma.DataBindings.Add("Text",bs,"MANAMHOC");
            ten.DataBindings.Add("Text", bs, "TENNAMHOC");

            batdau.DataBindings.Add("Value", bs, "NGAYBATDAU");
            ketthuc.DataBindings.Add("Value", bs, "NGAYKETTHUC");

        }
        public void HienThiLai(DataGridView dg, BindingNavigator bn, TextBox ma, TextBox ten, DateTimePicker batdau, DateTimePicker ketthuc)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = Data.LayDSNamHoc();
            bn.BindingSource = bs;
            dg.DataSource = bs;

        }


        public DataGridViewRow InfoToRow(NamHocInfo nh,DataGridView grid){
            DataGridViewRow r = (DataGridViewRow)grid.Rows[0].Clone();

            DataGridViewCell c = (DataGridViewCell)r.Cells[0].Clone();
            c.Value = nh.MaNamHoc.ToString();
            r.Cells["txtMaNamHoc"] = c;
            c.Value = nh.TenNamHoc;
            r.Cells["txtTenNamHoc"] =c;
            c.Value = nh.NgayBatDau;
            r.Cells["txtNgayBatDau"] = c;
            c.Value = nh.NgayKetThuc;
            r.Cells["txtNgayKetThuc"] = c;            
            
            return r;

        }
        public void Update()
        {
            Data.Update();
        }
        public void ThemNamHoc(NamHocInfo nam)
        {
            Data.ThemNamHoc(nam);
        }
        public void XoaNamHoc(NamHocInfo nam)
        {
            Data.XoaNamHoc(nam);
        }
        public void SuaNamHoc(NamHocInfo nam)
        {
            Data.SuaNamHoc(nam);
        }
        public void LayDSNamHoc(ComboBoxEx com)
        {
            NamHocData dt = new NamHocData();
            com.DataSource = dt.LayDSNamHoc();
            com.DisplayMember = "TENNAMHOC";
            com.ValueMember = "MANAMHOC";
        }
    }
}
