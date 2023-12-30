using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Huyen_DTO
    {
        private string _maHuyen;

        public string MaHuyen
        {
            get { return _maHuyen; }
            set { _maHuyen = value; }
        }
        private string _tenHuyen;

        public string TenHuyen
        {
            get { return _tenHuyen; }
            set { _tenHuyen = value; }
        }
        /*public Huyen_DTO(string mahuyen, string tenhuyen)
        {
            MaHuyen = mahuyen;
            TenHuyen = tenhuyen;
        }*/
    }
}
