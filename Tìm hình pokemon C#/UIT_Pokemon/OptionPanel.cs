using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections;

namespace UIT_Pokemon
{
    class OptionPanel : PictureBox
    {
        Timer time = new Timer();
        public Boolean IsSelect = false;
        private int x;
        private int y;
        private int tmp_x;
        public Form1 display;
        Button button1 = new Button();
        Button button2 = new Button();
        Button button3 = new Button();
        Button button4 = new Button();
        Button button5 = new Button();
        Button button6 = new Button();
        public OptionPanel(Form1 display)
        {

            this.display = display;
            this.x = display.ClientRectangle.Width - 17;
            this.y = display.ClientRectangle.Height;
            tmp = x;
            tmp_x = x;
            //this.Size = new Size(110, y);
            this.Anchor = AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            this.MouseEnter += new EventHandler(OnMouseEnter);
            this.MouseLeave += new EventHandler(OnMouseLeave);
            time.Interval = 30;
            this.Location = new Point(x - 5, 0);
            ControlRegion.CreateControl(this, global::UIT_Pokemon.Properties.Resources.option_panel);
            this.Image=global::UIT_Pokemon.Properties.Resources.option_panel;
          
            time.Tick += new EventHandler(OnTimeTick);
            this.Controls.Add(button1);
            this.Controls.Add(button2);
            this.Controls.Add(button3);
            this.Controls.Add(button4);
            this.Controls.Add(button5);
            this.Controls.Add(button6);
            button1.Location = new Point(21, 66);
            button2.Location = new Point(24, 168);
            button3.Location = new Point(25, 271);
            button4.Location = new Point(27, 380);
            button5.Location = new Point(27, 484);
            button6.Location = new Point(28, 586);
            button1.Size = new Size(62, 65);
            button2.Size = new Size(61, 65);
            button3.Size = new Size(61, 65);
            button4.Size = new Size(61, 65);
            button5.Size = new Size(61, 65);
            button6.Size = new Size(61, 65);
            ControlRegion.CreateControl(button1, CollectionImage.Button_option[0]);
            ControlRegion.CreateControl(button2, CollectionImage.Button_option[1]);
            ControlRegion.CreateControl(button3, CollectionImage.Button_option[2]);
            ControlRegion.CreateControl(button4, CollectionImage.Button_option[3]);
            ControlRegion.CreateControl(button5, CollectionImage.Button_option[4]);
            ControlRegion.CreateControl(button6, CollectionImage.Button_option[5]);
            
            button1.Image = CollectionImage.Button_option[0];
            button2.Image = CollectionImage.Button_option[1];
            button3.Image = CollectionImage.Button_option[2];
            button4.Image = CollectionImage.Button_option[3];
            button5.Image = CollectionImage.Button_option[4];
            button6.Image = CollectionImage.Button_option[5];
            button1.MouseEnter += new EventHandler(button1_MouseEnter);
            button2.MouseEnter += new EventHandler(button2_MouseEnter);
            button3.MouseEnter += new EventHandler(button3_MouseEnter);
            button4.MouseEnter += new EventHandler(button4_MouseEnter);
            button5.MouseEnter += new EventHandler(button5_MouseEnter);
            button6.MouseEnter += new EventHandler(button6_MouseEnter);
            button1.MouseLeave += new EventHandler(button1_MouseLeave);
            button2.MouseLeave += new EventHandler(button2_MouseLeave);
            button3.MouseLeave += new EventHandler(button3_MouseLeave);
            button4.MouseLeave += new EventHandler(button4_MouseLeave);
            button5.MouseLeave += new EventHandler(button5_MouseLeave);
            button6.MouseLeave += new EventHandler(button6_MouseLeave);
            button1.MouseClick += new MouseEventHandler(button1_MouseClick);
            button2.MouseClick += new MouseEventHandler(button2_MouseClick);
            button3.MouseClick += new MouseEventHandler(button3_MouseClick);
            button4.MouseClick += new MouseEventHandler(button4_MouseClick);
            button5.MouseClick += new MouseEventHandler(button5_MouseClick);
            button6.MouseClick += new MouseEventHandler(button6_MouseClick);
        }
        /*public void Update(Form1 display)
        {
            this.display = display;
            x = display.ClientRectangle.Width - 20;
            y = display.ClientRectangle.Height;
            tmp_x = x;
            tmp = x;
        }*/
        private int tmp;
        private void button1_MouseEnter(Object obj, EventArgs e)
        {
            button1.Image = CollectionImage.Button_option_choose[0];
        }
        private void button2_MouseEnter(Object obj, EventArgs e)
        {
            button2.Image = CollectionImage.Button_option_choose[1];
        }
        private void button3_MouseEnter(Object obj, EventArgs e)
        {
            button3.Image = CollectionImage.Button_option_choose[2];
        }
        private void button4_MouseEnter(Object obj, EventArgs e)
        {
            button4.Image = CollectionImage.Button_option_choose[3];
        }
        private void button5_MouseEnter(Object obj, EventArgs e)
        {
            button5.Image = CollectionImage.Button_option_choose[4];
        }
        private void button6_MouseEnter(Object obj, EventArgs e)
        {
            button6.Image = CollectionImage.Button_option_choose[5];
        }

