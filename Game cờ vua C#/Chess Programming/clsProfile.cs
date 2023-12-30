using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Data;
namespace Chess_Programming
{
    public enum GameResult
    {
        Win,
        Lose,
        Draw
    }
    public class clsProfile
    {
        private string _PlayerName;
        private clsImage _Avatar;
        private int _TotalGames;
        private int _TotalWin;
        private int _TotalLose;
        private int _TotalDraw;
        private int _Rating;
        private string path = "";

        public string PlayerName
        {
            get
            {
                return this._PlayerName;
            }
            set
            {
                this._PlayerName = value;
            }
        }

        public clsImage Avatar
        {
            get
            {
                return this._Avatar;
            }
            set
            {
                this._Avatar = value;
            }
        }
        public int TotalGames
        {
            get
            {
                return this._TotalGames;
            }
            set
            {
                this._TotalGames = value;
            }
        }
        public int TotalWin
        {
            get
            {
                return this._TotalWin;
            }
            set
            {
                this._TotalWin = value;
            }
        }
        public int TotalLose
        {
            get
            {
                return this._TotalLose;
            }
            set
            {
                this._TotalLose = value;
            }
        }
        public int TotalDraw
        {
            get
            {
                return this._TotalDraw;
            }
            set
            {
                this._TotalDraw = value;
            }
        }
        public int Rating
        {
            get
            {
                return this._Rating;
            }
            set
            {
                this._Rating = value;
            }
        }

        public clsProfile(string PlayerName)
        {
            this._PlayerName = PlayerName;
            this._Rating = 1200;
            this._TotalGames = 0;
            this._TotalWin = 0;
            this._TotalLose = 0;
            this._TotalDraw = 0;

            PlayerName = clsEncoding.Encode(PlayerName) + ".xml";
            path = Application.StartupPath + "\\Profiles\\" + PlayerName;

        }

        //public clsProfile()
        //{
        //    this._PlayerName = "Guest";
        //    this._Rating = 1200;
        //    this._TotalGames = 0;
        //    this._TotalWin = 0;
        //    this._TotalLose = 0;
        //    this._TotalDraw = 0;

        //    string PlayerName = this._PlayerName;

        //    PlayerName = clsEncoding.Encode(PlayerName) + ".xml";
        //    path = Application.StartupPath + "\\Profiles\\" + PlayerName;

        //}

        public void LoadProfile()
        {


            DataTable tbl = clsXMLProcess.GetTable(path);
            DataRow r = tbl.Rows[0];

            this._PlayerName = r["PlayerName"].ToString();
            this._Rating = Convert.ToInt32(r["Rating"]);
            this._TotalGames = Convert.ToInt32(r["TotalGames"]);
            this._TotalWin = Convert.ToInt32(r["TotalWin"]);
            this._TotalLose = Convert.ToInt32(r["TotalLose"]);
            this._TotalDraw = Convert.ToInt32(r["TotalDraw"]);

            string strAvatar = "";

            try
            {
                strAvatar = r["Avatar"].ToString();
                this._Avatar = new clsImage();
                this._Avatar.ImageFromBytes(Convert.FromBase64String(strAvatar));
            }
            catch
            {

            }

        }

        public void SaveProfile()
        {
           
            if (Directory.Exists(Application.StartupPath + "\\Profiles") == false)
                Directory.CreateDirectory(Application.StartupPath + "\\Profiles");

            if (File.Exists(path) == false)
            {
                clsXMLProcess.CreateNewProfile(path);
            }

            DataTable tbl = clsXMLProcess.GetTable(path);
            DataRow r = tbl.Rows[0];
            string strAvatar = "";
            if (this._Avatar != null)
            {
                strAvatar = Convert.ToBase64String(this._Avatar.ImageToBytes());
            }


            r["PlayerName"] = this._PlayerName;
            r["Avatar"] = strAvatar;
            r["TotalGames"] = this._TotalGames;
            r["TotalWin"] = this._TotalWin;
            r["TotalLose"] = this._TotalLose;
            r["TotalDraw"] = this._TotalDraw;
            r["Rating"] = this._Rating;

            tbl.WriteXml(path);
        }


