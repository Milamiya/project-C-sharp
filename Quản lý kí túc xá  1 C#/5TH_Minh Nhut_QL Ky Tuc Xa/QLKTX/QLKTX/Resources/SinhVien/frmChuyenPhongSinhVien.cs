using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLKTX
{
    public partial class frmChuyenPhongSinhVien : Form
    {
        public frmChuyenPhongSinhVien()
        {
            InitializeComponent();
        }

        private void frmChuyenPhongSinhVien_Load(object sender, EventArgs e)
        {
            dtPhongDi.Rows.Add(new object[]{"sad","sd","sd"});
            dtPhongDi.Rows.Add(new object[] { "sad", "sd", "sd" });
            dtPhongDi.Rows.Add(new object[] { "sad", "sd", "sd" });
            dtPhongDi.Rows.Add(new object[] { "sad", "sd", "sd" });
            dtPhongDi.Rows.Add(new object[] { "sad", "sd", "sd" });
            dtPhongDi.Rows.Add(new object[] { "sad", "sd", "sd" });
            dtPhongDi.Rows.Add(new object[] { "sad", "sd", "sd" });
            dtPhongDi.Rows.Add(new object[] { "sad", "sd", "sd" });
        }

       
    }
}