using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Chess_Usercontrol;
using System.IO;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Rendering;
using System.Collections;
using System.Media;
using DigitalClock;
namespace Chess_Programming
{
    public partial class frmMain : DevComponents.DotNetBar.Office2007RibbonForm
    {

        private eOffice2007ColorScheme m_BaseColorScheme = eOffice2007ColorScheme.Blue;
        private bool m_ColorSelected = false;
        public static ClsPC localpc;
        UcCapturedPieces ucCapturedPieces1, ucCapturedPieces2;
        UcMovesHistory UcMovesHistory1;
        UcCountDownTimer UcCountDownTimer1, UcCountDownTimer2;

        short TimeBonus = 0;
        short TimeLimit = 1;
        //10 phút + 15s mỗi lượt

        private void buttonStyleCustom_ColorPreview(object sender, DevComponents.DotNetBar.ColorPreviewEventArgs e)
        {
            RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(this, m_BaseColorScheme, e.Color);
        }
        private void buttonStyleCustom_ExpandChange(object sender, System.EventArgs e)
        {
            if (buttonStyleCustom.Expanded)
            {
                // Remember the starting color scheme to apply if no color is selected during live-preview
                m_ColorSelected = false;
                m_BaseColorScheme = ((Office2007Renderer)GlobalManager.Renderer).ColorTable.InitialColorScheme;
            }
            else
            {
                if (!m_ColorSelected)
                {
                    ribbonControl1.Office2007ColorTable = m_BaseColorScheme;
                }
            }
        }

        private void buttonStyleCustom_SelectedColorChanged(object sender, System.EventArgs e)
        {
            m_ColorSelected = true; // Indicate that color was selected for buttonStyleCustom_ExpandChange method
            buttonStyleCustom.CommandParameter = buttonStyleCustom.SelectedColor;
        }
        UcChessBoard Board;

        ChessSide _OwnSide;
        GameMode _GameMode;

        Label[] lblNotation = new Label[36];
        int intNotationSize;

        public frmMain()
        {
            InitializeComponent();
        }

