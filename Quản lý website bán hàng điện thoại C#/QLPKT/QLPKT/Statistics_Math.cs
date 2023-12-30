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
    public partial class Statistics_Math : Form
    {
        DateTime date;
        SqlConnection conn;

        public Statistics_Math()
        {
            InitializeComponent();
            date = DateTime.Today;
            quater.Enabled = false;
            year.Enabled = false;
            month.Enabled = false;
            day.Enabled = false;
            Connect c = new Connect();
            conn = c.GetConnect();
            type.Text = "Chọn loại thống kê";
            year.Text = date.Year.ToString();
            month.Text = date.Month.ToString();
            day.Text = date.Day.ToString();

            databuy.RowHeadersVisible = false;
        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (type.Text == "Theo quý")
            {
                quater.Enabled = true;
                year.Enabled = true;
                month.Enabled = false;
            }
            if(type.Text == "Theo tháng")
            {
                quater.Enabled = false;
                year.Enabled = true;
                month.Enabled = true;
            }
            if (type.Text == "Theo năm")
            {
                quater.Enabled = false;
                year.Enabled = true;
                month.Enabled = false;
            }
            if (type.Text == "Theo ngày")
            {
                quater.Enabled = false;
                year.Enabled = true;
                month.Enabled = true;
                day.Enabled = true;
                day.Text = date.Day.ToString() ;
                month.Text = date.Month.ToString();
                year.Text = date.Year.ToString();
            }
        }

        private void buttom_ok_Click(object sender, EventArgs e)
        {
            if (type.Text == "Theo tháng")
            {
                conn.Open();
                // Doanh thu
                SqlCommand cmd = new SqlCommand("select CONVERT(varchar,sum(ThanhTien)) from (select ChiTietHoaDonBan.MaHDBan, SUM(SLBan*GiaBan) as ThanhTien from HoaDonBan join ChiTietHoaDonBan on HoaDonBan.MaHDBan=ChiTietHoaDonBan.MaHDBan where (NgayBan between @from and @to) and TinhTrang like N'Đã giao hàng' group by ChiTietHoaDonBan.MaHDBan) as a", conn);
                cmd.Parameters.AddWithValue("@from", month.Text + "/01/" + year.Text);
                cmd.Parameters.AddWithValue("@to", month.Text + "/31/" + year.Text);
                double t1 = double.Parse((string)cmd.ExecuteScalar().ToString());
                doanhthu.Text = String.Format("{0:0,0 VNĐ}", t1);
                // Gia tri hang ton kho thang truoc
                int thang, nam;
                if (int.Parse(month.Text) == 1)
                {
                    thang = 12;
                    nam = int.Parse(year.Text) - 1;
                }
                else
                {
                    thang = int.Parse(month.Text) - 1;
                    nam = int.Parse(year.Text);
                }
                cmd.CommandText = "select CONVERT(varchar,GiaTriTonKho) as GiaTriTonKho from ThongKeTaiChinh where Thang=" + thang + " and Nam=" + nam + "";
                string t = (string)cmd.ExecuteScalar().ToString().Split('.')[0];
                double t2 = double.Parse(t);
                tk_dauthang.Text = String.Format("{0:0,0 VNĐ}", t2);
                // Gia tri hang ton kho thang nay
                cmd.CommandText = "select SUM(GiaMua*SLTon) from SanPham";
                double t3 = (int)cmd.ExecuteScalar();
                tk_cuoithang.Text = String.Format("{0:0,0 VNĐ}", t3);
                // Gia tri von them moi
                cmd.CommandText = "select sum(ThanhTien) from (select ChiTietHoaDonMua.MaHDMua, SUM(SLMua*GiaMua) as ThanhTien from HoaDonMua join ChiTietHoaDonMua on HoaDonMua.MaHDMua=ChiTietHoaDonMua.MaHDMua where (NgayMua between @from and @to) and TinhTrang like N'Đã xác nhận' group by ChiTietHoaDonMua.MaHDMua) as a";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@from", month.Text + "/01/" + year.Text);
                cmd.Parameters.AddWithValue("@to", month.Text + "/31/" + year.Text);
                double t4 = (int)cmd.ExecuteScalar();
                vonmoi.Text = String.Format("{0:0,0 VNĐ}", t4);
                // Tong von
                tongvon.Text = String.Format("{0:0,0 VNĐ}", (t2 + t4));
                // Lai truoc thue
                laitt.Text = String.Format("{0:0,0 VNĐ}", ((t1 + t3) - (t4 + t2)));
            }
            if (type.Text == "Theo ngày")
            {
                conn.Open();
                // Doanh thu
                SqlCommand cmd = new SqlCommand("select CONVERT(varchar,sum(ThanhTien)) from (select ChiTietHoaDonBan.MaHDBan, SUM(SLBan*GiaBan) as ThanhTien from HoaDonBan join ChiTietHoaDonBan on HoaDonBan.MaHDBan=ChiTietHoaDonBan.MaHDBan where NgayBan=@ngay and TinhTrang like N'Đã giao hàng' group by ChiTietHoaDonBan.MaHDBan) as a", conn);
                cmd.Parameters.AddWithValue("@ngay", month.Text + "/" + day.Text + "/" + year.Text);
                double t1 = double.Parse((string)cmd.ExecuteScalar().ToString());
                doanhthu.Text = String.Format("{0:0,0 VNĐ}", t1);
                conn.Close();  
            }

            if (type.Text == "Theo quý")
            {
                //conn.Open();
                //// Doanh thu
                //SqlCommand cmd = new SqlCommand("select CONVERT(varchar,sum(ThanhTien)) from (select ChiTietHoaDonBan.MaHDBan, SUM(SLBan*GiaBan) as ThanhTien from HoaDonBan join ChiTietHoaDonBan on HoaDonBan.MaHDBan=ChiTietHoaDonBan.MaHDBan where NgayBan=@ngay and TinhTrang like N'Đã giao hàng' group by ChiTietHoaDonBan.MaHDBan) as a", conn);
                //cmd.Parameters.AddWithValue("@ngay", month.Text + "/" + day.Text + "/" + year.Text);
                //double t1 = double.Parse((string)cmd.ExecuteScalar().ToString());
                //doanhthu.Text = String.Format("{0:0,0 VNĐ}", t1);
                //conn.Close();
                MessageBox.Show("Không đủ dữ liệu để thực hiện chức năng này.\nVul lòng thử lại sau!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (type.Text == "Theo năm")
            {
                MessageBox.Show("Không đủ dữ liệu để thực hiện chức năng này.\nVul lòng thử lại sau!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void nhung(Form f)
        {
            //foreach (Control ctl in panel3.Controls)
            //ctl.Dispose();
            panel_detail.Controls.Clear();//Xõa các control trong form cũ
            f.FormBorderStyle = FormBorderStyle.None;
            f.TopLevel = false;//quan trọng là dòng này thiếu là chít
            f.Visible = true;
            f.Dock = DockStyle.Fill;
            panel_detail.Controls.Add(f);//thêm form mới vào panel
            panel_detail.Show();
        }

        private void type2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (type2.Text == "Danh sách nhập hàng")
            {
                SqlDataAdapter adapter = new SqlDataAdapter("select TenSP,sum(SLMua) as SLMua,ChiTietHoaDonMua.GiaMua,sum(SLMua*ChiTietHoaDonMua.GiaMua) as ThanhTien from HoaDonMua join ChiTietHoaDonMua on ChiTietHoaDonMua.MaHDMua=HoaDonMua.MaHDMua join SanPham on ChiTietHoaDonMua.MaSP=SanPham.MaSP where (NgayMua between '" + month.Text + "/01/" + year.Text + "' and '" + month.Text + "/31/" + year.Text + "') and TinhTrang like N'Đã xác nhận' group by TenSP,ChiTietHoaDonMua.GiaMua", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                adapter.Dispose();
                databuy.DataSource = dt;
                conn.Close();
                SA_Buy f = new SA_Buy(dt);
                sumbuy.Text = String.Format("{0:0,0 VNĐ}", f.get());
                nhung(f);
            }
            if (type2.Text == "Danh sách bán hàng")
            {
                SqlDataAdapter adapter = new SqlDataAdapter("select TenSP,ChiTietHoaDonBan.GiaBan,sum(SLBan) as SLBan,sum(SLBan*ChiTietHoaDonBan.GiaBan) as ThanhTien from HoaDonBan,ChiTietHoaDonBan,SanPham where ChiTietHoaDonBan.MaHDBan=HoaDonBan.MaHDBan AND ChiTietHoaDonBan.MaSP=SanPham.MaSP and (NgayBan between '" + month.Text + "/01/" + year.Text + "' and '" + month.Text + "/31/" + year.Text + "')  and TinhTrang like N'Đã giao hàng' group by TenSP,ChiTietHoaDonBan.GiaBan", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                adapter.Dispose();
                databuy.DataSource = dt;
                conn.Close();
                SA_Sale f = new SA_Sale(dt);
                sumbuy.Text = String.Format("{0:0,0 VNĐ}", f.get());
                nhung(f);
            }
            if (type2.Text == "Danh sách bán chạy")
            {
                SqlDataAdapter adapter = new SqlDataAdapter("select TenSP,sum(SLBan) as SLBan,sum(SLBan*ChiTietHoaDonBan.GiaBan) as DoanhThu from HoaDonBan,ChiTietHoaDonBan,SanPham where ChiTietHoaDonBan.MaHDBan=HoaDonBan.MaHDBan AND ChiTietHoaDonBan.MaSP=SanPham.MaSP and (NgayBan between '" + month.Text + "/01/" + year.Text + "' and '" + month.Text + "/31/" + year.Text + "')  and TinhTrang like N'Đã giao hàng' group by TenSP order by SLBan desc", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                adapter.Dispose();
                databuy.DataSource = dt;
                conn.Close();
                SA_Sellwell f = new SA_Sellwell(dt);
                sumbuy.Text = String.Format("{0:0,0 VNĐ}", f.get());
                nhung(f);
            }
            if (type2.Text == "Danh sách tồn kho")
            {
                SqlDataAdapter adapter = new SqlDataAdapter("select TenSP,SLTon,SLTon*GiaMua as ThanhTien from SanPham order by SLTon desc", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                adapter.Dispose();
                databuy.DataSource = dt;
                conn.Close();
                SA_Innage f = new SA_Innage(dt);
                sumbuy.Text = String.Format("{0:0,0 VNĐ}", f.get());
                nhung(f);
            }

        }

        private void Statistics_Math_Load(object sender, EventArgs e)
        {

        }
    }
}
