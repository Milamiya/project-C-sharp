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
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStaffUp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFacultyUp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDepartmentUp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPlaceUp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStaffSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUnitSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPlaceSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIntroduction = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUpdate,
            this.tsmiSearch,
            this.tsmiIntroduction});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(516, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiUpdate
            // 
            this.tsmiUpdate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiStaffUp,
            this.tsmiFacultyUp,
            this.tsmiDepartmentUp,
            this.tsmiPlaceUp});
            this.tsmiUpdate.Name = "tsmiUpdate";
            this.tsmiUpdate.Size = new System.Drawing.Size(113, 20);
            this.tsmiUpdate.Text = "Cập nhật danh bạ";
            // 
            // tsmiStaffUp
            // 
            this.tsmiStaffUp.Name = "tsmiStaffUp";
            this.tsmiStaffUp.Size = new System.Drawing.Size(183, 22);
            this.tsmiStaffUp.Text = "Cập nhật cán bộ";
            this.tsmiStaffUp.Click += new System.EventHandler(this.tsmiStaffUp_Click);
            // 
            // tsmiFacultyUp
            // 
            this.tsmiFacultyUp.Name = "tsmiFacultyUp";
            this.tsmiFacultyUp.Size = new System.Drawing.Size(183, 22);
            this.tsmiFacultyUp.Text = "Cập nhật Khoa";
            this.tsmiFacultyUp.Click += new System.EventHandler(this.tsmiFacultyUp_Click);
            // 
            // tsmiDepartmentUp
            // 
            this.tsmiDepartmentUp.Name = "tsmiDepartmentUp";
            this.tsmiDepartmentUp.Size = new System.Drawing.Size(183, 22);
            this.tsmiDepartmentUp.Text = "Cập nhật Phòng ban";
            this.tsmiDepartmentUp.Click += new System.EventHandler(this.tsmiDepartmentUp_Click);
            // 
            // tsmiPlaceUp
            // 
            this.tsmiPlaceUp.Name = "tsmiPlaceUp";
            this.tsmiPlaceUp.Size = new System.Drawing.Size(183, 22);
            this.tsmiPlaceUp.Text = "Cập nhật địa điểm";
            this.tsmiPlaceUp.Click += new System.EventHandler(this.tsmiPlaceUp_Click);
            // 
            // tsmiSearch
            // 
            this.tsmiSearch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiStaffSearch,
            this.tsmiUnitSearch,
            this.tsmiPlaceSearch});
            this.tsmiSearch.Name = "tsmiSearch";
            this.tsmiSearch.Size = new System.Drawing.Size(105, 20);
            this.tsmiSearch.Text = "Tra cứu danh bạ";
            // 
            // tsmiStaffSearch
            // 
            this.tsmiStaffSearch.Name = "tsmiStaffSearch";
            this.tsmiStaffSearch.Size = new System.Drawing.Size(173, 22);
            this.tsmiStaffSearch.Text = "Tìm kiếm cán bộ";
            this.tsmiStaffSearch.Click += new System.EventHandler(this.tsmiStaffSearch_Click);
            // 
            // tsmiUnitSearch
            // 
            this.tsmiUnitSearch.Name = "tsmiUnitSearch";
            this.tsmiUnitSearch.Size = new System.Drawing.Size(173, 22);
            this.tsmiUnitSearch.Text = "Tìm kiếm đơn vị";
            this.tsmiUnitSearch.Click += new System.EventHandler(this.tsmiUnitSearch_Click);
            // 
            // tsmiPlaceSearch
            // 
            this.tsmiPlaceSearch.Name = "tsmiPlaceSearch";
            this.tsmiPlaceSearch.Size = new System.Drawing.Size(173, 22);
            this.tsmiPlaceSearch.Text = "Tìm kiếm địa điểm";
            this.tsmiPlaceSearch.Click += new System.EventHandler(this.tsmiPlaceSearch_Click);
            // 
            // tsmiIntroduction
            // 
            this.tsmiIntroduction.Name = "tsmiIntroduction";
            this.tsmiIntroduction.Size = new System.Drawing.Size(70, 20);
            this.tsmiIntroduction.Text = "Giới thiệu";
            this.tsmiIntroduction.Click += new System.EventHandler(this.tsmiIntroduction_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MC_TH_PhoneBook_K55B.Properties.Resources.Mau_xanh;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(516, 333);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh bạ điện thoại - Trang chủ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdate;
        private System.Windows.Forms.ToolStripMenuItem tsmiStaffUp;
        private System.Windows.Forms.ToolStripMenuItem tsmiFacultyUp;
        private System.Windows.Forms.ToolStripMenuItem tsmiDepartmentUp;
        private System.Windows.Forms.ToolStripMenuItem tsmiSearch;
        private System.Windows.Forms.ToolStripMenuItem tsmiStaffSearch;
        private System.Windows.Forms.ToolStripMenuItem tsmiUnitSearch;
        private System.Windows.Forms.ToolStripMenuItem tsmiPlaceSearch;
        private System.Windows.Forms.ToolStripMenuItem tsmiIntroduction;
        private ToolStripMenuItem tsmiPlaceUp;
    }
}