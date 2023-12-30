using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
   public class Doanh_Nghiep
    {
       public string Ma { get; set; }
       public string Ten { get; set; }
       public string DiaChi { get; set; }
       public string SDT { get; set; }
       public string Email  { get; set; }
       public string ChuDN { get; set; }
       public string MaNganhNghe { get; set; }
       public Doanh_Nghiep() { }
       public Doanh_Nghiep(string madn,string tendn,string diachi,string sdt,string email,string chudn,string manganhnghe) {
           Ma = madn;
           Ten = tendn;
           DiaChi = diachi;
           SDT = sdt;
           Email = email;
           ChuDN = chudn;
           MaNganhNghe = manganhnghe;
       }
    }
}
