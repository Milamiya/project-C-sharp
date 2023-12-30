using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongBao_DTO
    {
        private string _maTB;

        public string MaTB
        {
            get { return _maTB; }
            set { _maTB = value; }
        }
        private string _loaiTB;

        public string LoaiTB
        {
            get { return _loaiTB; }
            set { _loaiTB = value; }
        }
        private string _lyDo;

        public string LyDo
        {
            get { return _lyDo; }
            set { _lyDo = value; }
        }
        /*
        public ThongBao_DTO(string matb, string loaitb, string lydo)
        {
            MaTB = matb;
            LoaiTB = loaitb;
            LyDo = lydo;
        }
         */
    }
}
