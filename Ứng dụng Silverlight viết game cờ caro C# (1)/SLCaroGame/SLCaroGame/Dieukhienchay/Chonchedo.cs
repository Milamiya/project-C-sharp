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
using SLCaroGame.Giaodien;
using SLCaroGame.Giaodien.Anh;
using SLCaroGame.Thaotac;
namespace SLCaroGame.Dieukhienchay
{
    public class Chonchedo:SimpleCommand
    {
         public override void Execute(INotification notification)
        {
            var applicationMediator = Facade.RetrieveMediator(ApplicationMediator.ten) as ApplicationMediator;
            applicationMediator.Application.ModeSelectPanel.Visibility = Visibility.Visible;
            applicationMediator.Application.RestartPanel.Visibility = Visibility.Collapsed;

            var applicationProxy = Facade.RetrieveProxy(Thaotacvoiform.ten) as Thaotacvoiform;
            applicationProxy.Lammoityso();

            var pieceboardMediator = Facade.RetrieveMediator(PieceboardMediator.ten) as PieceboardMediator;
            pieceboardMediator.Clickable = false;
        }
    }
}
