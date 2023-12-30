using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections;
using System.Threading;
using System.IO;
namespace UIT_Pokemon
{
    class UtilityPanel : PictureBox
    {
        //Thread thread = new Thread(200);
        System.Windows.Forms.Timer time = new System.Windows.Forms.Timer();
        public Boolean IsSelect = false;
        private int x = 10;
        public Form1 display;
        Button button1 = new Button();
        Button button2 = new Button();
        Button button3 = new Button();
        Button button4 = new Button();
        Button button5 = new Button();
        Button button6 = new Button();
        public UtilityPanel(Form1 display)
        {

            this.display = display;
            this.Controls.Add(button1);
            this.Controls.Add(button2);
            this.Controls.Add(button3);
            this.Controls.Add(button4);
            this.Controls.Add(button5);
            this.Controls.Add(button6);
            //this.Size = new Size(100, MainForm.ClientRectangle.Height);
            this.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;
            this.MouseEnter += new EventHandler(OnMouseEnter);
            this.MouseLeave += new EventHandler(OnMouseLeave);
            time.Interval = 30;
            time.Tick += new EventHandler(OnTimeTick);
            tmp = x;
            button1.Location = new Point(20, 67);
            button2.Location = new Point(20, 178);
            button3.Location = new Point(20, 289);
            button4.Location = new Point(20, 400);
            button5.Location = new Point(20, 506);
            button6.Location = new Point(20, 616);
            button1.Size = new Size(62, 65);
            button2.Size = new Size(61, 65);
            button3.Size = new Size(61, 65);
            button4.Size = new Size(61, 65);
            button5.Size = new Size(61, 65);
            button6.Size = new Size(61, 65);
            button1.Image = CollectionImage.Button_u_Panel[0];
            button2.Image = CollectionImage.Button_u_Panel[1];
            button3.Image = CollectionImage.Button_u_Panel[2];
            button4.Image = CollectionImage.Button_u_Panel[5];
            button5.Image = CollectionImage.Button_u_Panel[4];
            button6.Image = CollectionImage.Button_u_Panel[3];
            button1.MouseEnter += new EventHandler(button1_MouseEnter);
            button2.MouseEnter += new EventHandler(button2_MouseEnter);
            button3.MouseEnter += new EventHandler(button3_MouseEnter);
            button4.MouseEnter += new EventHandler(button4_MouseEnter);
            //button6.MouseEnter += new EventHandler(button6_MouseEnter);
            button1.MouseLeave += new EventHandler(button1_MouseLeave);
            button2.MouseLeave += new EventHandler(button2_MouseLeave);
            button3.MouseLeave += new EventHandler(button3_MouseLeave);
            button4.MouseLeave += new EventHandler(button4_MouseLeave);
            //button6.MouseLeave += new EventHandler(button6_MouseLeave);
            button1.MouseClick += new MouseEventHandler(button1_MouseClick);
            button2.MouseClick += new MouseEventHandler(button2_MouseClick);
            button3.MouseClick += new MouseEventHandler(button3_MouseClick);
            button5.MouseClick += new MouseEventHandler(button5_MouseClick);
            button4.MouseClick += new MouseEventHandler(button4_MouseClick);
            button6.MouseClick += new MouseEventHandler(button6_MouseClick);

            button6.Enabled = false;
            //ControlRegion.CreateGraphicPath(button1, ImageAnimation.Button_u_Panel[0]);
            ControlRegion.CreateControl(this, global::UIT_Pokemon.Properties.Resources.panel1);

            this.Image =global::UIT_Pokemon.Properties.Resources.panel1;
            this.Location = new Point(-90, 0);
            //b.Dispose();
            //this.Invalidate();

        }
        private void button1_MouseEnter(Object obj, EventArgs e)
        {
            button1.Image = CollectionImage.Button_u_Panel_choose[0];
        }
        private void button2_MouseEnter(Object obj, EventArgs e)
        {
            button2.Image = CollectionImage.Button_u_Panel_choose[1];
        }
        private void button3_MouseEnter(Object obj, EventArgs e)
        {
            button3.Image = CollectionImage.Button_u_Panel_choose[2];
        }
        private void button4_MouseEnter(Object obj, EventArgs e)
        {
            button4.Image = CollectionImage.Button_u_Panel_choose[5];
        }

