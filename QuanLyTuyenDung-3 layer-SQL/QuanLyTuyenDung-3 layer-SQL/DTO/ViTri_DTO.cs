using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ViTri_DTO
    {
        private string _maViTri;

        public string MaViTri
        {
            get { return _maViTri; }
            set { _maViTri = value; }
        }
        private string _tenViTri;

        public string TenViTri
        {
            get { return _tenViTri; }
            set { _tenViTri = value; }
        }
        /*
        public ViTri_DTO(string mavitri, string tenvitri)
        {
            MaViTri = mavitri;
            TenViTri = tenvitri;
        }
         */ 
    }
}
