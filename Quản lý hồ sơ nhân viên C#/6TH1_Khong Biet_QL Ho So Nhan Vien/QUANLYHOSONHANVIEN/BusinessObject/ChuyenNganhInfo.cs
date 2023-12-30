using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QUANLYHOSONHANVIEN.BusinessObject
{
    public class ChuyenNganhInfo
    {
        public ChuyenNganhInfo() { }
        public ChuyenNganhInfo(string loai, string tenloai)
        {
            m_MaCN = loai;
            m_TenCN = tenloai;
        }

        private string m_MaCN;

        public string MaCN
        {
            get { return m_MaCN; }
            set { m_MaCN = value; }
        }

        private string  m_TenCN;

        public string  TenCN
        {
            get { return m_TenCN; }
            set { m_TenCN = value; }
        }
    }
}
