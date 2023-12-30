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
    partial class FrmPlaceUp
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
            this.lblPlaceUp = new System.Windows.Forms.Label();
            this.lblPlaceCode = new System.Windows.Forms.Label();
            this.lblPlaceName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblManagement = new System.Windows.Forms.Label();
            this.lblHomePhone = new System.Windows.Forms.Label();
            this.lblMobi = new System.Windows.Forms.Label();
            this.tbxPlaceCode = new System.Windows.Forms.TextBox();
            this.tbxManagement = new System.Windows.Forms.TextBox();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.tbxHomePhone = new System.Windows.Forms.TextBox();
            this.tbxMobi = new System.Windows.Forms.TextBox();
            this.tbxPlaceName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPlaceUp
            // 
            this.lblPlaceUp.AutoSize = true;
            this.lblPlaceUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaceUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblPlaceUp.Location = new System.Drawing.Point(115, 38);
            this.lblPlaceUp.Name = "lblPlaceUp";
            this.lblPlaceUp.Size = new System.Drawing.Size(249, 31);
            this.lblPlaceUp.TabIndex = 0;
            this.lblPlaceUp.Text = "Cập nhật địa điểm";
            // 
            // lblPlaceCode
            // 
            this.lblPlaceCode.AutoSize = true;
            this.lblPlaceCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaceCode.Location = new System.Drawing.Point(36, 90);
            this.lblPlaceCode.Name = "lblPlaceCode";
            this.lblPlaceCode.Size = new System.Drawing.Size(92, 18);
            this.lblPlaceCode.TabIndex = 1;
            this.lblPlaceCode.Text = "Mã địa điểm:";
            // 
            // lblPlaceName
            // 
            this.lblPlaceName.AutoSize = true;
            this.lblPlaceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaceName.Location = new System.Drawing.Point(36, 133);
            this.lblPlaceName.Name = "lblPlaceName";
            this.lblPlaceName.Size = new System.Drawing.Size(96, 18);
            this.lblPlaceName.TabIndex = 2;
            this.lblPlaceName.Text = "Tên địa điểm:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(36, 218);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(57, 18);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Địa chỉ:";
            // 
            // lblManagement
            // 
            this.lblManagement.AutoSize = true;
            this.lblManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagement.Location = new System.Drawing.Point(36, 175);
            this.lblManagement.Name = "lblManagement";
            this.lblManagement.Size = new System.Drawing.Size(58, 18);
            this.lblManagement.TabIndex = 4;
            this.lblManagement.Text = "Quản lí:";
            // 
            // lblHomePhone
            // 
            this.lblHomePhone.AutoSize = true;
            this.lblHomePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomePhone.Location = new System.Drawing.Point(36, 258);
            this.lblHomePhone.Name = "lblHomePhone";
            this.lblHomePhone.Size = new System.Drawing.Size(54, 18);
            this.lblHomePhone.TabIndex = 5;
            this.lblHomePhone.Text = "ĐTNR:";
            // 
            // lblMobi
            // 
            this.lblMobi.AutoSize = true;
            this.lblMobi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobi.Location = new System.Drawing.Point(36, 296);
            this.lblMobi.Name = "lblMobi";
            this.lblMobi.Size = new System.Drawing.Size(54, 18);
            this.lblMobi.TabIndex = 6;
            this.lblMobi.Text = "ĐTDĐ:";
            // 
            // tbxPlaceCode
            // 
            this.tbxPlaceCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPlaceCode.Location = new System.Drawing.Point(162, 87);
            this.tbxPlaceCode.Name = "tbxPlaceCode";
            this.tbxPlaceCode.Size = new System.Drawing.Size(198, 24);
            this.tbxPlaceCode.TabIndex = 7;
            this.tbxPlaceCode.TextChanged += new System.EventHandler(this.tbxPlaceCode_TextChanged);
            // 
            // tbxManagement
            // 
            this.tbxManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxManagement.Location = new System.Drawing.Point(162, 172);
            this.tbxManagement.Name = "tbxManagement";
            this.tbxManagement.Size = new System.Drawing.Size(198, 24);
            this.tbxManagement.TabIndex = 8;
            // 
            // tbxAddress
            // 
            this.tbxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAddress.Location = new System.Drawing.Point(162, 215);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(198, 24);
            this.tbxAddress.TabIndex = 9;
            // 
            // tbxHomePhone
            // 
            this.tbxHomePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxHomePhone.Location = new System.Drawing.Point(162, 255);
            this.tbxHomePhone.Name = "tbxHomePhone";
            this.tbxHomePhone.Size = new System.Drawing.Size(198, 24);
            this.tbxHomePhone.TabIndex = 10;
            // 
            // tbxMobi
            // 
            this.tbxMobi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMobi.Location = new System.Drawing.Point(162, 293);
            this.tbxMobi.Name = "tbxMobi";
            this.tbxMobi.Size = new System.Drawing.Size(198, 24);
            this.tbxMobi.TabIndex = 11;
            // 
            // tbxPlaceName
            // 
            this.tbxPlaceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPlaceName.Location = new System.Drawing.Point(162, 130);
            this.tbxPlaceName.Name = "tbxPlaceName";
            this.tbxPlaceName.Size = new System.Drawing.Size(198, 24);
            this.tbxPlaceName.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(53, 358);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(152, 358);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(251, 358);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(350, 358);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Đóng lại";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmPlaceUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 393);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbxPlaceName);
            this.Controls.Add(this.tbxMobi);
            this.Controls.Add(this.tbxHomePhone);
            this.Controls.Add(this.tbxAddress);
            this.Controls.Add(this.tbxManagement);
            this.Controls.Add(this.tbxPlaceCode);
            this.Controls.Add(this.lblMobi);
            this.Controls.Add(this.lblHomePhone);
            this.Controls.Add(this.lblManagement);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPlaceName);
            this.Controls.Add(this.lblPlaceCode);
            this.Controls.Add(this.lblPlaceUp);
            this.MaximizeBox = false;
            this.Name = "FrmPlaceUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh bạ điện thoại - Cập nhật địa điểm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlaceUp;
        private System.Windows.Forms.Label lblPlaceCode;
        private System.Windows.Forms.Label lblPlaceName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblManagement;
        private System.Windows.Forms.Label lblHomePhone;
        private System.Windows.Forms.Label lblMobi;
        private System.Windows.Forms.TextBox tbxPlaceCode;
        private System.Windows.Forms.TextBox tbxManagement;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.TextBox tbxHomePhone;
        private System.Windows.Forms.TextBox tbxMobi;
        private System.Windows.Forms.TextBox tbxPlaceName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
    }
}