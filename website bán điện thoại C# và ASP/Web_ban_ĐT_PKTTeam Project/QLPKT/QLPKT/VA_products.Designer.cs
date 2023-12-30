namespace QLPKT
{
    partial class VA_products
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VA_products));
            this.va = new System.Windows.Forms.TabControl();
            this.View = new System.Windows.Forms.TabPage();
            this.buttom_cancel = new System.Windows.Forms.PictureBox();
            this.SearchBox = new System.Windows.Forms.GroupBox();
            this.search2 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.ComboBox();
            this.buttom_showall = new System.Windows.Forms.PictureBox();
            this.buttom_search = new System.Windows.Forms.PictureBox();
            this.search = new System.Windows.Forms.TextBox();
            this.buttom_ok = new System.Windows.Forms.PictureBox();
            this.data = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Addp = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttom_ok2 = new System.Windows.Forms.PictureBox();
            this.clas = new System.Windows.Forms.ComboBox();
            this.factory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nameproducts = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.va.SuspendLayout();
            this.View.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttom_cancel)).BeginInit();
            this.SearchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttom_showall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttom_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttom_ok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.Addp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttom_ok2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // va
            // 
            this.va.Controls.Add(this.View);
            this.va.Controls.Add(this.Addp);
            this.va.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.va.Location = new System.Drawing.Point(13, 13);
            this.va.Name = "va";
            this.va.SelectedIndex = 0;
            this.va.Size = new System.Drawing.Size(474, 293);
            this.va.TabIndex = 14;
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
            this.SearchBox.Controls.Add(this.search2);
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
            // search2
            // 
            this.search2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search2.FormattingEnabled = true;
            this.search2.Items.AddRange(new object[] {
            "Smart phone",
            "Phổ thông"});
            this.search2.Location = new System.Drawing.Point(11, 18);
            this.search2.Name = "search2";
            this.search2.Size = new System.Drawing.Size(219, 21);
            this.search2.TabIndex = 66;
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
            "ID",
            "Brand"});
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.TenSX});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data.DefaultCellStyle = dataGridViewCellStyle4;
            this.data.GridColor = System.Drawing.SystemColors.Control;
            this.data.Location = new System.Drawing.Point(6, 99);
            this.data.MultiSelect = false;
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data.Size = new System.Drawing.Size(454, 162);
            this.data.TabIndex = 3;
            this.data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellClick);
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "MaSP";
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            this.MaSP.Width = 50;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên Điện Thoại";
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            this.TenSP.Width = 150;
            // 
            // TenSX
            // 
            this.TenSX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenSX.DataPropertyName = "TenSX";
            this.TenSX.HeaderText = "Nhà Sản Xuất";
            this.TenSX.Name = "TenSX";
            this.TenSX.ReadOnly = true;
            // 
            // Addp
            // 
            this.Addp.Controls.Add(this.panel1);
            this.Addp.Location = new System.Drawing.Point(4, 22);
            this.Addp.Name = "Addp";
            this.Addp.Padding = new System.Windows.Forms.Padding(3);
            this.Addp.Size = new System.Drawing.Size(466, 267);
            this.Addp.TabIndex = 1;
            this.Addp.Text = "Add new";
            this.Addp.UseVisualStyleBackColor = true;
            this.Addp.Click += new System.EventHandler(this.Add_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(248, 162);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 25);
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.buttom_cancel_Click);
            // 
            // buttom_ok2
            // 
            this.buttom_ok2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttom_ok2.BackgroundImage")));
            this.buttom_ok2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttom_ok2.Location = new System.Drawing.Point(140, 162);
            this.buttom_ok2.Name = "buttom_ok2";
            this.buttom_ok2.Size = new System.Drawing.Size(79, 25);
            this.buttom_ok2.TabIndex = 72;
            this.buttom_ok2.TabStop = false;
            this.buttom_ok2.Click += new System.EventHandler(this.buttom_ok2_Click);
            // 
            // clas
            // 
            this.clas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clas.FormattingEnabled = true;
            this.clas.Items.AddRange(new object[] {
            "Smart phone",
            "Phổ thông"});
            this.clas.Location = new System.Drawing.Point(140, 111);
            this.clas.Name = "clas";
            this.clas.Size = new System.Drawing.Size(246, 24);
            this.clas.TabIndex = 71;
            // 
            // factory
            // 
            this.factory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factory.FormattingEnabled = true;
            this.factory.Location = new System.Drawing.Point(140, 73);
            this.factory.Name = "factory";
            this.factory.Size = new System.Drawing.Size(246, 24);
            this.factory.TabIndex = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(19, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 64;
            this.label5.Text = "Nhà sản xuất:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(20, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 69;
            this.label7.Text = "Phân loại:";
            // 
            // nameproducts
            // 
            this.nameproducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameproducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameproducts.Location = new System.Drawing.Point(140, 38);
            this.nameproducts.Name = "nameproducts";
            this.nameproducts.Size = new System.Drawing.Size(246, 22);
            this.nameproducts.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(19, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 65;
            this.label2.Text = "Tên sản phẩm";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.nameproducts);
            this.panel1.Controls.Add(this.buttom_ok2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.clas);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.factory);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(28, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 223);
            this.panel1.TabIndex = 74;
            // 
            // VA_products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(494, 312);
            this.Controls.Add(this.va);
            this.Name = "VA_products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VA_products";
            this.Load += new System.EventHandler(this.VA_products_Load);
            this.va.ResumeLayout(false);
            this.View.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttom_cancel)).EndInit();
            this.SearchBox.ResumeLayout(false);
            this.SearchBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttom_showall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttom_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttom_ok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.Addp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttom_ok2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox buttom_ok;
        private System.Windows.Forms.TabControl va;
        private System.Windows.Forms.TabPage View;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSX;
        private System.Windows.Forms.TabPage Addp;
        private System.Windows.Forms.GroupBox SearchBox;
        private System.Windows.Forms.ComboBox search2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.PictureBox buttom_showall;
        private System.Windows.Forms.PictureBox buttom_search;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.PictureBox buttom_cancel;
        private System.Windows.Forms.ComboBox clas;
        private System.Windows.Forms.ComboBox factory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nameproducts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox buttom_ok2;
        private System.Windows.Forms.Panel panel1;
    }
}