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
using PureMVC.Interfaces;
using SLCaroGame.Thaotac;
using System.Collections.Generic;
namespace SLCaroGame.Giaodien.Anh
{
    public class ApplicationMediator:Mediator
    {
         public new const string ten = "ApplicationMediator";

        private Kiemtrabanco _pieceboardProxy;
        private Thaotacvoiform _applicationProxy;

        public MainPage Application
        {
            get
            {
                return ViewComponent as MainPage;
            }
        }
       
        public ApplicationMediator(object viewComponent)
            : base(ten, viewComponent)
        {
            Facade.RegisterMediator(new PieceboardMediator(Application.Pieceboard));
            Facade.RegisterMediator(new RestartPanelMediator(Application.RestartPanel));
            Facade.RegisterMediator(new ModeSelectPanelMediator(Application.ModeSelectPanel));

            _pieceboardProxy = Facade.RetrieveProxy(Kiemtrabanco.ten) as Kiemtrabanco;
            _applicationProxy = Facade.RetrieveProxy(Thaotacvoiform.ten) as Thaotacvoiform;

            Capnhattyso();

            Application.Shadow.Wind.RepeatBehavior = RepeatBehavior.Forever;
            Application.Shadow.Wind.Begin();

            Application.StartModeSelectClick += StartSelectModel_ButtonClick;

        }
     
         void StartSelectModel_ButtonClick(object sender, RoutedEventArgs e)
         {
             SendNotification(Thongbao.chonchedo);
         }
     
        public override IList<string> ListNotificationInterests()
        {
            return new List<string>(new[]
                                        {
                                            Thongbao.chenquan,
                                            Thongbao.nguoithang,
                                            Thongbao.khoidonglai,
                                            Thongbao.nguoi_nguoi,
                                            Thongbao.nguoi_may,
                                            Thongbao.may_nguoi
                                        });
            
        }
       
        public override void HandleNotification(INotification notification)
        {
            switch (notification.Name)
            {
                case Thongbao.chenquan:

                    _pieceboardProxy.Chenquanco(notification.Body as Quanco);
                    break;

                case Thongbao.nguoithang:

                    var type = ((List<KQthang>) notification.Body)[0].kieuquan;
                    _applicationProxy.Capnhattyso(type);
                    Application.RestartPanel.Visibility = Visibility.Visible;
                    Application.RestartPanel.FadeIn.Begin();
                    Capnhattyso();

                    break;

                case Thongbao.khoidonglai:
                    Application.RestartPanel.FadeOut.Begin();
                    _applicationProxy.Lammoityso();
                    SendNotification(Thongbao.batdaugame);
                    break;

                case Thongbao.nguoi_nguoi:
                    _applicationProxy.Lammoityso();
                    Capnhattyso();
                    Khaibaobien.nguoi = true;
                    Khaibaobien.may = false;
                    Application.ModeSelectPanel.Visibility = Visibility.Collapsed;
                    SendNotification(Thongbao.batdaugame);
                    break;

                case Thongbao.may_nguoi:
                    _applicationProxy.Lammoityso();
                    Capnhattyso();                    
                    Khaibaobien.may = true;
                    Khaibaobien.nguoi = false;
                    Application.ModeSelectPanel.Visibility = Visibility.Collapsed;
                    SendNotification(Thongbao.batdaugame);
                    break;

                case Thongbao.nguoi_may:
                    _applicationProxy.Lammoityso();
                    Capnhattyso();
                    Khaibaobien.nguoi = true;
                    Khaibaobien.may = true;
                    Application.ModeSelectPanel.Visibility = Visibility.Collapsed;
                    SendNotification(Thongbao.batdaugame);
                    break;
            }
        }
     
        private void Capnhattyso()
        {
            Application.StasticsPanel.textblockO.Text = _applicationProxy.SolanquanOthang.ToString();
            Application.StasticsPanel.textblockX.Text = _applicationProxy.SolanquanXthang.ToString();
            
        }
     
        public void Anbangthongbao()
        {
            Application.RestartPanel.Visibility = Visibility.Collapsed;
            Application.ModeSelectPanel.Visibility = Visibility.Collapsed;
        }
    }
}