        //Chơi với Người
        private void CreateChessBoard(ChessSide eOwnSide, GameMode eGameMode, string strFEN)
        {
            if (Board != null)
            {
                Board.CancelThinking();
                Board.Dispose();

                UcCountDownTimer1.StopTimer();
                UcCountDownTimer2.StopTimer();



                UcCountDownTimer1.Minute = TimeLimit;
                UcCountDownTimer2.Minute = TimeLimit;
                UcCountDownTimer1.Second = 0;
                UcCountDownTimer2.Second = 0;
            }
            else
            {
                ucCapturedPieces1 = new UcCapturedPieces();
                ucCapturedPieces2 = new UcCapturedPieces();
                UcMovesHistory1 = new UcMovesHistory();
                UcCountDownTimer1 = new UcCountDownTimer();
                UcCountDownTimer2 = new UcCountDownTimer();


                UcCountDownTimer1.StopTimer();
                UcCountDownTimer2.StopTimer();


                UcCountDownTimer1.Minute = TimeLimit;
                UcCountDownTimer2.Minute = TimeLimit;
                UcCountDownTimer1.Second = 1;
                UcCountDownTimer2.Second = 1;

                UcCountDownTimer1.TimeOut += new UcCountDownTimer.TimeOutHandler(UcCountDownTimer1_TimeOut);
                UcCountDownTimer2.TimeOut += new UcCountDownTimer.TimeOutHandler(UcCountDownTimer2_TimeOut);
            }

            btnSaveGame.Enabled = true;
            pnlCapturedPiece1.Controls.Clear();
            pnlCapturedPiece2.Controls.Clear();
            pnlHistory.Controls.Clear();

            pnlTimer1.Controls.Clear();
            pnlTimer2.Controls.Clear();


            pnlTimer1.Visible = true;
            pnlTimer2.Visible = true;

            pnlCapturedPiece1.Visible = true;
            pnlCapturedPiece2.Visible = true;
            pnlHistory.Visible = true;
            panel1.Visible = true;
            panel1.Controls.Clear();
            clsOptions obj = new clsOptions();
            Board = new UcChessBoard(obj.BoardStyle, obj.PieceStyle, eOwnSide, eGameMode, obj.CellSize, obj.PieceSize, obj.PlaySound, strFEN);
            //Captured Piece Collector

            ucCapturedPieces1.PieceColor = Board.OwnSide;
            //Moves History            
            UcMovesHistory1.LoadMovesHistory(Board.stkWhiteMoves, Board.stkBlackMoves);



            pnlTimer1.Controls.Add(UcCountDownTimer1);
            pnlTimer2.Controls.Add(UcCountDownTimer2);

            if (Board.OwnSide == ChessSide.Black)
                ucCapturedPieces2.PieceColor = ChessSide.White;
            else
                ucCapturedPieces2.PieceColor = ChessSide.Black;

            pnlCapturedPiece1.Controls.Add(ucCapturedPieces1);
            pnlCapturedPiece2.Controls.Add(ucCapturedPieces2);
            pnlHistory.Controls.Add(UcMovesHistory1);

            Board.MoveMaked += new UcChessBoard.MoveMakedHandler(MoveMaked);
            Board.PieceCaptured += new UcChessBoard.PieceCapturedHandler(Board_PieceCaptured);
            ucCapturedPieces1.LoadPieces(Board.stkCapturedPieces);
            ucCapturedPieces2.LoadPieces(Board.stkCapturedPieces);

            if (Board.GameMode == GameMode.VsComputer)
                btnHint.Enabled = true;
            else
                btnHint.Enabled = false;

            Bitmap bmpBackImage = new Bitmap(Board.Width, Board.Height);
            Board.DrawToBitmap(bmpBackImage, Board.Bounds);
            Board.BackgroundImage = bmpBackImage;
            Board.BoardBitMap = bmpBackImage;

            intNotationSize = (int)((obj.CellSize * 38) / 100);

            AddNotation(obj.CellSize, eOwnSide);
            Board.Location = new Point(intNotationSize, intNotationSize);
            this.panel1.Controls.Add(Board);
            this.panel1.ClientSize = new Size(obj.CellSize * 8 + intNotationSize * 2, obj.CellSize * 8 + intNotationSize * 2);
            pnlCapturedPiece1.Size = ucCapturedPieces1.Size;
            pnlCapturedPiece2.Size = ucCapturedPieces2.Size;


            pnlHistory.Size = UcMovesHistory1.Size;
            int x = this.ClientSize.Width - pnlHistory.Size.Width;
            pnlHistory.Location = new Point(x, panel1.Location.Y);


            UcCountDownTimer1.Size = new Size(110, 35);
            UcCountDownTimer2.Size = new Size(110, 35);
            UcCountDownTimer1.Location = new Point(8, 8);
            UcCountDownTimer2.Location = new Point(8, 8);
            pnlTimer1.Size = new Size(UcCountDownTimer1.Width + 16, UcCountDownTimer1.Height + 16);
            pnlTimer2.Size = pnlTimer1.Size;

            pnlPlayer1.Visible = true;
            pnlPlayer2.Visible = true;

            pnlPlayer1.Location = new Point(5, 3);
            int w = this.ribbonClientPanel1.Height - pnlPlayer2.Height - 10;
            pnlPlayer2.Location = new Point(pnlPlayer1.Location.X, w);

            panel1.Location = new Point(pnlPlayer1.Location.X + pnlPlayer1.Width + 5, pnlPlayer1.Location.Y);
            pnlCapturedPiece1.Location = new Point(panel1.Location.X + panel1.Size.Width + 3, panel1.Location.Y + 2);
            pnlCapturedPiece2.Location = new Point(panel1.Location.X + panel1.Size.Width + 3, this.ribbonClientPanel1.Height - pnlCapturedPiece2.Height - 2);

            if (Board.OwnSide == ChessSide.White)
                UcCountDownTimer2.StartTimer();
            else
                UcCountDownTimer1.StartTimer();
        }
        //Chơi với máy
        private void CreateChessBoard(ChessSide eOwnSide, GameMode eGameMode, GameDifficulty eDifficulty, string strFEN)
        {
            if (Board != null)
            {
                Board.CancelThinking();
                Board.Dispose();

                UcCountDownTimer1.StopTimer();
                UcCountDownTimer2.StopTimer();


                UcCountDownTimer1.Minute = TimeLimit;
                UcCountDownTimer2.Minute = TimeLimit;
                UcCountDownTimer1.Second = 0;
                UcCountDownTimer2.Second = 0;
            }
            else
            {
                ucCapturedPieces1 = new UcCapturedPieces();
                ucCapturedPieces2 = new UcCapturedPieces();
                UcMovesHistory1 = new UcMovesHistory();
                UcCountDownTimer1 = new UcCountDownTimer();
                UcCountDownTimer2 = new UcCountDownTimer();


                UcCountDownTimer1.StopTimer();
                UcCountDownTimer2.StopTimer();


                UcCountDownTimer1.Minute = TimeLimit;
                UcCountDownTimer2.Minute = TimeLimit;
                UcCountDownTimer1.Second = 1;
                UcCountDownTimer2.Second = 1;

                UcCountDownTimer1.TimeOut += new UcCountDownTimer.TimeOutHandler(UcCountDownTimer1_TimeOut);
                UcCountDownTimer2.TimeOut += new UcCountDownTimer.TimeOutHandler(UcCountDownTimer2_TimeOut);
            }

            pnlHistory.Controls.Clear();
            pnlHistory.Visible = true;

            btnSaveGame.Enabled = true;
            pnlCapturedPiece1.Controls.Clear();
            pnlCapturedPiece2.Controls.Clear();
            pnlCapturedPiece1.Visible = true;
            pnlCapturedPiece2.Visible = true;

            pnlTimer1.Controls.Clear();
            pnlTimer2.Controls.Clear();
            pnlTimer1.Visible = true;
            pnlTimer2.Visible = true;

            panel1.Visible = true;
            panel1.Controls.Clear();
            clsOptions obj = new clsOptions();
            Board = new UcChessBoard(obj.BoardStyle, obj.PieceStyle, eOwnSide, eGameMode, eDifficulty, obj.CellSize, obj.PieceSize, obj.PlaySound, strFEN);


            pnlTimer1.Controls.Add(UcCountDownTimer1);
            pnlTimer2.Controls.Add(UcCountDownTimer2);

            ucCapturedPieces1.PieceColor = Board.OwnSide;

            if (Board.OwnSide == ChessSide.Black)
                ucCapturedPieces2.PieceColor = ChessSide.White;
            else
                ucCapturedPieces2.PieceColor = ChessSide.Black;

            pnlCapturedPiece1.Controls.Add(ucCapturedPieces1);
            pnlCapturedPiece2.Controls.Add(ucCapturedPieces2);
            pnlHistory.Controls.Add(UcMovesHistory1);

            Board.MoveMaked += new UcChessBoard.MoveMakedHandler(MoveMaked);
            Board.PieceCaptured += new UcChessBoard.PieceCapturedHandler(Board_PieceCaptured);
            ucCapturedPieces1.LoadPieces(Board.stkCapturedPieces);
            ucCapturedPieces2.LoadPieces(Board.stkCapturedPieces);
            UcMovesHistory1.LoadMovesHistory(Board.stkWhiteMoves, Board.stkBlackMoves);
            if (Board.GameMode == GameMode.VsComputer)
                btnHint.Enabled = true;
            else
                btnHint.Enabled = false;

            Bitmap bmpBackImage = new Bitmap(Board.Width, Board.Height);
            Board.DrawToBitmap(bmpBackImage, Board.Bounds);
            Board.BackgroundImage = bmpBackImage;
            Board.BoardBitMap = bmpBackImage;

            intNotationSize = (int)((obj.CellSize * 38) / 100);
            this._GameMode = GameMode.VsComputer;
            this._OwnSide = ChessSide.White;
            AddNotation(obj.CellSize, eOwnSide);

            Board.Location = new Point(intNotationSize, intNotationSize);
            this.panel1.Controls.Add(Board);
            this.panel1.ClientSize = new Size(obj.CellSize * 8 + intNotationSize * 2, obj.CellSize * 8 + intNotationSize * 2);

            pnlCapturedPiece1.Size = ucCapturedPieces1.Size;
            pnlCapturedPiece2.Size = ucCapturedPieces2.Size;


            pnlHistory.Size = UcMovesHistory1.Size;
            int x = this.ClientSize.Width - pnlHistory.Size.Width;
            pnlHistory.Location = new Point(x, panel1.Location.Y);

            UcCountDownTimer1.Size = new Size(110, 35);
            UcCountDownTimer2.Size = new Size(110, 35);
            UcCountDownTimer1.Location = new Point(8, 8);
            UcCountDownTimer2.Location = new Point(8, 8);
            pnlTimer1.Size = new Size(UcCountDownTimer1.Width + 16, UcCountDownTimer1.Height + 16);
            pnlTimer2.Size = pnlTimer1.Size;

            pnlPlayer1.Visible = true;
            pnlPlayer2.Visible = true;

            pnlPlayer1.Location = new Point(5, 3);
            int w = this.ribbonClientPanel1.Height - pnlPlayer2.Height - 10;
            pnlPlayer2.Location = new Point(pnlPlayer1.Location.X, w);

            //Board
            panel1.Location = new Point(pnlPlayer1.Location.X + pnlPlayer1.Width + 5, pnlPlayer1.Location.Y);
            pnlCapturedPiece1.Location = new Point(panel1.Location.X + panel1.Size.Width + 3, panel1.Location.Y + 2);
            pnlCapturedPiece2.Location = new Point(panel1.Location.X + panel1.Size.Width + 3, this.ribbonClientPanel1.Height - pnlCapturedPiece2.Height - 2);

            if (Board.OwnSide == ChessSide.White)
                UcCountDownTimer2.StartTimer();
            else
                UcCountDownTimer1.StartTimer();
        }

