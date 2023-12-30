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
    public partial class frmBackup : Form
    {
        public frmBackup()
        {
            InitializeComponent();
        }

        private void btnThiHanh_Click(object sender, EventArgs e)
        {            
            SqlCommand m_Command = new SqlCommand("BACKUP DATABASE QLKTX TO DISK = '" + txtDuongDan.Text + "' WITH INIT , NOUNLOAD , NOSKIP , STATS = 10  , NOFORMAT");
            DataService ser = new DataService();
            ser.ThiHanh(m_Command);
            MessageBox.Show("Thành công!");
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            Save_Dialog.ShowDialog();
            txtDuongDan.Text = Save_Dialog.FileName;
        }
    }
}