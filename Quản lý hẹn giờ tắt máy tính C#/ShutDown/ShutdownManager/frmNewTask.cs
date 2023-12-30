using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TaskScheduler;
//using System.Runtime.InteropServices;

namespace ShutdownManager
{
    public partial class frmNewTask : Form
    {
        public frmNewTask()
        {
            InitializeComponent();
        }

        Modules.Global global = new ShutdownManager.Modules.Global();

        private ScheduledTasks st;
        private Task t;

        #region Khai Báo Biến Control
            
        //Daily
        GroupBox gbDaily;
        Label lblDaily;
        DateTimePicker dtpDaily;

        //Weekly
        GroupBox gbWeekly;
        DateTimePicker dtpWeekly;
        Label lblWeekly;
        CheckBox cbMondayWeekly;
        CheckBox cbTuesdayWeekly;
        CheckBox cbWednesdayWeekly;
        CheckBox cbThursdayWeekly;
        CheckBox cbFridayWeekly;
        CheckBox cbSaturdayWeekly;
        CheckBox cbSundayWeekly;

        //Monthly
        GroupBox gbMonthly;
        CheckBox cbNgayThuMonthly;
        CheckBox cbCuaThangMonthly;
        Label lblCuaThangMonthly;
        Label lblThuMonthly;
        Label lblCuaThang2Monthly;
        ComboBox cbDayInWeekMonthly;
        ComboBox cbThuTuMonthly;
        DateTimePicker dtpMonthly;
        Button btnChonThangMonthly;

        //Once
        GroupBox gbOnce;
        Label lblOnce;
        DateTimePicker dtpOnce;

        //Khi Không Làm Việc(Idle)
        //GroupBox gbIdle;
        //Label lblKhiKhongIdle;
        //Label lblMinutes;
        //TextBox txtIdle;
        #endregion

        #region Sinh Ra Các Control
        //Hàng Ngày (Daily)
        private void Daily()
        { 
            //Group box
            gbDaily = new GroupBox();
            gbDaily.Name = "gbDaily";
            gbDaily.Text = "Hàng Ngày";
            Point gbDailyLocation = new Point(12, 174);
            gbDaily.Location = Point.Add(gbDailyLocation, new Size(0, 0));
            Point gbDailySize = new Point(328, 76);
            gbDaily.Size = new Size(gbDailySize);
            this.Controls.Add(gbDaily);

            //DateTimePicker
            dtpDaily = new DateTimePicker();
            dtpDaily.Format = DateTimePickerFormat.Custom;
            dtpDaily.CustomFormat = "ss";
            dtpDaily.Text = "11:01:01 PM";
            dtpDaily.ShowUpDown = true;
            Point dtpDailyLocation = new Point(22, 28);
            dtpDaily.Location = Point.Add(dtpDailyLocation, new Size(0, 0));
            Point dtpDailySize = new Point(45, 20);
            dtpDaily.Size = new Size(dtpDailySize);
            this.dtpDaily.ValueChanged += new System.EventHandler(this.dtpDaily_ValueChanged);
            gbDaily.Controls.Add(dtpDaily);


            //lblDaily
            lblDaily = new Label();
            lblDaily.Text = "Ngày/Lần";
            lblDaily.AutoSize = true;
            Point lblDailyLocation = new Point(70, 31);
            lblDaily.Location = Point.Add(lblDailyLocation, new Size(0, 0));
            Point lblDailySize = new Point(54, 13);
            lblDaily.Size = new Size(lblDailySize);
            gbDaily.Controls.Add(lblDaily);
        }