        void UcCountDownTimer2_TimeOut(object sender, EventArgs e)
        {
            if (Board == null)
                return;
            Board.Enabled = false;
            btnHint.Enabled = false;
            btnUndo.Enabled = false;
            MessageBox.Show("Bạn Đã Thua Do Hết Thời Gian !!!");
        }

        void UcCountDownTimer1_TimeOut(object sender, EventArgs e)
        {
            if (Board == null)
                return;
            Board.Enabled = false;
            btnHint.Enabled = false;
            btnUndo.Enabled = false;
            MessageBox.Show("Đối Thủ Đã Hết Thời Gian !!!");
        }
        void MoveMaked(object sender, EventArgs e)
        {
            if (Board == null)
                return;



            if (Board.GameMode == GameMode.VsComputer)
            {
                Board.Enabled = true;
                if ((Board.WhiteToMove == true && Board.OwnSide == ChessSide.White) || (Board.WhiteToMove == false && Board.OwnSide == ChessSide.Black))
                {
                    btnSaveGame.Enabled = true;
                    btnHint.Enabled = true;
                    btnUndo.Enabled = true;
                }
                else
                {
                    btnSaveGame.Enabled = true;
                    btnHint.Enabled = false;
                    btnUndo.Enabled = false;
                }
                if (Board.GameStatus != GameStatus.NowPlaying)
                    btnHint.Enabled = false;
            }
            else
            {
                Board.Enabled = true;
                btnSaveGame.Enabled = true;
                btnUndo.Enabled = true;
            }

            UcMovesHistory1.LoadMovesHistory(Board.stkWhiteMoves, Board.stkBlackMoves);
            if ((Board.WhiteToMove == true && Board.OwnSide == ChessSide.Black) || (Board.WhiteToMove == false && Board.OwnSide == ChessSide.White))
            {
                UcCountDownTimer2.StopTimer();
                UcCountDownTimer1.StartTimer();
                UcCountDownTimer2.TimeBonus(TimeBonus);
            }
            if ((Board.WhiteToMove == true && Board.OwnSide == ChessSide.White) || (Board.WhiteToMove == false && Board.OwnSide == ChessSide.Black))
            {
                UcCountDownTimer1.StopTimer();
                UcCountDownTimer2.StartTimer();
                UcCountDownTimer1.TimeBonus(TimeBonus);
            }
            if (Board.GameStatus != GameStatus.NowPlaying)
            {
                UcCountDownTimer1.StopTimer();
                UcCountDownTimer2.StopTimer();
                Board.Enabled = false;
            }
        }


