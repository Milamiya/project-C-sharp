/**********************************/
/*                                */
/* Author: BUI VAN NGHIA          */
/* Email: katatunix@yahoo.com     */
/*                 [May, 2008]    */
/*                                */
/**********************************/

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Collections;

namespace Lines2008
{
	class MyPanel : Panel
	{
		public MainForm mainForm;
		public JumpThread jumpThread;
		public MoveThread moveThread;
		public AppearenceThread appearenceThread;
		public DestructionThread destructionThread;
		public TimeThread timeThread;

		public Piece[,] pieces = new Piece[9, 9];
		public PictureBox background = new PictureBox();
		public PictureBox[] nextColor = new PictureBox[3];
		public PictureBox[] YScore = new PictureBox[5];
		public PictureBox[] HScore = new PictureBox[5];
		public PictureBox hours = new PictureBox();
		public PictureBox minutes1 = new PictureBox();
		public PictureBox minutes2 = new PictureBox();
		public PictureBox seconds1 = new PictureBox();
		public PictureBox seconds2 = new PictureBox();

		public GameShape gameShape;
		bool isSelected;
		public bool isLocking;
		int colSelected, rowSelected;

		int[,] oldMatrix = new int[9, 9];
		int oldScores;

		public MyPanel(MainForm mainForm)
		{
			this.mainForm = mainForm;

			this.Location = new Point(0, 24);
			this.Size = new Size(SkinConstants.BKGSize.Width, SkinConstants.BKGSize.Height);

			buildPieces();
			buildYScore();
			buildHScore();
			buildNextColor();
			
			buildHour();
			buildMinutes();
			buildSeconds();
			
			buildBackground();

			newGame();
		}

		public void newGame()
		{
			applyGameShape(GameShape.getDefault());
		}

		public void applyGameShape(GameShape gameShape)
		{
			this.gameShape = gameShape;
			isSelected = false;
			isLocking = false;
			mainForm.setStepBack(false);
			stopAllThread();
			timeThread = new TimeThread(this);

			int[,] matrix = gameShape.matrix;

			repaintPieces(matrix);
			repaintNextColor(matrix);
			repaintYScore(gameShape.scores);
			repaintHScore(HighScoresFunctions.getMaxScores());
			repaintHour(gameShape.hours);
			repaintMinutes(gameShape.minutes);
			repaintSeconds(gameShape.seconds);
		}

		private void stopAllThread()
		{
			if (jumpThread != null) jumpThread.Stop();
			if (moveThread != null) moveThread.Stop();
			if (appearenceThread != null) appearenceThread.Stop();
			if (destructionThread != null) destructionThread.Stop();
			if (timeThread != null) timeThread.Stop();
		}

		private void buildBackground()
		{
			background.Location = new Point(0, 0);
			background.Size = new Size(SkinConstants.BKGSize.Width, SkinConstants.BKGSize.Height);
			background.Image = new Bitmap(SkinConstants.BKG);
			background.MouseClick += new MouseEventHandler(background_MouseClick);

			this.Controls.Add(background);
		}

		private void buildPieces()
		{
			for (int i = 0; i < 9; i++)
				for (int j = 0; j < 9; j++)
				{
					pieces[i, j] = new Piece(i, j);
					pieces[i, j].Click += new System.EventHandler(this.piece_Click);
					this.Controls.Add(pieces[i, j]);
				}
		}

		public void repaintPieces(int[,] matrix)
		{
			for (int i = 0; i < 9; i++)
				for (int j = 0; j < 9; j++)
					if (matrix[i, j] == 0)
					{
						pieces[i, j].Visible = false;
						pieces[i, j].color = 0;
					}
					else if (matrix[i, j] > 0)
					{
						pieces[i, j].Visible = true;
						pieces[i, j].color = matrix[i, j];
						pieces[i, j].setNormal();
					}
					else
					{
						pieces[i, j].Visible = true;
						pieces[i, j].color = matrix[i, j];
						pieces[i, j].setHint();
					}
		}

		private void buildNextColor()
		{
			for (int i = 0; i < 3; i++)
			{
				nextColor[i] = new PictureBox();
				nextColor[i].Location = SkinConstants.NextColor[i];
				nextColor[i].Size = SkinConstants.NextColorSize;
				this.Controls.Add(nextColor[i]);
			}
		}

		public void repaintNextColor(int[,] matrix)
		{
			int count = 0;
			for (int i = 0; i < 9; i++)
				for (int j = 0; j < 9; j++)
					if (matrix[i, j] < 0)
					{
						nextColor[count++].Image = ClippingImage.bitmapNextColor[-matrix[i, j] - 1];
					}
		}

		private void buildYScore()
		{
			for (int i = 0; i < 5; i++)
			{
				YScore[i] = new PictureBox();
				YScore[i].Location = SkinConstants.getLocationOfYScore(i);
				YScore[i].Size = SkinConstants.YScoreDigitSize;
				this.Controls.Add(YScore[i]);
			}
		}

		public void repaintYScore(int score)
		{
			int[] digit = Algorithms.splitNumber(score, 5);
			for (int i = 0; i < 5; i++)
				YScore[i].Image = ClippingImage.bitmapYScoreDigit[digit[i]];
		}

		private void buildHScore()
		{
			for (int i = 0; i < 5; i++)
			{
				HScore[i] = new PictureBox();
				HScore[i].Location = SkinConstants.getLocationOfHScore(i);
				HScore[i].Size = SkinConstants.HScoreDigitSize;
				this.Controls.Add(HScore[i]);
			}
		}

