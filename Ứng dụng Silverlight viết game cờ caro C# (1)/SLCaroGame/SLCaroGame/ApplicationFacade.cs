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

namespace SLCaroGame
{
    public class ApplicationFacade:Facade
    {
        public new static ApplicationFacade Instance
        {
            get
            {
                if (m_instance == null)
                    m_instance = new ApplicationFacade();

                return m_instance as ApplicationFacade;
            }
        }

        public void Startup(object app)
        {
            NotifyObservers(new Notification(Thongbao.khoidong, app));
        }

        static ApplicationFacade() { }

        protected override void InitializeController()
        {
            base.InitializeController();
            RegisterCommand(Thongbao.khoidong, typeof(Khoidong));
            RegisterCommand(Thongbao.khoidonglai, typeof(Restart));
            RegisterCommand(Thongbao.batdaugame, typeof(Batdaugame));
            RegisterCommand(Thongbao.chonchedo, typeof(Chonchedo));
        }

    }
}