        void Board_PieceCaptured(object sender, EventArgs e)
        {
            ucCapturedPieces1.LoadPieces(Board.stkCapturedPieces);
            ucCapturedPieces2.LoadPieces(Board.stkCapturedPieces);
        }



        void AddNotation(int intCellSize, ChessSide eOwnSide)
        {

            for (int i = 0; i < 36; i++)
            {
                lblNotation[i] = new Label();
                lblNotation[i].Height = intCellSize;
                lblNotation[i].Width = intCellSize;
                lblNotation[i].Image = clsImageProcess.GetChessBoardBitMap(ChessSide.Black, ChessBoardStyle.BoardEdge);

                lblNotation[i].TextAlign = ContentAlignment.MiddleCenter;
                lblNotation[i].Font = new Font(FontFamily.GenericSansSerif, 14.0f);
                lblNotation[i].ImageAlign = ContentAlignment.MiddleCenter;
                lblNotation[i].ForeColor = Color.White;
            }

            lblNotation[0].Height = intNotationSize;
            lblNotation[0].Width = intNotationSize;
            lblNotation[0].Location = new Point();
            lblNotation[0].BackColor = Color.Blue;
            panel1.Controls.Add(lblNotation[0]);

            for (int i = 1; i <= 8; i++)
            {
                lblNotation[i].Height = intNotationSize;
                if (eOwnSide == ChessSide.White)
                {
                    lblNotation[i].Text = Convert.ToChar(64 + i).ToString();
                }
                else
                {
                    lblNotation[i].Text = Convert.ToChar(73 - i).ToString();
                }
                lblNotation[i].Location = new Point(intCellSize * (i - 1) + intNotationSize, 0);
                panel1.Controls.Add(lblNotation[i]);
            }
            lblNotation[9].Height = intNotationSize;
            lblNotation[9].Width = intNotationSize;
            lblNotation[9].BackColor = Color.Blue;
            lblNotation[9].Location = new Point(0, intNotationSize + intCellSize * 8);
            panel1.Controls.Add(lblNotation[9]);

            for (int i = 1; i <= 8; i++)
            {
                lblNotation[9 + i].Height = intNotationSize;
                if (eOwnSide == ChessSide.White)
                {
                    lblNotation[9 + i].Text = Convert.ToChar(64 + i).ToString();
                }
                else
                {
                    lblNotation[9 + i].Text = Convert.ToChar(73 - i).ToString();
                }
                lblNotation[9 + i].Location = new Point(intCellSize * (i - 1) + intNotationSize, intNotationSize + intCellSize * 8);
                panel1.Controls.Add(lblNotation[9 + i]);
            }
            lblNotation[18].Height = intNotationSize;
            lblNotation[18].Width = intNotationSize;
            lblNotation[18].BackColor = Color.Blue;
            lblNotation[18].Location = new Point(intNotationSize + intCellSize * 8, 0);
            panel1.Controls.Add(lblNotation[18]);

            for (int i = 1; i <= 8; i++)
            {
                lblNotation[18 + i].Width = intNotationSize;
                if (eOwnSide == ChessSide.White)
                {
                    lblNotation[18 + i].Text = Convert.ToString(9 - i);
                }
                else
                {
                    lblNotation[18 + i].Text = Convert.ToString(i);
                }
                lblNotation[18 + i].Location = new Point(0, intCellSize * (i - 1) + intNotationSize);
                panel1.Controls.Add(lblNotation[18 + i]);
            }

            lblNotation[27].Height = intNotationSize;
            lblNotation[27].Width = intNotationSize;
            lblNotation[27].BackColor = Color.Blue;
            lblNotation[27].Location = new Point(intNotationSize + intCellSize * 8, intNotationSize + intCellSize * 8);
            panel1.Controls.Add(lblNotation[27]);
            for (int i = 1; i <= 8; i++)
            {
                lblNotation[27 + i].Width = intNotationSize;
                if (eOwnSide == ChessSide.White)
                {
                    lblNotation[27 + i].Text = Convert.ToString(9 - i);
                }
                else
                {
                    lblNotation[27 + i].Text = Convert.ToString(i);
                }
                lblNotation[27 + i].Location = new Point(intNotationSize + intCellSize * 8, intCellSize * (i - 1) + intNotationSize);
                panel1.Controls.Add(lblNotation[27 + i]);
            }

        }

