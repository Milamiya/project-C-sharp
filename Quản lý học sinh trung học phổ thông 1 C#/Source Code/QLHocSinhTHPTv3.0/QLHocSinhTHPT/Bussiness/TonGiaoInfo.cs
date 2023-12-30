using System;
using System.Collections.Generic;
using System.Text;

//Hoàn chỉnh
namespace QLHocSinhTHPT.Bussiness
{
    public class TonGiaoInfo
    {
        public TonGiaoInfo()
        {

        }

        private String m_MaTonGiao;
        public String MaTonGiao
        {
            get { return m_MaTonGiao; }
            set { m_MaTonGiao = value; }
        }

        private String m_TenTonGiao;
        public String TenTonGiao
        {
            get { return m_TenTonGiao; }
            set { m_TenTonGiao = value; }
        }
    }
}
