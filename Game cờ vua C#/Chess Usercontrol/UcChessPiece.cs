using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Collections;
using System.Media;
using System.Threading;
namespace Chess_Usercontrol
{

  
    public partial class UcChessPiece : UserControl
    {
        #region "Khai báo biến Toàn Cục"
        /*
         * Khai Báo Biến Toàn Cục
         */

        ChessSide _Side;
        ChessPieceType _Type;
        ChessPieceStyle _Style;
        
        int _PositionX, _PositionY;//Xem quân cờ đang nằm ở ô nào
        int _CellSize;
        int _PieceSize;

        Bitmap _image;
        Point CurrentMousePos, LastMousePos;
        UcChessCell _ucOnCell;       

        #endregion
        #region "Khai báo các Property"
        /// <summary>
        /// Phe trắng hoặc đen
        /// </summary>
        public ChessSide Side
        {
            get
            {
                return this._Side;
            }
            set
            {
                this._Side = value;
            }
        }

        /// <summary>
        /// Loại quân cờ (Tốt, Tượng, Mã, Xe, Hậu, Vua)
        /// </summary>
        public ChessPieceType Type
        {
            get
            {
                return this._Type;
            }
            set
            {
                this._Type = value;
            }
        }

        /// <summary>
        /// Style của quân cờ
        /// </summary>
        public ChessPieceStyle Style
        {
            get
            {
                return this._Style;
            }
            set
            {
                this._Style = value;
            }
        }

        /// <summary>
        /// Hình ảnh của quân cờ
        /// </summary>
        public Bitmap Image
        {
            get
            {
                return this._image;
            }
            set
            {
                this._image = value;
                Image.GetThumbnailImageAbort callback = null;
                IntPtr callbackdata = new IntPtr();
                this._image = (Bitmap)_image.GetThumbnailImage(_PieceSize, _PieceSize, callback, callbackdata);                
                this.UpdateStyles();
            }
        }

        /// <summary>
        /// Tọa độ quân cờ trên bàn cờ theo chiều ngang
        /// </summary>
        public int PositionX
        {
            get
            {
                return this._PositionX;
            }
            set
            {
                this._PositionX = value;
            }
        }
        /// <summary>
        /// Tọa độ quân cờ trên bàn cờ theo chiều dọc
        /// </summary>
        public int PositionY
        {
            get
            {
                return this._PositionY;
            }
            set
            {
                this._PositionY = value;
            }
        }
        /// <summary>
        /// Chiều dài cạnh của quân cờ
        /// </summary>
        public int PieceSize
        {
            get
            {
                return this._PieceSize;
            }
            set
            {
                this._PieceSize = value;
            }

        }
        public int CellSize
        {
            get
            {
                return this._CellSize;
            }
            set
            {
                this._CellSize = value;
            }

        }

        public UcChessCell UConCell
        {
            get { return _ucOnCell; }
            set
            {
                this._ucOnCell = value;
            }
        }

        #endregion


        /// <param name="intSide">Đen: 1, Trắng: 2</param>
        /// <param name="intType">Tốt: 1, Tượng: 2, Mã: 3, Xe: 4, Hậu: 5, Vua: 6</param>
        /// <param name="intEdgeSize">Chiều dài cạnh</param>
        public UcChessPiece(int intSide, int intType, int intStyle, int intCellSize, int intPieceSize)
        {
            InitializeComponent();

            this._Side = (ChessSide)intSide;
            this._Type = (ChessPieceType)intType;
            this._Style = (ChessPieceStyle)intStyle;
            this._image = clsImageProcess.GetChessPieceBitMap(_Side, _Type, _Style);
            this._CellSize = intCellSize;
            this._PieceSize = intPieceSize;
            this.Size = new Size(this._PieceSize, this._PieceSize);
        }
        public UcChessPiece()
        {
            InitializeComponent();

        }

