using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLPKT
{
    public partial class Invoice_buy_view : Form
    {
        SqlConnection conn;
        DataTable dt;
        int i;
        string name;
        string idemp;

        public Invoice_buy_view(string name1, string idemp1)
        {
            name = name1;
            idemp = idemp1;
            InitializeComponent();
            Connect c = new Connect();
            conn = c.GetConnect();
            type.Text = "Tình trạng";
        }

        private void Invoice_buy_view_Load(object sender, EventArgs e)
        {
            buttom_change.Enabled = false;
            buttom_change.BackgroundImage = Image.FromFile(@"Image\buttom_change3.png");
            buttom_confirm.Enabled = false;
            buttom_confirm.BackgroundImage = Image.FromFile(@"Image\buttom_confirm3.png");
            buttom_delete.Enabled = false;
            buttom_delete.BackgroundImage = Image.FromFile(@"Image\buttom_delete3.png");
        }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            if (i >= 0)
            {
                dataview(i);
            }
        }

        private void dataview(int i)
        {
            buttom_confirm.Enabled = true;
            buttom_confirm.BackgroundImage = Image.FromFile(@"Image\buttom_confirm.png");

            id.Text = dt.Rows[i][0].ToString();
            string ngay = dt.Rows[i][1].ToString();
            string[] kq = ngay.Split('/');
            day.Text = kq[0];
            month.Text = kq[1];
            year.Text = kq[2];
            idngdat.Text = dt.Rows[i][2].ToString();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Admin where MaAD='" + idngdat.Text + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ngdat.Text = (string)reader["HoTen"];
            }
            reader.Close();
            idngnhan.Text = dt.Rows[i][3].ToString();
            ngnhan.Text = "";
            cmd.CommandText="select * from Admin where MaAD='" + idngnhan.Text + "'";
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ngnhan.Text = (string)reader["HoTen"];
            }
            reader.Close();
            tinhtrang.Text = dt.Rows[i][4].ToString();
            if (tinhtrang.Text == "Đã xác nhận")
            {
                buttom_confirm.Visible = false;
                buttom_unconfirm.Visible = true;
                buttom_change.Enabled = false;
                buttom_change.BackgroundImage = Image.FromFile(@"Image\buttom_change3.png");
            }
            else
            {
                buttom_confirm.Visible = true;
                buttom_unconfirm.Visible = false;
                buttom_change.Enabled = true;
                buttom_change.BackgroundImage = Image.FromFile(@"Image\buttom_change.png");
            }
            string macu = dt.Rows[i][5].ToString();
            cmd.CommandText = "select * from NhaCungUng where MaCU ='" + macu + "'";
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ncu.Text = (string)reader["TenNCU"];
                diachi.Text = (string)reader["DiaChi"];
                sdt.Text = (string)reader["DT"];
            }
            reader.Close();
            conn.Close();
            cmd.CommandText = "select TenSP,SLMua,ChiTietHoaDonMua.GiaMua from ChiTietHoaDonMua join SanPham on ChiTietHoaDonMua.MaSP=SanPham.MaSP where MaHDMua='" + id.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtd = new DataTable();
            adapter.Fill(dtd);
            adapter.Dispose();
            datadetail.DataSource = dtd;
            ngay = dt.Rows[i][6].ToString();
            if (ngay != "")
            {
                kq = ngay.Split('/');
                if (kq[2] != "1900")
                {
                    day2.Text = kq[0];
                    month2.Text = kq[1];
                    year2.Text = kq[2];
                }
                else
                {
                    day2.Text = "";
                    month2.Text = "";
                    year2.Text = "";
                }
            }

            buttom_delete.Enabled = true;
            buttom_delete.BackgroundImage = Image.FromFile(@"Image\buttom_delete.png");
        }

        private void buttom_confirm_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select TinhTrang from HoaDonMua where MaHDMua=@mahd", conn);
            cmd.Parameters.AddWithValue("@mahd", id.Text);
            SqlDataReader r = cmd.ExecuteReader();
            if (r.Read())
            {

                if ((string)r["TinhTrang"] == "Chưa xác nhận")
                {
                    if (idemp != idngnhan.Text && idngnhan.Text.Length != 0)
                    {
                        Confirm f = new Confirm("MB_DIRECTOR");
                        f.ShowDialog();
                        if (f.DialogResult == DialogResult.OK)
                        {
                            DateTime date = DateTime.Today;
                            day2.Text = date.Day.ToString();
                            month2.Text = date.Month.ToString();
                            year2.Text = date.Year.ToString();

                            r.Close();
                            cmd.CommandText = "update HoaDonMua set TinhTrang=@tt,NguoiNhan=@ngnhan,NgayNhan=@day where MaHDMua=@mahd";
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@mahd", id.Text);
                            cmd.Parameters.AddWithValue("@tt", "Đã xác nhận");
                            cmd.Parameters.AddWithValue("@day", month2.Text + "/" + day2.Text + "/" + year2.Text);
                            cmd.Parameters.AddWithValue("@ngnhan", idemp);
                            cmd.ExecuteNonQuery();
                            tinhtrang.Text = "Đã xác nhận";
                            idngnhan.Text = idemp;
                            ngnhan.Text = name;

                            DataRow[] rows = dt.Select("MaHDMua = '" + id.Text + "'");
                            for (int i = 0; i < rows.Length; i++)
                            {
                                rows[i]["TinhTrang"] = "Đã xác nhận";
                                rows[i]["NguoiNhan"] = idemp;
                            }

                            error.Text = "Confirm success!";
                            buttom_change.Enabled = false;
                            buttom_change.BackgroundImage = Image.FromFile(@"Image\buttom_change3.png");
                            buttom_confirm.Visible = false;
                            buttom_unconfirm.Visible = true;

                            conn.Close();
                            //Cập nhật kho hàng
                            SqlDataAdapter adapter = new SqlDataAdapter("select * from ChiTietHoaDonMua where MaHDMua='" + id.Text + "'", conn);
                            DataTable dtsp = new DataTable();
                            adapter.Fill(dtsp);
                            adapter.Dispose();
                            conn.Open();
                            foreach (DataRow row in dtsp.Rows)
                            {
                                cmd.CommandText = "update SanPham set SLTon=SLTon+" + (int)row["SLMua"] + ",GiaMua=" + (int)row["GiaMua"] + "where MaSP='" + (string)row["MaSP"] + "'";
                                cmd.ExecuteNonQuery();
                            }
                            conn.Close();
                        }
                    }
                    else
                    {
                        DateTime date = DateTime.Today;
                        day2.Text = date.Day.ToString();
                        month2.Text = date.Month.ToString();
                        year2.Text = date.Year.ToString();

                        r.Close();
                        cmd.CommandText = "update HoaDonMua set TinhTrang=@tt,NguoiNhan=@ngnhan,NgayNhan=@day where MaHDMua=@mahd";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@mahd", id.Text);
                        cmd.Parameters.AddWithValue("@tt", "Đã xác nhận");
                        cmd.Parameters.AddWithValue("@day", month2.Text + "/" + day2.Text + "/" + year2.Text);
                        cmd.Parameters.AddWithValue("@ngnhan", idemp);
                        cmd.ExecuteNonQuery();
                        tinhtrang.Text = "Đã xác nhận";
                        idngnhan.Text = idemp;
                        ngnhan.Text = name;

                        DataRow[] rows = dt.Select("MaHDMua = '" + id.Text + "'");
                        for (int i = 0; i < rows.Length; i++)
                        {
                            rows[i]["TinhTrang"] = "Đã xác nhận";
                            rows[i]["NguoiNhan"] = idemp;
                        }

                        error.Text = "Confirm success!";
                        buttom_change.Enabled = false;
                        buttom_change.BackgroundImage = Image.FromFile(@"Image\buttom_change3.png");
                        buttom_confirm.Visible = false;
                        buttom_unconfirm.Visible = true;

                        conn.Close();
                        //Cập nhật kho hàng
                        SqlDataAdapter adapter = new SqlDataAdapter("select * from ChiTietHoaDonMua where MaHDMua='" + id.Text + "'", conn);
                        DataTable dtsp = new DataTable();
                        adapter.Fill(dtsp);
                        adapter.Dispose();
                        conn.Open();
                        foreach (DataRow row in dtsp.Rows)
                        {
                            cmd.CommandText = "update SanPham set SLTon=SLTon+" + (int)row["SLMua"] + ",GiaMua=" + (int)row["GiaMua"] + "where MaSP='" + (string)row["MaSP"] + "'";
                            cmd.ExecuteNonQuery();
                        }
                        conn.Close();
                    }
                }
                else
                    MessageBox.Show("Hóa đơn này đã được xác nhận!", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            r.Close();
            conn.Close();

                
        }

        private void buttom_unconfirm_Click(object sender, EventArgs e)
        {
            Confirm f = new Confirm("MB_DIRECTOR");
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
            {
                DateTime date = DateTime.Today;
                day2.Text = "";
                month2.Text = "";
                year2.Text = "";

                conn.Open();
                SqlCommand cmd = new SqlCommand("update HoaDonMua set TinhTrang=@tt,NguoiNhan=@ngnhan,NgayNhan=@day where MaHDMua=@mahd",conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@mahd", id.Text);
                cmd.Parameters.AddWithValue("@tt", "Chưa xác nhận");
                cmd.Parameters.AddWithValue("@day", "");
                cmd.Parameters.AddWithValue("@ngnhan", "");
                cmd.ExecuteNonQuery();
                tinhtrang.Text = "Chưa xác nhận";
                idngnhan.Text = "";
                ngnhan.Text = "";

                DataRow[] rows = dt.Select("MaHDMua = '" + id.Text + "'");
                for (int i = 0; i < rows.Length; i++)
                {
                    rows[i]["TinhTrang"] = "Chưa xác nhận";
                    rows[i]["NguoiNhan"] = "";
                }

                error.Text = "Unconfirm success!";
                buttom_change.Enabled = true;
                buttom_change.BackgroundImage = Image.FromFile(@"Image\buttom_change.png");
                buttom_confirm.Visible = true;
                buttom_unconfirm.Visible = false;

                conn.Close();
                //Cập nhật kho hàng
                SqlDataAdapter adapter = new SqlDataAdapter("select * from ChiTietHoaDonMua where MaHDMua='" + id.Text + "'", conn);
                DataTable dtsp = new DataTable();
                adapter.Fill(dtsp);
                adapter.Dispose();
                conn.Open();
                foreach (DataRow row in dtsp.Rows)
                {
                    cmd.CommandText = "update SanPham set SLTon=SLTon-" + (int)row["SLMua"] + ",GiaMua=" + (int)row["GiaMua"] + "where MaSP='" + (string)row["MaSP"] + "'";
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        private void buttom_delete_Click(object sender, EventArgs e)
        {
            if (tinhtrang.Text == "Chưa xác nhận")
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("delete from HoaDonMua where MaHDMua='" + id.Text + "'", conn);
                cmd.ExecuteNonQuery();
                cmd.CommandText = "delete from ChiTietHoaDonMua where MaHDMua='" + id.Text + "'";
                cmd.ExecuteNonQuery();
                conn.Close();
                dt.Rows.RemoveAt(i);
            }
            else
                error.Text = "Not alow delete this invoice!";

        }

        private void buttom_change_Click(object sender, EventArgs e)
        {
            if (tinhtrang.Text != "Đã xác nhận")
            {
                if (idngdat.Text != idemp || idngnhan.Text != idemp)
                {
                    Confirm f1 = new Confirm("MB_DIRECTOR");
                    f1.ShowDialog();
                    if (f1.DialogResult == DialogResult.OK)
                    {
                        Invoice_buy_add f = new Invoice_buy_add();
                        f.Invoice_buy_add_Load(sender, e);
                        f.set(dt, i);
                        f.ShowDialog();
                    }
                }
                else
                {
                    Invoice_buy_add f2 = new Invoice_buy_add();
                    f2.Invoice_buy_add_Load(sender, e);
                    f2.set(dt, i);
                    f2.ShowDialog();
                }
            }
            else
                MessageBox.Show("Hóa đơn này đã được xác nhận!", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void buttom_showall_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select MaHDMua,CONVERT(varchar, NgayMua, 103) as NgayMua,NguoiDat,NguoiNhan,TinhTrang,NhaCungUng,CONVERT(varchar, NgayNhan, 103) as NgayNhan from HoaDonMua order by NgayMua desc", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            adapter.Dispose();
            data.DataSource = dt;
        }

        private void searchwith(string type)
        {
            string sql = "select MaHDMua,CONVERT(varchar, NgayMua, 103) as NgayMua,NguoiDat,NguoiNhan,TinhTrang,NhaCungUng,CONVERT(varchar, NgayNhan, 103) as NgayNhan from HoaDonMua where " + type + " like N'%" + search.Text + search2.Text + "%' order by NgayMua desc";
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            adapter.Fill(dt);
            adapter.Dispose();
            data.DataSource = dt;
            if (dt.Rows.Count == 0)
                data.Visible = false;
            else data.Visible = true;
            ncu.Text = "";
            diachi.Text = "";
            sdt.Text = "";
            ngdat.Text = "";
            ngnhan.Text = "";
            id.Text = "";
            idngdat.Text = "";
            idngnhan.Text = "";
            tinhtrang.Text="";
            day.Text = "";
            month.Text = "";
            year.Text = "";
            buttom_change.Enabled = false;
            buttom_change.BackgroundImage = Image.FromFile(@"Image\buttom_change3.png");
            buttom_confirm.Enabled = false;
            buttom_confirm.BackgroundImage = Image.FromFile(@"Image\buttom_confirm3.png");
            buttom_delete.Enabled = false;
            buttom_delete.BackgroundImage = Image.FromFile(@"Image\buttom_delete3.png");
        }

        private void buttom_search_Click(object sender, EventArgs e)
        {
            if (type.Text == "MaHD")
            {
                searchwith("MaHDMua");
            }
            else if (type.Text == "Người đặt")
            {
                searchwith("NguoiDat");
            }
            else if (type.Text == "Ngày")
            {
                searchwith("NgayMua");
            }
            else if (type.Text == "Người nhận")
            {
                searchwith("NguoiNhan");
            }
            else if (type.Text == "Tình trạng")
            {
                searchwith("TinhTrang");
            }
        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (type.Text == "Ngày")
            {
                search2.Visible = false;
                search.Visible = true;
                note.Text = "Vui lòng nhập ngày theo định dạng mm-dd-yyyy để cho kết quả chính xác nhất!";
            }
            if (type.Text == "Người đặt")
            {
                search2.Visible = false;
                search.Visible = true;
                note.Text = "Hãy nhập mã số nhân viên của bạn để tìm kiếm những hóa đơn do bạn phụ trách!";
            }
            if (type.Text == "Người nhận")
            {
                search2.Visible = false;
                search.Visible = true;
                note.Text = "Hãy nhập mã số nhân viên của bạn để tìm kiếm những hóa đơn do bạn phụ trách!";
            }
            if (type.Text == "MaHD")
            {
                search2.Visible = false;
                search.Visible = true;
                note.Text = "Bạn chỉ cần nhập chuỗi số có trong hóa đơn là có thể tìm thấy hóa đơn bạn cần tìm!";
            }
            if (type.Text == "Tình trạng")
            {
                search2.Visible = true;
                search.Visible = false;
            }
            buttom_search.Enabled = false;
            buttom_search.BackgroundImage = Image.FromFile(@"Image\buttom_search3.png");
            search.Text = "";
            search2.Text = "";
        }

        private void search2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (search2.Text == "")
            {
                buttom_search.Enabled = false;
                buttom_search.BackgroundImage = Image.FromFile(@"Image\buttom_search3.png");
            }
            else
            {
                buttom_search.Enabled = true;
                buttom_search.BackgroundImage = Image.FromFile(@"Image\buttom_search.png");
            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            if (search.Text == "")
            {
                buttom_search.Enabled = false;
                buttom_search.BackgroundImage = Image.FromFile(@"Image\buttom_search3.png");
            }
            else
            {
                buttom_search.Enabled = true;
                buttom_search.BackgroundImage = Image.FromFile(@"Image\buttom_search.png");
            }
        }

        
    }
}