        private void ribbonClientPanel1_Click(object sender, EventArgs e)
        {

        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveGame_Click(object sender, EventArgs e)
        {
            if (Board != null && Board.stkWhiteMoves.Count > 0) //&& (Board.stkWhiteMoves.Count >= Board.stkBlackMoves.Count))
            {
                SaveFileDialog dlg = new SaveFileDialog();

                dlg.Filter = "Saved Game|*.sav";
                string savedir = Application.StartupPath + "\\Saved Games";
                if (Directory.Exists(savedir) == false)
                    Directory.CreateDirectory(savedir);
                dlg.InitialDirectory = savedir;
                if (dlg.ShowDialog() != DialogResult.Cancel)
                {
                    string FEN = clsFEN.GetFEN(Board);
                    string strMoveList = GetMoveList(Board.stkWhiteMoves, Board.stkBlackMoves);
                    clsSavedGame save = new clsSavedGame(Board.GameMode, Board.Difficulty, Board.OwnSide, FEN, strMoveList);

                    save.TimeLimit = TimeLimit;
                    save.TimeBonus = TimeBonus;
                    save.MinutesRemaining1 = UcCountDownTimer1.Minute;
                    save.MinutesRemaining2 = UcCountDownTimer2.Minute;
                    save.SecondsRemaining1 = UcCountDownTimer1.Second;
                    save.SecondsRemaining2 = UcCountDownTimer2.Second;
                    if (File.Exists(dlg.FileName))
                    {
                        File.SetAttributes(dlg.FileName, FileAttributes.Normal);
                        File.Delete(dlg.FileName);
                    }
                    save.SaveToFile(dlg.FileName);
                }
            }
        }
        string GetMoveList(Stack stkWhite, Stack stkBlack)
        {
            StringBuilder str = new StringBuilder();

            Stack MoveList = new Stack();
            if (stkWhite.Count > stkBlack.Count)
            {
                MoveList.Push(stkBlack.Pop());
            }
            //Lúc này 2 Stack bằng nhau
            while (stkWhite.Count > 0)
            {
                MoveList.Push(stkBlack.Pop());
                MoveList.Push(stkWhite.Pop());
            }

            foreach (string s in MoveList)
            {
                str.Append(s);
                str.Append(' ');
            }
            return str.ToString().Trim();
        }

        private void btnLoadGame_Click(object sender, EventArgs e)
        {
            try
            {
                frmLoadGame frm = new frmLoadGame();
                bool K = true, Q = true, k = true, q = true;
                if (Board != null)
                {
                    K = UcChessBoard.KINGsideCastling;
                    Q = UcChessBoard.QUEENsideCastling;
                    k = UcChessBoard.kingsideCastling;
                    q = UcChessBoard.queensideCastling;
                }

                DialogResult dr = frm.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    clsSavedGame sav = frm.SavedGame;
                    if (sav != null)
                    {
                        GameMode eGameMode = sav.GameMode;
                        GameDifficulty eDiff = sav.GameDifficulty;
                        ChessSide eOwnSide = sav.OwnSide;
                        string Fen = sav.FEN;
                        string strMoveList = sav.MoveList;

                        this.TimeLimit = sav.TimeLimit;
                        this.TimeBonus = sav.TimeBonus;

                        //string[] s = strMoveList.Trim().Split(' ');
                        //if (s[0] != "")
                        //{
                        //    //if (eGameMode == GameMode.VsComputer)
                        //    //    CreateChessBoard(eOwnSide, GameMode.VsNetWorkPlayer, eDiff, clsFEN.DefaultFENstring);
                        //    //else
                        //    //    CreateChessBoard(eOwnSide, eGameMode, clsFEN.DefaultFENstring);
                        //    //bool bSound = Board.PlaySound;
                        //    //bool bMess = Board.ShowMessage;
                        //    //Board.PlaySound = false;
                        //    //frmMessageBox.ShowMessage = false;
                        //    //Board.ShowMessage = false;
                        //    //foreach (string str in s)
                        //    //{
                        //    //    Board.MakeMove(str.Remove(2, 1));
                        //    //}
                        //    //Board.PlaySound = bSound;
                        //    //Board.ShowMessage = bMess;
                        //    //Board.GameMode = eGameMode;
                        //}
                        //else
                        //{
                        if (eGameMode == GameMode.VsComputer)
                            CreateChessBoard(eOwnSide, eGameMode, eDiff, Fen);
                        else
                            CreateChessBoard(eOwnSide, eGameMode, Fen);
                        //}

                        UcCountDownTimer1.Minute = sav.MinutesRemaining1;
                        UcCountDownTimer1.Second = sav.SecondsRemaining1;
                        UcCountDownTimer2.Minute = sav.MinutesRemaining2;
                        UcCountDownTimer2.Second = sav.SecondsRemaining2;

                        frmMessageBox.ShowMessage = true;

                    }

                }
                else
                {
                    UcChessBoard.KINGsideCastling = K;
                    UcChessBoard.QUEENsideCastling = Q;
                    UcChessBoard.kingsideCastling = k;
                    UcChessBoard.queensideCastling = q;
                }
            }
            catch { }
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            string strFEN = "";
            if (Board != null)
            {
                strFEN = clsFEN.GetFEN(Board);
            }

            frmOptions frm = new frmOptions();
            if (frm.ShowDialog() == DialogResult.OK && Board != null)
            {

                this._OwnSide = Board.OwnSide;
                this._GameMode = Board.GameMode;
                Stack Black, White, State;

                Black = (Stack)Board.stkBlackMoves.Clone();
                White = (Stack)Board.stkWhiteMoves.Clone();
                State = (Stack)Board.stkState.Clone();

                Stack Captured = new Stack();
                foreach (UcChessPiece piece in Board.stkCapturedPieces)
                {
                    UcChessPiece p = new UcChessPiece();
                    p.PositionX = piece.PositionX;
                    p.PositionY = piece.PositionY;
                    p.Location = piece.Location;
                    p.Side = piece.Side;
                    p.Type = piece.Type;
                    Captured.Push(p);
                }

                if (this._GameMode == GameMode.VsComputer)
                {
                    GameDifficulty diff = Board.Difficulty;

                    short m1, s1, m2, s2;
                    m1 = UcCountDownTimer1.Minute;
                    m2 = UcCountDownTimer2.Minute;
                    s1 = UcCountDownTimer1.Second;
                    s2 = UcCountDownTimer2.Second;
                    CreateChessBoard(this._OwnSide, this._GameMode, diff, strFEN);
                    UcCountDownTimer1.Minute = m1;
                    UcCountDownTimer2.Minute = m2;
                    UcCountDownTimer1.Second = s1;
                    UcCountDownTimer2.Second = s2;
                }
                else
                {

                    short m1, s1, m2, s2;
                    m1 = UcCountDownTimer1.Minute;
                    m2 = UcCountDownTimer2.Minute;
                    s1 = UcCountDownTimer1.Second;
                    s2 = UcCountDownTimer2.Second;
                    CreateChessBoard(this._OwnSide, this._GameMode, strFEN);
                    UcCountDownTimer1.Minute = m1;
                    UcCountDownTimer2.Minute = m2;
                    UcCountDownTimer1.Second = s1;
                    UcCountDownTimer2.Second = s2;
                }
                Board.stkBlackMoves = Black;
                Board.stkWhiteMoves = White;
                Board.stkState = State;
                clsOptions obj = new clsOptions();
                foreach (UcChessPiece piece in Captured)
                {
                    UcChessPiece p = new UcChessPiece(piece.Side, piece.Type, obj.PieceStyle, obj.CellSize, obj.PieceSize, piece.PositionX, piece.PositionY, Board.arrChessCell[piece.PositionX, piece.PositionY]);
                    Board.stkCapturedPieces.Push(p);
                }

                ucCapturedPieces1.LoadPieces(Board.stkCapturedPieces);
                ucCapturedPieces2.LoadPieces(Board.stkCapturedPieces);
                UcMovesHistory1.LoadMovesHistory(Board.stkWhiteMoves, Board.stkBlackMoves);
            }
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            frmManageProfile frm = new frmManageProfile();
            frm.ShowDialog();
        }




