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
using PureMVC.Interfaces;
using PureMVC.Patterns;
using SLCaroGame.Thaotac;
using System.Collections.Generic;
//using SLCaroGame.Thaotac;

namespace SLCaroGame.Giaodien
{
    public class PieceboardMediator:Mediator
    {
        public new const string ten = "PieceboardMediator";
        private Kiemtrabanco kiemtra;
        private Thaotacvoiform thaotac;
        private bool laquanX = true;
        private UIElement quancohientai;
        private bool click;

        public bool Clickable
        {
            set
            {
                click = value;
            }
        }

        public Banchoico PieceboardComponent
        {
            get { return ViewComponent as Banchoico; }
        }

        public override IList<string> ListNotificationInterests()
        {
            return new List<string>(new[]
                                        {
                                            Thongbao.quancoduocchenvaobang,
                                            Thongbao.kiemtra_nguoithang,
                                            Thongbao.nguoithang,
                                            Thongbao.tieptuc,
                                            Thongbao.vitrikhongdung
                                        });
        }

        public PieceboardMediator(object viewComponent)
            : base(ten, viewComponent)
        {
            kiemtra = Facade.RetrieveProxy(Kiemtrabanco.ten) as Kiemtrabanco;
            thaotac = Facade.RetrieveProxy(Thaotacvoiform.ten) as Thaotacvoiform;

            PieceboardComponent.PieceboardClick += Pieceboard_Click;

            var pieceGrid = new Grid();
            pieceGrid.Name = "PieceGrid";
            PieceboardComponent.PieceboardGrid.Children.Add(pieceGrid);

            Ganquancochochuot();

            PieceboardComponent.PieceboardGridMouseMove += PieceboardComponent_PieceboardGridMouseMove;
            PieceboardComponent.PieceboardGridMouseEnter += PieceboardComponent_PieceboardGridMouseEnter;
            PieceboardComponent.PieceboardGridMouseLeave += PieceboardComponent_PieceboardGridMouseLeave;

        }

        void PieceboardComponent_PieceboardGridMouseLeave(object sender, MouseEventArgs e)
        {
            quancohientai.Visibility = Visibility.Collapsed;
        }

        void PieceboardComponent_PieceboardGridMouseEnter(object sender, MouseEventArgs e)
        {
            quancohientai.Visibility = Visibility.Visible;
        }

        void PieceboardComponent_PieceboardGridMouseMove(object sender, MouseEventArgs e)
        {
            if (!PieceboardComponent.CursorContainer.Children.Contains(quancohientai))
                PieceboardComponent.CursorContainer.Children.Add(quancohientai);

            quancohientai.SetValue(Canvas.LeftProperty,
                                   e.GetPosition((UIElement)sender).X - quancohientai.RenderSize.Width / 2);
            quancohientai.SetValue(Canvas.TopProperty,
                                   e.GetPosition((UIElement)sender).Y - quancohientai.RenderSize.Height / 2);
        }

        public override void HandleNotification(INotification notification)
        {
            switch (notification.Name)
            {
                case Thongbao.quancoduocchenvaobang:
                    var piece = (Quanco)notification.Body;
                    Chenquancotoiban(piece);
                    break;

                case Thongbao.kiemtra_nguoithang:
                    var kiemtraquan = (Quanco)notification.Body;
                    kiemtra.Kiemtranguoithang(kiemtraquan);
                    break;

                case Thongbao.nguoithang:
                    Danhdauco((List<KQthang>)notification.Body);
                    click = false;
                    break;

                case Thongbao.tieptuc:

                    if (Khaibaobien.may)
                    {
                        if (thaotac.nguoi)
                        {
                            thaotac.nguoi = false;
                            Maychoi();
                        }
                        else
                        {
                            thaotac.nguoi = true;
                            click = true;
                        }
                    }
                    else
                    {
                        click = true;
                    }
                    break;

                case Thongbao.vitrikhongdung:
                    click = true;
                    break;
            }
        }

        private void Chenquancotoiban(Quanco piece)
        {
            var point = new Point(piece.X * 30 - 9, piece.Y * 30 - 9);

            piece.Hinhdang.SetValue(Canvas.LeftProperty, point.X);
            piece.Hinhdang.SetValue(Canvas.TopProperty, point.Y);          
            PieceboardComponent.PieceContainer.Children.Add(piece.Hinhdang);

            laquanX= piece.kieu != Kieuquan.QuanX;

            PieceboardComponent.CursorContainer.Children.Remove(quancohientai);
            Ganquancochochuot();

            SendNotification(Thongbao.kiemtra_nguoithang, piece);
        }

        private void Danhdauco(List<KQthang> kq)
        {
            foreach (var item in kq)
            {
                foreach (var co in item.ds)
                {
                    if (co.kieu == Kieuquan.QuanX)
                    {
                        ((QuanX)co.Hinhdang).Nhapnhay.RepeatBehavior = RepeatBehavior.Forever;
                        ((QuanX)co.Hinhdang).Nhapnhay.Begin();
                    }
                    else
                    {
                        ((QuanO)co.Hinhdang).Nhapnhay.RepeatBehavior = RepeatBehavior.Forever;
                        ((QuanO)co.Hinhdang).Nhapnhay.Begin();
                    }
                }
            }


        }

        protected void Pieceboard_Click(object sender, Point diem)
        {
            if (click && thaotac.nguoi)
            {
                click = false;
                var x = (int)(diem.X / 30);
                var y = (int)(diem.Y / 30);
                if ((diem.X % 30 > 10 && diem.X % 30 < 20) || diem.Y % 30 > 10 && diem.Y % 30 < 20)
                {
                    SendNotification(Thongbao.vitrikhongdung);
                    return;
                }

                if (diem.Y % 30 > 20)
                    y++;
                if (diem.X % 30 > 20)
                    x++;

                var quanmoi = new Quanco
                {
                    X = x,
                    Y = y,
                    kieu = (laquanX ? Kieuquan.QuanX : Kieuquan.QuanO)
                };

                kiemtra.Chenquanco(quanmoi);
            }
                //Chenquancotoiban(quanmoi);
        }

        public void Ganquancochochuot()
        {
            if (laquanX)
                quancohientai = new QuanX();
            else
                quancohientai = new QuanO();
        }

        public void Maychoi()
        {
            int m = 0, n = 0;
            int err = 0;

            int[,] banco = new int[Khaibaobien.dodai, Khaibaobien.dodai];

            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    if (kiemtra.quan[i, j] == null)
                        banco[i, j] = -1;
                    else
                        banco[i, j] = kiemtra.quan[i, j].kieu == Kieuquan.QuanX ? 0 : 1;
                }
            }

            do
            {
                AI.GetInstance().Danh(banco);
                m = AI.GetInstance().X;
                n = AI.GetInstance().Y;
                err++;
                if (err > 100)
                {
                    SendNotification(Thongbao.batdaugame);
                    return;
                }
            } while (Luatchoi.Exit(m, n, banco));

            Quanco q = new Quanco();
            q.X = m;
            q.Y = n;
            q.kieu = (laquanX ? Kieuquan.QuanX : Kieuquan.QuanO);

            kiemtra.Chenquanco(q);
        }

        public void InitPieceBoard()
        {
            laquanX= true;
            if (Khaibaobien.nguoi || !Khaibaobien.may)
                click = true;
            Ganquancochochuot();
            PieceboardComponent.PieceContainer.Children.Clear();            
        }
    }
}
