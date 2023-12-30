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
    public partial class Invoice_sale_add : Form
    {
        public SqlConnection conn;
        string mahd;
        string makh = "";
        int i;
        string name;
        string idemp;
        DataTable d; //bang truyen vao tu inv view
        int j;
        
        DataTable dtdata;

        public Invoice_sale_add(string name1, string idemp1)
        {
            InitializeComponent();
            name = name1; nggiao.Text = name;
            idemp = idemp1; idnggiao.Text = idemp;
            Connect c = new Connect();
            conn = c.GetConnect();
            Ngay_Load();
            sanxuat_Load();
            newdata();
            tinhtrang.Text = "Chưa giao hàng";
        }

        private void Invoice_sale_add_Load(object sender, EventArgs e)
        {
            sanpham.Text = "Chọn";
            sanxuat.Text = "Chọn";
            DateTime date = DateTime.Today;
            day.Text = date.Day.ToString();
            month.Text = date.Month.ToString();
            year.Text = date.Year.ToString();

            buttom_change.Enabled = false;
            buttom_change.BackgroundImage = Image.FromFile(@"Image\buttom_change3.png");
            buttom_delete.Enabled = false;
            buttom_delete.BackgroundImage = Image.FromFile(@"Image\buttom_delete3.png");
        }

        public void set(DataTable d1, int j1)
        {
            d = d1;
            j = j1;
            buttom_addnew.Visible = false;
            buttom_confirm.Visible = false;

            id.Text = d.Rows[j][0].ToString();
            string ngay = d.Rows[j][1].ToString();
            string[] kq = ngay.Split('/');
            day.Text = kq[0];
            month.Text = kq[1];
            year.Text = kq[2];
            string makh = d.Rows[j][2].ToString();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from KhachHang where MaKH='" + makh + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ten.Text = (string)reader["HoTen"];
                cmnd.Text = (string)reader["CMND"];
                diachi.Text = (string)reader["DiaChi"];
                dt.Text = (string)reader["DT"];
            }
            reader.Close();
            conn.Close();
            tinhtrang.Text = d.Rows[j][3].ToString();
            idnggiao.Text = d.Rows[j][4].ToString();
            conn.Open();
            cmd.CommandText = "select HoTen from Admin where MaAD ='" + idnggiao.Text + "'";
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                nggiao.Text = (string)reader["HoTen"];
                reader.Close();
            }
            else
            {
                nggiao.Text = "";
                reader.Close();
            }
            cmd.CommandText = "select ChiTietHoaDonBan.MaSP,TenSP,SLBan,ChiTietHoaDonBan.GiaBan,(ChiTietHoaDonBan.GiaBan*SLBan) as ThanhTien from ChiTietHoaDonBan join SanPham on ChiTietHoaDonBan.MaSP=SanPham.MaSP where MaHDBan='" + id.Text + "'";
            reader = cmd.ExecuteReader();
            newdata();
            while (reader.Read())
            {
                DataRow r = dtdata.NewRow();
                r["MaSP"] = reader["MaSP"].ToString();
                r["TenSP"] = reader["TenSP"].ToString();
                r["SLBan"] = (int)reader["SLBan"];
                r["GiaBan"] = (int)reader["GiaBan"];
                r["ThanhTien"] = (int)reader["ThanhTien"];
                dtdata.Rows.Add(r);
                data.DataSource = dtdata.DefaultView;
            }
            mahd = id.Text;
            conn.Close();
            sanxuat_Load();
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter("select * from SanPham order by MaSP desc", conn);
            DataTable dtt = new DataTable();
            adapter.Fill(dtt);
            adapter.Dispose();
            sanpham.DisplayMember = "TenSP";
            sanpham.ValueMember = "MaSP";
            sanpham.DataSource = dtt.DefaultView;

        }

        // Buttom
        private void buttom_add_Click(object sender, EventArgs e)
        {
            if(sl.Text.Length==0)
                error.SetError(sl,"Not null!");
            else
            {
                err.Text = "";

                conn.Open();
                SqlCommand cmd = new SqlCommand("select SLTon from SanPham where MaSP='"+sanpham.SelectedValue.ToString()+"'",conn);
                int c = (int)cmd.ExecuteScalar();
                conn.Close();
                if (int.Parse(sl.Text)>c)
                {
                    MessageBox.Show("Hiện trong kho chỉ còn "+c+" sản phẩm! ", "Waring", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                    DataRow[] rows = dtdata.Select("MaSP = '" + sanpham.SelectedValue.ToString() + "'");
                    if (rows.Length == 0)
                    {
                        DataRow r = dtdata.NewRow();
                        r["MaSP"] = sanpham.SelectedValue.ToString();
                        r["TenSP"] = sanpham.Text;
                        r["SLBan"] = int.Parse(sl.Text);
                        r["GiaBan"] = int.Parse(gia.Text);
                        r["ThanhTien"] = int.Parse(sl.Text) * int.Parse(gia.Text);
                        dtdata.Rows.Add(r);
                        data.DataSource = dtdata.DefaultView;

                        object sum = dtdata.Compute("sum(SLBan)", "SLBan>0");
                        tongsl.Text = sum.ToString();
                        sum = dtdata.Compute("sum(ThanhTien)", "SLBan>0");
                        tongt.Text = sum.ToString();
                        buttom_addnewpro_Click(sender, e);
                    }
                    else
                        MessageBox.Show("Sản phẩm này đã có trong hóa đơn! ", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void buttom_addnewpro_Click(object sender, EventArgs e)
        {
            sl.Text = "";
            sanpham.Text = "Chọn";
            sanxuat.Text = "Chọn";

            buttom_add.Enabled = true;
            buttom_add.BackgroundImage = Image.FromFile(@"Image\buttom_add.png");
            buttom_change.Enabled = false;
            buttom_change.BackgroundImage = Image.FromFile(@"Image\buttom_change3.png");
            buttom_delete.Enabled = false;
            buttom_delete.BackgroundImage = Image.FromFile(@"Image\buttom_delete3.png");
        }

        private void buttom_save_Click(object sender, EventArgs e)
        {
            if (makh == "")
            {
                string sql = "insert KhachHang (MaKH,HoTen,DT,NgaySinh,DiaChi,CMND) values('',@name,@phone,@birth,@add,@idcard)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@name", ten.Text);
                cmd.Parameters.AddWithValue("@phone", dt.Text);
                cmd.Parameters.AddWithValue("@birth", month.Text + "/" + day.Text + "/" + year.Text);
                cmd.Parameters.AddWithValue("@add", diachi.Text);
                cmd.Parameters.AddWithValue("@idcard", cmnd.Text);
                cmd.ExecuteNonQuery();
                cmd.CommandText = "select MaKH from KhachHang where CMND=@idcard";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idcard", cmnd.Text);
                makh = (string)cmd.ExecuteScalar();
                conn.Close();
            }
            if (id.Text.Length == 0)
            {
                conn.Open();
                SqlCommand cmd2=new SqlCommand("insert HoaDonBan(MaHDBan,NgayBan,MaKH,TinhTrang,NguoiGiao) values ('',@ngay,@makh,@tt,@ngiao)",conn);
                cmd2.Parameters.AddWithValue("@ngay", month.Text + "/" + day.Text + "/" + year.Text);
                cmd2.Parameters.AddWithValue("@makh", makh);
                cmd2.Parameters.AddWithValue("@tt", tinhtrang.Text);
                cmd2.Parameters.AddWithValue("@ngiao", idnggiao.Text);
                cmd2.ExecuteNonQuery();
                cmd2.CommandText = "select top(1) MaHDBan from HoaDonBan order by MaHDBan desc";
                mahd = (string)cmd2.ExecuteScalar();
                id.Text = mahd;

                foreach (DataRow r in dtdata.Rows)
                {
                    cmd2.CommandText = "insert ChiTietHoaDonBan(MaHDBan,MaSP,SLBan,GiaBan) values (@mahd,@sp,@sl,@gia)";
                    cmd2.Parameters.Clear();
                    cmd2.Parameters.AddWithValue("@mahd", mahd);
                    cmd2.Parameters.AddWithValue("@sp", r["MaSP"]);
                    cmd2.Parameters.AddWithValue("@sl", r["SLBan"]);
                    cmd2.Parameters.AddWithValue("@gia", r["GiaBan"]);
                    cmd2.ExecuteNonQuery();
                }
                conn.Close();
                err.Text = "Save success!";
                //Cập nhật kho hàng
                SqlDataAdapter adapter = new SqlDataAdapter("select * from ChiTietHoaDonBan where MaHDBan='" + id.Text + "'", conn);
                DataTable dtsp = new DataTable();
                adapter.Fill(dtsp);
                adapter.Dispose();
                conn.Open();
                foreach (DataRow row in dtsp.Rows)
                {
                    cmd2.CommandText = "update SanPham set SLTon=SLTon-" + (int)row["SLBan"] + "where MaSP='" + (string)row["MaSP"] + "'";
                    cmd2.ExecuteNonQuery();
                }
                conn.Close();
            }
            else
            {
                //Cập nhật kho hàng
                SqlDataAdapter adapter = new SqlDataAdapter("select * from ChiTietHoaDonBan where MaHDBan='" + id.Text + "'", conn);
                DataTable dtsp = new DataTable();
                adapter.Fill(dtsp);
                adapter.Dispose();
                conn.Open();
                foreach (DataRow row in dtsp.Rows)
                {
                    SqlCommand cmd5 = new SqlCommand ("update SanPham set SLTon=SLTon+" + (int)row["SLBan"] + "where MaSP='" + (string)row["MaSP"] + "'",conn);
                    cmd5.ExecuteNonQuery();
                }
                conn.Close();
                conn.Open();
                SqlCommand cmd3=new SqlCommand("update HoaDonBan set NgayBan=@ngay,MaKH=@makh,TinhTrang=@tt where MaHDBan=@mahd",conn);
                cmd3.Parameters.AddWithValue("@ngay", month.Text + "/" + day.Text + "/" + year.Text);
                cmd3.Parameters.AddWithValue("@makh", makh);
                cmd3.Parameters.AddWithValue("@tt", tinhtrang.Text);
                cmd3.Parameters.AddWithValue("@mahd", mahd);
                cmd3.ExecuteNonQuery();
                foreach (DataRow row in dtdata.Rows)
                {
                    cmd3.CommandText = "select MaSP from ChiTietHoaDonBan where MaHDBan=@mahd and MaSP=@masp";
                    cmd3.Parameters.Clear();
                    cmd3.Parameters.AddWithValue("@mahd", mahd);
                    cmd3.Parameters.AddWithValue("@masp", row["MaSP"]);
                    SqlDataReader r = cmd3.ExecuteReader();
                    bool check = r.Read(); r.Close();
                    if (check)
                    {
                        cmd3.CommandText = "update ChiTietHoaDonBan set SLBan=@sl,GiaBan=@gia where MaHDBan=@mahd and MaSP=@masp";
                        cmd3.Parameters.Clear();
                        cmd3.Parameters.AddWithValue("@mahd", mahd);
                        cmd3.Parameters.AddWithValue("@masp", row["MaSP"]);
                        cmd3.Parameters.AddWithValue("@sl", row["SLBan"]);
                        cmd3.Parameters.AddWithValue("@gia", row["GiaBan"]);
                        cmd3.ExecuteNonQuery();
                    }
                    else
                    {
                        cmd3.CommandText = "insert ChiTietHoaDonBan(MaHDBan,MaSP,SLBan,GiaBan) values (@mahd,@sp,@sl,@gia)";
                        cmd3.Parameters.Clear();
                        cmd3.Parameters.AddWithValue("@mahd", mahd);
                        cmd3.Parameters.AddWithValue("@sp", row["MaSP"]);
                        cmd3.Parameters.AddWithValue("@sl", row["SLBan"]);
                        cmd3.Parameters.AddWithValue("@gia", row["GiaBan"]);
                        cmd3.ExecuteNonQuery();
                    }
                }

                conn.Close();

                //Cập nhật kho hàng
                SqlDataAdapter adapter6 = new SqlDataAdapter("select * from ChiTietHoaDonBan where MaHDBan='" + id.Text + "'", conn);
                DataTable dtsp6 = new DataTable();
                adapter6.Fill(dtsp6);
                adapter6.Dispose();
                conn.Open();
                foreach (DataRow row in dtsp6.Rows)
                {
                    SqlCommand cmd6 = new SqlCommand("update SanPham set SLTon=SLTon-" + (int)row["SLBan"] + "where MaSP='" + (string)row["MaSP"] + "'", conn);
                    cmd6.ExecuteNonQuery();
                }
                conn.Close();
                err.Text = "Save success!";
            }
        }

        private void buttom_confirm_Click(object sender, EventArgs e)
        {
            if (tinhtrang.Text == "Chưa giao hàng")
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update HoaDonBan set TinhTrang=N'Đã giao hàng',NguoiGiao=@idngiao,NgayGiao=@ngaygiao where MaHDBan=@mahd", conn);
                cmd.Parameters.AddWithValue("@mahd", mahd);
                cmd.Parameters.AddWithValue("@idngiao", idnggiao.Text);
                cmd.Parameters.AddWithValue("@ngaygiao", month.Text + "/" + day.Text + "/" + year.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                tinhtrang.Text = "Đã giao hàng";
                DateTime date = DateTime.Today;
                day2.Text = date.Day.ToString();
                month2.Text = date.Month.ToString();
                year2.Text = date.Year.ToString();
                buttom_save.Enabled = false;
                buttom_save.BackgroundImage = Image.FromFile(@"Image\buttom_save3.png");
            }
            else
                MessageBox.Show("Hóa đơn này đã được giao hàng! ", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void buttom_delete_Click(object sender, EventArgs e)
        {
            dtdata.Rows.RemoveAt(i);
            data.DataSource = dtdata.DefaultView;
            info.Text = "Delete success!";
            err.Text = "";
        }

        private void buttom_change_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select SLTon from SanPham where MaSP='" + sanpham.SelectedValue.ToString() + "'", conn);
            int c = (int)cmd.ExecuteScalar();
            conn.Close();
            if (int.Parse(sl.Text) > c)
            {
                MessageBox.Show("Hiện trong kho chỉ còn " + c + " sản phẩm! ", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                err.Text = "";
                DataRow[] rows = dtdata.Select("MaSP = '" + sanpham.SelectedValue.ToString() + "'");
                for (int i = 0; i < rows.Length; i++)
                {
                    rows[i]["SLBan"] = sl.Text;
                    rows[i]["ThanhTien"] = int.Parse(sl.Text) * int.Parse(gia.Text);

                    object sum = dtdata.Compute("sum(SLBan)", "SLBan>0");
                    tongsl.Text = sum.ToString();
                    sum = dtdata.Compute("sum(ThanhTien)", "SLBan>0");
                    tongt.Text = sum.ToString();
                }
                info.Text = "Change success!";
            }
        }

        // Kiem tra và load dữ liệu
        private void cmnd_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(cmnd.Text, @"^[0-9]+$"))
                error.Clear();
            else
                error.SetError(cmnd, "Only type number!");
        }

        private void cmnd_Leave(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select MaKH,HoTen,DiaChi,DT from KhachHang where CMND=@idcard", conn);
            cmd.Parameters.AddWithValue("@idcard", cmnd.Text);
            SqlDataReader r = cmd.ExecuteReader();
            if (r.Read())
            {
                makh = r["MaKH"].ToString();
                ten.Text = r["HoTen"].ToString();
                diachi.Text = r["DiaChi"].ToString();
                dt.Text = r["DT"].ToString();
                MessageBox.Show("Khách hàng này đã lưu trong hệ thông! Hệ thống tự động lấy thông tin của khách hàng này! ", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                r.Close();
                conn.Close();
            }
            else
            {
                makh = "";
                r.Close();
                conn.Close();
            }
        }

        private void buttom_addnew_Click(object sender, EventArgs e)
        {
            ten.Clear();
            cmnd.Clear();
            diachi.Clear();
            dt.Clear();
            id.Clear();
            newdata();
            grde.Enabled = true;
            data.DataSource = dtdata.DefaultView;
            tinhtrang.Text = "Chưa giao hàng";
            buttom_save.Enabled = true;
            buttom_save.BackgroundImage = Image.FromFile(@"Image\buttom_save.png");
        }

        private void dataview(int i)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select MaSX from SanPham where MaSP='"+dtdata.Rows[i][0].ToString()+"'", conn);
            sanxuat.SelectedValue = (string)cmd.ExecuteScalar();
            conn.Close();
            sanpham.SelectedValue = dtdata.Rows[i][0].ToString();
            sl.Text = dtdata.Rows[i][2].ToString();
            gia.Text = dtdata.Rows[i][3].ToString();
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

        private void dt_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(dt.Text, @"^[0-9]+$"))
                error.Clear();
            else
                error.SetError(dt, "Only type number!");
        }      

        private void VA_p_Click(object sender, EventArgs e)
        {
            VA_products f = new VA_products();
            f.setdk(true);
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
            f.setdk(true);
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
            {
                sanxuat_Load();
                sanxuat.Text = f.getdata();
            }
        }

        private void sanxuat_SelectedIndexChanged(object sender, EventArgs e)
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

        private void sanpham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sanpham.Text != "Chọn")
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select GiaBan from SanPham where MaSP=@masp", conn);
                cmd.Parameters.AddWithValue("@masp", sanpham.SelectedValue.ToString());
                int i = (int)cmd.ExecuteScalar();
                conn.Close();
                gia.Text = i.ToString();
            }
        }

        private void sl_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(sl.Text, @"^[0-9]+$"))
            {
                error.Clear();
            }

            else
                error.SetError(sl, "Only type number!");
        }

        public void newdata()
        {
            dtdata = new DataTable();
            DataColumn MaSP = new DataColumn("MaSP", typeof(string));
            dtdata.Columns.Add(MaSP);
            DataColumn TenSP = new DataColumn("TenSP", typeof(string));
            dtdata.Columns.Add(TenSP);
            DataColumn SlBan = new DataColumn("SLBan", typeof(int));
            dtdata.Columns.Add(SlBan);
            DataColumn GiaBan = new DataColumn("GiaBan", typeof(int));
            dtdata.Columns.Add(GiaBan);
            DataColumn ThanhTien = new DataColumn("ThanhTien", typeof(int));
            dtdata.Columns.Add(ThanhTien);
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

    }
}
