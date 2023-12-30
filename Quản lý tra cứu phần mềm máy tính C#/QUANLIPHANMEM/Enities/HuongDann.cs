using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enities
{
    public class HuongDann
    {
        public string MaHD{get;set;}
        public string MaPhanMem{get;set;}
        public string HuongDan { get; set; }
        public HuongDann(){}
        public HuongDann(string mahd,string maphanmem,string huongdan)
        {
            MaHD = mahd;
            MaPhanMem = maphanmem;
            HuongDan = huongdan;
        }
    }
}
