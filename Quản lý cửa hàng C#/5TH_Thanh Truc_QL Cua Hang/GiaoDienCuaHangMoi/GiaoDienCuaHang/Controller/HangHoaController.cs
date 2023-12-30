using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using GiaoDienCuaHang.DataLayer;

namespace GiaoDienCuaHang.Controller
{
   public class HangHoaController
    {
       HangHoaData data = new HangHoaData();
       public void HienThiDataGridView(TextBox txtMHH, TextBox txtTHH, TextBox txtSL,ComboBox cmbMDVT,DateTimePicker dt,TextBox txtSLG,TextBox txtTLG, DataGridView dgv, BindingNavigator bn)
       {
           BindingSource bs = new BindingSource();
           bs.DataSource = data.LayDSHangHoa();
           dgv.DataSource = bs;
           bn.BindingSource = bs;
           txtMHH.DataBindings.Add("Text", bs, "MAHH");
           txtTHH.DataBindings.Add("Text", bs, "TENHH");
           txtSL.DataBindings.Add("Text", bs, "SOLUONG");
           cmbMDVT.DataBindings.Add("SelectedValue", bs, "MADVT");
           dt.DataBindings.Add("Text", bs, "NGAYHETHAN");
           txtSLG.DataBindings.Add("Text", bs, "SOLUONGGIAM");
           txtTLG.DataBindings.Add("Text", bs, "TILEGIAM");

           DonViTinhController dvtctrl = new DonViTinhController();
           dgv.Columns.Add(dvtctrl.LoadComboBoxColumn());
           dgv.Columns.Remove("MADVT");

           dvtctrl.LoadComboBoxDVT(cmbMDVT);
       }
       public void HienThiDataGridViewHHsaphethan(DataGridView dgv, BindingNavigator bn)
       {
           BindingSource bs = new BindingSource();
           bs.DataSource = data.LayDSHHsaphethan();
           dgv.DataSource = bs;
           bn.BindingSource = bs;
                    
       }

       public void LoadComboBoxHangHoa(ComboBox cmb)
       {
           cmb.DataSource = data.LayDSHangHoa();
           cmb.DisplayMember = "TENHH";
           cmb.ValueMember = "MAHH";
           //cmb.SelectedValue = "MAHH";
        }
       public DataGridViewComboBoxColumn LoadComboBoxColumn()
       {
           DataGridViewComboBoxColumn colma = new DataGridViewComboBoxColumn();
           colma.DataSource = data.LayDSHangHoa();
           colma.DisplayMember = "TENHH";
           colma.ValueMember = "MAHH";
           colma.HeaderText = "Mã sản phẩm";
           colma.DataPropertyName = "MASP"; //Cot MASP trong bang TONKHO
           return colma;
       }
        string strTenHangHoa;

        public ListViewItem.ListViewSubItem LoadListViewSubItemHangHoa(string str)
        {
            ListViewItem.ListViewSubItem subI = new ListViewItem.ListViewSubItem();
            DataTable dt = data.LayDSHangHoa();
            subI.Tag = dt;
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["MAHH"].ToString() == str)
                    strTenHangHoa = dr["TENHH"].ToString();

            }
            subI.Text = strTenHangHoa;
            return subI;
        }

       public void TimKiemHH(TextBox txttenHH,ComboBox cmbchonMDVT,ComboBox cmbMDVT,ComboBox cmbchonSL,TextBox txtSL,ComboBox cmbchonSLG,TextBox txtSLG,ComboBox cmbchonTLG,TextBox txtTLG,DataGridView dg)
       {
           DataTable tbl = data.TimKiemHangHoa(txttenHH.Text, cmbchonMDVT.Text, cmbMDVT.Text, cmbchonSL.Text, txtSL.Text, cmbchonSLG.Text, txtSLG.Text, cmbchonTLG.Text, txtTLG.Text);
           if (tbl.Rows.Count == 0)
           {
               MessageBox.Show("Tìm không thấy trong danh sách HÀNG HÓA.Vui lòng kiểm tra lại các thông tin","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
           }
           dg.DataSource = tbl;

       }
    /*   string strdon_gia;
       public string LayDonGia(string tenhang)
       {
           DataTable dtb = data.LayDSHangHoa();
           foreach (DataRow dtr in dtb.Rows)
           {
               if (dtr["TENHH"].ToString() == tenhang)
               {
                   strdon_gia = dtr["DONGIA"].ToString();
                   break;
               }
           }
           return strDonGia;
       }*/
       public void Update()
       {
           data.Update();
       }
    }
}
