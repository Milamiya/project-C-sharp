using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using DevComponents.DotNetBar;

namespace Quanlydoanvien
{
    public partial class frmDoanvien : DevComponents.DotNetBar.Office2007Form
    {
        public frmDoanvien()
        {
            InitializeComponent();
        }

        private OleDbConnection objConnect;
        private DataTable objDataTable;

        OleDbCommand cmd = new OleDbCommand();
        public OleDbConnection conn()
        {
            return new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0 ;" +
                        "Data Source =" + Application.StartupPath + @"\quanlydoanvien.mdb;" +
                        "Jet OLEDB:Database Password =000000;" +
                        "User ID = admin");
        }
        private void subCreateConnect()
        {
            try
            {
                String varChuoiConnect = "Provider = Microsoft.Jet.OLEDB.4.0 ;" +
                            "Data Source =" + Application.StartupPath + @"\quanlydoanvien.mdb;" +
                            "Jet OLEDB:Database Password =000000;" +
                            "User ID = admin";
                objConnect = new OleDbConnection(varChuoiConnect);
                objConnect.Open();
            }
            catch (Exception)
            {
                MessageBoxEx.Show("Không thể kết nối tới CSDL. Xin kiểm tra lại kết nối!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void subDestroyConnect()
        {
            objConnect.Close(); //Đóng kết nối
            objConnect.Dispose();//Giải phóng tài nguyên
            objConnect = null; //Hủy đối tượng
        }
        private void subSelectBySQLTructiepQuaDataReader()
        {
            //Tạo kết nối tới file Access
            subCreateConnect();
            //Truy vấn dữ liệu
            String varSelect = "Select * from DOANVIEN";//Lệnh SQL
            OleDbCommand objCommand = new OleDbCommand(varSelect, objConnect);
            //Tạo DataReader nhận dữ liệu trả về
            OleDbDataReader objReader = objCommand.ExecuteReader();
            //Tạo đối tượng DataTable và Load DataReader vào
            objDataTable = new DataTable("abc");
            objDataTable.Load(objReader);
            //Gán dữ liệu vào Datagrid
            dgdoanvien.DataSource = objDataTable;
            //Hủy các đối tượng
            objCommand.Dispose();
            objCommand = null;
            objReader.Close();
            objReader.Dispose();
            objReader = null;
            objDataTable.Dispose();
            objDataTable = null;
            subDestroyConnect();
        }
        private void subBindingData()
        {
            txtnangkhieu.DataBindings.Clear();
            txtnangkhieu.DataBindings.Add("Text", dgdoanvien.DataSource, "NANGKHIEU");
            txtmadv.DataBindings.Clear();
            txtmadv.DataBindings.Add("Text", dgdoanvien.DataSource, "MADV");
            txtten.DataBindings.Clear();
            txtten.DataBindings.Add("Text", dgdoanvien.DataSource, "TEN");
            txtho.DataBindings.Clear();
            txtho.DataBindings.Add("Text", dgdoanvien.DataSource, "HO");
            
            txtquanhuyen.DataBindings.Clear();
            txtquanhuyen.DataBindings.Add("Text", dgdoanvien.DataSource, "QUANHUYEN");
            txttongiao.DataBindings.Clear();
            txttongiao.DataBindings.Add("Text", dgdoanvien.DataSource, "TONGIAO");
            txtcmnd.DataBindings.Clear();
            txtcmnd.DataBindings.Add("Text", dgdoanvien.DataSource, "CMND");
            txttdvh.DataBindings.Clear();
            txttdvh.DataBindings.Add("Text", dgdoanvien.DataSource, "TRINHDOVH");
            txttinhtp.DataBindings.Clear();
            txttinhtp.DataBindings.Add("Text", dgdoanvien.DataSource, "TINHTHANHPHO");        
            txtdantoc.DataBindings.Clear();
            txtdantoc.DataBindings.Add("Text", dgdoanvien.DataSource, "DANTOC");
            txtgioitinh.DataBindings.Clear();
            txtgioitinh.DataBindings.Add("Text", dgdoanvien.DataSource, "GIOITINH");
            txtchucvu.DataBindings.Clear();
            txtchucvu.DataBindings.Add("Text", dgdoanvien.DataSource, "CHUCVU");
            dtngaysinh.DataBindings.Clear();
            dtngaysinh.DataBindings.Add("Text", dgdoanvien.DataSource, "NGAYSINH");           
            dtngayvaodoan.DataBindings.Clear();
            dtngayvaodoan.DataBindings.Add("Text", dgdoanvien.DataSource, "NGAYVAODOAN");
            txtvathitran.DataBindings.Clear();
            txtvathitran.DataBindings.Add("Text", dgdoanvien.DataSource, "XATHITRAN");
            txtchidoan.DataBindings.Clear();
            txtchidoan.DataBindings.Add("Text", dgdoanvien.DataSource, "CHIDOAN");
        }
        private void subInsertCommandHasParameter()
        {
            //Tạo kết nối tới file Access
            subCreateConnect();
            //Tạo đối tượng Command
            OleDbCommand objCommand = new OleDbCommand();
            objCommand.Connection = objConnect;
            objCommand.CommandType = CommandType.Text;

            objCommand.CommandText = "Insert into DOANVIEN values(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)";
            objCommand.Parameters.Add("@MADV", OleDbType.VarChar).Value = txtmadv.Text;
            objCommand.Parameters.Add("@HO", OleDbType.VarChar).Value = txtho.Text;
            objCommand.Parameters.Add("@TEN", OleDbType.VarChar).Value = txtten.Text;
            objCommand.Parameters.Add("@CHUCVU", OleDbType.VarChar).Value = txtchucvu.Text;
            objCommand.Parameters.Add("@NGAYSINH", OleDbType.Date).Value = dtngaysinh.Text;
            objCommand.Parameters.Add("@NGAYVAODOAN", OleDbType.Date).Value = dtngayvaodoan.Text;
            objCommand.Parameters.Add("@GIOITINH", OleDbType.VarChar).Value = txtgioitinh.Text;
            objCommand.Parameters.Add("@DANTOC", OleDbType.VarChar).Value = txtdantoc.Text;
            objCommand.Parameters.Add("@TONGIAO", OleDbType.VarChar).Value = txttongiao.Text;
            objCommand.Parameters.Add("@CMND", OleDbType.VarChar).Value = txtcmnd.Text;
            objCommand.Parameters.Add("@XATHITRAN", OleDbType.VarChar).Value = txtvathitran.Text;
            objCommand.Parameters.Add("@QUANHUYEN", OleDbType.VarChar).Value = txtquanhuyen.Text;          
            objCommand.Parameters.Add("@TINHTHANHPHO", OleDbType.VarChar).Value = txttinhtp.Text;           
            objCommand.Parameters.Add("@TRINHDOVH", OleDbType.VarChar).Value = txttdvh.Text;
            objCommand.Parameters.Add("@NANGKHIEU", OleDbType.VarChar).Value = txtnangkhieu.Text;
            objCommand.Parameters.Add("@CHIDOAN", OleDbType.VarChar).Value = txtchidoan.Text;
            
            objCommand.ExecuteNonQuery();
            //Hủy đối tượng
            objCommand.Dispose();
            objCommand = null;
            subDestroyConnect();
        }
        public void selectdl()
        {
            dgdoanvien.DataSource = null;
            subSelectBySQLTructiepQuaDataReader();
            subBindingData();
            //Load bảng điểm
            subCreateConnect();
            OleDbCommand objcommand = new OleDbCommand("Select * from DOANVIEN", objConnect);
            OleDbDataReader objReader = objcommand.ExecuteReader();
            objDataTable = new DataTable();
            objDataTable.Load(objReader);
        }
        public void disableselect()
        {
            dgdoanvien.DataSource = null;
            subSelectBySQLTructiepQuaDataReader();
            //subBindingData();
            //Load bảng điểm
            subCreateConnect();
            OleDbCommand objcommand = new OleDbCommand("Select * from DOANVIEN", objConnect);
            OleDbDataReader objReader = objcommand.ExecuteReader();
            objDataTable = new DataTable();
            objDataTable.Load(objReader);
        }
        private void frmDoanvien_Load(object sender, EventArgs e)
        {
            AdvancedCursors av = new AdvancedCursors();
            this.Cursor = AdvancedCursors.Create(@".\3dc_3043.ani");
            selectdl();         
            btnsua.Enabled = false;
            btnthem.Enabled = false;
            btnlamoi.Enabled = false;
            disable();
        }
       
        private bool kiemtratontai()
        {
            bool tatkt = false;
            string cmnd = txtcmnd.Text;
            OleDbConnection kn = conn();
            OleDbCommand cmd = new OleDbCommand("Select CMND from DOANVIEN", kn);
            kn.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (cmnd == dr.GetString(0))
                {
                    tatkt = true;
                    break;
                }
            }
            kn.Close();
            return tatkt;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            disableselect();
            string s1 = "Nam";
            string s2 = "Nữ";
            try
            {
                if (txtmadv.Text == "")
                {
                    btnthem.Enabled = true;
                    MessageBoxEx.Show(" Mã đoàn viên không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtmadv.Focus();
                }
                else
                    if (txtho.Text == "")
                    {
                        btnthem.Enabled = true;
                        MessageBoxEx.Show(" Họ không được rỗng !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtho.Focus();
                    }
                    else
                        if (txtten.Text == "")
                        {
                            btnthem.Enabled = true;
                            MessageBoxEx.Show(" Tên không được rỗng !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtten.Focus();
                        }
                    else
                        if (dtngaysinh.Text == ""&& dtngayvaodoan.Text =="")
                        {
                            btnthem.Enabled = true;
                            MessageBoxEx.Show(" Ngày sinh và ngày vào đoàn không được rỗng!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dtngaysinh.Focus();
                        }
                        else
                            if ((DateTime.Now.Year - dtngayvaodoan.Value.Year) >= 14)
                            {
                                btnthem.Enabled = true;
                                MessageBoxEx.Show(" Tuổi vào đoàn phải lớn hơn hoặc bằng số tuổi 14!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                dtngayvaodoan.Focus();
                            }
                        else
                            if (txtchucvu.Text == "")
                            {
                                btnthem.Enabled = true;
                                MessageBoxEx.Show(" Chức vụ không được rỗng !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtchucvu.Focus();
                            }
                            else
                                if (txtgioitinh.Text == "")
                                {
                                    btnthem.Enabled = true;
                                    MessageBoxEx.Show(" Giới tính không được rỗng !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtgioitinh.Focus();
                                }
                                else
                                    if (txtgioitinh.Text.ToString() != s1 && txtgioitinh.Text.ToString() != s2)
                                    {
                                        btnthem.Enabled = true;
                                        MessageBoxEx.Show(" Giới tính chỉ có thể Nam hoặc Nữ !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        txtgioitinh.Focus();
                                    }
                                    else
                                        if (txttongiao.Text == "")
                                        {
                                            btnthem.Enabled = true;
                                            MessageBoxEx.Show(" Tôn giáo không được rỗng !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            txttongiao.Focus();
                                        }
                                        else
                                            if (txtdantoc.Text == "")
                                            {
                                                btnthem.Enabled = true;
                                                MessageBoxEx.Show(" Dân tộc không được rỗng !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                txtdantoc.Focus();
                                            }
                                            else
                                                if (txtquanhuyen.Text == "")
                                                {
                                                    btnthem.Enabled = true;
                                                    MessageBoxEx.Show(" Quận huyện không được rỗng !", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    txtquanhuyen.Focus();
                                                }

                                                else
                                                    if (txtvathitran.Text == "")
                                                    {
                                                        btnthem.Enabled = true;
                                                        MessageBoxEx.Show(" Xã/Thị Trấn không được rỗng!", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                        txtvathitran.Focus();
                                                    }
                                                    else
                                                        if (txtchidoan.Text == "")
                                                        {
                                                            btnthem.Enabled = true;
                                                            MessageBoxEx.Show(" Tên chi đoàn không được rỗng !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                            txtchidoan.Focus();
                                                        }
                                                        else
                                                            if (txtcmnd.Text == "")
                                                            {
                                                                btnthem.Enabled = true;
                                                                MessageBoxEx.Show(" Chứng minh nhân dân không được rỗng !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                txtcmnd.Focus();
                                                            }
                                                            else
                                                                if (txtcmnd.Text.Trim().Length > 10 || txtcmnd.Text.Trim().Length < 9)
                                                                {
                                                                    btnthem.Enabled = true;
                                                                    MessageBoxEx.Show(" Chứng minh nhân dân không được bé hơn 9 chữ số hoặc lớn hơn 10 chữ số!", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                    txtcmnd.Focus();
                                                                }
                                                               

                                                                  
                                                                        else
                                                                            if ((DateTime.Now.Year - dtngaysinh.Value.Year) < 18)
                                                                            {
                                                                                MessageBoxEx.Show(" Ngày sinh tính đến nay phải lớn hơn hoặc bằng 18 tuổi!", "lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                                return;
                                                                            }

                                                                            else
                                                                                if (kiemtratontai())
                                                                                {
                                                                                    btnthem.Enabled = true;
                                                                                    MessageBoxEx.Show(" Chứng minh nhân dân này đã tồn tại.Chú ý! mỗi đoàn vên khác nhau phải có một CMND khác nhau", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                                                    txtcmnd.Focus();
                                                                                }
                                                                                else
                                                                                    if (txtmadv.Text.StartsWith("DV") == false || txtmadv.Text.ToString().Length > 6)
                                                                                    {
                                                                                        MessageBoxEx.Show(" Mã đoàn viên bắt buộc 2 ký tự đầu phải là DV và phải bé hơn hoặc bằng 8 kí tự  !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                                        txtmadv.Focus();
                                                                                    }

                                                                                    else
                                                                                    {
                                                                                        subInsertCommandHasParameter();
                                                                                        disableselect();
                                                                                        MessageBoxEx.Show("Đã lưu đoàn viên " + txtho.Text + " vào CSDL thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                                        btnthem.Enabled = false;

                                                                                    }


            }
            catch (Exception)
            {
                MessageBoxEx.Show("Mã đoàn viên này đã tồn tại.Chú ý! mỗi đoàn vên khác nhau phải có một MADV khác nhau !", " Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmadv.Focus();
            }
             

        }

        public void disable()
        {
            txtmadv.Enabled = false;
            txttdvh.Enabled = false;
            txtnangkhieu.Enabled = false;
            txtquanhuyen.Enabled = false;
            txttinhtp.Enabled = false;
          
            txtho.Enabled = false;
            txtgioitinh.Enabled = false;
            txtdantoc.Enabled = false;
            txtcmnd.Enabled = false;
            txtchucvu.Enabled = false;
            txtvathitran.Enabled = false;
            txtchidoan.Enabled = false;
            txtquanhuyen.Enabled = false;
            txtnangkhieu.Enabled = false;
            txttongiao.Enabled = false;
            dtngayvaodoan.Enabled = false;
            dtngaysinh.Enabled = false;
            txtten.Enabled = false;
        }
        public void enable()
        {
            txtmadv.Enabled = true;
            txttdvh.Enabled = true;
            txtnangkhieu.Enabled = true;
            txtquanhuyen.Enabled = true;
            txttinhtp.Enabled = true;
            
            txtten.Enabled = true;
            txtho.Enabled = true;
            txtgioitinh.Enabled = true;
            txtdantoc.Enabled = true;
            txtcmnd.Enabled = true;
            txtchucvu.Enabled = true;
            txtvathitran.Enabled = true;
            txtchidoan.Enabled = true;
            txtquanhuyen.Enabled = true;
            txtnangkhieu.Enabled = true;
            txttongiao.Enabled = true;
            dtngaysinh.Enabled = true;
            dtngayvaodoan.Enabled = true;
            txtten.Enabled = true;
        }
        private void btnlamoi_Click(object sender, EventArgs e)
        {
            string s = "DV";
            btnsua.Enabled = false;
            txtho.Focus();
            dtngaysinh.Text = "";
            dtngayvaodoan.Text = "";
            txtchidoan.Text = "";
            txtvathitran.Text = "";
            txtchucvu.Text = "";
            txtdantoc.Text = "";
            txtho.Text = "";
            txtten.Text = "";
            
            txtquanhuyen.Text = "";
            txttongiao.Text = "";
            txtgioitinh.Text = "Nam";
            txttdvh.Text = "12/12";
            txtcmnd.Text = "";
            txtnangkhieu.Text = "";
            txttinhtp.Text = "";           
            txtchucvu.Text = "Đoàn Viên";          
            txtmadv.Text=s;
            btnthem.Enabled = true;
            btnsua.Enabled = false;
            
            
        }
        private void subDeleteCommandHasParameter()
        {
            //Tạo kết nối
            subCreateConnect();
            //Tạo command
            OleDbCommand objcommand = new OleDbCommand { Connection = objConnect, CommandType = CommandType.Text, CommandText = "Delete From DOANVIEN Where MADV = ?" };
            objcommand.Parameters.Add("MADV", OleDbType.VarChar).Value = txtmadv.Text;
            objcommand.ExecuteNonQuery();
            //Hủy đối tượng
            objcommand.Dispose();
            objcommand = null;
            subDestroyConnect();

        }
        public void rong()
        {
            txtchidoan.Text = "";
            txtvathitran.Text = "";
            txtchucvu.Text = "";
            txtdantoc.Text = "";
            txtho.Text = "";
            txtmadv.Text = "";
            txtten.Text = "";
           
            txtquanhuyen.Text = "";
            txttongiao.Text = "";
            txtgioitinh.Text = "";
            txttdvh.Text = "12/12";
            txtcmnd.Text = "";
            txtnangkhieu.Text = "";
            txttinhtp.Text = "";
            dtngaysinh.Text = "";
        }
        public int demgiatri()
        {
            int i;
            for (i = 0; i < dgdoanvien.RowCount - 1; i++)
            {
                i.ToString();
            }
            return i;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (demgiatri() == 0)
                {
                    rong();
                    MessageBoxEx.Show(" Dữ liệu không tồn tại để thực hiện chức năng xóa này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult XOA = MessageBoxEx.Show(" Bạn thực sự muốn xóa đoàn viên " + txtho.Text + " " + txtten.Text + " ra khỏi danh sách?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (XOA == DialogResult.Yes)
                    {

                        subDeleteCommandHasParameter();
                        rong();
                        selectdl();

                        MessageBoxEx.Show("  Xóa thành công !", " Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBoxEx.Show(" Bạn đã không xóa!", " Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                selectdl();
            }
            catch (Exception)
            {
                MessageBoxEx.Show("Không thể xóa " + txtho.Text + " " + txtten.Text + " này được .Nếu muốn xóa thì hãy xóa " + txtmadv.Text + " trong các quản lý gia đình,đoàn phí,kỷ luật, nhận xét trước tiên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
           
            subCreateConnect();
            OleDbCommand objCommand = new OleDbCommand();
            objCommand.Connection = objConnect;
            objCommand.CommandType = CommandType.Text;
            string s1 = "Nam";
            string s2 = "Nữ";           
                if (txtmadv.Text == "")
                {
                    btnthem.Enabled = true;
                    MessageBoxEx.Show(" Mã đoàn viên không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtmadv.Focus();
                }
                else
                    if (txtho.Text == "")
                    {
                        btnthem.Enabled = true;
                        MessageBoxEx.Show(" Họ không được rỗng !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtho.Focus();
                    }
                    else
                        if (txtten.Text == "")
                        {
                            btnthem.Enabled = true;
                            MessageBoxEx.Show(" Tên không được rỗng !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtten.Focus();
                        }
                    else
                        if (dtngaysinh.Text == ""&& dtngayvaodoan.Text =="")
                        {
                            btnthem.Enabled = true;
                            MessageBoxEx.Show(" Ngày sinh và ngày vào đoàn không được rỗng!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dtngaysinh.Focus();
                        }
                        else
                            if ((DateTime.Now.Year - dtngayvaodoan.Value.Year) >= 14)
                            {
                                btnthem.Enabled = true;
                                MessageBoxEx.Show(" Tuổi vào đoàn phải lớn hơn hoặc bằng số tuổi 14!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                dtngayvaodoan.Focus();
                            }
                        else
                            if (txtchucvu.Text == "")
                            {
                                btnthem.Enabled = true;
                                MessageBoxEx.Show(" Chức vụ không được rỗng !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtchucvu.Focus();
                            }
                            else
                                if (txtgioitinh.Text == "")
                                {
                                    btnthem.Enabled = true;
                                    MessageBoxEx.Show(" Giới tính không được rỗng !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtgioitinh.Focus();
                                }
                                else
                                    if (txtgioitinh.Text.ToString() != s1 && txtgioitinh.Text.ToString() != s2)
                                    {
                                        btnthem.Enabled = true;
                                        MessageBoxEx.Show(" Giới tính chỉ có thể Nam hoặc Nữ !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        txtgioitinh.Focus();
                                    }
                                    else
                                        if (txttongiao.Text == "")
                                        {
                                            btnthem.Enabled = true;
                                            MessageBoxEx.Show(" Tôn giáo không được rỗng !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            txttongiao.Focus();
                                        }
                                        else
                                            if (txtdantoc.Text == "")
                                            {
                                                btnthem.Enabled = true;
                                                MessageBoxEx.Show(" Dân tộc không được rỗng !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                txtdantoc.Focus();
                                            }
                                            else
                                                if (txtquanhuyen.Text == "")
                                                {
                                                    btnthem.Enabled = true;
                                                    MessageBoxEx.Show(" Quận huyện không được rỗng !", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    txtquanhuyen.Focus();
                                                }

                                                else
                                                    if (txtvathitran.Text == "")
                                                    {
                                                        btnthem.Enabled = true;
                                                        MessageBoxEx.Show(" Xã/Thị Trấn không được rỗng!", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                        txtvathitran.Focus();
                                                    }
                                                    else
                                                        if (txtchidoan.Text == "")
                                                        {
                                                            btnthem.Enabled = true;
                                                            MessageBoxEx.Show(" Tên chi đoàn không được rỗng !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                            txtchidoan.Focus();
                                                        }
                                                        else
                                                            if (txtcmnd.Text == "")
                                                            {
                                                                btnthem.Enabled = true;
                                                                MessageBoxEx.Show(" Chứng minh nhân dân không được rỗng !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                txtcmnd.Focus();
                                                            }
                                                            else
                                                                if (txtcmnd.Text.Trim().Length > 10 || txtcmnd.Text.Trim().Length < 9)
                                                                {
                                                                    btnthem.Enabled = true;
                                                                    MessageBoxEx.Show(" Chứng minh nhân dân không được bé hơn 9 chữ số hoặc lớn hơn 10 chữ số!", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                    txtcmnd.Focus();
                                                                }
                                                                                                                         
                                                                        else
                                                                            if ((DateTime.Now.Year - dtngaysinh.Value.Year) < 18)
                                                                            {
                                                                                MessageBoxEx.Show(" Ngày sinh tính đến nay phải lớn hơn hoặc bằng 18 tuổi!", "lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                                return;
                                                                            }

                                                                                else
                                                                                    if (txtmadv.Text.StartsWith("DV") == false || txtmadv.Text.ToString().Length > 8)
                                                                                    {
                                                                                        MessageBoxEx.Show(" Mã đoàn viên bắt buộc 2 ký tự đầu phải là DV và phải bé hơn hoặc bằng 8 kí tự  !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                                        txtmadv.Focus();
                                                                                    }
                                                                                    else
                                                                                        if (demgiatri() != 0)
                                                                                        {

                                                                                            string s;
                                                                                            s = "Update DOANVIEN" + " Set HO = '" + txtho.Text + "'," +
                                                                                                "CHIDOAN = '" + txtchidoan.Text + "',TEN = '" + txtten.Text + "', CMND = '" + txtcmnd.Text + "',QUANHUYEN = '" + txtquanhuyen.Text + "', DANTOC = '" + txtdantoc.Text + "', GIOITINH = '" + txtgioitinh.Text + "',TONGIAO= '" + txttongiao.Text + "',NANGKHIEU = '" + txtnangkhieu.Text + "',XATHITRAN = '" + txtvathitran.Text + "', NGAYSINH= '" + dtngaysinh.Text + "', NGAYVAODOAN = '" + dtngayvaodoan.Text + "', CHUCVU = '" + txtchucvu.Text + "', TINHTHANHPHO = '" + txttinhtp.Text + "'" +
                                                                                                " Where MADV = '" + txtmadv.Text + "'";
                                                                                            objCommand.Connection = objConnect;
                                                                                            objCommand.CommandText = s;
                                                                                            objCommand.ExecuteNonQuery();
                                                                                            objConnect.Close();

                                                                                            objCommand.Dispose();
                                                                                            objCommand = null;
                                                                                            subDestroyConnect();

                                                                                            MessageBoxEx.Show("Đã Cập nhật thông tin cho đoàn viên " + txtho.Text + " " + txtten.Text + " thành công!", " Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            MessageBoxEx.Show(" Dữ liệu không tồn tại để thực hiện chức năng này!", " Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                                        }
                                                                                        selectdl();
                
        }

        private void txtnh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBoxEx.Show(" Không được nhập ký tự là chữ cái!", "   Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtcmnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBoxEx.Show(" Không được nhập ký tự là chữ cái!", "   Lỗi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmDoanvien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult thoat = MessageBoxEx.Show("Có phải bạn muốn thoát khỏi danh mục này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = (thoat == DialogResult.No);
        }

        private void xóaĐoànViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (demgiatri() == 0)
            {
                rong();
                MessageBoxEx.Show(" Dữ liệu không tồn tại để thực hiện chức năng xóa này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult XOA = MessageBoxEx.Show(" Bạn thực sự muốn xóa đoàn viên " + txtho.Text + " " + txtten.Text + " ra khỏi danh sách ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (XOA == DialogResult.Yes)
                {

                    subDeleteCommandHasParameter();
                    rong();
                    selectdl();

                    MessageBoxEx.Show("  Xóa thành công !", " Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBoxEx.Show(" Bạn đã không xóa!", " Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            selectdl();
        }

        private void txthoten_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == 'b')
            {
                e.Handled = true;
                //MessageBoxEx.Show(" Họ tên không thể nhập số được!", " Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                e.Handled = false;
            
            

        }

        private void txtnk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == 'b')
            {
                e.Handled = true;
                //MessageBoxEx.Show(" Không thể nhập số được!", " Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                e.Handled = false;
        }

        private void txtsotruong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == 'b')
            {
                e.Handled = true;
                //MessageBoxEx.Show(" Không thể nhập số được!", " Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                e.Handled = false;
        }

        private void txtquequan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == 'b')
            {
                e.Handled = true;
                //MessageBoxEx.Show(" Không thể nhập số được!", " Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                e.Handled = false;
        }

        private void txtchidoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == 'b')
            {
                e.Handled = true;
                //MessageBoxEx.Show(" Không thể nhập số được!", " Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                e.Handled = false;
        }

        private void txttongiao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == 'b')
            {
                e.Handled = true;
                //MessageBoxEx.Show(" Không thể nhập số được!", " Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                e.Handled = false;
        }

        private void btnkichoatsua_Click(object sender, EventArgs e)
        {
            selectdl();
            btnsua.Enabled = true;
            btnthem.Enabled = false;
            btnlamoi.Enabled = false;
            btnthem.Enabled = false;
            enable();
        }

        private void btnkichoatthem_Click(object sender, EventArgs e)
        {
            btnlamoi.Enabled = true;
            enable();
            btnsua.Enabled = false;
            disableselect();

        }

        private void btnindv_Click(object sender, EventArgs e)
        {
            try
            {
                if (demgiatri() > 0)
                {
                    frmInDV dv = new frmInDV();
                    dv.Show();
                }

                else
                    MessageBoxEx.Show(" Hiện tại hệ thống kiểm tra trong CSDL không có đoàn viên nào để xuất ra danh sách!", " Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBoxEx.Show(" Bạn chưa cài đặt Reportreview để bật chức năng này!", " Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void btnindvnam_Click(object sender, EventArgs e)
        {
            try
            {
                if (demgiatri() > 0)
                {
                    frmInDVNam dvn = new frmInDVNam();
                    dvn.Show();

                }

                else
                    MessageBoxEx.Show(" Hiện tại hệ thống kiểm tra trong CSDL không có đoàn viên nào để xuất ra danh sách!", " Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBoxEx.Show(" Bạn chưa cài đặt Reportreview để bật chức năng này!", " Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
       }

        private void btnIndvnu_Click(object sender, EventArgs e)
        {
            try
            {
                if (demgiatri() > 0)
                {
                    frmInDVNu dvk = new frmInDVNu();
                    dvk.Show();

                }
                else
                    MessageBoxEx.Show(" Hiện tại hệ thống kiểm tra trong CSDL không có đoàn viên nào để xuất ra danh sách!", " Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBoxEx.Show(" Bạn chưa cài đặt Reportreview để bật chức năng này!", " Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
      
        private void buttonX1_Click(object sender, EventArgs e)
        {
            frmChonNamHoc first = new frmChonNamHoc();
           
            first.Show();
        }

        private void txtten_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == 'b')
            {
                e.Handled = true;
                //MessageBoxEx.Show(" Không thể nhập số được!", " Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                e.Handled = false;
        }

    }
}
