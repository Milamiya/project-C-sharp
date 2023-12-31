using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DoAnCTSDK
{
    public partial class frmMain : Form
    {
        int dapAn;
        public Color ProblemFore=Color.Red;
        public Color ProblemBack=Color.Cyan;

        public Color ResultFore=Color.Black;
        public Color ResultBack = Color.White;
        

        public TextBox[] text = new TextBox[82];
        int[] de = new int[82];
        public void LoadText()
        {
            const int space = 10;
            for (int i = 1; i <= 81; i++)
            {
                text[i] = new TextBox();
                text[i].Size = Mau.Size;
                text[i].Font = Mau.Font;
                text[i].MaxLength = 1;
                text[i].TabIndex = i;

                text[i].Top = ((i - 1) / 9) % 9 * text[i].Height + 1 + ((i - 1) / 27) * space+space ;
                text[i].Left = (i - 1) % 9 * text[i].Width + 1+((i-1)%9)/3*space+space;
                text[i].Show();
                text[i].TextAlign = HorizontalAlignment.Center;
                text[i].Name = "Text" + i.ToString();
                text[i].Tag = i;
                text[i].Text = "";
                text[i].ContextMenuStrip = PoppupMenu;

                this.text[i].TextChanged += new System.EventHandler(this.Mau_TextChanged);
                this.text[i].KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Mau_KeyPress);
                myPanel.Controls.Add(text[i]);
            }
            myTool.Top = myMenu.Height;
            myPanel.Left = 0;
            myPanel.Top =myTool.Top+ myTool.Height;
            myPanel.Height = text[81].Top + text[81].Height + space;
            myPanel.Width  = text[81].Left  + text[81].Width + space;
            this.Width = myPanel.Width + 6;
            this.Height = myPanel.Top + myPanel.Height + myMenu.Height + space - 2 + statusStrip1.Height;

        }
        private void LoadPictureTool()
        {
            toolNew.Image = mnuNew.Image;
            toolOpen.Image = mnuOpen.Image;
            toolSave.Image = mnuSave.Image;
            toolSolve.Image = mnuSolve.Image;
            toolSolveNext.Image = mnuSolveNext.Image;
            toolSolvePre.Image = mnuSolvePrevious.Image;
            toolSoveTo.Image = mnuSolveTo.Image;
            toolStatic.Image = mnuSatic.Image;
            toolInfo.Image = mnuInformation.Image;
        }
        public frmMain()
        {
            InitializeComponent();
        }
        
        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadText();
            LoadPictureTool();
        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void mnuNew_Click(object sender, EventArgs e)
        {
            dapAn = 0;
            myStatus.Text = "Sẳn sàng nhập dữ liệu";
            for (int i = 0; i < 81; i++)
            {
                text[i + 1].Text = "";
                text[i + 1].ForeColor = Color.Black;
                text[i + 1].BackColor = Color.White;
            }
            text[1].Focus();
        }
        private void mnuOpen_Click(object sender, EventArgs e)
        {
            dapAn = 0;
            DiagOpen.InitialDirectory = Application.StartupPath;
            if (DiagOpen.ShowDialog() == DialogResult.Cancel ) return;
            char x;
            try
            {
                FileStream file = new FileStream(DiagOpen.FileName, FileMode.Open);
                BinaryReader BR = new BinaryReader(file);
                for (int i = 0; i < 81; i++)
                {
                    do
                    {
                        x = BR.ReadChar();
                    } while (x < '0' || x > '9');
                    if (x > '0')
                    {
                        text[i + 1].Text = x.ToString();
                        text[i + 1].ForeColor = Color.Red;
                        text[i + 1].BackColor = Color.Cyan;
                    }
                    else 
                    {
                        text[i + 1].Text = "";
                        text[i + 1].ForeColor = Color.Black;
                        text[i + 1].BackColor = Color.White;
                    }
                }
                BR.Close();
                file.Close();
                myStatus.Text = "Mở tập tin " + DiagOpen.FileName;
            }
            catch(Exception Ex) {
                MessageBox.Show("Lỗi khi đọc file !\n"+Ex.Message  , "Đã có lỗi",MessageBoxButtons.OK,MessageBoxIcon.Information );

            };
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            dapAn = 0;
            DiagSave.Filter = "Sudoku file(*.sdk)|*.sdk|Text file (*.txt)|*.txt";
            if (DiagSave.ShowDialog() == DialogResult.Cancel) return;
            try
            {
                FileStream file = new FileStream(DiagSave.FileName, FileMode.Create);
                BinaryWriter bw = new BinaryWriter(file);

                for (int i = 0; i < 81; i++)
                {
                    bw.Write(text[i + 1].Text == "" ? "0" : text[i + 1].Text);
                }
                bw.Close();
                file.Close();
                myStatus.Text = "Đã lưu ra tập tin \"" + DiagSave.FileName + "\"";
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Có lỗi khi viết ra file !\n" + Ex.Message, "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void napde()
        {
            int i;
            for (i = 1; i <= 81; i++)
            {
                if ((text[i].Text == "")||(text[i].ForeColor==Color.Black)) de[i] = 0;
                else de[i] = int.Parse(text[i].Text);
            }
        }
        private void mnuSolve_Click(object sender, EventArgs e)
        {
            dapAn = 1;
            napde();
            SDK a= new SDK(de);
            if (a.SolveFirst())
            {
                for (int i = 1; i <= 81; i++)
                {
                    text[i].Text = a.Result[i].ToString();
                    if (de[i] == 0)
                    {
                        text[i].BackColor = Color.White;
                        text[i].ForeColor = Color.Black;
                    }
                    myStatus.Text = "Đã giải đề thành công";
                }
            }
            else
            {
                MessageBox.Show("Không có kết quả nào cả !", "Vô nghiệm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                myStatus.Text = "Giải đề không thành công";
            }
        }

        private void mnuSolveTo_Click(object sender, EventArgs e)
        {
            SelectResult frm = new SelectResult();
            frm.ShowDialog();
            int select = frm.selected;
            if (select == -1) return;
            napde();
            SDK a=new SDK(de);            
            if (select > 10000)
            {
                lblwait.Visible = true;
                this.Enabled = false;
            }
            Application.DoEvents();
            if (!a.SolveTo(select))
            {
                if (select > 10000)
                {
                    this.Enabled = true;
                    lblwait.Visible = false;
                }
                MessageBox.Show("Bạn muốn xem nghiệm thứ " + select.ToString() + "\nNhưng Sudoku này có ít hơn " + select.ToString() + " nghiệm !\nHãy nhập vào số thích hợp.", "Không có nghiệm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                myStatus.Text = "Giải đề không thành công";
                return;
            }
            if (select > 10000)
            {
                this.Enabled = true;
                lblwait.Visible = false;
            }
            dapAn = select;
            for (int i = 1; i <= 81; i++)
            {
                text[i].Text = a.Result[i].ToString();
                if (de[i] == 0)
                {
                    text[i].BackColor = Color.White;
                    text[i].ForeColor = Color.Black;
                }
            }
            myStatus.Text = "Đã giải đề thành công";
        }

        private void mnuSatic_Click(object sender, EventArgs e)
        {
            string da = dapAn == 0 ? "Chưa xem đáp án nào." : "Đang xem đáp án thứ " + dapAn.ToString() + ".";
            int daDien = 0,chuaDien=0;
            napde();
            for (int i = 0; i < 81; i++)
            {
                if (de[i + 1] != 0) daDien++;
            }
            chuaDien=81-daDien;
            SDK a = new SDK(de);
            Application.DoEvents();
            int count=a.ResultCount();
            if (count == 0)
                MessageBox.Show("Sudoku có "+daDien.ToString()+" ô được điền, "+ chuaDien.ToString()+" còn trống.\n Sudoku này không có đáp án\n", "Thống kê", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (count > 0) MessageBox.Show("Sudoku có " + daDien.ToString() + " ô được điền, " + chuaDien.ToString() + " còn trống.\n Sudoku này có " + count.ToString() + " đáp án !", "Thống kê", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Sudoku có " + daDien.ToString() + " ô được điền, " + chuaDien.ToString() + " còn trống.\nSudoku này có nhiều hơn 10.000 đáp án !\n"+da, "Thống kê", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuInformation_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đồ án cấu trúc dữ liệu và giải thuật.\nChương trình giải Sudoku.\n\n Thực hiện bởi :\n\n Võ Quang Hòa\n Nguyễn Trần Đình Trọng\n Phạm Minh Tân \n\nLớp 07T4 - Nhóm 12", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sudokuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Điền đầy đủ các số từ 0~9 vào ô trống cho : \n\tTất cả các hàng :\n\tTất cả các cột : \n\tTất cả các vùng 3x3\nChỉ được điền một ô một số mà thôi !", "Sudoku", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Mau_TextChanged(object sender, EventArgs e)
        {
            int i =int.Parse(((TextBox)sender).Tag.ToString());
            text[i].SelectAll();
            text[i].ForeColor = Color.Red;
            text[i].BackColor = Color.Cyan;
        }

        private void Mau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                ((TextBox)sender).Text = "";
                ((TextBox)sender).ForeColor = Color.Black;
                ((TextBox)sender).BackColor = Color.White;
            }
            if (e.KeyChar > '9' || e.KeyChar < '1') e.KeyChar = '\0';
        }

        private void recovery_Click(object sender, EventArgs e)
        {
            dapAn = 0;
            for (int i = 0; i < 81; i++)
            {
                if ((de[i + 1] == 0))
                {
                    text[i + 1].Text = "";
                    text[i+1].BackColor = Color.White;
                    text[i+1].ForeColor = Color.Black;
                }
            }
        }

        private void xuấtBảnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OptionPublish op = new OptionPublish();
            op.ShowDialog();
            if (op.willPublish)
            {
                int[] ketqua = new int[82];
                int[] de = new int[82];
                bool publishResult = true;
                for (int i = 1; i <= 81; i++)
                {
                    try
                    {
                        ketqua[i] = int.Parse(text[i].Text);
                        if (text[i].ForeColor != Color.Red) de[i] = 0;
                        else de[i] = ketqua[i];
                    }
                    catch
                    {
                        de[i] = 0;
                        publishResult = false;
                    }
                }
                Application.DoEvents();
                PublishTo a = new PublishTo(publishResult, de, ketqua,op.txtPath.Text);
                string x;
                if (op.rtf) x = a.WriteToFileRTF();
                else x = a.WriteToFileHTML();
                if (x != "")
                {
                    MessageBox.Show("Đã có lỗi khi ghi vào tập tin \"" + DiagSave.FileName + "\".\n" + x, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                DiagSave.FileName = "";
            }
            Application.DoEvents();
            op.Dispose();
            op = null;
        }

        private void inẤnToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("Nếu thấy cần thì thêm chức năng này vào !", "Ok - Is plan", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (OpenImg.ShowDialog() == DialogResult.Cancel) return;
            try
            {
                myPanel.BackgroundImage = Image.FromFile(OpenImg.FileName);
                myStatus.Text = "Đã đặt hình nền mới";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Có lỗi khi load hình ảnh !\n"+ex.Message , "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void mnuSolvePrevious_Click(object sender, EventArgs e)
        {
            switch (dapAn)
            {
                case 0: MessageBox.Show("Bạn chưa giải đề !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 1: MessageBox.Show("Đây là đáp án đầu tiên !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    dapAn--;
                    napde();
                    SDK a = new SDK(de);
                    if (dapAn > 10000)
                    {
                        lblwait.Visible = true; ;
                        this.Enabled =false ;
                    }
                    a.SolveTo(dapAn);
                    if (dapAn > 10000)
                    {
                        lblwait.Visible =false  ;
                        this.Enabled = true; 
                    }
                    for (int i = 1; i <= 81; i++)
                    {
                        text[i].Text = a.Result[i].ToString();
                        if (de[i] == 0)
                        {
                            text[i].BackColor = Color.White;
                            text[i].ForeColor = Color.Black;
                        }
                    }
                    break;
            }
        }

        private void mnuSolveNext_Click(object sender, EventArgs e)
        {
            dapAn++;
            napde();
            SDK a = new SDK(de);
            if (dapAn > 10000)
            {
                lblwait.Visible = true;
                this.Enabled = false;
            }
            Application.DoEvents();
            if (!a.SolveTo(dapAn))
            {
                if (dapAn > 10000)
                {
                    lblwait.Visible = false; ;
                    this.Enabled = true; ;
                }
                MessageBox.Show("Hết đáp án - Không tìm thấy đáp án tiếp theo !", "Không có nghiệm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dapAn--;
                return;
            }
            if (dapAn > 10000)
            {
                lblwait.Visible = false; ;
                this.Enabled = true; ;
            }
            for (int i = 1; i <= 81; i++)
            {
                text[i].Text = a.Result[i].ToString();
                if (de[i] == 0)
                {
                    text[i].BackColor = Color.White;
                    text[i].ForeColor = Color.Black;
                }
            }
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 81; i++)
            {
                if (text[i + 1].Focused == true) text[i + 1].Text = "1";
            }
        }
        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 81; i++)
            {
                if (text[i + 1].Focused == true) text[i + 1].Text = "6";
            }
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 81; i++)
            {
                if (text[i + 1].Focused == true) text[i + 1].Text = "2";
            }
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 81; i++)
            {
                if (text[i + 1].Focused == true) text[i + 1].Text = "3";
            }
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 81; i++)
            {
                if (text[i + 1].Focused == true) text[i + 1].Text = "4";
            }
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 81; i++)
            {
                if (text[i + 1].Focused == true) text[i + 1].Text = "5";
            }
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 81; i++)
            {
                if (text[i + 1].Focused == true) text[i + 1].Text = "7";
            }
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 81; i++)
            {
                if (text[i + 1].Focused == true) text[i + 1].Text = "8";
            }
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 81; i++)
            {
                if (text[i + 1].Focused == true) text[i + 1].Text = "9";
            }
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 81; i++)
            {
                if (text[i + 1].Focused == true)
                {
                    text[i + 1].Text = "";
                    text[i+1].BackColor = Color.White;
                    text[i+1].ForeColor = Color.Black;
                }

            }
        }

        private void myPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}