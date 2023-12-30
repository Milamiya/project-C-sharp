using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections;
using System.Windows.Forms;
using GiaoDienCuaHang.DataLayer;
using GiaoDienCuaHang.Controller;

namespace GiaoDienCuaHang.Controller
{
   public class PhieuSuCoController
    {
       HangHoaController HHctrl = new HangHoaController();
       PhieuSuCoData data = new PhieuSuCoData();
       public void HienThiListView(ListView listview)
       {
           listview.Items.Clear();
           DataTable dtb = data.LayDSPSC();
           int n = 0;
           foreach (DataRow row in dtb.Rows)
           {
               ListViewItem item = new ListViewItem();
               n++;
               item.Text = n.ToString();
               item.SubItems.Add(row["MAPHIEUSUCO"].ToString());
               item.SubItems.Add(row["MASP"].ToString());
               item.SubItems.Add(row["NGAYHUHONG"].ToString());
               item.SubItems.Add(row["LYDO"].ToString());
               item.SubItems.Add(row["SOLUONGHUHONG"].ToString());
               item.SubItems.Add(row["DONGIA"].ToString());
               item.SubItems.Add(row["TONGTIENHUHONG"].ToString());

               listview.Items.Add(item);

           }
       }
       public void HienThiComboBox(ComboBox cmbMaSP)
       {
           HHctrl.LoadComboBoxHangHoa(cmbMaSP);
           
       }
       public void Luu_PhieuSuCo(TextBox MaPSC, ComboBox MaSP, DateTimePicker NgayLap, TextBox Ldo,TextBox SLuong,TextBox DGia,TextBox TTien)
       {
           PhieuSuCoData pscdata = new PhieuSuCoData();

           DataTable dt = pscdata.LayDSPSC();
           DataRow row = dt.NewRow();

           row[0] = MaPSC.Text;
           row[1] = MaSP.SelectedValue;
           row[2] = NgayLap.Value.Date;
           row[3] = Ldo.Text;
           row[4] = SLuong.Text;
           row[5] = DGia.Text;
           row[6] = TTien.Text;

           dt.Rows.Add(row);
           pscdata.Update();

       }
       public void Update()
       {
           data.Update();
       }
    }
}
