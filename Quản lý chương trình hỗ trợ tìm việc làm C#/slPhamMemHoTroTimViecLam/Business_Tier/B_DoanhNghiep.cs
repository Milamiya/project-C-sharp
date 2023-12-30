using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Entities;
using Data_Tier;

namespace Business_Tier
{
    public class B_DoanhNghiep
    {
        D_DoanhNghiep DN = new D_DoanhNghiep();
        D_NganhNghe objNN = new D_NganhNghe();
        public DataTable gettbdoanhnghieptheomanganhnghe(string manganhnghe) { 
            return DN.getDoanhNghiep_theo_maNganhNghe(manganhnghe).Tables["DoanhNghiep"];
        }
        public DataTable gettbdoanhnghieptheomadoanhnghiep(string madn) { 
            return DN.getDoanhNghiep_theo_maDoanhNghiep(madn).Tables["DoanhNghiep"];
        }
        public DataTable getDoanhNghiep_TheoDiaDiem(string diadiem)
        {
            return DN.getDoanhNghiep_theo_DiaDiem(diadiem).Tables["DoanhNghiep"];
        }
        public DataTable getAllDoanhNghiep()
        {
            return DN.getAllTable("DoanhNghiep").Tables["DoanhNghiep"];
        }
        public DataTable getEmail_TheoMaDN(string ma)
        {
            return DN.getEmail_TheoMaDN(ma).Tables["doanhnghiep"];
        }
        public DataTable getMa_TheoEmail(string email)
        {
            return DN.getMa_TheoEmail(email).Tables["doanhnghiep"];
        }
        public DataTable getTenNN_TheoMaNN(string ma)
        {
            return objNN.getTenNN_TheoMaNN(ma).Tables["nganhnghe"];
        }
        public int ThemDoanhNghiep(Doanh_Nghiep dn)
        {
            return DN.ThemDoanhNghiep(dn);
        }
        public int XoaDoanhNghiep(string ma)
        {
            return DN.XoaDoanhNghiep(ma);
        }
        public int CapNhatDoanhNghiep(Doanh_Nghiep dn)
        {
            return DN.CapNhatDoanhNghiep(dn);
        }
    }
}
