using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MC_TH_PhoneBook_K55B
{
    partial class FrmPlaceSearch
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
            this.lblPlaceSearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dtGridPlaceSearch = new System.Windows.Forms.DataGrid();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridPlaceSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlaceSearch
            // 
            this.lblPlaceSearch.AutoSize = true;
            this.lblPlaceSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaceSearch.Location = new System.Drawing.Point(216, 40);
            this.lblPlaceSearch.Name = "lblPlaceSearch";
            this.lblPlaceSearch.Size = new System.Drawing.Size(37, 18);
            this.lblPlaceSearch.TabIndex = 0;
            this.lblPlaceSearch.Text = "Tìm:";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(507, 40);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(362, 366);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Đóng lại";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dtGridPlaceSearch
            // 
            this.dtGridPlaceSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.dtGridPlaceSearch.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtGridPlaceSearch.CaptionVisible = false;
            this.dtGridPlaceSearch.DataMember = "";
            this.dtGridPlaceSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtGridPlaceSearch.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dtGridPlaceSearch.Location = new System.Drawing.Point(1, 82);
            this.dtGridPlaceSearch.Name = "dtGridPlaceSearch";
            this.dtGridPlaceSearch.ReadOnly = true;
            this.dtGridPlaceSearch.Size = new System.Drawing.Size(796, 278);
            this.dtGridPlaceSearch.TabIndex = 4;
            // 
            // tbxSearch
            // 
            this.tbxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearch.Location = new System.Drawing.Point(259, 38);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(230, 24);
            this.tbxSearch.TabIndex = 5;
            this.tbxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxSearch_KeyDown);
            // 
            // FrmPlaceSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 396);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.dtGridPlaceSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblPlaceSearch);
            this.MaximizeBox = false;
            this.Name = "FrmPlaceSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh bạ điện thoại - Tìm kiếm địa điểm";
            this.Load += new System.EventHandler(this.FrmPlaceSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridPlaceSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlaceSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGrid dtGridPlaceSearch;
        private TextBox tbxSearch;
    }
}