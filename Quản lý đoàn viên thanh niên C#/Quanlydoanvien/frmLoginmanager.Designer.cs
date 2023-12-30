namespace Quanlydoanvien
{
    partial class frmLoginmanager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoginmanager));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnthem = new DevComponents.DotNetBar.ButtonX();
            this.txtpass = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dgdoanvien = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.lenhxoa = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaNgườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtrole = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.btnxoa = new DevComponents.DotNetBar.ButtonX();
            this.txtuser = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnsua = new DevComponents.DotNetBar.ButtonX();
            this.btnthemmoi = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgdoanvien)).BeginInit();
            this.lenhxoa.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnthem
            // 
            this.btnthem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnthem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnthem.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnthem.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.Image")));
            this.btnthem.Location = new System.Drawing.Point(34, 96);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 33);
            this.btnthem.TabIndex = 8;
            this.btnthem.Text = "Lưu";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txtpass
            // 
            // 
            // 
            // 
            this.txtpass.Border.Class = "TextBoxBorder";
            this.txtpass.Location = new System.Drawing.Point(148, 64);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(121, 20);
            this.txtpass.TabIndex = 4;
            this.txtpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgdoanvien
            // 
            this.dgdoanvien.BackgroundColor = System.Drawing.Color.Yellow;
            this.dgdoanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdoanvien.ContextMenuStrip = this.lenhxoa;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgdoanvien.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgdoanvien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgdoanvien.Location = new System.Drawing.Point(2, 123);
            this.dgdoanvien.Name = "dgdoanvien";
            this.dgdoanvien.ReadOnly = true;
            this.dgdoanvien.Size = new System.Drawing.Size(328, 183);
            this.dgdoanvien.TabIndex = 2;
            // 
            // lenhxoa
            // 
            this.lenhxoa.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lenhxoa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaNgườiDùngToolStripMenuItem});
            this.lenhxoa.Name = "lenhxoa";
            this.lenhxoa.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.lenhxoa.Size = new System.Drawing.Size(195, 26);
            // 
            // xóaNgườiDùngToolStripMenuItem
            // 
            this.xóaNgườiDùngToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("xóaNgườiDùngToolStripMenuItem.Image")));
            this.xóaNgườiDùngToolStripMenuItem.Name = "xóaNgườiDùngToolStripMenuItem";
            this.xóaNgườiDùngToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.xóaNgườiDùngToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.xóaNgườiDùngToolStripMenuItem.Text = "Xóa Người Dùng";
            this.xóaNgườiDùngToolStripMenuItem.Click += new System.EventHandler(this.xóaNgườiDùngToolStripMenuItem_Click);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.Snow;
            this.labelX1.Location = new System.Drawing.Point(55, 30);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(88, 24);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Tên người dùng";
            // 
            // txtrole
            // 
            this.txtrole.DisplayMember = "Text";
            this.txtrole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtrole.FormattingEnabled = true;
            this.txtrole.ItemHeight = 14;
            this.txtrole.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2});
            this.txtrole.Location = new System.Drawing.Point(148, 94);
            this.txtrole.Name = "txtrole";
            this.txtrole.Size = new System.Drawing.Size(121, 20);
            this.txtrole.TabIndex = 6;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "Admin";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "user";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.Red;
            this.labelX2.Location = new System.Drawing.Point(107, 95);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(36, 15);
            this.labelX2.TabIndex = 5;
            this.labelX2.Text = "Quyền";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.ForeColor = System.Drawing.Color.MintCream;
            this.labelX3.Location = new System.Drawing.Point(85, 64);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(48, 22);
            this.labelX3.TabIndex = 3;
            this.labelX3.Text = "Mật khẩu";
            // 
            // btnxoa
            // 
            this.btnxoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnxoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnxoa.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnxoa.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.Image")));
            this.btnxoa.Location = new System.Drawing.Point(34, 160);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 33);
            this.btnxoa.TabIndex = 9;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // txtuser
            // 
            // 
            // 
            // 
            this.txtuser.Border.Class = "TextBoxBorder";
            this.txtuser.Location = new System.Drawing.Point(148, 31);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(121, 20);
            this.txtuser.TabIndex = 2;
            this.txtuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnsua
            // 
            this.btnsua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnsua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnsua.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnsua.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.Image")));
            this.btnsua.Location = new System.Drawing.Point(34, 227);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 33);
            this.btnsua.TabIndex = 10;
            this.btnsua.Text = "Sửa";
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthemmoi
            // 
            this.btnthemmoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnthemmoi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnthemmoi.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnthemmoi.Image = ((System.Drawing.Image)(resources.GetObject("btnthemmoi.Image")));
            this.btnthemmoi.Location = new System.Drawing.Point(34, 29);
            this.btnthemmoi.Name = "btnthemmoi";
            this.btnthemmoi.Size = new System.Drawing.Size(79, 34);
            this.btnthemmoi.TabIndex = 7;
            this.btnthemmoi.Text = "Thêm user ";
            this.btnthemmoi.Click += new System.EventHandler(this.btnthemmoi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnthemmoi);
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(336, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 290);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Các chức năng";
            // 
            // frmLoginmanager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(496, 327);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgdoanvien);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtrole);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLoginmanager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý người dùng (Administrator)";
            this.Load += new System.EventHandler(this.frmLoginmanager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdoanvien)).EndInit();
            this.lenhxoa.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnthem;
        private DevComponents.DotNetBar.Controls.TextBoxX txtpass;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgdoanvien;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx txtrole;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.ButtonX btnxoa;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtuser;
        private DevComponents.DotNetBar.ButtonX btnsua;
        private DevComponents.DotNetBar.ButtonX btnthemmoi;
        private System.Windows.Forms.ContextMenuStrip lenhxoa;
        private System.Windows.Forms.ToolStripMenuItem xóaNgườiDùngToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}