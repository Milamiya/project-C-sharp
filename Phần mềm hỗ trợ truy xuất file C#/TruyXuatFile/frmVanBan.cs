using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.Word;
using System.Xml;
namespace TruyXuatFile
{
    public partial class frmVanBan : Form
    {
        public string PathName;
        public string ex;
        public frmVanBan()
        {
            InitializeComponent();
        }

        public void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = " text file(*.txt*)|*.txt*|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string FileName = openFileDialog1.FileName;
                StreamReader stReader = new StreamReader(FileName);
                rtbVanBan.Text = stReader.ReadToEnd();
                stReader.Close();
            }

        }

        private void frmVanBan_Load(object sender, EventArgs e)
        {
            if (PathName != null)
            {
                StreamReader stReader1 = new StreamReader(PathName);
                rtbVanBan.Text = stReader1.ReadToEnd();
                stReader1.Close();
            }
                       
        }

        public string Getext(string e)
        {
            e = ex;
            return e;
        }

        public string GetPathVB(string a)
        {
            PathName = a;
            return PathName ;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vui lòng lưu tập tin hiện hành trước khi tạo mới", "Cảnh Báo", MessageBoxButtons.YesNoCancel);
            rtbVanBan.Text = "";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string FileName = "";
            if (FileName == "")
            {
                saveFileDialog1.Filter = "Text Document.(*.txt)|*.txt|All File|*.*";
                DialogResult resVal = saveFileDialog1.ShowDialog();
                if (resVal == DialogResult.Cancel)
                {
                    return;
                }
                FileName = saveFileDialog1.FileName; 
            }
            try
            {
                StreamWriter stWriter = new StreamWriter(FileName);
                stWriter.WriteLine(rtbVanBan.Text);
                stWriter.Close();
            }
            catch 
            {
                MessageBox.Show(this,"The file" + FileName + "  is Read only. \n\n File Could not saved.", "Notepad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string FileName = "";
            if (FileName == "")
            {
                saveFileDialog1.Filter = "Text Document.(*.txt)|*.txt|All File|*.*";
                DialogResult resVal = saveFileDialog1.ShowDialog();
                if (resVal == DialogResult.Cancel)
                {
                    return;
                }
                FileName = saveFileDialog1.FileName;
            }
            try
            {
                StreamWriter stWriter = new StreamWriter(FileName);
                stWriter.WriteLine(rtbVanBan.Text);
                stWriter.Close();
            }
            catch
            {
                MessageBox.Show(this, "The file" + FileName + "  is Read only. \n\n File Could not saved.", "Notepad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.rtbVanBan.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.rtbVanBan.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.rtbVanBan.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.rtbVanBan.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.rtbVanBan.Paste();
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongTin FormThongTin = new frmThongTin();
            FormThongTin.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát khỏi chương trình", "THÔNG BÁO", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                this.Close();
            
        }

       
    }
}