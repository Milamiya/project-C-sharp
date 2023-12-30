using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;


namespace UIT_Pokemon
{

    class NextLevelEffect : PictureBox
    {
        Form1 form;
        Bitmap bit = null;
        Bitmap locked;
        Bitmap image = null;
        private Timer time;
        private Timer timeAdd;
        private 
        int dem = 9;
        String str;
        private bool ActiveTimeAdd = true;
        public NextLevelEffect(Form1 form)
        {
            this.form = form;
            this.Size = new Size(350, 400);
            this.Location = new Point(460, 220);
            time = new Timer();
            time.Interval = 120;
            this.DoubleBuffered = true;
            time.Tick += new EventHandler(time_Tick);
            this.Image = CollectionImage.PokemonLevel[17];// locked;
            this.BackColor = Color.FromArgb(2, 0, 1);
            locked = global::UIT_Pokemon.Properties.Resources._lock;
            this.Hide();
            timeAdd = new Timer();
            timeAdd.Interval = 40;
            timeAdd.Tick+=new EventHandler(timeAdd_Tick);

        }
        public int total=0,_total=0;
        int _randomclick;
        int randomclick;
        int helpclick;
        int _helpclick;
        int percent;
        int _percent;
        int smarteye;
        int _smarteye;
        bool finish;
        public void AdditionScore()
        {
            smarteye = form.SmartEye;
            randomclick = form.RandomPokemonClick;
            helpclick = form.HelpPokemonClick;
            percent = form.percent;
            int sum = percent * 6 + smarteye * 10;
            _total = sum - sum * randomclick * 4 / 100 - sum * helpclick * 2 / 100;
            total = 0;
            timeAdd.Start();
        }
        public void Reset()
        {
            finish = false;
            _randomclick = _percent = _smarteye = _helpclick = 0;
            total = 0;
            if (Information.imageFileLevel.ImageLevel != null)
                bit = Information.imageFileLevel.ImageLevel;
            else
                bit = global::UIT_Pokemon.Properties.Resources.Full;
            ActiveTimeAdd = true;
            bit.MakeTransparent(bit.GetPixel(0, 0));
            this.Image = CollectionImage.PokemonLevel[17];
            image = locked;
            dem = 9;
            str = Information.StringLock;
            this.Hide();
        }
        public void NonAction()
        {
            image = null;
            bit = null;
            Information.LockNextButton = false;
        }
        public void Action()
        {
            form.NextLevel.Visible = false;
            Reset();
            AdditionScore();
            this.Show();
            timeAdd.Start();
        }
        private void timeAdd_Tick(Object obj,EventArgs e)
        {
            if (finish == false)
            {
                if (_percent < percent)
                {
                    _percent++;
                    form.UpdatePercent();
                    // total = _percent * 6;
                }
                else if (_percent == percent)
                {
                    if (_smarteye < smarteye)
                    {
                        _smarteye++;
                        //total = _percent * 6 + _smarteye * 10;
                    }
                    else if (_smarteye == smarteye)
                    {
                        if (_helpclick < helpclick)
                            _helpclick++;
                        else if (_helpclick == helpclick)
                        {
                            if (_randomclick < randomclick)
                            {
                                _randomclick++;
                                // total = (_percent * 6 + _smarteye * 10)*(_helpclick*);
                            }
                            else if (_randomclick == randomclick)
                            {
                                total = _total;
                                this.Invalidate();
                                form.UpdateScore();
                                finish = true;
                            }
                        }
                    }
                }
                this.Invalidate();
            }
            else
            {
                timeAdd.Stop();
                finish = false;
                Information.LockNextButton = false;
                form.NextLevel.Visible = true;
                //System.Threading.Thread.Sleep(1000);
                
            }
            
        }
        public void Clickmore()
        {
            ActiveTimeAdd = false;
            form.NextLevel.Visible = false;
            time.Start();
        }
        #region time_tick
        private void time_Tick(Object obj, EventArgs e)
        {
            dem++;
            if (dem < 10)
                return;
            if (dem >= 10 && dem <= 27)
            {
                this.Image = CollectionImage.PokemonLevel[dem - 10];
                if (dem == 18)
                {
                    str = Information.StringLevel +" "+ Information.Level.ToString()+" " + Information.StringUnlock;
                    image = bit;

                }
            }
            else if (dem <= 40 + 72)
            {
                time.Interval = 20;
                this.Invalidate();
            }
            else if (dem <= 40 + 72 + 7)
            {
                time.Interval = 130;
                return;
            }
            else if (dem <= 40 + 73 + 7 + 17)
            {

                this.Image = CollectionImage.PokemonLevel[dem - 40 - 73 - 7];
                //time.Stop();
                //dem = 0;
            }
            else
            {
                time.Stop();
                NonAction();
                form.NextLevel.Visible = true;
            }
        }
        #endregion

