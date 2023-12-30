using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Media;
using System.Diagnostics;
using System.Collections;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

/**********************************************************************
/**Description:	Đề tài Memory Game                                    *
/**Params :	                                                      *
/**Write by: Nguyễn Minh Sang DHTH7B                                  *
/**Create date:	                                                      *
**********************************************************************/

namespace Memory_Game
{
    public partial class FrmMemory : Form
    {
        //Download source code tại Sharecode.vn
        public FrmMemory()
        {
            InitializeComponent();
            timer2.Start();
            mnuReplay.Enabled = false;
            mnuSaveCurrent.Enabled = false;
            toolStripStatusLabel2.Spring = true;
            toolStripStatusLabel2.Text = "";
            toolStripStatusLabel1.Text = DateTime.Now.ToString("hh:mm:ss");
            btnPause.Enabled = false;
            lblHScore.Text = "0";
            lblYScore.Text = "0";
            btnPause.Enabled = false;
            btnStart.Enabled = false;
            label2.Visible = false;
            progressBar1.Visible = false;
            groupBox1.Visible = false;
            readFile();
        }
        
        //toolStripStatusLabel3 sẽ dẫn đến trang www.fit.iuh.edu.vn nếu người chơi Click vào
        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {
            ProcessStartInfo processInfo = new ProcessStartInfo();
            processInfo.FileName = "iexplore.exe";//Mở trang với Internet Explore.
            processInfo.Arguments = "www.fit.iuh.edu.vn";
            Process.Start(processInfo);
        }
        
