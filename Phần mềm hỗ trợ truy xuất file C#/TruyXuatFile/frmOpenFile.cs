using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TruyXuatFile
{
    public partial class frmOpenFile : Form
    {
        public int CopyValue;
        public int MoveValue;
        ////////Hàm nhận giá trị của Copy và Move//////////////


        public int GetCopy(int c)
        {
            CopyValue = c;
            return CopyValue;
        }
        public int GetMove(int m)
        {
            MoveValue = m;
            return MoveValue;
        }


        public string DuongDan;
        public string GetDuongDan(string dd) //Lay duong dan tu txtDuongDan ben Form Main
        {
            DuongDan = dd;
            return DuongDan;
        }
        public string TenFile;
        public string GetTenFile(string tf) //Lay Ten File tu txt TenFile ben Form Main
        {
            TenFile = tf;
            return TenFile;
        }

        public frmOpenFile()
        {
            InitializeComponent();
        }

        
        
        

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath=txtDuongDanMoi.Text;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtDuongDanMoi.Text = folderBrowserDialog1.SelectedPath;
                                
            }
        }

       
        private void frmOpenFile_Load(object sender, EventArgs e)
        {
           
            if (CopyValue ==1)
               btnCopy.Visible = true;
            if (MoveValue == 1)
              btnMove.Visible = true;
          
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            try
            {
               
                string Query = "Bạn có muốn copy tập tin \n" + DuongDan + "tới " + txtDuongDanMoi.Text + "?";
                if ((DuongDan  == "") || (txtDuongDanMoi.Text == ""))
                {
                    MessageBox.Show("Bạn chưa nhập vào đường dẫn để có thể thực hiện lệnh Copy", "THÔNG BÁO", MessageBoxButtons.OK);
                }
                else if (MessageBox.Show(Query, "THÔNG BÁO", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    File.Copy(DuongDan, Path.Combine(txtDuongDanMoi.Text, TenFile ), true);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể copy tập tin vì :" + " xảy ra: \n" + ex.Message, "Thất bại");
            }
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = "Bạn có muốn mOVE tập tin \n" + DuongDan + "tới " + txtDuongDanMoi.Text + "?";
                    if ((DuongDan  == "") || (txtDuongDanMoi.Text  == ""))
                    {
                        MessageBox.Show("Thiếu đường dẫn để có thể thực hiện lệnh Move", "THÔNG BÁO", MessageBoxButtons.OK);
                    }
                    else if (MessageBox.Show(Query, "THÔNG BÁO", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                    {
                        File.Move(DuongDan , Path.Combine(txtDuongDanMoi.Text, TenFile ));
                    }
              }        
            catch (Exception ex)
            {
                MessageBox.Show("Không thể di chuyển tập tin. Có ngoại lệ" + " xảy ra: \n" + ex.Message, "Thất bại");
            }

        }
    }
}