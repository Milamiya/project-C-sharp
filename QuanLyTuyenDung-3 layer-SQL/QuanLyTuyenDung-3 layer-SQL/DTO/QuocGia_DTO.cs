using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class QuocGia_DTO
    {
        private string _maQG;

        public string MaQG
        {
            get { return _maQG; }
            set { _maQG = value; }
        }
        private string _tenQG;

        public string TenQG
        {
            get { return _tenQG; }
            set { _tenQG = value; }
        }
        /*
        public QuocGia_DTO(string maqg, string tenqg)
        {
            MaQG = maqg;
            TenQG = tenqg;
        }
         */
    }
}
