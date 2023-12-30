using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using QLKTX.BusinessObject;
using QLKTX.DataLayer;
using DevComponents.DotNetBar.Controls;
using System.Data;
using System.Windows.Forms;

namespace QLKTX.Controller
{
    public class SinhVienCtrl
    {
        SinhVienData d = new SinhVienData();
        
        ThanNhanData thanNhanData = new ThanNhanData();
        public void CapNhatDSSV(ListViewEx dssv)
        {
            bool[] thanhcong=new bool[dssv.Items.Count];
            for(int i=0;i<dssv.Items.Count;i++){
                
                SinhVienInfo sv = (SinhVienInfo)dssv.Items[i].Tag;
                if (CapNhatSV(sv))
                    thanhcong[i] = true;
                else thanhcong[i] = false;
            }

            //Xóa những Sinh viên cập nhật thành công
            int DemSinhThanhCong = 0;
            for (int i = thanhcong.Length - 1; i >= 0; i--)
            {
                if (thanhcong[i])
                {
                    DemSinhThanhCong++;
                    dssv.Items.RemoveAt(i);
                }
            }
            MessageBox.Show("Cập nhật thành công "+DemSinhThanhCong+" Sinh viên","Sinh viên",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //Xoa Danh Sách-- Nho lam ki hon mot chut khi cap nhat khong thành công hòan toan
            

        }
        /// <summary>
        /// Cập nhật sinh viên
        /// </summary>
        /// <param name="sv">Sinh viên cần cập nhật</param>
        /// <returns>
        /// true --> thành công
        /// false --> không thành công
        /// </returns>
        public bool CapNhatSV(QLKTX.BusinessObject.SinhVienInfo sv)
        {
            if (d.ThemVaoCSDL(sv))
            {
                bool thanhcong = true;// kiểm tra xem Thân Nhân có lưu được hết không
                foreach (ThanNhanInfo tn in sv.DSThanNhan)
                {
                    thanhcong = thanNhanData.ThemVaoCSDL(tn);
                }
                if (!thanhcong)//nêu thất bại
                {
                    foreach (ThanNhanInfo tn in sv.DSThanNhan)
                    {
                        thanNhanData.XoaRaKhoiCSDL(tn);
                    }
                    d.XoaRaKhoiCSDL(sv);
                    return false;
                }
                return true;
            }
            return false;
        }

        public SinhVienInfo LayDiSinhVienTuDanhSach(ListView list)
        {
            SinhVienInfo sv = new SinhVienInfo();
            IEnumerator dssv = list.SelectedItems.GetEnumerator();
            if (dssv.MoveNext())
            {
                ListViewItem item  = (ListViewItem)dssv.Current;
                list.Items.Remove(item);
                sv = (SinhVienInfo)item.Tag;
            }
            return sv;
        }

        public String LayMaKTX()
        {
            String str1 = DateTime.Now.ToString("yy");
            String str2 = Convert.ToString((Convert.ToInt32(DateTime.Now.ToString("yy"))+1));
            str2 = (Convert.ToInt32(str2)<10)?"0"+str2:str2;
            
            
            DataTable table = d.LayMaKTXMax(str1,str2);
            string Ma="";
            try
            {
                 Ma= table.Rows[0]["MA"].ToString();//dang: 07_00001
                 Ma = Ma.Substring(3);
                 int maktx = Convert.ToInt32(Ma) + 1;
                 string str3 = "";
                 if (maktx < 10)
                     str3 = "000" + maktx.ToString();
                 else
                     if (maktx < 100)
                         str3 = "00" + maktx.ToString();
                     else
                         if (maktx < 1000)
                             str3 = "0" + maktx.ToString();
                         else
                             str3 = maktx.ToString();

                 return str1 + "_" + str3;
            }
            catch(Exception e)
            {
                e.ToString();
                return str1 + "_0001";
            }
            
           
        }
        public int MaKTXToInt(string str)
        {
            return  Convert.ToInt32(str.Substring(3));            
            
        }
        public string LayMaKTXTuDanhSach(ListView list)
        {
            int maktx = 0;
            string str = "";
            foreach (ListViewItem item in list.Items)
            {
                SinhVienInfo sv = (SinhVienInfo)item.Tag;
                if (maktx < MaKTXToInt(sv.MaKTX))
                    maktx = MaKTXToInt(sv.MaKTX);
            }

            maktx++;
            if (maktx < 10)
                str = "000" + maktx.ToString();
            else
                if (maktx < 100)
                    str = "00" + maktx.ToString();
                else
                    if (maktx < 1000)
                        str = "0" + maktx.ToString();
                    else
                        str = maktx.ToString();

            return DateTime.Now.ToString("yy")+"_" + str;

            return str;

        }

        public void LayDataGridViewComboBoxColumn_CoDo(DataGridViewComboBoxColumn com)
        {
            com.DataSource = d.LayDSSinhVien();
            com.DisplayMember = "HOTEN";
            com.ValueMember = "MAKTX";
            com.DataPropertyName = "MACODO";
        }

        public void LayDSSinhVienLenComboBox(ComboBoxEx com)
        {
            com.DataSource = d.LayDSSinhVien();
            com.DisplayMember = "HOTEN";
            com.ValueMember = "MAKTX";            
        }
        public SinhVienInfo DataToInfo(DataRow r)
        {
            SinhVienInfo sv = new SinhVienInfo();
            sv.CamTinhDang = Convert.ToBoolean(r["CAMTINHDANG"].ToString());
            sv.DangVien = Convert.ToBoolean(r["DANGVIEN"].ToString());
            sv.DanToc.MaDanToc = Convert.ToInt32(r["MADT"].ToString());
            sv.DiaChi = r["DIACHI"].ToString();
            sv.DienThoai = r["DIENTHOAI"].ToString();
            sv.DoanVien = Convert.ToBoolean(r["DOANVIEN"].ToString());
            sv.GioiTinh = Convert.ToBoolean(r["GIOITINH"].ToString());
            sv.HinhAnh = r["HINH"].ToString();
            sv.HoTen = r["HOTEN"].ToString();
            sv.MaKTX = r["MAKTX"].ToString();
            sv.MSSV = r["MSSV"].ToString();
            sv.Namsinh = Convert.ToDateTime(r["NAMSINH"].ToString());
            sv.QuocTich.MaQuocTich = Convert.ToInt32(r["MAQT"].ToString());
            sv.SoCMDN = r["CMND"].ToString();
            sv.TonGiao.MaTonGiao = Convert.ToInt32(r["MATG"].ToString());
            return sv;
        }
        public void LayDSSVLenListView_Sua(ListView list)
        {
            list.Items.Clear();
            SinhVienData data = new SinhVienData();
            DataTable table =  data.LayDSSinhVien();
            foreach (DataRow r in table.Rows)
            {

                SinhVienInfo sv = DataToInfo(r);

                ListViewItem item = new ListViewItem();
                item.Text = sv.HoTen;
                item.SubItems.Add(sv.GioiTinh.ToString());
                item.Tag = sv;
                list.Items.Add(item);
            }
            
            
        }
        public bool KiemTra(TextBoxX hoten,DateTimePicker ngaysinh,TextBoxX diachi,
            TextBoxX mssv,TextBoxX cmnd,TextBoxX dienthoai,ComboBoxEx qt, ComboBoxEx dt,ComboBoxEx tg)
        {
            if (hoten.Text != "")
            {
                if(hoten.Text.Length>30){
                    MessageBox.Show("Tên không quá 30 ký tự","Sinh vien",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    hoten.Focus();
                    return false;
                }
            }
            else
            {
                hoten.Focus();
                MessageBox.Show("Chưa nhập tên","Sinh vien",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            if ((DateTime.Now.Year - ngaysinh.Value.Year) <17)
            {
                MessageBox.Show("Tuổi phải lớn hơn 16 (tính theo năm)", "Sinh vien", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ngaysinh.Focus();
                return false;
            }
            if (diachi.Text != "")
            {
                if(diachi.Text.Length>100){
                    MessageBox.Show("chiều dài Địa chỉ không quá 100 ký tự", "Sinh vien", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    diachi.Focus();
                    return false;
                }
            }
            else
            {
                diachi.Focus();
                MessageBox.Show("Chưa nhập địa chỉ","Sinh vien",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            if (mssv.Text != "")
            {
                if(mssv.Text.Length>9){
                    MessageBox.Show("Mã số Sinh viên không quá 9 ký tự","Sinh vien",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    mssv.Focus();
                    return false;
                }
            }
            else
            {
                mssv.Focus();
                MessageBox.Show("Chưa nhập MSSV","Sinh vien",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            if (cmnd.Text != "")
            {
                if (cmnd.Text.Length != 9 )
                {
                    MessageBox.Show("Chứng minh nhân phải là 9 số", "Sinh vien", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmnd.Focus();
                    return false;
                }
                else
                {
                    char[] arr = cmnd.Text.ToCharArray();
                    string s="0123456789";
                    foreach (char c in arr)
                    {
                        if(!s.Contains(c.ToString()))
                        {
                            MessageBox.Show("Chứng minh nhân dân không được có ký tự", "Sinh vien", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            cmnd.Focus();
                            return false;
                        }

                    }
                }
            }
            else
            {
                cmnd.Focus();
                MessageBox.Show("Chưa nhập số chứng minh nhân dân","Sinh vien",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            if (dienthoai.Text != "")
            {
                if (dienthoai.Text.Length != 10 && dienthoai.Text.Length != 6 && dienthoai.Text.Length != 9)
                {
                    MessageBox.Show("Số điện thoại không thích hợp", "Sinh vien", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dienthoai.Focus();
                    return false;
                }
                else
                {
                    char[] arr = cmnd.Text.ToCharArray();
                    string s = "0123456789";
                    foreach (char c in arr)
                    {
                        if (!s.Contains(c.ToString()))
                        {
                            MessageBox.Show("Số điện thoại không được có ký tự", "Sinh vien", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            cmnd.Focus();
                            return false;
                        }

                    }
                }
            }
            else
            {
                dienthoai.Focus();
                MessageBox.Show("Chưa nhập số điện thoại", "Sinh vien", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // có the khong có 
            }
            if (qt.SelectedIndex < 0)
            {
                qt.Focus();
                MessageBox.Show("Chưa chọn Quốc tịch", "Sinh vien", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (dt.SelectedIndex < 0)
            {
                dt.Focus();
                MessageBox.Show("Chưa chọn Dân tộc", "Sinh vien", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (tg.SelectedIndex < 0)
            {
                tg.Focus();
                MessageBox.Show("Chưa chọn Tôn giáo", "Sinh vien", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

        }
    }
}

