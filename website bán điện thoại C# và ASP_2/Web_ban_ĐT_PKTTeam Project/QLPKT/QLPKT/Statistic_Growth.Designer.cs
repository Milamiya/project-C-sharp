namespace QLPKT
{
    partial class Statistic_Growth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistic_Growth));
            this.pannel_nd = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.typedate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.limit = new System.Windows.Forms.ComboBox();
            this.labelfrom = new System.Windows.Forms.Label();
            this.from = new System.Windows.Forms.ComboBox();
            this.labelto = new System.Windows.Forms.Label();
            this.to = new System.Windows.Forms.ComboBox();
            this.buttom_ok = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.year1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.year2 = new System.Windows.Forms.ComboBox();
            this.listpro = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.buttom_ok)).BeginInit();
            this.SuspendLayout();
            // 
            // pannel_nd
            // 
            this.pannel_nd.Location = new System.Drawing.Point(199, 85);
            this.pannel_nd.Name = "pannel_nd";
            this.pannel_nd.Size = new System.Drawing.Size(600, 380);
            this.pannel_nd.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mục cần xem:";
            // 
            // type
            // 
            this.type.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "Doanh thu ",
            "Lợi nhuận",
            "Doanh số theo sản phẩm"});
            this.type.Location = new System.Drawing.Point(157, 13);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(156, 24);
            this.type.TabIndex = 8;
            this.type.SelectedIndexChanged += new System.EventHandler(this.type_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Xem theo:";
            // 
            // typedate
            // 
            this.typedate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typedate.FormattingEnabled = true;
            this.typedate.Items.AddRange(new object[] {
            "Tháng",
            "Quý",
            "Năm"});
            this.typedate.Location = new System.Drawing.Point(157, 43);
            this.typedate.Name = "typedate";
            this.typedate.Size = new System.Drawing.Size(156, 24);
            this.typedate.TabIndex = 10;
            this.typedate.SelectedIndexChanged += new System.EventHandler(this.typedate_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(330, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Giới hạn:";
            // 
            // limit
            // 
            this.limit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limit.FormattingEnabled = true;
            this.limit.Location = new System.Drawing.Point(405, 13);
            this.limit.Name = "limit";
            this.limit.Size = new System.Drawing.Size(114, 24);
            this.limit.TabIndex = 12;
            this.limit.SelectedIndexChanged += new System.EventHandler(this.limit_SelectedIndexChanged);
            // 
            // labelfrom
            // 
            this.labelfrom.AutoSize = true;
            this.labelfrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfrom.Location = new System.Drawing.Point(330, 47);
            this.labelfrom.Name = "labelfrom";
            this.labelfrom.Size = new System.Drawing.Size(30, 16);
            this.labelfrom.TabIndex = 15;
            this.labelfrom.Text = "Từ:";
            // 
            // from
            // 
            this.from.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from.FormattingEnabled = true;
            this.from.Items.AddRange(new object[] {
            "Theo tháng",
            "Theo quý",
            "Theo năm",
            "Ngày hôm nay",
            "Tuần này"});
            this.from.Location = new System.Drawing.Point(405, 43);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(44, 24);
            this.from.TabIndex = 14;
            this.from.SelectedIndexChanged += new System.EventHandler(this.from_SelectedIndexChanged);
            // 
            // labelto
            // 
            this.labelto.AutoSize = true;
            this.labelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelto.Location = new System.Drawing.Point(550, 48);
            this.labelto.Name = "labelto";
            this.labelto.Size = new System.Drawing.Size(39, 16);
            this.labelto.TabIndex = 17;
            this.labelto.Text = "Đến:";
            // 
            // to
            // 
            this.to.Enabled = false;
            this.to.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to.FormattingEnabled = true;
            this.to.Items.AddRange(new object[] {
            "Theo tháng",
            "Theo quý",
            "Theo năm",
            "Ngày hôm nay",
            "Tuần này"});
            this.to.Location = new System.Drawing.Point(645, 44);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(39, 24);
            this.to.TabIndex = 16;
            // 
            // buttom_ok
            // 
            this.buttom_ok.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttom_ok.BackgroundImage")));
            this.buttom_ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttom_ok.Location = new System.Drawing.Point(585, 13);
            this.buttom_ok.Name = "buttom_ok";
            this.buttom_ok.Size = new System.Drawing.Size(75, 24);
            this.buttom_ok.TabIndex = 19;
            this.buttom_ok.TabStop = false;
            this.buttom_ok.Click += new System.EventHandler(this.buttom_ok_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Chọn sản phẩm:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(449, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Năm:";
            // 
            // year1
            // 
            this.year1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year1.FormattingEnabled = true;
            this.year1.Items.AddRange(new object[] {
            "2011",
            "2012"});
            this.year1.Location = new System.Drawing.Point(494, 45);
            this.year1.Name = "year1";
            this.year1.Size = new System.Drawing.Size(50, 24);
            this.year1.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(686, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Năm:";
            // 
            // year2
            // 
            this.year2.Enabled = false;
            this.year2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year2.FormattingEnabled = true;
            this.year2.Items.AddRange(new object[] {
            "2011",
            "2012"});
            this.year2.Location = new System.Drawing.Point(736, 45);
            this.year2.Name = "year2";
            this.year2.Size = new System.Drawing.Size(50, 24);
            this.year2.TabIndex = 23;
            // 
            // listpro
            // 
            this.listpro.FormattingEnabled = true;
            this.listpro.Location = new System.Drawing.Point(25, 105);
            this.listpro.Name = "listpro";
            this.listpro.Size = new System.Drawing.Size(155, 355);
            this.listpro.TabIndex = 25;
            // 
            // Statistic_Growth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 482);
            this.Controls.Add(this.listpro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.year2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.year1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttom_ok);
            this.Controls.Add(this.labelto);
            this.Controls.Add(this.to);
            this.Controls.Add(this.labelfrom);
            this.Controls.Add(this.from);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.limit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.typedate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.type);
            this.Controls.Add(this.pannel_nd);
            this.Name = "Statistic_Growth";
            this.Text = "Statistic_Growth";
            this.Load += new System.EventHandler(this.Statistic_Growth_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buttom_ok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pannel_nd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox typedate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox limit;
        private System.Windows.Forms.Label labelfrom;
        private System.Windows.Forms.ComboBox from;
        private System.Windows.Forms.Label labelto;
        private System.Windows.Forms.ComboBox to;
        private System.Windows.Forms.PictureBox buttom_ok;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox year1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox year2;
        private System.Windows.Forms.ListBox listpro;
    }
}