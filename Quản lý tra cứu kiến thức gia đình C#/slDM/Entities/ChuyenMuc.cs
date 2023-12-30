using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class ChuyenMuc
    {
        public string Machuyenmuc { get; set; }
        public string Tenchuyenmuc { get; set; }

        public ChuyenMuc()
        { }

        public ChuyenMuc(string macm ,string tencm)
        {
            Machuyenmuc = macm;
            Tenchuyenmuc = tencm;
        }
    }
}
