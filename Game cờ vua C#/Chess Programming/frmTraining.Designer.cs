namespace Chess_Programming
{
    partial class frmTraining
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblEnpassant = new DevComponents.DotNetBar.LabelX();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.lblBKCastling = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.lblBQCastling = new DevComponents.DotNetBar.LabelX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.lblWKCastling = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.lblWQCastling = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.btnUndo = new DevComponents.DotNetBar.ButtonX();
            this.btnTryAgain = new DevComponents.DotNetBar.ButtonX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.lblType = new DevComponents.DotNetBar.LabelX();
            this.btnHint = new DevComponents.DotNetBar.ButtonX();
            this.lblWhoMove = new DevComponents.DotNetBar.LabelX();
            this.lblOwnSide = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnNext = new DevComponents.DotNetBar.ButtonX();
            this.btnTrainingOptions = new DevComponents.DotNetBar.ButtonX();
            this.btnExit = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.btnSelectGame = new DevComponents.DotNetBar.ButtonX();
            this.btnBoard = new DevComponents.DotNetBar.ButtonX();
            this.timerManageControl = new System.Windows.Forms.Timer(this.components);
            this.btnPre = new DevComponents.DotNetBar.ButtonX();
            this.lblIndex = new DevComponents.DotNetBar.LabelX();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 560);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblEnpassant);
            this.panel2.Controls.Add(this.labelX14);
            this.panel2.Controls.Add(this.lblBKCastling);
            this.panel2.Controls.Add(this.labelX10);
            this.panel2.Controls.Add(this.lblBQCastling);
            this.panel2.Controls.Add(this.labelX12);
            this.panel2.Controls.Add(this.lblWKCastling);
            this.panel2.Controls.Add(this.labelX8);
            this.panel2.Controls.Add(this.lblWQCastling);
            this.panel2.Controls.Add(this.labelX6);
            this.panel2.Controls.Add(this.btnUndo);
            this.panel2.Controls.Add(this.btnTryAgain);
            this.panel2.Controls.Add(this.labelX4);
            this.panel2.Controls.Add(this.lblType);
            this.panel2.Controls.Add(this.btnHint);
            this.panel2.Controls.Add(this.lblWhoMove);
            this.panel2.Controls.Add(this.lblOwnSide);
            this.panel2.Controls.Add(this.labelX3);
            this.panel2.Controls.Add(this.labelX2);
            this.panel2.Controls.Add(this.labelX1);
            this.panel2.Location = new System.Drawing.Point(576, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(208, 310);
            this.panel2.TabIndex = 2;
            // 
            // lblEnpassant
            // 
            this.lblEnpassant.AutoSize = true;
            this.lblEnpassant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnpassant.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEnpassant.Location = new System.Drawing.Point(97, 235);
            this.lblEnpassant.Name = "lblEnpassant";
            this.lblEnpassant.Size = new System.Drawing.Size(50, 21);
            this.lblEnpassant.TabIndex = 17;
            this.lblEnpassant.Text = "Không";
            // 
            // labelX14
            // 
            this.labelX14.AutoSize = true;
            this.labelX14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX14.Location = new System.Drawing.Point(10, 235);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(83, 21);
            this.labelX14.TabIndex = 16;
            this.labelX14.Text = "Enpassant:";
            // 
            // lblBKCastling
            // 
            this.lblBKCastling.AutoSize = true;
            this.lblBKCastling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBKCastling.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBKCastling.Location = new System.Drawing.Point(77, 205);
            this.lblBKCastling.Name = "lblBKCastling";
            this.lblBKCastling.Size = new System.Drawing.Size(50, 21);
            this.lblBKCastling.TabIndex = 15;
            this.lblBKCastling.Text = "Không";
            // 
            // labelX10
            // 
            this.labelX10.AutoSize = true;
            this.labelX10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX10.Location = new System.Drawing.Point(10, 204);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(64, 21);
            this.labelX10.TabIndex = 14;
            this.labelX10.Text = "o-o Đen:";
            // 
            // lblBQCastling
            // 
            this.lblBQCastling.AutoSize = true;
            this.lblBQCastling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBQCastling.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBQCastling.Location = new System.Drawing.Point(91, 178);
            this.lblBQCastling.Name = "lblBQCastling";
            this.lblBQCastling.Size = new System.Drawing.Size(24, 21);
            this.lblBQCastling.TabIndex = 13;
            this.lblBQCastling.Text = "Có";
            // 
            // labelX12
            // 
            this.labelX12.AutoSize = true;
            this.labelX12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX12.Location = new System.Drawing.Point(10, 177);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(78, 21);
            this.labelX12.TabIndex = 12;
            this.labelX12.Text = "o-o-o Đen:";
            // 
            // lblWKCastling
            // 
            this.lblWKCastling.AutoSize = true;
            this.lblWKCastling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWKCastling.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblWKCastling.Location = new System.Drawing.Point(89, 147);
            this.lblWKCastling.Name = "lblWKCastling";
            this.lblWKCastling.Size = new System.Drawing.Size(50, 21);
            this.lblWKCastling.TabIndex = 11;
            this.lblWKCastling.Text = "Không";
            // 
            // labelX8
            // 
            this.labelX8.AutoSize = true;
            this.labelX8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX8.Location = new System.Drawing.Point(10, 146);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(76, 21);
            this.labelX8.TabIndex = 10;
            this.labelX8.Text = "o-o Trắng:";
            // 
            // lblWQCastling
            // 
            this.lblWQCastling.AutoSize = true;
            this.lblWQCastling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWQCastling.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblWQCastling.Location = new System.Drawing.Point(103, 120);
            this.lblWQCastling.Name = "lblWQCastling";
            this.lblWQCastling.Size = new System.Drawing.Size(24, 21);
            this.lblWQCastling.TabIndex = 9;
            this.lblWQCastling.Text = "Có";
            // 
            // labelX6
            // 
            this.labelX6.AutoSize = true;
            this.labelX6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.Location = new System.Drawing.Point(10, 120);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(90, 21);
            this.labelX6.TabIndex = 8;
            this.labelX6.Text = "o-o-o Trắng:";
            // 
            // btnUndo
            // 
            this.btnUndo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUndo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.Location = new System.Drawing.Point(77, 269);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(53, 27);
            this.btnUndo.TabIndex = 7;
            this.btnUndo.Text = "Undo";
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnTryAgain
            // 
            this.btnTryAgain.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTryAgain.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTryAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTryAgain.Location = new System.Drawing.Point(144, 269);
            this.btnTryAgain.Name = "btnTryAgain";
            this.btnTryAgain.Size = new System.Drawing.Size(53, 27);
            this.btnTryAgain.TabIndex = 3;
            this.btnTryAgain.Text = "Thử Lại";
            this.btnTryAgain.Click += new System.EventHandler(this.btnTryAgain_Click);
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.ForeColor = System.Drawing.Color.Black;
            this.labelX4.Location = new System.Drawing.Point(61, 2);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(97, 26);
            this.labelX4.TabIndex = 6;
            this.labelX4.Text = "Thông Tin";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblType.Location = new System.Drawing.Point(47, 36);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(116, 19);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "Mate in 2 Moves";
            // 
            // btnHint
            // 
            this.btnHint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHint.Location = new System.Drawing.Point(10, 269);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(53, 27);
            this.btnHint.TabIndex = 5;
            this.btnHint.Text = "Gợi Ý";
            this.btnHint.Click += new System.EventHandler(this.btnHint_Click);
            // 
            // lblWhoMove
            // 
            this.lblWhoMove.AutoSize = true;
            this.lblWhoMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhoMove.ForeColor = System.Drawing.Color.Crimson;
            this.lblWhoMove.Location = new System.Drawing.Point(80, 90);
            this.lblWhoMove.Name = "lblWhoMove";
            this.lblWhoMove.Size = new System.Drawing.Size(33, 21);
            this.lblWhoMove.TabIndex = 4;
            this.lblWhoMove.Text = "Đen";
            // 
            // lblOwnSide
            // 
            this.lblOwnSide.AutoSize = true;
            this.lblOwnSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnSide.ForeColor = System.Drawing.Color.Crimson;
            this.lblOwnSide.Location = new System.Drawing.Point(89, 62);
            this.lblOwnSide.Name = "lblOwnSide";
            this.lblOwnSide.Size = new System.Drawing.Size(46, 21);
            this.lblOwnSide.TabIndex = 3;
            this.lblOwnSide.Text = "Trắng";
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(10, 62);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(78, 21);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "Bạn Chọn:";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(10, 90);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(67, 21);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Đi Trước:";
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(10, 34);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(37, 21);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Loại:";
            // 
            // btnNext
            // 
            this.btnNext.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNext.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(719, 329);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(58, 28);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = ">>";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnTrainingOptions
            // 
            this.btnTrainingOptions.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTrainingOptions.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTrainingOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrainingOptions.Location = new System.Drawing.Point(683, 363);
            this.btnTrainingOptions.Name = "btnTrainingOptions";
            this.btnTrainingOptions.Size = new System.Drawing.Size(100, 33);
            this.btnTrainingOptions.TabIndex = 5;
            this.btnTrainingOptions.Text = "Bài Tập Mới";
            this.btnTrainingOptions.Click += new System.EventHandler(this.btnTrainingOptions_Click);
            // 
            // btnExit
            // 
            this.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnExit.Location = new System.Drawing.Point(694, 530);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 31);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "&Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.Location = new System.Drawing.Point(683, 402);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(100, 33);
            this.buttonX1.TabIndex = 7;
            this.buttonX1.Text = "Sao Chép FEN";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // btnSelectGame
            // 
            this.btnSelectGame.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSelectGame.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSelectGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectGame.Location = new System.Drawing.Point(577, 363);
            this.btnSelectGame.Name = "btnSelectGame";
            this.btnSelectGame.Size = new System.Drawing.Size(100, 33);
            this.btnSelectGame.TabIndex = 8;
            this.btnSelectGame.Text = "Chọn Bài Tập";
            this.btnSelectGame.Click += new System.EventHandler(this.btnSelectGame_Click);
            // 
            // btnBoard
            // 
            this.btnBoard.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBoard.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoard.Location = new System.Drawing.Point(577, 402);
            this.btnBoard.Name = "btnBoard";
            this.btnBoard.Size = new System.Drawing.Size(100, 33);
            this.btnBoard.TabIndex = 9;
            this.btnBoard.Text = "Bàn Cờ Tạm";
            this.btnBoard.Click += new System.EventHandler(this.btnBoard_Click);
            // 
            // timerManageControl
            // 
            this.timerManageControl.Enabled = true;
            this.timerManageControl.Tick += new System.EventHandler(this.timerManageControl_Tick);
            // 
            // btnPre
            // 
            this.btnPre.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPre.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPre.Location = new System.Drawing.Point(585, 329);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(58, 28);
            this.btnPre.TabIndex = 10;
            this.btnPre.Text = "<<";
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // lblIndex
            // 
            this.lblIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndex.Location = new System.Drawing.Point(644, 333);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(74, 21);
            this.lblIndex.TabIndex = 17;
            this.lblIndex.Text = "0/0";
            this.lblIndex.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // frmTraining
            // 
            this.ClientSize = new System.Drawing.Size(792, 572);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.lblIndex);
            this.Controls.Add(this.btnBoard);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnSelectGame);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTrainingOptions);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmTraining";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Luyện Tập - Cờ Vua CĐTH07A";
            this.Load += new System.EventHandler(this.frmTraining_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTraining_FormClosing);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX lblType;
        private DevComponents.DotNetBar.LabelX lblWhoMove;
        private DevComponents.DotNetBar.LabelX lblOwnSide;
        private DevComponents.DotNetBar.ButtonX btnTryAgain;
        private DevComponents.DotNetBar.ButtonX btnNext;
        private DevComponents.DotNetBar.ButtonX btnHint;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.ButtonX btnTrainingOptions;
        private DevComponents.DotNetBar.ButtonX btnExit;
        private DevComponents.DotNetBar.ButtonX btnUndo;
        private DevComponents.DotNetBar.LabelX lblWQCastling;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX lblEnpassant;
        private DevComponents.DotNetBar.LabelX labelX14;
        private DevComponents.DotNetBar.LabelX lblBKCastling;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX lblBQCastling;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.LabelX lblWKCastling;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX btnSelectGame;
        private DevComponents.DotNetBar.ButtonX btnBoard;
        private System.Windows.Forms.Timer timerManageControl;
        private DevComponents.DotNetBar.ButtonX btnPre;
        private DevComponents.DotNetBar.LabelX lblIndex;
    }
}