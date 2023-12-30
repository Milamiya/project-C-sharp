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
    public partial class frmQuanLyTaiKhoan : Form
    {
        public frmQuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        Modules.Global global = new LichCongTac.Modules.Global();
        Modules.ConnectionString sqlConn = new LichCongTac.Modules.ConnectionString();
        Modules.StringMessage strMess = new LichCongTac.Modules.StringMessage();

        private void frmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            try
            {
                sqlConn.getConnectionString();
            }
            catch
            {
                MessageBox.Show(strMess.strChuaKetNoiCSDL, strMess.strTieuDe, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            string strSQL = "select Account.TenDangNhap , Account.MatKhau,LoaiTaiKhoan.LoaiTaiKhoan from Account,LoaiTaiKhoan where Account.QuyenTruyCap = LoaiTaiKhoan.QuyenTruyCap and 1=2";
            global.LoadDataGrid(dtgQuanLyTaiKhoan, strSQL, sqlConn.sqlCNN);
            FormatGrid(dtgQuanLyTaiKhoan);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBox2.Items.Clear();
                string strCombo = comboBox1.Text;
                string strTest = null;
                string strSQL = null;
                if (strCombo == "Tên Tài Khoản")
                {
                    strTest = "TenDangNhap";
                }
                if (strCombo == "Quyền Truy Cập")
                {
                    strTest = "QuyenTruyCap";
                    strSQL = "Select distinct " + strTest + " from Account";
                }
                else
                {
                    strSQL = "Select distinct " + strTest + " from LichLamViec";
                }
                DataTable dtTable = new DataTable();
                SqlDataAdapter sqlADP = new SqlDataAdapter(strSQL, sqlConn.sqlCNN);
                sqlADP.Fill(dtTable);
                if (dtTable != null)
                {
                    for (int i = 0; i <= dtTable.Rows.Count - 1; i++)
                    {
                        if (dtTable.Rows[i][strTest].ToString() == "0")
                        {
                            comboBox2.Items.Add("Guest");
                        }
                        if (dtTable.Rows[i][strTest].ToString() == "1")
                        {
                            comboBox2.Items.Add("Admin");
                        }
                        if ((dtTable.Rows[i][strTest].ToString() != "0") && (dtTable.Rows[i][strTest].ToString() != "1"))
                        {
                            comboBox2.Items.Add(dtTable.Rows[i][strTest].ToString());
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, strMess.strTieuDe, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        //private void LoadDataGrid(string strSQL,DataGrid dtg)
        //{
        //    DataTable dtTable = new DataTable();
        //    SqlDataAdapter SqlADP = new SqlDataAdapter(strSQL,sqlConn.sqlCNN);
        //    SqlADP.Fill(dtTable);
        //    dtTable.DefaultView.AllowDelete = false;
        //    dtTable.DefaultView.AllowEdit = false;
        //    dtTable.DefaultView.AllowNew = false;
        //    dtg.DataSource = dtTable;
        //}
        private void FormatGrid(DataGrid dtg)
        {
            DataGridTableStyle dtgTableStyle = new DataGridTableStyle();
            dtg.TableStyles.Clear();

            //Select
            DataGridBoolColumn dtgColSelect = new DataGridBoolColumn();
            dtgColSelect.MappingName = "Select";
            dtgColSelect.HeaderText = "Chọn";
            dtgColSelect.NullText = "";
            dtgColSelect.Width = 50;
            dtgColSelect.AllowNull = false;
            dtgColSelect.Alignment = HorizontalAlignment.Center;

            //TenDangNhap
            DataGridTextBoxColumn dtgColTenDangNhap = new DataGridTextBoxColumn();
            dtgColTenDangNhap.MappingName = "TenDangNhap";
            dtgColTenDangNhap.HeaderText = "Tên Đăng Nhập";
            dtgColTenDangNhap.NullText = "";
            dtgColTenDangNhap.Width = 90;
            dtgColTenDangNhap.Alignment = HorizontalAlignment.Center;

            //MatKhau
            DataGridTextBoxColumn dtgColMatKhau = new DataGridTextBoxColumn();
            dtgColMatKhau.MappingName = "MatKhau";
            dtgColMatKhau.HeaderText = "Mật Khẩu";
            dtgColMatKhau.NullText = "";
            dtgColMatKhau.Width = 70;
            dtgColMatKhau.Alignment = HorizontalAlignment.Center;

            //LoaiTaiKhoan
            DataGridTextBoxColumn dtgColLoaiTaiKhoan = new DataGridTextBoxColumn();
            dtgColLoaiTaiKhoan.MappingName = "LoaiTaiKhoan";
            dtgColLoaiTaiKhoan.HeaderText = "Loại Tài Khoản";
            dtgColLoaiTaiKhoan.NullText = "";
            dtgColLoaiTaiKhoan.Width = 90;
            dtgColLoaiTaiKhoan.Alignment = HorizontalAlignment.Center;

            dtgTableStyle.GridColumnStyles.AddRange(new DataGridColumnStyle[] { dtgColSelect, dtgColTenDangNhap, dtgColMatKhau, dtgColLoaiTaiKhoan });
            dtg.TableStyles.Add(dtgTableStyle);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strSQL = null; 
            if (comboBox1.Text == "Tên Tài Khoản")
            {
                strSQL = " Select Account.TenDangNhap , Account.MatKhau,LoaiTaiKhoan.LoaiTaiKhoan from Account,LoaiTaiKhoan where Account.QuyenTruyCap = LoaiTaiKhoan.QuyenTruyCap and Account.TenDangNhap='" + comboBox2.Text + "'";
            }
            if (comboBox1.Text == "Quyền Truy Cập")
            {
                if (comboBox2.Text == "Guest")
                {
                    strSQL = "select Account.TenDangNhap , Account.MatKhau,LoaiTaiKhoan.LoaiTaiKhoan from Account,LoaiTaiKhoan where Account.QuyenTruyCap = LoaiTaiKhoan.QuyenTruyCap and LoaiTaiKhoan.QuyenTruyCap ='0'";
                }
                if (comboBox2.Text == "Admin")
                {
                    strSQL = "select Account.TenDangNhap , Account.MatKhau,LoaiTaiKhoan.LoaiTaiKhoan from Account,LoaiTaiKhoan where Account.QuyenTruyCap = LoaiTaiKhoan.QuyenTruyCap and LoaiTaiKhoan.QuyenTruyCap ='1'";
                }
            }
            global.LoadDataGrid(dtgQuanLyTaiKhoan, strSQL, sqlConn.sqlCNN);
            FormatGrid(dtgQuanLyTaiKhoan);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgQuanLyTaiKhoan.DataSource != null)
                {
                    DataTable dtTable = (DataTable)dtgQuanLyTaiKhoan.DataSource;
                    if ((dtTable != null) && (dtTable.Rows.Count > 0))
                    {
                        for (int i = 0; i <= dtTable.Rows.Count - 1; i++)
                        {
                            if (Convert.ToBoolean(dtTable.Rows[i]["Select"]))
                            {
                                string strTenDangNhap = dtTable.Rows[i]["TenDangNhap"].ToString();
                                string strSQL = "Delete From Account where TenDangNhap='" + strTenDangNhap + "'";
                                global.SQL_Database(strSQL, sqlConn.sqlCNN);
                            }
                        }
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