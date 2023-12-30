using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TrinhDo_DTO
    {
        private string _maTrinhDo;

        public string MaTrinhDo
        {
            get { return _maTrinhDo; }
            set { _maTrinhDo = value; }
        }
        private string _tenTrinhDo;

        public string TenTrinhDo
        {
            get { return _tenTrinhDo; }
            set { _tenTrinhDo = value; }
        }
        /*
        public TrinhDo_DTO(string matrinhdo,string tentrinhdo)
        {
            MaTrinhDo = matrinhdo;
            TenTrinhDo = tentrinhdo;
        }
         */
    }
}
