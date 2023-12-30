using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace SLCaroGame
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
            
            ApplicationFacade.Instance.Startup(this);
            StartSelectModeButton.Click += new RoutedEventHandler(StartSelectModeButton_Click);
        }
        public EventHandler<RoutedEventArgs> StartModeSelectClick;
        void StartSelectModeButton_Click(object sender, RoutedEventArgs e)
        {
            StartModeSelectClick(sender, e);    
        }
    }
}
