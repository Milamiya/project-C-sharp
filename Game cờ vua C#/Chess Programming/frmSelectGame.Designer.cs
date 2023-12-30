namespace Chess_Programming
{
    partial class frmSelectGame
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cboGameMode = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.radWhite = new System.Windows.Forms.RadioButton();
            this.radBlack = new System.Windows.Forms.RadioButton();
            this.groupDifficulty = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.radHard = new System.Windows.Forms.RadioButton();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.radEasy = new System.Windows.Forms.RadioButton();
            this.radNormal = new System.Windows.Forms.RadioButton();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnBegin = new DevComponents.DotNetBar.ButtonX();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.iTImeBonus = new DevComponents.Editors.IntegerInput();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.iTimeLimit = new DevComponents.Editors.IntegerInput();
            this.groupDifficulty.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.groupPanel3.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iTImeBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTimeLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(8, 9);
            this.labelX1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(110, 19);
            this.labelX1.TabIndex = 14;
            this.labelX1.Text = "Hình Thức Chơi:";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(6, 10);
            this.labelX2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(114, 19);
            this.labelX2.TabIndex = 15;
            this.labelX2.Text = "Bạn Chọn Quân:";
            // 
            // cboGameMode
            // 
            this.cboGameMode.DisplayMember = "Text";
            this.cboGameMode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboGameMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGameMode.FormattingEnabled = true;
            this.cboGameMode.ItemHeight = 16;
            this.cboGameMode.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2});
            this.cboGameMode.Location = new System.Drawing.Point(122, 6);
            this.cboGameMode.Name = "cboGameMode";
            this.cboGameMode.Size = new System.Drawing.Size(157, 22);
            this.cboGameMode.TabIndex = 16;
            this.cboGameMode.SelectedIndexChanged += new System.EventHandler(this.cboGameMode_SelectedIndexChanged);
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "Chơi Với Máy";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "Chơi 2 Người";
            // 
            // radWhite
            // 
            this.radWhite.AutoSize = true;
            this.radWhite.BackColor = System.Drawing.Color.Transparent;
            this.radWhite.Checked = true;
            this.radWhite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radWhite.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radWhite.Location = new System.Drawing.Point(125, 9);
            this.radWhite.Name = "radWhite";
            this.radWhite.Size = new System.Drawing.Size(67, 20);
            this.radWhite.TabIndex = 17;
            this.radWhite.TabStop = true;
            this.radWhite.Text = "Trắng";
            this.radWhite.UseVisualStyleBackColor = false;
            // 
            // radBlack
            // 
            this.radBlack.AutoSize = true;
            this.radBlack.BackColor = System.Drawing.Color.Transparent;
            this.radBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBlack.Location = new System.Drawing.Point(197, 8);
            this.radBlack.Name = "radBlack";
            this.radBlack.Size = new System.Drawing.Size(53, 20);
            this.radBlack.TabIndex = 18;
            this.radBlack.TabStop = true;
            this.radBlack.Text = "Đen";
            this.radBlack.UseVisualStyleBackColor = false;
            // 
            // groupDifficulty
            // 
            this.groupDifficulty.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupDifficulty.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupDifficulty.Controls.Add(this.radHard);
            this.groupDifficulty.Controls.Add(this.labelX3);
            this.groupDifficulty.Controls.Add(this.radEasy);
            this.groupDifficulty.Controls.Add(this.radNormal);
            this.groupDifficulty.Location = new System.Drawing.Point(14, 102);
            this.groupDifficulty.Name = "groupDifficulty";
            this.groupDifficulty.Size = new System.Drawing.Size(289, 42);
            // 
            // 
            // 
            this.groupDifficulty.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupDifficulty.Style.BackColorGradientAngle = 90;
            this.groupDifficulty.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupDifficulty.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupDifficulty.Style.BorderBottomWidth = 1;
            this.groupDifficulty.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupDifficulty.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupDifficulty.Style.BorderLeftWidth = 1;
            this.groupDifficulty.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupDifficulty.Style.BorderRightWidth = 1;
            this.groupDifficulty.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupDifficulty.Style.BorderTopWidth = 1;
            this.groupDifficulty.Style.CornerDiameter = 4;
            this.groupDifficulty.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupDifficulty.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupDifficulty.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupDifficulty.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupDifficulty.TabIndex = 19;
            // 
            // radHard
            // 
            this.radHard.AutoSize = true;
            this.radHard.BackColor = System.Drawing.Color.Transparent;
            this.radHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radHard.Location = new System.Drawing.Point(229, 8);
            this.radHard.Name = "radHard";
            this.radHard.Size = new System.Drawing.Size(52, 20);
            this.radHard.TabIndex = 22;
            this.radHard.Text = "Khó";
            this.radHard.UseVisualStyleBackColor = false;
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(8, 9);
            this.labelX3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(57, 19);
            this.labelX3.TabIndex = 19;
            this.labelX3.Text = "Độ Khó:";
            // 
            // radEasy
            // 
            this.radEasy.AutoSize = true;
            this.radEasy.BackColor = System.Drawing.Color.Transparent;
            this.radEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radEasy.Location = new System.Drawing.Point(70, 8);
            this.radEasy.Name = "radEasy";
            this.radEasy.Size = new System.Drawing.Size(46, 20);
            this.radEasy.TabIndex = 20;
            this.radEasy.Text = "Dễ";
            this.radEasy.UseVisualStyleBackColor = false;
            // 
            // radNormal
            // 
            this.radNormal.AutoSize = true;
            this.radNormal.BackColor = System.Drawing.Color.Transparent;
            this.radNormal.Checked = true;
            this.radNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNormal.Location = new System.Drawing.Point(123, 8);
            this.radNormal.Name = "radNormal";
            this.radNormal.Size = new System.Drawing.Size(100, 20);
            this.radNormal.TabIndex = 21;
            this.radNormal.TabStop = true;
            this.radNormal.Text = "Trung Bình";
            this.radNormal.UseVisualStyleBackColor = false;
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.labelX1);
            this.groupPanel2.Controls.Add(this.cboGameMode);
            this.groupPanel2.Location = new System.Drawing.Point(14, 51);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(289, 40);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel2.TabIndex = 20;
            // 
            // groupPanel3
            // 
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.labelX2);
            this.groupPanel3.Controls.Add(this.radWhite);
            this.groupPanel3.Controls.Add(this.radBlack);
            this.groupPanel3.Location = new System.Drawing.Point(16, 154);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(287, 42);
            // 
            // 
            // 
            this.groupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel3.Style.BackColorGradientAngle = 90;
            this.groupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderBottomWidth = 1;
            this.groupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderLeftWidth = 1;
            this.groupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderRightWidth = 1;
            this.groupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderTopWidth = 1;
            this.groupPanel3.Style.CornerDiameter = 4;
            this.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel3.TabIndex = 20;
            // 
            // btnBegin
            // 
            this.btnBegin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBegin.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBegin.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBegin.ForeColor = System.Drawing.Color.Red;
            this.btnBegin.Location = new System.Drawing.Point(110, 291);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(96, 36);
            this.btnBegin.TabIndex = 21;
            this.btnBegin.Text = "Bắt Đầu Chơi";
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // reflectionLabel1
            // 
            this.reflectionLabel1.Location = new System.Drawing.Point(72, 13);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.ReflectionEnabled = false;
            this.reflectionLabel1.Size = new System.Drawing.Size(172, 30);
            this.reflectionLabel1.TabIndex = 22;
            this.reflectionLabel1.Text = "<font color=\"#ED1C24\" size=\"+4\"><b>Tùy Chọn Trò Chơi</b></font>";
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.labelX6);
            this.groupPanel1.Controls.Add(this.labelX7);
            this.groupPanel1.Controls.Add(this.iTImeBonus);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.iTimeLimit);
            this.groupPanel1.Location = new System.Drawing.Point(16, 206);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(287, 73);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel1.TabIndex = 23;
            // 
            // labelX6
            // 
            this.labelX6.AutoSize = true;
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            this.labelX6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.Location = new System.Drawing.Point(215, 37);
            this.labelX6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(33, 19);
            this.labelX6.TabIndex = 21;
            this.labelX6.Text = "Giây";
            // 
            // labelX7
            // 
            this.labelX7.AutoSize = true;
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            this.labelX7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX7.Location = new System.Drawing.Point(6, 38);
            this.labelX7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(154, 19);
            this.labelX7.TabIndex = 20;
            this.labelX7.Text = "Thời Gian Cộng Thêm:";
            // 
            // iTImeBonus
            // 
            // 
            // 
            // 
            this.iTImeBonus.BackgroundStyle.Class = "DateTimeInputBackground";
            this.iTImeBonus.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.iTImeBonus.Location = new System.Drawing.Point(164, 36);
            this.iTImeBonus.MaxValue = 30;
            this.iTImeBonus.MinValue = 0;
            this.iTImeBonus.Name = "iTImeBonus";
            this.iTImeBonus.ShowUpDown = true;
            this.iTImeBonus.Size = new System.Drawing.Size(40, 22);
            this.iTImeBonus.TabIndex = 19;
            this.iTImeBonus.Value = 5;
            // 
            // labelX5
            // 
            this.labelX5.AutoSize = true;
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(215, 8);
            this.labelX5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(33, 19);
            this.labelX5.TabIndex = 18;
            this.labelX5.Text = "Phút";
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(6, 8);
            this.labelX4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(120, 19);
            this.labelX4.TabIndex = 17;
            this.labelX4.Text = "Thời Gian Tối Đa:";
            // 
            // iTimeLimit
            // 
            // 
            // 
            // 
            this.iTimeLimit.BackgroundStyle.Class = "DateTimeInputBackground";
            this.iTimeLimit.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.iTimeLimit.Location = new System.Drawing.Point(164, 5);
            this.iTimeLimit.MaxValue = 90;
            this.iTimeLimit.MinValue = 1;
            this.iTimeLimit.Name = "iTimeLimit";
            this.iTimeLimit.ShowUpDown = true;
            this.iTimeLimit.Size = new System.Drawing.Size(40, 22);
            this.iTimeLimit.TabIndex = 16;
            this.iTimeLimit.Value = 10;
            // 
            // frmSelectGame
            // 
            this.ClientSize = new System.Drawing.Size(316, 336);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.reflectionLabel1);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.groupPanel3);
            this.Controls.Add(this.groupDifficulty);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmSelectGame";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tùy Chọn Trò Chơi - Cờ Vua CĐTH07A";
            this.groupDifficulty.ResumeLayout(false);
            this.groupDifficulty.PerformLayout();
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel2.PerformLayout();
            this.groupPanel3.ResumeLayout(false);
            this.groupPanel3.PerformLayout();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iTImeBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTimeLimit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboGameMode;
        private System.Windows.Forms.RadioButton radWhite;
        private System.Windows.Forms.RadioButton radBlack;
        private DevComponents.DotNetBar.Controls.GroupPanel groupDifficulty;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.RadioButton radEasy;
        private System.Windows.Forms.RadioButton radNormal;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private System.Windows.Forms.RadioButton radHard;
        private DevComponents.DotNetBar.ButtonX btnBegin;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.Editors.IntegerInput iTimeLimit;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.Editors.IntegerInput iTImeBonus;
        private DevComponents.DotNetBar.LabelX labelX5;
    }
}