        //Hàng Tuần (Weekly)
        private void Weekly()
        {
            //Group box
            gbWeekly = new GroupBox();
            gbWeekly.Name = "gbDaily";
            gbWeekly.Text = "Hàng Tuần";
            Point gbWeeklyLocation = new Point(12, 174);
            gbWeekly.Location = Point.Add(gbWeeklyLocation, new Size(0, 0));
            Point gbWeeklySize = new Point(328, 146);
            gbWeekly.Size = new Size(gbWeeklySize);
            this.Controls.Add(gbWeekly);

            //DateTimePicker
            dtpWeekly = new DateTimePicker();
            dtpWeekly.Format = DateTimePickerFormat.Custom;
            dtpWeekly.CustomFormat = "ss";
            dtpWeekly.Text = "11:01:01 PM";
            dtpWeekly.ShowUpDown = true;
            Point dtpWeeklyLocation = new Point(22, 28);
            dtpWeekly.Location = Point.Add(dtpWeeklyLocation, new Size(0, 0));
            Point dtpWeeklySize = new Point(45, 20);
            dtpWeekly.Size = new Size(dtpWeeklySize);
            gbWeekly.Controls.Add(dtpWeekly);

            //Label
            lblWeekly = new Label();
            lblWeekly.Text = "Tuần/Lần Vào";
            lblWeekly.AutoSize = true;
            Point lblWeeklyLocation = new Point(73, 32);
            lblWeekly.Location = Point.Add(lblWeeklyLocation, new Size(0, 0));
            Point lblWeeklySize = new Point(55, 13);
            lblWeekly.Size = new Size(lblWeeklySize);
            gbWeekly.Controls.Add(lblWeekly);

            //cbMondayWeekly;
            cbMondayWeekly = new CheckBox();
            cbMondayWeekly.AutoSize = true;
            cbMondayWeekly.Text = "Thứ Hai";
            Point cbMondayWeeklyLocation = new Point(152, 31);
            cbMondayWeekly.Location = Point.Add(cbMondayWeeklyLocation, new Size(0, 0));
            Point cbMondayWeeklySize = new Point(64, 17);
            cbMondayWeekly.Size = new Size(cbMondayWeeklySize);
            gbWeekly.Controls.Add(cbMondayWeekly);

            //cbTuesdayWeekly;
            cbTuesdayWeekly = new CheckBox();
            cbTuesdayWeekly.AutoSize = true;
            cbTuesdayWeekly.Text = "Thứ Ba";
            Point cbTuesdayWeeklyLocation = new Point(152, 54);
            cbTuesdayWeekly.Location = Point.Add(cbTuesdayWeeklyLocation, new Size(0, 0));
            Point cbTuesdayWeeklySize = new Point(64, 17);
            cbTuesdayWeekly.Size = new Size(cbTuesdayWeeklySize);
            gbWeekly.Controls.Add(cbTuesdayWeekly);

            //cbWednesdayWeekly
            cbWednesdayWeekly = new CheckBox();
            cbWednesdayWeekly.AutoSize = true;
            cbWednesdayWeekly.Text = "Thứ Tư";
            Point cbWednesdayWeeklyLocation = new Point(152, 77);
            cbWednesdayWeekly.Location = Point.Add(cbWednesdayWeeklyLocation, new Size(0, 0));
            Point cbWednesdayWeeklySize = new Point(64, 17);
            cbWednesdayWeekly.Size = new Size(cbWednesdayWeeklySize);
            gbWeekly.Controls.Add(cbWednesdayWeekly);

            //cbThursdayWeekly;
            cbThursdayWeekly = new CheckBox();
            cbThursdayWeekly.AutoSize = true;
            cbThursdayWeekly.Text = "Thứ Năm";
            Point cbThursdayWeeklyLocation = new Point(152, 100);
            cbThursdayWeekly.Location = Point.Add(cbThursdayWeeklyLocation, new Size(0, 0));
            Point cbThursdayWeeklySize = new Point(64, 17);
            cbThursdayWeekly.Size = new Size(cbThursdayWeeklySize);
            gbWeekly.Controls.Add(cbThursdayWeekly);

            //cbFridayWeekly;
            cbFridayWeekly = new CheckBox();
            cbFridayWeekly.AutoSize = true;
            cbFridayWeekly.Text = "Thứ Sáu";
            Point cbFridayWeeklyLocation = new Point(240, 31);
            cbFridayWeekly.Location = Point.Add(cbFridayWeeklyLocation, new Size(0, 0));
            Point cbFridayWeeklySize = new Point(64, 17);
            cbFridayWeekly.Size = new Size(cbFridayWeeklySize);
            gbWeekly.Controls.Add(cbFridayWeekly);

            //cbSaturdayWeekly
            cbSaturdayWeekly = new CheckBox();
            cbSaturdayWeekly.AutoSize = true;
            cbSaturdayWeekly.Text = "Thứ Bảy";
            Point cbSaturdayWeeklyLocation = new Point(240, 54);
            cbSaturdayWeekly.Location = Point.Add(cbSaturdayWeeklyLocation, new Size(0, 0));
            Point cbSaturdayWeeklySize = new Point(64, 17);
            cbSaturdayWeekly.Size = new Size(cbSaturdayWeeklySize);
            gbWeekly.Controls.Add(cbSaturdayWeekly);

            //cbSundayWeekly;
            cbSundayWeekly = new CheckBox();
            cbSundayWeekly.AutoSize = true;
            cbSundayWeekly.Text = "Chủ Nhật";
            Point cbSundayWeeklyLocation = new Point(240, 77);
            cbSundayWeekly.Location = Point.Add(cbSundayWeeklyLocation, new Size(0, 0));
            Point cbSundayWeeklySize = new Point(64, 17);
            cbSundayWeekly.Size = new Size(cbSundayWeeklySize);
            gbWeekly.Controls.Add(cbSundayWeekly);
        }

