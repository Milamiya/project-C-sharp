using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace TruyXuatFile
{
    public partial class frmWord : Form
    {
        public frmWord()
        {
            InitializeComponent();
        }

        public string PathNameWord;
        public string GetPathWord(string pnw)
        {
            PathNameWord = pnw;
            return PathNameWord;
        }



        private void frmWord_Load(object sender, EventArgs e)
        {
            txtPath.Text = PathNameWord;
            btnOpenWordDocument_Click(sender, e);
        }

        private void btnOpenWordDocument_Click(object sender, EventArgs e)
        {
            ApplicationClass wordApp = new ApplicationClass();
            string PathNameWord = txtPath.Text;
            object wFileName = PathNameWord ;
            object wConfirmConversions = true;
            object wReadOnly = true;
            object wAddToRecentFiles = true;
            object wPasswordDocument = "";
            object wPasswordTemplate = "";
            object wRevert = true;
            object wWritePasswordDocument = "";
            object wWritePasswordTemplate = "";
            object wFormat = WdOpenFormat.wdOpenFormatAuto;
            object wEncoding = Microsoft.Office.Core.MsoEncoding.msoEncodingAutoDetect;
            object wVisible = true;
            object wOpenAndRepair = true;
            object wDocumentDirection = WdDocumentDirection.wdRightToLeft;
            object wNoEncodingDialog = false;
            object wXMLTransform = System.Reflection.Missing.Value;

            object nullobj = System.Reflection.Missing.Value;
            wordApp.Visible = true;
            Document doc = wordApp.Documents.Open(ref wFileName, ref wConfirmConversions, ref nullobj,
                                                   ref wAddToRecentFiles, ref wPasswordDocument, ref wPasswordTemplate,
                                                   ref wRevert, ref wWritePasswordDocument, ref wWritePasswordTemplate,
                                                   ref wFormat, ref wEncoding, ref wVisible, ref wOpenAndRepair,
                                                   ref wDocumentDirection, ref wNoEncodingDialog, ref wXMLTransform);
        }

        private void btnBrowse_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.FileName = txtPath.Text;
            openFileDialog1.Filter = " Document File(*.doc*)|*.doc*";
            openFileDialog1.ShowDialog();
            string PathNameWord = openFileDialog1.FileName;
            txtPath.Text = PathNameWord;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}