        #region Paint
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.InterpolationMode = InterpolationMode.High;
            DrawImage(g);
            DrawString(g);
        }
        public void DrawImage(Graphics gr)
        {

            LinearGradientBrush br1 = new LinearGradientBrush(new Point(0, 0), new Point(200, 500), Color.BlueViolet, Color.Gold);
            LinearGradientBrush br2 = new LinearGradientBrush(new Point(-50, -50), new Point(500, 400), Color.Black, Color.Brown);
            LinearGradientBrush br3 = new LinearGradientBrush(new Point(-50, -50), new Point(500, 400), Color.Aquamarine, Color.Blue);
            LinearGradientBrush br4 = new LinearGradientBrush(new Point(-50, -50), new Point(500, 400), Color.Cyan, Color.Azure);
            gr.DrawRectangle(new Pen(br1, 6), new Rectangle(10, 10, 300, 330));
            gr.FillRectangle(br2, new Rectangle(14, 14, 300 - 8, 330 - 8));
            if (this.Image != null)
            {
                Bitmap b = (Bitmap)this.Image;
                b.MakeTransparent(b.GetPixel(0, 0));
                if (dem >= 40 && dem < 40 + 73)
                {
                    gr.FillPie(br3, new Rectangle(30, 45, 260, 260), -90, (dem - 40) * 5);
                    gr.FillPie(br1, new Rectangle(40, 55, 240, 240), -90, (dem - 40) * 5);
                }
                else if (dem > 40 + 72 + 7)
                {
                    gr.FillPie(br4, new Rectangle(30, 45, 260, 260), -90, 360);
                    gr.FillPie(br3, new Rectangle(40, 55, 240, 240), -90, 360);
                    gr.DrawImage(b, new Rectangle(45, 60, 200, 200));
                    gr.DrawImage(b, new Rectangle(55, 150, 200, 100));
                    gr.DrawImage(b, new Rectangle(95, 100, 100, 130));
                    gr.DrawImage(b, new Rectangle(130, 60, 100, 130));
                    gr.DrawImage(b, new Rectangle(100, 160, 100, 90));
                    //gr.DrawEllipse(new Pen(br1,10), new Rectangle(35, 50, 250, 250));

                }
                //gr.DrawBezier(new Pen(Brushes.BlueViolet,4),new Point(10,10),)
                gr.DrawImage(image, new Rectangle(55, 65, 220, 220));
                if (dem <= 27)
                {
                    gr.DrawImage(b, new Rectangle(15, 100, 180, 230));
                    gr.DrawImage(b, new Rectangle(10, 20, 230, 200));
                    gr.DrawImage(b, new Rectangle(85, 65, 220, 300));
                }

            }
        }
        public void DrawString(Graphics gr)
        {
            Font fonta = new Font("", 10, FontStyle.Bold);
            Font fontb = new Font("", 25, FontStyle.Bold);
            Font fontc = new Font("", 14, FontStyle.Bold);
            LinearGradientBrush br0 = new LinearGradientBrush(new Point(50, 0), new Point(400, 150), Color.Brown, Color.Azure);
            LinearGradientBrush br = new LinearGradientBrush(new Point(50, 0), new Point(450, 150), Color.Blue, Color.Chocolate);
            LinearGradientBrush br1 = new LinearGradientBrush(new Point(0, 0), new Point(300, 150), Color.GreenYellow, Color.GreenYellow);
            LinearGradientBrush br2 = new LinearGradientBrush(new Point(0, 0), new Point(300, 150), Color.Blue, Color.Blue);
            if (dem < 18)
            {
                gr.DrawString(str, fontb, br0, new Point(73, 348));
                gr.DrawString(str, fontb, br, new Point(75, 350));
            }
            else if (dem > 110)
            {
                gr.DrawString(str, fontb, br0, new Point(11, 348));
                gr.DrawString(str, fontb, br, new Point(10, 350));
            }
            if (ActiveTimeAdd == true)
            {
                int sum = percent * 6 + smarteye * 10;
                //sum=sum-sum*()
                LinearGradientBrush br21 = new LinearGradientBrush(new Point(-50, -50), new Point(500, 400), Color.Black, Color.Brown);
                gr.FillRectangle(br21, new Rectangle(14, 14, 300 - 8, 330 - 8));
                // percent
                gr.DrawString(Information.StringPercent, fonta, br1, new Point(12, 30));
                gr.DrawString((percent-_percent).ToString(), fontc, br1, new Point(157, 25));
                gr.DrawString(_percent.ToString(), fontc, br1, new Point(107, 53));
                gr.DrawString("6", fontc, br1, new Point(177, 53));
                gr.DrawString("=", fontc, br1, new Point(210, 53));
               
                SizeF m = gr.MeasureString((_percent * 6).ToString(),fontc);
                gr.DrawString((_percent*6).ToString(), fontc, br1, new Point(300-(int)m.Width, 53));
                gr.DrawLine(new Pen(br1, 2), new Point(160, 60), new Point(170, 70));
                gr.DrawLine(new Pen(br1, 2), new Point(170, 60), new Point(160, 70));
                // smart eye
                gr.DrawString(Information.StringSmartEye, fonta, br1, new Point(12, 80));
                gr.DrawString(_smarteye.ToString(), fontc, br1, new Point(107, 103));
                gr.DrawString("10", fontc, br1, new Point(177, 103));
                gr.DrawString("=", fontc, br1, new Point(210, 103));
                m = gr.MeasureString((_smarteye * 10).ToString(),fontc);
                gr.DrawString((_smarteye * 10).ToString(), fontc, br1, new Point(300 - (int)m.Width, 103));
                gr.DrawString((smarteye-_smarteye).ToString(), fontc, br1, new Point(157, 75));
                gr.DrawLine(new Pen(br1, 2), new Point(160, 110), new Point(170, 120));
                gr.DrawLine(new Pen(br1, 2), new Point(170, 110), new Point(160, 120));
                // help
                gr.DrawString(Information.StringHelp, fonta, br1, new Point(12, 130));
                gr.DrawString((-_helpclick).ToString(), fontc, br1, new Point(107, 153));
                gr.DrawString("2%", fontc, br1, new Point(177, 153));
                gr.DrawString("=", fontc, br1, new Point(210, 153));
                m = gr.MeasureString(((int)((-_helpclick * 2 * sum) / 100)).ToString(),fontc);
                gr.DrawString(((int)((-_helpclick * 2 * sum) / 100)).ToString(), fontc, br1, new Point(300 - (int)m.Width, 153));
                gr.DrawString((helpclick-_helpclick).ToString(), fontc, br1, new Point(157, 125));
                gr.DrawLine(new Pen(br1, 2), new Point(160, 160), new Point(170, 170));
                gr.DrawLine(new Pen(br1, 2), new Point(170, 160), new Point(160, 170));
                // random
                gr.DrawString(Information.StringRandom, fonta, br1, new Point(12,180 ));
                gr.DrawString((randomclick-_randomclick).ToString(), fontc, br1, new Point(157, 175));
                gr.DrawLine(new Pen(br1, 2), new Point(160, 210), new Point(170, 220));
                gr.DrawLine(new Pen(br1, 2), new Point(170, 210), new Point(160, 220));
                gr.DrawString((-_randomclick).ToString(), fontc, br1, new Point(107, 203));
                gr.DrawString("4%", fontc, br1, new Point(177, 203));
                gr.DrawString("=", fontc, br1, new Point(210, 203));
                m = gr.MeasureString(((int)((-_randomclick * 4 * sum) / 100)).ToString(),fontc);
                gr.DrawString(((int)((-_randomclick * 4 * sum) / 100)).ToString(), fontc, br1, new Point(300 - (int)m.Width, 203));
                gr.DrawLine(new Pen(br,2),new Point(14,230),new Point(240,230));
                gr.DrawString(Information.StringTotal, fonta, br1, new Point(12, 250));
                m = gr.MeasureString(total.ToString(), fontc);
                gr.DrawString(total.ToString(), fontc, br1, new Point(300 - (int)m.Width, 245));
            }
            fontc.Dispose();
            fontb.Dispose();
            fonta.Dispose();
        }
        #endregion
    }
}
