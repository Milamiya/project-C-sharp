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
using SLCaroGame.Thaotac;
using SLCaroGame.Giaodien;

namespace SLCaroGame.Giaodien
{
    public class ModeSelectPanelMediator:Mediator
    {
        public new const string NAME = "ModeSelectPanelMediator";

        public Chedochon ModeSelectPanel
        {
            get
            {
                return ViewComponent as Chedochon;
            }
        }

        public ModeSelectPanelMediator(object viewComponent)
            : base(NAME, viewComponent)
        {
            ModeSelectPanel.PVPButtonClick += ModeSelectPanel_PVPButtonClick;
            ModeSelectPanel.PVEButtonClick += ModeSelectPanel_PVEButtonClick;
            ModeSelectPanel.EVPButtonClick += ModeSelectPanel_EVPButtonClick;
        }

        void ModeSelectPanel_EVPButtonClick(object sender, RoutedEventArgs e)
        {
            SendNotification(Thongbao.may_nguoi);
        }

        void ModeSelectPanel_PVEButtonClick(object sender, RoutedEventArgs e)
        {
            SendNotification(Thongbao.nguoi_may);
        }

        void ModeSelectPanel_PVPButtonClick(object sender, RoutedEventArgs e)
        {
            SendNotification(Thongbao.nguoi_nguoi);
        }
    }
}
