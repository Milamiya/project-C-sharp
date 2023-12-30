namespace detai_HoangQuan
{
    partial class frmThem_Album
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThem_Album));
            this.imgIcon = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaAlbum = new System.Windows.Forms.TextBox();
            this.txtTenAlbum = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtnamphathanh = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnTrove = new System.Windows.Forms.Button();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imgIcon
            // 
            this.imgIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgIcon.ImageStream")));
            this.imgIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.imgIcon.Images.SetKeyName(0, "chucnang.jpg");
            this.imgIcon.Images.SetKeyName(1, "Remove.jpg");
            this.imgIcon.Images.SetKeyName(2, "reset.jpg");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(113, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "Thêm ALBUM mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã số album (50 ký tự):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tên album (100 ký tự):";
            // 
            // txtMaAlbum
            // 
            this.txtMaAlbum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaAlbum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtMaAlbum.Location = new System.Drawing.Point(159, 55);
            this.txtMaAlbum.MaxLength = 50;
            this.txtMaAlbum.Name = "txtMaAlbum";
            this.txtMaAlbum.Size = new System.Drawing.Size(268, 24);
            this.txtMaAlbum.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtMaAlbum, "Nhập mã số album, không được trùng với các mã album khác\r\nDùng để phân biệt các a" +
                    "lbum");
            // 
            // txtTenAlbum
            // 
            this.txtTenAlbum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenAlbum.Location = new System.Drawing.Point(159, 85);
            this.txtTenAlbum.MaxLength = 100;
            this.txtTenAlbum.Name = "txtTenAlbum";
            this.txtTenAlbum.Size = new System.Drawing.Size(268, 24);
            this.txtTenAlbum.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Năm phát hành album (4 ký tự):";
            // 
            // txtnamphathanh
            // 
            this.txtnamphathanh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnamphathanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnamphathanh.Location = new System.Drawing.Point(209, 122);
            this.txtnamphathanh.MaxLength = 4;
            this.txtnamphathanh.Name = "txtnamphathanh";
            this.txtnamphathanh.Size = new System.Drawing.Size(218, 24);
            this.txtnamphathanh.TabIndex = 2;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOk.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.ImageIndex = 0;
            this.btnOk.ImageList = this.imgIcon;
            this.btnOk.Location = new System.Drawing.Point(12, 173);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(114, 35);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Đồng ý";
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnOk, "Đồng ý với dử liệu vừa nhập và lưu album này lại");
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnTrove
            // 
            this.btnTrove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTrove.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTrove.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnTrove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrove.ImageIndex = 1;
            this.btnTrove.ImageList = this.imgIcon;
            this.btnTrove.Location = new System.Drawing.Point(256, 173);
            this.btnTrove.Name = "btnTrove";
            this.btnTrove.Size = new System.Drawing.Size(175, 35);
            this.btnTrove.TabIndex = 5;
            this.btnTrove.Text = "Hủy thao tác";
            this.btnTrove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnTrove, "Hủy các thao tác và trở về màn hình chính");
            this.btnTrove.UseVisualStyleBackColor = false;
            this.btnTrove.Click += new System.EventHandler(this.btnTrove_Click);
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNhapLai.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapLai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnNhapLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapLai.ImageIndex = 2;
            this.btnNhapLai.ImageList = this.imgIcon;
            this.btnNhapLai.Location = new System.Drawing.Point(132, 173);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(118, 35);
            this.btnNhapLai.TabIndex = 4;
            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnNhapLai, "Xóa trắng các textbõ và nhập lại");
            this.btnNhapLai.UseVisualStyleBackColor = false;
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
            // 
            // frmThem_Album
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnTrove;
            this.ClientSize = new System.Drawing.Size(440, 220);
            this.Controls.Add(this.txtnamphathanh);
            this.Controls.Add(this.txtTenAlbum);
            this.Controls.Add(this.txtMaAlbum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTrove);
            this.Controls.Add(this.btnNhapLai);
            this.Controls.Add(this.btnOk);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "frmThem_Album";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm ALBUM mới";
            this.Load += new System.EventHandler(this.frmThem_Album_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ImageList imgIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaAlbum;
        private System.Windows.Forms.TextBox txtTenAlbum;
        private System.Windows.Forms.Button btnTrove;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnamphathanh;
    }
}