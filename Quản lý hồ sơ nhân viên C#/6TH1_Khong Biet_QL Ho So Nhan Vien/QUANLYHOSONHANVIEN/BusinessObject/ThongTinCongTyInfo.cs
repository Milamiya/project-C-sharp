using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QUANLYHOSONHANVIEN.BusinessObject
{
    public class ThongTinCongTyInfo
    {
        private string m_tenct;
        public string TenCT
        {
            get { return m_tenct; }
            set { m_tenct = value; }
        }
        private string m_diachi;
        public string DiaChi
        {
            get { return m_diachi; }
            set { m_diachi = value; }
        }
        private string m_dienthoai;
        public string DiaThoai
        {
            get { return m_dienthoai; }
            set { m_dienthoai = value; }
        }
        private string m_thudientu;
        public string ThuDienTu
        {
            get { return m_thudientu; }
            set { m_thudientu = value; }
        }
        private string m_website;
        public string SebSite
        {
            get { return m_website; }
            set { m_website = value; }
        }

    }
}
