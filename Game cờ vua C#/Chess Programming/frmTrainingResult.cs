using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace Chess_Programming
{
    public partial class frmTrainingResult : DevComponents.DotNetBar.Office2007Form
    {
        public frmTrainingResult()
        {
            InitializeComponent();
        }

        public frmTrainingResult(bool IsSuccess)
        {
            InitializeComponent();
            if (IsSuccess == true)
            {
                lblResult.Text = "Bạn Đã Hoàn Thành Bài Tập";
                lblResult.ForeColor = Color.Red;                

                btnNext.Text = "Tiếp Tục";
                this.Text = "Thành Công !!!";

            }
            else
            {
                lblResult.Text = "Xin Hãy Thử Lại !!!";
                lblResult.ForeColor = Color.Blue ;

                btnNext.Text = "Thử Lại";
                this.Text = "Thất Bại !!!";
            }
        }

        private void frmTrainingResult_Load(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}