        //Hàng Tháng (Monthly)
        private void Monthly()
        {
            //Group box
            gbMonthly = new GroupBox();
            gbMonthly.Name = "gbMonthly";
            gbMonthly.Text = "Hàng Tháng";
            Point gbMonthlyLocation = new Point(12, 174);
            gbMonthly.Location = Point.Add(gbMonthlyLocation, new Size(0, 0));
            Point gbMonthlySize = new Point(328, 138);
            gbMonthly.Size = new Size(gbMonthlySize);
            this.Controls.Add(gbMonthly);

            //cbNgayThuMonthly
            cbNgayThuMonthly = new CheckBox();
            cbNgayThuMonthly.Text = "Ngày Thứ";
            cbNgayThuMonthly.AutoSize = true;
            cbNgayThuMonthly.Checked = true;
            Point cbNgayThuMonthlyLocation = new Point(27, 26);
            cbNgayThuMonthly.Location = Point.Add(cbNgayThuMonthlyLocation, new Size(0, 0));
            Point cbNgayThuMonthlySize = new Point(72, 17);
            cbNgayThuMonthly.Size = new Size(cbNgayThuMonthlySize);
            this.cbNgayThuMonthly.Click += new System.EventHandler(this.cbNgayThuMonthly_Click);
            gbMonthly.Controls.Add(cbNgayThuMonthly);

            //dtpMonthly
            dtpMonthly = new DateTimePicker();
            dtpMonthly = new DateTimePicker();
            dtpMonthly.Format = DateTimePickerFormat.Custom;
            dtpMonthly.CustomFormat = "ss";
            dtpMonthly.Text = "11:01:01 PM";
            dtpMonthly.ShowUpDown = true;
            Point dtpMonthlyLocation = new Point(105, 24);
            dtpMonthly.Location = Point.Add(dtpMonthlyLocation, new Size(0, 0));
            Point dtpMonthlySize = new Point(45, 20);
            dtpMonthly.Size = new Size(dtpMonthlySize);
            gbMonthly.Controls.Add(dtpMonthly);

            //lblCuaThangMonthly
            lblCuaThangMonthly = new Label();
            lblCuaThangMonthly = new Label();
            lblCuaThangMonthly.Text = "Của Tháng";
            lblCuaThangMonthly.AutoSize = true;
            Point lblCuaThangMonthlyLocation = new Point(156, 28);
            lblCuaThangMonthly.Location = Point.Add(lblCuaThangMonthlyLocation, new Size(0, 0));
            Point lblCuaThangMonthlySize = new Point(60, 13);
            lblCuaThangMonthly.Size = new Size(lblCuaThangMonthlySize);
            gbMonthly.Controls.Add(lblCuaThangMonthly);

            //cbCuaThangMonthly
            cbCuaThangMonthly = new CheckBox();
            cbCuaThangMonthly.Text = "Ngày";
            cbCuaThangMonthly.AutoSize = true;
            cbCuaThangMonthly.Checked = false;
            Point cbCuaThangMonthlyLocation = new Point(27, 63);
            cbCuaThangMonthly.Location = Point.Add(cbCuaThangMonthlyLocation, new Size(0, 0));
            Point cbCuaThangMonthlySize = new Point(50, 17);
            cbCuaThangMonthly.Size = new Size(cbCuaThangMonthlySize);
            this.cbCuaThangMonthly.Click += new System.EventHandler(this.cbCuaThangMonthly_Click);
            gbMonthly.Controls.Add(cbCuaThangMonthly);

            //cbDayInWeekMonthly
            cbDayInWeekMonthly = new ComboBox();
            cbDayInWeekMonthly.Items.Add("Thứ Hai");
            cbDayInWeekMonthly.Items.Add("Thứ Ba");
            cbDayInWeekMonthly.Items.Add("Thứ Tư");
            cbDayInWeekMonthly.Items.Add("Thứ Năm");
            cbDayInWeekMonthly.Items.Add("Thứ Sáu");
            cbDayInWeekMonthly.Items.Add("Thứ Bảy");
            cbDayInWeekMonthly.Items.Add("Chủ Nhật");
            cbDayInWeekMonthly.Enabled = false;
            Point cbDayInWeekMonthlyLocation = new Point(105, 62);
            cbDayInWeekMonthly.Location = Point.Add(cbDayInWeekMonthlyLocation, new Size(0, 0));
            Point cbDayInWeekMonthlySize = new Point(78, 21);
            cbDayInWeekMonthly.Size = new Size(cbDayInWeekMonthlySize);
            gbMonthly.Controls.Add(cbDayInWeekMonthly);

            //lblThuMonthly
            lblThuMonthly = new Label();
            lblThuMonthly.Text = "Thứ";
            lblThuMonthly.AutoSize = true;
            Point lblThuMonthlyLocation = new Point(189, 65);
            lblThuMonthly.Location = Point.Add(lblThuMonthlyLocation, new Size(0, 0));
            Point lblThuMonthlySize = new Point(26, 13);
            lblThuMonthly.Size = new Size(lblThuMonthlySize);
            gbMonthly.Controls.Add(lblThuMonthly);

            //cbThuTuMonthly
            cbThuTuMonthly = new ComboBox();
            cbThuTuMonthly.Items.Add("1");
            cbThuTuMonthly.Items.Add("2");
            cbThuTuMonthly.Items.Add("3");
            cbThuTuMonthly.Items.Add("4");
            cbThuTuMonthly.Items.Add("5");
            cbThuTuMonthly.Enabled = false;
            Point cbThuTuMonthlyLocation = new Point(221, 62);
            cbThuTuMonthly.Location = Point.Add(cbThuTuMonthlyLocation, new Size(0, 0));
            Point cbThuTuMonthlySize = new Point(39, 21);
            cbThuTuMonthly.Size = new Size(cbThuTuMonthlySize);
            gbMonthly.Controls.Add(cbThuTuMonthly);

            //lblCuaThang2Monthly
            lblCuaThang2Monthly = new Label();
            lblCuaThang2Monthly.Text = "Của Tháng";
            lblCuaThang2Monthly.AutoSize = true;
            Point lblCuaThang2MonthlyLocation = new Point(259, 65);
            lblCuaThang2Monthly.Location = Point.Add(lblCuaThang2MonthlyLocation, new Size(0, 0));
            Point lblCuaThang2MonthlySize = new Point(60, 13);
            lblCuaThang2Monthly.Size = new Size(lblCuaThang2MonthlySize);
            gbMonthly.Controls.Add(lblCuaThang2Monthly);

            //btnChonThangMonthly
            btnChonThangMonthly = new Button();
            btnChonThangMonthly.Text = "Chọn Tháng";
            Point btnChonThangMonthlyLocation = new Point(27, 105);
            btnChonThangMonthly.Location = Point.Add(btnChonThangMonthlyLocation, new Size(0, 0));
            Point btnChonThangMonthlySize = new Point(75, 23);
            btnChonThangMonthly.Size = new Size(btnChonThangMonthlySize);
            this.btnChonThangMonthly.Click += new System.EventHandler(this.btnChonThangMonthly_Click);
            gbMonthly.Controls.Add(btnChonThangMonthly);
        }

