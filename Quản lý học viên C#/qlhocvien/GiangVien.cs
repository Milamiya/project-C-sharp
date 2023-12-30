using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace qlhocvien
{
    public partial class GiangVien : DevComponents.DotNetBar.Office2007Form
    {
        DataSet ds = new DataSet();
        OleDbConnection cnn = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        string sql;
        public GiangVien()
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
        private void GiangVien_Load(object sender, EventArgs e)
        {
            try
            {


            Ketnoi();

            sql = "Select * From GiangVien";
            OleDbCommand cmd = new OleDbCommand(sql, cnn);
            OleDbDataReader reader = cmd.ExecuteReader();
            reader.Read();
            txtmagv.Text = reader["MaGV"].ToString();
            txttengv.Text = reader["TenGV"].ToString();
            cbmakhoagv.Text = reader["MaKhoa"].ToString();
            cbmamh.Text = reader["MaMH"].ToString();
            reader.Close();
            OleDbDataAdapter sda = new OleDbDataAdapter();
            sda.SelectCommand = cmd;
            sda.Fill(ds, "GiangVien");
            DataTable dtb = ds.Tables["GiangVien"];
            showdatagv.DataSource = dtb;

            cnn.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Lỗi Kết Nối, Vui Lòng Thử Lại");
            }
        }
        public void DanhSachGV()
        {

            string sql = "SELECT * FROM GiangVien";
            DataTable dt = ketnoi.ExecuteQuery(sql);
            this.showdatagv.DataSource = dt;
        }
        private void showdatagv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
             DataGridViewRow row = new DataGridViewRow();

            row = showdatagv.Rows[e.RowIndex];
            txtmagv.Text = row.Cells[0].Value.ToString();
            txttengv.Text = row.Cells[1].Value.ToString();
            cbmakhoagv.Text = row.Cells[2].Value.ToString();
            cbmamh.Text = row.Cells[3].Value.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Hãy Click Vào Giảng Viên Bạn Muốn Sửa");
            }
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            try
            {
                txtmagv.Text = "";
                txttengv.Text = "";
                cbmakhoagv.Text = "[--Chọn Một--]";
                cbmamh.Text = "[--Chọn Một--]";
                
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
                if (txtmagv.Text != "")
                {

                    DialogResult ok;
                    ok = MessageBox.Show("Bạn thực sự muốn xóa Giảng Viên: " + txttengv.Text + " có mã số :" + txtmagv.Text + " chứ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ok == DialogResult.Yes)
                    {
                        Ketnoi();
                        string sql = "";
                        sql = "delete from GiangVien where MaGV='" + txtmagv.Text + "'";
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                        cnn.Close();
                        this.DanhSachGV();
                    }
                    else
                    {
                        return;
                    }

                }
                else
                    MessageBox.Show("Hãy Chọn Mã Giảng Viên Cần Xóa");

            }
            catch(Exception ex)
            {
                MessageBox.Show(" Lỗi:   "+ex.Message);

            }
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmagv.Text == "" || txttengv.Text == "" || cbmakhoagv.Text == "[--Chọn Một--]" || cbmamh.Text == "[--Chọn Một--]" || cbmakhoagv.Text == "" || cbmamh.Text == "")
                {
                    MessageBox.Show("Phải Nhập đủ Thông Tin");
                }

                else if (txtmagv.Text != "")
                {
                    Ketnoi();
                    string sql = "";
                    sql = "UPDATE GiangVien SET TenGV ='" + txttengv.Text + "',MaKhoa ='" + cbmakhoagv.Text + "', MaMH ='" + cbmamh.Text + "' WHERE MaGV='" + txtmagv.Text + "'";
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Đã Sữa Giảng Viên " + txttengv.Text + " Thành Công");

                    cnn.Close();
                    this.DanhSachGV();
                }
                else
                {
                    MessageBox.Show("Hãy Nhập Thông Tin Vào Box ...", "Thông báo");
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Có Lỗi :"+ex.Message);
                cnn.Close();
            }
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmagv.Text == "" || txttengv.Text == "" || cbmakhoagv.Text == "" || cbmamh.Text == "" || cbmamh.Text == "[--Chọn Một--]" || cbmamh.Text == "[--Chọn Một--]")
                    {
                        MessageBox.Show("Bạn chưa nhập đủ điều kiện", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txtmagv.Text.ToString().Length > 5)
                    {
                        MessageBox.Show("Mã Giảng viên không được quá năm kí tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtmagv.Text = "";
                    }
                    else if (txttengv.Text.ToString().Length > 20)
                    {
                        MessageBox.Show("Tên giảng viên phải Nhỏ Hơn 20 Ký Tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txttengv.Text = "";
                    }



                    else
                    {


                            Ketnoi();
                            string sql = "";
                            sql = "INSERT INTO GiangVien(MaGV,TenGV,MaKhoa,MaMH) VALUES('" + txtmagv.Text + "','" + txttengv.Text + "','" + cbmakhoagv.Text + "','" + cbmamh.Text + "')";

                            cmd.CommandText = sql;

                            MessageBox.Show("Lưu thành công Giảng Viên : " + txtmagv.Text + " ");

                            cmd.ExecuteNonQuery();

                            cnn.Close();
                            this.DanhSachGV();

                    }
                }
          catch(Exception ex)
          {
              MessageBox.Show("Lỗi: "+ex.Message);
              cnn.Close();
          }
        }

        private void timgv_Click(object sender, EventArgs e)
        {
            string mgv = "Tìm Theo MãGV", tgv = "Tìm Theo Tên";
            ketnoi a = new ketnoi();
            OleDbConnection con = a.data();
            con.Open();
            string tim = "";
            tim = Convert.ToString(txtsearch.Text);

            try
            {
                if (txtsearch.Text != "")
                {
                    if (cbsearch.Text == mgv)
                    {
                        string ketqua = " select * from GiangVien where MaGV like '%" + tim + "%'";
                        OleDbCommand cmd = new OleDbCommand(ketqua, con);

                        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "GiangVien");
                        showdatagv.DataSource = ds.Tables["GiangVien"].DefaultView;
                    }
                    else if (cbsearch.Text == tgv)
                    {
                        string ketqua = " select * from GiangVien where TenGV like '%" + tim + "%'";
                        OleDbCommand cmd = new OleDbCommand(ketqua, con);

                        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "GiangVien");
                        showdatagv.DataSource = ds.Tables["GiangVien"].DefaultView;
                    }
                    else

                        MessageBox.Show("Vui Lòng Chọn Tìm Theo Mã Giảng Viên Hoặc Theo Tên Giảng Viên");
                }
                else
                    MessageBox.Show("Hãy Nhập Từ Khóa Cần Tìm!!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi" + ex.Message);
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.DanhSachGV();
        }
    }
}
