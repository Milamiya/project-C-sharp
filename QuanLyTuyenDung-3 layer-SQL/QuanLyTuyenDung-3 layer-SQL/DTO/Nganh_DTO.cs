using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Nganh_DTO
    {
        private string _maNganh;

        public string MaNganh
        {
            get { return _maNganh; }
            set { _maNganh = value; }
        }
        private string _tenNganh;

        public string TenNganh
        {
            get { return _tenNganh; }
            set { _tenNganh = value; }
        }
        /*
        public Nganh_DTO(string manganh, string tennganh)
        {
            MaNganh = manganh;
            TenNganh = tennganh;
        }
         */ 
    }
}
