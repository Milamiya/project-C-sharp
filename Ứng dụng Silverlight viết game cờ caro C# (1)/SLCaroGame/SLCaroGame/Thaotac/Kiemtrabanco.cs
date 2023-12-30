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
namespace SLCaroGame.Thaotac
{
    public class Kiemtrabanco:Proxy
    {
        public new const string ten = "PieceboardProxy";

        public Quanco[,] quan;

        private List<KQthang> dskq;

        public Kiemtrabanco()
            : base(ten)
        {
            quan = new Quanco[Khaibaobien.dodai, Khaibaobien.dodai];
            dskq = new List<KQthang>();
        }

        public bool Kiemtraotrong(Quanco q)
        {
            if (quan[q.X, q.Y] == null)
                return true;

            SendNotification(Thongbao.vitrikhongdung);
            return false;

        }

        public void Chenquanco(Quanco q)
        {
            if (Kiemtraotrong(q))
            {
                SendNotification(Thongbao.quancoduocchenvaobang, q);
            }
        }

        public void Kiemtranguoithang(Quanco q)
        {
            dskq.Clear();

            quan[q.X, q.Y] = q;

            if (Kiemtrathuattoan(q.X - 4, q.Y - 4, 1, 1, 9, q.kieu)
                || Kiemtrathuattoan(q.X - 4, q.Y, 1, 0, 9, q.kieu)
                || Kiemtrathuattoan(q.X, q.Y - 4, 0, 1, 9, q.kieu)
                || Kiemtrathuattoan(q.X - 4, q.Y + 4, 1, -1, 9, q.kieu))
            {
                SendNotification(Thongbao.nguoithang, dskq);
            }
            else
            {
                SendNotification(Thongbao.tieptuc);
            }
        }

        private bool Kiemtrathuattoan(int batdauX, int batdauY, int buocX, int buocY, int tongsobuocdi, Kieuquan kieu)
        {
            KQthang kq = new KQthang();

            List<Quanco> ds = new List<Quanco>();

            for (int i = 0; i < tongsobuocdi; i++)
            {
                int x = batdauX + buocX * i;
                int y = batdauY + buocY * i;

                if (x >= 0 && y >= 0 && x < Khaibaobien.dodai && y < Khaibaobien.dodai)
                {
                    if (quan[batdauX + buocX * i, batdauY + buocY * i] != null &&
                        quan[batdauX + buocX * i, batdauY + buocY * i].kieu == kieu)
                        ds.Add(quan[batdauX + buocX * i, batdauY + buocY * i]);
                    else
                        ds.Clear();

                    if (ds.Count >= 5)
                    {
                        kq.ds = ds;
                        kq.kieuquan = kieu;

                        if (buocX == 1 && buocY == 1)
                            kq.Kieu = Kieuchienthang.Tutrenxuong;
                        if (buocX == 1 && buocY == 0)
                            kq.Kieu = Kieuchienthang.Theochieungang;
                        if (buocX == 0 && buocY == 1)
                            kq.Kieu = Kieuchienthang.Theochieudoc;
                        if (buocX == 1 && buocY == -1)
                            kq.Kieu = Kieuchienthang.Tuduoilen;

                        dskq.Add(kq);
                        return true;
                    }
                }
            }
            return false;
        }

        public void Xoaquan()
        {
            quan = new Quanco[Khaibaobien.dodai, Khaibaobien.dodai];
        }
    }
}
