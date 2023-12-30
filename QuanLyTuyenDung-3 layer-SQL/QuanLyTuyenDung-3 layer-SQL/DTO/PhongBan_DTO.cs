using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhongBan_DTO
    {
        private string _maPB;

        public string MaPB
        {
            get { return _maPB; }
            set { _maPB = value; }
        }
        private string _tenPB;

        public string TenPB
        {
            get { return _tenPB; }
            set { _tenPB = value; }
        }
        /*
        public PhongBan_DTO(string mapb, string tenpb)
        {
            MaPB = mapb;
            TenPB = tenpb;
        }
         */
    }
}
