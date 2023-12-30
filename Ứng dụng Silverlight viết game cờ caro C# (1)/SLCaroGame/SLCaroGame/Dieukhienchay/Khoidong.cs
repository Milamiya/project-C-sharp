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
using SLCaroGame.Giaodien.Anh;

namespace SLCaroGame.Dieukhienchay
{
    public class Khoidong : SimpleCommand
    {
        public override void Execute(INotification notification)
        {
            Facade.RegisterProxy(new Thaotacvoiform());
            Facade.RegisterProxy(new Kiemtrabanco());
            Facade.RegisterMediator(new ApplicationMediator(notification.Body));
        }
    }
}
