using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace Chess_Usercontrol
{
    public partial class UcChessCell : UserControl
    {
        #region "Khai báo biến  toàn cục"
        int _PositionX, _PositionY;
        Bitmap _BackImage;
        UcChessPiece _ChessPiece;
        ChessSide _Side;
        ChessBoardStyle _BoardStyle;



        #endregion

        public UcChessCell(int PositionX, int PositionY, ChessSide Side, ChessBoardStyle Style)
        {
            InitializeComponent();

            this._PositionX = PositionX;
            this._PositionY = PositionY;
            this._Side = Side;
            this._BoardStyle = Style;
            this._BackImage = clsImageProcess.GetChessBoardBitMap(Side, Style);
            this.BackImage = _BackImage;

        }
        public UcChessCell(int PositionX, int PositionY, Bitmap BackImage, ChessSide Side, ChessBoardStyle Style)
        {
            InitializeComponent();
            this._PositionX = PositionX;
            this._PositionY = PositionY;
            this._Side = Side;
            this._BoardStyle = Style;
            this._BackImage = BackImage;
        }

        public UcChessCell()
        {
            InitializeComponent();
        }


        public int PositionX
        {
            get
            {
                return this._PositionX;
            }
            set
            {
                this.PositionX = value;
            }
        }

        public int PositionY
        {
            get
            {
                return this._PositionY;
            }
            set
            {
                this.PositionY = value;
            }
        }

        public Bitmap BackImage
        {
            get
            {
                return this._BackImage;
            }
            set
            {
                this._BackImage = value;
                this.UpdateStyles();
            }
        }
        public void HighlightPossibleMove()
        {
            this.BackImage = clsImageProcess.GetChessBoardBitMap(this._Side, this._BoardStyle, "Possible");

        }
        public void UnHighlightMove()
        {
            this.BackImage = clsImageProcess.GetChessBoardBitMap(this._Side, this._BoardStyle);
        }
        public void ShowLastMove()
        {
            this.BackImage = clsImageProcess.GetChessBoardBitMap(this._Side, this._BoardStyle,"Last");
        }

        public UcChessPiece ChessPiece
        {
            get
            {
                return this._ChessPiece;
            }
            set
            {
                if (value != null)
                {
                    this._ChessPiece = value;
                    int x = (int)(this.Size.Width - this._ChessPiece.Width) / 2;
                    int y = (int)(this.Size.Height - this._ChessPiece.Height) / 2;
                    if (UcChessBoard.IsCapturedMode == true)
                    {
                        this._ChessPiece.Location = new Point( x,y);
                        this.Controls.Add(this._ChessPiece);    
                    }
                    else
                    {
                        this._ChessPiece.Location = new Point(this.Location.X + x, this.Location.Y + y);
                        this.Parent.Controls.Add(this._ChessPiece);                       
                    }
                    this._ChessPiece.BringToFront();
                }
                else
                {
                    this._ChessPiece = null;
                }
            }
        }


        private void UcChessCell_Load(object sender, EventArgs e)
        {

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);            
            
            
            this.UpdateStyles();


        }

        private void UcChessCell_Click(object sender, EventArgs e)
        {
           
        }

      
        private void UcChessCell_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //g.DrawImage(_BackImage ,0,0,Width ,Height );
            g.DrawImage(_BackImage, new Rectangle(0, 0, this.Width, this.Height), new Rectangle(this._PositionY *5,this._PositionX *5, this.Width, this.Height), GraphicsUnit.Pixel);
            
        }

    }
}
