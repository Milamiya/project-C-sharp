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

namespace SLCaroGame.Giaodien
{
    public partial class Chedochon : UserControl
    {
        public delegate void PVPButtonClickHandler(object sender, RoutedEventArgs e);

        public delegate void PVEButtonClickHandler(object sender, RoutedEventArgs e);

        public delegate void EVPButtonClickHandler(object sender, RoutedEventArgs e);

        public event PVPButtonClickHandler PVPButtonClick;
        public event PVEButtonClickHandler PVEButtonClick;
        public event EVPButtonClickHandler EVPButtonClick;

        public Chedochon()
        {
            InitializeComponent();
            PVPButton.Click += PVPButton_Click;
            PVEButton.Click += PVEButton_Click;
            EVPButton.Click += EVPButton_Click;
        }

        void EVPButton_Click(object sender, RoutedEventArgs e)
        {
            EVPButtonClick(sender, e);
        }

        void PVEButton_Click(object sender, RoutedEventArgs e)
        {
            PVEButtonClick(sender, e);
        }

        void PVPButton_Click(object sender, RoutedEventArgs e)
        {
            PVPButtonClick(sender, e);
        }

       
    }
}
