namespace School._forms
{
    partial class frmFindExp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lstv_Findexp = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.rdoID = new System.Windows.Forms.RadioButton();
            this.rdoName = new System.Windows.Forms.RadioButton();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_Find = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::School.Properties.Resources.top;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 98);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(476, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 21);
            this.button1.TabIndex = 48;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(206)))), ((int)(((byte)(104)))));
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(15, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Find Expenses";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::School.Properties.Resources.listshadow;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lstv_Findexp);
            this.panel3.Location = new System.Drawing.Point(10, 147);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(510, 263);
            this.panel3.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Double Click to Select";
            // 
            // lstv_Findexp
            // 
            this.lstv_Findexp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3});
            this.lstv_Findexp.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstv_Findexp.FullRowSelect = true;
            this.lstv_Findexp.GridLines = true;
            this.lstv_Findexp.Location = new System.Drawing.Point(18, 12);
            this.lstv_Findexp.Name = "lstv_Findexp";
            this.lstv_Findexp.Size = new System.Drawing.Size(462, 225);
            this.lstv_Findexp.TabIndex = 1;
            this.lstv_Findexp.UseCompatibleStateImageBehavior = false;
            this.lstv_Findexp.View = System.Windows.Forms.View.Details;
            this.lstv_Findexp.DoubleClick += new System.EventHandler(this.lstv_Findexp_DoubleClick);
            this.lstv_Findexp.Click += new System.EventHandler(this.lstv_Findexp_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Exp ID";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Expense Name";
            this.columnHeader3.Width = 379;
            // 
            // rdoID
            // 
            this.rdoID.AutoSize = true;
            this.rdoID.Location = new System.Drawing.Point(109, 121);
            this.rdoID.Name = "rdoID";
            this.rdoID.Size = new System.Drawing.Size(51, 17);
            this.rdoID.TabIndex = 46;
            this.rdoID.TabStop = true;
            this.rdoID.Text = "By ID";
            this.rdoID.UseVisualStyleBackColor = true;
            // 
            // rdoName
            // 
            this.rdoName.AutoSize = true;
            this.rdoName.Location = new System.Drawing.Point(41, 121);
            this.rdoName.Name = "rdoName";
            this.rdoName.Size = new System.Drawing.Size(68, 17);
            this.rdoName.TabIndex = 45;
            this.rdoName.TabStop = true;
            this.rdoName.Text = "By Name";
            this.rdoName.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label18.Location = new System.Drawing.Point(171, 104);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(206, 13);
            this.label18.TabIndex = 53;
            this.label18.Text = "Type The Expense Name or ID for Search";
            // 
            // txt_Find
            // 
            this.txt_Find.BackColor = System.Drawing.Color.Khaki;
            this.txt_Find.Location = new System.Drawing.Point(173, 120);
            this.txt_Find.Name = "txt_Find";
            this.txt_Find.Size = new System.Drawing.Size(238, 20);
            this.txt_Find.TabIndex = 52;
            this.txt_Find.TextChanged += new System.EventHandler(this.txt_Find_TextChanged);
            // 
            // frmFindExp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(525, 416);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txt_Find);
            this.Controls.Add(this.rdoID);
            this.Controls.Add(this.rdoName);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFindExp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmFindExp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView lstv_Findexp;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.RadioButton rdoID;
        private System.Windows.Forms.RadioButton rdoName;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_Find;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}