        private void btnNewGame_Click(object sender, EventArgs e)
        {

            frmSelectGame frm = new frmSelectGame();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ChessSide eOwnSide = frm.eOwnSide;
                GameMode eGameMode = frm.eGameMode;
                GameDifficulty eDifficulty = frm.eDifficulty;
                string strFen = clsFEN.DefaultFENstring;

                this.TimeLimit = frm.TimeLimit;
                this.TimeBonus = frm.TimeBonus;

                if (eGameMode == GameMode.VsComputer)
                    CreateChessBoard(eOwnSide, eGameMode, eDifficulty, strFen);
                else
                    CreateChessBoard(eOwnSide, eGameMode, strFen);
                frmMessageBox.ShowMessage = true;

                PlayMusic(soundNewGame);
            }
            frm.Dispose();

        }
        public void PlayMusic(SoundPlayer sound)
        {
            if (Board == null)
                return;
            if (Board.PlaySound == true)
            {
                sound.Play();
            }
        }

        private void buttonStyleOffice2007Blue_Click(object sender, EventArgs e)
        {

        }

        private void AppCommandTheme_Executed(object sender, EventArgs e)
        {
            ICommandSource source = sender as ICommandSource;
            if (source.CommandParameter is string)
            {
                eOffice2007ColorScheme colorScheme = (eOffice2007ColorScheme)Enum.Parse(typeof(eOffice2007ColorScheme), source.CommandParameter.ToString());
                // This is all that is needed to change the color table for all controls on the form
                ribbonControl1.Office2007ColorTable = colorScheme;
            }
            else if (source.CommandParameter is Color)
            {
                RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(this, m_BaseColorScheme, (Color)source.CommandParameter);
            }
            this.Invalidate();
        }

