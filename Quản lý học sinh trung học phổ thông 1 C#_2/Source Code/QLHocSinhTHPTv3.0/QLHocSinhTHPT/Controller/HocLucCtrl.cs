using System;
using System.Text;
using System.Data;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using QLHocSinhTHPT.DataLayer;

namespace QLHocSinhTHPT.Controller
{
    public class HocLucCtrl
    {
        DiemCtrl m_DiemCtrl     = new DiemCtrl();
        HocLucData m_HocLucData = new HocLucData();
        MonHocData m_MonHocData = new MonHocData();

        #region Hien thi ComboBox
        public void HienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.DataSource = m_HocLucData.LayDsHocLuc();
            comboBox.DisplayMember = "TenHocLuc";
            comboBox.ValueMember = "MaHocLuc";
        }
        #endregion

        #region Hien thi ComboBox trong DataGridView
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_HocLucData.LayDsHocLuc();
            cmbColumn.DisplayMember = "TenHocLuc";
            cmbColumn.ValueMember = "MaHocLuc";
            cmbColumn.DataPropertyName = "MaHocLuc";
            cmbColumn.HeaderText = "Học lực";
        }
        #endregion

        public String XepLoaiHocLucMonHoc(float[] arrayDiemTBTungMon, float tongDiem)
        {
            String xepLoai = "";
            float diemTBMonNhoNhat = arrayDiemTBTungMon[0];

            for (int i = 0; i < arrayDiemTBTungMon.Length - 1; i++)
            {
                if (arrayDiemTBTungMon[i] < diemTBMonNhoNhat)
                    diemTBMonNhoNhat = arrayDiemTBTungMon[i];
            }

            HocLucData m_HLData = new HocLucData();
            DataTable m_DT      = m_HLData.LayDsHocLuc();
            String[] maHocLuc   = new String[m_DT.Rows.Count];
            float[] diemCanDuoi = new float[m_DT.Rows.Count];

            int count = 0;
            foreach (DataRow row in m_DT.Rows)
            {
                maHocLuc[count]     = row["MaHocLuc"].ToString();
                diemCanDuoi[count]  = float.Parse(row["DiemCanDuoi"].ToString());
                count++;
            }

            for (int i = 0; i < count - 1; i++)
            {
                if (tongDiem >= diemCanDuoi[i] && diemTBMonNhoNhat >= diemCanDuoi[i + 1])
                {
                    xepLoai = maHocLuc[i];
                    break;
                }
            }

            if (xepLoai == "")
                xepLoai = maHocLuc[count - 1].ToString();
            return xepLoai;
        }

        public String XepLoaiLocLucHocKy(String maHocSinh, String maLop, String maHocKy, String maNamHoc)
        {
            float tongDiem       = 0;
            float tongDiemCacMon = 0;
            float diemTBTungMon  = 0;
            int tongHeSoCacMon   = 0;

            DataTable m_DT = m_MonHocData.LayDsMonHoc(maNamHoc, maLop);

            float[] arrayDiemTBTungMon = new float[m_DT.Rows.Count];

            int soMonHoc = 0;
            foreach (DataRow row in m_DT.Rows)
            {
                diemTBTungMon = m_DiemCtrl.DiemTrungBinhMonHocKy(maHocSinh, row["MaMonHoc"].ToString(), maHocKy, maNamHoc, maLop);
                arrayDiemTBTungMon[soMonHoc++] = diemTBTungMon;
                
                tongDiemCacMon += diemTBTungMon * Convert.ToInt32(row["HeSo"].ToString());
                tongHeSoCacMon += Convert.ToInt32(row["HeSo"].ToString());
            }
            if (tongHeSoCacMon > 0)
                tongDiem = tongDiemCacMon / tongHeSoCacMon;
            else
                tongDiem = 0;

            return XepLoaiHocLucMonHoc(arrayDiemTBTungMon, tongDiem);
        }

        public String XepLoaiLocLucCaNam(String maHocSinh, String maLop, String maNamHoc)
        {
            float tongDiem       = 0;
            float tongDiemCacMon = 0;
            float diemTBTungMon  = 0;
            int tongHeSoCacMon   = 0;

            DataTable m_DT = m_MonHocData.LayDsMonHoc(maNamHoc, maLop);

            float[] arrayDiemTBTungMon = new float[m_DT.Rows.Count];

            int soMonHoc = 0;
            foreach (DataRow row in m_DT.Rows)
            {
                diemTBTungMon = m_DiemCtrl.DiemTrungBinhMonCaNam(maHocSinh, row["MaMonHoc"].ToString(), maNamHoc, maLop);
                arrayDiemTBTungMon[soMonHoc++] = diemTBTungMon;

                tongDiemCacMon += diemTBTungMon * Convert.ToInt32(row["HeSo"].ToString());
                tongHeSoCacMon += Convert.ToInt32(row["HeSo"].ToString());
            }
            if (tongHeSoCacMon > 0)
                tongDiem = tongDiemCacMon / tongHeSoCacMon;
            else
                tongDiem = 0;

            return XepLoaiHocLucMonHoc(arrayDiemTBTungMon, tongDiem);
        }

        #region Do du lieu vao DataGridView
        public void HienThi(DataGridViewX dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();

            bS.DataSource = m_HocLucData.LayDsHocLuc();
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        #endregion

        #region Them moi
        public DataRow ThemDongMoi()
        {
            return m_HocLucData.ThemDongMoi();
        }

        public void ThemHocLuc(DataRow m_Row)
        {
            m_HocLucData.ThemHocLuc(m_Row);
        }
        #endregion

        #region Luu du lieu
        public bool LuuHocLuc()
        {
            return m_HocLucData.LuuHocLuc();
        }
        #endregion
    }
}
