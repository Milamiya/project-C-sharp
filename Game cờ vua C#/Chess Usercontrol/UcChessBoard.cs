using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace Chess_Usercontrol
{
    #region "Khai báo biến Enum"

    public enum ChessSide
    {
        Black = 1,//Đen
        White = 2//Trắng
    }
    public enum GameDifficulty
    {
        Easy = 1,
        Normal = 2,
        Hard = 3
    }
    public enum ChessPieceType
    {
        Pawn = 1,//Tốt
        Bishop = 2,//Tượng
        Knight = 3,//Mã
        Rook = 4,//Xe
        Queen = 5,//Hậu
        King = 6,//Vua
        Null = 7
    }
    public enum ChessPieceStyle
    {
        Classic = 1,
        Classsic2 = 2,
        Wooden3D = 3,
        Plastic = 4,
        DotA = 5
    }
    public enum ChessBoardStyle
    {
        BoardEdge = 0,
        Wooden = 1,
        Metal = 2,
        BlueMarble = 3,
        TanMarble = 4,
        GreenMarble = 5,
        Granite = 6,
        Brick = 7
    }

    public enum GameMode
    {
        VsHuman = 1,
        VsComputer = 2,
        VsNetWorkPlayer = 3
    }

    public enum GameStatus
    {
        NowPlaying = 0,
        BlackWin = 1,
        WhiteWin = 2,
        Draw = 3
    }

    #endregion
    public partial class UcChessBoard : UserControl
    {
        #region "Khai báo biến toàn cục"
        private Bitmap _BlackCellBitmap;
        private Bitmap _WhiteCellBitmap;
        private int _CellSize, _PieceSize;//Kích thước ô cờ, quân cờ
        private ChessPieceStyle _PieceStyle;
        private ChessSide _OwnSide = ChessSide.White;
        private ChessBoardStyle _BoardStyle;
        private GameMode _GameMode;
        private GameStatus _GameStatus;
        private GameDifficulty _GameDiffculty = GameDifficulty.Normal;

        public static bool kingsideCastling = true;//Nhập thành gần, quân đen
        public static bool queensideCastling = true;//Nhập thành xa, quân đen

        public static bool KINGsideCastling = true;//Nhập thành gần, quân trắng        
        public static bool QUEENsideCastling = true;//Nhập thành xa, quân trắng

        public clsMove LastMove = null;
        public int HalfMoveClock;

        public static Point _EnPassantPoint = new Point();


        private bool _PlaySound;
        private bool _WhiteToMove = true;
        private Bitmap _BoardBitMap;
        private bool _ShowMessage = true;


        public ArrayList arrMove = new ArrayList();
        //Cập nhật ngày 30/07/2010 xử lý trường hợp bất biến 3 lần        

        public ArrayList arrFEN = new ArrayList();

        public Stack stkWhiteMoves = new Stack();
        public Stack stkBlackMoves = new Stack();

        public Stack stkState = new Stack();

        public Stack stkCapturedPieces = new Stack();


        public static bool IsCapturedMode = false;//Dùng để chụp ảnh control

        public int[,] _BoardState = new int[10, 10];//Luu trang thai ban co
        /*
         * Qui ước: 
         *  + Cạnh bàn cờ:-1
         *  + Không có quân cờ:0
         *  + Quân Tốt Đen:   11, Quân Tốt Trắng:   12
         *  + Quân Tượng Đen: 21, Quân Tượng Trắng: 22
         *  + Quân Mã Đen:    31, Quân Mã Trắng:    32
         *  + Quân Xe Đen:    41, Quân Xe Trắng:    42
         *  + Quân Hậu Đen:   51, Quân Hậu Trắng:   52
         *  + Quân Vua Đen:   61, Quân Vua Trắng:   62
         */


        public UcChessCell[,] arrChessCell = new UcChessCell[9, 9];//mảng các ô cờ

        #endregion

        #region Property


        public Bitmap WhiteCellBitmap
        {
            get { return _WhiteCellBitmap; }
            set { _WhiteCellBitmap = value; }
        }

        public Bitmap BlackCellBitmap
        {
            get { return _BlackCellBitmap; }
            set { _BlackCellBitmap = value; }
        }
        public ChessSide OwnSide
        {
            get
            {
                return this._OwnSide;
            }
            set
            {
                this._OwnSide = value;
            }
        }
        public Bitmap BoardBitMap
        {
            get
            {
                return this._BoardBitMap;
            }
            set
            {
                this._BoardBitMap = value;
            }

        }

        public bool WhiteToMove
        {
            get
            {
                return this._WhiteToMove;
            }
            set
            {
                this._WhiteToMove = value;
            }
        }
        #endregion

        public ChessBoardStyle BoardStyle
        {
            get
            {
                return this._BoardStyle;
            }
            set
            {
                this._BoardStyle = value;
            }
        }

        public GameMode GameMode
        {
            get
            {
                return this._GameMode;
            }
            set
            {
                this._GameMode = value;
            }
        }
        public bool ShowMessage
        {
            get
            {
                return this._ShowMessage;
            }
            set
            {
                this._ShowMessage = value;
            }
        }


        public GameStatus GameStatus
        {
            get { return this._GameStatus; }
            set { this._GameStatus = value; }

        }

        public ChessPieceStyle PieceStyle
        {
            get
            {
                return this._PieceStyle;
            }
            set
            {
                this._PieceStyle = value;
            }
        }

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

        public bool PlaySound
        {
            get
            {
                return this._PlaySound;
            }
            set
            {
                this._PlaySound = value;
            }
        }

        public int FullMovesNumber
        {
            get
            {
                return stkBlackMoves.Count + 1;
            }
        }
        public GameDifficulty Difficulty
        {
            get { return this._GameDiffculty; }
            set { this._GameDiffculty = value; }
        }


        public ArrayList FENList
        {
            get { return arrFEN; }
            set { arrFEN = value; }
        }


        //public UcChessBoard(ChessBoardStyle eBoardStyle, ChessPieceStyle ePieceStyle, ChessSide eOwnSide, GameMode eGameMode, int CellSize, int PieceSize, bool bPlaySound)
        //{
        //    InitializeComponent();
        //    this.Size = new Size(CellSize * 8, CellSize * 8);
        //    this._BlackCellBitmap = clsImageProcess.GetChessBoardBitMap(ChessSide.Black, eBoardStyle);
        //    this._WhiteCellBitmap = clsImageProcess.GetChessBoardBitMap(ChessSide.White, eBoardStyle);
        //    this._CellSize = CellSize;
        //    this._PieceSize = PieceSize;
        //    this._PieceStyle = ePieceStyle;
        //    this._BoardStyle = eBoardStyle;
        //    this._PlaySound = bPlaySound;
        //    this._OwnSide = eOwnSide;
        //    this._GameMode = eGameMode;
        //    CreateChessBoard();//Tạo các ô cờ    
        //    InitBoardState();//Tạo Trạng Thái Bàn Cờ
        //    AddChessPiece(ePieceStyle, this._BoardState);
        //}

        //public UcChessBoard(ChessBoardStyle eBoardStyle, int CellSize, int PieceSize)
        //{
        //    InitializeComponent();
        //    this.Size = new Size(CellSize * 8, CellSize * 8);
        //    this._BlackCellBitmap = clsImageProcess.GetChessBoardBitMap(ChessSide.Black, eBoardStyle);
        //    this._WhiteCellBitmap = clsImageProcess.GetChessBoardBitMap(ChessSide.White, eBoardStyle);
        //    this._CellSize = CellSize;
        //    this._PieceSize = PieceSize;
        //    this._BoardStyle = eBoardStyle;

        //    CreateChessBoard();//Tạo các ô cờ   

        //}

        //public UcChessBoard(ChessBoardStyle eBoardStyle, ChessPieceStyle ePieceStyle, ChessSide eOwnSide, GameMode eGameMode, int[,] BoardState, int CellSize, int PieceSize, bool bPlaySound, bool bWhiteToMove)
        //{
        //    InitializeComponent();
        //    this.Size = new Size(CellSize * 8, CellSize * 8);
        //    this._BlackCellBitmap = clsImageProcess.GetChessBoardBitMap(ChessSide.Black, eBoardStyle);
        //    this._WhiteCellBitmap = clsImageProcess.GetChessBoardBitMap(ChessSide.White, eBoardStyle);
        //    this._BoardState = BoardState;
        //    this._CellSize = CellSize;
        //    this._PieceSize = PieceSize;
        //    this._PieceStyle = ePieceStyle;
        //    this._BoardStyle = eBoardStyle;
        //    this._PlaySound = bPlaySound;
        //    this._OwnSide = eOwnSide;
        //    this._GameMode = eGameMode;
        //    this._WhiteToMove = bWhiteToMove;
        //    CreateChessBoard();//Tạo các ô cờ    
        //    // InitBoardState();//Tạo Trạng Thái Bàn Cờ
        //    AddChessPiece(ePieceStyle, this._BoardState);
        //}
        /// <param name="eBoardStyle">Kiểu bàn cờ</param>
        /// <param name="ePieceStyle">Kiểu quân cờ</param>
        /// <param name="eOwnSide">Quân Mà Người Chơi Chọn</param>
        /// <param name="eGameMode">Chế Độ Chơi</param>        
        /// <param name="CellSize">Kích thước ô cờ</param>
        /// <param name="PieceSize">Kích thước quân cờ (Mặc định nếu =0)</param>
        /// <param name="bPlaySound">Âm Thanh</param>
        /// <param name="strFEN">Forsyth-Edwards Notation</param>
        /// Chơi Với Người
        public UcChessBoard(ChessBoardStyle eBoardStyle, ChessPieceStyle ePieceStyle, ChessSide eOwnSide, GameMode eGameMode, int CellSize, int PieceSize, bool bPlaySound, string strFEN)
        {
            InitializeComponent();
            this.Size = new Size(CellSize * 8, CellSize * 8);
            this._BlackCellBitmap = clsImageProcess.GetChessBoardBitMap(ChessSide.Black, eBoardStyle);
            this._WhiteCellBitmap = clsImageProcess.GetChessBoardBitMap(ChessSide.White, eBoardStyle);

            this._CellSize = CellSize;
            this._PieceSize = PieceSize;
            this._PieceStyle = ePieceStyle;
            this._BoardStyle = eBoardStyle;
            this._PlaySound = bPlaySound;
            this._OwnSide = eOwnSide;
            this._GameMode = eGameMode;


            CreateChessBoard();//Tạo các ô cờ    
            kingsideCastling = true;//Nhập thành gần, quân đen
            queensideCastling = true;//Nhập thành xa, quân đen

            KINGsideCastling = true;//Nhập thành gần, quân trắng        
            QUEENsideCastling = true;//Nhập thành xa, quân trắng
            _EnPassantPoint = new Point();
            clsFEN.SetFEN(this, strFEN);
            AddChessPiece(ePieceStyle, this._BoardState);


        }

        public UcChessBoard(ChessBoardStyle eBoardStyle, ChessPieceStyle ePieceStyle, ChessSide eOwnSide, GameMode eGameMode, GameDifficulty eDifficulty, int CellSize, int PieceSize, bool bPlaySound, string strFEN)
        {
            InitializeComponent();
            this.Size = new Size(CellSize * 8, CellSize * 8);
            this._BlackCellBitmap = clsImageProcess.GetChessBoardBitMap(ChessSide.Black, eBoardStyle);
            this._WhiteCellBitmap = clsImageProcess.GetChessBoardBitMap(ChessSide.White, eBoardStyle);

            this._CellSize = CellSize;
            this._PieceSize = PieceSize;
            this._PieceStyle = ePieceStyle;
            this._BoardStyle = eBoardStyle;
            this._PlaySound = bPlaySound;
            this._OwnSide = eOwnSide;
            this._GameMode = eGameMode;
            this._GameDiffculty = eDifficulty;
            CreateChessBoard();//Tạo các ô cờ    

            kingsideCastling = true;//Nhập thành gần, quân đen
            queensideCastling = true;//Nhập thành xa, quân đen

            KINGsideCastling = true;//Nhập thành gần, quân trắng        
            QUEENsideCastling = true;//Nhập thành xa, quân trắng
            _EnPassantPoint = new Point();
            clsFEN.SetFEN(this, strFEN);
            AddChessPiece(ePieceStyle, this._BoardState);
            if (this._GameMode == GameMode.VsComputer)
            {
                if (this.OwnSide == ChessSide.White)
                {
                    if (WhiteToMove == false)
                        timerComputerMove.Enabled = true;
                }
                else
                {
                    if (WhiteToMove == true)
                        timerComputerMove.Enabled = true;
                }
            }
        }

        #region "Đặt quân cờ lên bàn cờ"

        private void InitBoardState()
        {
            /*
            * Qui ước:             
            *  + Cạnh bàn cờ:-1
            *  + Không có quân cờ:0
            *  + Quân Tốt Đen:   11, Quân Tốt Trắng:   12
            *  + Quân Tượng Đen: 21, Quân Tượng Trắng: 22
            *  + Quân Mã Đen:    31, Quân Mã Trắng:    32
            *  + Quân Xe Đen:    41, Quân Xe Trắng:    42
            *  + Quân Hậu Đen:   51, Quân Hậu Trắng:   52
            *  + Quân Vua Đen:   61, Quân Vua Trắng:   62
            * 
            * Phần tử có tọa độ (x,y) có trạng thái là _BoardState[x,y]
            */

            //******Quan Tot******
            for (int i = 1; i <= 8; i++)
            {
                _BoardState[i, 2] = 12;
                _BoardState[i, 7] = 11;
            }
            //******Quan Tượng*******
            _BoardState[3, 1] = 22;
            _BoardState[6, 1] = 22;
            _BoardState[3, 8] = 21;
            _BoardState[6, 8] = 21;
            //******Quan Mã*******
            _BoardState[2, 1] = 32;
            _BoardState[7, 1] = 32;
            _BoardState[2, 8] = 31;
            _BoardState[7, 8] = 31;
            //******Quan Xe*******
            _BoardState[1, 1] = 42;
            _BoardState[8, 1] = 42;
            _BoardState[1, 8] = 41;
            _BoardState[8, 8] = 41;
            //******Quan Hậu, Vua*******
            _BoardState[4, 1] = 52;
            _BoardState[4, 8] = 51;
            _BoardState[5, 1] = 62;
            _BoardState[5, 8] = 61;
            //******Cạnh bàn cờ*********
            for (int i = 0; i < 10; i++)
            {
                _BoardState[0, i] = -1;
                _BoardState[i, 0] = -1;
                _BoardState[9, i] = -1;
                _BoardState[i, 9] = -1;
            }
            //*****Còn lại là 0********         
        }


        private void AddChessPiece(ChessPieceStyle ePieceStyle, int[,] BoardState)
        {

            //************************Add Tot**********************
            //Quân Tốt Trắng nằm ở dòng 2
            //Quân Tốt Đen nằm ở dòng 7
            //*****************************************************                     
            if (this._PieceSize == 0)
            {
                this._PieceSize = this._CellSize;
            }

            for (int y = 1; y <= 8; y++)
                for (int x = 1; x <= 8; x++)
                {
                    if (BoardState[x, y] > 0)
                    {
                        ChessPieceType eType = (ChessPieceType)(BoardState[x, y] / 10);
                        ChessSide eSide = (ChessSide)(BoardState[x, y] % 10);
                        arrChessCell[x, y].ChessPiece = new UcChessPiece(eSide, eType, ePieceStyle, this._CellSize, this._PieceSize, x, y, arrChessCell[x, y]);
                    }
                }
        }


        #endregion
        #region "Tạo bàn cờ từ các ô cờ"
        /*
             * Góc dưới bên trái của bàn cờ vua là một ô đen
             * Quân Hậu Trắng sẽ nằm trên ô Trắng và Quân Hậu Đen sẽ nằm trên ô đen
             * Bàn cờ được đánh tọa độ như sau :
             * Từ A->I tính từ trái sang phải
             * Từ 1->8 tính từ dưới lên bắt đầu từ dòng đầu tiên của quân trắng             * 
             */

        /*
         * Nếu x+y là số lẻ thì đó là ô Trắng
         * Nếu x+y là số chẵn thì đó là ô Đen
         */
        public void CreateChessBoard()
        {

            for (int i = 1; i <= 8; i++)//-> tạo ô cờ từ trên xuông dưới từ trái sang phải
            {
                for (int j = 1; j <= 8; j++)
                {

                    UcChessCell Cell;

                    if ((9 - i + j) % 2 == 1)//ô Trắng
                    {
                        Cell = new UcChessCell(j, 9 - i, this._WhiteCellBitmap, ChessSide.White, this._BoardStyle);
                    }
                    else
                    {
                        Cell = new UcChessCell(j, 9 - i, this._BlackCellBitmap, ChessSide.Black, this._BoardStyle);
                    }

                    Cell.Size = new Size(this._CellSize, this._CellSize);
                    Cell.Name = Convert.ToChar(64 + j).ToString() + (9 - i);//65 là kí tự A

                    /////CODECHANGE NGÀY 0605
                    if (this._OwnSide == ChessSide.White)
                    {
                        Cell.Location = new Point((j - 1) * _CellSize, (i - 1) * _CellSize);
                    }
                    else
                    {
                        Cell.Location = new Point((8 - j) * _CellSize, (8 - i) * _CellSize);
                    }


                    arrChessCell[j, 9 - i] = Cell;//Đưa vào mảng các ô cờ

                    this.Controls.Add(Cell);
                }
            }
        }
        #endregion
        Bitmap bmpBackImage;

        public Bitmap TakePicture(int w, int h)
        {
            Bitmap bmp = new Bitmap(w, h);
            IsCapturedMode = true;

            for (int x = 1; x <= 8; x++)
            {
                for (int y = 1; y <= 8; y++)
                {
                    UcChessPiece p = arrChessCell[x, y].ChessPiece;
                    if (p != null)
                    {
                        this.Controls.Remove(p);
                        arrChessCell[x, y].ChessPiece = p;
                    }
                }
            }
            this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height));
            IsCapturedMode = false;
            for (int x = 1; x <= 8; x++)
            {
                for (int y = 1; y <= 8; y++)
                {
                    UcChessPiece p = arrChessCell[x, y].ChessPiece;
                    if (p != null)
                    {
                        arrChessCell[x, y].Controls.Remove(p);
                        arrChessCell[x, y].ChessPiece = p;
                    }
                }
            }
            return bmp;
        }
        private void UcChessBoard_Load(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);


            CheckForIllegalCrossThreadCalls = false;

            arrFEN = new ArrayList();
            arrFEN.Add(clsFEN.GetPiecePlacementString(this._BoardState));

            if (this.OwnSide == ChessSide.Black && this.GameMode == GameMode.VsComputer)
            {
                if (this.WhiteToMove == true)
                    timerComputerMove.Enabled = true;
            }

            bmpBackImage = new Bitmap(this.Width, this.Height);

            CapturedSound.LoadAsync();
            MovedSound.LoadAsync();
            CheckedSound.LoadAsync();
            CheckMatedSound.LoadAsync();

        }

        public void HighlightPossibleMoves()
        {
            if (arrMove.Count == 0)
                return;

            foreach (Point p in arrMove)
            {
                UcChessCell cell = this.arrChessCell[p.X, p.Y];
                cell.HighlightPossibleMove();
            }

            this.DrawToBitmap(bmpBackImage, new Rectangle(0, 0, this.Width, this.Height));
            Thread t = new Thread(new ThreadStart(SetBackGround));
            t.Start();

        }

        void SetBackGround()
        {
            this.BackgroundImage = bmpBackImage;
            this.UpdateStyles();

        }

        void SetDefaultBackground()
        {
            this.BackgroundImage = _BoardBitMap;
            this.UpdateStyles();
        }

        public void UnHighlightMoves()
        {
            if (arrMove.Count == 0)
                return;
            foreach (Point p in arrMove)
            {
                UcChessCell cell = this.arrChessCell[p.X, p.Y];
                cell.UnHighlightMove();
            }
            this.HighlightLastMove();
        }
        public void HighlightLastMove()
        {
            if (LastMove == null)
                return;

            UcChessCell cell = this.arrChessCell[LastMove.CurPos.X, LastMove.CurPos.Y];
            cell.ShowLastMove();
            cell = this.arrChessCell[LastMove.NewPos.X, LastMove.NewPos.Y];
            cell.ShowLastMove();
            this.DrawToBitmap(bmpBackImage, new Rectangle(0, 0, this.Width, this.Height));
            Thread t = new Thread(new ThreadStart(SetBackGround));
            t.Start();
        }

        public void UnHighlightLastMove()
        {
            if (LastMove == null)
            {
                Thread t = new Thread(new ThreadStart(SetDefaultBackground));
                t.Start();
                return;
            }
            UcChessCell cell = this.arrChessCell[LastMove.CurPos.X, LastMove.CurPos.Y];
            cell.UnHighlightMove();
            this.arrChessCell[LastMove.NewPos.X, LastMove.NewPos.Y].UnHighlightMove();
        }


        SoundPlayer CapturedSound = new SoundPlayer(Properties.Resources.Capture);
        SoundPlayer MovedSound = new SoundPlayer(Properties.Resources.Move);
        SoundPlayer CheckedSound = new SoundPlayer(Properties.Resources.Say_check);
        SoundPlayer CheckMatedSound = new SoundPlayer(Properties.Resources.Say_checkmate);

        public void PlayMusic(SoundPlayer sound)
        {
            if (this.PlaySound == true)
            {
                sound.Play();
            }
        }

        #region "DoMove"
        //vd: E2E3, E7E8=q
        public void MakeMove(string strMove)
        {
            if (strMove == "")
                return;
            clsMove MyMove = new clsMove(strMove);
            //string strCur = "", strNew = "", strPromotion = "";

            //strCur = strMove.Substring(0, 2);
            //strNew = strMove.Substring(2, 2);
            //if (strMove.Length == 6)
            //{
            //    strPromotion = strMove.Substring(5, 1);
            //}
            //int CurX = strCur[0] - 64;
            //int NewX = strNew[0] - 64;

            //MyMove.CurPos = new Point(CurX, strCur[1] - 48);
            //MyMove.NewPos = new Point(NewX, strNew[1] - 48);

            //if (strPromotion == "")
            //    MyMove.PromoteTo = ChessPieceType.Null;
            //else if (strPromotion == "Q")
            //    MyMove.PromoteTo = ChessPieceType.Queen;
            //else if (strPromotion == "B")
            //    MyMove.PromoteTo = ChessPieceType.Bishop;
            //else if (strPromotion == "N")
            //    MyMove.PromoteTo = ChessPieceType.Knight;
            //else if (strPromotion == "R")
            //    MyMove.PromoteTo = ChessPieceType.Rook;


            UcChessPiece Piece = this.arrChessCell[MyMove.CurPos.X, MyMove.CurPos.Y].ChessPiece;
            if (Piece == null)
                return;

            arrMove = clsChessEngine.FindAllLegalMove(_BoardState, MyMove.CurPos, Piece.Type);
            DoMove(Piece, MyMove);
        }

        public bool AlreadyMakeMove = false;

        public delegate void MoveMakedHandler(object sender, EventArgs e);
        public event MoveMakedHandler MoveMaked;
        protected virtual void OnMoveMaked(EventArgs e)
        {
            if (MoveMaked != null)
                MoveMaked(this, e);
        }

        public delegate void PieceCapturedHandler(object sender, EventArgs e);
        public event PieceCapturedHandler PieceCaptured;
        protected virtual void OnPieceCaptured(EventArgs e)
        {
            if (PieceCaptured != null)
                PieceCaptured(this, e);
        }

        public void DoMove(UcChessPiece Piece, clsMove move)
        {
            if ((Piece.Side == ChessSide.Black && this._WhiteToMove == true) || (Piece.Side == ChessSide.White && this._WhiteToMove == false))
                return;

            Point CurPos = move.CurPos;
            Point NewPos = move.NewPos;

            UcChessCell ct = (UcChessCell)this.arrChessCell[NewPos.X, NewPos.Y];
            //*********************************Kiểm tra nước đi************************
            //Kiểm tra Xem Quân Cờ có thể di chuyển từ CurPos đến NewPos hay không
            if (clsChessEngine.CanMove(arrMove, NewPos) == true)
            {
                UnHighlightLastMove();
                PushState();
                string strLastCell = Convert.ToChar(CurPos.X + 64) + CurPos.Y.ToString();
                string strNewCell = Convert.ToChar(NewPos.X + 64) + NewPos.Y.ToString();


                this._BoardState[CurPos.X, CurPos.Y] = 0;//Đánh dấu vị trí cũ không chứa quân cờ
                this._BoardState[NewPos.X, NewPos.Y] = (int)Piece.Type * 10 + (int)Piece.Side;
                //Kiểm tra xem quân vua có bị chiếu không
                //****************Chưa tính trường hợp chiếu bí và Hòa***************


                bool bCapture = false;

                //Lấy vị trí Bắt tôt qua đường nếu có

                if (Piece.Type == ChessPieceType.Pawn)
                {
                    if (Math.Abs(NewPos.Y - CurPos.Y) == 2)
                    {
                        _EnPassantPoint = clsPawn.GetEnPassantPoint(this._BoardState, NewPos);
                    }
                    else if (CurPos.X == NewPos.X)
                    {
                        _EnPassantPoint = new Point();
                    }


                    //Thực hiện nước bắt tốt qua đường
                    if (NewPos == _EnPassantPoint)
                    {
                        Point CapturedPoint;

                        if (Piece.Side == ChessSide.White)
                            CapturedPoint = new Point(_EnPassantPoint.X, _EnPassantPoint.Y - 1);
                        else
                            CapturedPoint = new Point(_EnPassantPoint.X, _EnPassantPoint.Y + 1);

                        UcChessCell bt = arrChessCell[CapturedPoint.X, CapturedPoint.Y];

                        this._BoardState[CapturedPoint.X, CapturedPoint.Y] = 0;//Đánh dấu vị trí cũ không chứa quân cờ                        



                        stkCapturedPieces.Push(bt.ChessPiece);

                        bt.ChessPiece.Hide();
                        bt.ChessPiece = null;
                        _EnPassantPoint = new Point();

                        bCapture = true;
                    }
                }
                else
                {
                    _EnPassantPoint = new Point();
                }
                //MessageBox.Show(_EnPassantPoint.X + " " + _EnPassantPoint.Y);
                if (ct.ChessPiece != null && ct.ChessPiece.Side != Piece.Side)//Nếu đã có quân cờ đặt tại ô đến
                {

                    UcChessPiece CapturedPiece = ct.ChessPiece;
                    stkCapturedPieces.Push(CapturedPiece);
                    CapturedPiece.Hide();//Xóa quân cờ tại ô Di chuyển đến 

                    if (CapturedPiece.Type == ChessPieceType.Rook)
                    {
                        if (CapturedPiece.Side == ChessSide.White)
                        {
                            if (CapturedPiece.PositionX == 1)
                                QUEENsideCastling = false;
                            if (CapturedPiece.PositionX == 8)
                                KINGsideCastling = false;
                        }
                        else
                        {
                            if (CapturedPiece.PositionX == 1)
                                queensideCastling = false;
                            if (CapturedPiece.PositionX == 8)
                                kingsideCastling = false;
                        }
                    }
                    ct.ChessPiece = null;
                    bCapture = true;
                }

                Piece.UConCell.ChessPiece = null;//Ô cờ trước đó ko còn chứa quân cờ này nữa
                //Dat Quan Co Tai Vi Tri Moi
                ct.ChessPiece = Piece;
                Piece.UConCell = ct;

                //Gán tọa độ mới cho quân cờ
                Piece.PositionX = NewPos.X;
                Piece.PositionY = NewPos.Y;

                string strPromote = "";
                if (Piece.Type == ChessPieceType.Pawn)
                {

                    if (clsPawn.Promotion(Piece, move.PromoteTo) == true)
                    {
                        this._BoardState[Piece.PositionX, Piece.PositionY] = (int)Piece.Type * 10 + (int)Piece.Side;
                        switch (Piece.Type)
                        {
                            case ChessPieceType.Bishop: strPromote = "=B";
                                break;
                            case ChessPieceType.Knight: strPromote = "=N";
                                break;
                            case ChessPieceType.Rook: strPromote = "=R";
                                break;
                            case ChessPieceType.Queen: strPromote = "=Q";
                                break;

                        }
                        move.PromoteTo = Piece.Type;
                    }

                }

                if (bCapture == true)
                {

                    PushMove(Piece.Side, strLastCell + "X" + strNewCell + strPromote);
                    OnPieceCaptured(EventArgs.Empty);
                    PlayMusic(CapturedSound);
                }
                else
                {
                    PushMove(Piece.Side, strLastCell + "-" + strNewCell + strPromote);
                    PlayMusic(MovedSound);
                }

                //Cập Nhật trạng thái nhập thành
                if (Piece.Type == ChessPieceType.Rook)
                {
                    if (Piece.Side == ChessSide.White)
                    {
                        if (Piece.PositionX == 1)
                            QUEENsideCastling = false;
                        if (Piece.PositionX == 8)
                            KINGsideCastling = false;
                    }
                    else
                    {
                        if (Piece.PositionX == 1)
                            queensideCastling = false;
                        if (Piece.PositionX == 8)
                            kingsideCastling = false;
                    }
                }
                if (Piece.Type == ChessPieceType.King)
                {

                    if (Piece.Side == ChessSide.White)
                    {
                        QUEENsideCastling = false;
                        KINGsideCastling = false;
                    }
                    else
                    {
                        queensideCastling = false;
                        kingsideCastling = false;
                    }

                    if (Math.Abs(NewPos.X - CurPos.X) == 2)//Nhập Thành
                    {

                        if (NewPos.X == 3)
                        {
                            UcChessCell OldRookCell = (UcChessCell)this.arrChessCell[1, NewPos.Y];
                            UcChessCell NewRookCell = (UcChessCell)this.arrChessCell[4, NewPos.Y];

                            this._BoardState[1, NewPos.Y] = 0;//Đánh dấu quân xe không còn ở vị trí cũ
                            this._BoardState[4, NewPos.Y] = 40 + (int)Piece.Side;//Đặt quân xe tại vị trí mới

                            NewRookCell.ChessPiece = OldRookCell.ChessPiece;
                            OldRookCell.ChessPiece = null;

                            NewRookCell.ChessPiece.UConCell = NewRookCell;
                            NewRookCell.ChessPiece.PositionX = NewRookCell.PositionX;
                            NewRookCell.ChessPiece.PositionY = NewRookCell.PositionY;
                        }
                        else
                        {
                            UcChessCell OldRookCell = (UcChessCell)this.arrChessCell[8, NewPos.Y];
                            UcChessCell NewRookCell = (UcChessCell)this.arrChessCell[6, NewPos.Y];

                            this._BoardState[8, NewPos.Y] = 0;//Đánh dấu quân xe không còn ở vị trí cũ
                            this._BoardState[6, NewPos.Y] = 40 + (int)Piece.Side;//Đặt quân xe tại vị trí mới

                            NewRookCell.ChessPiece = OldRookCell.ChessPiece;
                            OldRookCell.ChessPiece = null;

                            NewRookCell.ChessPiece.UConCell = NewRookCell;
                            NewRookCell.ChessPiece.PositionX = NewRookCell.PositionX;
                            NewRookCell.ChessPiece.PositionY = NewRookCell.PositionY;
                        }
                    }
                }
                arrFEN.Add(clsFEN.GetPiecePlacementString(this._BoardState));
                //********Play Sound, Hiển thị thông báo*************
                this._GameStatus = clsChessEngine.GetGameStatus(this._BoardState, arrFEN, Piece.Side);

                if (this._GameStatus == GameStatus.BlackWin)
                {
                    PlayMusic(CheckMatedSound);
                    DisplayMessage("Quân Đen Thắng !");

                }
                if (this._GameStatus == GameStatus.WhiteWin)
                {
                    PlayMusic(CheckMatedSound);
                    DisplayMessage("Quân Trắng Thắng !");

                }
                if (this._GameStatus == GameStatus.Draw)
                {
                    if (clsChessEngine.CheckThreefoldRepetition(arrFEN))
                        DisplayMessage("Ván cờ Hòa do \"Bất Biến 3 Lần\"");
                    else if (clsChessEngine.CheckInsufficientMaterial(this._BoardState, Piece.Side))
                        DisplayMessage("Ván cờ Hòa do cả 2 bên không đủ quân chiếu bí đối phương");
                    else
                        DisplayMessage("Ván cờ Hòa do không còn nước đi hợp lệ");

                }

                if (this._GameStatus == GameStatus.NowPlaying && (clsKing.IsChecked(this._BoardState, ChessSide.Black) == true || clsKing.IsChecked(this._BoardState, ChessSide.White) == true))
                {
                    PlayMusic(CheckedSound);
                    if ((this._OwnSide == ChessSide.White && this._WhiteToMove == false) || (this._OwnSide == ChessSide.Black && this._WhiteToMove == true))
                        DisplayMessage("Chiếu !");
                }


                if (Piece.Side == this._OwnSide)
                {
                    AlreadyMakeMove = true;
                }

                //Chuyển lượt đi cho đối phương
                if (Piece.Side == ChessSide.Black)
                    this.WhiteToMove = true;
                else
                    this.WhiteToMove = false;


                //Cho máy đi
                if (Piece.Side == this.OwnSide && this.GameMode == GameMode.VsComputer)
                {
                    IsThinking = true;
                    timerComputerMove.Enabled = true;
                }

                LastMove = move;

                HighlightLastMove();


                OnMoveMaked(EventArgs.Empty);

            }
            else
            {
                Piece.UConCell.ChessPiece = Piece;// tra về ô cũ
            }

        }

        void DisplayMessage(string Msg)
        {
            this._ShowMessage = frmMessageBox.ShowMessage;

            if (this._ShowMessage)
            {
                if (this.GameMode == GameMode.VsNetWorkPlayer)
                {
                    MessageBox.Show(Msg);
                    return;
                }

                frmMessageBox frm = new frmMessageBox(Msg);
                frm.Show();
            }
        }

        #endregion

        #region "Undo"
        public void UnDoMove()
        {

            string strMoves = "";
            string strLastMove = "";
            if (stkBlackMoves.Count == 0 && this.GameMode == GameMode.VsComputer && this.OwnSide == ChessSide.Black)
                return;
            if (stkWhiteMoves.Count > 0 && this.WhiteToMove == false)
            {
                strMoves = stkWhiteMoves.Pop().ToString();

                UnHighlightLastMove();
                if (stkBlackMoves.Count > 0)
                    strLastMove = stkBlackMoves.Peek().ToString();

            }
            if (stkBlackMoves.Count > 0 && this.WhiteToMove == true)
            {
                strMoves = stkBlackMoves.Pop().ToString();

                UnHighlightLastMove();

                if (stkWhiteMoves.Count > 0)
                    strLastMove = stkWhiteMoves.Peek().ToString();
            }

            if (strLastMove != "")
            {
                char m = strLastMove[2];
                string strLast = "";
                string strNew = "";
                UcChessCell OldCell;
                UcChessCell NewCell;

                strLast = strLastMove.Substring(0, 2);
                strNew = strLastMove.Substring(3, 2);

                OldCell = (UcChessCell)this.Controls.Find(strLast, true)[0];
                NewCell = (UcChessCell)this.Controls.Find(strNew, true)[0];

                LastMove = new clsMove(new Point(OldCell.PositionX, OldCell.PositionY), new Point(NewCell.PositionX, NewCell.PositionY));
                HighlightLastMove();
            }
            else
            {
                LastMove = null;
                this.UnHighlightLastMove();
            }


            if (strMoves != "")
            {
                char m = strMoves[2];
                string strLast = "";
                string strNew = "";
                UcChessCell OldCell;
                UcChessCell NewCell;

                string strPromote = "";
                if (strMoves.Length == 7)
                {
                    strPromote = strMoves.Split('=')[1];
                    strMoves = strMoves.Substring(0, 5);
                }

                if (m == '-')
                {
                    strLast = strMoves.Split('-')[0];
                    strNew = strMoves.Split('-')[1];

                    OldCell = (UcChessCell)this.Controls.Find(strLast, true)[0];
                    NewCell = (UcChessCell)this.Controls.Find(strNew, true)[0];


                    if (NewCell.ChessPiece.Type == ChessPieceType.King && Math.Abs(NewCell.PositionX - OldCell.PositionX) == 2)
                    {
                        if (NewCell.PositionX == 3)
                        {
                            UcChessCell OldRookCell = (UcChessCell)this.arrChessCell[1, NewCell.PositionY];
                            UcChessCell NewRookCell = (UcChessCell)this.arrChessCell[4, NewCell.PositionY];

                            this._BoardState[1, NewCell.PositionY] = 40 + (int)NewRookCell.ChessPiece.Side;
                            this._BoardState[4, NewCell.PositionY] = 0;

                            OldRookCell.ChessPiece = NewRookCell.ChessPiece;
                            NewRookCell.ChessPiece = null;

                            OldRookCell.ChessPiece.UConCell = OldRookCell;
                            OldRookCell.ChessPiece.PositionX = OldRookCell.PositionX;
                            OldRookCell.ChessPiece.PositionY = OldRookCell.PositionY;
                        }
                        else
                        {
                            UcChessCell OldRookCell = (UcChessCell)this.arrChessCell[8, NewCell.PositionY];
                            UcChessCell NewRookCell = (UcChessCell)this.arrChessCell[6, NewCell.PositionY];

                            this._BoardState[8, NewCell.PositionY] = 40 + (int)NewRookCell.ChessPiece.Side;
                            this._BoardState[6, NewCell.PositionY] = 0;

                            OldRookCell.ChessPiece = NewRookCell.ChessPiece;
                            NewRookCell.ChessPiece = null;

                            OldRookCell.ChessPiece.UConCell = OldRookCell;
                            OldRookCell.ChessPiece.PositionX = OldRookCell.PositionX;
                            OldRookCell.ChessPiece.PositionY = OldRookCell.PositionY;

                        }
                    }
                    OldCell.ChessPiece = NewCell.ChessPiece;

                    if (strPromote != "")
                    {
                        UcChessPiece p = OldCell.ChessPiece;
                        p.Type = ChessPieceType.Pawn;
                        p.Image = clsImageProcess.GetChessPieceBitMap(p.Side, ChessPieceType.Pawn, this.PieceStyle);

                    }

                    OldCell.ChessPiece.UConCell = OldCell;
                    OldCell.ChessPiece.PositionX = OldCell.PositionX;
                    OldCell.ChessPiece.PositionY = OldCell.PositionY;
                    this._BoardState[OldCell.PositionX, OldCell.PositionY] = (int)OldCell.ChessPiece.Type * 10 + (int)OldCell.ChessPiece.Side;
                    this._BoardState[NewCell.PositionX, NewCell.PositionY] = 0;

                    NewCell.ChessPiece = null;

                }
                else
                {
                    strLast = strMoves.Split('X')[0];
                    strNew = strMoves.Split('X')[1];



                    OldCell = (UcChessCell)this.Controls.Find(strLast, true)[0];
                    NewCell = (UcChessCell)this.Controls.Find(strNew, true)[0];


                    OldCell.ChessPiece = NewCell.ChessPiece;

                    if (strPromote != "")
                    {
                        UcChessPiece p = OldCell.ChessPiece;
                        p.Type = ChessPieceType.Pawn;
                        p.Image = clsImageProcess.GetChessPieceBitMap(p.Side, ChessPieceType.Pawn, this.PieceStyle);
                    }

                    OldCell.ChessPiece.UConCell = OldCell;
                    OldCell.ChessPiece.PositionX = OldCell.PositionX;
                    OldCell.ChessPiece.PositionY = OldCell.PositionY;
                    this._BoardState[OldCell.PositionX, OldCell.PositionY] = (int)OldCell.ChessPiece.Type * 10 + (int)OldCell.ChessPiece.Side;
                    this._BoardState[NewCell.PositionX, NewCell.PositionY] = 0;
                    NewCell.ChessPiece = null;

                    UcChessPiece CapturedPiece = (UcChessPiece)stkCapturedPieces.Pop();
                    UcChessCell CapturedCell = arrChessCell[CapturedPiece.PositionX, CapturedPiece.PositionY];
                    CapturedCell.ChessPiece = CapturedPiece;

                    this._BoardState[CapturedPiece.PositionX, CapturedPiece.PositionY] = (int)CapturedPiece.Type * 10 + (int)CapturedPiece.Side;

                    CapturedPiece.Show();
                }

                string strState = stkState.Pop().ToString();

                string[] s = strState.Split(' ');

                string strEnPassant = s[0];
                string strCastling = s[1];

                if (strEnPassant != "-")
                {
                    UcChessCell cell = (UcChessCell)this.Controls.Find(strEnPassant, true)[0];
                    _EnPassantPoint = new Point(cell.PositionX, cell.PositionY);
                }
                else
                    _EnPassantPoint = new Point();


                KINGsideCastling = false;
                kingsideCastling = false;
                QUEENsideCastling = false;
                queensideCastling = false;

                if (strCastling != "-")
                {
                    foreach (char c in strCastling)
                    {
                        switch (c)
                        {
                            case 'Q': QUEENsideCastling = true; break;
                            case 'K': KINGsideCastling = true; break;

                            case 'q': queensideCastling = true; break;
                            case 'k': kingsideCastling = true; break;
                        }
                    }
                }
                this._WhiteToMove = !this.WhiteToMove;
                arrFEN.RemoveAt(arrFEN.Count - 1);
            }
            else
            {
                UnHighlightLastMove();
            }

        }
        void PushMove(ChessSide side, string strMove)
        {
            if (side == ChessSide.White)
                stkWhiteMoves.Push(strMove);
            else
                stkBlackMoves.Push(strMove);

        }
        void PushState()
        {
            string strState = "";
            string strCastling = "";

            if (_EnPassantPoint == new Point())
                strState = "-";
            else
                strState = this.arrChessCell[_EnPassantPoint.X, _EnPassantPoint.Y].Name.ToLower();


            if (KINGsideCastling == true)
                strCastling += "K";

            if (QUEENsideCastling == true)
                strCastling += "Q";

            if (kingsideCastling == true)
                strCastling += "k";

            if (queensideCastling == true)
                strCastling += "q";

            if (strCastling == "")
                strCastling = "-";

            strState = strState + " " + strCastling;

            stkState.Push(strState);
        }

        #endregion

        #region"ComputerMove"
        // static bool bMove = false;
        private void timerComputerMove_Tick(object sender, EventArgs e)
        {
            if (this._GameStatus == GameStatus.NowPlaying)
            {
                ChessSide OppSide;
                if (this.OwnSide == ChessSide.White)
                    OppSide = ChessSide.Black;
                else
                    OppSide = ChessSide.White;
                timerComputerMove.Enabled = false;
                //if (bMove == true)
                //    Computer_Move(this.OwnSide);
                //else

                Computer_Move(OppSide, this._GameDiffculty);
                //bMove = !bMove;
            }
            else
            {
                this.timerComputerMove.Enabled = false;

            }

        }

        public void Computer_Move(ChessSide OppSide, GameDifficulty eDifficulty)
        {
            tmpOppSide = OppSide;
            tmpDifficulty = eDifficulty;
            backgroundWorker1.RunWorkerAsync();

        }
        ChessSide tmpOppSide;//Phe của quân cần tìm Best move
        GameDifficulty tmpDifficulty;
        clsMove MyMove = new clsMove();
        public bool IsThinking = false;
        public bool IsCancelThinking = false;

        public void CancelThinking()
        {
            backgroundWorker1.CancelAsync();
            IsCancelThinking = true;
        }
        //DateTime StartTime, EndTime;

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                IsThinking = true;
                if (IsCancelThinking == true)
                {
                    IsCancelThinking = false;
                    return;
                }
                Point CurPos = new Point();
                Point NewPos = new Point();


                string strFen = clsFEN.GetFENWithoutMoveNumber(this);
                MyMove = clsChessEngine.ReadFromBook(strFen);
                if (MyMove == null)
                {

                    MyMove = new clsMove(CurPos, NewPos);
                    //StartTime = DateTime.Now;
                    arrMove = clsChessEngine.GenerateMove(this._BoardState, this.arrFEN, tmpOppSide, ref MyMove, tmpDifficulty);
                    if (tmpDifficulty == GameDifficulty.Hard)
                        clsChessEngine.WriteToBook(strFen, MyMove);
                }
                else
                {
                    //  intOutOfBookCount = 0;
                    ChessPieceType eType = (ChessPieceType)(this._BoardState[MyMove.CurPos.X, MyMove.CurPos.Y] / 10);
                    arrMove = clsChessEngine.FindAllLegalMove(this._BoardState, MyMove.CurPos, eType);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //try
            //{
            if (IsCancelThinking == true)
                return;
            IsCancelThinking = false;
            IsThinking = false;

            //EndTime = DateTime.Now;
            //long result = EndTime.ToFileTimeUtc() - StartTime.ToFileTimeUtc();
            //result = result / 10000;
            //long sec = result / 1000;
            //long milisec = result % 1000;

            // MessageBox.Show(sec .ToString ()+","+milisec .ToString () +" giây");
            if (arrMove.Count > 0)
            {

                UcChessPiece Piece = this.arrChessCell[MyMove.CurPos.X, MyMove.CurPos.Y].ChessPiece;
                DoMove(Piece, MyMove);
            }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        #endregion






    }
}