        //Một Lần(Once)
        private void Once()
        {
            //Group box
            gbOnce = new GroupBox();
            gbOnce.Name = "gbOnce";
            gbOnce.Text = "Hàng Ngày";
            Point gbOnceLocation = new Point(12, 174);
            gbOnce.Location = Point.Add(gbOnceLocation, new Size(0, 0));
            Point gbOnceSize = new Point(328, 75);
            gbOnce.Size = new Size(gbOnceSize);
            this.Controls.Add(gbOnce);

            //lblOnce
            lblOnce = new Label();
            lblOnce.Text = "Vào Ngày";
            lblOnce.AutoSize = true;
            Point lblOnceLocation = new Point(6, 31);
            lblOnce.Location = Point.Add(lblOnceLocation, new Size(0, 0));
            Point lblOnceSize = new Point(54, 13);
            lblOnce.Size = new Size(lblOnceSize);
            gbOnce.Controls.Add(lblOnce);

            //dtpOnce
            dtpOnce = new DateTimePicker();
            dtpOnce.Format = DateTimePickerFormat.Custom;
            dtpOnce.CustomFormat = "dd/MM/yyyy";
            dtpOnce.ShowUpDown = true;
            Point dtpOnceLocation = new Point(66, 27);
            dtpOnce.Location = Point.Add(dtpOnceLocation, new Size(0, 0));
            Point dtpOnceSize = new Point(89, 20);
            dtpOnce.Size = new Size(dtpOnceSize);
            gbOnce.Controls.Add(dtpOnce);
        }

        //Khi Không Làm Việc (Idle)
        //private void Idle()
        //{
        //    //gbIdle
        //    gbIdle = new GroupBox();
        //    gbIdle.Name = "gbIdle";
        //    gbIdle.Text = "Hàng Ngày";
        //    Point gbIdleLocation = new Point(12, 174);
        //    gbIdle.Location = Point.Add(gbIdleLocation, new Size(0, 0));
        //    Point gbIdleSize = new Point(328, 75);
        //    gbIdle.Size = new Size(gbIdleSize);
        //    this.Controls.Add(gbIdle);

        //    //lblKhiKhongIdle
        //    lblKhiKhongIdle = new Label();
        //    lblKhiKhongIdle.Text = "Khi Máy Không Làm Việc Trong ";
        //    lblKhiKhongIdle.AutoSize = true;
        //    Point lblKhiKhongIdleLocation = new Point(6, 31);
        //    lblKhiKhongIdle.Location = Point.Add(lblKhiKhongIdleLocation, new Size(0, 0));
        //    Point lblKhiKhongIdleSize = new Point(160, 13);
        //    lblKhiKhongIdle.Size = new Size(lblKhiKhongIdleSize);
        //    gbIdle.Controls.Add(lblKhiKhongIdle);

        //    //txtIdle
        //    txtIdle = new TextBox();
        //    Point txtIdleLocation = new Point(169, 28);
        //    txtIdle.Location = Point.Add(txtIdleLocation, new Size(0, 0));
        //    Point txtIdleSize = new Point(100, 20);
        //    txtIdle.Size = new Size(txtIdleSize);
        //    gbIdle.Controls.Add(txtIdle);

        //    //lblMinutes
        //    lblMinutes = new Label();
        //    lblMinutes.Text = "Phút";
        //    lblMinutes.AutoSize = true;
        //    Point lblMinutesLocation = new Point(275, 31);
        //    lblMinutes.Location = Point.Add(lblMinutesLocation, new Size(0, 0));
        //    Point lblMinutesSize = new Point(29, 13);
        //    lblMinutes.Size = new Size(lblMinutesSize);
        //    gbIdle.Controls.Add(lblMinutes);
        //}

        #region Event Của Các Control Tự Sinh

        //Hàm Mở Từng Group
        private void DeleteGroupbox()
        {
            this.Controls.Remove(gbDaily);
            this.Controls.Remove(gbWeekly);
            this.Controls.Remove(gbMonthly);
            this.Controls.Remove(gbOnce);
            //this.Controls.Remove(gbIdle);
        }