        private void button1_MouseLeave(Object obj, EventArgs e)
        {
            button1.Image = CollectionImage.Button_option[0];
        }
        private void button2_MouseLeave(Object obj, EventArgs e)
        {
            button2.Image = CollectionImage.Button_option[1];
        }
        private void button3_MouseLeave(Object obj, EventArgs e)
        {
            button3.Image = CollectionImage.Button_option[2];
        }
        private void button4_MouseLeave(Object obj, EventArgs e)
        {
            button4.Image = CollectionImage.Button_option[3];
        }
        private void button5_MouseLeave(Object obj, EventArgs e)
        {
            button5.Image = CollectionImage.Button_option[4];
        }
        private void button6_MouseLeave(Object obj, EventArgs e)
        {
            button6.Image = CollectionImage.Button_option[5];
        }
        private void button1_MouseClick(Object obj, MouseEventArgs e)
        {
            display.gameLockingUtility();
            KindGameOption optionplay = new KindGameOption(display);
            optionplay.ShowDialog();
            display.fause = false;
            display.PScreen.HideScreen();
            if (display.gameover == false)
                display.time.Start();
            if (display.full == true)
                display.TopMost = true;
            
        }
        private void button2_MouseClick(Object obj, EventArgs e)
        {
            display.gameLockingUtility();
            HelpIntroduction help = new HelpIntroduction(display);
            help.ShowDialog();
            display.fause = false;
            display.PScreen.HideScreen();
            if (display.gameover == false)
                display.time.Start();
            if (display.full == true)
                display.TopMost = true;
        }
        //configutation
        private void button3_MouseClick(Object obj, MouseEventArgs e)
        {
            display.gameLockingUtility();
            OptionControl Conform = new OptionControl(display);
            Conform.ShowDialog();
            Conform.Dispose();
            display.fause = false;
            display.PScreen.HideScreen();
            if (display.gameover == false)
                display.time.Start();
            if (display.full == true)
                display.TopMost = true;
        }

        //high score
        private void button4_MouseClick(Object obj, MouseEventArgs e)
        {
            display.gameLockingUtility();
            HighScore HS = new HighScore(display.KindGame-1);
            HS.ShowDialog();
            HS.Dispose();
            display.fause = false;
            display.PScreen.HideScreen();
            if (display.gameover == false)
                display.time.Start();
            if (display.full == true)
                display.TopMost = true;
        }
        private void button5_MouseClick(Object obj, EventArgs e)
        {
            display.gameLockingUtility();
            LevelCharacter LCharacter = new LevelCharacter(display);
            LCharacter.ShowDialog();
            LCharacter.Dispose();
            display.fause = false;
            display.PScreen.HideScreen();
            if (display.gameover == false)
                display.time.Start();
            if (display.full == true)
                display.TopMost = true;
            try
            {
                GC.SuppressFinalize(LCharacter);
                GC.Collect();
            }
            catch { }
        }
        // about me
        private void button6_MouseClick(Object obj, MouseEventArgs e)
        {
            display.gameLockingUtility();
            About about = new About();
            about.ShowDialog();
            about.Dispose();
            display.fause = false;
            display.PScreen.HideScreen();
            if(display.gameover==false)
                display.time.Start();
            if (display.full == true)
                display.TopMost = true;
        }
        private void OnTimeTick(Object Obj, EventArgs e)
        {
            //y = MainForm.ClientRectangle.Height;
            if (IsSelect == false)
            {
                if (x > tmp_x - 85)
                {
                    x = x - 15;
                    this.Location = new Point(x, 0);
                    tmp = x;
                }
                else
                {
                    /*if (tmp <= tmp_x - 85)
                    {
                        tmp = tmp + 3;
                        this.Location = new Point(tmp, 0);
                    }*/
                    //else
                    {
                        time.Stop();
                        IsSelect = true;
                        x = tmp;
                    }
                }
            }
            else
            {
                x = x + 5; 

                this.Location = new Point(x, 0);
                //this.Size = new Size(80, y);
                if (x >= tmp_x+3)
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
            if (display.effect == true)
                time.Start();
            else
            {
                this.Location = new Point(tmp_x - 85, 0);
                IsSelect = true;
            }
        }
        public void locker()
        {
            if (display.effect == true)
                time.Start();
            else
            {
                this.Location = new Point(tmp_x+5 , 0);
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
