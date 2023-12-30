using System;
using System.Text;
using System.Data;
using System.Windows.Forms;
using QuanLyHoSoCongChuc.DataLayer;
using QuanLyHoSoCongChuc.BusinessObject;

namespace QuanLyHoSoCongChuc.Controller
{
    public class NguoiDungCtrl
    {
        NguoiDungData m_NguoiDungData = new NguoiDungData();

        NguoiDungInfo m_NguoiDungInfo = new NguoiDungInfo();

        public void HienThiComboBox(ComboBox cmb)
        {
            DataTable m_DT = m_NguoiDungData.LayDSNguoiDung();
            cmb.DataSource = m_DT;
            cmb.DisplayMember = "TENQUYEN";
            cmb.ValueMember = "MAQUYEN";
        }

        public void HienThi(DataGridView dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();

            bS.DataSource = m_NguoiDungData.LayDSNguoiDung();
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }

        public DataRow ThemDongMoi()
        {
            return m_NguoiDungData.ThemDongMoi();
        }

        public void ThemNguoiDung(DataRow m_Row)
        {
            m_NguoiDungData.ThemNguoiDung(m_Row);
        }

        public bool LuuNguoiDung()
        {
            return m_NguoiDungData.LuuNguoiDung();
        }


        private String m_PhanQuyen;
        public String PhanQuyen
        {
            get { return m_PhanQuyen; }
            set { m_PhanQuyen = value; }
        }

        public int DangNhap(String username, String password)
        {
            DataTable pw = m_NguoiDungData.LayPassWord(password);
            DataTable nd = m_NguoiDungData.LayNguoiDung(username);
            if (nd.Rows.Count == 0)
                return 0;

            String matkhau_hethong = nd.Rows[0][3].ToString();

            if (matkhau_hethong != password)
            {
                return 1;
            }
            else
            {
                NguoiDungInfo ndinfo = new NguoiDungInfo(nd.Rows[0][0].ToString(), nd.Rows[0][1].ToString(), nd.Rows[0][2].ToString(), nd.Rows[0][3].ToString(), Convert.ToInt32(nd.Rows[0][4]));

                staticClass.nguoidungStatic = ndinfo;
                return 2;
            }
        }

        public String LayTenNguoiDung(string m_TenND)
        {
            m_NguoiDungInfo.TenDangNhap = m_TenND;


            DataTable tenNguoiDung = m_NguoiDungData.LayNguoiDung(m_NguoiDungInfo.TenDangNhap);

            if (tenNguoiDung.Rows.Count == 0)
                return "";

            else
                return tenNguoiDung.Rows[0]["TenDangNhap"].ToString();
        }
        public String LayMatKhau(string m_MK)
        {
            m_NguoiDungInfo.MatKhau = m_MK;


            DataTable matkhau = m_NguoiDungData.LayPassWord(m_NguoiDungInfo.MatKhau);

            if (matkhau.Rows.Count == 0)
                return "";

            else
                return matkhau.Rows[0]["MatKhau"].ToString();
        }
        public void ChangePassword(String userName, String newPassword)
        {
            m_NguoiDungData.ChangePassword(userName, newPassword);
        }
    }
}
