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
using PureMVC.Interfaces;
using PureMVC.Patterns;
using SLCaroGame.Giaodien;
using SLCaroGame.Thaotac;
namespace SLCaroGame.Giaodien
{
    public class RestartPanelMediator:Mediator
    {
        public new const string NAME = "RestartPanelMediator";

        public Khoidonglai RestartPanel
        {
            get
            {
                return ViewComponent as Khoidonglai;
            }
        }

        public RestartPanelMediator(object viewComponent)
            : base(NAME, viewComponent)
        {
            RestartPanel.RestartClick += RestartPanel_RestartClick;
        }

        void RestartPanel_RestartClick(object sender, RoutedEventArgs e)
        {
            SendNotification(Thongbao.khoidonglai);
        }

        public override IList<string> ListNotificationInterests()
        {
            return new List<string>(new[]
                                        {
                                            Thongbao.nguoithang
                                        }
                );
        }

        public override void HandleNotification(INotification thongbao)
        {
            switch (thongbao.Name)
            {
                case Thongbao.nguoithang:

                    var type = ((List<KQthang>)thongbao.Body)[0].kieuquan;
                    RestartPanel.MessageTextBlock.Text = type + " thắng. Chúc mừng nhé!";
                    break;
            }
        }
    }
}
