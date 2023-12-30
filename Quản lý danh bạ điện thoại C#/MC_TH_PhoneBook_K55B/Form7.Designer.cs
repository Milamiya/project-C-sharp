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
    partial class FrmFacultyUp
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
            this.lblUpFaculty = new System.Windows.Forms.Label();
            this.lblFacultyCode = new System.Windows.Forms.Label();
            this.lblFacultyName = new System.Windows.Forms.Label();
            this.lblPlaceCode = new System.Windows.Forms.Label();
            this.lblDean = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.tbxFacultyCode = new System.Windows.Forms.TextBox();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.tbxDean = new System.Windows.Forms.TextBox();
            this.tbxPlaceCode = new System.Windows.Forms.TextBox();
            this.tbxFacultyName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUpFaculty
            // 
            this.lblUpFaculty.AutoSize = true;
            this.lblUpFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpFaculty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblUpFaculty.Location = new System.Drawing.Point(157, 41);
            this.lblUpFaculty.Name = "lblUpFaculty";
            this.lblUpFaculty.Size = new System.Drawing.Size(207, 31);
            this.lblUpFaculty.TabIndex = 0;
            this.lblUpFaculty.Text = "Cập nhật Khoa";
            // 
            // lblFacultyCode
            // 
            this.lblFacultyCode.AutoSize = true;
            this.lblFacultyCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacultyCode.Location = new System.Drawing.Point(34, 106);
            this.lblFacultyCode.Name = "lblFacultyCode";
            this.lblFacultyCode.Size = new System.Drawing.Size(72, 18);
            this.lblFacultyCode.TabIndex = 1;
            this.lblFacultyCode.Text = "Mã Khoa:";
            // 
            // lblFacultyName
            // 
            this.lblFacultyName.AutoSize = true;
            this.lblFacultyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacultyName.Location = new System.Drawing.Point(34, 148);
            this.lblFacultyName.Name = "lblFacultyName";
            this.lblFacultyName.Size = new System.Drawing.Size(76, 18);
            this.lblFacultyName.TabIndex = 2;
            this.lblFacultyName.Text = "Tên Khoa:";
            // 
            // lblPlaceCode
            // 
            this.lblPlaceCode.AutoSize = true;
            this.lblPlaceCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaceCode.Location = new System.Drawing.Point(34, 191);
            this.lblPlaceCode.Name = "lblPlaceCode";
            this.lblPlaceCode.Size = new System.Drawing.Size(92, 18);
            this.lblPlaceCode.TabIndex = 3;
            this.lblPlaceCode.Text = "Mã địa điểm:";
            // 
            // lblDean
            // 
            this.lblDean.AutoSize = true;
            this.lblDean.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDean.Location = new System.Drawing.Point(34, 234);
            this.lblDean.Name = "lblDean";
            this.lblDean.Size = new System.Drawing.Size(116, 18);
            this.lblDean.TabIndex = 4;
            this.lblDean.Text = "Mã trưởng khoa:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(34, 276);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(42, 18);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "SĐT:";
            // 
            // tbxFacultyCode
            // 
            this.tbxFacultyCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFacultyCode.Location = new System.Drawing.Point(156, 100);
            this.tbxFacultyCode.Name = "tbxFacultyCode";
            this.tbxFacultyCode.Size = new System.Drawing.Size(278, 24);
            this.tbxFacultyCode.TabIndex = 6;
            this.tbxFacultyCode.TextChanged += new System.EventHandler(this.tbxFacultyCode_TextChanged);
            // 
            // tbxPhone
            // 
            this.tbxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPhone.Location = new System.Drawing.Point(156, 270);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(278, 24);
            this.tbxPhone.TabIndex = 7;
            // 
            // tbxDean
            // 
            this.tbxDean.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDean.Location = new System.Drawing.Point(156, 228);
            this.tbxDean.Name = "tbxDean";
            this.tbxDean.Size = new System.Drawing.Size(278, 24);
            this.tbxDean.TabIndex = 8;
            // 
            // tbxPlaceCode
            // 
            this.tbxPlaceCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPlaceCode.Location = new System.Drawing.Point(156, 185);
            this.tbxPlaceCode.Name = "tbxPlaceCode";
            this.tbxPlaceCode.Size = new System.Drawing.Size(278, 24);
            this.tbxPlaceCode.TabIndex = 9;
            // 
            // tbxFacultyName
            // 
            this.tbxFacultyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFacultyName.Location = new System.Drawing.Point(156, 142);
            this.tbxFacultyName.Name = "tbxFacultyName";
            this.tbxFacultyName.Size = new System.Drawing.Size(278, 24);
            this.tbxFacultyName.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(50, 344);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(165, 344);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(280, 344);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(395, 344);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Đóng lại";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmFacultyUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 394);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbxFacultyName);
            this.Controls.Add(this.tbxPlaceCode);
            this.Controls.Add(this.tbxDean);
            this.Controls.Add(this.tbxPhone);
            this.Controls.Add(this.tbxFacultyCode);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblDean);
            this.Controls.Add(this.lblPlaceCode);
            this.Controls.Add(this.lblFacultyName);
            this.Controls.Add(this.lblFacultyCode);
            this.Controls.Add(this.lblUpFaculty);
            this.MaximizeBox = false;
            this.Name = "FrmFacultyUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh bạ điện thoại - Cập nhật Khoa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUpFaculty;
        private System.Windows.Forms.Label lblFacultyCode;
        private System.Windows.Forms.Label lblFacultyName;
        private System.Windows.Forms.Label lblPlaceCode;
        private System.Windows.Forms.Label lblDean;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox tbxFacultyCode;
        private System.Windows.Forms.TextBox tbxPhone;
        private System.Windows.Forms.TextBox tbxDean;
        private System.Windows.Forms.TextBox tbxPlaceCode;
        private System.Windows.Forms.TextBox tbxFacultyName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
    }
}