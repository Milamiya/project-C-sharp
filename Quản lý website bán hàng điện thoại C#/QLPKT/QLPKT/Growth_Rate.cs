using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLPKT
{
    public partial class Growth_Rate : Form
    {
        SqlConnection conn;
        string ty1;
        string ty2;
        int lm;
        int fr;
        int t;
        int y1;
        int y2;
        string masp;

        public Growth_Rate(string ty11,string ty21,int lm1,int fr1,int t1,int y11,int y21,string m)
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            Connect c = new Connect();
            conn = c.GetConnect();
            ty1 = ty11;
            ty2 = ty21;
            lm = lm1;
            fr = fr1;
            t = t1;
            y1 = y11;
            y2 = y21;
            masp = m;
            
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (ty1 == "Lợi nhuận")
            {
                if (ty2 == "Tháng")
                {
                    SauThang(e, fr, t, y1, y2, lm);
                }
            }

            if (ty1 == "Doanh số theo sản phẩm")
            {
                if (ty2 == "Tháng")
                {
                    sauThangDoanhSo(e, fr, t, y1, y2, lm, masp);
                }
            } 

        }

        private void sauThangDoanhSo(PaintEventArgs e, int fr, int to, int y1, int y2, int limit,string ma)
        {
            int k = 0;
            int[] month = new int[6];
            for (int i = fr; i <= to; i++)
            {
                month[k] = i;
                k++;
            }
            SqlCommand cmd = new SqlCommand("select MONTH(NgayBan) as Thang,sum(ChiTietHoaDonBan.SLBan) as SoLuong from ChiTietHoaDonBan,HoaDonBan where ChiTietHoaDonBan.MaHDBan=HoaDonBan.MaHDBan and (NgayBan between '3/1/2012' and '8/31/2012') and MaSP='"+ ma +"' group by MONTH(NgayBan)", conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            int[] value = new int[6];
            for (int i = 0; i <6; i++)
            {
                value[i]=0;
            }
            while (reader.Read())
            {
                for (int i = 0; i < 6; i++)
                {
                    if(month[i]==(int)reader["Thang"])
                        value[i]=(int)reader["SoLuong"];
                }
            }
            reader.Close();
            conn.Close();

            //Display
            ylabel.Text = "Đ/v";
            x1.Text = "Tháng " + month[0].ToString();
            x2.Text = "Tháng " + month[1].ToString();
            x3.Text = "Tháng " + month[2].ToString();
            x4.Text = "Tháng " + month[3].ToString();
            x5.Text = "Tháng " + month[4].ToString();
            x6.Text = "Tháng " + month[5].ToString();

            r1.Text = value[0].ToString();
            if (value[1] > value[0])
                r1.Location = new System.Drawing.Point(5, (352 + Xuli(value[0])));
            else
                r1.Location = new System.Drawing.Point(5, (352 + Xuli(value[0])) - 20);

            r2.Text = value[1].ToString();
            if (value[2] > value[1])
                r2.Location = new System.Drawing.Point(90, (352 + Xuli(value[1])));
            else
                r2.Location = new System.Drawing.Point(90, (352 + Xuli(value[1])) - 20);

            r3.Text = value[2].ToString();
            if (value[3] > value[2])
                r3.Location = new System.Drawing.Point(190, (352 + Xuli(value[2])));
            else
                r3.Location = new System.Drawing.Point(190, (352 + Xuli(value[2])) - 20);

            r4.Text = value[3].ToString();
            if (value[4] > value[3])
                r4.Location = new System.Drawing.Point(290, (352 + Xuli(value[3])));
            else
                r4.Location = new System.Drawing.Point(290, (352 + Xuli(value[3])) - 20);

            r5.Text = value[4].ToString();
            if (value[5] > value[4])
                r5.Location = new System.Drawing.Point(390, (352 + Xuli(value[4])));
            else
                r5.Location = new System.Drawing.Point(390, (352 + Xuli(value[4])) - 20);

            r6.Text = value[5].ToString();
            if (value[5] > value[4])
                r6.Location = new System.Drawing.Point(490, (352 + Xuli(value[5])) - 20);
            else
                r6.Location = new System.Drawing.Point(490, (352 + Xuli(value[5])) + 20);

            Graphics g = e.Graphics;
            g.PageUnit = GraphicsUnit.Pixel;
            g.TranslateTransform(70, 350); //Gốc tọa độ (0,0)

            // Trục tọa độ
            Pen TTD = new Pen(Color.Black, 1);
            TTD.StartCap = LineCap.RoundAnchor;
            //TTD.EndCap = LineCap.ArrowAnchor;
            //aPen.DashStyle = DashStyle.Solid;
            //aPen.DashOffset = 50;
            g.DrawLine(TTD, 0, 0, 510, 0); //Trục x
            g.DrawLine(TTD, 0, 0, 0, -330);//Trục y
            TTD.Dispose();

            //Display
            Pen m = new Pen(Color.LightGray, 1);
            g.DrawLine(m, -4, -50, 510, -50);
            g.DrawLine(m, -4, -100, 510, -100);
            g.DrawLine(m, -4, -150, 510, -150);
            g.DrawLine(m, -4, -200, 510, -200);
            g.DrawLine(m, -4, -250, 510, -250);
            g.DrawLine(m, -4, -300, 510, -300);

            g.DrawLine(m, 100, 0, 100, 4);
            g.DrawLine(m, 200, 0, 200, 4);
            g.DrawLine(m, 300, 0, 300, 4);
            g.DrawLine(m, 400, 0, 400, 4);
            g.DrawLine(m, 500, 0, 500, 4);
            m.Dispose();

            //Xác định điểm
            Pen p = new Pen(Color.Red, 3);
            p.StartCap = LineCap.RoundAnchor;
            g.DrawLine(p, 0, Xuli(value[0]), 2, Xuli(value[0]));
            g.DrawLine(p, 100, Xuli(value[1]), 102, Xuli(value[1]));
            g.DrawLine(p, 200, Xuli(value[2]), 202, Xuli(value[2]));
            g.DrawLine(p, 300, Xuli(value[3]), 302, Xuli(value[3]));
            g.DrawLine(p, 400, Xuli(value[4]), 402, Xuli(value[4]));
            g.DrawLine(p, 500, Xuli(value[5]), 502, Xuli(value[5]));
            p.Dispose();

            //Nối điểm
            Pen n = new Pen(Color.Red, 2);
            n.StartCap = LineCap.RoundAnchor;
            g.DrawLine(n, 0, Xuli(value[0]), 100, Xuli(value[1])); //Quy uoc khoi dau = 10%
            g.DrawLine(n, 100, Xuli(value[1]), 200, Xuli(value[2]));
            g.DrawLine(n, 200, Xuli(value[2]), 302, Xuli(value[3]));
            g.DrawLine(n, 300, Xuli(value[3]), 402, Xuli(value[4]));
            g.DrawLine(n, 400, Xuli(value[4]), 502, Xuli(value[5]));
            p.Dispose();


            /* define point array to draw a curve: */
            //Point point1 = new Point(50, 200);
            //Point point2 = new Point(100, 300);
            //Point point3 = new Point(150, 60);
            //Point point4 = new Point(200, 160);
            //Point point5 = new Point(250, 250);
            //Point[] Points = { point1, point2, point3, point4, point5 };
            //g.DrawCurve(aPen, Points);

            g.Dispose();
        }

        private void SauThang(PaintEventArgs e, int fr, int to, int y1,int y2, int limit)
        {
            string sql="";
            if (y1 == y2 && fr > 1)
            {
                sql = "select * from ThongKeTaiChinh where Nam=" + y1 + " and (Thang between " + (fr - 1) + " and " + to + ") order by Thang";
            }
            else
            {
                sql = "select * from ThongKeTaiChinh where (Nam=" + y1 + " and Thang >= " + (fr - 1) + ") and (Nam=" + y2 + " and Thang <= " + to + ") order by Nam,Thang";
            }
            //"select * From (select TOP (7) Thang,Nam,CONVERT(varchar,Lai) as Lai from ThongKeTaiChinh order by Thang desc)as a order by a.Thang"
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            int[] value = new int[7];
            int[] month = new int[7];
            int k = 0;
            while (reader.Read())
            {
                value[k] = int.Parse((string)reader["Lai"].ToString().Split('.')[0]);
                month[k] = (int)reader["Thang"];
                k++;
            }
            conn.Close();

            //Display
            x1.Text = "Tháng " + month[1].ToString();
            x2.Text = "Tháng " + month[2].ToString();
            x3.Text = "Tháng " + month[3].ToString();
            x4.Text = "Tháng " + month[4].ToString();
            x5.Text = "Tháng " + month[5].ToString();
            x6.Text = "Tháng " + month[6].ToString();

            // Xử lí chuyển sang tỉ lệ %
            int[] rate = new int[6];
            int r = 0;
            for (int i = 1; i < 7; i++)
            {
                double t = (((value[i] - value[i - 1]) * 1.0) / value[i - 1]* 1.0) *100;
                rate[r] = int.Parse(String.Format("{0:0}", t));
                r++;
            }

            r1.Text = value[1] + " - "+ rate[0].ToString().Replace("-","") + "%";
            if(rate[1] > rate[0] )
                r1.Location = new System.Drawing.Point(5, (352+Xuli(rate[0])));
            else
                r1.Location = new System.Drawing.Point(5, (352 + Xuli(rate[0]))-10);

            r2.Text = value[2] + " - " + rate[1].ToString().Replace("-", "") + "%";
            if (rate[2] > rate[1])
                r2.Location = new System.Drawing.Point(90, (352 + Xuli(rate[1])));
            else
                r2.Location = new System.Drawing.Point(90, (352 + Xuli(rate[1])) - 20);

            r3.Text = value[3] + " - " + rate[2].ToString().Replace("-", "") + "%";
            if (rate[3] > rate[2])
                r3.Location = new System.Drawing.Point(190, (352 + Xuli(rate[2])));
            else
                r3.Location = new System.Drawing.Point(190, (352 + Xuli(rate[2])) - 20);

            r4.Text = value[4] + " - " + rate[3].ToString().Replace("-", "") + "%";
            if (rate[4] > rate[3])
                r4.Location = new System.Drawing.Point(290, (352 + Xuli(rate[3])));
            else
                r4.Location = new System.Drawing.Point(290, (352 + Xuli(rate[3])) - 20);

            r5.Text = value[5] + " - " + rate[4].ToString().Replace("-", "") + "%";
            if (rate[5] > rate[4])
                r5.Location = new System.Drawing.Point(390, (352 + Xuli(rate[4])));
            else
                r5.Location = new System.Drawing.Point(390, (352 + Xuli(rate[4])) - 20);

            r6.Text = value[6] + " - " + rate[5].ToString().Replace("-", "") + "%";
            if (rate[5] > rate[4])
                r6.Location = new System.Drawing.Point(450, (352 + Xuli(rate[5])) -20);
            else
                r6.Location = new System.Drawing.Point(450, (352 + Xuli(rate[5])) + 20);

            Graphics g = e.Graphics;
            g.PageUnit = GraphicsUnit.Pixel;
            g.TranslateTransform(70,350); //Gốc tọa độ (0,0)

            // Trục tọa độ
            Pen TTD = new Pen(Color.Black, 1 );
            TTD.StartCap = LineCap.RoundAnchor;
            //TTD.EndCap = LineCap.ArrowAnchor;
                            //aPen.DashStyle = DashStyle.Solid;
                            //aPen.DashOffset = 50;
            g.DrawLine(TTD, 0, 0, 510, 0); //Trục x
            g.DrawLine(TTD, 0, 0, 0, -330);//Trục y
            TTD.Dispose();

            //Display
            Pen m = new Pen(Color.LightGray, 1);
            g.DrawLine(m, -4, -50, 510, -50);
            g.DrawLine(m, -4, -100, 510, -100);
            g.DrawLine(m, -4, -150, 510, -150);
            g.DrawLine(m, -4, -200, 510, -200);
            g.DrawLine(m, -4, -250, 510, -250);
            g.DrawLine(m, -4, -300, 510, -300);

            g.DrawLine(m, 100, 0, 100, 4);
            g.DrawLine(m, 200, 0, 200, 4);
            g.DrawLine(m, 300, 0, 300, 4);
            g.DrawLine(m, 400, 0, 400, 4);
            g.DrawLine(m, 500, 0, 500, 4);
            m.Dispose();

            //Xác định điểm
            Pen p = new Pen(Color.Red, 3);
            p.StartCap = LineCap.RoundAnchor;
            g.DrawLine(p, 0, Xuli(rate[0]), 2, Xuli(rate[0]));
            g.DrawLine(p, 100, Xuli(rate[1]), 102, Xuli(rate[1]));
            g.DrawLine(p, 200, Xuli(rate[2]), 202, Xuli(rate[2]));
            g.DrawLine(p, 300, Xuli(rate[3]), 302, Xuli(rate[3]));
            g.DrawLine(p, 400, Xuli(rate[4]), 402, Xuli(rate[4]));
            g.DrawLine(p, 500, Xuli(rate[5]), 502, Xuli(rate[5]));
            p.Dispose();

            //Nối điểm
            Pen n = new Pen(Color.Red, 2);
            n.StartCap = LineCap.RoundAnchor;
            g.DrawLine(n, 0, Xuli(rate[0]), 100, Xuli(rate[1])); //Quy uoc khoi dau = 10%
            g.DrawLine(n, 100, Xuli(rate[1]), 200, Xuli(rate[2]));
            g.DrawLine(n, 200, Xuli(rate[2]), 302, Xuli(rate[3]));
            g.DrawLine(n, 300, Xuli(rate[3]), 402, Xuli(rate[4]));
            g.DrawLine(n, 400, Xuli(rate[4]), 502, Xuli(rate[5]));
            p.Dispose();


            /* define point array to draw a curve: */
            //Point point1 = new Point(50, 200);
            //Point point2 = new Point(100, 300);
            //Point point3 = new Point(150, 60);
            //Point point4 = new Point(200, 160);
            //Point point5 = new Point(250, 250);
            //Point[] Points = { point1, point2, point3, point4, point5 };
            //g.DrawCurve(aPen, Points);
            
            g.Dispose();
        }

        private int Xuli(int i)
        {
            if (i < 0)
                i = -i;
            i = int.Parse(String.Format("{0:0}", -250 * 1.0 / 100 * i));
            return i;
        }

        private void Growth_Rate_Load(object sender, EventArgs e)
        { 

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

    }
}
