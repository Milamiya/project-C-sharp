using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class Nganh_Nghe
    {
        public string MaNganhNghe { get; set; }
        public string TenNganhNghe { get; set; }
        public Nganh_Nghe() { }
        public Nganh_Nghe(string manghe, string tennghe) {
            MaNganhNghe = manghe;
            TenNganhNghe = tennghe;
        }
    }
}