        public static void CalculateResult(ref clsProfile profile1, ref clsProfile profile2, GameResult result)
        {
            profile1.TotalGames += 1;
            profile2.TotalGames += 1;

            int k1 = GetDevelopmenCoefficien(profile1);
            int k2 = GetDevelopmenCoefficien(profile2);

            float fResult1 = new float();

            if (result == GameResult.Win)
            {
                fResult1 = 1.0f;
                profile1.TotalWin += 1;
                profile2.TotalLose += 1;
            }
            if (result == GameResult.Lose)
            {
                fResult1 = 0.0f;
                profile1.TotalLose += 1;
                profile2.TotalWin += 1;
            }
            if (result == GameResult.Draw)
            {
                fResult1 = 0.5f;
                profile1.TotalDraw += 1;
                profile2.TotalDraw += 1;
            }

            float fResult2 = 1.0f - fResult1;


            int difference = profile1.Rating - profile2.Rating;

            float dp1 = GetScoringProbability(difference);
            float dp2 = 1.0f - dp1;

            int score1 = (int)Math.Round((fResult1 - dp1) * k1);
            int score2 = (int)Math.Round((fResult2 - dp2) * k2);


            profile1.Rating = profile1.Rating + score1;
            profile2.Rating = profile2.Rating + score2;

        }

        private static float GetScoringProbability(int difference)
        {
            float H;
            int value = Math.Abs(difference);

            if (value < 4)
                H = 0.50f;
            else if (value < 11)
                H = 0.51f;
            else if (value < 18)
                H = 0.52f;
            else if (value < 26)
                H = 0.53f;
            else if (value < 33)
                H = 0.54f;
            else if (value < 40)
                H = 0.55f;
            else if (value < 47)
                H = 0.56f;
            else if (value < 54)
                H = 0.57f;
            else if (value < 62)
                H = 0.58f;
            else if (value < 69)
                H = 0.59f;
            else if (value < 77)
                H = 0.60f;
            else if (value < 84)
                H = 0.61f;
            else if (value < 92)
                H = 0.62f;
            else if (value < 99)
                H = 0.63f;
            else if (value < 107)
                H = 0.64f;
            else if (value < 114)
                H = 0.65f;
            else if (value < 122)
                H = 0.66f;
            else if (value < 130)
                H = 0.67f;
            else if (value < 138)
                H = 0.68f;
            else if (value < 146)
                H = 0.69f;
            else if (value < 154)
                H = 0.70f;
            else if (value < 163)
                H = 0.71f;
            else if (value < 171)
                H = 0.72f;
            else if (value < 180)
                H = 0.73f;
            else if (value < 189)
                H = 0.74f;
            else if (value < 198)
                H = 0.75f;
            else if (value < 207)
                H = 0.76f;
            else if (value < 216)
                H = 0.77f;
            else if (value < 226)
                H = 0.78f;
            else if (value < 236)
                H = 0.79f;
            else if (value < 246)
                H = 0.80f;
            else if (value < 257)
                H = 0.81f;
            else if (value < 268)
                H = 0.82f;
            else if (value < 279)
                H = 0.83f;
            else if (value < 291)
                H = 0.84f;
            else if (value < 303)
                H = 0.85f;
            else if (value < 316)
                H = 0.86f;
            else if (value < 329)
                H = 0.87f;
            else if (value < 345)
                H = 0.88f;
            else if (value < 358)
                H = 0.89f;
            else if (value < 375)
                H = 0.90f;
            else if (value < 392)
                H = 0.91f;
            else if (value < 412)
                H = 0.92f;
            else if (value < 433)
                H = 0.93f;
            else if (value < 457)
                H = 0.94f;
            else if (value < 485)
                H = 0.95f;
            else if (value < 518)
                H = 0.96f;
            else if (value < 560)
                H = 0.97f;
            else if (value < 620)
                H = 0.98f;
            else if (value < 735)
                H = 0.99f;
            else
                H = 1.00f;

            if (difference < 0)
                return (float)1 - H;
            else
                return H;

        }

        private static int GetDevelopmenCoefficien(clsProfile profile)
        {
            if (profile._TotalGames < 30)
                return 25;
            else if (profile.Rating < 2400)
                return 15;
            else
                return 10;
        }

    }
}