		public void repaintHScore(int score)
		{
			int[] digit = Algorithms.splitNumber(score, 5);
			for (int i = 0; i < 5; i++)
				HScore[i].Image = ClippingImage.bitmapHScoreDigit[digit[i]];
		}

		private void buildHour()
		{
			hours.Location = SkinConstants.TimePos;
			hours.Size = SkinConstants.TimeDigitSize;
			this.Controls.Add(hours);
		}

		public void repaintHour(int v)
		{
			hours.Image = ClippingImage.bitmapTimeDigit[v];
		}

		private void buildMinutes()
		{
			minutes1.Location = new Point(
				hours.Location.X + hours.Size.Width + 1 + 2 * SkinConstants.TimeAndCommaBetween,
				SkinConstants.TimePos.Y);
			minutes1.Size = SkinConstants.TimeDigitSize;

			minutes2.Location = new Point(
				minutes1.Location.X + minutes1.Size.Width + SkinConstants.TimeBetween,
				SkinConstants.TimePos.Y);
			minutes2.Size = SkinConstants.TimeDigitSize;

			this.Controls.Add(minutes1);
			this.Controls.Add(minutes2);
		}

		public void repaintMinutes(int v)
		{
			int[] digit = Algorithms.splitNumber(v, 2);
			minutes1.Image = ClippingImage.bitmapTimeDigit[digit[0]];
			minutes2.Image = ClippingImage.bitmapTimeDigit[digit[1]];
		}

		private void buildSeconds()
		{
			seconds1.Location = new Point(
				minutes2.Location.X + minutes2.Size.Width + 1 + 2 * SkinConstants.TimeAndCommaBetween,
				SkinConstants.TimePos.Y);
			seconds1.Size = SkinConstants.TimeDigitSize;

			seconds2.Location = new Point(
				seconds1.Location.X + seconds1.Size.Width + SkinConstants.TimeBetween,
				SkinConstants.TimePos.Y);
			seconds2.Size = SkinConstants.TimeDigitSize;

			this.Controls.Add(seconds1);
			this.Controls.Add(seconds2);
		}

		public void repaintSeconds(int v)
		{
			int[] digit = Algorithms.splitNumber(v, 2);
			seconds1.Image = ClippingImage.bitmapTimeDigit[digit[0]];
			seconds2.Image = ClippingImage.bitmapTimeDigit[digit[1]];
		}

		private void piece_Click(object sender, EventArgs e)
		{
			if (isLocking) return;
			Piece piece = sender as Piece;
			if (!isSelected && piece.color < 0) return;

			if (!isSelected)
			{
				newJump(piece);
				isSelected = true;
			}
			else if (piece.color < 0)
				moveTo(piece.col, piece.row);
			else
				newJump(piece);
		}

		private void background_MouseClick(object sender, MouseEventArgs e)
		{
			if (isLocking) return;
			Point p = SkinConstants.getColRowIndex(e.X, e.Y);
			if (p.X == -1) return;

			if (gameShape.matrix[p.X, p.Y] != 0)
			{
				piece_Click(pieces[p.X, p.Y], null);
			}
			else
			{
				if (!isSelected) return;
				moveTo(p.X, p.Y);
			}
		}

		private void newJump(Piece piece)
		{
			colSelected = piece.col;
			rowSelected = piece.row;
			if (jumpThread != null) jumpThread.Stop();
			jumpThread = new JumpThread(piece);
		}

		public void moveTo(int newCol, int newRow)
		{
			ArrayList list = Algorithms.havePath(gameShape.matrix, colSelected, rowSelected, newCol, newRow);
			if (list != null)
			{
				jumpThread.Stop();
				moveThread = new MoveThread(this, list);
				isSelected = false;
			}
			else
				if (mainForm.isSound) LinesMediaPlayer.cantmoveSound.Play();
		}

		public void setGameOver()
		{
			if (jumpThread != null) jumpThread.Stop();
			if (timeThread != null) timeThread.Stop();
			Player newPlayer = new Player("", gameShape.scores, gameShape.hours, gameShape.minutes,
				gameShape.seconds);
			Player worstPlayer = HighScoresFunctions.getWorstPlayer();
			if (Player.less(newPlayer, worstPlayer))
			{
				new HighScoresForm().ShowDialog(mainForm);
			}
			else
			{
				new WhatsYourName(gameShape).ShowDialog(mainForm);
			}
			newGame();
		}

		public void backUp()
		{
			for (int i = 0; i < 9; i++)
				for (int j = 0; j < 9; j++)
					oldMatrix[i, j] = gameShape.matrix[i, j];
			oldScores = gameShape.scores;
			mainForm.setStepBack(true);
		}

		public void stepBack()
		{
			if (jumpThread != null) jumpThread.Stop();
			if (moveThread != null) moveThread.Stop();
			if (appearenceThread != null) appearenceThread.Stop();
			if (destructionThread != null) destructionThread.Stop();
			isSelected = false;
			for (int i = 0; i < 9; i++)
				for (int j = 0; j < 9; j++)
					gameShape.matrix[i, j] = oldMatrix[i, j];
			gameShape.scores = oldScores;
			repaintYScore(gameShape.scores);
			repaintPieces(gameShape.matrix);
			repaintNextColor(gameShape.matrix);
			mainForm.setStepBack(false);
		}
	}
}
