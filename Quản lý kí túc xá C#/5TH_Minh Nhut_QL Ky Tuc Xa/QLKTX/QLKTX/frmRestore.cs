using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLKTX
{
    public partial class frmRestore : Form
    {
        public frmRestore()
        {
            InitializeComponent();
        }

        private void btnThiHanh_Click(object sender, EventArgs e)
        {
            SqlCommand m_Command = new SqlCommand("RESTORE  DATABASE QLKTX  FROM DISK ='" + txtDuongDan.Text + "' with REPLACE ");
            DataService ser = new DataService();
            ser.ThiHanh(m_Command);
            MessageBox.Show("Thành công!");
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            Open_DiaLog.ShowDialog();
            txtDuongDan.Text = Open_DiaLog.FileName;
        }
    }
}