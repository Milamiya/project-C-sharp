using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.Generic;

namespace SLCaroGame.Thaotac
{
    public enum Kieuchienthang
    {
        Tutrenxuong, Tuduoilen, Theochieungang, Theochieudoc
    }
    public class KQthang
    {
        public List<Quanco> ds;
        public Kieuchienthang Kieu;
        public Kieuquan kieuquan;

        public KQthang()
        {
            ds = new List<Quanco>();
        }
    }
}
