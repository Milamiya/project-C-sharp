using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace LichCongTac
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        Modules.StringMessage strMess = new LichCongTac.Modules.StringMessage();
        Modules.AgentController controller ;
        Modules.ConvertTime convertTime = new LichCongTac.Modules.ConvertTime();
        Modules.ConnectionString sqlConnec = new LichCongTac.Modules.ConnectionString();
        Modules.Global global = new LichCongTac.Modules.Global();
        Modules.TinhThu tinhThu = new LichCongTac.Modules.TinhThu();

        public static string strDangNhap = null;
        public static int intQuyenTruyCap;
        private string strNgayCanTim = null;
        private string strGioCanTim = null;
        public static string strNoiDungCongViec = null;
        private string strNgayHomNay = null;
        
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin lg = new frmLogin();
            lg.ShowDialog();
            if (lg.getNumberAccount() == 0)
            {
                this.PhanQuyen_Guest();
                toolStripTrangThai.Text = lg.getAccountName();
                strDangNhap = lg.getAccountName();
                intQuyenTruyCap = 0;
            }
            if (lg.getNumberAccount() == 1)
            {
                this.PhanQuyen_Administrator();
                toolStripTrangThai.Text = lg.getAccountName();
                strDangNhap = lg.getAccountName();
                intQuyenTruyCap = 1;
            }
        }

        private void đangXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Thoát Khỏi Tài Khoản Này", strMess.strTieuDe, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.PhanQuyen_ChuaDangNhap();
                strDangNhap = null;
                toolStripTrangThai.Text = "Chưa Đăng Nhập";                
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //timer3.Enabled = true;
            timer1.Enabled = true;
            controller = new LichCongTac.Modules.AgentController(axAgent1, "Genie");
            controller.Show();
            controller.Speak("WellCome");
            controller.MoveTo(777, 555);
            controller.Hide();
            PhanQuyen_ChuaDangNhap();
            //MessageBox.Show(System.DateTime.Now.ToLocalTime().ToShortTimeString());
            toolStripHour.Text = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
            //MessageBox.Show( convertTime.Convert("1:20 AM").ToString());
        }

        private void PhanQuyen_ChuaDangNhap()
        {
            lậpLịchCôngViệcToolStripMenuItem.Enabled = false;
            đangXuấtToolStripMenuItem.Enabled = false;
            đổiMậtKhẩuToolStripMenuItem.Enabled = false;
            tạoTàiKhoảnToolStripMenuItem.Enabled = false;
            traCứuCôngViệcToolStripMenuItem.Enabled = false;
            báoCáoToolStripMenuItem.Enabled = false;
        }
        private void PhanQuyen_Guest()
        {
            lậpLịchCôngViệcToolStripMenuItem.Enabled = true;
            đangXuấtToolStripMenuItem.Enabled = true;
            đổiMậtKhẩuToolStripMenuItem.Enabled = true;
            tạoTàiKhoảnToolStripMenuItem.Enabled = true;
            traCứuCôngViệcToolStripMenuItem.Enabled = true;
        }
        private void PhanQuyen_Administrator()
        {
            lậpLịchCôngViệcToolStripMenuItem.Enabled = true;
            đangXuấtToolStripMenuItem.Enabled = true;
            đổiMậtKhẩuToolStripMenuItem.Enabled = true;
            tạoTàiKhoảnToolStripMenuItem.Enabled = true;
            traCứuCôngViệcToolStripMenuItem.Enabled = true;
            báoCáoToolStripMenuItem.Enabled = true;
        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePass chanp = new frmChangePass();
            chanp.MdiParent = this;
            chanp.Show();
        }

        private void tạoTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmDangKy dk = new frmDangKy();
            //dk.MdiParent = this;
            //dk.Show();
        }

        private void lậpLịchCôngViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLichCongTac lct = new frmLichCongTac();
            lct.MdiParent = this;
            lct.Show();
        }

        private void traCứuCôngViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTraCuu frmTC = new frmTraCuu();
            frmTC.MdiParent = this;
            frmTC.Show();
        }

        private void tạoTàiKhoảnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDangKy dk = new frmDangKy();
            dk.MdiParent = this;
            dk.Show();
        }

        private void quảnLýNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyTaiKhoan tk = new frmQuanLyTaiKhoan();
            tk.MdiParent = this;
            tk.Show();
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            sqlConnec.getConnectionString();
            //bool boolTestValue = false;
            //string strNgayCanTim = null;
            if (FormWindowState.Minimized == WindowState)
            {
                Hide();
                if (frmLogin.boolDangNhapThanhCong)
                {
                    try
                    {
                        //int intDay = 0;
                        int intSotrungGian = 0;
                        //int j = 0;
                        strNgayHomNay = DateTime.Now.ToShortDateString();
                        int intNgayHomNay = tinhThu.ThuTrongThang(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                        strNgayHomNay = global.ConvertFormatDay(strNgayHomNay);
                        strNgayHomNay = global.Convert_Day(strNgayHomNay);
                        string strSQL = "select * from LichLamViec where TenDangNhap = '" + strDangNhap + "'";
                        SqlDataAdapter sqlADP = new SqlDataAdapter(strSQL, sqlConnec.sqlCNN);
                        DataTable dtTable = new DataTable();
                        sqlADP.Fill(dtTable);

                        //Tìm ngày có công việc gần nhất
                        strNgayCanTim = null;
                        int intNgayCanTim = 0;
                        for (int i = 0; i < dtTable.Rows.Count - 1; i++)
                        {
                            string strNgayBatDau = dtTable.Rows[i]["NgayBatDau"].ToString();
                            int intNgayBatDau = tinhThu.ThuTrongThang(Convert.ToInt32(strNgayBatDau.Substring(6, 4)), Convert.ToInt32(strNgayBatDau.Substring(3, 2)), Convert.ToInt32(strNgayBatDau.Substring(0, 2)));
                            if ((intNgayBatDau >= intNgayHomNay) && (intSotrungGian == 0))
                            {
                                strNgayCanTim = strNgayBatDau;
                                intNgayCanTim = tinhThu.ThuTrongThang(Convert.ToInt32(strNgayCanTim.Substring(6, 4)), Convert.ToInt32(strNgayCanTim.Substring(3, 2)), Convert.ToInt32(strNgayCanTim.Substring(0, 2)));
                                intSotrungGian = 1;
                            }
                            if ((intNgayBatDau >= intNgayHomNay) && (intSotrungGian == 1))
                            {
                                if (intNgayBatDau < intNgayCanTim)
                                {
                                    strNgayCanTim = strNgayBatDau;
                                }
                            } 
                        }

                        sqlADP.Dispose();
                        dtTable.Dispose();

                        //Tìm Giờ gần nhất
                        if (strNgayCanTim != null)
                        {
                            
                            int intGioCanTim = 0;
                            string strGioHienTai = DateTime.Now.ToShortTimeString();
                            int intGioHienTai = global.ConvertTime(strGioHienTai);
                            strSQL = "select * from LichLamViec where TenDangNhap = '" + strDangNhap + "' and NgayBatDau='" + strNgayCanTim + "'";
                            sqlADP = new SqlDataAdapter(strSQL, sqlConnec.sqlCNN);
                            dtTable = new DataTable();
                            sqlADP.Fill(dtTable);
                            intSotrungGian = 0;
                            if (strNgayCanTim == strNgayHomNay)
                            {
                                for (int i = 0; i < dtTable.Rows.Count - 1; i++)
                                {
                                    string strGioBatDau = dtTable.Rows[i]["GioBatDau"].ToString();
                                    int intGioBatDau = global.ConvertTime(strGioBatDau);
                                    if (intGioHienTai < intGioBatDau)
                                    {
                                        if (intSotrungGian == 0)
                                        {
                                            strGioCanTim = strGioBatDau;
                                            intSotrungGian = 1;
                                            intGioCanTim = global.ConvertTime(strGioCanTim);
                                        }
                                        else
                                        {
                                            if (intGioBatDau < intGioCanTim)
                                            {
                                                strGioCanTim = strGioBatDau;
                                                intGioCanTim = global.ConvertTime(strGioCanTim);
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                intSotrungGian = 0;
                                for (int i = 0; i < dtTable.Rows.Count - 1; i++)
                                {
                                    string strGioBatDau = dtTable.Rows[i]["GioBatDau"].ToString();
                                    int intGioBatDau = global.ConvertTime(strGioBatDau);
                                    if (intSotrungGian == 0)
                                    {
                                        strGioCanTim = strGioBatDau;
                                        intSotrungGian = 1;
                                        intGioCanTim = global.ConvertTime(strGioCanTim);
                                    }
                                    else
                                    {
                                        if (intGioBatDau < intGioCanTim)
                                        {
                                            strGioCanTim = strGioBatDau;
                                            intGioCanTim = global.ConvertTime(strGioCanTim);
                                        }
                                    }
                                }
                                
                            }
                            //MessageBox.Show(strGioCanTim);
                        }
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                    //MessageBox.Show(strNgayCanTim);
                }
                if ((strNgayCanTim != null) && (strGioCanTim != null))
                {
                    timer3.Enabled = true;
                }
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true;
        }

        private void đồngHồCủaTôiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VirtualClock.Form1 vc = new VirtualClock.Form1();
            vc.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripHour.Text = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
        }
        //object sender = null;  EventArgs e=null;
        //private void timer2_Tick(object sender, EventArgs e)
        //{
        //    //bool bollValueTest = false;
        //    //string strDateNow = DateTime.Now.ToShortTimeString();
        //    //strDateNow = global.ConvertFormatDay(strDateNow);
        //    ////string strNoiDungCongViec = null;
        //    //if (strDateNow == strNgayCanTim)
        //    //{
        //    //    sqlConnec.getConnectionString();
        //    //    string strSQL = "Select GioBatDau ,NoiDungCongViec from LichLamViec where NgayBatDau = '" + strNgayCanTim + "'";
        //    //    //strSQL = "Select NoiDungCongViec from LichLamViec where NgayBatDau ='" + strNgayCanTim + "'";
        //    //    SqlDataAdapter sqlADP = new SqlDataAdapter(strSQL, sqlConnec.sqlCNN);
        //    //    DataTable dtTable = new DataTable();
        //    //    sqlADP.Fill(dtTable);
        //    //    for (int i = 0; i <= dtTable.Rows.Count - 1; i++)
        //    //    {
        //    //        if (dtTable.Rows[i]["GioBatDau"].ToString() == DateTime.Now.ToShortTimeString())
        //    //        {
        //    //            strNoiDungCongViec += dtTable.Rows[i]["NoiDungCongViec"].ToString() + " Vào Lúc " + dtTable.Rows[i]["GioBatDau"].ToString() + "\n";
        //    //            bollValueTest = true;
        //    //        }
        //    //    }
        //    //}
        //    //if (bollValueTest)
        //    //{
        //    //    timer2.Stop();
        //    //    frmMain.ActiveForm.WindowState = FormWindowState.Maximized;
        //    //    frmNoiDungNhacNho NoiDung = new frmNoiDungNhacNho();
        //    //    NoiDung.Show();
        //    //}
        //}

        private void timer3_Tick(object sender, EventArgs e)
        {
            //bool bollValueTest = false;
            
            //string strNoiDungCongViec = null;
            if (strNgayHomNay == strNgayCanTim)
            {
                sqlConnec.getConnectionString();
                string strSQL = "Select NoiDungCongViec from LichLamViec where NgayBatDau = '" + strNgayCanTim + "' and GioBatDau='"+strGioCanTim+"'";
                //strSQL = "Select NoiDungCongViec from LichLamViec where NgayBatDau ='" + strNgayCanTim + "'";
                SqlDataAdapter sqlADP = new SqlDataAdapter(strSQL, sqlConnec.sqlCNN);
                DataTable dtTable = new DataTable();
                sqlADP.Fill(dtTable);
                for (int i = 0; i <= dtTable.Rows.Count - 1; i++)
                {
                    int j=i+1;
                    strNoiDungCongViec += "Nội Dung Công Việc " + j.ToString() + " " + dtTable.Rows[i]["NoiDungCongViec"].ToString() + " \n";
                }
            }
            string strTime = DateTime.Now.ToShortTimeString();
            if ((strGioCanTim == strTime) && (strNgayHomNay == strNgayCanTim))
            {
                timer2.Stop();
                timer3.Stop();
                this.Visible = true;
                frmNoiDungNhacNho NoiDung = new frmNoiDungNhacNho();
                NoiDung.MdiParent = this;
                NoiDung.Show(); 
            }
            strNoiDungCongViec = null;
        }

        private void chuyểnĐơnVịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChuyenDonVi fc = new frmChuyenDonVi();
            fc.MdiParent = this;
            fc.Show();
        }

        private void côngViệcĐãThựcHiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCRDaThucHien fd = new frmCRDaThucHien();
            fd.MdiParent = this;
            fd.Show();
        }

        private void côngViệcChưaThựcHiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCRChuaThucHien fc = new frmCRChuaThucHien();
            fc.MdiParent = this;
            fc.Show();
        }
    }
}