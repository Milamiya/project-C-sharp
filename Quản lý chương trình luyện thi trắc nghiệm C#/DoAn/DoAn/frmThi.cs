using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Doan
{
    public partial class frmThi : Form  
    {
        public frmThi()
        {
            InitializeComponent();
        }
        public frmLuaChon frmluachon;
        public string diemkq,strcapdo1, strsoluongcauhoi1,ten;
        int i = 1, p = 0;
        int iRows = 0;
        int diem = 0;
        int sodonghienlen = 5;
        string[] strdapan = new string[99];
        private void dapan()
        {
            StreamReader srdapan = new StreamReader("DAPAN.txt");
            string line;
            for (int i = 0; i <= int.Parse(frmluachon.strsoluongcauhoi); i++)
            {
                strdapan[i] = (line = srdapan.ReadLine());
            }
        }
        int j = 0;
        string strcheck;
        private void test()
        {
            strcheck = strdapan[j];    
            if (checkBox1.Text == strcheck && checkBox1.Checked)
            {
                diem = diem + 1;
            }
            if (checkBox2.Text == strcheck && checkBox2.Checked)
            {
                diem = diem + 1;
            }
            if (checkBox3.Text == strcheck && checkBox3.Checked)
            {
                diem = diem + 1;
            }
            if (checkBox4.Text == strcheck && checkBox4.Checked)
            {
                diem = diem + 1;
            }
            int diem1 = 0 + diem;
            label1.Text = diem1.ToString();
        }
        private void getdapan()
        {
            strcheck = strdapan[j + 1];
            if (checkBox1.Text == strcheck && checkBox1.Checked)
            {
                diem = diem + 1;
            }
            if (checkBox2.Text == strcheck && checkBox2.Checked)
            {
                diem = diem + 1;
            }
            if (checkBox3.Text == strcheck && checkBox3.Checked)
            {
                diem = diem + 1;
            }
            if (checkBox4.Text == strcheck && checkBox4.Checked)
            {
                diem = diem + 1;
            }
            int diem1 = 0 + diem;
            label1.Text = diem1.ToString();
        }
        public void load()
        {
            p = int.Parse(frmluachon.strthoigian);
            strcapdo1 = frmluachon.strcapdo;
            strsoluongcauhoi1 = frmluachon.strsoluongcauhoi;
            lbcapdo.Text = strcapdo1.ToString();
            lbsoluong.Text = strsoluongcauhoi1.ToString();
            lbthoigian.Text = p.ToString() + "   phut ";
            label6.Text = frmluachon.tenthisinh;
        }

        private void getdatakq()
        {
            ten = frmluachon.tenthisinh;
            strcapdo1 = frmluachon.strcapdo;
            strsoluongcauhoi1 = frmluachon.strsoluongcauhoi;
            diemkq = label1.Text;
            frmKetQuathuthu frmformkq = new frmKetQuathuthu();
            frmformkq.frmformthi1 = this;
            frmformkq.Show();
        }
        /// <summary>
        /// Lấy dữ liệu theo dòng
        /// </summary>
        /// <param name="Rows">Dòng cần lấy</param>
        private void getData(int Rows)
        {
            List<string> lst = new List<string>();
            lst = readfile("datadoan.txt");
            if (Rows >= lst.Count)
            {
                Rows = iRows = lst.Count - sodonghienlen;
            }
            else if (Rows <= 0)
            {
                Rows = iRows = 0;
            }
            //if + else kiểm tra đã load hết file text chưa nếu hết thì khi nhấn next sẽ k hiện ra gì nữa
            for (int i = 0; i < sodonghienlen; i++)
            {
                string strTemp = "";
                if ((Rows + i) < lst.Count)
                {
                    strTemp = lst[Rows + i].ToString();
                }
                switch (i)
                {
                    case 0:
                        lbcauhoi.Text = strTemp;
                        break;
                    case 1:
                        checkBox1.Text= strTemp;
                        checkBox1.Checked = false;
                        break;
                    case 2:
                        checkBox2.Text = strTemp;
                        checkBox2.Checked = false;
                        break;
                    case 3:
                        checkBox3.Text = strTemp;
                        checkBox3.Checked = false;
                        break;
                    case 4:
                        checkBox4.Text = strTemp;
                        checkBox4.Checked = false;
                        break;
                    default:
                        lbd.Text = strTemp;
                        break;
                }
            }
        }

        private int totalS(int sodongtrentrang)
        {
            int sodong = readfile(@"dataddoan.txt").Count;
            if ((sodong % sodongtrentrang) > 0)
            {
                return sodong / sodongtrentrang + 1;
            }
            else
            {
                return sodong / sodongtrentrang;
            }
        }

        /// <summary>
        /// Hàm đọc file txt gán dữ liệu vào List(cái này giống Array)
        /// </summary>
        /// <param name="path">Đường dẫn file txt</param>
        /// <returns>Giá trị trả về là Mảng chứa tất cả các câu trong file txt</returns>
        private List<string> readfile(string path)
        {
            List<string> lst = new List<string>();
            StreamReader stReader = new StreamReader(path);
            //Lập lại cho đến câu cuối cùng của file txt
            while (stReader.Peek() >= 0)
            {
                //Thêm giá trị vào List
                lst.Add(stReader.ReadLine());
            }
            return lst;
        }
        private void btPre_Click(object sender, EventArgs e)
        {
            iRows -= sodonghienlen;
            getData(iRows);
            if (i < 100 && i > 1)
            {
                i--;
                groupBox1.Text = " Nội dung câu hỏi  " + i.ToString();
            }
            else
                return;
        }
        
        private void btNext_Click(object sender, EventArgs e)
        {
            test();
            getdapan();
            iRows += sodonghienlen;
            getData(iRows);
            if (i < 1)
                return;
            else
            {
                //strsoluongcauhoi1 = frmluachon.strsoluongcauhoi;
                i++;
                if (int.Parse(strsoluongcauhoi1)< i)
                {
                    groupBox1.Text = " Nội dung câu hỏi  " + i.ToString();
                    if (MessageBox.Show("Bạn đã làm xong","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)== DialogResult.OK)
                    {
                      
                    } 
                }
                else
                {
                    groupBox1.Text = " Nội dung câu hỏi  " + i.ToString();
                }
            }
            j = j + 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            p--;
            lbtime.Text =p.ToString() +"  phut";
            if (p==0)
            {
                timer1.Stop();
                MessageBox.Show("Da het gio lam bai");
            }
        }
        private void frmThi_Load(object sender, EventArgs e)
        {
            test();
            dapan();
            getData(iRows);
            load();
            label1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getdatakq();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

    }

