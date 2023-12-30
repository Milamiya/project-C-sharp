namespace VietGraph
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lstExpressions = new System.Windows.Forms.ListBox();
            this.txtExpression = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.cmdPlotGraph = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.startX = new System.Windows.Forms.NumericUpDown();
            this.endX = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.endY = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.startY = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.divY = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.divX = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.sensitivity = new System.Windows.Forms.NumericUpDown();
            this.mode = new System.Windows.Forms.ComboBox();
            this.penWidth = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.absToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cosecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arcsinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arccosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arctanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.antilogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sqrtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tanhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arcsinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arccoshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arctanhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toánTửToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tácGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.startX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensitivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penWidth)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstExpressions
            // 
            this.lstExpressions.FormattingEnabled = true;
            this.lstExpressions.HorizontalScrollbar = true;
            this.lstExpressions.ItemHeight = 16;
            this.lstExpressions.Location = new System.Drawing.Point(17, 113);
            this.lstExpressions.Margin = new System.Windows.Forms.Padding(4);
            this.lstExpressions.Name = "lstExpressions";
            this.lstExpressions.Size = new System.Drawing.Size(392, 116);
            this.lstExpressions.TabIndex = 2;
            this.lstExpressions.SelectedIndexChanged += new System.EventHandler(this.lstExpressions_SelectedIndexChanged);
            // 
            // txtExpression
            // 
            this.txtExpression.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtExpression.Location = new System.Drawing.Point(17, 55);
            this.txtExpression.Margin = new System.Windows.Forms.Padding(4);
            this.txtExpression.Multiline = false;
            this.txtExpression.Name = "txtExpression";
            this.txtExpression.Size = new System.Drawing.Size(303, 22);
            this.txtExpression.TabIndex = 0;
            this.txtExpression.Text = "";
            this.txtExpression.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExpression_KeyPress);
            this.txtExpression.TextChanged += new System.EventHandler(this.txtExpression_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hãy điền vào ô trống 1 biểu thức";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(329, 52);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 27);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Những biểu thức sẽ vẽ";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(17, 237);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 27);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Xóa danh sách";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(274, 237);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(135, 27);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Xóa biểu thức";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // cmdPlotGraph
            // 
            this.cmdPlotGraph.Location = new System.Drawing.Point(161, 461);
            this.cmdPlotGraph.Margin = new System.Windows.Forms.Padding(4);
            this.cmdPlotGraph.Name = "cmdPlotGraph";
            this.cmdPlotGraph.Size = new System.Drawing.Size(104, 27);
            this.cmdPlotGraph.TabIndex = 13;
            this.cmdPlotGraph.Text = "Vẽ đồ thị";
            this.cmdPlotGraph.UseVisualStyleBackColor = true;
            this.cmdPlotGraph.Click += new System.EventHandler(this.cmdPlotGraph_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 293);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Điểm đầu trục X";
            // 
            // startX
            // 
            this.startX.DecimalPlaces = 2;
            this.startX.Location = new System.Drawing.Point(118, 288);
            this.startX.Margin = new System.Windows.Forms.Padding(4);
            this.startX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.startX.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.startX.Name = "startX";
            this.startX.Size = new System.Drawing.Size(81, 22);
            this.startX.TabIndex = 5;
            this.startX.Value = new decimal(new int[] {
            8,
            0,
            0,
            -2147483648});
            // 
            // endX
            // 
            this.endX.DecimalPlaces = 2;
            this.endX.Location = new System.Drawing.Point(329, 288);
            this.endX.Margin = new System.Windows.Forms.Padding(4);
            this.endX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.endX.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.endX.Name = "endX";
            this.endX.Size = new System.Drawing.Size(81, 22);
            this.endX.TabIndex = 6;
            this.endX.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 293);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Điểm cuối trục X";
            // 
            // endY
            // 
            this.endY.DecimalPlaces = 2;
            this.endY.Location = new System.Drawing.Point(329, 319);
            this.endY.Margin = new System.Windows.Forms.Padding(4);
            this.endY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.endY.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.endY.Name = "endY";
            this.endY.Size = new System.Drawing.Size(81, 22);
            this.endY.TabIndex = 8;
            this.endY.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 324);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Điểm cuối trục Y";
            // 
            // startY
            // 
            this.startY.DecimalPlaces = 2;
            this.startY.Location = new System.Drawing.Point(118, 319);
            this.startY.Margin = new System.Windows.Forms.Padding(4);
            this.startY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.startY.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.startY.Name = "startY";
            this.startY.Size = new System.Drawing.Size(81, 22);
            this.startY.TabIndex = 7;
            this.startY.Value = new decimal(new int[] {
            8,
            0,
            0,
            -2147483648});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 324);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Điểm đầu trục Y";
            // 
            // divY
            // 
            this.divY.Location = new System.Drawing.Point(329, 349);
            this.divY.Margin = new System.Windows.Forms.Padding(4);
            this.divY.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.divY.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.divY.Name = "divY";
            this.divY.Size = new System.Drawing.Size(81, 22);
            this.divY.TabIndex = 10;
            this.divY.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(217, 354);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Tỷ lệ trục Y";
            // 
            // divX
            // 
            this.divX.Location = new System.Drawing.Point(118, 349);
            this.divX.Margin = new System.Windows.Forms.Padding(4);
            this.divX.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.divX.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.divX.Name = "divX";
            this.divX.Size = new System.Drawing.Size(81, 22);
            this.divX.TabIndex = 9;
            this.divX.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 354);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Tỷ lệ trục X";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(217, 385);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Độ nhạy polar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 420);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Chế độ";
            // 
            // sensitivity
            // 
            this.sensitivity.Enabled = false;
            this.sensitivity.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.sensitivity.Location = new System.Drawing.Point(329, 380);
            this.sensitivity.Margin = new System.Windows.Forms.Padding(4);
            this.sensitivity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.sensitivity.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.sensitivity.Name = "sensitivity";
            this.sensitivity.Size = new System.Drawing.Size(81, 22);
            this.sensitivity.TabIndex = 12;
            this.sensitivity.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // mode
            // 
            this.mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mode.FormattingEnabled = true;
            this.mode.Items.AddRange(new object[] {
            "Cartesian",
            "Polar"});
            this.mode.Location = new System.Drawing.Point(118, 415);
            this.mode.Margin = new System.Windows.Forms.Padding(4);
            this.mode.Name = "mode";
            this.mode.Size = new System.Drawing.Size(291, 24);
            this.mode.TabIndex = 11;
            this.mode.SelectedIndexChanged += new System.EventHandler(this.mode_SelectedIndexChanged);
            // 
            // penWidth
            // 
            this.penWidth.Location = new System.Drawing.Point(118, 380);
            this.penWidth.Margin = new System.Windows.Forms.Padding(4);
            this.penWidth.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.penWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.penWidth.Name = "penWidth";
            this.penWidth.Size = new System.Drawing.Size(81, 22);
            this.penWidth.TabIndex = 26;
            this.penWidth.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 385);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 16);
            this.label12.TabIndex = 27;
            this.label12.Text = "Bề rộng nét vẽ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hToolStripMenuItem,
            this.toánTửToolStripMenuItem,
            this.thôngTinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(429, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hToolStripMenuItem
            // 
            this.hToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.absToolStripMenuItem,
            this.sinToolStripMenuItem,
            this.cosToolStripMenuItem,
            this.tanToolStripMenuItem,
            this.secToolStripMenuItem,
            this.cosecToolStripMenuItem,
            this.cotToolStripMenuItem,
            this.arcsinToolStripMenuItem,
            this.arccosToolStripMenuItem,
            this.arctanToolStripMenuItem,
            this.expToolStripMenuItem,
            this.lnToolStripMenuItem,
            this.logToolStripMenuItem,
            this.antilogToolStripMenuItem,
            this.sqrtToolStripMenuItem,
            this.sinhToolStripMenuItem,
            this.coshToolStripMenuItem,
            this.tanhToolStripMenuItem,
            this.arcsinhToolStripMenuItem,
            this.arccoshToolStripMenuItem,
            this.arctanhToolStripMenuItem});
            this.hToolStripMenuItem.Name = "hToolStripMenuItem";
            this.hToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.hToolStripMenuItem.Text = "Hàm số";
            // 
            // absToolStripMenuItem
            // 
            this.absToolStripMenuItem.Name = "absToolStripMenuItem";
            this.absToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.absToolStripMenuItem.Text = "abs";
            this.absToolStripMenuItem.Click += new System.EventHandler(this.absToolStripMenuItem_Click);
            // 
            // sinToolStripMenuItem
            // 
            this.sinToolStripMenuItem.Name = "sinToolStripMenuItem";
            this.sinToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.sinToolStripMenuItem.Text = "sin";
            this.sinToolStripMenuItem.Click += new System.EventHandler(this.sinToolStripMenuItem_Click);
            // 
            // cosToolStripMenuItem
            // 
            this.cosToolStripMenuItem.Name = "cosToolStripMenuItem";
            this.cosToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.cosToolStripMenuItem.Text = "cos";
            this.cosToolStripMenuItem.Click += new System.EventHandler(this.cosToolStripMenuItem_Click);
            // 
            // tanToolStripMenuItem
            // 
            this.tanToolStripMenuItem.Name = "tanToolStripMenuItem";
            this.tanToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.tanToolStripMenuItem.Text = "tan";
            this.tanToolStripMenuItem.Click += new System.EventHandler(this.tanToolStripMenuItem_Click);
            // 
            // secToolStripMenuItem
            // 
            this.secToolStripMenuItem.Name = "secToolStripMenuItem";
            this.secToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.secToolStripMenuItem.Text = "sec";
            this.secToolStripMenuItem.Click += new System.EventHandler(this.secToolStripMenuItem_Click);
            // 
            // cosecToolStripMenuItem
            // 
            this.cosecToolStripMenuItem.Name = "cosecToolStripMenuItem";
            this.cosecToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.cosecToolStripMenuItem.Text = "cosec";
            this.cosecToolStripMenuItem.Click += new System.EventHandler(this.cosecToolStripMenuItem_Click);
            // 
            // cotToolStripMenuItem
            // 
            this.cotToolStripMenuItem.Name = "cotToolStripMenuItem";
            this.cotToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.cotToolStripMenuItem.Text = "cot";
            this.cotToolStripMenuItem.Click += new System.EventHandler(this.cotToolStripMenuItem_Click);
            // 
            // arcsinToolStripMenuItem
            // 
            this.arcsinToolStripMenuItem.Name = "arcsinToolStripMenuItem";
            this.arcsinToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.arcsinToolStripMenuItem.Text = "arcsin";
            this.arcsinToolStripMenuItem.Click += new System.EventHandler(this.arcsinToolStripMenuItem_Click);
            // 
            // arccosToolStripMenuItem
            // 
            this.arccosToolStripMenuItem.Name = "arccosToolStripMenuItem";
            this.arccosToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.arccosToolStripMenuItem.Text = "arccos";
            this.arccosToolStripMenuItem.Click += new System.EventHandler(this.arccosToolStripMenuItem_Click);
            // 
            // arctanToolStripMenuItem
            // 
            this.arctanToolStripMenuItem.Name = "arctanToolStripMenuItem";
            this.arctanToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.arctanToolStripMenuItem.Text = "arctan";
            this.arctanToolStripMenuItem.Click += new System.EventHandler(this.arctanToolStripMenuItem_Click);
            // 
            // expToolStripMenuItem
            // 
            this.expToolStripMenuItem.Name = "expToolStripMenuItem";
            this.expToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.expToolStripMenuItem.Text = "exp";
            this.expToolStripMenuItem.Click += new System.EventHandler(this.expToolStripMenuItem_Click);
            // 
            // lnToolStripMenuItem
            // 
            this.lnToolStripMenuItem.Name = "lnToolStripMenuItem";
            this.lnToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.lnToolStripMenuItem.Text = "ln";
            this.lnToolStripMenuItem.Click += new System.EventHandler(this.lnToolStripMenuItem_Click);
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.logToolStripMenuItem.Text = "log";
            this.logToolStripMenuItem.Click += new System.EventHandler(this.logToolStripMenuItem_Click);
            // 
            // antilogToolStripMenuItem
            // 
            this.antilogToolStripMenuItem.Name = "antilogToolStripMenuItem";
            this.antilogToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.antilogToolStripMenuItem.Text = "antilog";
            this.antilogToolStripMenuItem.Click += new System.EventHandler(this.antilogToolStripMenuItem_Click);
            // 
            // sqrtToolStripMenuItem
            // 
            this.sqrtToolStripMenuItem.Name = "sqrtToolStripMenuItem";
            this.sqrtToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.sqrtToolStripMenuItem.Text = "sqrt";
            this.sqrtToolStripMenuItem.Click += new System.EventHandler(this.sqrtToolStripMenuItem_Click);
            // 
            // sinhToolStripMenuItem
            // 
            this.sinhToolStripMenuItem.Name = "sinhToolStripMenuItem";
            this.sinhToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.sinhToolStripMenuItem.Text = "sinh";
            this.sinhToolStripMenuItem.Click += new System.EventHandler(this.sinhToolStripMenuItem_Click);
            // 
            // coshToolStripMenuItem
            // 
            this.coshToolStripMenuItem.Name = "coshToolStripMenuItem";
            this.coshToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.coshToolStripMenuItem.Text = "cosh";
            this.coshToolStripMenuItem.Click += new System.EventHandler(this.coshToolStripMenuItem_Click);
            // 
            // tanhToolStripMenuItem
            // 
            this.tanhToolStripMenuItem.Name = "tanhToolStripMenuItem";
            this.tanhToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.tanhToolStripMenuItem.Text = "tanh";
            this.tanhToolStripMenuItem.Click += new System.EventHandler(this.tanhToolStripMenuItem_Click);
            // 
            // arcsinhToolStripMenuItem
            // 
            this.arcsinhToolStripMenuItem.Name = "arcsinhToolStripMenuItem";
            this.arcsinhToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.arcsinhToolStripMenuItem.Text = "arcsinh";
            this.arcsinhToolStripMenuItem.Click += new System.EventHandler(this.arcsinhToolStripMenuItem_Click);
            // 
            // arccoshToolStripMenuItem
            // 
            this.arccoshToolStripMenuItem.Name = "arccoshToolStripMenuItem";
            this.arccoshToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.arccoshToolStripMenuItem.Text = "arccosh";
            this.arccoshToolStripMenuItem.Click += new System.EventHandler(this.arccoshToolStripMenuItem_Click);
            // 
            // arctanhToolStripMenuItem
            // 
            this.arctanhToolStripMenuItem.Name = "arctanhToolStripMenuItem";
            this.arctanhToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.arctanhToolStripMenuItem.Text = "arctanh";
            this.arctanhToolStripMenuItem.Click += new System.EventHandler(this.arctanhToolStripMenuItem_Click);
            // 
            // toánTửToolStripMenuItem
            // 
            this.toánTửToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8});
            this.toánTửToolStripMenuItem.Name = "toánTửToolStripMenuItem";
            this.toánTửToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.toánTửToolStripMenuItem.Text = "Toán tử";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(93, 22);
            this.toolStripMenuItem2.Text = "+";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(93, 22);
            this.toolStripMenuItem3.Text = "--";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(93, 22);
            this.toolStripMenuItem4.Text = "*";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(93, 22);
            this.toolStripMenuItem5.Text = "/";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(93, 22);
            this.toolStripMenuItem6.Text = "^";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(93, 22);
            this.toolStripMenuItem7.Text = "(";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(93, 22);
            this.toolStripMenuItem8.Text = ")";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tácGiảToolStripMenuItem});
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.thôngTinToolStripMenuItem.Text = "Thông tin";
            // 
            // tácGiảToolStripMenuItem
            // 
            this.tácGiảToolStripMenuItem.Name = "tácGiảToolStripMenuItem";
            this.tácGiảToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.tácGiảToolStripMenuItem.Text = "Tác giả";
            this.tácGiảToolStripMenuItem.Click += new System.EventHandler(this.tácGiảToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 501);
            this.Controls.Add(this.penWidth);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.mode);
            this.Controls.Add(this.sensitivity);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.divY);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.divX);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.endY);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.startY);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.endX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.startX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdPlotGraph);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtExpression);
            this.Controls.Add(this.lstExpressions);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "VietGraph 1.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.startX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensitivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penWidth)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox lstExpressions;
        private System.Windows.Forms.RichTextBox txtExpression;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button cmdPlotGraph;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown startX;
        private System.Windows.Forms.NumericUpDown endX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown endY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown startY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown divY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown divX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown sensitivity;
        private System.Windows.Forms.ComboBox mode;
        private System.Windows.Forms.NumericUpDown penWidth;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toánTửToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem absToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cosecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arcsinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arccosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arctanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem antilogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sqrtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tanhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arcsinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arccoshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arctanhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tácGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;

    }
}

