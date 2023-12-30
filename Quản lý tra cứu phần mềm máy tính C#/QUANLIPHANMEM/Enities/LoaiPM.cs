using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enities
{
  public  class LoaiPM
    {    public string MaPL{ get; set; }
        public string TenLoaiPM { get; set; }
        public string MaCD { get; set; }
        public LoaiPM() { }
        public LoaiPM(string mapl, string tenloaipm,string macd)
        {
            MaPL = mapl;
            TenLoaiPM = tenloaipm;
            MaCD = macd;
        }
    }
}
