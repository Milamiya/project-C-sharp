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
    public partial class frmTraCuu : Form
    {
        public frmTraCuu()
        {
            InitializeComponent();
        }

        Modules.ConnectionString sqlConn = new LichCongTac.Modules.ConnectionString();
        Modules.StringMessage strMess = new LichCongTac.Modules.StringMessage();
        Modules.Global global = new LichCongTac.Modules.Global();

        private string strSoThuTu;

        private void frmTraCuu_Load(object sender, EventArgs e)
        {
            try
            {
                sqlConn.getConnectionString();
                string strSQL = "select * from LichLamViec where 1=2";
                global.LoadDataGrid(dtgTraCuu, strSQL, sqlConn.sqlCNN);
                FormatGrid(dtgTraCuu);
            }
            catch
            {
                MessageBox.Show(strMess.strChuaKetNoiCSDL,strMess.strTieuDe,MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            txtDangNhap.Text = frmMain.strDangNhap;
            if (frmLogin.intQuyenTruyCap == 0)
            {
                txtDangNhap.Enabled = false; 
            }
            else
            {
                txtDangNhap.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtDangNhap.Text = "";
            dtpNgayBatDau.Text = "";
            dtpNgayKetThuc.Text = "";
            //txtGioBatDau.Text = "";
            comboTrangThai.Text = "";
            rtbNoiDung.Text = "";
            comboHourStart.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                comboHourStart.Items.Add(i.ToString());
            }

            comboMinutesStart.Items.Clear();
            for (int i = 1; i <= 60; i++)
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
            for (int i = 1; i <= 60; i++)
            {
                comboMinutesEnd.Items.Add(i.ToString());
            }

            comboTimeEnd.Items.Clear();
            comboTimeEnd.Items.Add("AM");
            comboTimeEnd.Items.Add("PM");

            comboTrangThai.Items.Clear();
            comboTrangThai.Items.Add("Chưa Thực Hiện");
            comboTrangThai.Items.Add("Đã Thực Hiện");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strTenDangNhap = txtDangNhap.Text.Trim();
            string strNgayBatDau = dtpNgayBatDau.Text.Trim();
            string strNgayKetThuc = dtpNgayKetThuc.Text.Trim();
            string strThoiGianBatDau=null;
            try
            {
                strThoiGianBatDau = comboHourStart.SelectedItem.ToString();
                strThoiGianBatDau += ":" + comboMinutesStart.SelectedItem.ToString();
                strThoiGianBatDau += " " + comboTimeStart.SelectedItem.ToString();
            }
            catch
            {
                strThoiGianBatDau = "";
            }
            string strThoiGianKetThuc = null;
            try
            {
                strThoiGianKetThuc = comboHourEnd.SelectedItem.ToString();
                strThoiGianKetThuc += ":" + comboMinutesEnd.SelectedItem.ToString();
                strThoiGianKetThuc +=" "+ comboTimeEnd.SelectedItem.ToString();
            }
            catch
            {
                strThoiGianKetThuc = "";
            }
            string strTrangThai = null;
            try
            {
                strTrangThai = comboTrangThai.SelectedItem.ToString().Trim();
            }
            catch
            {
                strTrangThai = null;
            }
            string strNoiDung = rtbNoiDung.Text.Trim();
            string strSQL;
            if (frmMain.intQuyenTruyCap == 1)
            {
                strSQL = "select * from LichLamViec where TenDangNhap = N'" + strTenDangNhap + "' ";
                strSQL += "or NgayBatDau=N'" + strNgayBatDau + "'or NgayKetThuc=N'" + strNgayKetThuc + "'";
                strSQL += "or GioBatDau=N'" + strThoiGianBatDau + "' or GioKetThuc=N'" + strThoiGianKetThuc + "'";
                strSQL += " or TrangThaiThucHien = N'" + strTrangThai + "' or NoiDungCongViec=N'" + strNoiDung + "'";
            }
            else
            {
                strSQL = "select LichLamViec.STT,LichLamViec.TenDangNhap,LichLamViec.NgayBatDau,LichLamViec.NgayKetThuc,";
                strSQL += " LichLamViec.GioBatDau,LichLamViec.NoiDungCongViec ,LichLamViec.TrangThaiThucHien , LichLamViec.GioKetThuc from LichLamViec,";
                strSQL += " Account where (LichLamViec.TenDangNhap=Account.TenDangNhap or LichLamViec.TenDangNhap = N'" + strTenDangNhap + "' ";
                strSQL += "or LichLamViec.GioBatDau='" + strThoiGianBatDau + "' or LichLamViec.NoiDungCongViec='" + strNoiDung + "' or LichLamViec.GioKetThuc='" + strThoiGianKetThuc + "'";
                strSQL += " or  NgayBatDau=N'" + strNgayBatDau + "'or NgayKetThuc=N'" + strNgayKetThuc + "' or TrangThaiThucHien=N'" + strTrangThai + "')";
                strSQL += " and Account.TenDangNhap=N'" + strTenDangNhap + "' and LichLamViec.TenDangNhap=N'" + strTenDangNhap + "'";
            }

            global.LoadDataGrid(dtgTraCuu, strSQL, sqlConn.sqlCNN);
            FormatGrid(dtgTraCuu);
        }

        private void listViewTraCuu_CursorChanged(object sender, EventArgs e)
        {
            
        }
        private void FormatGrid(DataGrid grd)
        {
            try
            {
                DataGridTableStyle grdTableStyle = new DataGridTableStyle();
                grd.TableStyles.Clear();

                //Select
                DataGridBoolColumn grdColSelect = new DataGridBoolColumn();
                grdColSelect.MappingName = "Select";
                grdColSelect.HeaderText = "Chọn";
                grdColSelect.NullText = "";
                grdColSelect.Width = 45;
                grdColSelect.AllowNull = false;
                grdColSelect.Alignment = HorizontalAlignment.Center;

                //STT
                DataGridTextBoxColumn grdColSTT = new DataGridTextBoxColumn();
                grdColSTT.MappingName = "STT";
                grdColSTT.HeaderText = "Số Thứ Tự";
                grdColSTT.NullText = "";
                grdColSTT.Width = 60;
                grdColSelect.Alignment = HorizontalAlignment.Center;

                //TenDangNhap
                DataGridTextBoxColumn grdColTenDangNhap = new DataGridTextBoxColumn();
                grdColTenDangNhap.MappingName = "TenDangNhap";
                grdColTenDangNhap.HeaderText = "Tên Đăng Nhập";
                grdColTenDangNhap.NullText = "";
                grdColTenDangNhap.Width = 90;
                grdColTenDangNhap.Alignment = HorizontalAlignment.Center;

                //NgayBatDau
                DataGridTextBoxColumn grdColNgayBatDau = new DataGridTextBoxColumn();
                grdColNgayBatDau.MappingName = "NgayBatDau";
                grdColNgayBatDau.HeaderText = "Ngày Bắt Đầu";
                grdColNgayBatDau.NullText = "";
                grdColNgayBatDau.Width = 80;
                grdColNgayBatDau.Alignment = HorizontalAlignment.Center;

                //NgayKetThuc
                DataGridTextBoxColumn grdColNgayKetThuc = new DataGridTextBoxColumn();
                grdColNgayKetThuc.MappingName = "NgayKetThuc";
                grdColNgayKetThuc.HeaderText = "Ngày Kết Thúc";
                grdColNgayKetThuc.NullText = "";
                grdColNgayKetThuc.Width = 80;
                grdColNgayKetThuc.Alignment = HorizontalAlignment.Center;

                //GioBatDau
                DataGridTextBoxColumn grdColGioBatDau = new DataGridTextBoxColumn();
                grdColGioBatDau.MappingName = "GioBatDau";
                grdColGioBatDau.HeaderText = "Giờ Bắt Đầu";
                grdColGioBatDau.NullText = "";
                grdColGioBatDau.Width = 70;
                grdColGioBatDau.Alignment = HorizontalAlignment.Center;

                //GioKetThuc
                DataGridTextBoxColumn grdColGioKetThuc = new DataGridTextBoxColumn();
                grdColGioKetThuc.MappingName = "GioKetThuc";
                grdColGioKetThuc.HeaderText = "Giờ Kết Thúc";
                grdColGioKetThuc.NullText = "";
                grdColGioKetThuc.Width = 70;
                grdColGioKetThuc.Alignment = HorizontalAlignment.Center;

                //NoiDungCongViec
                DataGridTextBoxColumn grdColNoiDungCongViec = new DataGridTextBoxColumn();
                grdColNoiDungCongViec.MappingName = "NoiDungCongViec";
                grdColNoiDungCongViec.HeaderText = "Nội Dung Công Việc";
                grdColNoiDungCongViec.NullText = "";
                grdColNoiDungCongViec.Width = 120;
                grdColNoiDungCongViec.Alignment = HorizontalAlignment.Center;

                //TrangThaiThucHien
                DataGridTextBoxColumn grdColTrangThaiThucHien = new DataGridTextBoxColumn();
                grdColTrangThaiThucHien.MappingName = "TrangThaiThucHien";
                grdColTrangThaiThucHien.HeaderText = "Trạng Thái Thực Hiện";
                grdColTrangThaiThucHien.NullText = "";
                grdColTrangThaiThucHien.Width = 120;
                grdColTrangThaiThucHien.Alignment = HorizontalAlignment.Center;

                grdTableStyle.GridColumnStyles.AddRange(new DataGridColumnStyle[] { grdColSelect, grdColSTT, grdColTenDangNhap, grdColNgayBatDau, grdColNgayKetThuc, grdColGioBatDau, grdColGioKetThuc, grdColNoiDungCongViec, grdColTrangThaiThucHien });
                grd.TableStyles.Add(grdTableStyle);
            }
            catch
            { }
        }

        private void dtgTraCuu_CurrentCellChanged(object sender, EventArgs e)
        {
            DataTable dtTable = (DataTable)dtgTraCuu.DataSource;
            int intIndex = dtgTraCuu.CurrentRowIndex;
            if ((dtTable != null) && (dtTable.Rows.Count > 0))
            {
                if (intIndex >= 0)
                {
                    txtDangNhap.Text = dtTable.Rows[intIndex]["TenDangNhap"].ToString();
                    dtpNgayBatDau.Text= global.Convert_Day(dtTable.Rows[intIndex]["NgayBatDau"].ToString());
                    dtpNgayKetThuc.Text = global.Convert_Day(dtTable.Rows[intIndex]["NgayKetThuc"].ToString());
                    //txtGioBatDau.Text = dtTable.Rows[intIndex]["GioBatDau"].ToString();
                    comboTrangThai.Text = dtTable.Rows[intIndex]["TrangThaiThucHien"].ToString();
                    rtbNoiDung.Text = dtTable.Rows[intIndex]["NoiDungCongViec"].ToString();
                    strSoThuTu = dtTable.Rows[intIndex]["STT"].ToString();
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            comboTrangThai.Text = "Chưa Thực Hiện";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strSQL = "Delete From LichLamViec Where STT='" + strSoThuTu + "'";
            global.SQL_Database(strSQL,sqlConn.sqlCNN);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string strTenDangNhap = txtDangNhap.Text;
                string strNgayBatDau = dtpNgayBatDau.Text;
                string strNgayKetThuc = dtpNgayKetThuc.Text;
                string strThoiGianBatDau = null;
                try
                {
                    strThoiGianBatDau = comboHourStart.SelectedItem.ToString();
                    strThoiGianBatDau += ":" + comboMinutesStart.SelectedItem.ToString();
                    strThoiGianBatDau += " " + comboTimeStart.SelectedItem.ToString();
                }
                catch
                {
                    strThoiGianBatDau = "";
                }
                string strThoiGianKetThuc = null;
                try
                {
                    strThoiGianKetThuc = comboHourEnd.SelectedItem.ToString();
                    strThoiGianKetThuc += ":" + comboMinutesEnd.SelectedItem.ToString();
                    strThoiGianKetThuc += " "+comboTimeEnd.SelectedItem.ToString();
                }
                catch
                {
                    strThoiGianKetThuc = "";
                }
                //string strGioBatDau = txtGioBatDau.Text;
                string strTrangThai = comboTrangThai.Text;
                string strNoiDung = rtbNoiDung.Text;
                string strSQL = "Update LichLamViec set TenDangNhap=N'" + strTenDangNhap + "',NgayBatDau=N'" + strNgayBatDau + "',NgayKetThuc=N'" + strNgayKetThuc + "',";
                strSQL += "GioBatDau=N'" + strThoiGianBatDau + "',NoiDungCongViec=N'" + strNoiDung + "',TrangThaiThucHien=N'" + strTrangThai + "',GioKetThuc=N'" + strThoiGianKetThuc + "'";
                strSQL += "where STT=" + strSoThuTu + "";
                global.SQL_Database(strSQL, sqlConn.sqlCNN);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string strChuoiDieuKIen = null;
            try
            {
                if (dtgTraCuu.DataSource != null)
                {
                    DataTable dtTable = (DataTable)dtgTraCuu.DataSource;
                    if ((dtTable != null) && (dtTable.Rows.Count > 0))
                    {
                        for (int i = 0; i <= dtTable.Rows.Count - 1; i++)
                        {
                            if (Convert.ToBoolean(dtTable.Rows[i]["Select"]))
                            {
                                string strSTT = dtTable.Rows[i]["STT"].ToString();
                                strChuoiDieuKIen += "'" + strSTT + "',";
                            }
                        }
                        strChuoiDieuKIen = strChuoiDieuKIen.Substring(0, strChuoiDieuKIen.Length - 1);
                        string strSQL = "Delete From LichLamViec where STT in(" + strChuoiDieuKIen + ")";
                        global.SQL_Database(strSQL, sqlConn.sqlCNN);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, strMess.strTieuDe, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string strChuoiDieuKIen = null;
            try
            {
                if (dtgTraCuu.DataSource != null)
                {
                    DataTable dtTable = (DataTable)dtgTraCuu.DataSource;
                    if ((dtTable != null) && (dtTable.Rows.Count > 0))
                    {
                        for (int i = 0; i <= dtTable.Rows.Count - 1; i++)
                        {
                            if (Convert.ToBoolean(dtTable.Rows[i]["Select"]))
                            {
                                string strSTT = dtTable.Rows[i]["STT"].ToString();
                                strChuoiDieuKIen += "'" + strSTT + "',";  
                            }
                        }
                        strChuoiDieuKIen = strChuoiDieuKIen.Substring(0, strChuoiDieuKIen.Length - 1);
                        string strSQL = "Update LichLamViec set TrangThaiThucHien=N'Đã Thực Hiện' where STT in (" + strChuoiDieuKIen + ")";
                        global.SQL_Database(strSQL, sqlConn.sqlCNN);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, strMess.strTieuDe, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string strChuoiDieuKIen = null;
            try
            {
                if (dtgTraCuu.DataSource != null)
                {
                    DataTable dtTable = (DataTable)dtgTraCuu.DataSource;
                    if ((dtTable != null) && (dtTable.Rows.Count > 0))
                    {
                        for (int i = 0; i <= dtTable.Rows.Count - 1; i++)
                        {
                            if (Convert.ToBoolean(dtTable.Rows[i]["Select"]))
                            {
                                string strSTT = dtTable.Rows[i]["STT"].ToString();
                                strChuoiDieuKIen += "'" + strSTT + "',";
                            }
                        }
                        strChuoiDieuKIen = strChuoiDieuKIen.Substring(0, strChuoiDieuKIen.Length - 1);
                        string strSQL = "Update LichLamViec set TrangThaiThucHien=N'Chưa Thực Hiện' where STT in (" + strChuoiDieuKIen + ")";
                        global.SQL_Database(strSQL, sqlConn.sqlCNN);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, strMess.strTieuDe, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}