        private void btnHint_Click(object sender, EventArgs e)
        {
            if (Board == null)
                return;
            if ((Board.WhiteToMove == true && Board.OwnSide == ChessSide.White) || (Board.WhiteToMove == false && Board.OwnSide == ChessSide.Black))
            {
                btnHint.Enabled = false;
                //if (Board.WhiteToMove == true)
                //    Board.WhiteToMove = false;
                //else
                //    Board.WhiteToMove = true ;
                Board.Enabled = false;
                Board.Computer_Move(Board.OwnSide, Board.Difficulty);

            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (Board != null && (Board.stkBlackMoves.Count > 0 || Board.stkWhiteMoves.Count > 0))
            {


                if (Board.GameMode == GameMode.VsHuman)
                {
                    Board.UnDoMove();
                    ucCapturedPieces1.LoadPieces(Board.stkCapturedPieces);
                    UcMovesHistory1.LoadMovesHistory(Board.stkWhiteMoves, Board.stkBlackMoves);
                }
                else
                {
                    if (Board.IsThinking == true)
                        return;

                    Board.UnDoMove();
                    Board.UnDoMove();
                    ucCapturedPieces1.LoadPieces(Board.stkCapturedPieces);
                    ucCapturedPieces2.LoadPieces(Board.stkCapturedPieces);
                    UcMovesHistory1.LoadMovesHistory(Board.stkWhiteMoves, Board.stkBlackMoves);
                }

                if (Board.stkBlackMoves.Count > 0 || Board.stkWhiteMoves.Count > 0)
                    btnUndo.Enabled = true;
                else
                {
                    btnUndo.Enabled = false;
                }
            }
        }



        private void btnGetFen_Click(object sender, EventArgs e)
        {
            if (Board != null)
            {
                string strFEN = clsFEN.GetFEN(Board);
                Clipboard.SetText(strFEN);

                MessageBox.Show(strFEN, "Đã lưu vào ClipBoard !!!");
            }
        }

        private void btnLanGame_Click(object sender, EventArgs e)
        {
            try
            {
                if (frmMain.localpc.Profile == null)
                {
                    frmManageProfile frm = new frmManageProfile();
                    if (frm.ShowDialog() != DialogResult.OK)
                        return;
                }
                this.Hide();
                frmFindGame frms = new frmFindGame();
                frms.ShowDialog();
                this.Show();
            }
            catch
            {


            }

        }

        private void btnTrainingDatabase_Click(object sender, EventArgs e)
        {
            frmTrainingDatabase frm = new frmTrainingDatabase();
            frm.ShowDialog();
        }

        private void btnTraining_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTraining frm = new frmTraining();
            frm.ShowDialog();
            this.Show();
        }
        SoundPlayer soundNewGame;
        private void frmMain_Load(object sender, EventArgs e)
        {
            soundNewGame = new SoundPlayer(Properties.Resources.NewGame);
            soundNewGame.LoadAsync();

            frmMain.localpc = new ClsPC(28000);
            //frmMain.localpc.ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
        }

