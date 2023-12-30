using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace QLPKT
{
    public partial class Invoice_buy_add : Form
    {
        public SqlConnection conn;
        string mahd;
        int i;
        DataTable dtdata;
        DataTable d; //bang truyen vao tu inv view
        int j;


        public Invoice_buy_add()
        {
            InitializeComponent();
            Connect c = new Connect();
            conn = c.GetConnect();
            buttom_addnew.Visible = true;
            buttom_confirm.Visible = true;
            newdata();
        }

        public void Invoice_buy_add_Load(object sender, EventArgs e)
        {
            Ngay_Load();
            employee_Load();
            NCU_Load();
            sanpham_Load();
            sanxuat_Load();
            tinhtrang.Enabled = false;
            tinhtrang.Text = "Chưa xác nhận";

            sanpham.Text = "Chọn";
            sanxuat.Text = "Chọn";
            //ngdat.Text = "Chọn";
            //ngnhan.Text = "Chọn";
            //nhacu.Text = "Chọn";
            DateTime date = DateTime.Today;
            day.Text = date.Day.ToString();
            month.Text = date.Month.ToString();
            year.Text = date.Year.ToString();

            buttom_change.Enabled = false;
            buttom_change.BackgroundImage = Image.FromFile(@"Image\buttom_change3.png");
            buttom_delete.Enabled = false;
            buttom_delete.BackgroundImage = Image.FromFile(@"Image\buttom_delete3.png");

            if (j != 0)
                set(d, j);
        }

        public void set(DataTable d1, int j1)
        {
            d = d1;
            j = j1;
            buttom_addnew.Visible = false;
            buttom_confirm.Visible = false;

            id.Text = d.Rows[j][0].ToString();
            mahd = id.Text;
            string ngay = d.Rows[j][1].ToString();
            string[] kq = ngay.Split('/');
            day.Text = kq[0];
            month.Text = kq[1];
            year.Text = kq[2];
            string idngdat = d.Rows[j][2].ToString();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Admin where MaAD='" + idngdat + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ngdat.Text = (string)reader["HoTen"];
            }
            reader.Close();
            string idngnhan = d.Rows[j][3].ToString();
            cmd.CommandText = "select * from Admin where MaAD='" + idngnhan + "'";
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ngnhan.Text = (string)reader["HoTen"];
            }
            reader.Close();
            tinhtrang.Text = d.Rows[j][4].ToString();
            string macu = d.Rows[j][5].ToString();
            cmd.CommandText = "select * from NhaCungUng where MaCU ='" + macu + "'";
            reader = cmd.ExecuteReader();
            string ncu;
            if (reader.Read())
            {
                diachi.Text = (string)reader["DiaChi"];
                dt.Text = (string)reader["DT"];
                ncu = (string)reader["TenNCU"];
                reader.Close();
                conn.Close();
                reader.Close();
                conn.Close();
            }
            else
                reader.Close();
            conn.Close();
            conn.Open();
            cmd.CommandText = "select TenSP,TenSX,SLMua,ChiTietHoaDonMua.GiaMua,(SLMua*ChiTietHoaDonMua.GiaMua)as ThanhTien,ChiTietHoaDonMua.MaSP,ChiTietHoaDonMua.MaSX from ChiTietHoaDonMua join SanPham on ChiTietHoaDonMua.MaSP=SanPham.MaSP join NhaSanXuat on SanPham.MaSX=NhaSanXuat.MaSX where MaHDMua='" + id.Text + "'";
            reader = cmd.ExecuteReader();
            newdata();
            while (reader.Read())
            {
                DataRow r = dtdata.NewRow();
                r["MaSP"] = reader["MaSP"].ToString();
                r["TenSP"] = reader["TenSP"].ToString();
                r["MaSX"] = reader["MaSX"].ToString();
                r["TenSX"] = reader["TenSX"].ToString();
                r["SLMua"] = (int)reader["SLMua"];
                r["GiaMua"] = (int)reader["GiaMua"];
                r["ThanhTien"] = (int)reader["ThanhTien"];
                dtdata.Rows.Add(r);
                data.DataSource = dtdata.DefaultView;
            }
            reader.Close();
            conn.Close();
            ngay = d.Rows[i][6].ToString();
            if (ngay != "")
            {
                kq = ngay.Split('/');
                day2.Text = kq[0];
                month2.Text = kq[1];
                year2.Text = kq[2];
            }
        }

        private void buttom_add_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from NhaSanXuat where TenSX like '%" + sanxuat.Text + "%'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (!reader.Read())
            {
                reader.Close();
                cmd.CommandText = "insert NhaSanXuat(MaSX,TenSX) values ('',@ten)";
                cmd.Parameters.AddWithValue("@ten", sanxuat.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                sanxuat_Load();
            }
            else
            {
                reader.Close();
                conn.Close();
            }

            conn.Open();
            cmd.CommandText = "select * from SanPham where TenSP like '%" + sanpham.Text + "%'";
            reader = cmd.ExecuteReader();
            if (!reader.Read())
            {
                reader.Close();
                cmd.CommandText = "insert SanPham(MaSP,MaSX,TenSP) values ('',@masx,@ten)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@masx", sanxuat.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@ten", sanpham.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                sanpham_Load();
            }
            else
            {
                reader.Close();
                conn.Close();
            }


            if (sl.Text.Length == 0 || gia.Text.Length == 0)
            {
                info.Text = "Error!";
                if (sl.Text.Length == 0)
                    error.SetError(sl, "Not null!");
                else
                    error.Clear();

                if (gia.Text.Length == 0)
                    error1.SetError(gia, "Not null!");
                else
                    error1.Clear();
            }
            else
            {
                error.Clear();
                error1.Clear();
                DataRow[] rows = dtdata.Select("MaSP = '" + sanpham.SelectedValue.ToString() + "'");
                if (rows.Length == 0)
                {
                    DataRow r = dtdata.NewRow();
                    r["MaSP"] = sanpham.SelectedValue.ToString();
                    r["TenSP"] = sanpham.Text;
                    r["MaSX"] = sanxuat.SelectedValue.ToString();
                    r["TenSX"] = sanxuat.Text;
                    r["SLMua"] = int.Parse(sl.Text);
                    r["GiaMua"] = int.Parse(gia.Text);
                    r["ThanhTien"] = int.Parse(sl.Text) * int.Parse(gia.Text);
                    dtdata.Rows.Add(r);
                    data.DataSource = dtdata.DefaultView;
                    dataview(0);
                    info.Text = "Add success!";
                    buttom_addnewpro_Click(sender, e);
                }
                else
                    MessageBox.Show("Sản phẩm này đã có trong hóa đơn! ", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                object sum = dtdata.Compute("sum(SLMua)", "SLMua>0");
                tongsl.Text = sum.ToString();
                sum = dtdata.Compute("sum(ThanhTien)", "SLMua>0");
                tongt.Text = sum.ToString();

            }
        }

        private void buttom_save_Click(object sender, EventArgs e)
        {
            if (diachi.Text.Length == 0 || dt.Text.Length == 0)
                err.Text = "Save not success! Please check again!";
            else
            {
                if (id.Text.Length == 0)
                {
                    bool ktr = false;
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("select * from NhaCungUng where TenNCU like '%" + nhacu.Text + "%'", conn);
                    SqlDataReader r = cmd.ExecuteReader();
                    if (!r.Read())
                    {
                        r.Close();
                        cmd.CommandText = "insert NhaCungUng(MaCU,TenNCU,DiaChi,DT) values ('',@ten,@diachi,@dt)";
                        cmd.Parameters.AddWithValue("@ten", nhacu.Text);
                        cmd.Parameters.AddWithValue("@diachi", diachi.Text);
                        cmd.Parameters.AddWithValue("@dt", dt.Text);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        ktr = true;
                        NCU_Load();
                    }
                    r.Close();
                    if (ktr == true)
                        conn.Open();
                    cmd.CommandText = "insert HoaDonMua(MaHDMua,NgayMua,NguoiDat,NguoiNhan,TinhTrang,NhaCungUng) values ('',@ngay,@dat,@nhan,@tt,@ncu)";
                    cmd.Parameters.AddWithValue("@ngay", month.Text + "/" + day.Text + "/" + year.Text);
                    cmd.Parameters.AddWithValue("@dat", ngdat.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@nhan", ngnhan.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@tt", tinhtrang.Text);
                    cmd.Parameters.AddWithValue("@ncu", nhacu.SelectedValue.ToString());
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "select top(1) MaHDMua from HoaDonMua order by MaHDMua desc";
                    mahd = (string)cmd.ExecuteScalar();
                    id.Text = mahd;

                    foreach (DataRow row in dtdata.Rows)
                    {
                        cmd.CommandText = "insert ChiTietHoaDonMua(MaHDMua,MaSP,MaSX,SLMua,GiaMua) values (@mahd,@sp,@sx,@sl,@gia)";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@mahd", mahd);
                        cmd.Parameters.AddWithValue("@sp", row["MaSP"]);
                        cmd.Parameters.AddWithValue("@sx", row["MaSX"]);
                        cmd.Parameters.AddWithValue("@sl", row["SLMua"]);
                        cmd.Parameters.AddWithValue("@gia", row["GiaMua"]);
                        cmd.ExecuteNonQuery();
                    }

                    conn.Close();
                    err.Text = "Save success!";
                }
                else
                {
                    bool kt = false;
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("select * from NhaCungUng where TenNCU like '%" + nhacu.Text + "%'", conn);
                    SqlDataReader r = cmd.ExecuteReader();
                    if (!r.Read())
                    {
                        r.Close();
                        cmd.CommandText = "insert NhaCungUng(MaCU,TenNCU,DiaChi,DT) values ('',@ten,@diachi,@dt)";
                        cmd.Parameters.AddWithValue("@ten", nhacu.Text);
                        cmd.Parameters.AddWithValue("@diachi", diachi.Text);
                        cmd.Parameters.AddWithValue("@dt", dt.Text);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        kt = true;
                        NCU_Load();
                    }
                    r.Close();
                    if (kt == true)
                        conn.Open();
                    cmd.CommandText = "update HoaDonMua set NgayMua=@ngay,NguoiDat=@dat,NguoiNhan=@nhan,NhaCungUng=@ncu where MaHDMua=@mahd";
                    cmd.Parameters.AddWithValue("@ngay", month.Text + "/" + day.Text + "/" + year.Text);
                    cmd.Parameters.AddWithValue("@dat", ngdat.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@nhan", ngnhan.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@ncu", nhacu.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@mahd", id.Text);
                    cmd.ExecuteNonQuery();
                    foreach (DataRow row in dtdata.Rows)
                    {
                        cmd.CommandText = "select MaSP from ChiTietHoaDonMua where MaHDMua=@mahd and MaSP=@masp";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@mahd", mahd);
                        cmd.Parameters.AddWithValue("@masp", row["MaSP"]);
                        r = cmd.ExecuteReader();
                        bool check = r.Read(); r.Close();
                        if (check)
                        {
                            cmd.CommandText = "update ChiTietHoaDonMua set SLMua=@sl,GiaMua=@gia where MaHDMua=@mahd and MaSP=@masp";
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@mahd", mahd);
                            cmd.Parameters.AddWithValue("@masp", row["MaSP"]);
                            cmd.Parameters.AddWithValue("@sl", row["SLMua"]);
                            cmd.Parameters.AddWithValue("@gia", row["GiaMua"]);
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            cmd.CommandText = "insert ChiTietHoaDonMua(MaHDMua,MaSP,MaSX,SLMua,GiaMua) values (@mahd,@sp,@sx,@sl,@gia)";
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@mahd", mahd);
                            cmd.Parameters.AddWithValue("@sp", row["MaSP"]);
                            cmd.Parameters.AddWithValue("@sx", row["MaSX"]);
                            cmd.Parameters.AddWithValue("@sl", row["SLMua"]);
                            cmd.Parameters.AddWithValue("@gia", row["GiaMua"]);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    conn.Close();
                    err.Text = "Save success!";
                }
            }

        }

        private void buttom_change_Click(object sender, EventArgs e)
        {
            DataRow[] rows = dtdata.Select("MaSP = '" + sanpham.SelectedValue.ToString() + "'");
            for (int i = 0; i < rows.Length; i++)
            {
                rows[i]["SLMua"] = sl.Text;
                rows[i]["GiaMua"] = gia.Text;
            }
        }

        private void buttom_delete_Click(object sender, EventArgs e)
        {
            dtdata.Rows.RemoveAt(i);
            data.DataSource = dtdata.DefaultView;
            info.Text = "Delete success!";
        }

        private void buttom_confirm_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select TinhTrang from HoaDonMua where MaHDMua=@mahd", conn);
            cmd.Parameters.AddWithValue("@mahd", mahd);
            SqlDataReader r = cmd.ExecuteReader();
            if (r.Read())
            {

                if ((string)r["TinhTrang"] == "Chưa xác nhận")
                {
                    DateTime date = DateTime.Today;
                    day2.Text = date.Day.ToString();
                    month2.Text = date.Month.ToString();
                    year2.Text = date.Year.ToString();

                    r.Close();
                    cmd.CommandText = "update HoaDonMua set TinhTrang=@tt,NgayNhan=@day where MaHDMua=@mahd";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@mahd", mahd);
                    cmd.Parameters.AddWithValue("@tt", "Đã xác nhận");
                    cmd.Parameters.AddWithValue("@day", month2.Text + "/" + day2.Text + "/" + year2.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    tinhtrang.Text = "Đã xác nhận";
                    buttom_save.Enabled = false;
                    buttom_save.BackgroundImage = Image.FromFile(@"Image\buttom_save3.png");

                    //cap nhat kho
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
                else
                    MessageBox.Show("Hóa đơn này đã được xác nhận!", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            r.Close();
            conn.Close();
        }

        private void buttom_addnew_Click(object sender, EventArgs e)
        {
            id.Text = "";
            err.Text = "";
            dtdata = new DataTable();
            data.DataSource = dtdata.DefaultView;
            tinhtrang.Text = "Chưa xác nhận";
            buttom_save.Enabled = true;
            buttom_save.BackgroundImage = Image.FromFile(@"Image\buttom_save.png");
            newdata();
        }

        private void buttom_addnewpro_Click(object sender, EventArgs e)
        {
            sl.Text = "";
            gia.Text = "";
            info.Text = "";
            buttom_add.Enabled = true;
            buttom_add.BackgroundImage = Image.FromFile(@"Image\buttom_add.png");
            buttom_change.Enabled = false;
            buttom_change.BackgroundImage = Image.FromFile(@"Image\buttom_change3.png");
            buttom_delete.Enabled = false;
            buttom_delete.BackgroundImage = Image.FromFile(@"Image\buttom_delete3.png");
        }

        // Load dữ liệu
        private void dataview(int i)
        {
            sanxuat.Text = dtdata.Rows[i][1].ToString();
            sanpham.Text = dtdata.Rows[i][0].ToString();
            sl.Text = dtdata.Rows[i][2].ToString();
            gia.Text = dtdata.Rows[i][3].ToString();
        }

        private void sl_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(sl.Text, @"^[0-9]+$"))
                error.Clear();
            else
                error.SetError(sl, "Only type number!");
        }

        private void gia_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(gia.Text, @"^[0-9]+$"))
                error.Clear();
            else
                error.SetError(gia, "Only type number!");
        }

        private void sanxuat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sanxuat.Text != "")
            {
                SqlDataAdapter adapter;
                adapter = new SqlDataAdapter("select * from SanPham where MaSX='" + sanxuat.SelectedValue.ToString() + "' order by MaSP desc", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                adapter.Dispose();
                sanpham.DisplayMember = "TenSP";
                sanpham.ValueMember = "MaSP";
                sanpham.DataSource = dt.DefaultView;
            }
        }

        private void VA_p_Click(object sender, EventArgs e)
        {
            VA_products f = new VA_products();
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
            {
                sanxuat_SelectedIndexChanged(sender, e);
                sanpham.Text = f.getdata();
            }
        }

        private void VA_b_Click(object sender, EventArgs e)
        {
            VA_brand f = new VA_brand();
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
            {
                sanxuat_Load();
                sanxuat.Text = f.getdata();
            }
        }

        public void newdata()
        {
            dtdata = new DataTable();
            DataColumn TenSP = new DataColumn("TenSP", typeof(string));
            dtdata.Columns.Add(TenSP);
            DataColumn TenSX = new DataColumn("TenSX", typeof(string));
            dtdata.Columns.Add(TenSX);
            DataColumn SlBan = new DataColumn("SLMua", typeof(int));
            dtdata.Columns.Add(SlBan);
            DataColumn GiaBan = new DataColumn("GiaMua", typeof(int));
            dtdata.Columns.Add(GiaBan);
            DataColumn ThanhTien = new DataColumn("ThanhTien", typeof(int));
            dtdata.Columns.Add(ThanhTien);
            DataColumn MaSP = new DataColumn("MaSP", typeof(string));
            dtdata.Columns.Add(MaSP);
            DataColumn MaSX = new DataColumn("MaSX", typeof(string));
            dtdata.Columns.Add(MaSX);
        }

        protected void employee_Load()
        {
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter("select * from Admin", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            adapter.Dispose();
            ngdat.DisplayMember = "HoTen";
            ngdat.ValueMember = "MaAD";
            ngdat.DataSource = dt.DefaultView;
            adapter = new SqlDataAdapter("select * from Admin", conn);
            DataTable dt2 = new DataTable();
            adapter.Fill(dt2);
            ngnhan.DisplayMember = "HoTen";
            ngnhan.ValueMember = "MaAD";
            ngnhan.DataSource = dt2.DefaultView;

        }

        protected void NCU_Load()
        {
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter("select * from NhaCungUng order by MaCU desc", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            adapter.Dispose();
            nhacu.DisplayMember = "TenNCU";
            nhacu.ValueMember = "MaCU";
            nhacu.DataSource = dt.DefaultView;
        }

        protected void sanpham_Load()
        {
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter("select * from SanPham order by MaSP desc", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            adapter.Dispose();
            sanpham.DisplayMember = "TenSP";
            sanpham.ValueMember = "MaSP";
            sanpham.DataSource = dt.DefaultView;
        }

        protected void sanxuat_Load()
        {
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter("select * from NhaSanXuat order by MaSX desc", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            adapter.Dispose();
            sanxuat.DisplayMember = "TenSX";
            sanxuat.ValueMember = "MaSX";
            sanxuat.DataSource = dt.DefaultView;
        }

        private void day_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select* from Thang where @ngay<=Ngay", conn);
            cmd.Parameters.AddWithValue("@ngay", day.SelectedValue);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            adapter.Dispose();
            month.DisplayMember = "Thang";
            month.ValueMember = "Thang";
            month.DataSource = dt.DefaultView;
        }

        protected void Ngay_Load()
        {
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter("select Ngay from Ngay", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            adapter.Dispose();
            day.DisplayMember = "Ngay";
            day.ValueMember = "Ngay";
            day.DataSource = dt.DefaultView;
        }

        private void month_SelectedIndexChanged(object sender, EventArgs e)
        {
            int d = int.Parse(day.SelectedValue.ToString());
            int m = int.Parse(month.SelectedValue.ToString());
            if (d == 29 && m == 2)
            {
                string sql = "select* from NamNhuan";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                adapter.Dispose();
                year.DisplayMember = "Nam";
                year.ValueMember = "Nam";
                year.DataSource = dt.DefaultView;
            }
            else
            {
                string sql = "select* from Nam";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                adapter.Dispose();
                year.DisplayMember = "Nam";
                year.ValueMember = "Nam";
                year.DataSource = dt.DefaultView;
            }
        }

        private void nhacu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nhacu.SelectedValue.ToString() == "NCU00")
            {
                diachi.Enabled = true;
                dt.Enabled = true;
                diachi.Text = "";
                dt.Text = "";
            }
            else
            {
                diachi.Enabled = false;
                dt.Enabled = false;
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from NhaCungUng where MaCU='" + nhacu.SelectedValue.ToString() + "'", conn);
                SqlDataReader r = cmd.ExecuteReader();
                if (r.Read())
                {
                    diachi.Text = (string)r["DiaChi"];
                    dt.Text = (string)r["DT"];
                    r.Close();
                }
                r.Close();
                conn.Close();
            }
        }

        private void diachi_TextChanged(object sender, EventArgs e)
        {
            if (diachi.Text.Length == 0)
                error.SetError(diachi, "Not null!");
            else
                error.Clear();
        }

        private void dt_TextChanged(object sender, EventArgs e)
        {
            if (dt.Text.Length == 0)
                error.SetError(dt, "Not null!");
            else
                error.Clear();
        }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            if (i >= 0)
            {
                dataview(i);
            }
            buttom_add.Enabled = false;
            buttom_add.BackgroundImage = Image.FromFile(@"Image\buttom_add3.png");
            buttom_change.Enabled = true;
            buttom_change.BackgroundImage = Image.FromFile(@"Image\buttom_change.png");
            buttom_delete.Enabled = true;
            buttom_delete.BackgroundImage = Image.FromFile(@"Image\buttom_delete.png");
        }

    }
}
