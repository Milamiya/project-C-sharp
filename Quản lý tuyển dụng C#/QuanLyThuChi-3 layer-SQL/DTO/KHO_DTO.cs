using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KHO_DTO
    {
        private string _maKho;

        public string MaKho
        {
            get { return _maKho; }
            set { _maKho = value; }
        }
        private string _tenKho;

        public string TenKho
        {
            get { return _tenKho; }
            set { _tenKho = value; }
        }
        private string _diaDiem;

        public string DiaDiem
        {
            get { return _diaDiem; }
            set { _diaDiem = value; }
        }

    }
}