        Button[] b;
        Random r = new Random();
        int n;
        int time;
        int flag = 0;
        //Phát sinh các button động với số lượng theo các mức độ do người chơi chọn
        public void Expert()
        {
            n = 20;
            b = new Button[n];
            int k = 0, j = 1;
            for (int i = 0; i < n; i++)
            {
                b[i] = new Button();
                b[i].Size = new Size(100, 70);
                b[i].Text = "";
                b[i].Image = Image.FromFile("Default.jpg");
                b[i].Location = new Point(70 + k * 105, 70 + j * 75);
                b[i].Enabled = false;
                b[i].Click += new EventHandler(b_Click);
                this.Controls.Add(b[i]);
                k++;
                if (k == 5)
                {
                    k = 0; j++;
                }
            }

        }
        public void Intermediate()
        {
            n = 16;
            b = new Button[n];
            int k = 0, j = 1;
            for (int i = 0; i < n; i++)
            {

                b[i] = new Button();
                b[i].Size = new Size(100, 70);
                b[i].Text = "";
                b[i].Image = Image.FromFile("Default.jpg");
                b[i].Location = new Point(115 + k * 105, 75 + j * 75);
                b[i].Enabled = false;
                b[i].Click += new EventHandler(b_Click);
                this.Controls.Add(b[i]);
                k++;
                if (k == 4)
                {
                    k = 0; j++;
                }
            }
        }
        public void beginner()
        {
           
            n = 12;
            b = new Button[n];
            int k = 0, j = 1;
            for (int i = 0; i < n; i++)
            {

                b[i] = new Button();
                b[i].Size = new Size(100, 70);
                b[i].Text = "";
                b[i].Image = Image.FromFile("Default.jpg");
                b[i].Location = new Point(115 + k * 105, 100 + j * 75);
                b[i].Enabled = false;
                b[i].Click += new EventHandler(b_Click);
                this.Controls.Add(b[i]);
                k++;
                if (k == 4)
                {
                    k = 0; j++;
                }
            }
        }
        //Phát sinh các button động theo số lượng mà người chơi nhập vào, số nhập vào phải là số chẵn, lớn hơn 10 và nhỏ hơn 20
        int s;
        public void custom()
        {

             s = int.Parse(Interaction.InputBox("Nhập vào số lượng ô bạn muốn chơi, số ô phải là số chẵn lớn hơn hoặc bằng 10 và nhỏ hơn hoặc bằng 20: ", "Thông báo"));

            if (s < 10 || s > 20 || s % 2 != 0)//Bắt lỗi nhập giá trị số ô
            {
                MessageBox.Show("Nhập sai giá trị số ô, hãy nhập lại\nSố ô phải là số chẵn lớn hơn hoặc bằng 10 và nhỏ hơn hoặc bằng 20 ", "Chú ý!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                custom();//Sau khi người dùng nhấn OK thì yêu cầu nhập lại
            }
            else
            {
                
                b = new Button[s];
                int k = 0, j = 1;
                for (int i = 0; i < b.Length; i++)
                {

                    //Tùy vào số lượng button mà người chơi chọn sẽ quy định thời gian và việc xuống dòng
                    if (s <= 16)
                    {
                        b[i] = new Button();
                        b[i].Size = new Size(100, 70);
                        b[i].Image = Image.FromFile("Default.jpg");
                        b[i].Location = new Point(115 + k * 105, 75 + j * 75);
                        b[i].Enabled = false;
                        b[i].Click += new EventHandler(b_Click);
                        b[i].Text = "";
                        this.Controls.Add(b[i]);
                        k++;
                        if (k == 4)
                        {
                            k = 0; j++;
                        }
                        CurTime = new DateTime(2013, 1, 1, 0, 1, 0, 0);//Thời gian khi chọn mức độ này là 1 phút và 4 ô xuống dòng
                        lblYourtime.Text = "0" + CurTime.Minute.ToString() + " : " + "0" + CurTime.Second.ToString();

                    }
                    if (s <= 20 && s > 16)
                    {
                        b[i] = new Button();
                        b[i].Size = new Size(100, 70);
                        b[i].Image = Image.FromFile("Default.jpg");
                        b[i].Location = new Point(75 + k * 105, 65 + j * 75);
                        b[i].Enabled = false;
                        b[i].Click += new EventHandler(b_Click);
                        b[i].Text = "";
                        this.Controls.Add(b[i]);
                        k++;
                        if (k == 5)
                        {
                            k = 0; j++;
                        }
                        CurTime = new DateTime(2013, 1, 1, 0, 1, 30, 0);//Thời gian khi chọn mức độ này là 1 phút 30 giây và 5 ô xuống dòng
                        lblYourtime.Text = "0" + CurTime.Minute.ToString() + " : " + CurTime.Second.ToString();

                    }
                }
            }
        }

        public void random()
        {
            //Nửa mảng button cho random các giá trị từ 0 đến 9
            ArrayList list = new ArrayList();
            for (int i = 0; i < b.Length / 2; i++)
            {
                int j = r.Next(0, 12);
                b[i].Tag = j;
                list.Add(j);//Lưu các giá trị đã random vào trong list.
            }
            for (int i = b.Length / 2; i < b.Length; i++)
            {
                int x = r.Next(0, list.Count - 1); // Lấy ngẫu nhiên 1 index trong list.
                b[i].Tag = list[x];//random phần tử có index x trong list.
                list.RemoveAt(x);//Xóa phần tử đã được random trong list.
            }
        }
        int tmp = 0;//Lưu giá trị số lần Clicks
        public void b_Click(object sender, EventArgs e)
        {
                Button k = (Button)sender;
                k.Image = Image.FromFile(k.Tag.ToString() + ".jpg");
                tmp++;//Sau mỗi lần nhấn chuột tmp tăng lên 1 để tính số lần Clicks
                lblClicks.Text = tmp.ToString();
                k.Enabled = false;
                k.Text = " ";
                Checkpair();
                CheckLength();               
                
        }
        int dem = 0;
        int Score = 0;
        //Kiểm tra sự giống nhau của 2 cặp hình ảnh
        public void Checkpair()
        {

            for (int i = 0; i < b.Length - 1; i++)
            {
                for (int j = i + 1; j < b.Length; j++)
                {
                    if (b[i].Enabled == false && b[j].Enabled == false)
                    {
                        //Nếu 2 button đều đã mở thì kiểm tra tiếp xem tag của 2 button có bằng nhau không, nếu bằng nhau thì xóa button.
                        if (b[i].Tag.ToString() == b[j].Tag.ToString())
                        {
                            correctSound();
                            System.Threading.Thread.Sleep(500);
                            b[i].Enabled = true;
                            b[j].Enabled = true;
                            b[i].Visible = false;
                            b[j].Visible = false;
                            Score = Score + 10;
                            lblYScore.Text = Score.ToString();
                            dem++;
                        }
                        else
                        {
                            wrongSound();
                            System.Threading.Thread.Sleep(500);
                            b[i].Enabled = true;
                            b[j].Enabled = true;

                            if (Score > 0)
                                Score = Score - 5;
                            lblYScore.Text = Score.ToString();
                            b[i].Image = Image.FromFile("Default.jpg");
                            b[j].Image = Image.FromFile("Default.jpg");
                        }
                    }
                    b[i].Text = " ";
                    b[j].Text = " ";

                }

            }

        }
        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            //Thông tin về game
            MessageBox.Show("Đây là Trò chơi Memory được viết theo đề tài môn DotNet Framework."
            + "\nGiảng viên hướng dẫn: Nguyễn Thị Hồng Minh.\nĐề tài : Thực hiện project Memory game.\nNhóm thực hiện:\n1. Nguyễn Minh Sang - 11052681\n"
             + "2. Nguyễn Ngọc Chí - 11232481\nKhoa Công nghệ Thông tin\n"
            + "Trường Đại học Công nghiệp Thành phố Hồ Chí Minh.\n10-01-2013");
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có thực sự muốn thoát trò chơi này?", "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
        private void mnuInstructions_Click(object sender, EventArgs e)
        {
            //Hướng dẫn chơi game
            MessageBox.Show("                               Hướng dẫn chơi game\n"

        + "   Để bắt đầu trò chơi hãy nhấn nút Bắt đầu, nhấn Tạm dừng nếu muốn dừng trò chơi trong 1 khoảng thời gian \n"
        + "Nhấn vào mỗi ô hình sẽ xuất hiện một hình ảnh và hãy nhớ hình ảnh này\n "
        + "   Lật tiếp hình thứ 2 nếu hình ảnh trong hình này giống hình ảnh của hình mở lần 1 thì 2 hình sẽ biến mất "
        + "ngược lại thì 2 hình này sẽ ẩn giá trị hình ảnh. "
        + "Hãy thực hiện liên tục cho đến khi không còn hình nào.\n Để lựa chọn nhanh bạn có thể dùng các phím tắt sau:\n"
        + "- Thoát : Ctrl+F4\n- Dễ : F2\n- Bình thường : F3\n- Khó : F4\n- Tự chọn : F5\n- Chơi lại : F12\n"
        + "- Lưu trạng thái đang chơi : Ctrl+S\n- Mở lại lần chơi gần đây : Ctrl+L\n- Hướng dẫn : F1\n- Thông tin : Ctrl + F12", "Hướng dẫn",
        MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        int ans = 0;
        private void mnuCustom_Click(object sender, EventArgs e)
        {
            
            custom();
            tmp = 0;
            lblClicks.Text = tmp.ToString();
            if (s>=10 && s <= 16)
            {
                time = 60;
            }
            
            if (s <= 20 && s > 16)
            {
                time = 90;
            }
            mnuExpert.Enabled = false;
            mnuIntermediate.Enabled = false;
            mnuBeginner.Enabled = false;
            mnuCustom.Enabled = false;
            mnuReplay.Enabled = true;
            groupBox2.Visible = false;
            btnStart.Enabled = true;
            label2.Visible = true;
            progressBar1.Visible = true;
            groupBox2.Visible = false;
            groupBox1.Visible = true;
            if (ans == 0)
            {
                InputName();
            }
            ans = 1;
        }
        private void mnuBeginner_Click(object sender, EventArgs e)
        {
            CurTime = new DateTime(2013, 1, 1, 0, 1, 0, 0);//thời gian khi chọn cấp độ này là 1 phút
            lblYourtime.Text = "0" + CurTime.Minute.ToString() + " : " + "0" + CurTime.Second.ToString();
            
            beginner();
            tmp = 0;
            lblClicks.Text = tmp.ToString();
            time = 60;
            mnuExpert.Enabled = false;
            mnuIntermediate.Enabled = false;
            mnuCustom.Enabled = false;
            mnuBeginner.Enabled = false;
            mnuReplay.Enabled = true;
            groupBox2.Visible = false;
            btnStart.Enabled = true;
            label2.Visible = true;
            progressBar1.Visible = true;
            groupBox2.Visible = false;
            groupBox1.Visible = true;
            if (ans == 0)
            {
                InputName();
            }
            ans = 1;
        }
        private void mnuIntermediate_Click(object sender, EventArgs e)
        {
            CurTime = new DateTime(2013, 1, 1, 0, 1, 30, 0);//thời gian khi chọn cấp độ này là 1 phút 30 giây
            lblYourtime.Text = "0" + CurTime.Minute.ToString() + " : " + CurTime.Second.ToString();
            
            Intermediate();
            tmp = 0;
            lblClicks.Text = tmp.ToString();
            time = 90;
            mnuExpert.Enabled = false;
            mnuBeginner.Enabled = false;
            mnuCustom.Enabled = false;
            mnuIntermediate.Enabled = false;
            mnuReplay.Enabled = true;
            groupBox2.Visible = false;
            btnStart.Enabled = true;
            label2.Visible = true;
            progressBar1.Visible = true;
            groupBox2.Visible = false;
            groupBox1.Visible = true;
            if (ans == 0)
            {
                InputName();
            }
            ans = 1;
        }

        private void mnuExpert_Click(object sender, EventArgs e)
        {
            CurTime = new DateTime(2013, 1, 1, 0, 2, 0, 0);//thời gian khi chọn cấp độ này là 2 phút
            lblYourtime.Text = "0" + CurTime.Minute.ToString() + " : " + "0" + CurTime.Second.ToString();
            
            Expert();
            tmp = 0;
            lblClicks.Text = tmp.ToString();
            time = 120;
            mnuBeginner.Enabled = false;
            mnuIntermediate.Enabled = false;
            mnuCustom.Enabled = false;
            mnuExpert.Enabled = false;
            mnuReplay.Enabled = true;
            groupBox2.Visible = false;
            btnStart.Enabled = true;
            label2.Visible = true;
            progressBar1.Visible = true;
            groupBox2.Visible = false;
            groupBox1.Visible = true;
            if (ans == 0)
            {
                InputName();
            }
            ans = 1;
        }
        //Chơi lại 
        public void Replay()
        {
            timer1.Stop();
           // timer2.Stop();
            progressBar1.Maximum = 0;
            btnStart.Enabled = true;
            for (int i = 0; i < b.Length; i++)
            {
                b[i].Visible = false;//Xóa tất cả các button đã được tạo ra
            }
            mnuBeginner.Enabled = true;
            mnuIntermediate.Enabled = true;
            mnuCustom.Enabled = true;
            mnuExpert.Enabled = true;
            mnuReplay.Enabled = false;
            btnPause.BackColor = Color.Blue;
            readFile();
            Score = 0;
            lblYScore.Text = Score.ToString();
            lblYourtime.Text = "";
            groupBox2.Visible = true;
            label2.Visible = false;
            progressBar1.Visible = false;
            groupBox1.Visible = false;
            btnPause.Enabled = false;
            tmp = 0;
            lblClicks.Text = tmp.ToString();//Reset lại số clicks
        }
        private void mnuReplay_Click(object sender, EventArgs e)
        {
            //Hỏi người chơi có chắc chắn muốn chơi lại không.
            MessageBox.Show("Bạn có chắc chắn muốn chơi lại trò chơi ở mức độ khác chứ?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            Replay();
            flag = 1;


        }
        //Dùng để tạo âm thanh khi người chơi chọn sai
        void wrongSound()
        {
            SoundPlayer sp = new SoundPlayer("tada.wav");
            sp.Play();
        }
        //Dùng để tạo âm thanh khi người chơi chọn đúng
        void correctSound()
        {
            SoundPlayer sp = new SoundPlayer("chimes.wav");
            sp.Play();
        }
        //Button Start đề kích hoạt form
        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i].Text == "")
                {
                    b[i].Enabled = true;
                }
                else
                    b[i].Enabled = false;
            }
            random();
            
            btnStart.Enabled = false;
            btnPause.Enabled = true;
            btnPause.BackColor = Color.LightPink;
            mnuSaveCurrent.Enabled = true;
        }
        //Button tạm dừng trò chơi
        private void btnPause_Click(object sender, EventArgs e)
        {
            if (btnPause.Text == "Tạm &dừng")
            {
                timer1.Stop();
                btnPause.Text = "&Tiếp tục";
                for (int i = 0; i < b.Length; i++)
                    b[i].Enabled = false;
            }
            else
            {
                timer1.Start();
                btnPause.Text = "Tạm &dừng";
                for (int i = 0; i < b.Length; i++)
                {
                    b[i].Enabled = true;
                }
            }
        }
        private DateTime CurTime;
        public int i = 5;
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = time;
            progressBar1.Step = 1;
            progressBar1.PerformStep();
            //Thời gian đếm ngược
            TimeSpan dt = new TimeSpan(0, 0, 0, 1, 0);
            CurTime = CurTime.Subtract(dt);
            lblYourtime.Text = CurTime.Minute.ToString() + " : " + CurTime.Second.ToString();
            if (CurTime.Minute == 0 && CurTime.Second == 0)//Hết thời gian thì thông báo thua cuộc
            {
                timer1.Enabled = false;
                MessageBox.Show("Hết thời gian!\nRất tiếc bạn đã thua, hãy cố gắng ở lần sau nhé.", "Thua rồi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                Replay();//Chơi lại
            }            
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            toolStripStatusLabel1.Text = now.ToString("hh:mm:ss");//In ra thời gian hệ thống sau mỗi giây
            //Tạo dòng chữ chạy qua lại
            lblTen.Left += i;
            if (lblTen.Left >= this.Width - lblTen.Width || lblTen.Left <= 0)
            {
                i = -i;
                lblTen.ForeColor = Color.Red;
            }
        }

