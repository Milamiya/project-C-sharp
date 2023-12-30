using System;
using System.Collections.Generic;
using System.Linq;
using DAL;
using System.Data.SqlClient;
using System.Data;

using System.Text;

namespace BLL
{
    public class ClassBLL
    {
        ClassDAL da = new ClassDAL();
        public void ChuanBi3Table(string MaHK)
        {
            //Table 1
            string sql1 = " select MaSV,'sotinchi'=sum(SoTC) " +
                       " from KetQua kq,HocPhan hp,NhomHocPhan nhp,KeHoachGiangDay khgd " +
                       " where  kq.MaNhomHP=nhp.MaNhomHP and nhp.MaHP=hp.MaHP and khgd.MaKHGD=nhp.MaKHGD and MaHK='" + MaHK + "' " +
                       " group by MaSV ";
            DataTable dt1 = da.GetTable(sql1);
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                string sql_1 = "Insert into Loptc values('" + dt1.Rows[i][0] + "'," + dt1.Rows[i][1] + ")";
                da.ExcuteNonQuery(sql_1);
            }
            //Table 2
            string sql2 = "select MaSV,'cuoiky'=sum(DiemTk10*SoTC) " +
                           " from KetQua kq,NhomHocPhan nhp,HocPhan hp,KeHoachGiangDay khdt " +
                           " where kq.MaNhomHP=nhp.MaNhomHP and nhp.MaHP=hp.MaHP and khdt.MaKHGD=nhp.MaKHGD  and MaHK='" + MaHK + "' " +
                           " group by MaSV ";
            DataTable dt2 = da.GetTable(sql2);
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                string sql_2 = "Insert into Lopdiem10 values('" + dt2.Rows[i][0] + "'," + dt2.Rows[i][1] + ")";
                da.ExcuteNonQuery(sql_2);
            }
            //Table 3
            string sql3 = " select Lopdiem10.MaSV,'TrungBinhCuoiKyHe10'=cuoiky/sotinchi " +
                           " from Lopdiem10 left join Loptc on Loptc.MaSV=Lopdiem10.MaSV";
            DataTable dt3 = da.GetTable(sql3);
            for (int i = 0; i < dt3.Rows.Count; i++)
            {
                string sql_3 = "Insert into DTB values('" + dt3.Rows[i][0] + "'," + dt3.Rows[i][1] + ")";
                da.ExcuteNonQuery(sql_3);
            }
        }
        public void ChuanBi3Table()
        {
            //Table 1
            string sql1 = " select MaSV,'sotinchi'=sum(SoTC) " +
                       " from KetQua kq,HocPhan hp,NhomHocPhan nhp,KeHoachGiangDay khgd " +
                       " where  kq.MaNhomHP=nhp.MaNhomHP and nhp.MaHP=hp.MaHP and khgd.MaKHGD=nhp.MaKHGD " +
                       " group by MaSV ";
            DataTable dt1 = da.GetTable(sql1);
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                string sql_1 = "Insert into Loptc values('" + dt1.Rows[i][0] + "'," + dt1.Rows[i][1] + ")";
                da.ExcuteNonQuery(sql_1);
            }
            //Table 2
            string sql2 = "select MaSV,'cuoiky'=sum(DiemTk10*SoTC) " +
                           " from KetQua kq,NhomHocPhan nhp,HocPhan hp,KeHoachGiangDay khdt " +
                           " where kq.MaNhomHP=nhp.MaNhomHP and nhp.MaHP=hp.MaHP and khdt.MaKHGD=nhp.MaKHGD " +
                           " group by MaSV ";
            DataTable dt2 = da.GetTable(sql2);
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                string sql_2 = "Insert into Lopdiem10 values('" + dt2.Rows[i][0] + "'," + dt2.Rows[i][1] + ")";
                da.ExcuteNonQuery(sql_2);
            }
            //Table 3
            string sql3 = " select Lopdiem10.MaSV,'TrungBinhCuoiKyHe10'=cuoiky/sotinchi " +
                           " from Lopdiem10 left join Loptc on Loptc.MaSV=Lopdiem10.MaSV";
            DataTable dt3 = da.GetTable(sql3);
            for (int i = 0; i < dt3.Rows.Count; i++)
            {
                string sql_3 = "Insert into DTB values('" + dt3.Rows[i][0] + "'," + dt3.Rows[i][1] + ")";
                da.ExcuteNonQuery(sql_3);
            }
        }
        public DataTable XemDiemLop(string MaLop)
        {
            SqlConnection con = new SqlConnection();
            ChuanBi3Table();
            string sql4 = "select sv.MaSV,TenSV,TrungBinhCuoiKyHe10 " +
                          "  from DTB  left join SinhVien sv on DTB.MaSV=sv.MaSV " +
                            " where MaLop='" + MaLop + "'";
            DataTable dt4 = da.GetTable(sql4);
            da.ExcuteNonQuery("delete from Loptc where MaSV in  ( select MaSV from Loptc )");
            da.ExcuteNonQuery("delete from Lopdiem10 where MaSV in  ( select MaSV from Lopdiem10 )");
            da.ExcuteNonQuery("delete from DTB where MaSV in  ( select MaSV from DTB )");
            return dt4;
        }
        public DataTable ThongKeLop(string MaHK,string MaLop,int loai)
        {
            SqlConnection con = da.GetConnect();
            ChuanBi3Table(MaHK);
            //Truy van cuoi cung
            string sql4;
            switch (loai)
            {
                case 0:
                    sql4 = "select sv.MaSV,TenSV,TrungBinhCuoiKyHe10 " +
                           " from DTB  left join SinhVien sv on DTB.MaSV=sv.MaSV " +
                           " where MaLop='" + MaLop + "' and TrungBinhCuoiKyHe10 >= 9";
                    break;
                case 1:
                    sql4 = "select sv.MaSV,TenSV,TrungBinhCuoiKyHe10 " +
                           " from DTB  left join SinhVien sv on DTB.MaSV=sv.MaSV " +
                           " where MaLop='" + MaLop + "' and TrungBinhCuoiKyHe10 >=8 and TrungBinhCuoiKyHe10 < 9";
                    break;
                case 2:
                    sql4 = "select sv.MaSV,TenSV,TrungBinhCuoiKyHe10 " +
                           " from DTB  left join SinhVien sv on DTB.MaSV=sv.MaSV " +
                           " where MaLop='" + MaLop + "' and TrungBinhCuoiKyHe10 >=6.5 and TrungBinhCuoiKyHe10 < 8";    
                    break;
                case 3:
                    sql4 = "select sv.MaSV,TenSV,TrungBinhCuoiKyHe10 " +
                           " from DTB  left join SinhVien sv on DTB.MaSV=sv.MaSV " +
                           " where MaLop='" + MaLop + "' and TrungBinhCuoiKyHe10 >=5 and TrungBinhCuoiKyHe10 < 6.5";
                    break;
                case 4:
                    sql4 = "select sv.MaSV,TenSV,TrungBinhCuoiKyHe10 " +
                           " from DTB  left join SinhVien sv on DTB.MaSV=sv.MaSV " +
                           " where MaLop='" + MaLop + "' and TrungBinhCuoiKyHe10 >=3.5 and TrungBinhCuoiKyHe10 < 5";
                    break;
                default:
                    sql4 = "select sv.MaSV,TenSV,TrungBinhCuoiKyHe10 " +
                           " from DTB  left join SinhVien sv on DTB.MaSV=sv.MaSV " +
                           " where MaLop='" + MaLop + "' and TrungBinhCuoiKyHe10 < 3.5";
                    break;
            }
            DataTable dt4 = da.GetTable(sql4);
            da.ExcuteNonQuery("delete from Loptc where MaSV in  ( select MaSV from Loptc )");
            da.ExcuteNonQuery("delete from Lopdiem10 where MaSV in  ( select MaSV from Lopdiem10 )");
            da.ExcuteNonQuery("delete from DTB where MaSV in  ( select MaSV from DTB )");
            return dt4;
        }
        public DataTable ThongKeKhoiLop(string MaHK, string MaKhoiLop, int loai)
        {
            SqlConnection con = da.GetConnect();
            ChuanBi3Table(MaHK);
            string sql4;
            switch (loai)
            {
                case 0:
                    sql4 = "select sv.MaSV,TenSV,sv.MaLop,TrungBinhCuoiKyHe10 " +
                           " from DTB  left join SinhVien sv on DTB.MaSV=sv.MaSV,KhoiLop kl,Lop l " +
                           " where sv.MaLop=l.MaLop and l.MaKhoiLop=kl.MaKhoiLop " +
                           " and kl.MaKhoiLop='" + MaKhoiLop + "' and TrungBinhCuoiKyHe10 >=9 ";
                    break;
                case 1:
                    sql4 = "select sv.MaSV,TenSV,sv.MaLop,TrungBinhCuoiKyHe10 " +
                           " from DTB  left join SinhVien sv on DTB.MaSV=sv.MaSV,KhoiLop kl,Lop l " +
                           " where sv.MaLop=l.MaLop and l.MaKhoiLop=kl.MaKhoiLop " +
                           " and kl.MaKhoiLop='" + MaKhoiLop + "' and TrungBinhCuoiKyHe10 >=8 and TrungBinhCuoiKyHe10 < 9";
                    break;
                case 2:
                    sql4 = "select sv.MaSV,TenSV,sv.MaLop,TrungBinhCuoiKyHe10 " +
                           " from DTB  left join SinhVien sv on DTB.MaSV=sv.MaSV,KhoiLop kl,Lop l " +
                           " where sv.MaLop=l.MaLop and l.MaKhoiLop=kl.MaKhoiLop " +
                           " and kl.MaKhoiLop='" + MaKhoiLop + "' and TrungBinhCuoiKyHe10 >=6.5 and TrungBinhCuoiKyHe10 < 8";
                    break;
                case 3:
                    sql4 = "select sv.MaSV,TenSV,sv.MaLop,TrungBinhCuoiKyHe10 " +
                           " from DTB  left join SinhVien sv on DTB.MaSV=sv.MaSV,KhoiLop kl,Lop l " +
                           " where sv.MaLop=l.MaLop and l.MaKhoiLop=kl.MaKhoiLop " +
                           " and kl.MaKhoiLop='" + MaKhoiLop + "' and TrungBinhCuoiKyHe10 >=5 and TrungBinhCuoiKyHe10 < 6.5";
                    break;
                case 4:
                    sql4 = "select sv.MaSV,TenSV,sv.MaLop,TrungBinhCuoiKyHe10 " +
                           " from DTB  left join SinhVien sv on DTB.MaSV=sv.MaSV,KhoiLop kl,Lop l " +
                           " where sv.MaLop=l.MaLop and l.MaKhoiLop=kl.MaKhoiLop " +
                           " and kl.MaKhoiLop='" + MaKhoiLop + "' and TrungBinhCuoiKyHe10 >=3.5 and TrungBinhCuoiKyHe10 < 5";
                    break;
                default:
                    sql4 = "select sv.MaSV,TenSV,sv.MaLop,TrungBinhCuoiKyHe10 " +
                           " from DTB  left join SinhVien sv on DTB.MaSV=sv.MaSV,KhoiLop kl,Lop l " +
                           " where sv.MaLop=l.MaLop and l.MaKhoiLop=kl.MaKhoiLop " +
                           " and kl.MaKhoiLop='" + MaKhoiLop + "' and TrungBinhCuoiKyHe10 < 3.5";
                    break;
            }
            DataTable dt4 = da.GetTable(sql4);
            da.ExcuteNonQuery("delete from Loptc where MaSV in  ( select MaSV from Loptc )");
            da.ExcuteNonQuery("delete from Lopdiem10 where MaSV in  ( select MaSV from Lopdiem10 )");
            da.ExcuteNonQuery("delete from DTB where MaSV in  ( select MaSV from DTB )");
            return dt4;
        }
        public int CheckLogin(string name, string pass)
        {
            SqlConnection con = da.GetConnect();
            SqlCommand cmd = new SqlCommand("select *from Users Where Username='"+name+"' and Password='"+pass+"'",con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (dr[2].ToString() == "admin")
                {
                    return 1;
                }
                else 
                { 
                    return 2;
                }
            }
            else
            {
                return -1;
            }
        }
        public string TinhDiemTB(string MaSV, string MaHK)
        {
            SqlConnection con = da.GetConnect();
            con.Open();
            //view tc
            string sql1 = " select 'sotinchi'=sum(SoTC) " +
                               " from KetQua kq,HocPhan hp,NhomHocPhan nhp,KeHoachGiangDay khgd " +
                               " where  kq.MaNhomHP=nhp.MaNhomHP and nhp.MaHP=hp.MaHP and khgd.MaKHGD=nhp.MaKHGD and MaSV='"+MaSV+"' and MaHK='"+MaHK+"' " +
                               " group by MaSV ";
            SqlCommand cmd1 = new SqlCommand(sql1, con);
            string tc = cmd1.ExecuteScalar().ToString();
            // view diem10
            string sql2 = " select 'cuoiky'=sum(DiemTk10*SoTC) " +
                               " from KetQua kq,NhomHocPhan nhp,HocPhan hp,KeHoachGiangDay khdt " +
                               " where kq.MaNhomHP=nhp.MaNhomHP and nhp.MaHP=hp.MaHP and khdt.MaKHGD=nhp.MaKHGD and MaSV='"+MaSV+"'  and MaHK='"+MaHK+"' " +
                               " group by MaSV ";
            SqlCommand cmd2 = new SqlCommand(sql2, con);
            string diem10 = cmd2.ExecuteScalar().ToString();
            //view diem4
            string sql3 = " select 'cuoiky'=sum(DiemTk4*SoTC) " +
                               " from KetQua kq,NhomHocPhan nhp,HocPhan hp,KeHoachGiangDay khdt " +
                               " where kq.MaNhomHP=nhp.MaNhomHP and nhp.MaHP=hp.MaHP and khdt.MaKHGD=nhp.MaKHGD and MaSV='"+MaSV+"' and MaHK='"+MaHK+"' " +
                               " group by MaSV ";
            SqlCommand cmd3 = new SqlCommand(sql3, con);
            string diem4 = cmd3.ExecuteScalar().ToString();

           
            string ketqua="";
            ketqua = Convert.ToDouble(diem10) / Convert.ToDouble(tc) + "," + Convert.ToDouble(diem4) / Convert.ToDouble(tc) ;
            return ketqua;
        }
        public string TinhDiemTB(string MaSV)
        {
            SqlConnection con = da.GetConnect();
            con.Open();
            //view tc
            string sql1 = " select 'sotinchi'=sum(SoTC) " +
                               " from KetQua kq,HocPhan hp,NhomHocPhan nhp,KeHoachGiangDay khgd " +
                               " where  kq.MaNhomHP=nhp.MaNhomHP and nhp.MaHP=hp.MaHP and khgd.MaKHGD=nhp.MaKHGD and MaSV='" + MaSV + "'" +
                               " group by MaSV ";
            SqlCommand cmd1 = new SqlCommand(sql1, con);
            string tc = cmd1.ExecuteScalar().ToString();
            // view diem10
            string sql2 = " select 'cuoiky'=sum(DiemTk10*SoTC) " +
                               " from KetQua kq,NhomHocPhan nhp,HocPhan hp,KeHoachGiangDay khdt " +
                               " where kq.MaNhomHP=nhp.MaNhomHP and nhp.MaHP=hp.MaHP and khdt.MaKHGD=nhp.MaKHGD and MaSV='" + MaSV + "'" +
                               " group by MaSV ";
            SqlCommand cmd2 = new SqlCommand(sql2, con);
            string diem10 = cmd2.ExecuteScalar().ToString();
            //view diem4
            string sql3 = " select 'cuoiky'=sum(DiemTk4*SoTC) " +
                               " from KetQua kq,NhomHocPhan nhp,HocPhan hp,KeHoachGiangDay khdt " +
                               " where kq.MaNhomHP=nhp.MaNhomHP and nhp.MaHP=hp.MaHP and khdt.MaKHGD=nhp.MaKHGD and MaSV='" + MaSV + "'" +
                               " group by MaSV ";
            SqlCommand cmd3 = new SqlCommand(sql3, con);
            string diem4 = cmd3.ExecuteScalar().ToString();


            string ketqua = "";
            ketqua = Convert.ToDouble(diem10) / Convert.ToDouble(tc) + "," + Convert.ToDouble(diem4) / Convert.ToDouble(tc);
            return ketqua;
        }
        public bool Proc_Insert(string proc,string test)
        {
            SqlConnection con = da.GetConnect();
            con.Open();
            SqlCommand cmd = new SqlCommand(proc, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@test", SqlDbType.NVarChar).Value = test;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                return false;
            }
            return true;
        }
        public DataTable XemDiemLop(string MaHK,string MaLop)
        {
            SqlConnection con = new SqlConnection();
            ChuanBi3Table(MaHK);
            string sql4="select sv.MaSV,TenSV,TrungBinhCuoiKyHe10 "+
                          "  from DTB  left join SinhVien sv on DTB.MaSV=sv.MaSV "+
                            " where MaLop='"+MaLop+"'";
            DataTable dt4 = da.GetTable(sql4);
            da.ExcuteNonQuery("delete from Loptc where MaSV in  ( select MaSV from Loptc )");
            da.ExcuteNonQuery("delete from Lopdiem10 where MaSV in  ( select MaSV from Lopdiem10 )");
            da.ExcuteNonQuery("delete from DTB where MaSV in  ( select MaSV from DTB )");
            return dt4;
        }
        public void Insert(string table,string sql)
        {
            sql = "insert into "+table+" values("+sql+")";
            da.ExcuteNonQuery(sql);
        }
        public void Update(string table, string sql)
        {
            sql = "update "+table+" set "+sql+"";
            da.ExcuteNonQuery(sql);
        }
        public void Delete(string table, string sql)
        {
            sql = "delete from "+table+" where "+sql+"";
            da.ExcuteNonQuery(sql);
        }
        public DataTable ShowData(string sql)
        {
            sql = "select *from "+sql+"";
            return da.GetTable(sql);
        }
        public DataTable ShowData_where(string sql)
        {
            return da.GetTable(sql);
        }
    }
}
