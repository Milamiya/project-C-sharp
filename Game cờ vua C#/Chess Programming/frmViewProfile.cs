using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace Chess_Programming
{
    public partial class frmViewProfile : DevComponents.DotNetBar.Office2007Form
    {
        string strPlayerName = "";
        public frmViewProfile(string strPlayerName)
        {
            InitializeComponent();
            this.strPlayerName = strPlayerName;
        }

        private void frmManageProfile_Load(object sender, EventArgs e)
        {
            clsProfile profile = new clsProfile(strPlayerName);
            profile.LoadProfile();

            picAvatar.Image = profile.Avatar.Avatar;
            lblPlayerName.Text = profile.PlayerName;
            lblTotalGames.Text  = profile.TotalGames.ToString();
            lblTotalWin .Text = profile.TotalWin.ToString () ;
            lblTotalLose .Text = profile.TotalLose.ToString () ;
            lblTotalDraw .Text = profile.TotalDraw.ToString () ;
            lblRating .Text = profile.Rating.ToString ();
            
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}