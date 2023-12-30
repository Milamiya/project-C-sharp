using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Core;
using Excel = Microsoft.Office.Interop.Excel;

namespace TruyXuatFile
{
    public partial class frmExcel : Form
    {
        public frmExcel()
        {
            InitializeComponent();
        }

        public string PathNameExcel;
        public string GetPathExcel(string exl)
        {
            PathNameExcel = exl;
            return PathNameExcel;
        }

        private void frmExcel_Load(object sender, EventArgs e)
        {
            txtPath.Text = PathNameExcel;
            //button1_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Excel.Application ExcelApp = new Excel.ApplicationClass();
            string PathNameExcel = txtPath.Text;
            ExcelApp.Visible = true;
            Excel.Workbook exWorkBook = ExcelApp.Workbooks.Open(PathNameExcel, 0, false, 5, "", "", false,
                Excel.XlPlatform.xlWindows, "",
        true, false, 0, true, false, false);
           
         }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

            openFileDialog1.FileName = txtPath.Text;
            openFileDialog1.Filter = " Excel File(*.xls*)|*.xls*";
            openFileDialog1.ShowDialog();
            string PathNameExcel = openFileDialog1.FileName;
            txtPath.Text = PathNameExcel;
        }

     
    }
}