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
using PureMVC.Patterns;
using System.Collections.Generic;
using SLCaroGame.Giaodien;
namespace SLCaroGame.Thaotac
{
    public class Thaotacvoiform : Proxy
    {

        public new static string ten = "ApplicationProxy";
        public bool nguoi;
        public bool may;
        private Dictionary<string, int> thongke;
        public Thaotacvoiform()
            : base(ten)
        {
            thongke = new Dictionary<string, int>
                            {
                                {"QuanXthang", 0},
                                {"QuanOthang", 0},                               
                                {"Tongcong", 0}
                            };
        }


        public void Ganbien()
        {
            nguoi = Khaibaobien.nguoi;
            may = Khaibaobien.may;
        }

        public void Capnhattyso(Kieuquan kieu)
        {
            if (kieu == Kieuquan.QuanX)
                thongke["QuanXthang"]++;

            if (kieu == Kieuquan.QuanO)
                thongke["QuanOthang"]++;
        }

        public void Lammoityso()
        {
            thongke["Xthang"] = 0;
            thongke["QuanOthang"] = 0;
        }

        public int SolanquanXthang
        {
            get { return thongke["QuanXthang"]; }
        }

        public int SolanquanOthang
        {
            get { return thongke["QuanOthang"]; }
        }
    }
}