        public UcChessPiece(ChessSide Side, ChessPieceType Type, ChessPieceStyle Style, int intCellSize, int intPieceSize)
        {
            InitializeComponent();

            this._Side = Side;
            this._Type = Type;
            this._Style = Style;
            this._image = clsImageProcess.GetChessPieceBitMap(_Side, _Type, _Style);
            this._CellSize = intCellSize;
            this._PieceSize = intPieceSize;
            this.Size = new Size(this._PieceSize, this._PieceSize);

        }

        public UcChessPiece(ChessSide Side, ChessPieceType Type, ChessPieceStyle Style, int intCellSize, int intPieceSize, int PositionX, int PositionY, UcChessCell UcOnCell)
        {
            InitializeComponent();

            this._Side = Side;
            this._Type = Type;
            this._Style = Style;
            this._image = clsImageProcess.GetChessPieceBitMap(_Side, _Type, _Style);
            this._PieceSize = intPieceSize;
            this._CellSize = intCellSize;
            this.Size = new Size(this._PieceSize, this._PieceSize);
            this._PositionX = PositionX;
            this._PositionY = PositionY;
            this._ucOnCell = UcOnCell;
        }


        public UcChessPiece(Bitmap bmpImage, int intCellSize, int intPieceSize)
        {
            InitializeComponent();

            this._image = bmpImage;
            this._PieceSize = intPieceSize;
            this._CellSize = intCellSize;
            this.Size = new Size(this._PieceSize, this._PieceSize);

        }

        private void UcChessPiece_Load(object sender, EventArgs e)
        {
            
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
            
            Image.GetThumbnailImageAbort callback = null;
            IntPtr callbackdata = new IntPtr();
            this._image  = (Bitmap)_image.GetThumbnailImage(_PieceSize, _PieceSize, callback, callbackdata);
            this.UpdateStyles();
           
            //GraphicsPath shape = new GraphicsPath();
            //shape.AddRectangle(new RectangleF(0, 0, this._PieceSize, this._PieceSize));
            //this.Region = new Region(shape);          

            
        }


        private void UcChessPiece_MouseDown(object sender, MouseEventArgs e)
        {
            if (UcChessBoard.IsCapturedMode)
                return;
            LastMousePos = MousePosition;
         
            UcChessBoard Board = (UcChessBoard)this.Parent;//Lấy bàn cờ
            
            Board.arrMove = new ArrayList();
            //Hiển thị các nước có thể đi
            if ((Board.OwnSide == this.Side || Board.GameMode == GameMode.VsHuman)&&Board .GameStatus == GameStatus.NowPlaying)
            {
                if ((Board.WhiteToMove == true && this._Side == ChessSide.White) || (Board.WhiteToMove == false && this._Side == ChessSide.Black))
                {
                    int[,] BoardState = Board._BoardState;//Lấy trạng thái bàn cờ
                    Point CurPos = new Point(this._PositionX, this._PositionY);
                    Board.arrMove = clsChessEngine.FindAllLegalMove(BoardState, CurPos, this._Type);               

                    Board.HighlightPossibleMoves();
                }
            }
        }


        private void UcChessPiece_MouseMove(object sender, MouseEventArgs e)
        {
            if (UcChessBoard.IsCapturedMode)
                return;
            this.BringToFront();
            this.Cursor = Cursors.Hand;
            UcChessBoard Board = (UcChessBoard)this.Parent;//Lấy bàn cờ
            if (this.Side == Board.OwnSide || Board.GameMode == GameMode.VsHuman)
            {
                if ((this.Side == ChessSide.White && Board.WhiteToMove == true) || (this.Side == ChessSide.Black && Board.WhiteToMove == false))
                {
                    if (MouseButtons == MouseButtons.Left)
                    {
                       
                        CurrentMousePos = MousePosition;

                        int x, y;
                        x = CurrentMousePos.X - LastMousePos.X;
                        y = CurrentMousePos.Y - LastMousePos.Y;

                        Point ControlPos = this.Location;
                        ControlPos.X += x;
                        ControlPos.Y += y;
                        ///Không cho phép di chuyển con cờ ra ngoài biên
                        if (ControlPos.X < 0)
                        {
                            ControlPos = new Point(0, ControlPos.Y);
                            Cursor.Position = LastMousePos;
                            return;
                        }
                        if (ControlPos.Y < 0)
                        {
                            ControlPos = new Point(ControlPos.X, 0);
                            Cursor.Position = LastMousePos;
                            return;
                        }

                        if (ControlPos.X + this.Width > this.Parent.Width)
                        {
                            ControlPos = new Point(this.Parent.Width - this.Width, ControlPos.Y);
                            Cursor.Position = LastMousePos;
                            return;
                        }
                        if (ControlPos.Y + this.Height > this.Parent.Height)
                        {
                            ControlPos = new Point(ControlPos.X, this.Parent.Height - this.Height);
                            Cursor.Position = LastMousePos;
                            return;
                        }
                        this.Location = ControlPos;
                        LastMousePos = CurrentMousePos;

                    }
                    else this.Cursor = Cursors.Hand;
                }
            }
        }


