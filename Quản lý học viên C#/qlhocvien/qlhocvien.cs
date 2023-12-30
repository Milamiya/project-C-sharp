using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Diagnostics;

namespace qlhocvien
{
    public partial class qlhocvien : DevComponents.DotNetBar.Office2007RibbonForm
    {
        DataSet ds = new DataSet();
        OleDbConnection cnn = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        string sql;

        public qlhocvien()
        {
            InitializeComponent();
        }
        public void Ketnoi()
        {
            cnn.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0 ;" + "Data Source =" +
                                Application.StartupPath + @"\qlhocvien.mdb;" +
                                "Jet OLEDB:Database Password =;" +
                                "User ID = admin";


            cnn.Open();

            cmd.Connection = cnn;


        }
        public void DanhSachHV()
        {

            string sql = "SELECT * FROM HocVien";
            DataTable dt = ketnoi.ExecuteQuery(sql);
            this.showdata.DataSource = dt;
        }


        
        private void buttonItem29_Click(object sender, EventArgs e)
        {
            try
            {
                this.DanhSachHV();
            }
            catch  { }
        }


        private void btthem_Click(object sender, EventArgs e)
        {
            try
            {
                txtmahv.Text = "";
                cbmakhoa.Text = "[--Chọn Một--]";
                txthoten.Text = "";
                txttuoi.Text = "";
                cbgioitinh.Text = "[--Chọn Một--]";
                txtnoisinh.Text = "";
                this.DanhSachHV();
            }
            catch 
            {
                MessageBox.Show("Bắt Được Exception ");
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        { 
            try
            {

                DialogResult ok;
                ok = MessageBox.Show("Bạn thực sự muốn xóa Học Viên: " +  txthoten.Text + " có mã số :" + txtmahv.Text + " chứ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ok == DialogResult.Yes)
                {
                    Ketnoi();
                    string sql = "";
                    sql = "delete from HocVien where MaHV='" + txtmahv.Text + "'";
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    MessageBox.Show("Xóa Thành Công");
                    txtmahv.Text = "";
                    cbmakhoa.Text = "[--Chọn Một--]";
                    txthoten.Text = "";
                    txttuoi.Text = "";
                    cbgioitinh.Text = "[--Chọn Một--]";
                    txtnoisinh.Text = "";
                    this.DanhSachHV();
                }
                else
                {
                    return;
                }

                

            }
 
		

                catch (Exception ex)
            {
                MessageBox.Show("Bắt Lỗi: Exception  "+ex.Message);
            
            }
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmahv.Text == "" || txthoten.Text == "" || txtnoisinh.Text == "" || cbmakhoa.Text == "" || cbmakhoa.Text == "[--Chọn Một--]")
                {
                    MessageBox.Show("Bạn chưa nhập đủ điều kiện", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtmahv.Text.ToString().Length > 5)
                {
                    MessageBox.Show("Mã học viên không được quá năm kí tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtmahv.Text = "";
                }
                else if (txthoten.Text.ToString().Length > 25)
                {
                    MessageBox.Show("Tên Học viên phải Nhỏ Hơn 25 Ký Tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txttuoi.Text = "";
                }
                else if (Int32.Parse(txttuoi.Text) < 18)
                {
                    MessageBox.Show("Học viên phải đủ mười tám tuổi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txttuoi.Text = "";
                }
                else
                {
                    Ketnoi();
                    string sql = "";
                    sql = "INSERT INTO HocVien(MaHV,TenHV,MaKhoa,Tuoi,Phai,Noisinh) VALUES('" + txtmahv.Text + "','" + cbmakhoa.Text + "','" + txthoten.Text + "','" + txttuoi.Text + "','" + cbgioitinh.Text + "','" + txtnoisinh.Text + " ')";

                    cmd.CommandText = sql;

                    MessageBox.Show("Lưu thành công Học Viên : " + txtmahv.Text + " ");

                    cmd.ExecuteNonQuery();

                    cnn.Close();
                    txtmahv.Text = "";
                    cbmakhoa.Text = "[--Chọn Một--]";
                    txthoten.Text = "";
                    txttuoi.Text = "";
                    cbgioitinh.Text = "[--Chọn Một--]";
                    txtnoisinh.Text = "";
                    this.DanhSachHV();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Vui Lòng Kiểm Tra lại "+ex.Message);
            }
                        
         }



        private void btsua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmahv.Text == "" || txthoten.Text == "" || txtnoisinh.Text == "" || cbmakhoa.Text == "" || cbgioitinh.Text == "[--Chọn Một--]" || cbmakhoa.Text == "" || cbmakhoa.Text == "[--Chọn Một--]")
                {
                    MessageBox.Show("Bạn chưa nhập đủ điều kiện", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtmahv.Text.ToString().Length > 5)
                {
                    MessageBox.Show("Mã học viên không được quá năm kí tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtmahv.Text = "";
                }
                else if (txthoten.Text.ToString().Length > 25)
                {
                    MessageBox.Show("Tên Học viên phải Nhỏ Hơn 25 Ký Tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txttuoi.Text = "";
                }
                else if (Int32.Parse(txttuoi.Text) < 18)
                {
                    MessageBox.Show("Học viên phải đủ mười tám tuổi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txttuoi.Text = "";
                }
                
                else
                {
                    string sql = "";
                    sql = "UPDATE HocVien SET TenHV ='" + txthoten.Text + "',MaKhoa ='" + cbmakhoa.Text + "', Tuoi ='" + txttuoi.Text + "',Phai ='" + cbgioitinh.Text + "',Noisinh='" + txtnoisinh.Text + "' WHERE MaHV='" + txtmahv.Text + "'";
                    Ketnoi();
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Đã Sữa Học Viên có Mã Số : " + txtmahv.Text + " Thành Công");
                    txtmahv.Text = "";
                    cbmakhoa.Text = "[--Chọn Một--]";
                    txthoten.Text = "";
                    txttuoi.Text = "";
                    cbgioitinh.Text = "[--Chọn Một--]";
                    txtnoisinh.Text = "";
                    cnn.Close();
                    this.DanhSachHV();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi :"+ex.Message);
            }
        }

        private void showdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


            
                DataGridViewRow row = new DataGridViewRow();

                row = showdata.Rows[e.RowIndex];
                txtmahv.Text = row.Cells[0].Value.ToString();
                cbmakhoa.Text = row.Cells[1].Value.ToString();
                txthoten.Text = row.Cells[2].Value.ToString();
                txttuoi.Text = row.Cells[3].Value.ToString();
                cbgioitinh.Text = row.Cells[4].Value.ToString();
                txtnoisinh.Text = row.Cells[5].Value.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Hãy Click Vào Học Viên Bạn Muốn Sửa");
            }
               
        }

  



        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.DanhSachHV();
            try
            {


                sql = "Select * From HocVien";
                OleDbCommand cmd = new OleDbCommand(sql, cnn);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtmahv.Text = reader["MaHV"].ToString();
                    cbmakhoa.Text = reader["MaKhoa"].ToString();
                    txthoten.Text = reader["TenHV"].ToString();
                    txttuoi.Text = reader["Tuoi"].ToString();
                    cbgioitinh.Text = reader["Phai"].ToString();
                    txtnoisinh.Text = reader["Noisinh"].ToString();
                    reader.Close();

                }
                OleDbDataAdapter sda = new OleDbDataAdapter();
                sda.SelectCommand = cmd;
                sda.Fill(ds, "HocVien");
                DataTable dtb = ds.Tables["HocVien"];
                showdata.DataSource = dtb;


                cnn.Close();
                
            }
            catch { }
            
        }

        private void btsearch_Click_1(object sender, EventArgs e)
        {
            string mhv = "Tìm Theo MãHV", ht = "Tìm Theo Tên";
            ketnoi a = new ketnoi();
            OleDbConnection con = a.data();
            con.Open();
            string tim = "";
            tim = Convert.ToString(txtsearch.Text);
            
            try
            {
                if (txtsearch.Text != "")
                    {
                        if (cbsearch.Text == mhv)
                        {
                            string ketqua = " select * from HocVien where MaHV like '%" + tim + "%'";
                            OleDbCommand cmd = new OleDbCommand(ketqua, con);

                            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                            DataSet ds = new DataSet();
                            da.Fill(ds, "HocVien");
                            showdata.DataSource = ds.Tables["HocVien"].DefaultView;
                        }
                        else if (cbsearch.Text == ht)
                        {
                            string ketqua = " select * from HocVien where TenHV like '%" + tim + "%'";
                            OleDbCommand cmd = new OleDbCommand(ketqua, con);

                            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                            DataSet ds = new DataSet();
                            da.Fill(ds, "HocVien");
                            showdata.DataSource = ds.Tables["HocVien"].DefaultView;
                        }
                        else

                            MessageBox.Show("Vui Lòng Chọn Tìm Theo Mã Học Viên Hoặc Theo Tên học Viên");
                    }
                else
                    MessageBox.Show("Hãy Nhập Từ Khóa Cần Tìm!!");
                }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi"+ex.Message);
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            try
            {


            if (txtmahv.Text != "")
            {


                SaveFileDialog dlg = new SaveFileDialog();


                dlg.Filter = "file *.txt|*.txt";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = new FileStream(dlg.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.Write("-----------Thong Tin Cua HV: " + txthoten.Text + "        -----------\r\n");
                    sw.Write("-----------Ma Hoc Vien     : " + txtmahv.Text + "         -----------\r\n");
                    sw.Write("-----------Ten Hoc Vien    : " + txthoten.Text + "        -----------\r\n");
                    sw.Write("-----------Mã Khoa         : " + cbmakhoa.Text + "        -----------\r\n");
                    sw.Write("-----------Tuổi            : " + txttuoi.Text + "     -----------\r\n");
                    sw.Write("-----------Giới Tính       : " + cbgioitinh.Text + "     -----------\r\n");
                    sw.Write("-----------Nơi Sinh        : " + txtnoisinh.Text + "      -----------\r\n");
                    sw.Write("-----------Chương Trình Quản Lý Hoc Viên: Nhóm 7 SGU      ----------------\r\n");
                    MessageBox.Show("Đã lưu File thành công");
                    sw.Close();
                }
            }
            else
                MessageBox.Show("Bạn Chưa Chọn Học Viên Để Lưu");
            }
            catch (Exception)
            {

                MessageBox.Show("Có Lỗi Không Thể Lưu File");
            }
        }

        private void qlhocvien_Load(object sender, EventArgs e)
        {

            qlhv.Enabled = false;
            giangvienkhoa.Enabled = false;
            hd.Enabled = false;
            gdangnhap.Visible = true;
            gdangxuat.Visible = false;
            

            

        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            Login f1 = new Login();
            f1.ShowDialog();
            if (Login.flag == true)
            {

                qlhv.Enabled = true;
                giangvienkhoa.Enabled = true;
                gdangnhap.Visible = false;
                gdangxuat.Visible = true;
                hd.Enabled = true;
               
            }
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            qlhv.Enabled = false;
            giangvienkhoa.Enabled = false;

            gdangnhap.Visible = true;
            hd.Enabled = false;
            MessageBox.Show("Đăng Xuất Thành Công,");
            //Application.Exit();
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonX7_Click_1(object sender, EventArgs e)
        {
            Process.Start("http://vietgiare.com/winform/qlhocvien.mdb",null);
        }

        private void buttonItem23_Click(object sender, EventArgs e)
        {
            Process.Start("http://vietgiare.com", null);
        }

        private void buttonItem17_Click(object sender, EventArgs e)
        {
            Process.Start("http://sgu.edu.vn", null);
        }

        private void buttonItem29_Click_1(object sender, EventArgs e)
        {
            Process.Start("http://sgu.edu.vn", null);
        }

        private void buttonItem26_Click(object sender, EventArgs e)
        {
            Process.Start("http://vietgiare.com", null);
        }





        private void buttonItem31_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                txtmahv.ForeColor = txthoten.ForeColor = cbmakhoa.ForeColor = gdangnhap.ForeColor = gdangxuat.ForeColor = groupBox1.ForeColor = groupBox2.ForeColor = groupBox3.ForeColor  =  ribbonControl1.ForeColor = cbgioitinh.ForeColor = txttuoi.ForeColor = showdata.ForeColor = dlg.Color;
        }

        private void buttonItem32_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                txtmahv.Font = txthoten.Font = cbmakhoa.Font = gdangnhap.Font = gdangxuat.Font = groupBox1.Font = groupBox2.Font = groupBox3.Font =   ribbonControl1.Font = cbgioitinh.Font = txttuoi.Font = showdata.Font = dlg.Font;
        }

        private void btgiangvien_Click(object sender, EventArgs e)
        {
            GiangVien view = new GiangVien();
            view.Show();
        }
        private void buttonX8_Click(object sender, EventArgs e)
        {
            Khoa k = new Khoa();
            k.Show();
        }

        private void buttonX9_Click(object sender, EventArgs e)
        {
            MonHoc mh = new MonHoc();
            mh.Show();
        }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void mởToolStripMenuItem_Click(object sender, EventArgs e)
        {
            qlhocvien f = new qlhocvien();
            f.Show();
        }

        private void thoátHoànToànToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {

                DialogResult ok;
                ok = MessageBox.Show("Bạn Có Chắc Muốn Thoát khỏi Chương trình", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ok == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    return;
                }



            }
            catch
            {
                MessageBox.Show("Bắt Lỗi: Exception  ");

            }
        }


        private void qlhocvien_Resize(object sender, EventArgs e)
        {
            try
            {

                // Nếu Form đang Minimize thì ẩn luôn Form
                if (FormWindowState.Minimized == WindowState)
                    Hide();



            }
            catch
            {
                MessageBox.Show("Bắt Lỗi: Exception  ");

            }      

            

        }

        private void buttonX10_Click(object sender, EventArgs e)
        {
            Process file = new Process();
            file.StartInfo.FileName = "WINWORD.EXE";
            file.StartInfo.Arguments = "huongdan.docx";
            file.Start();
        }

        private void buttonItem7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




        





        



























    }
}
