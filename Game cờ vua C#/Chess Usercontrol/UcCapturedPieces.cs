using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Collections ;
namespace Chess_Usercontrol
{
    public partial class UcCapturedPieces : UserControl
    {
        ChessSide _Color;

        public UcCapturedPieces()
        {
            InitializeComponent();
        }
        public ChessSide PieceColor
        {
            get { return this._Color; }
            set { this._Color = value; }
        }
        //private ArrayList arrPieces= new ArrayList ();

        //public void Add(UcChessPiece Piece)
        //{
        //    arrPieces.Add(Piece);
        //}
        //public void RemoveLastest()
        //{
        //    if (arrPieces.Count == 0)
        //        return;
        //    arrPieces.RemoveAt(arrPieces.Count);
        //}
        //public int PieceCount()
        //{
        //    return arrPieces.Count;
        //}
        public void LoadPieces(Stack  arrPieces)
        {
            for (int i = 0; i < 16; i++)
            {
                Pic[i].Image =null;                
            }            
            
            int index = 0;
            Stack stk = new Stack();

            foreach (UcChessPiece piece in arrPieces)
            {
                stk.Push(piece);             
            }            
            foreach (UcChessPiece  piece in stk )
            {             
                if (piece.Side == this._Color)
                    Pic[index++].Image  = piece.Image;
            }
        }
        PictureBox[] Pic = new PictureBox[16];
        void Initial()
        {
            for (int i = 0; i < 16; i++)
            {
                Pic[i] = new PictureBox();
                Pic[i].SizeMode = PictureBoxSizeMode.StretchImage;
                Pic[i].Size = new Size(30, 30);
                Pic[i].Location = new Point((i % 2) * 30, (i / 2) * 30);
                this.Controls.Add(Pic[i]);
            }
        }

        private void UcCapturedPieces_Load(object sender, EventArgs e)
        {
            Initial();

        }


    }
}