        private void UcChessPiece_Paint(object sender, PaintEventArgs e)
        {            
            
            Graphics g = e.Graphics;
            g.DrawImage(_image , new Rectangle(0, 0, _image.Width ,_image.Height ), 0, 0, _image .Width ,_image .Height , GraphicsUnit.Pixel);
        }     
        
       


        private void UcChessPiece_MouseUp(object sender, MouseEventArgs e)
        {
            if (UcChessBoard.IsCapturedMode)
                return;
            UcChessBoard Board = (UcChessBoard)this.Parent;//Lấy bàn cờ
          

            if (this.Side == Board.OwnSide || Board.GameMode == GameMode.VsHuman)
            {
                if ((this.Side == ChessSide.White && Board.WhiteToMove == true) || (this.Side == ChessSide.Black && Board.WhiteToMove == false))
                {
                    Board.UnHighlightMoves();                    
                    //*********************************Lấy tọa độ ô cờ***********************
                    //Lấy hai vị trí trọng tâm của PieceSize/2
                    int a = (this.Location.X + (this._PieceSize / 2)) / this._CellSize;
                    int b = (this.Location.Y + (this._PieceSize / 2)) / this._CellSize;

                    UcChessCell ct = new UcChessCell();

                    ///////CODECHANGE NGÀY 0605
                    string n;
                    int NewPos_X;
                    int NewPos_Y;
                    if (Board.OwnSide == ChessSide.White)
                    {
                        n = Convert.ToChar(65 + a).ToString() + (8 - b);//65 là kí tự A
                        NewPos_X = a + 1;
                        NewPos_Y = 8 - b;
                    }
                    else
                    {
                        n = Convert.ToChar(64 + 8 - a).ToString() + (b + 1);//65 là kí tự A
                        NewPos_X = 8 - a;
                        NewPos_Y = b + 1;
                    }

                    Point NewPos = new Point(NewPos_X, NewPos_Y);
                    Point CurPos = new Point(this._PositionX, this._PositionY);

                    
                    Board.DoMove(this,new clsMove ( CurPos, NewPos));//Di chuyển quân cờ

                }
            }

        }

        //private void UcChessPiece_MouseEnter(object sender, EventArgs e)
        //{
        //    string msg = "";
        //    switch (this._Type )
        //    {
        //        case ChessPieceType.Pawn: msg = "Tốt ";
        //            break;
        //        case ChessPieceType.Bishop: msg = "Tượng ";
        //            break;
        //        case ChessPieceType.Knight: msg = "Mã ";
        //            break;
        //        case ChessPieceType.Rook: msg = "Xe ";
        //            break;
        //        case ChessPieceType.Queen: msg = "Hậu ";
        //            break;
        //        case ChessPieceType.King: msg = "Vua ";
        //            break;                                
        //    }
        //    switch (this._Side )
        //    {
        //        case ChessSide.Black: msg += "Đen";
        //            break;
        //        case ChessSide.White: msg += "Trắng";
        //            break;                
        //    }
        //    this.toolTip1.Show(msg, this);
        //}

    }
}