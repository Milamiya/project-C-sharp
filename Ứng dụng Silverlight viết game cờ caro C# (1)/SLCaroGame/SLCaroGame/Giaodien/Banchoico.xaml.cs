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
    public partial class Banchoico : UserControl
    {
        public delegate void PieceboardClickHandler(object sender, Point point);

        public delegate void PieceboardGridMouseEnterHandler(object sender, MouseEventArgs e);

        public delegate void PieceboardGridMouseLeaveHandler(object sender, MouseEventArgs e);

        public delegate void PieceboardGridMouseMoveHandler(object sender, MouseEventArgs e);

        public event PieceboardClickHandler PieceboardClick;
        public event PieceboardGridMouseEnterHandler PieceboardGridMouseEnter;
        public event PieceboardGridMouseLeaveHandler PieceboardGridMouseLeave;
        public event PieceboardGridMouseMoveHandler PieceboardGridMouseMove;

        public Banchoico()
        {
            InitializeComponent();
            PieceboardGrid.MouseLeftButtonUp += new MouseButtonEventHandler(PieceboardGrid_MouseLeftButtonUp);
            PieceboardGrid.MouseMove += new MouseEventHandler(PieceboardGrid_MouseMove);
            PieceboardGrid.MouseEnter += new MouseEventHandler(PieceboardGrid_MouseEnter);
            PieceboardGrid.MouseLeave += new MouseEventHandler(PieceboardGrid_MouseLeave);
            PieceboardGrid.Cursor = Cursors.None;
        }

        void PieceboardGrid_MouseLeave(object sender, MouseEventArgs e)
        {
            PieceboardGridMouseLeave(sender, e);
        }

        void PieceboardGrid_MouseEnter(object sender, MouseEventArgs e)
        {
            PieceboardGridMouseEnter(sender, e);
        }

        void PieceboardGrid_MouseMove(object sender, MouseEventArgs e)
        {
            PieceboardGridMouseMove(sender, e);
        }

        void PieceboardGrid_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Point point = e.GetPosition(sender as Canvas);
            PieceboardClick(this, point);
            PieceboardGrid.CaptureMouse();
        }

    }
}
