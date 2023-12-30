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
    public class Batdaugame:SimpleCommand
    {
        public override void Execute(INotification notification)
        {
            var applicationProxy = Facade.RetrieveProxy(Thaotacvoiform.ten) as Thaotacvoiform;
            var pieceboardProxy = Facade.RetrieveProxy(Kiemtrabanco.ten) as Kiemtrabanco;
            var pieceboardMediator = Facade.RetrieveMediator(PieceboardMediator.ten) as PieceboardMediator;
            var applicationMediator = Facade.RetrieveMediator(ApplicationMediator.ten) as ApplicationMediator;
            applicationProxy.Ganbien();
            pieceboardProxy.Xoaquan();
            pieceboardMediator.InitPieceBoard();
            applicationMediator.Anbangthongbao();
            if (!Khaibaobien.nguoi && Khaibaobien.may)
                pieceboardMediator.Maychoi();
        }
    }
}
