using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Pabo.Calendar;

namespace LichCongTac
{
    public partial class frmLichCongTac : Form
    {
        public frmLichCongTac()
        {
            InitializeComponent();
        }

        Modules.ThemNgayAm themNgayAm = new LichCongTac.Modules.ThemNgayAm();
        Modules.TinhThu tinhThu = new LichCongTac.Modules.TinhThu();
        Modules.ConnectionString sqlConn = new LichCongTac.Modules.ConnectionString();
        Modules.StringMessage strMess = new LichCongTac.Modules.StringMessage();
        Modules.Global global = new LichCongTac.Modules.Global();

        private int TestYear=System.DateTime.Now.Year;
        private int intTestNumber = 0;
        private int intMonthNow = System.DateTime.Now.Month;
        public static string strNoiDungSauCung;
        public static string strNoiDungCongViec;
        public static int intTest = 0;
        private string strNgayBatDau = null;
        private string strNgayKetThuc = null;
        private string strThoiGianBatDau = null;
        private string strThoiGianKetThuc = null;

        private string strHourseStart = null;
        private string strMinutesStart = null;
        private string strTimeStart = null;
        private string strHourseEnd = null;
        private string strMinutesEnd = null;
        private string strTimeEnd = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            themNgayAm.TextOfDay(System.DateTime.Now.Year, mcLichCongViec);
            mcLichCongViec.ActiveMonth.Month = System.DateTime.Now.Month;
            try
            {
                sqlConn.getConnectionString();
            }
            catch
            {
                MessageBox.Show(strMess.strChuaKetNoiCSDL, strMess.strTieuDe, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void mcLichCongViec_MonthChanged(object sender, Pabo.Calendar.MonthChangedEventArgs e)
        {
            intMonthNow = e.Month;
            int intYear = e.Year;
            if (TestYear != intYear)
            {
                mcLichCongViec.Dates.Clear();
                TestYear = intYear;
                themNgayAm.TextOfDay(TestYear, mcLichCongViec);
            }           
        }

        private void mcLichCongViec_DayDoubleClick(object sender, DayClickEventArgs e)
        {
            if (intTestNumber == 0)
            {
                dtpNgayBatDau.Text = e.Date.ToString();
                intTestNumber = 1;
            }
            else
            {
                dtpNgayXongCV.Text = e.Date.ToString();
                intTestNumber = 0;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dtpNgayBatDau.Text = "";
            dtpNgayXongCV.Text = "";
            rtbNoiDungCongViec.Text = "";
            intTestNumber = 0;

            comboHourStart.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                comboHourStart.Items.Add(i.ToString());    
            }

            comboMinutesStart.Items.Clear();
            for (int i = 0; i <= 60; i++)
            {
                comboMinutesStart.Items.Add(i.ToString());
            }

            comboTimeStart.Items.Clear();
            comboTimeStart.Items.Add("AM");
            comboTimeStart.Items.Add("PM");

            comboHourEnd.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                comboHourEnd.Items.Add(i.ToString());
            }

            comboMinutesEnd.Items.Clear();
            for (int i = 0; i <= 60; i++)
            {
                comboMinutesEnd.Items.Add(i.ToString());
            }

            comboTimeEnd.Items.Clear();
            comboTimeEnd.Items.Add("AM");
            comboTimeEnd.Items.Add("PM");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (dtpNgayBatDau.Checked)
            {
                strNgayBatDau = dtpNgayBatDau.Text;
            }
            else
            {
                strNgayBatDau = null;
            }
            if (dtpNgayXongCV.Checked)
            {
                strNgayKetThuc = dtpNgayXongCV.Text;
            }
            else
            {
                strNgayKetThuc = null;
            }
            try
            {
                string strDangNhap = frmMain.strDangNhap;
                if ((strHourseStart != null) && (strMinutesStart != null) & (strTimeStart != null))
                {
                    strThoiGianBatDau = strHourseStart + ":" + strMinutesStart + " " + strTimeStart;
                }
                else
                {
                    strThoiGianBatDau = null;
                }
                if ((strHourseEnd != null) && (strMinutesEnd != null) & (strTimeEnd != null))
                {
                    strThoiGianKetThuc = strHourseEnd + ":" + strMinutesEnd + " " + strTimeEnd;
                }
                else
                {
                    strThoiGianKetThuc = null;
                }
                if ((strHourseStart == null) || (strMinutesStart == null) || (strTimeStart == null) || (strHourseEnd == null) || (strMinutesEnd == null) || (strTimeEnd == null))
                {
                    MessageBox.Show("Giờ Bạn Nhập Chưa Chính Xác - Vui Lòng Thử Lại", strMess.strTieuDe, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (CompareTime(strNgayBatDau,strNgayKetThuc,strThoiGianBatDau,strThoiGianKetThuc))
                    {
                        string strSQL = "insert into LichLamViec values(N'" + strDangNhap + "',N'" + strNgayBatDau + "',N'" + strNgayKetThuc + "',N'" + strThoiGianBatDau + "',N'" + rtbNoiDungCongViec.Text.Trim() + "',N'Chưa Thực Hiện',N'" + strThoiGianKetThuc + "')";
                        global.SQL_Database(strSQL, sqlConn.sqlCNN);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, strMess.strTieuDe, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        frmNoiDungCongViec nd;
        private void mcLichCongViec_DayMouseMove(object sender, DayMouseMoveEventArgs e)
        {
            
            int intMonthSelect = Convert.ToInt32(e.Date.Substring(3, 2));
            if (intMonthSelect == intMonthNow)
            {
                string strGioBatDau;
                string strGioKetThuc;
                string strThoiGianBatDau;
                string strThoiGianKetThuc;
                string strDaySeLect = e.Date.ToString();
                string strSQL = "select * from LichLamViec where NgayBatDau='" + strDaySeLect + "' and TenDangNhap='" + frmMain.strDangNhap + "'";
                DataTable dtTable = new DataTable();
                SqlDataAdapter sqlADP = new SqlDataAdapter(strSQL,sqlConn.sqlCNN);
                sqlADP.Fill(dtTable);
                if (dtTable.Rows.Count > 0)
                {
                    for (int i = 0; i <= dtTable.Rows.Count - 1; i++)
                    {
                        strNoiDungCongViec = dtTable.Rows[i]["NoiDungCongViec"].ToString();
                        strGioBatDau = dtTable.Rows[i]["GioBatDau"].ToString();
                        strThoiGianBatDau = dtTable.Rows[i]["NgayBatDau"].ToString();
                        strGioKetThuc = dtTable.Rows[i]["GioKetThuc"].ToString();
                        strThoiGianKetThuc=dtTable.Rows[i]["NgayKetThuc"].ToString();
                        int intSodem = i + 1;
                        strNoiDungSauCung += "Công Việc " + intSodem.ToString() + " :\n" + strNoiDungCongViec + "\n" + "Công Việc Bắt Đầu Vào Lúc " + strGioBatDau + " " + "Trong Ngày " + strThoiGianBatDau + "\n" + "Công Việc Kết Thúc Vào Lúc " + strGioKetThuc + " " + "Trong Ngày " + strThoiGianKetThuc + "\n" + "\n";
                    }
                    
                    if (intTest == 0)
                    {
                        nd = new frmNoiDungCongViec();
                        nd.MdiParent = frmMain.ActiveForm;
                        nd.Show();
                        intTest += 1;
                    }
                    if (intTest > 0)
                    {
                        nd.CallEventLoadFrom();
                    }
                    strNoiDungSauCung = "";
                }
            }
        }

        private void comboHour_SelectedIndexChanged(object sender, EventArgs e)
        {
            strHourseStart = comboHourStart.SelectedItem.ToString();         
        }

        private void comboMinutesStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            strMinutesStart = comboMinutesStart.SelectedItem.ToString();
        }

        private void comboTimeStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            strTimeStart = comboTimeStart.SelectedItem.ToString();
        }

        private void comboHourEnd_SelectedIndexChanged(object sender, EventArgs e)
        {
            strHourseEnd = comboHourEnd.SelectedItem.ToString();
        }

        private void comboMinutesEnd_SelectedIndexChanged(object sender, EventArgs e)
        {
            strMinutesEnd = comboMinutesEnd.SelectedItem.ToString();
        }

        private void comboTimeEnd_SelectedIndexChanged(object sender, EventArgs e)
        {
            strTimeEnd = comboTimeEnd.SelectedItem.ToString();
        }

        private void dtpNgayBatDau_ValueChanged(object sender, EventArgs e)
        {
            intTestNumber = 1;
        }

        private void dtpNgayXongCV_ValueChanged(object sender, EventArgs e)
        {
            intTestNumber = 0;
        }
        private bool CompareTime(string strDayStart, string strDayEnd, string strGioBatDau, string strGioKetThuc)
        {
            bool bollTest = true;
            int intGioBatDau = 0;
            int intGioKetThuc = 0;
            try
            {
                string strNgayBatDau = global.getDay(strDayStart);
                string strThangBatDau = global.getMonth(strDayStart);
                string strNamBatDau = global.getYear(strDayStart);

                string strNgayKetThuc = global.getDay(strDayEnd);
                string strThangKetThuc = global.getMonth(strDayEnd);
                string strNamKetThuc = global.getYear(strDayEnd);

                int intDayStart = tinhThu.ThuTrongThang(Convert.ToInt32(strNamBatDau), Convert.ToInt32(strThangBatDau), Convert.ToInt32(strNgayBatDau));
                int intDayEnd = tinhThu.ThuTrongThang(Convert.ToInt32(strNamKetThuc), Convert.ToInt32(strThangKetThuc), Convert.ToInt32(strNgayKetThuc));
                if (intDayStart > intDayEnd)
                {
                    MessageBox.Show("Ngày Kết Thúc Không Thể Trước Ngày Bắt Đầu", strMess.strTieuDe, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    bollTest = false;
                    int a = 0;
                    int b = 2 / a;
                }
                if (intDayStart == intDayEnd)
                {
                    intGioBatDau = global.ConvertTime(strGioBatDau);
                    intGioKetThuc = global.ConvertTime(strGioKetThuc);
                    if (intGioBatDau <= intGioKetThuc)
                    {
                        MessageBox.Show("Giờ Kết Thúc Phải Muộn Hơn Giờ Bắt Đầu", strMess.strTieuDe, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        bollTest = false;
                        int a = 0;
                        int b = 2 / a;
                    }
                }
                
            }
            catch
            {

            }
            return bollTest;
        }
    }
}