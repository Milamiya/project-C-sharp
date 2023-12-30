using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiHoSo_DTO
    {
        private string _maLoaiHS;

        public string MaLoaiHS
        {
            get { return _maLoaiHS; }
            set { _maLoaiHS = value; }
        }
        private string _tenHS;

        public string TenHS
        {
            get { return _tenHS; }
            set { _tenHS = value; }
        }
        /*
        public LoaiHoSo_DTO(string maloaihs, string tenhs)
        {
            MaLoaiHS = maloaihs;
            TenHS = tenhs;
        }
        */
    }
}
