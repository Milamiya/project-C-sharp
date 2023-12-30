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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void tsmiStaffSearch_Click(object sender, EventArgs e)
        {
            
            (new FrmStaffSearch()).Show();
        }

        private void tsmiUnitSearch_Click(object sender, EventArgs e)
        {
           
            (new FrmUnitSearch()).Show();
        }

        private void tsmiPlaceSearch_Click(object sender, EventArgs e)
        {
          
            (new FrmPlaceSearch()).Show();
        }

        private void tsmiStaffUp_Click(object sender, EventArgs e)
        {
            
            (new FrmStaffUp()).Show();
        }

        private void tsmiFacultyUp_Click(object sender, EventArgs e)
        {
           
            (new FrmFacultyUp()).Show();
        }

        private void tsmiDepartmentUp_Click(object sender, EventArgs e)
        {
            
            (new FrmDepartmentUp()).Show();
        }

        public string st1, st2, st3;

        private void tsmiPlaceUp_Click(object sender, EventArgs e)
        {
            
            (new FrmPlaceUp()).Show();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
            e.Cancel = true;
        }

        private void tsmiIntroduction_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phần mềm Danh bạ điện thoại được thiết kế bởi CH-Group (Minh châu - Thanh Hoà K55B).\nContact: minhchau.vt@gmail.com .", "Giới thiệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       
       
        
    }
}