        //dtpDaily_ValueChanged
        private void dtpDaily_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDaily.Text.Trim() == "00")
            {
                dtpDaily.Text = "12:11:59";
            }
        }

        //btnChonThangMonthly_Click
        private void btnChonThangMonthly_Click(object sender, EventArgs e)
        {
            frmSelectMonth selectMonth = new frmSelectMonth();
            selectMonth.ShowDialog();
        }

        //cbNgayThuMonthly_CheckedChanged
        private void cbNgayThuMonthly_Click(object sender, EventArgs e)
        {
            cbNgayThuMonthly.Checked = true;
            dtpMonthly.Enabled = true;

            cbCuaThangMonthly.Checked = false;
            cbDayInWeekMonthly.Enabled = false;
            cbThuTuMonthly.Enabled = false;
        }

        //cbCuaThangMonthly
        private void cbCuaThangMonthly_Click(object sender, EventArgs e)
        {
            cbNgayThuMonthly.Checked = false;
            dtpMonthly.Enabled = false;

            cbCuaThangMonthly.Checked = true;
            cbDayInWeekMonthly.Enabled = true;
            cbThuTuMonthly.Enabled = true;
        }

        #endregion
        #endregion

        #region Scheduled Task

        private string getNameScheduled()
        {
            return txtNameScheduled.Text.Trim();
        }

        private string getNameApplication()
        {
            return txtNameApplication.Text.Trim();
        }

        private string getLichTrinh()
        {
            return cbLichTrinh.Text.Trim();
        }

        private string getTimeStart()
        {
            return dtpTimeStart.Text.Trim();
        }

        #endregion

        #region Event

        //Chọn Chương Trình
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    frmSetAccount setAccount = new frmSetAccount();
                    setAccount.ShowDialog();
                    if (frmSetAccount.boolTestAction)
                    {
                        txtNameApplication.Text = openFileDialog1.FileName.ToString().Trim();
                    }
                    else
                    {
                        txtNameApplication.Text = "";
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Chọn Kiểu Lịch Trình
        private void cbLichTrinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLichTrinh.Text == "Hằng Ngày")
            {
                DeleteGroupbox();
                Daily();
                dtpTimeStart.Enabled = true;
            }
            if (cbLichTrinh.Text == "Hằng Tuần")
            {
                DeleteGroupbox();
                Weekly();
                dtpTimeStart.Enabled = true;
            }
            if (cbLichTrinh.Text == "Hằng Tháng")
            {
                DeleteGroupbox();
                Monthly();
                dtpTimeStart.Enabled = true;
                cbDayInWeekMonthly.SelectedIndex = 0;
                cbThuTuMonthly.SelectedIndex = 0;
            }
            if (cbLichTrinh.Text == "Một Lần")
            {
                DeleteGroupbox();
                Once();
                dtpTimeStart.Enabled = true;
            }
            if (cbLichTrinh.Text == "Lúc Bằt Đầu Hệ Thống")
            {
                DeleteGroupbox();
                dtpTimeStart.Enabled = false;
            }
            if (cbLichTrinh.Text == "Lúc Log On")
            {
                DeleteGroupbox();
                dtpTimeStart.Enabled = false;
            }
            if (cbLichTrinh.Text == "Khi Không Làm Việc")
            {
                DeleteGroupbox();
                dtpTimeStart.Enabled = false;
                //Idle();
            }
        }

        //Form Đóng (Trả Lại Mặc Định Cho Form Select Month)
        private void frmNewTask_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmSelectMonth.boolCheck1 = true;
            frmSelectMonth.boolCheck2 = true;
            frmSelectMonth.boolCheck3 = true;
            frmSelectMonth.boolCheck4 = true;
            frmSelectMonth.boolCheck5 = true;
            frmSelectMonth.boolCheck6 = true;
            frmSelectMonth.boolCheck7 = true;
            frmSelectMonth.boolCheck8 = true;
            frmSelectMonth.boolCheck9 = true;
            frmSelectMonth.boolCheck10 = true;
            frmSelectMonth.boolCheck11 = true;
            frmSelectMonth.boolCheck12 = true;
        }

        //Đồng Ý
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if ((getNameScheduled() != "") && (getTimeStart() != ""))
                {
                    if (MessageBox.Show("Bạn Có Chắc Chắn Muốn Thêm Một Lịch Trình Mới Không", "Time Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string strTimeStart = getTimeStart();
                        st = new ScheduledTasks(global.getNameComputer());
                        try
                        {
                            st.DeleteTask(frmTimeManager.strNameScheduled);
                        }
                        catch { }
                        t = st.CreateTask(getNameScheduled());
                        if (txtNameApplication.Text != "")
                        {
                            t.ApplicationName = getNameApplication();
                            t.SetAccountInformation(frmSetAccount.strUserName, frmSetAccount.strPassWord);
                        }                    
                        t.Flags = TaskFlags.SystemRequired;
                        short shortHourStart = Convert.ToInt16(global.getHour(getTimeStart()));

                        #region Hàng Ngày
                        //Hàng Ngày
                        if (cbLichTrinh.Text == "Hằng Ngày")
                        {  
                            if (global.getPeriod(strTimeStart) == "PM")
                            {
                                shortHourStart = Convert.ToInt16(shortHourStart + 12);
                            }
                            t.Triggers.Add(new DailyTrigger(shortHourStart, Convert.ToInt16(global.getMinute(getTimeStart())), Convert.ToInt16(dtpDaily.Text)));
                            t.Save();
                            st.Dispose();
                            t.Dispose();
                        }
                        #endregion

                        #region Hàng Tuần
                        //Hàng Tuần
                        if (cbLichTrinh.Text == "Hằng Tuần")
                        {
                            if (cbMondayWeekly.Checked)
                            {
                                t.Triggers.Add(new WeeklyTrigger(shortHourStart, Convert.ToInt16(global.getMinute(getTimeStart())), DaysOfTheWeek.Monday));
                            }
                            if (cbTuesdayWeekly.Checked)
                            {
                                t.Triggers.Add(new WeeklyTrigger(shortHourStart, Convert.ToInt16(global.getMinute(getTimeStart())), DaysOfTheWeek.Tuesday));
                            }
                            if (cbWednesdayWeekly.Checked)
                            {
                                t.Triggers.Add(new WeeklyTrigger(shortHourStart, Convert.ToInt16(global.getMinute(getTimeStart())), DaysOfTheWeek.Wednesday));
                            }
                            if (cbThursdayWeekly.Checked)
                            {
                                t.Triggers.Add(new WeeklyTrigger(shortHourStart, Convert.ToInt16(global.getMinute(getTimeStart())), DaysOfTheWeek.Thursday));
                            }
                            if (cbFridayWeekly.Checked)
                            {
                                t.Triggers.Add(new WeeklyTrigger(shortHourStart, Convert.ToInt16(global.getMinute(getTimeStart())), DaysOfTheWeek.Friday));
                            }
                            if (cbSaturdayWeekly.Checked)
                            {
                                t.Triggers.Add(new WeeklyTrigger(shortHourStart, Convert.ToInt16(global.getMinute(getTimeStart())), DaysOfTheWeek.Saturday));
                            }
                            if (cbSundayWeekly.Checked)
                            {
                                t.Triggers.Add(new WeeklyTrigger(shortHourStart, Convert.ToInt16(global.getMinute(getTimeStart())), DaysOfTheWeek.Sunday));
                            }
                            if (!(cbMondayWeekly.Checked) && !(cbTuesdayWeekly.Checked) && !(cbWednesdayWeekly.Checked) &&
                                !(cbThursdayWeekly.Checked) && !(cbFridayWeekly.Checked) && !(cbSaturdayWeekly.Checked) && !(cbSundayWeekly.Checked))
                            {
                                MessageBox.Show("Bạn Chưa Chọn Bất Kỳ Ngày Nào Trong Tuần", "Time Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                t.Save();
                            }
                        }
                        #endregion

                        #region Hàng Tháng

                        if (cbLichTrinh.Text == "Hằng Tháng")
                        {
                            if (cbNgayThuMonthly.Checked)
                            {
                                int[] intArray ={ Convert.ToInt32(dtpMonthly.Text.Trim()) };
                                if (frmSelectMonth.boolCheck1)
                                {
                                    t.Triggers.Add(new MonthlyTrigger(shortHourStart, Convert.ToInt16(global.getMinute(getTimeStart())), intArray, MonthsOfTheYear.January));
                                }
                                if (frmSelectMonth.boolCheck2)
                                {
                                    t.Triggers.Add(new MonthlyTrigger(shortHourStart, Convert.ToInt16(global.getMinute(getTimeStart())), intArray, MonthsOfTheYear.February));
                                }
                                if (frmSelectMonth.boolCheck3)
                                {
                                    t.Triggers.Add(new MonthlyTrigger(shortHourStart, Convert.ToInt16(global.getMinute(getTimeStart())), intArray, MonthsOfTheYear.March));
                                }
                                if (frmSelectMonth.boolCheck4)
                                {
                                    t.Triggers.Add(new MonthlyTrigger(shortHourStart, Convert.ToInt16(global.getMinute(getTimeStart())), intArray, MonthsOfTheYear.April));
                                }
                                if (frmSelectMonth.boolCheck5)
                                {
                                    t.Triggers.Add(new MonthlyTrigger(shortHourStart, Convert.ToInt16(global.getMinute(getTimeStart())), intArray, MonthsOfTheYear.May));
                                }
                                if (frmSelectMonth.boolCheck6)
                                {
                                    t.Triggers.Add(new MonthlyTrigger(shortHourStart, Convert.ToInt16(global.getMinute(getTimeStart())), intArray, MonthsOfTheYear.June));
                                }
                                if (frmSelectMonth.boolCheck7)
                                {
                                    t.Triggers.Add(new MonthlyTrigger(shortHourStart, Convert.ToInt16(global.getMinute(getTimeStart())), intArray, MonthsOfTheYear.July));
                                }
                                if (frmSelectMonth.boolCheck8)
                                {
                                    t.Triggers.Add(new MonthlyTrigger(shortHourStart, Convert.ToInt16(global.getMinute(getTimeStart())), intArray, MonthsOfTheYear.August));
                                }
                                if (frmSelectMonth.boolCheck9)
                                {
                                    t.Triggers.Add(new MonthlyTrigger(shortHourStart, Convert.ToInt16(global.getMinute(getTimeStart())), intArray, MonthsOfTheYear.September));
                                }
                                if (frmSelectMonth.boolCheck10)
                                {
                                    t.Triggers.Add(new MonthlyTrigger(shortHourStart, Convert.ToInt16(global.getMinute(getTimeStart())), intArray, MonthsOfTheYear.October));
                                }
                                if (frmSelectMonth.boolCheck11)
                                {
                                    t.Triggers.Add(new MonthlyTrigger(shortHourStart, Convert.ToInt16(global.getMinute(getTimeStart())), intArray, MonthsOfTheYear.November));
                                }
                                if (frmSelectMonth.boolCheck12)
                                {
                                    t.Triggers.Add(new MonthlyTrigger(shortHourStart, Convert.ToInt16(global.getMinute(getTimeStart())), intArray, MonthsOfTheYear.December));
                                }
                                t.Save();
                            }
                            if (cbCuaThangMonthly.Checked)
                            {
                                if (frmSelectMonth.boolCheck1)
                                {
                                    t.Triggers.Add(new TaskScheduler.MonthlyDOWTrigger(shortHourStart, Convert.ToInt16(global.getMinute(getTimeStart())), getDaysOfTheWeek_Monthly(), getWhichWeek_Monthly(), MonthsOfTheYear.January));
                                }
                                if (frmSelectMonth.boolCheck2)
                                {
                                    t.Triggers.Add(new TaskScheduler.MonthlyDOWTrigger(shortHourStart, Convert.ToInt16(global.getMinute(getTimeStart())), getDaysOfTheWeek_Monthly(), getWhichWeek_Monthly(), MonthsOfTheYear.February));
                                }
                                if (frmSelectMonth.boolCheck3)
                                {
                                    t.Triggers.Add(new TaskScheduler.MonthlyDOWTrigger(shortHourStart, Convert.ToInt16(global.getMinute(getTimeStart())), getDaysOfTheWeek_Monthly(), getWhichWeek_Monthly(), MonthsOfTheYear.March));
                                }
                                if (frmSelectMonth.boolCheck4)
                                {
                                    t.Triggers.Add(new TaskScheduler.MonthlyDOWTrigger(shortHourStart, Convert.ToInt16(global.getMinute(getTimeStart())), getDaysOfTheWeek_Monthly(), getWhichWeek_Monthly(), MonthsOfTheYear.April));
                                }
                                if (frmSelectMonth.boolCheck5)
                                {
                                    t.Triggers.Add(new TaskScheduler.MonthlyDOWTrigger(shortHourStart, Convert.ToInt16(global.getMinute(getTimeStart())), getDaysOfTheWeek_Monthly(), getWhichWeek_Monthly(), MonthsOfTheYear.May));
                                }
                                if (frmSelectMonth.boolCheck6)
                                {
                                    t.Triggers.Add(new TaskScheduler.MonthlyDOWTrigger(shortHourStart, Convert.ToInt16(global.getMinute(getTimeStart())), getDaysOfTheWeek_Monthly(), getWhichWeek_Monthly(), MonthsOfTheYear.June));
                                }
                                if (frmSelectMonth.boolCheck7)
                                {
                                    t.Triggers.Add(new TaskScheduler.MonthlyDOWTrigger(shortHourStart, Convert.ToInt16(global.getMinute(getTimeStart())), getDaysOfTheWeek_Monthly(), getWhichWeek_Monthly(), MonthsOfTheYear.November));
                                }
                                if (frmSelectMonth.boolCheck8)
                                {
                                    t.Triggers.Add(new TaskScheduler.MonthlyDOWTrigger(shortHourStart, Convert.ToInt16(global.getMinute(getTimeStart())), getDaysOfTheWeek_Monthly(), getWhichWeek_Monthly(), MonthsOfTheYear.December));
                                }
                                if (frmSelectMonth.boolCheck9)
                                {
                                    t.Triggers.Add(new TaskScheduler.MonthlyDOWTrigger(shortHourStart, Convert.ToInt16(global.getMinute(getTimeStart())), getDaysOfTheWeek_Monthly(), getWhichWeek_Monthly(), MonthsOfTheYear.September));
                                }
                                if (frmSelectMonth.boolCheck10)
                                {
                                    t.Triggers.Add(new TaskScheduler.MonthlyDOWTrigger(shortHourStart, Convert.ToInt16(global.getMinute(getTimeStart())), getDaysOfTheWeek_Monthly(), getWhichWeek_Monthly(), MonthsOfTheYear.October));
                                }
                                if (frmSelectMonth.boolCheck11)
                                {
                                    t.Triggers.Add(new TaskScheduler.MonthlyDOWTrigger(shortHourStart, Convert.ToInt16(global.getMinute(getTimeStart())), getDaysOfTheWeek_Monthly(), getWhichWeek_Monthly(), MonthsOfTheYear.May));
                                }
                                if (frmSelectMonth.boolCheck12)
                                {
                                    t.Triggers.Add(new TaskScheduler.MonthlyDOWTrigger(shortHourStart, Convert.ToInt16(global.getMinute(getTimeStart())), getDaysOfTheWeek_Monthly(), getWhichWeek_Monthly(), MonthsOfTheYear.June));
                                }
                                t.Save();
                            }
                        }

                        #endregion

                        #region Một Lần
                        if (cbLichTrinh.Text == "Một Lần")
                        {
                            int intGetDay = Convert.ToInt32(global.getDay(dtpOnce.Text.Trim()));
                            int intGetMonth = Convert.ToInt32(global.getMonth(dtpOnce.Text.Trim()));
                            int intGetYear = Convert.ToInt32(global.getYear(dtpOnce.Text.Trim()));
                            t.Triggers.Add(new TaskScheduler.RunOnceTrigger(new DateTime(intGetYear, intGetMonth, intGetDay, shortHourStart, Convert.ToInt16(global.getMinute(getTimeStart())), 0)));
                            t.Save();
                        }
                        #endregion   
                        #region Lúc Hệ Thống Bắt Đầu + Logon  + Không Làm Việc
                        if (cbLichTrinh.Text == "Lúc Bằt Đầu Hệ Thống")
                        {
                            t.Triggers.Add(new TaskScheduler.OnSystemStartTrigger());
                            t.Save();
                        }

                        if (cbLichTrinh.Text == "Lúc Log On")
                        {
                            t.Triggers.Add(new TaskScheduler.OnLogonTrigger());
                            t.Save();
                        }

                        if (cbLichTrinh.Text == "Khi Không Làm Việc")
                        {
                            t.Triggers.Add(new TaskScheduler.OnIdleTrigger());
                            //SetScreenSaverTimeout(Convert.ToInt32(txtIdle.Text.Trim()) * 60);
                            t.Save();
                        }

                        #endregion
                        //t.Save();
                        this.Close();
                    }                 
                }
                else
                {
                    MessageBox.Show("Bạn Chưa Chọn Tên Công Việc Hoặc Giờ Bắt Đầu", "Time Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Time Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion               

        #region Các Phương Thức
        private DaysOfTheWeek getDaysOfTheWeek_Monthly()
        {
            DaysOfTheWeek dayOfWeek = new DaysOfTheWeek();
            if (cbDayInWeekMonthly.Text == "Thứ Hai")
            {
                dayOfWeek = DaysOfTheWeek.Monday;
            }
            if (cbDayInWeekMonthly.Text == "Thứ Ba")
            {
                dayOfWeek = DaysOfTheWeek.Tuesday;
            }
            if (cbDayInWeekMonthly.Text == "Thứ Tư")
            {
                dayOfWeek = DaysOfTheWeek.Wednesday;
            }
            if (cbDayInWeekMonthly.Text == "Thứ Năm")
            {
                dayOfWeek = DaysOfTheWeek.Thursday;
            }
            if (cbDayInWeekMonthly.Text == "Thứ Sáu")
            {
                dayOfWeek = DaysOfTheWeek.Friday;
            }
            if (cbDayInWeekMonthly.Text == "Thứ Bảy")
            {
                dayOfWeek = DaysOfTheWeek.Saturday;
            }
            if (cbDayInWeekMonthly.Text == "Chủ Nhật")
            {
                dayOfWeek = DaysOfTheWeek.Sunday;
            }
            return dayOfWeek;
        }
        private WhichWeek getWhichWeek_Monthly()
        {
            WhichWeek whichWeek = new WhichWeek();
            if (cbThuTuMonthly.Text == "1")
            {
                whichWeek = WhichWeek.FirstWeek;
            }
            if (cbThuTuMonthly.Text == "2")
            {
                whichWeek = WhichWeek.SecondWeek;
            }
            if (cbThuTuMonthly.Text == "3")
            {
                whichWeek = WhichWeek.ThirdWeek;
            }
            if (cbThuTuMonthly.Text == "4")
            {
                whichWeek = WhichWeek.FourthWeek;
            }
            if (cbThuTuMonthly.Text == "5")
            {
                whichWeek = WhichWeek.LastWeek;
            }
            return whichWeek;
        }

        private void frmNewTask_Load(object sender, EventArgs e)
        {
            cbLichTrinh.SelectedIndex = 0;   
            if (frmTimeManager.strNameScheduled != null)
            {
                txtNameScheduled.Text = frmTimeManager.strNameScheduled;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNewTask_Resize(object sender, EventArgs e)
        {
            this.Size = new Size(384, 427);
        }

        //Chỉnh Time Idle
        //[DllImport("user32.dll", CharSet = CharSet.Auto)]
        //private static extern bool SystemParametersInfo(int uAction, int uParam, ref int lpvParam, int flags);

        //private const int SPI_SETSCREENSAVERTIMEOUT = 15;
        //private const int SPIF_SENDWININICHANGE = 2;

        //public static void SetScreenSaverTimeout(Int32 Value)
        //{
        //    int nullVar = 0;

        //    SystemParametersInfo(SPI_SETSCREENSAVERTIMEOUT, Value, ref nullVar, SPIF_SENDWININICHANGE);
        //}

        #endregion
    }
}