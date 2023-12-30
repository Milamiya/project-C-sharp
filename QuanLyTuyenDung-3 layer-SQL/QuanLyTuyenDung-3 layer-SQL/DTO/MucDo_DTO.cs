using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MucDo_DTO
    {
        private string _maMucDo;

        public string MaMucDo
        {
            get { return _maMucDo; }
            set { _maMucDo = value; }
        }
        private string _mucDo;

        public string MucDo
        {
            get { return _mucDo; }
            set { _mucDo = value; }
        }
        /*public MucDo_DTO(string mamucdo, string mucdo)
        {
            MaMucDo = mamucdo;
            MucDo = mucdo;

        }
         */
    }
}