        private void btnScreenCapture_Click(object sender, EventArgs e)
        {
            if (Board != null)
            {
                try
                {
                    Bitmap bmp = Board.TakePicture(Board.Width, Board.Height);
                    Clipboard.SetImage(bmp);
                    MessageBox.Show("Đã Lưu ảnh Vào ClipBoard");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btnChessRule_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, Application.StartupPath + "\\LuatCoVua.chm", HelpNavigator.TableOfContents);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            frmFeedBack frm = new frmFeedBack();
            frm.ShowDialog();
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            if (Board != null)
            {
                try
                {
                    SaveFileDialog dlg = new SaveFileDialog();
                    dlg.Filter = "Text File|*.txt";
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter s = new StreamWriter(dlg.FileName);

                        Stack MoveList = new Stack();
                        if (Board.stkWhiteMoves.Count > Board.stkBlackMoves.Count)
                        {
                            MoveList.Push(Board.stkBlackMoves.Pop());
                        }
                        //Lúc này 2 Stack bằng nhau
                        while (Board.stkWhiteMoves.Count > 0)
                        {
                            MoveList.Push(Board.stkBlackMoves.Pop());
                            MoveList.Push(Board.stkWhiteMoves.Pop());
                        }


                        int i = 0;
                        while (MoveList.Count > 0)
                        {
                            string str = "";
                            i++;
                            str += (i + 1) / 2;
                            str += ". ";
                            str += MoveList.Pop().ToString();
                            if (MoveList.Count > 0)
                            {
                                str += " " + MoveList.Pop().ToString();
                            }
                            i++;
                            s.WriteLine(str.ToLower());
                        }

                        s.Close();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }















    }
}