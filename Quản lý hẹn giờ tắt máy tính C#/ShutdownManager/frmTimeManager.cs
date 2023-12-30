using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TaskScheduler;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;

namespace ShutdownManager
{
    public partial class frmTimeManager : Form
    {
        public frmTimeManager()
        {
            InitializeComponent();
        }

        Modules.Global global = new ShutdownManager.Modules.Global();
        Modules.LockComputer lockComputer = new ShutdownManager.Modules.LockComputer();

        private string strAction = null;
        private int intMinutes = 0;
        private int intSecond = 59;
        private bool boolMessageShutDown = false;
        private int intTestClose = 0;
        public static string strNameScheduled = null;

        #region Event

        private void frmTimeManager_Load(object sender, EventArgs e)
        {
            CultureInfo ci = CultureInfo.CurrentCulture;
            SetShortDate("M/d/yyyy");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (intTestClose == 0)
            {
                if (MessageBox.Show("Bạn Có Muốn Thoát Khỏi Chương Trình", "Time Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    intTestClose = 1;
                    Application.Exit();
                }
            }
            intTestClose = 0;
        }
      
        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                //Giờ

                cbGio.Items.Clear();
                cbGio.Text = "";
                string strValueItem = null;
                for (int i = 0; i < 24; i++)
                {
                    if (i < 10)
                    {
                        strValueItem = "0" + i.ToString();
                    }
                    else
                    {
                        strValueItem = i.ToString();
                    }

                    cbGio.Items.Add(strValueItem);
                }

                //Phút

                cbPhut.Items.Clear();
                cbPhut.Text = "";
                for (int i = 0; i < 60; i++)
                {
                    if (i < 10)
                    {
                        strValueItem = "0" + i.ToString();
                    }
                    else
                    {
                        strValueItem = i.ToString();
                    }

                    cbPhut.Items.Add(strValueItem);
                }

                //Ngày

                dtpNgay.Text = DateTime.Now.ToShortDateString();

                //Hành Động

                cbHanhDong.Items.Clear();
                cbHanhDong.Text = "";
                cbHanhDong.Items.Add("Khoá Máy");
                cbHanhDong.Items.Add("Log Off");
                cbHanhDong.Items.Add("Khởi Động Lại");
                cbHanhDong.Items.Add("Tắt Máy");
                cbHanhDong.Items.Add("Bắt Buộc Log Off");
                cbHanhDong.Items.Add("Hibernate(Ngủ Đông)");
                cbHanhDong.Items.Add("Stand By");

                //Time
                timer1.Enabled = false;

                //lbl
                lblTime.Text = "Chưa Thiết Lập";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                //Lấy Giờ Và Ngày Thực Hiện Công Việc 

                string strHour = null;
                string strDay = null;

                if ((cbGio.Text.Trim() != "") && (cbHanhDong.Text.Trim() != ""))
                {

                    if (cbPhut.Text != "")
                    {
                        strHour = cbGio.Text.Trim() + ":" + cbPhut.Text.Trim() + " ";
                    }
                    else
                    {
                        strHour = cbGio.Text.Trim() + ":" + "00" + " ";
                    }
                    if (dtpNgay.Checked)
                    {
                        strDay = dtpNgay.Text.Trim();
                    }
                    else
                    {
                        strDay = DateTime.Now.ToShortDateString();
                        strDay = global.Convert_Day(strDay);
                    }

                    //Lấy Giờ Và Ngày Hệ Thống
                    string strSystemHour = null;
                    string strSystemTime = null;
                    strSystemHour = DateTime.Now.ToShortTimeString();
                    strSystemTime = DateTime.Now.ToShortDateString();
                    strSystemTime = global.Convert_Day(strSystemTime);

                    //Tính ra số phút còn lại 
                    intMinutes = global.ConvertHourToNumber(strHour, strSystemHour, strDay, strSystemTime);
                    if (intMinutes > 0)
                    {
                        //Lấy Hành Động
                        strAction = cbHanhDong.Text.Trim();

                        //Lấy boolMessageShutDown
                        if (cbMessageShutDown.Checked)
                        {
                            boolMessageShutDown = true;
                        }

                        timer1.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Giờ Của Hành Động Phải Lớn Hơn Giờ Hiện Hành", "Nhắc Nhở", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Bạn Chưa Chọn Giờ Hoặc Hành Động", "Nhắc Nhở", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        //Chuyển Số Phút Thành Giờ : Phút

        private string ConvertTime(int intPhut)
        {
            intPhut = intPhut - 1;
            int intHour = intPhut / 60;
            int intMinute = intPhut - (60 * intHour);
            intSecond = intSecond - 1;
            if (intSecond == 0)
            {
                intSecond = 59;
                intMinutes = intMinutes - 1;
            }
            string strTime = intHour.ToString() + " " + "Giờ" + " " + intMinute.ToString() + " " + "Phút" + " " + intSecond.ToString() + " " + "Giây";
            return strTime;
        }

        //Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            lblTime.Text = ConvertTime(intMinutes);
            notifyIcon1.Text = lblTime.Text;
            if ((intMinutes == 0)&&(intSecond == 59))
            {
                if (boolMessageShutDown)
                {
                    timer1.Enabled = false;
                    if (MessageBox.Show("Bạn Có Muốn " + strAction + " " + "Máy Tính Không", "Time Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Action(strAction);
                        lblTime.Text = "Chưa Thiết Lập";
                    }
                }
                else
                {
                    Action(strAction);
                    lblTime.Text = "Chưa Thiết Lập";
                }
                timer1.Enabled = false;
            }
        }

        //Action
        private void Action(string str)
        {
            if (str == "Khoá Máy")
            {
                lockComputer.Lock();
            }
            if (str == "Log Off")
            {
                lockComputer.LogOff();
            }
            if (str == "Khởi Động Lại")
            {
                lockComputer.Reboot();
            }
            if (str == "Tắt Máy")
            {
                lockComputer.Shutdown();
            }
            if (str == "Bắt Buộc Log Off")
            {
                lockComputer.ForceLogOff();
            }
            if (str == "Hibernate(Ngủ Đông)")
            {
                lockComputer.Hibernate();
            }
            if (str == "Stand By")
            {
                lockComputer.StandBy();
            }
        }

        //Auto Hibernate
        private void cbHiberbate_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOKHiberbate.Checked)
            {
                global.EnableHibernate("powercfg /hibernate on");
                cbCancelHibernate.Checked = false;
            }
        }

        private void cbCancelHibernate_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCancelHibernate.Checked)
            {
                global.EnableHibernate("powercfg /hibernate off");
                cbOKHiberbate.Checked = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //WebBrowser website = new WebBrowser();
            System.Diagnostics.Process.Start("iexplore.exe", @"http://cuasotinhoc.vn/index.php?");
        }

