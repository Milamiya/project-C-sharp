using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using GiaoDienCuaHang.DataLayer;

namespace GiaoDienCuaHang.Controller
{
   public class LoaiNhanVienController
    {
       LoaiNhanVienData data = new LoaiNhanVienData();
       public void HienThi(TextBox txtMLNV, TextBox txtTLNV, DataGridView dg, BindingNavigator bn)
       {
           BindingSource bs = new BindingSource();
           bs.DataSource = data.LayDSLoaiNhanVien();
           bn.BindingSource = bs;
           dg.DataSource = bs;

           txtMLNV.DataBindings.Add("Text",bs,"MALOAINV");
           txtTLNV.DataBindings.Add("Text",bs,"TENLOAINV");
          
       }
           public DataGridViewComboBoxColumn LoadComboBoxColumn()
        {
            DataGridViewComboBoxColumn colma = new DataGridViewComboBoxColumn();
            colma.DataSource = data.LayDSLoaiNhanVien();             
            colma.DisplayMember = "TENLOAINV";
            colma.ValueMember = "MALOAINV";
            colma.HeaderText = "Loại Nhân viên";
            colma.DataPropertyName = "LOAINV"; //Cot MALOAINV trong bang NHANVIEN
            return colma;
        }

        //Do du lieu vao o combobox Loai Nhan Vien
       
       public void LoadComboBoxLoaiNV(ComboBox cmbLoaiNV)
       {
           LoaiNhanVienData loainvdata = new LoaiNhanVienData();
           cmbLoaiNV.DataSource = loainvdata.LayDSLoaiNhanVien();
           cmbLoaiNV.DisplayMember = "TENLOAINV";
           cmbLoaiNV.ValueMember = "MALOAINV";
           cmbLoaiNV.SelectedValue = "LOAINV";
       }
       public void Update()
       {
           data.Update();
       }

       }
    }

