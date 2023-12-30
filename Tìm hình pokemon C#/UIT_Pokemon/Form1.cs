using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace UIT_Pokemon
{
    public partial class Form1 : Form
    {
        private Piece[,] PokemonPiece= new Piece[16,8];
        public int IDWith=16, IDHeight=8;
        private Limittime limittime;
        public Argument argument;
        public bool select = false;
        public bool effect = true;
        private ShapeGame shapegame = new ShapeGame();
        public Timer time = new Timer();
        public WayEffect wayeffect;
        private bool showway = true;
        public bool English = true;
        private List<Point> ListHelp = new List<Point>();
        private int[,] OldMatrix = new int[18, 10];
        private int oldScore=0;
        public TimePlay timeplay = new TimePlay();
        public Timer timeway = new Timer();
        public int Score = 0;
        public int Level =1;
        public int HelpEffect=0;
        public int SmartEye = 0;
        public int KindGame=1;// 1 easy,2 medium, 3 hard
        public bool lockBack = false;
        public bool LockSound = false;
        public bool LockGame = false;
        public bool gameover = false;
        public bool full = false;
        public bool fause=false;
        private bool draw = true;
        public LifeTime lifetime;
        private PictureBox templateScreen;
        RibbonButton RandomPokemon;
        public int RandomPokemonClick=0;
        RibbonButton HelpPokemon;
        public int HelpPokemonClick = 0;
        public PauseScreen PScreen;
        RibbonButton FullScreen;
        public SpecilButton NextLevel;
        public SpecilButton PauseButton;
        int NextClickCount;
        public int percent;
        private UtilityPanel utilitypanel;
        private OptionPanel optionpanel;
        Bitmap ImageLevel = global::UIT_Pokemon.Properties.Resources.findbutton;
        private NextLevelEffect nextLevelEffect;
        public Form1()
        {
            argument= new Argument(this);
            nextLevelEffect = new NextLevelEffect(this);
            this.Controls.Add(nextLevelEffect);
            InitializeComponent();
            InitializePokemon();
            //this.FormBorderStyle = FormBorderStyle.None;

            this.BackColor = Color.FromArgb(2, 0, 1);
            timeway.Interval = Information.timeway;
            timeway.Tick+=new EventHandler(timeway_Tick);
            time.Interval = 1000;
            time.Tick += new EventHandler(time_Tick);
            Information.directories = Directory.GetCurrentDirectory();
            NewGame();
            this.Paint+=new PaintEventHandler(Form1_Paint);
            //this.BackgroundImage = global::UIT_Pokemon.Properties.Resources.Space;
            
        }
        private void Form1_Paint(Object obj, PaintEventArgs e)
        {
            Graphics gp = e.Graphics;
            //gp.DrawImage(new Bitmap("C:\\Users\\Acer\\Desktop\\Space.png"), new Rectangle(140, 10, 300, 500));//new Rectangle((this.Width - global::UIT_Pokemon.Properties.Resources.Space.Width)/2,(this.Height-global::UIT_Pokemon.Properties.Resources.Space.Height)/2,global::UIT_Pokemon.Properties.Resources.Space.Width,global::UIT_Pokemon.Properties.Resources.Space.Height));
            LinearGradientBrush br=new LinearGradientBrush(new Point(300,300),new Point(700,700),Color.Blue,Color.BurlyWood);
            LinearGradientBrush br1 = new LinearGradientBrush(new Point(250, 250), new Point(800, 800), Color.Green, Color.BlueViolet);
            if (draw==true)
            {
                
                gp.SmoothingMode = SmoothingMode.HighQuality;
                //gp.DrawString(Information.StringLevel + " " + Level.ToString(), new Font("", 26, FontStyle.Bold), br1, new Point(this.Width / 2 - 73,87 ));
                gp.DrawString(Information.StringLevel + " " + Level.ToString(),new Font("",26,FontStyle.Bold),br,new Point(this.Width/2-70,90));
                //gp.FillPie(br1, new Rectangle(1200, 100, 120, 120), 0, 360);

                gp.FillPie(br1, new Rectangle(this.Width / 2 - 210, this.Height / 2 - 180, 420, 420), 0, 360);

                gp.FillPie(br, new Rectangle(this.Width / 2 - 200, this.Height / 2 - 170, 400, 400), 0, 360);
                gp.SmoothingMode = SmoothingMode.Default;
            }
            else
            {
                gp.FillRectangle(Brushes.Black,new Rectangle(this.Width / 2 - 200, this.Height / 2 - 180, 420, 420));
            }
            if (ImageLevel != null)
                gp.DrawImage(ImageLevel, new Rectangle((this.Width - ImageLevel.Width) / 2, (this.Height - ImageLevel.Height) / 2 +40, ImageLevel.Width-10, ImageLevel.Height-10));
        }
        private void InitializePokemon()
        {
            this.SuspendLayout();
            PScreen = new PauseScreen(this);
            this.Controls.Add(PScreen);
            templateScreen = new PictureBox();
            templateScreen.Size = new Size(1100, 800);
            templateScreen.Location = new Point(100, 100);
            this.Controls.Add(templateScreen);
            RandomPokemon = new RibbonButton(" Random");
            RandomPokemon.Location = new Point(400, 15);
            RandomPokemon.Image = global::UIT_Pokemon.Properties.Resources.changebutton;
            RandomPokemon.Click += new EventHandler(RandomPokemon_Click);
            this.Controls.Add(RandomPokemon);
            HelpPokemon = new RibbonButton("   Help");
            HelpPokemon.Location = new Point(580, 15);
            HelpPokemon.Image = global::UIT_Pokemon.Properties.Resources.findbutton;
            HelpPokemon.Click += new EventHandler(HelpPokemon_Click);
            this.Controls.Add(HelpPokemon);
            FullScreen = new RibbonButton("  Full Screen");
            FullScreen.Location = new Point(760, 15);
            FullScreen.Image = global::UIT_Pokemon.Properties.Resources.Full;
            FullScreen.Click += new EventHandler(FullScreen_Click);
            this.Controls.Add(FullScreen);
            NextLevel = new SpecilButton(0);
            NextLevel.Location=new Point(630, 620);
            NextLevel.Click+=new EventHandler(NextLevel_Click);
            NextLevel.Text = "NEXT";
            this.Controls.Add(NextLevel);
            NextLevel.Hide();
            wayeffect = new WayEffect(this);
            this.Controls.Add(wayeffect);
            for (int y = 0; y < IDHeight; y++)
                for (int x = IDWith - 1; x >= 0; x--)
                {
                    PokemonPiece[x, y] = new Piece(x, y);
                    this.Controls.Add(PokemonPiece[x, y]);
                    PokemonPiece[x, y].Click += new EventHandler(PokemonPiece_Click);
                }
            try
            {
                GC.Collect();
            }
            catch { }
            utilitypanel = new UtilityPanel(this);
            this.Controls.Add(utilitypanel);
            optionpanel = new OptionPanel(this);
            this.Controls.Add(optionpanel);
            limittime = new Limittime(this);
            this.Controls.Add(limittime);
            PauseButton = new SpecilButton(1);
            PauseButton.Location = new Point(6, 13);
            PauseButton.Click += new EventHandler(PauseButton_Click);
            PauseButton.Text = "PAUSE";
            this.Controls.Add(PauseButton);
           
            lifetime = new LifeTime(this);
            lifetime.Location = new Point(this.Width - 205, -80);
            this.Controls.Add(lifetime);
            Config config = OptionPlay.ReadConfig();
            if (config.English == false)
            {
                this.English = false;
                Information.Vietnamese();
                ChoosingLanguage();
            }
            wayeffect.BackColor = config.color;
            this.effect = config.effect;
            this.KindGame = config.kindgame;
            lifetime.Life = 10 + (KindGame - 1) * 5;
            Information.CurrentKindGame = Information.defaultPokemonNumber + (KindGame - 1) * 6;
            this.ResumeLayout();
            
           
        }
        private void NextLevel_Click(Object obj, EventArgs e)
        {
            if (Information.LockNextButton == true)
                return;
            
            NextClickCount++;
            if (NextClickCount == 1)
            {         
                nextLevelEffect.Clickmore();

            }
            else if(NextClickCount==2)
            {
                nextLevelEffect.Hide();
                NextLevel.Hide();

                lifetime.UpdateLife(true);
                Level++;
                Config config = OptionPlay.ReadConfig();
                int tmp_config = config.MaxLevel;
                if (Level - 1 > tmp_config)
                {
                    config = new Config(effect, wayeffect.BackColor, English, KindGame, Level - 1);
                    OptionPlay.WriteConfig(config);
                }
                if (Level < 16)
                {
                    NewGame();
                    LockGame = false;
                }
                else
                {
                    time.Stop();
                    gameLocking();
                    gameover = true;
                    PScreen.ShowScreenFinish();
                }

                
            }

        }
        public void timeway_Tick(Object obj, EventArgs e)
        {
            if (showway == true)
            {
                wayeffect.Hide();
                timeway.Stop();
                PieceUpdate();
                //PokemonUpdate(LocalPokemonChage);
                if (argument.RemainPokemon <= 0)
                {
                    percent = limittime.percent;
                    draw = false;
                    ImageLevel = global::UIT_Pokemon.Properties.Resources.findbutton;
                    this.Invalidate();
                    time.Stop();
                    gameLocking();
                    Information.LockNextButton = true;
                    nextLevelEffect.Action();
                }
            }
            else
            {
                HelpEffect++;
                ShowHelpEffect();
            }
        }
        public void TurnOnScreen()
        {
            if (full == false)
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.None;
                this.TopMost = true;
                WinApi.SetWinFullScreen(this.Handle);
                full = true;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.Fixed3D;
                TopMost = false;
                full = false;
            }
            limittime.UpdatePercent();
        }
        private void FullScreen_Click(Object obj,EventArgs e)
        {
            TurnOnScreen();
        }
        private void HelpPokemon_Click(Object obj, EventArgs e)
        {
            if (gameover == true)
                return;
            if (LockGame == true)
                return;
            ComebackDefault();
            if (argument.RemainPokemon == 0)
                return;
            HelpPokemonClick++;
            if (ListHelp != null || ListHelp.Count == 2)
            {
                if (limittime.percent > 2)
                {
                    ShowHelpEffect();
                    showway = false;
                    limittime.percent -= 2;
                    limittime.UpdatePercent();
                    if (Score > 20)
                        Score -= 20;
                    else
                        Score = 0;
                    timeway.Interval = Information.timeHelp;
                    limittime.updateTime();
                    timeway.Start();
                }
            }
            
        }
        private void ShowHelpEffect()
        {
            if (ListHelp != null&&ListHelp.Count==2)
            {
                if (HelpEffect % 2 == 0)
                {
                    PokemonPiece[ListHelp[0].X - 1, ListHelp[0].Y - 1].PokemonCouple2();
                    PokemonPiece[ListHelp[1].X - 1, ListHelp[1].Y - 1].PokemonCouple2();
                }
                else
                {
                    PokemonPiece[ListHelp[0].X - 1, ListHelp[0].Y - 1].PokemonCouple();
                    PokemonPiece[ListHelp[1].X - 1, ListHelp[1].Y - 1].PokemonCouple();
                }
            }
        }
        private void HideHelpEffect()
        {
            
            timeway.Stop();
            if(wayeffect.Visible==true)
            {
                wayeffect.Hide();
                PieceUpdate();
            }
            timeway.Interval = Information.timeway;
            showway = true;
            if (ListHelp != null && ListHelp.Count==2)
            {
                PokemonPiece[ListHelp[0].X - 1, ListHelp[0].Y - 1].Default();
                PokemonPiece[ListHelp[1].X - 1, ListHelp[1].Y - 1].Default();
            }
        }
        private void RandomFunction()
        {
            HideHelpEffect();
            templateScreen.Show();
            this.SuspendLayout();

            argument.RandomAgain();
            RandomGame();
            PieceUpdate();
            this.ResumeLayout();
            templateScreen.Hide();
            try
            {
                //ListHelp.Clear();// co loi
                ListHelp = argument.FindCouple();
                if (ListHelp == null)
                {
                    RandomFunction();
                }
            }
            catch(Exception ex)
            {
                //RichTextBox rt = new RichTextBox();
                //RichTextBox.T
                //MessageBox.Show(ex.ToString()+ex.MessageMessage);
            }
        }
        private void RandomPokemon_Click(Object obj, EventArgs e)
        {
            //for (int i = 1; i < 10; i++)
              //  argument.Matrix[i, 2] = 5;
            //
            if (gameover == true)
                return;
            if (LockGame == true)
                return;
            OldMatrix = (int[,])argument.Matrix.Clone();
            lockBack = false;
            ComebackDefault();
            if (argument.RemainPokemon == 0)
                return;
            RandomPokemonClick++;
            if (limittime.percent < 10)
                return;
            if (argument.RemainPokemon == 0)
                return;
            RandomFunction();
            limittime.percent -= 10;
            if (Score >= 50)
                Score -= 50;
            else
                Score = 0;
            limittime.UpdatePercent();
            limittime.updateTime();
            /*String test = "";
            int[] l = new int[20];
            for (int i = 0; i < 20; i++)
                l[i] = 0;
            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 16; x++)
                {
                    test += "  *" + argument.Matrix[x + 1, y + 1].ToString() + "*   ";
                    for (int i = 0; i < 20; i++)
                    {
                        if (argument.Matrix[x + 1, y + 1] == i)
                            l[i]++;
                    }
                }
                test += "\n";
            }
            String test_2 = "";
            int phu = 0;
            for (int i = 0; i < 20; i++)
            {
                phu += l[i];
                test_2 += "So " + i.ToString() + " =" + l[i].ToString() + "\n";
            }
            test_2 += "tong = " + phu.ToString();
            MessageBox.Show(test);
           // MessageBox.Show(test_2);
            //PieceUpdate();*/
           
        }
        public void ComebackDefault()
        {
            try
            {
                if (select)
                {
                    if (shapegame.X != -1)
                    {
                        PokemonPiece[shapegame.X, shapegame.Y].Default(shapegame.IDPokemon);
                        select = false;
                        shapegame.SetDefault();
                    }
                }
            }
            catch
            { 
            }
        }
        private void PokemonPiece_Click(object obj, EventArgs e)
        {
            if (LockGame == true)
                return;
            if (gameover == true)
                return;
            if (wayeffect.Visible == true&&Level>1)
                return;
            if (showway == false)
            {
                HideHelpEffect();
            }
            Piece p = (Piece)obj;
            if (p.Locked == true)
                return;
            if (!select)
            {
                select = true;
                p.HighLight(p.ID);
                shapegame.Action(p.X, p.Y, p.ID, p.IDAction);
            }
            else
            {
                if (p.IDAction == 1)
                {
                    select = false;
                    p.Default(p.ID);
                    shapegame.SetDefault();
                }
                else
                {

                    if (p.ID != shapegame.IDPokemon)
                    {
                        PokemonPiece[shapegame.X, shapegame.Y].Default(shapegame.IDPokemon);
                        p.HighLight(p.ID);
                        shapegame.Action(p.X, p.Y, p.ID, p.IDAction);
                        Score -= 10;
                        if (Score < 0)
                            Score = 0;
                    }
                    else
                    {
                        // kiem tra an
                        ArrayList a = argument.min_way(argument.Matrix, p.X, p.Y, shapegame.X, shapegame.Y);
                        if (a != null && a.Count > 0)
                        {
                            if (LockSound ==false)
                            {
                                try
                                {
                                    if (argument.RemainPokemon >= 4)
                                        UITSoundPlayer.media_Die.Play();
                                    else
                                        UITSoundPlayer.media_Pikachu.Play();
                                }
                                catch { }
                            } 
                            lockBack = false;
                            OldMatrix=(int[,])argument.Matrix.Clone();
                            oldScore = Score;
                            p.MakePoint(p.ID);
                            wayeffect.Create_way(a);
                            PokemonPiece[shapegame.X, shapegame.Y].MakePoint(shapegame.IDPokemon);
                            argument.HavePoint(p.X, p.Y, shapegame.X, shapegame.Y);
                            select = false;
                            Score += (a.Count-1)*2;
                            if (a.Count > 19)
                                SmartEye++;
                            timeway.Start();
                            //PokemonUpdate(LocalPokemonChage);
                            if (argument.RemainPokemon <= 0)
                            {
                                time.Stop();
                            }
                            else
                            {
                                try
                                {
                                    ListHelp = argument.FindCouple();
                                    if (ListHelp == null)
                                    {
                                        RandomFunction();
                                        lifetime.UpdateLife(false);
                                    }
                                }
                                catch
                                {
 
                                }
                                
                            }
                        }
                        else
                        {
                            if (LockSound == false)
                            {
                                try
                                {
                                    UITSoundPlayer.media_cantmove.Play();
                                }
                                catch { }
                            }
                            PokemonPiece[shapegame.X, shapegame.Y].Default(shapegame.IDPokemon);
                            shapegame.SetDefault();
                            select = false;
                            if (Score > 10)
                                Score -= 10;
                            else
                                Score = 0;
                        }
                        limittime.updateTime();
                    }
                }
            }
        }
        public void PieceUpdate()
        {
            for(int x=0;x<16;x++)
                for (int y = 0; y < 8; y++)
                {
                    if (argument.Matrix[x + 1, y + 1] == -1)
                    {
                        PokemonPiece[x, y].Hide();
                        PokemonPiece[x, y].Locked = true;
                    }
                    else
                    {
                        if (PokemonPiece[x, y].IDAction == 3)
                        {
                            PokemonPiece[x, y].Default();
                        }
                        if (PokemonPiece[x, y].ID!=argument.Matrix[x + 1, y + 1])
                            PokemonPiece[x, y].Default(argument.Matrix[x + 1, y + 1]);
                        
                        PokemonPiece[x, y].Show();
                        PokemonPiece[x, y].Locked = false;
                    }
                }
        }
       
        public void RandomGame()
        {
            for (int x = 0; x < 16; x++)
                for (int y = 0; y < 8; y++)
                {
                    PokemonPiece[x, y].Default(argument.Matrix[x + 1, y + 1]);
                    PokemonPiece[x, y].Locked = false;
                    PokemonPiece[x, y].Show();
                }
            
            
        }
        private void InitialImage()
        {
            String Filename = Information.directories + "\\Collection\\";
            Filename += "Level" + Level.ToString() + ".UIT";
            //NextLevel.Show();
            //LevelFile.WriteFile(Filename);
            if (File.Exists(Filename))
            {
                try
                {

                    Information.imageFileLevel = ReadfileImage.ReadFile(Filename);
                    if (Information.imageFileLevel.ImageLevel != null&&Information.imageFileLevel.level==Level)
                        ImageLevel = Information.imageFileLevel.ImageLevel;
                    else
                        ImageLevel = global::UIT_Pokemon.Properties.Resources.findbutton;

                }
                catch
                {
                    Information.imageFileLevel = new ImageFile(null,1);
                }
                try
                {
                    GC.Collect();
                }
                catch { }
            }
            else
            {
                Information.imageFileLevel = new ImageFile(null,1);
                ImageLevel = global::UIT_Pokemon.Properties.Resources.findbutton;
            }
            lockBack = true;
            LockGame = false;
            gameover = false;
        }
        public void NewGame()
        {
            //if (KindGame == 1)
            //{
            Information.PokemonNumber = Information.CurrentKindGame + Level - 1;
            //}
            time.Start();
            SmartEye = 0;
            RandomPokemonClick = 0;
            HelpPokemonClick = 0;
            NextClickCount = 0;
            templateScreen.Show();
            HideHelpEffect();
            ComebackDefault();
            limittime.reset();
            InitialImage();
            argument.NewGame();
            RandomGame();
            time.Start();
            ListHelp = argument.FindCouple();
            Information.Level = Level;
            templateScreen.Hide();
            draw = true;
            this.Invalidate();
            /*test
            String test = "";
            int[] l = new int[30];
            for (int i = 0; i < 30; i++)
                l[i] = 0;
            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 16; x++)
                {
                    test += "  *" + argument.Matrix[x + 1, y + 1].ToString() + "*   ";
                    for (int i = 0; i < 30; i++)
                    {
                        if (argument.Matrix[x + 1, y + 1] == i)
                            l[i]++;
                    }
                }
                test += "\n";
            }
            String test_2 = "";
            int phu = 0;
            for (int i = 0; i < 30; i++)
            {
                phu += l[i];
                test_2 += "So " + i.ToString() + " =" + l[i].ToString() + "\n";
            }
            test_2 += "tong = " + phu.ToString();
            MessageBox.Show(test);
            MessageBox.Show(test_2);
            */

        }
        public void UpdatePercent()
        {
            if (percent >= 0)
            {
                limittime.percent--;
                percent = limittime.percent;
                limittime.UpdatePercent();
            }
        }
        public void UpdateScore()
        {
            Score += nextLevelEffect._total;
            limittime.UpdateScore();
        }
        private void time_Tick(Object obj,EventArgs e)
        {
            timeplay.lifetime();
            limittime.updateTime();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            ComebackDefault();
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X > 105)
            {
                if (utilitypanel.IsSelect == true)
                    utilitypanel.locker();
            }
            if (e.X < ClientRectangle.Width - 110)
            {
                if (optionpanel.IsSelect == true)
                    optionpanel.locker();

            }
        }
        public zipgame SaveGame()
        {
            zipgame zip = new zipgame(KindGame,Information.CurrentKindGame,lifetime.Life, argument.Matrix,Level, Information.PokemonNumber, Score,argument.RemainPokemon,limittime.percent,HelpPokemonClick, RandomPokemonClick,SmartEye, timeplay.hour, timeplay.minute, timeplay.second);
            return zip;
        }
        public void LoadGame(zipgame zip)
        {
            HideHelpEffect();
            ComebackDefault();
            KindGame = zip.kindgame;
            Information.CurrentKindGame = zip.sumfirstpokemon;
            argument.Matrix = zip.Matrix;
            Information.PokemonNumber = zip.number_pokemon;
            Information.CurrentKindGame = Information.defaultPokemonNumber + (KindGame - 1) * 6;
            Score = zip.score;
            argument.RemainPokemon = zip.Remainpokemon;
            limittime.percent = zip.percent;
            percent = limittime.percent;
            timeplay.hour = zip.hour;
            timeplay.minute = zip.minute;
            timeplay.second = zip.second;
            Level = zip.level;
            HelpPokemonClick = zip.helpclick;
            RandomPokemonClick = zip.randomclick;
            lifetime.Life = zip.Lifetime;
            lifetime.Invalidate();
            SmartEye = zip.smarteye;
            templateScreen.Show();
            InitialImage();
            time.Start();
            ListHelp = argument.FindCouple();
            Information.Level = Level;
            limittime.UpdatePercent();
            limittime.updateTime();
            PieceUpdate();
            templateScreen.Hide();
            draw = true;
            argument.Level = Level;
            this.Invalidate();
        }
        public void ComeBackLastStep()
        {
            HideHelpEffect();
            ComebackDefault();
            if (lockBack == false)
            {
                argument.Matrix = (int[,])OldMatrix.Clone();
                argument.RemainPokemon += 2;
                Score = oldScore;
                lockBack = true;
                RandomGame();
                PieceUpdate();
                this.Invalidate();
            }
            
        }
        public void gameLocking()
        {
            HideHelpEffect();
            ComebackDefault();
            lockBack = true;
            LockGame = true;
        }
        public void gameLockingUtility()
        {
            HideHelpEffect();
            ComebackDefault();
            LockGame = true;
            time.Stop();
            PScreen.ShowScreenPause();
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (LockGame == false)
                {
                    PScreen.ShowScreenGameOver();
                }
                else
                {
                    PScreen.HideScreen();
                }
            }
            MessageBox.Show(e.KeyCode.ToString());
        }
        public void ChoosingLanguage()
        {
            if (English)
            {
                NextLevel.Text = "NEXT";
                PauseButton.Text = "PAUSE";
                HelpPokemon.changeText("   Help");
                RandomPokemon.changeText(" Random");
                this.Invalidate();
            }
            else
            {
                NextLevel.Text = "TIẾP TỤC";
                PauseButton.Text = "TẠM DỪNG";
                HelpPokemon.changeText(" Trợ giúp");
                RandomPokemon.changeText("  Đảo lại");
                this.Invalidate();
            }
        }
        private void PauseButton_Click(Object obj,EventArgs e)
        {
            if (fause == false)
            {
                fause = true;
                gameLockingUtility();
            }
            else
            {
                fause = false;
                time.Start();
                PScreen.HideScreen();
            }
        }
        public void SetRecord()
        {
            int tmp = 0;
            if (KindGame==1)
            {
                UIT_PokemonHighScore.List_highscore high_score = UIT_PokemonHighScore.HighScoreGame.ReadHighScore();

                if (Score > high_score.player_easy.GetMinScore())
                {
                    if (Score > high_score.player_easy.GetMaxScore())
                        tmp = 1;
                    InputName IN = new InputName(this, tmp);
                    IN.ShowDialog();
                    IN.Dispose();
                }
            }
            else if (KindGame==2)
            {
                UIT_PokemonHighScore.List_highscore high_score = UIT_PokemonHighScore.HighScoreGame.ReadHighScore();
                if (Score > high_score.player_mid.GetMinScore())
                {
                    if (Score > high_score.player_mid.GetMaxScore())
                        tmp = 1;
                    InputName IN = new InputName(this, tmp);
                    IN.ShowDialog();
                    IN.Dispose();
                }
            }
            else
            {
                UIT_PokemonHighScore.List_highscore high_score = UIT_PokemonHighScore.HighScoreGame.ReadHighScore();
                if (Score> high_score.player_hard.GetMinScore())
                {
                    if (Score > high_score.player_hard.GetMaxScore())
                        tmp = 1;
                    InputName IN = new InputName(this, tmp);
                    IN.ShowDialog();
                    IN.Dispose();
                }
            }
            Config config = OptionPlay.ReadConfig();
            int tmp_config = config.MaxLevel;
            if (Level - 1 > tmp_config)
            {
                config = new Config(effect, wayeffect.BackColor, English, KindGame, Level - 1);
                OptionPlay.WriteConfig(config);
            }
            PScreen.HideScreen();
            HighScore high = new HighScore(KindGame-1);
            high.ShowDialog();
            high.Dispose();
            
        }
    }
    

}
