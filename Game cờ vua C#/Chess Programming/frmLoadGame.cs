using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.IO;
using Chess_Usercontrol;

namespace Chess_Programming
{
    public partial class frmLoadGame : DevComponents.DotNetBar.Office2007Form
    {
        public frmLoadGame()
        {
            InitializeComponent();
            
        }
        string SavePath = Application.StartupPath + "\\Saved Games";
        public clsSavedGame SavedGame = null;
        private void frmLoadGame_Load(object sender, EventArgs e)
        {
            LoadFiles();
            
        }

        void LoadFiles()
        {
            try
            {
                listBox1.Items.Clear();
                if (Directory.Exists(SavePath) == false)
                {
                    Directory.CreateDirectory(SavePath);
                }

                DirectoryInfo dir = new DirectoryInfo(SavePath);
                
                foreach (FileInfo file in dir.GetFiles("*.sav"))
                {                    
                    listBox1.Items.Add(Path.GetFileName(file.FullName));
                }
            }
            catch (Exception ex)
            {                
                MessageBox.Show (ex.Message );
            }
            
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string fname = listBox1.SelectedItem.ToString();
                DataTable tbl = clsXMLProcess.GetTable(SavePath + "\\" + fname);
                DataRow r = tbl.Rows[0];
                SavedGame = new clsSavedGame();
                SavedGame.GameMode = (GameMode)Convert.ToInt32(r["GameMode"]);
                SavedGame.GameDifficulty = (GameDifficulty)Convert.ToInt32(r["GameDifficulty"]);
                SavedGame.OwnSide = (ChessSide)Convert.ToInt32(r["Ownside"]);
                SavedGame.FEN = r["FEN"].ToString();
                SavedGame.MoveList = r["MoveList"].ToString();
                SavedGame.TimeBonus = Convert.ToInt16(r["TimeBonus"]);
                SavedGame.TimeLimit= Convert.ToInt16(r["TimeLimit"]);
                SavedGame.MinutesRemaining1 = Convert.ToInt16(r["mRemain1"]);
                SavedGame.MinutesRemaining2 = Convert.ToInt16(r["mRemain2"]);
                SavedGame.SecondsRemaining1  = Convert.ToInt16(r["sRemain1"]);
                SavedGame.SecondsRemaining2  = Convert.ToInt16(r["sRemain2"]);

                lblFileName.Text = listBox1.SelectedItem.ToString();
                Fen2Pic(SavedGame.FEN);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        void Fen2Pic(string strFEN)
        {
            int size = pictureBox1.Width / 8;
            clsOptions obj = new clsOptions();

            UcChessBoard board = new UcChessBoard(obj.BoardStyle, obj.PieceStyle, ChessSide.White, GameMode.VsNetWorkPlayer, size, size, false, strFEN);
            Bitmap bmp = board.TakePicture(size * 8, size * 8);
            pictureBox1.Image = bmp;
            board.Dispose();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn Chưa Chọn File Cần Xóa !!!");
                return;
            }

            if (MessageBox.Show("Bạn Có Muốn Xóa Không ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string fname = SavePath +"\\"+ listBox1.SelectedItem.ToString();
                File.SetAttributes(fname, FileAttributes.Normal);
                File.Delete(fname);
                LoadFiles();
                MessageBox.Show("Xóa Thành Công !!!");
            }
        }

        private void btnLoadGame_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn Chưa Chọn File Cần Nạp !!!");
                return;
            }
            this.Close();
        }



    }
}