using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using QLKTX.BusinessObject;

namespace QLKTX.Controller
{
    public class ThanNhanCtrl
    {
        public ThanNhanCtrl()
        {

        }
        /// <summary>
        /// Chỉnh sửa lại cột STT khi có thao tác xóa trên ListView
        /// </summary>
        /// <param name="list">ListView Cần Chỉnh</param>
        public void SuaMaSoThanNhan(ListView list)
        {
            for (int i = 0; i < list.Items.Count; i++)
            {
                list.Items[i].Text = Convert.ToString(i + 1);
                ThanNhanInfo tn = (ThanNhanInfo)list.Items[i].Tag;
                tn.MaThanNhan = Convert.ToInt32(list.Items[i].Text);
                list.Items[i].Tag = tn;
                
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="list"></param>
        public void XoaThanNhan(ListView list)
        {
            IEnumerator rows = list.Items.GetEnumerator();
            if (MessageBox.Show("Bạn có muốn xóa Thân Nhân không?", "Thân Nhân", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                while (rows.MoveNext())
                {
                    ListViewItem item = (ListViewItem)rows.Current;
                    if (item.Selected == true)
                    {
                        list.Items.Remove(item);
                    }
                }
                QLKTX.Controller.ThanNhanCtrl tn = new ThanNhanCtrl();
                tn.SuaMaSoThanNhan(list);

            }
            else
            {
                //Khi khong muon xoa
            }
        }
        public void SuaThongTinThanNhan(ListView listDS,TextBox txtHoTen, ComboBoxEx cmbQuanHe,ComboBoxEx cmbNgheNghiep)
        {
            if (MessageBox.Show("Sửa Thông tin!", "Thân Nhân", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                IEnumerator list = listDS.SelectedItems.GetEnumerator();
                if (list.MoveNext())
                {
                    ListViewItem row = (ListViewItem)list.Current;
                    listDS.Items.Remove(row);
                    txtHoTen.Text = row.SubItems[1].Text;
                    cmbQuanHe.Text = row.SubItems[2].Text;
                    cmbNgheNghiep.Text = row.SubItems[3].Text;
                }
                SuaMaSoThanNhan(listDS);
            }
            else
            { //Không xóa
            }
        }
    }
}
