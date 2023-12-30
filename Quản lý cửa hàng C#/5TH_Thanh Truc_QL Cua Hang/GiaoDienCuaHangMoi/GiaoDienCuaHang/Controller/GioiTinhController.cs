using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using GiaoDienCuaHang.DataLayer;

namespace GiaoDienCuaHang.Controller
{
   public class GioiTinhController
    {
       GioiTinhData data = new GioiTinhData();
       public DataGridViewComboBoxColumn LoadComboBoxColumn()
       {
           DataGridViewComboBoxColumn colgt = new DataGridViewComboBoxColumn();
           colgt.DataSource = data.LayDSGioiTinh();
           colgt.DisplayMember = "TENGIOITINH";
           colgt.ValueMember = "GIOITINH";
           colgt.HeaderText = "Giới Tính";
           colgt.DataPropertyName = "GIOITINH"; //Cot GIOITINH trong bang GIOITINH
           return colgt;
       }

       //Do du lieu vao o combobox gioi tinh

       public void LoadComboBoxGioiTinh(ComboBox cmbgioitinh)
       {
           GioiTinhData gtdata = new GioiTinhData();
           cmbgioitinh.DataSource = gtdata.LayDSGioiTinh();
           cmbgioitinh.DisplayMember = "TENGIOITINH";
           cmbgioitinh.ValueMember = "GIOITINH";
           cmbgioitinh.SelectedValue = "GIOITINH";
       }
    }
}
