using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class Ly_Lich
    {
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string QueQuan { get; set; }
        public string DiaChiThuongTru { get; set; }
        public string DiaChiTamTru { get; set; }
        public string SDT { get; set; }
        public string CMND { get; set; }
        public string Tinhhinhsuckhoe { get; set; }
        public string TenTK { get; set; }
        public string MaDN { get; set; }
        public Ly_Lich() 
        {
 
        }
        public Ly_Lich(string macanhan,string tencanhan,string quequan,string diachithuongtru,string diachitamtru,string sdt,string cmnd,string suckhoe,string tentk,string madn) 
        {
            Ma = macanhan;
            Ten = tencanhan;
            QueQuan = quequan;
            DiaChiThuongTru = diachithuongtru;
            DiaChiTamTru = diachitamtru;
            SDT = sdt;
            CMND = cmnd;
            Tinhhinhsuckhoe = suckhoe;
            TenTK = tentk;
            MaDN = madn;
        }
    }
}
