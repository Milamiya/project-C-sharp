using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLBDDemo
{
    public partial class frmQuanlythucuocvienthong : Form
    {
        private String connString2 = "server = (local); database = QLBD; Integrated Security = true";
        public frmQuanlythucuocvienthong()
        {
            InitializeComponent();
        }

        private void frmQuanlythucuocvienthong_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection2 = new SqlConnection(connString2);
                String sqlCommandString2 = "";
                sqlConnection2.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommandString2, connString2);
                SqlCommand sqlCommand2 = new SqlCommand(sqlCommandString2, sqlConnection2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Có lỗi xảy ra! ");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}