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
    public partial class Invoice_sale_view : Form
    {
        SqlConnection conn;
        DataTable dt;
        int i;
        string name;
        string idemp;

        public Invoice_sale_view(string name1, string idemp1)
        {
            InitializeComponent();
            name = name1;
            idemp = idemp1;
            Connect c = new Connect();
            conn = c.GetConnect();
            type.Text = "MaHD";
        }

        private void Invoice_sale_view_Load(object sender, EventArgs e)
        {
            buttom_change.Enabled = false;
            buttom_change.BackgroundImage = Image.FromFile(@"Image\buttom_change3.png");
            buttom_confirm.Enabled = false;
            buttom_confirm.BackgroundImage = Image.FromFile(@"Image\buttom_confirm3.png");
            buttom_delete.Enabled = false;
            buttom_delete.BackgroundImage = Image.FromFile(@"Image\buttom_delete3.png");
        }

        private void dataview(int i)
        {
            buttom_delete.Enabled = true;
            buttom_delete.BackgroundImage = Image.FromFile(@"Image\buttom_delete.png");
            buttom_confirm.Enabled = true;
            buttom_confirm.BackgroundImage = Image.FromFile(@"Image\buttom_confirm.png");
            error.Text = "";

            id.Text = dt.Rows[i][0].ToString();
            string ngay = dt.Rows[i][1].ToString();
            string[] kq = ngay.Split('/');
            day.Text = kq[0];
            month.Text = kq[1];
            year.Text = kq[2];
            string makh = dt.Rows[i][2].ToString();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from KhachHang where MaKH='" + makh + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ten.Text = (string)reader["HoTen"];
                cmnd.Text = (string)reader["CMND"];
                diachi.Text = (string)reader["DiaChi"];
                sdt.Text = (string)reader["DT"];
            }
            reader.Close();
            conn.Close();
            tinhtrang.Text = dt.Rows[i][3].ToString();
            if (tinhtrang.Text == "Đã giao hàng")
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
            idnggiao.Text = dt.Rows[i][4].ToString();
            nggiao.Text = "";
            conn.Open();
            cmd.CommandText="select HoTen from Admin where MaAD ='" + idnggiao.Text + "'";
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                nggiao.Text = (string)reader["HoTen"];
                reader.Close();
                conn.Close();
            }
            else 
            {
                nggiao.Text = "";
                reader.Close();
            }

            ngay = dt.Rows[i][5].ToString();
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
            
            conn.Close();
            cmd.CommandText = "select TenSP,SLBan,ChiTietHoaDonBan.GiaBan,SLBan*ChiTietHoaDonBan.GiaBan as ThanhTien,MaKM from ChiTietHoaDonBan join SanPham on ChiTietHoaDonBan.MaSP=SanPham.MaSP where MaHDBan='" + id.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtd = new DataTable();
            adapter.Fill(dtd);
            adapter.Dispose();
            datadetail.DataSource = dtd;
            object sumt = dtd.Compute("sum(ThanhTien)", "SLBan>0");
            sum.Text = sumt.ToString();

        }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            if (i >= 0)
            {
                dataview(i);
            }
        }

        private void buttom_confirm_Click(object sender, EventArgs e)
        {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select TinhTrang from HoaDonBan where MaHDBan=@mahd", conn);
                cmd.Parameters.AddWithValue("@mahd", id.Text);
                SqlDataReader r = cmd.ExecuteReader();
                if (r.Read())
                {
                    if ((string)r["TinhTrang"] != "Đã giao hàng")
                    {
                        if (idemp != idnggiao.Text && idnggiao.Text.Length != 0)
                        {
                            Confirm f = new Confirm("MB_DIRECTOR");
                            f.ShowDialog();
                            if (f.DialogResult == DialogResult.OK)
                            {
                                r.Close();
                                cmd.CommandText = "update HoaDonBan set TinhTrang=@tt,NguoiGiao=@ngiao where MaHDBan=@mahd";
                                cmd.Parameters.Clear();
                                cmd.Parameters.AddWithValue("@mahd", id.Text);
                                cmd.Parameters.AddWithValue("@tt", "Đã giao hàng");
                                cmd.Parameters.AddWithValue("@ngiao", idemp);
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                tinhtrang.Text = "Đã giao hàng";
                                idnggiao.Text = idemp;
                                nggiao.Text = name;
                                error.Text = "Confirm success!";
                                DataRow[] rows = dt.Select("MaHDBan = '" + id.Text + "'");
                                for (int i = 0; i < rows.Length; i++)
                                {
                                    rows[i]["TinhTrang"] = "Đã giao hàng";
                                    rows[i]["NguoiGiao"] = idemp;
                                }
                            }
                        }
                        else
                        {
                            r.Close();
                            cmd.CommandText = "update HoaDonBan set TinhTrang=@tt,NguoiGiao=@ngiao where MaHDBan=@mahd";
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@mahd", id.Text);
                            cmd.Parameters.AddWithValue("@tt", "Đã giao hàng");
                            cmd.Parameters.AddWithValue("@ngiao", idemp);
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            tinhtrang.Text = "Đã giao hàng";
                            idnggiao.Text = idemp;
                            nggiao.Text = name;
                            error.Text = "Confirm success!";
                            DataRow[] rows = dt.Select("MaHDBan = '" + id.Text + "'");
                            for (int i = 0; i < rows.Length; i++)
                            {
                                rows[i]["TinhTrang"] = "Đã giao hàng";
                                rows[i]["NguoiGiao"] = idemp;
                            }
                        }
                    }
                    else
                        MessageBox.Show("Hóa đơn này đã được giao hàng!", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                r.Close();
                conn.Close();  
        }

        private void buttom_unconfirm_Click(object sender, EventArgs e)
        {
            Confirm f = new Confirm("MS_DIRECTOR");
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
            {
                day2.Text = "";
                month2.Text = "";
                year2.Text = "";

                conn.Open();
                SqlCommand cmd = new SqlCommand("update HoaDonBan set TinhTrang=@tt,NguoiGiao=@ngiao,NgayGiao=@ngaygiao where MaHDBan=@mahd",conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@mahd", id.Text);
                cmd.Parameters.AddWithValue("@tt", "Chưa giao hàng");
                cmd.Parameters.AddWithValue("@ngiao", "");
                cmd.Parameters.AddWithValue("@ngaygiao", "");
                cmd.ExecuteNonQuery();
                tinhtrang.Text = "Chưa giao hàng";
                idnggiao.Text = "";
                nggiao.Text = "";

                DataRow[] rows = dt.Select("MaHDBan = '" + id.Text + "'");
                for (int i = 0; i < rows.Length; i++)
                {
                    rows[i]["TinhTrang"] = "Chưa giao hàng";
                    rows[i]["NguoiGiao"] = "";
                }

                error.Text = "Unconfirm success!";
                buttom_change.Enabled = true;
                buttom_change.BackgroundImage = Image.FromFile(@"Image\buttom_change.png");
                buttom_confirm.Visible = true;
                buttom_unconfirm.Visible = false;

                //Cập nhật kho hàng
                SqlDataAdapter adapter = new SqlDataAdapter("select * from ChiTietHoaDonBan where MaHDBan='" + id.Text + "'", conn);
                DataTable dtsp = new DataTable();
                adapter.Fill(dtsp);
                adapter.Dispose();
                foreach (DataRow row in dtsp.Rows)
                {
                    cmd.CommandText = "update SanPham set SLTon=SLTon+" + (int)row["SLBan"] + "where MaSP='" + (string)row["MaSP"] + "'";
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
        
        private void buttom_delete_Click(object sender, EventArgs e)
        {
            if (tinhtrang.Text != "Đã giao hàng")
            {
                if (tinhtrang.Text == "Xác nhận đặt hàng")
                {
                    //cap nhap kho
                    SqlDataAdapter adapter = new SqlDataAdapter("select * from ChiTietHoaDonBan where MaHDBan='" + id.Text + "'", conn);
                    DataTable dtsp = new DataTable();
                    adapter.Fill(dtsp);
                    adapter.Dispose();
                    conn.Open();
                    foreach (DataRow row in dtsp.Rows)
                    {
                        SqlCommand cmd2 = new SqlCommand("update SanPham set SLTon=SLTon+" + (int)row["SLBan"] + "where MaSP='" + (string)row["MaSP"] + "'", conn);
                        cmd2.ExecuteNonQuery();
                    }
                    SqlCommand cmd = new SqlCommand("delete from HoaDonBan where MaHDBan='" + id.Text + "'", conn);
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "delete from ChiTietHoaDonBan where MaHDBan='" + id.Text + "'";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    dt.Rows.RemoveAt(i);
                    error.Text = "Delete success!";
                }
                else
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete from HoaDonBan where MaHDBan='" + id.Text + "'", conn);
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "delete from ChiTietHoaDonBan where MaHDBan='" + id.Text + "'";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    dt.Rows.RemoveAt(i);
                    error.Text = "Delete success!";
                }
            }
            else 
            {
                error.Text = "Not allow delete this invoice!";
            }
        }

        private void buttom_change_Click(object sender, EventArgs e)
        {
            if (tinhtrang.Text != "Đã giao hàng")
            {
                if (idnggiao.Text != idemp && idnggiao.Text.Length != 0)
                {
                    Confirm f1 = new Confirm("MB_DIRECTOR");
                    f1.ShowDialog();
                    if (f1.DialogResult == DialogResult.OK)
                    {
                        Invoice_sale_add f = new Invoice_sale_add("a", "a");
                        f.set(dt, i);
                        f.ShowDialog();
                    }
                }
                else
                {
                    Invoice_sale_add f = new Invoice_sale_add("a", "a");
                    f.set(dt, i);
                    f.ShowDialog();
                }
            }
            else
                MessageBox.Show("Hóa đơn này đã được xác nhận!", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void searchwith(string type)
        {
            string sql = "select MaHDBan,CONVERT(varchar, NgayBan, 103) as NgayBan,MaKH,TinhTrang,NguoiGiao,CONVERT(varchar, NgayGiao, 103) as NgayGiao from HoaDonBan where " + type + " like N'%" + search.Text + search2.Text + "%' order by NgayBan desc";
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            adapter.Fill(dt);
            adapter.Dispose();
            data.DataSource = dt;
            if (dt.Rows.Count == 0)
                data.Visible = false;
            else data.Visible = true;
            diachi.Text = "";
            sdt.Text = "";
            ten.Text = "";
            cmnd.Text = "";
            id.Text = "";
            sum.Text = "";
            nggiao.Text = "";
            idnggiao.Text = "";
            tinhtrang.Text = "";
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
                searchwith("MaHDBan");
            }
            else if (type.Text == "Người giao")
            {
                searchwith("NguoiGiao");
            }
            else if (type.Text == "Ngày")
            {
                searchwith("NgayBan");
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
                search.Visible = true;
                search2.Visible = false;
                note.Text = "Vui lòng nhập ngày theo định dạng mm-dd-yyyy để cho kết quả chính xác nhất!";
            }
            if (type.Text == "Người giao")
            {
                search.Visible = true;
                search2.Visible = false;
                note.Text = "Hãy nhập mã số nhân viên của bạn để tìm kiếm những hóa đơn do bạn phụ trách!";
            }
            if (type.Text == "MaHD")
            {
                search.Visible = true;
                search2.Visible = false;
                note.Text = "Bạn chỉ cần nhập chuỗi số có trong hóa đơn là có thể tìm thấy hóa đơn bạn cần tìm!";
            }
            if (type.Text == "Tình trạng")
            {
                search.Visible = false;
                search2.Visible = true;
            }
            search.Text = "";
            search2.Text = "";
            buttom_search.Enabled = false;
            buttom_search.BackgroundImage = Image.FromFile(@"Image\buttom_search3.png");
        }

        private void buttom_showall_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select MaHDBan,CONVERT(varchar, NgayBan, 103) as NgayBan,MaKH,TinhTrang,NguoiGiao,CONVERT(varchar, NgayGiao, 103) as NgayGiao from HoaDonBan order by NgayBan desc", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            adapter.Dispose();
            data.DataSource = dt;

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