        private void button1_MouseLeave(Object obj, EventArgs e)
        {
            button1.Image = CollectionImage.Button_u_Panel[0];
        }
        private void button2_MouseLeave(Object obj, EventArgs e)
        {
            button2.Image = CollectionImage.Button_u_Panel[1];
        }
        private void button3_MouseLeave(Object obj, EventArgs e)
        {
            button3.Image = CollectionImage.Button_u_Panel[2];
        }
        private void button4_MouseLeave(Object obj, EventArgs e)
        {
            button4.Image = CollectionImage.Button_u_Panel[5];
        }
        //open game
        private void button1_MouseClick(Object obj, MouseEventArgs e)
        {
            OpenFileDialog gameload = new OpenFileDialog();
            gameload.Title = "UIT Pokemon load game";
            gameload.Filter = "Only file (*uitp)|*uitp";
            gameload.InitialDirectory = Information.directories;
            if (gameload.ShowDialog() == DialogResult.OK)
            {
                zipgame zip = LoadSaveGame.LoadGame(gameload.FileName);
                display.LoadGame(zip);
            }
            try
            {
                gameload.Dispose(); 
                GC.SuppressFinalize(gameload);
                GC.Collect();
            }
            catch { }
        }
        //savegame
        private void button2_MouseClick(Object obj, MouseEventArgs e)
        {
            if (display.gameover == true)
                return;
            if (display.LockGame == true)
                return;
            SaveFileDialog gamesave = new SaveFileDialog();
            gamesave.Title = "UIT Pokemon save game";
            gamesave.Filter = "Only file (*uitp)|*uitp";
            gamesave.InitialDirectory = Information.directories;
            if (gamesave.ShowDialog() == DialogResult.OK)
            {
                zipgame zip = display.SaveGame();
                LoadSaveGame.SaveGame(zip, gamesave.FileName+".uitp");
            }
            try
            {
                gamesave.Dispose();
                GC.Collect();
            }
            catch
            {
                // write report file
            }
        }
        //new game
        private void button3_MouseClick(Object obj, MouseEventArgs e)
        {
            DialogResult a = MessageBox.Show("CHƠI MỚI ! (YES/NO)?", "UIT_SOFTWARE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                display.Score = 0;
                display.Level = 1;
                display.argument.Level = 1;
                display.timeplay.Reset();
                display.lifetime.Life = 10 + (display.KindGame - 1) * 5;
                display.NewGame();
                if (display.fause == true)
                {
                    display.fause = false;
                    display.PScreen.HideScreen();
                }
            }
        }
        //tat chuong trinh
        private void button4_MouseClick(Object obj, MouseEventArgs e)
        {
            DialogResult a = MessageBox.Show("TẮT TRÒ CHƠI UIT-POKEMON (YES/NO) ?:", "UIT_SOFTWARE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                display.Close();
            }
        }
        // tuy chon am thanh
        private void button5_MouseClick(Object obj, MouseEventArgs e)
        {
            display.LockSound ^= true;
            if (display.LockSound == false)
                button5.Image = CollectionImage.Button_u_Panel[4];
            else
                button5.Image = CollectionImage.Button_u_Panel_choose[4];
                
        }
        //undo game ne
        private void button6_MouseClick(Object obj, MouseEventArgs e)
        {
            display.ComeBackLastStep();
            button6.Enabled = false;
        }


        private int tmp;
        private void OnTimeTick(Object Obj, EventArgs e)
        {
            //y = MainForm.ClientRectangle.Height;
            if (IsSelect == false)
            {
                if (x < 95)
                {
                    x = x + 15;
                    this.Location = new Point(x - 100, 0);
                    tmp = x;
                }
                else
                {
                    if (tmp >= 105)
                    {
                        tmp = tmp - 2;
                        this.Location = new Point(x - 100, 0);
                    }
                    else
                    {
                        time.Stop();
                        IsSelect = true;
                        x = tmp;
                    }
                }
            }
            else
            {
                x = x - 5; ;

                this.Location = new Point(x - 100, 0);
                if (x <= 13)
                {
                    time.Stop();
                    IsSelect = false;
                }
            }
        }
        private void OnMouseEnter(Object obj, EventArgs e)
        {
            //y = MainForm.ClientRectangle.Height;
            IsSelect = false;
            if (display.LockSound == true)
                button5.Image = CollectionImage.Button_u_Panel_choose[4];
            else
                button5.Image = CollectionImage.Button_u_Panel[4];
            
            if (display.lockBack == false)
                button6.Enabled = true;
            else
                button6.Enabled = false;
            if (display.effect == true)
                time.Start();
            
            else
            {
                this.Location = new Point(0, 0);
                IsSelect = true;
            }

            //this.Visible = true;
            //MessageBox.Show("OK");
        }
        public void locker()
        {
            if (display.effect == true)
                time.Start();
            else
            {
                Location = new Point(-90, 0);
                IsSelect = false;
            }
        }
        private void OnMouseLeave(Object obj, EventArgs e)
        {
            //IsSelect = true;
            //time.Start();
        }
    }
}
