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
using SLCaroGame.Dieukhienchay;
using SLCaroGame.Thaotac;

namespace SLCaroGame.Dieukhienchay
{
    public class Restart:SimpleCommand
    {
        public override void Execute(INotification notification)
        {
            var pieceboardProxy = Facade.RetrieveProxy(Kiemtrabanco.ten) as Kiemtrabanco;
            if (pieceboardProxy != null)
            {
                pieceboardProxy.Xoaquan();                
            }
        }
    }
}
