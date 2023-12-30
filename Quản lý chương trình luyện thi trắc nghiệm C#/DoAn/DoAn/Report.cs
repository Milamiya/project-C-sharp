using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Doan
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        
            {
                TS a = new TS();
                String strCon = "server=.\\SQLEXPRESS;database=QL_Thitracnghiem;integrated security=true";
                SqlConnection con = new SqlConnection(strCon);
                SqlCommand cmd = new SqlCommand("select * from THISINH", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(a, "THISINH");
                rptThisinh1.SetDataSource(a.Tables["THISINH"]);
                // Lấy dữ liệu từ dataset chèn vào rptThisinh

            }
        
    }
}
