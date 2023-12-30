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
    partial class FrmUnitSearch
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
            this.lblUnitSearch = new System.Windows.Forms.Label();
            this.cbxUnitSearch = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtGridUnitSearch = new System.Windows.Forms.DataGrid();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbxNameUnit = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridUnitSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUnitSearch
            // 
            this.lblUnitSearch.AutoSize = true;
            this.lblUnitSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitSearch.Location = new System.Drawing.Point(52, 39);
            this.lblUnitSearch.Name = "lblUnitSearch";
            this.lblUnitSearch.Size = new System.Drawing.Size(70, 18);
            this.lblUnitSearch.TabIndex = 0;
            this.lblUnitSearch.Text = "Tìm theo:";
            // 
            // cbxUnitSearch
            // 
            this.cbxUnitSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUnitSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUnitSearch.Items.AddRange(new object[] {
            "Khoa",
            "Phòng ban"});
            this.cbxUnitSearch.Location = new System.Drawing.Point(128, 39);
            this.cbxUnitSearch.Name = "cbxUnitSearch";
            this.cbxUnitSearch.Size = new System.Drawing.Size(147, 26);
            this.cbxUnitSearch.TabIndex = 1;
            this.cbxUnitSearch.SelectedIndexChanged += new System.EventHandler(this.cbxUnitSearch_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(294, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 18);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Tên:";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(292, 89);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtGridUnitSearch
            // 
            this.dtGridUnitSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.dtGridUnitSearch.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtGridUnitSearch.CaptionVisible = false;
            this.dtGridUnitSearch.DataMember = "";
            this.dtGridUnitSearch.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dtGridUnitSearch.Location = new System.Drawing.Point(2, 118);
            this.dtGridUnitSearch.Name = "dtGridUnitSearch";
            this.dtGridUnitSearch.ReadOnly = true;
            this.dtGridUnitSearch.Size = new System.Drawing.Size(656, 324);
            this.dtGridUnitSearch.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(289, 458);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 25);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Đóng lại";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbxNameUnit
            // 
            this.tbxNameUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNameUnit.Location = new System.Drawing.Point(350, 39);
            this.tbxNameUnit.Name = "tbxNameUnit";
            this.tbxNameUnit.Size = new System.Drawing.Size(257, 24);
            this.tbxNameUnit.TabIndex = 7;
            this.tbxNameUnit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxNameUnit_KeyDown);
            // 
            // FrmUnitSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 495);
            this.Controls.Add(this.tbxNameUnit);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dtGridUnitSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cbxUnitSearch);
            this.Controls.Add(this.lblUnitSearch);
            this.MaximizeBox = false;
            this.Name = "FrmUnitSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh bạ điện thoại - Tìm kiếm đơn vị";
            this.Load += new System.EventHandler(this.FrmUnitSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridUnitSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUnitSearch;
        private System.Windows.Forms.ComboBox cbxUnitSearch;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGrid dtGridUnitSearch;
        private System.Windows.Forms.Button btnClose;
        private TextBox tbxNameUnit;
    }
}