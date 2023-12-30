namespace detai_HoangQuan
{
    partial class frmThem_NhaSanXuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThem_NhaSanXuat));
            this.txtThongTin = new System.Windows.Forms.RichTextBox();
            this.txtTenHangSX = new System.Windows.Forms.TextBox();
            this.txtMaHangSX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTrove = new System.Windows.Forms.Button();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.imgIcon = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // txtThongTin
            // 
            this.txtThongTin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThongTin.Location = new System.Drawing.Point(9, 146);
            this.txtThongTin.Name = "txtThongTin";
            this.txtThongTin.Size = new System.Drawing.Size(417, 177);
            this.txtThongTin.TabIndex = 33;
            this.txtThongTin.Text = "";
            // 
            // txtTenHangSX
            // 
            this.txtTenHangSX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenHangSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHangSX.Location = new System.Drawing.Point(208, 85);
            this.txtTenHangSX.MaxLength = 100;
            this.txtTenHangSX.Name = "txtTenHangSX";
            this.txtTenHangSX.Size = new System.Drawing.Size(216, 24);
            this.txtTenHangSX.TabIndex = 32;
            // 
            // txtMaHangSX
            // 
            this.txtMaHangSX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaHangSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHangSX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtMaHangSX.Location = new System.Drawing.Point(208, 55);
            this.txtMaHangSX.MaxLength = 50;
            this.txtMaHangSX.Name = "txtMaHangSX";
            this.txtMaHangSX.Size = new System.Drawing.Size(216, 24);
            this.txtMaHangSX.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "Thông tin nhà sản xuất";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Tên Hãng sản xuất (100 ký tự):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 16);
            this.label2.TabIndex = 39;
            this.label2.Text = "Mã số Hãng sản xuất (50 ký tự):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(52, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 35);
            this.label1.TabIndex = 37;
            this.label1.Text = "Thêm NHÀ SẢN XUẤT mới";
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
            this.btnTrove.Location = new System.Drawing.Point(253, 329);
            this.btnTrove.Name = "btnTrove";
            this.btnTrove.Size = new System.Drawing.Size(175, 35);
            this.btnTrove.TabIndex = 36;
            this.btnTrove.Text = "Hủy thao tác";
            this.btnTrove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.btnNhapLai.Location = new System.Drawing.Point(129, 329);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(118, 35);
            this.btnNhapLai.TabIndex = 35;
            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhapLai.UseVisualStyleBackColor = false;
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOk.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.ImageIndex = 0;
            this.btnOk.ImageList = this.imgIcon;
            this.btnOk.Location = new System.Drawing.Point(9, 329);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(114, 35);
            this.btnOk.TabIndex = 34;
            this.btnOk.Text = "Đồng ý";
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // imgIcon
            // 
            this.imgIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgIcon.ImageStream")));
            this.imgIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.imgIcon.Images.SetKeyName(0, "chucnang.jpg");
            this.imgIcon.Images.SetKeyName(1, "Remove.jpg");
            this.imgIcon.Images.SetKeyName(2, "reset.jpg");
            // 
            // frmThem_NhaSanXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 378);
            this.Controls.Add(this.txtThongTin);
            this.Controls.Add(this.txtTenHangSX);
            this.Controls.Add(this.txtMaHangSX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTrove);
            this.Controls.Add(this.btnNhapLai);
            this.Controls.Add(this.btnOk);
            this.Name = "frmThem_NhaSanXuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm NHÀ SẢN XUẤT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtThongTin;
        private System.Windows.Forms.TextBox txtTenHangSX;
        private System.Windows.Forms.TextBox txtMaHangSX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTrove;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ImageList imgIcon;
    }
}