        int[] intHighScores = new int[3];
        string[] strUser = new string[3];
        string[] strName = new string[3];
        public void InputName()
        {
            if (flag != 1)
            {
                //Hiển thị form để người dùng nhập tên
                strName[0] = Interaction.InputBox("Chào mừng bạn đã tham gia trò chơi!", "Nhập tên", "Bạn chưa nhập tên!", 400, 300);

                while (strName[0].Length > 20)
                {
                    MessageBox.Show("Chỉ được phép nhập dưới 20 kí tự !", "Chú ý",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    strName[0] = Interaction.InputBox("Tên của bạn dài quá, nhập lại đi!\nÍt hơn 20 kí tự nhé!!", "Nhập tên", "Hãy nhập tên!", 400, 300);

                }
                StreamWriter NameStreamWriter = new StreamWriter(Directory.GetCurrentDirectory() + @"/Data/Name.txt", false);

                for (int c = 0; c < 3; c++)
                {
                    NameStreamWriter.WriteLine(strName[c]);
                }
                NameStreamWriter.Close();
            }
            try
            {
                //Đọc file lưu tên người chơi lên label Name
                StreamReader NameStreamReader = new StreamReader(Directory.GetCurrentDirectory() + @"/Data/Name.txt");
                while (NameStreamReader.Peek() != -1)
                {
                    for (int a = 0; a < 3; a++)
                        strName[a] = NameStreamReader.ReadLine();
                }
                NameStreamReader.Close();
            }
            catch
            {
                MessageBox.Show("Lỗi khi đọc tên của người chơi!");
            }
            lblName.Text = strName[0];
        }
        public void CheckLength()
        {
            if (dem == b.Length / 2)
            {
                timer1.Stop();
                dem = 0;
                btnPause.Enabled = false;
                MessageBox.Show("Trò chơi đã kết thúc! Bạn đã làm rất tốt!\nĐiểm của bạn : "+lblYScore.Text+"\nSố lần Click : "+lblClicks.Text+"\nThời gian chơi: "+progressBar1.Value.ToString(), "Chúc mừng");
                if (Score > intHighScores[0])
                {
                    intHighScores[0] = Score;
                    //Hiển thị form để người dùng nhập tên
                    strUser[0] = Interaction.InputBox("Chúc mừng " + lblName.Text + " đã có số điểm cao nhất tính đến thời điểm hiện tại!"
                    + "\nHãy nhập tên bạn muốn công khai với mọi người", "Điểm cao", "Hãy nhập tên để mọi người biết!", 400, 300);
                    while (strUser[0].Length > 7)
                    {
                        MessageBox.Show("Chỉ được phép nhập dưới 7 kí tự!\nTên này là tên ngắn gọn của bạn hoặc biệt danh!", "Chú ý",
                            MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        strUser[0] = Interaction.InputBox("Tên của bạn dài quá, nhập lại đi!\nÍt hơn 7 kí tự nhé!", "Điểm cao", "Hãy nhập tên để mọi người biết!", 400, 300);
                    }
                }
                //ghi điểm cao vào file highscore trong thư mục bin
                StreamWriter HighScoreStreamWriter = new StreamWriter(Directory.GetCurrentDirectory() + @"/Data/HighScores.txt", false);
                for (int g = 0; g < 3; g++)
                {
                    HighScoreStreamWriter.WriteLine(intHighScores[g]);
                }
                HighScoreStreamWriter.Close();
                //Ghi lại tên của người đạt điểm cao
                StreamWriter strUserStreamWriter = new StreamWriter(Directory.GetCurrentDirectory() + @"/Data/User.txt", false);
                for (int h = 0; h < 3; h++)
                {
                    strUserStreamWriter.WriteLine(strUser[h]);
                }
                strUserStreamWriter.Close();
                //Reset lại điểm của người chơi
                Score = 0;
                lblYScore.Text = Score.ToString();
                Replay();//Chơi lại
            }
        }
        
        public void readFile()
        {
            try
            {
                //Đọc file lưu điểm cao để hiển thị lên label Highscore
                StreamReader highScoresStreamReader = new StreamReader(Directory.GetCurrentDirectory() + @"/Data/HighScores.txt");
                while (highScoresStreamReader.Peek() != -1)
                {
                    for (int a = 0; a < 3; a++)
                        intHighScores[a] = int.Parse(highScoresStreamReader.ReadLine());
                }
                highScoresStreamReader.Close();
            }
            catch
            {
                MessageBox.Show("Lỗi khi đọc dữ liệu chơi lần cuối!");
            }

            //Đọc file user.txt để lấy tên của người đạt điểm cao
            try
            {
                StreamReader userStreamReader = new StreamReader(Directory.GetCurrentDirectory() + @"/Data/User.txt");
                while (userStreamReader.Peek() != -1)
                {
                    for (int a = 0; a < 3; a++)
                        strUser[a] = userStreamReader.ReadLine();
                }
                userStreamReader.Close();
            }
            catch
            {
                MessageBox.Show("Lỗi khi đọc dữ liệu chơi lần cuối!");
            }
            lblHScore.Text = strUser[0] + "..." + intHighScores[0];
            
        }
        private void mnuSaveCurrent_Click(object sender, EventArgs e)
        {
                MessageBox.Show("Chức năng này tạm thời chưa sử dụng được!");
        }

        private void mnuLoadgame_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Chức năng này tạm thời chưa sử dụng được!");
        }

       

    }

}      
