using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.IO;
namespace Doan
{
    public partial class frmThiThat : Form
    {
        public string hoten1, mats1;
        public int diem;
        int s, p, h;
        DataTable BangDeThi = new DataTable();
        int CauHienTai = 0;
        public int SoCauDung = 0;
        int SoCauHoi = 0;
        public bool DeThi = false;
        int SoCauNgauNhien = 50;//qui dinh bao nhieu cau thi tu dien
        
        public frmThiThat(string strvalue,string strvalue1)
        {

            InitializeComponent();
            getvalueformdienten = strvalue;
            getvalueformdienma = strvalue1;
            
        }
        void Load_DeThiThat()
        {
            try
            {
                SqlConnection cnn = new SqlConnection("server=.\\SQLEXPRESS;database=QL_Thitracnghiem;integrated security =true");
                SqlDataAdapter da = new SqlDataAdapter("select cauhoi.mach,cauhoi,a,b,c,d ,dapan from cauhoi,DAPAN where cauhoi.mach=DAPAN.mach", cnn);
                DataTable BangQuestion = new DataTable();
                da.Fill(BangQuestion);
                TaoBangRandomCauHoi(BangQuestion);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            p = 60;//nhap thoi gian thi 
            s = 60;
            h = 0;  
        }
        void TaoBangRandomCauHoi(DataTable BangQuestion)
        {
            
            try
            {
                Random Rnd = new Random();
                ArrayList ArrQuestion = new ArrayList();

                ArrQuestion.Clear();
                int x, dem = 0;
                int SoCauTrongBangGoc = BangQuestion.Rows.Count;
                while (dem < SoCauNgauNhien)
                {
                    x = Rnd.Next(0, SoCauTrongBangGoc);
                    if (!ArrQuestion.Contains(x))
                    {
                        ArrQuestion.Add(x);
                        dem++;
                    }
                }
                for (int j = SoCauTrongBangGoc - 1; j >= 0; j--)
                    if (!ArrQuestion.Contains(j))
                        BangQuestion.Rows.RemoveAt(j);

                BangDeThi = BangQuestion;
                BangDeThi.Columns.Add("cauhoi,DAPAN");

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }
        void TaoBangRandomCauTraLoi()
        {
            try
            {
                SoCauHoi = BangDeThi.Rows.Count;
                string DapAnDung = "";
                string A, B, C, D;
                int DapAn;
                Random Rnd = new Random();
                ArrayList ArrDapAn = new ArrayList();
                for (int i = 0; i < SoCauHoi; i++)
                {
                    A = "";
                    B = "";
                    C = "";
                    D = "";
                    DapAnDung = "";
                    DapAn = 0;
                    ArrDapAn.Clear();
                    ArrDapAn.Add(2);
                    ArrDapAn.Add(3);
                    ArrDapAn.Add(4);
                    ArrDapAn.Add(5);
                    
                    DapAn = Rnd.Next(ArrDapAn.Count);
                    A = BangDeThi.Rows[i][(int)ArrDapAn[DapAn]].ToString();
                    if ((BangDeThi.Rows[i][6].ToString().ToUpper().Contains("A") && (int)ArrDapAn[DapAn] == 2) || (BangDeThi.Rows[i][6].ToString().ToUpper().Contains("B") && (int)ArrDapAn[DapAn] == 3) || (BangDeThi.Rows[i][6].ToString().ToUpper().Contains("C") && (int)ArrDapAn[DapAn] == 4) || (BangDeThi.Rows[i][6].ToString().ToUpper().Contains("D") && (int)ArrDapAn[DapAn] == 5))
                        DapAnDung += "A";
                    ArrDapAn.RemoveAt(DapAn);
                    DapAn = Rnd.Next(ArrDapAn.Count);
                    B = BangDeThi.Rows[i][(int)ArrDapAn[DapAn]].ToString();
                    if ((BangDeThi.Rows[i][6].ToString().ToUpper().Contains("A") && (int)ArrDapAn[DapAn] == 2) || (BangDeThi.Rows[i][6].ToString().ToUpper().Contains("B") && (int)ArrDapAn[DapAn] == 3) || (BangDeThi.Rows[i][6].ToString().ToUpper().Contains("C") && (int)ArrDapAn[DapAn] == 4) || (BangDeThi.Rows[i][6].ToString().ToUpper().Contains("D") && (int)ArrDapAn[DapAn] == 5))
                        DapAnDung += "B";
                    ArrDapAn.RemoveAt(DapAn);
                    DapAn = Rnd.Next(ArrDapAn.Count);
                    C = BangDeThi.Rows[i][(int)ArrDapAn[DapAn]].ToString();
                    if ((BangDeThi.Rows[i][6].ToString().ToUpper().Contains("A") && (int)ArrDapAn[DapAn] == 2) || (BangDeThi.Rows[i][6].ToString().ToUpper().Contains("B") && (int)ArrDapAn[DapAn] == 3) || (BangDeThi.Rows[i][6].ToString().ToUpper().Contains("C") && (int)ArrDapAn[DapAn] == 4) || (BangDeThi.Rows[i][6].ToString().ToUpper().Contains("D") && (int)ArrDapAn[DapAn] == 5))
                        DapAnDung += "C";
                    ArrDapAn.RemoveAt(DapAn);
                    DapAn = Rnd.Next(ArrDapAn.Count);
                    D = BangDeThi.Rows[i][(int)ArrDapAn[DapAn]].ToString();
                    if ((BangDeThi.Rows[i][6].ToString().ToUpper().Contains("A") && (int)ArrDapAn[DapAn] == 2) || (BangDeThi.Rows[i][6].ToString().ToUpper().Contains("B") && (int)ArrDapAn[DapAn] == 3) || (BangDeThi.Rows[i][6].ToString().ToUpper().Contains("C") && (int)ArrDapAn[DapAn] == 4) || (BangDeThi.Rows[i][6].ToString().ToUpper().Contains("D") && (int)ArrDapAn[DapAn] == 5))
                        DapAnDung += "D";
                    BangDeThi.Rows[i][2] = A;
                    BangDeThi.Rows[i][3] = B;
                    BangDeThi.Rows[i][4] = C;
                    BangDeThi.Rows[i][5] = D;
                    BangDeThi.Rows[i][6] = DapAnDung;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        void LoadCauHoiVaoControl()
        {
            
            try
            {
                groupBox1.Text = "Câu: " + (CauHienTai + 1).ToString();
                lbCauHoi.Text = BangDeThi.Rows[CauHienTai][1].ToString();
                lbA.Text = BangDeThi.Rows[CauHienTai][2].ToString();
                lbB.Text = BangDeThi.Rows[CauHienTai][3].ToString();
                lbC.Text = BangDeThi.Rows[CauHienTai][4].ToString();
                lbD.Text = BangDeThi.Rows[CauHienTai][5].ToString();

                if (BangDeThi.Rows[CauHienTai][7].ToString().Contains("A"))
                    checkBox1.Checked = true;
                if (BangDeThi.Rows[CauHienTai][7].ToString().Contains("B"))
                    checkBox2.Checked = true;
                if (BangDeThi.Rows[CauHienTai][7].ToString().Contains("C"))
                    checkBox3.Checked = true;
                if (BangDeThi.Rows[CauHienTai][7].ToString().Contains("D"))
                    checkBox4.Checked = true;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        void GhiLaiDapAnTS()
        {
            string DapAnTS = "";
            if (checkBox1.Checked == true)
                DapAnTS += "A";
            if (checkBox2.Checked == true)
                DapAnTS += "B";
            if (checkBox3.Checked == true)
                DapAnTS += "C";
            if (checkBox4.Checked == true)
                DapAnTS += "D";
            BangDeThi.Rows[CauHienTai][7] = DapAnTS;
        }
      //lay thong tin//
        public string getvalueformdienten
        {
            set
            {
                this.lbhoten.Text = value;
                
            }
           
        }
        public string getvalueformdienma
        {
            set
            {
                this.lbmathisinh.Text = value;  
            }
        }
    
        private void frmThiThat_Load(object sender, EventArgs e)
        {
           
           
            lbNgaythang.Text = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();

            {
                try
                {
                    if (DeThi == true)
                        Load_DeThiThat();
                    else
                        Load_DeThiThat();
                    TaoBangRandomCauTraLoi();
                    LoadCauHoiVaoControl();
                    timer1.Start();
                    
                    btPre.Enabled = false;
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            }

        }

        private void btPre_Click(object sender, EventArgs e)
        {
            try
            {
                GhiLaiDapAnTS();
                if (CauHienTai > 0)
                {
                    GhiLaiDapAnTS();
                    btNext.Enabled = true;
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                    checkBox4.Checked = false;
                    CauHienTai--;
                    LoadCauHoiVaoControl();
                }
                if (CauHienTai == 0)
                    btPre.Enabled = false;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            try
            {
                GhiLaiDapAnTS();
                if (CauHienTai < SoCauHoi - 1)
                {
                    GhiLaiDapAnTS();
                    btPre.Enabled = true;
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                    checkBox4.Checked = false;
                    CauHienTai++;
                    LoadCauHoiVaoControl();
                }
                if (CauHienTai == SoCauHoi - 1)
                    btNext.Enabled = false;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btketthuc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn kết thúc không ?" , "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Hide();
                try
                {
                    timer1.Stop();
                    btketthuc.Enabled = false;
                    
                    GhiLaiDapAnTS();
                    SoCauDung = 0;
                    for (int i = 0; i < SoCauHoi; i++)
                    {
                        if (BangDeThi.Rows[i][6].ToString().ToUpper() == BangDeThi.Rows[i][7].ToString().ToUpper())
                            SoCauDung++;

                    }
                    
                    diem = SoCauDung * 2;
                    MessageBox.Show("Đúng " + SoCauDung.ToString() + " câu " + "  Bạn được  " + diem.ToString() + "  điểm ");
                    this.Close();
                    string ten = lbhoten.Text;
                    string mats = lbmathisinh.Text;
                    string diem1 = diem.ToString();
                    string socaudung = SoCauDung.ToString();
                    frmKetQua ketqua = new frmKetQua(ten,mats,diem1,socaudung);
                    ketqua.ShowDialog();
                    //them form ket qua tai day 
                    
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            }
            else
            { return; }
        }
       

        int th =0;
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            
            s--;
            th--;
            if (th == 0)
            {
                                    timer1.Stop();
                    MessageBox.Show("Hết giờ làm bài!", "Thong bao");
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                    checkBox4.Checked = false;

                    GhiLaiDapAnTS();
                    SoCauDung = 0;
                    for (int i = 0; i < SoCauHoi; i++)
                    {
                        if (BangDeThi.Rows[i][6].ToString().ToUpper() == BangDeThi.Rows[i][7].ToString().ToUpper())
                            SoCauDung++;
                    }
                    int diem;
                    diem = SoCauDung * 2;
                    MessageBox.Show("Đúng " + SoCauDung.ToString()+" câu " + "  Bạn được  " + diem.ToString() + "  điểm ");
                    this.Close();
                
            }
            if (s == 0)
            {
                p--;
                if (p == 0)
                {
                    s = 60;
                    th = s;                                                  
                }
                s = 60;
            }
              
                lblHour.Text = h.ToString() + "  : " + p.ToString() + " : " + s.ToString();

            }
        }
    }
    

    

