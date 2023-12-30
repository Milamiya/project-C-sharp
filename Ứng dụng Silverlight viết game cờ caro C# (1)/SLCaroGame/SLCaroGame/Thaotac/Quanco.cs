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
using SLCaroGame.Giaodien;

namespace SLCaroGame.Thaotac
{
    public class Quanco
    {
        private UserControl hinhdang;
        private Vitri vitri;

        public int X
        {
            get { return vitri.X; }
            set { vitri.X = value; }
        }

        public int Y
        {
            get { return vitri.Y; }
            set { vitri.Y = value; }
        }

        public Vitri Vitri
        {
            get { return vitri; }
            set { vitri = value; }
        }

        public Kieuquan kieu { get; set; }

        public Quanco()
        {
            vitri = new Vitri();
        }

        public UserControl Hinhdang
        {
            get
            {
                if (hinhdang == null)
                {
                    if (kieu == Kieuquan.QuanX)
                        hinhdang = new QuanX();
                    if (kieu == Kieuquan.QuanO)
                        hinhdang = new QuanO();
                }
                return hinhdang;
            }
        }
    }
}