        #region MenuStrip
        //Tắt Máy
        private void tắtMáyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lockComputer.Shutdown();
        }

        //Khởi Động
        private void khởiĐộngLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lockComputer.Reboot();
        }

        //Log Off
        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lockComputer.LogOff();
        }

        //Stand By
        private void standByToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lockComputer.StandBy();
        }

        //Hibernate
        private void hibernateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lockComputer.Hibernate();
        }

        //Khoá Máy
        private void khoáMáyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lockComputer.Lock();
        }

        //Power Option
        private void powerOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            global.OpenProcess("C:\\WINDOWS\\system32\\Powercfg.cpl");
        }
        #endregion       

        #region Menu Bật Máy

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmNewTask frmNew = new frmNewTask();
            frmNew.Hide();
            frmNew.ShowDialog(); 
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
           //MessageBox.Show( e.TabPage.Text);
            LoadDataOnListView();
        }


        private void lswTimeManager_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            strNameScheduled = lswTimeManager.Items[e.Index].Text;
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            LoadDataOnListView();
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            frmNewTask frmNew = new frmNewTask();
            frmNew.Hide();
            frmNew.ShowDialog();
        }

        private void toolStripButton3_Click_1(object sender, EventArgs e)
        {
            if (strNameScheduled != null)
            {
                frmNewTask newTask = new frmNewTask();
                newTask.ShowDialog();
                LoadDataOnListView();
            }
            else
            {
                MessageBox.Show("Bạn Chưa Chọn Công Việc Cần Sửa", "Time Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripButton4_Click_1(object sender, EventArgs e)
        {
            if (strNameScheduled != null)
            {
                ScheduledTasks st = new ScheduledTasks(global.getNameComputer());
                st.DeleteTask(strNameScheduled);
                LoadDataOnListView();
            }
            else
            {
                MessageBox.Show("Bạn Chưa Chọn Công Việc Cần Xoá", "Time Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Chắc Chắn Muốn Xoá Toàn Bộ Công Việc", "Time Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ScheduledTasks st = new ScheduledTasks(global.getNameComputer());
                string[] taskNames = st.GetTaskNames();
                foreach (string name in taskNames)
                {
                    st.DeleteTask(name);
                }
                LoadDataOnListView();
            }
        }

        private void ẩnChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tắtMáyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lockComputer.Shutdown();
        }

        private void khởiĐộngLạiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lockComputer.Reboot();
        }

        private void logOffToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lockComputer.LogOff();
        }

        private void standByToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lockComputer.StandBy();
        }

        private void hibernateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lockComputer.Hibernate();
        }

        private void khoáMáyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lockComputer.Lock();
        }

        private void hiểnThịChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void vềTácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAboutAuthor at = new frmAboutAuthor();
            at.ShowDialog();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }
        
        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process p = new Process();
                p.StartInfo.FileName = Application.StartupPath + "\\Help.chm";
                p.Start();
            }
            catch
            {
                MessageBox.Show("Mở file Help.chm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("iexplore.exe", @"http://cuasotinhoc.vn/index.php?");
        }
        #endregion

        #region Function

        //Chỉnh Format Date
        [DllImport("kernel32.dll")]
        private static extern uint GetUserDefaultLCID();
        [DllImport("kernel32.dll")]
        static extern bool SetLocaleInfo(uint Locale, uint LCType,
        string lpLCData);
        public const int LOCALE_SSHORTDATE = 0x1F;
        public const int LOCALE_SDATE = 0x1D;

        public static void SetShortDate(string strShortDate)
        {
            uint lngLCID;
            lngLCID = GetUserDefaultLCID();
            SetLocaleInfo(lngLCID, LOCALE_SSHORTDATE, strShortDate);
            SetLocaleInfo(lngLCID, LOCALE_SDATE, "/");
        }

        public void LoadDataOnListView()
        {
            lswTimeManager.Items.Clear();
            ScheduledTasks st = new ScheduledTasks(global.getNameComputer());
            string[] taskNames = st.GetTaskNames();
            Task t;
            int i = 0;
            foreach (string name in taskNames)
            {
                t = st.OpenTask(name);
                lswTimeManager.Items.Add(name);
                lswTimeManager.Items[i].SubItems.Add(name);
                lswTimeManager.Items[i].SubItems.Add(t.NextRunTime.ToString());
                i++;
                //Lần Chạy Kế Tiếp
                //MessageBox.Show(global.getMonth(t.NextRunTime.ToShortDateString()));
                //  MessageBox.Show(t.Status.ToString());
            }
        }
        #endregion
    }
}