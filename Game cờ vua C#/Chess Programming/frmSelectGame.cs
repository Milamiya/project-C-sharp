using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Chess_Usercontrol ;
namespace Chess_Programming
{
    public partial class frmSelectGame : DevComponents.DotNetBar.Office2007Form
    {
        public frmSelectGame()
        {
            InitializeComponent();
            cboGameMode.SelectedIndex = 0;
        }

        public ChessSide eOwnSide;
        public GameMode eGameMode;
        public GameDifficulty eDifficulty;
        public short TimeLimit = 1;
        public short TimeBonus = 0;

        private void btnBegin_Click(object sender, EventArgs e)
        {
            if (cboGameMode.SelectedIndex == 0)
                eGameMode = GameMode.VsComputer;
            else
                eGameMode = GameMode.VsHuman;

            if (radWhite.Checked)
                eOwnSide = ChessSide.White;
            else
                eOwnSide = ChessSide.Black;
            
                if (radEasy.Checked)
                    eDifficulty = GameDifficulty.Easy;
                else if (radNormal.Checked)
                    eDifficulty = GameDifficulty.Normal; 
                else
                    eDifficulty = GameDifficulty.Hard;
                TimeLimit = Convert .ToInt16 ( iTimeLimit.Value);
                TimeBonus = Convert .ToInt16 ( iTImeBonus.Value );
            
        }

        private void cboGameMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGameMode.SelectedIndex == 0)
                groupDifficulty.Enabled = true;
            if (cboGameMode.SelectedIndex == 1)
                groupDifficulty.Enabled = false;                
        }


      
    }
}