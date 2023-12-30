namespace QLPKT
{
    partial class VA_brand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VA_brand));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.View = new System.Windows.Forms.TabPage();
            this.buttom_cancel = new System.Windows.Forms.PictureBox();
            this.SearchBox = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.ComboBox();
            this.buttom_showall = new System.Windows.Forms.PictureBox();
            this.buttom_search = new System.Windows.Forms.PictureBox();
            this.search = new System.Windows.Forms.TextBox();
            this.buttom_ok = new System.Windows.Forms.PictureBox();
            this.data = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.name = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttom_ok2 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.View.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttom_cancel)).BeginInit();
            this.SearchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttom_showall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttom_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttom_ok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.Add.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttom_ok2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.View);
            this.tabControl1.Controls.Add(this.Add);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(10, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(474, 293);
            this.tabControl1.TabIndex = 15;
            // 
            // View
            // 
            this.View.Controls.Add(this.buttom_cancel);
            this.View.Controls.Add(this.SearchBox);
            this.View.Controls.Add(this.buttom_ok);
            this.View.Controls.Add(this.data);
            this.View.ForeColor = System.Drawing.Color.Black;
            this.View.Location = new System.Drawing.Point(4, 22);
            this.View.Name = "View";
            this.View.Padding = new System.Windows.Forms.Padding(3);
            this.View.Size = new System.Drawing.Size(466, 267);
            this.View.TabIndex = 0;
            this.View.Text = "Search";
            this.View.UseVisualStyleBackColor = true;
            // 
            // buttom_cancel
            // 
            this.buttom_cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttom_cancel.BackgroundImage")));
            this.buttom_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttom_cancel.Location = new System.Drawing.Point(366, 55);
            this.buttom_cancel.Name = "buttom_cancel";
            this.buttom_cancel.Size = new System.Drawing.Size(79, 25);
            this.buttom_cancel.TabIndex = 14;
            this.buttom_cancel.TabStop = false;
            this.buttom_cancel.Click += new System.EventHandler(this.buttom_cancel_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Controls.Add(this.label13);
            this.SearchBox.Controls.Add(this.type);
            this.SearchBox.Controls.Add(this.buttom_showall);
            this.SearchBox.Controls.Add(this.buttom_search);
            this.SearchBox.Controls.Add(this.search);
            this.SearchBox.ForeColor = System.Drawing.Color.Red;
            this.SearchBox.Location = new System.Drawing.Point(6, 6);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(329, 87);
            this.SearchBox.TabIndex = 12;
            this.SearchBox.TabStop = false;
            this.SearchBox.Text = "Search";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label13.Location = new System.Drawing.Point(233, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 15);
            this.label13.TabIndex = 40;
            this.label13.Text = "by";
            // 
            // type
            // 
            this.type.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "Name",
            "ID"});
            this.type.Location = new System.Drawing.Point(253, 18);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(66, 21);
            this.type.TabIndex = 3;
            this.type.SelectedIndexChanged += new System.EventHandler(this.type_SelectedIndexChanged);
            // 
            // buttom_showall
            // 
            this.buttom_showall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttom_showall.BackgroundImage")));
            this.buttom_showall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttom_showall.Location = new System.Drawing.Point(170, 48);
            this.buttom_showall.Name = "buttom_showall";
            this.buttom_showall.Size = new System.Drawing.Size(86, 25);
            this.buttom_showall.TabIndex = 2;
            this.buttom_showall.TabStop = false;
            this.buttom_showall.Click += new System.EventHandler(this.buttom_showall_Click);
            // 
            // buttom_search
            // 
            this.buttom_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttom_search.BackgroundImage")));
            this.buttom_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttom_search.Location = new System.Drawing.Point(64, 48);
            this.buttom_search.Name = "buttom_search";
            this.buttom_search.Size = new System.Drawing.Size(86, 25);
            this.buttom_search.TabIndex = 1;
            this.buttom_search.TabStop = false;
            this.buttom_search.Click += new System.EventHandler(this.buttom_search_Click);
            // 
            // search
            // 
            this.search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.search.Location = new System.Drawing.Point(11, 19);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(219, 20);
            this.search.TabIndex = 0;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // buttom_ok
            // 
            this.buttom_ok.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttom_ok.BackgroundImage")));
            this.buttom_ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttom_ok.Location = new System.Drawing.Point(366, 18);
            this.buttom_ok.Name = "buttom_ok";
            this.buttom_ok.Size = new System.Drawing.Size(79, 25);
            this.buttom_ok.TabIndex = 13;
            this.buttom_ok.TabStop = false;
            this.buttom_ok.Click += new System.EventHandler(this.buttom_ok_Click);
            // 
            // data
            // 
            this.data.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSX});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data.DefaultCellStyle = dataGridViewCellStyle2;
            this.data.GridColor = System.Drawing.SystemColors.Control;
            this.data.Location = new System.Drawing.Point(6, 99);
            this.data.MultiSelect = false;
            this.data.Name = "data";
            this.data.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data.Size = new System.Drawing.Size(454, 162);
            this.data.TabIndex = 3;
            this.data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellClick);
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSX";
            this.MaSP.HeaderText = "Mã NSX";
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            // 
            // TenSX
            // 
            this.TenSX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenSX.DataPropertyName = "TenSX";
            this.TenSX.HeaderText = "Nhà Sản Xuất";
            this.TenSX.Name = "TenSX";
            this.TenSX.ReadOnly = true;
            // 
            // Add
            // 
            this.Add.Controls.Add(this.panel1);
            this.Add.Location = new System.Drawing.Point(4, 22);
            this.Add.Name = "Add";
            this.Add.Padding = new System.Windows.Forms.Padding(3);
            this.Add.Size = new System.Drawing.Size(466, 267);
            this.Add.TabIndex = 1;
            this.Add.Text = "Add new";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttom_ok2);
            this.panel1.Location = new System.Drawing.Point(20, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 111);
            this.panel1.TabIndex = 74;
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(143, 19);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(246, 22);
            this.name.TabIndex = 66;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(251, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 25);
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.buttom_cancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(22, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 65;
            this.label2.Text = "Name of brand:";
            // 
            // buttom_ok2
            // 
            this.buttom_ok2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttom_ok2.BackgroundImage")));
            this.buttom_ok2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttom_ok2.Location = new System.Drawing.Point(143, 60);
            this.buttom_ok2.Name = "buttom_ok2";
            this.buttom_ok2.Size = new System.Drawing.Size(79, 25);
            this.buttom_ok2.TabIndex = 72;
            this.buttom_ok2.TabStop = false;
            this.buttom_ok2.Click += new System.EventHandler(this.buttom_ok2_Click);
            // 
            // VA_brand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 312);
            this.Controls.Add(this.tabControl1);
            this.Name = "VA_brand";
            this.Text = "AV_brand";
            this.Load += new System.EventHandler(this.VA_brand_Load);
            this.tabControl1.ResumeLayout(false);
            this.View.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttom_cancel)).EndInit();
            this.SearchBox.ResumeLayout(false);
            this.SearchBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttom_showall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttom_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttom_ok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.Add.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttom_ok2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage View;
        private System.Windows.Forms.PictureBox buttom_cancel;
        private System.Windows.Forms.GroupBox SearchBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.PictureBox buttom_showall;
        private System.Windows.Forms.PictureBox buttom_search;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.PictureBox buttom_ok;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.TabPage Add;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox buttom_ok2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSX;
        private System.Windows.Forms.Panel panel1;
    }
}