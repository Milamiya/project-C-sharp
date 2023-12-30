using System;
using System.Text;
using System.Data;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors;
using QLHocSinhTHPT.DataLayer;

namespace QLHocSinhTHPT.Controller
{
    public class QuyDinhCtrl
    {
        QuyDinhData m_QuyDinhData = new QuyDinhData();

        public void HienThi(IntegerInput txtSiSoCanDuoi,
                            IntegerInput txtSiSoCanTren,
                            IntegerInput txtDoTuoiCanDuoi,
                            IntegerInput txtDoTuoiCanTren,
                            CheckBoxX ckbThang10,
                            CheckBoxX ckbThang100,
                            TextBoxX txtTenTruong,
                            TextBoxX txtDiaChiTruong)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_QuyDinhData.LayDsQuyDinh();

            DataTable dT = m_QuyDinhData.LayDsQuyDinh();
            int thangDiem = Convert.ToInt32(dT.Rows[0]["ThangDiem"]);

            if (thangDiem == 10)
                ckbThang10.Checked = true;
            else
                ckbThang100.Checked = true;

            txtSiSoCanDuoi.DataBindings.Clear();
            txtSiSoCanDuoi.DataBindings.Add("Value", bS, "SiSoCanDuoi");

            txtSiSoCanTren.DataBindings.Clear();
            txtSiSoCanTren.DataBindings.Add("Value", bS, "SiSoCanTren");

            txtDoTuoiCanDuoi.DataBindings.Clear();
            txtDoTuoiCanDuoi.DataBindings.Add("Value", bS, "TuoiCanDuoi");

            txtDoTuoiCanTren.DataBindings.Clear();
            txtDoTuoiCanTren.DataBindings.Add("Value", bS, "TuoiCanTren");

            txtTenTruong.DataBindings.Clear();
            txtTenTruong.DataBindings.Add("Text", bS, "TenTruong");

            txtDiaChiTruong.DataBindings.Clear();
            txtDiaChiTruong.DataBindings.Add("Text", bS, "DiaChiTruong");
        }

        public void CapNhatQuyDinhSiSo(int siSoCanDuoi, int siSoCanTren)
        {
            m_QuyDinhData.CapNhatQuyDinhSiSo(siSoCanDuoi, siSoCanTren);
        }

        public void CapNhatQuyDinhDoTuoi(int tuoiCanDuoi, int tuoiCanTren)
        {
            m_QuyDinhData.CapNhatQuyDinhDoTuoi(tuoiCanDuoi, tuoiCanTren);
        }

        public void CapNhatQuyDinhTruong(String tenTruong, String diaChiTruong)
        {
            m_QuyDinhData.CapNhatQuyDinhTruong(tenTruong, diaChiTruong);
        }

        public void CapNhatQuyDinhThangDiem(int thangDiem)
        {
            m_QuyDinhData.CapNhatQuyDinhThangDiem(thangDiem);
        }
    }
}
