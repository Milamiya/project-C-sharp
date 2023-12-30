using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Tinh_DTO
    {
        private string _maTinh;

        public string MaTinh
        {
            get { return _maTinh; }
            set { _maTinh = value; }
        }
        private string _tenTinh;

        public string TenTinh
        {
            get { return _tenTinh; }
            set { _tenTinh = value; }
        }
        /*
        public Tinh_DTO(string matinh,string tentinh)
        {
            MaTinh = matinh;
            TenTinh = tentinh;
        }
         */
    }
}
