using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Chess_Usercontrol;
namespace Chess_Programming
{
    public partial class frmOptions : DevComponents.DotNetBar.Office2007Form
    {
        clsOptions obj;
        
        public frmOptions()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmOptions_Load(object sender, EventArgs e)
        {
            obj = new clsOptions();
            Load_Options();
      
        }
       
        void Load_Options()
        {
            numCellSize.Value = obj.CellSize;
            numPieceSize.Value = obj.PieceSize;

            cboBoardStyle.SelectedIndex = ((int)obj.BoardStyle) - 1;
            cboPieceStyle.SelectedIndex = ((int)obj.PieceStyle) - 1;

            chkPlaySound.Checked = obj.PlaySound;

            try
            {
                UcChessBoard Board = new UcChessBoard(obj.BoardStyle, obj.PieceStyle, ChessSide.White, GameMode.VsNetWorkPlayer, 48, 48, false, "KQRBNP2/kqrbnp2/8/8/8/8/8/8 w - -");
                pictureBox1.Image = Board.TakePicture(pictureBox1 .Width  ,pictureBox1 .Height  );
                Board.Dispose();
            }
            catch 
            {
                
                
            }
 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            obj.CellSize =(int) numCellSize.Value;
            obj.PieceSize =(int) numPieceSize.Value;

            obj.BoardStyle = (ChessBoardStyle)(cboBoardStyle.SelectedIndex + 1);

            obj.PieceStyle = (ChessPieceStyle )(cboPieceStyle.SelectedIndex + 1);
            
            obj.PlaySound = chkPlaySound.Checked;
            obj.SaveOptions();
            this.Close();

           
            
        }

        private void numPieceSize_ValueChanged(object sender, EventArgs e)
        {
            if (numPieceSize.Value > numCellSize.Value)
                numPieceSize.Value = numCellSize.Value;
        }

        private void numCellSize_ValueChanged(object sender, EventArgs e)
        {
            if (numPieceSize.Value > numCellSize.Value)
                numPieceSize.Value = numCellSize.Value;
        }

        private void cboBoardStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBoardStyle.SelectedIndex == -1 || cboPieceStyle.SelectedIndex == -1)
                return;
            try
            {
                ChessBoardStyle BoardStyle = (ChessBoardStyle)(cboBoardStyle.SelectedIndex + 1);

                ChessPieceStyle  PieceStyle = (ChessPieceStyle)(cboPieceStyle.SelectedIndex + 1);

                UcChessBoard Board = new UcChessBoard(BoardStyle, PieceStyle, ChessSide.White, GameMode.VsNetWorkPlayer, 48, 48, false, "KQRBNP2/kqrbnp2/8/8/8/8/8/8");
                pictureBox1.Image = Board.TakePicture(pictureBox1.Width, pictureBox1.Height);
                Board.Dispose();
            }
            catch
            {


            }
        }

      
    }
}