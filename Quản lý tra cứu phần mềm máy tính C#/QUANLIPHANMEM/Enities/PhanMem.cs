using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enities
{
    public class PhanMem
    {
        public string MaphanMem { get; set; }
        public string TenPhanMem { get; set; }
        public string HeDieuHanh { get; set; }
        public string LinkDown { get; set; }
        public string MaPL { get; set; }


        public PhanMem() { }
      
        public PhanMem(string mapm, string tenpm, string hedieuhanh, string linkdown, string mapl)
        {
            MaphanMem = mapm;
            TenPhanMem = tenpm;
            HeDieuHanh = hedieuhanh;
            LinkDown = linkdown;
            MaPL = mapl;

        }

    }
}