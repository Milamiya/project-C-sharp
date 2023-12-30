using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace clsDATABASE
{
    public class clsQLTTTH
    {
        OleDbConnection Connec=new OleDbConnection();

        #region Xu ly chung
        public clsQLTTTH()
        {
            string strConnection = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=TrungTam TH.mdb";
            Connec.ConnectionString = strConnection;
            Connec.Open();
        }
        
        public DataTable GetDataTable(string Tenbang)
        {
            string sql;
            DataTable tbl = new DataTable();
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter();
            OleDbCommand cmd = new OleDbCommand();
            sql = "select * from " + Tenbang;
            cmd.Connection = Connec;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            da.SelectCommand = cmd;
            da.Fill(ds, Tenbang);
            tbl = ds.Tables[0];
            return tbl;
        }

        public DataSet Getdataset(string Tablename)
        {
            string SQL;
            DataSet ds = new DataSet();
            OleDbDataAdapter DA;
            SQL= "select * from " + Tablename;
            DA = new OleDbDataAdapter(SQL, Connec);
            DA.Fill(ds, Tablename);
            return ds;
        }
        #endregion

        #region Thong ke hoc vien dau rot theo lop
        public DataSet GetdatasetKQ(string ClassName)
        {
            string sql;
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter();
            OleDbCommand cmd = new OleDbCommand();
            sql = "select HocVien.MaHV,TenHV,Phai,NgaySinh,MonHoc.MaMH,TenMH,Diem,Lop.GVCN,LanThi from Diem,HocVien,MonHoc,Lop where Lop.MaLop=HocVien.MaLop and Diem.MaHV=HocVien.MaHV  and MonHoc.MaMH=Diem.MaMH and HocVien.MaLop='" + ClassName + "'";
            cmd.Connection = Connec;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            da.SelectCommand = cmd;
            da.Fill(ds);
            return ds;
        }
        #endregion

        #region Bao cao

        public DataTable GetDataTableReport(string MaLop)
        {
            string sql;
            OleDbDataAdapter da = new OleDbDataAdapter();
            OleDbCommand cmd = new OleDbCommand();
            DataSet ds = new DataSet();
            if (MaLop != "")
                sql = "SELECT HocVien.MaHV, TenMH, Diem.Diem, Diem.LanThi FROM HocVien , Monhoc ,Diem where  Monhoc.MaMH = Diem.MaMH and HocVien.MaHV = Diem.MaHV and MaLop='" + MaLop + "'";
            else
                sql = "SELECT HocVien.MaHV, TenMH, Diem.Diem, Diem.LanThi FROM HocVien , Monhoc ,Diem where  Monhoc.MaMH = Diem.MaMH and HocVien.MaHV = Diem.MaHV ";
            cmd.Connection = Connec;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            da.SelectCommand = cmd;
            da.Fill(ds, "Report");
            return ds.Tables[0];
        }

        #endregion

        #region Ket Qua Hoc Tap

        #region Tim kiem ket qua
        public DataSet GetdatasetXemKQ(string CodeStu)
        {
            string sql;
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter();
            OleDbCommand cmd = new OleDbCommand();
            sql = "select TenHV,MonHoc.TenMH,Diem,TenLop,LanThi from Diem,HocVien,MonHoc,Lop where HocVien.MaLop=Lop.MaLop and Diem.MaHV=HocVien.MaHV and MonHoc.MaMH=Diem.MaMH and Diem.MaHV='" + CodeStu + "'";
            cmd.Connection = Connec;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            da.SelectCommand = cmd;
            da.Fill(ds);
            return ds;
        }
        #endregion

        #region Xu ly them, sua, xoa ket qua hoc tap

        #region Them ket qua
        public void ThemKQ(string MaHV, string MaMH, string LanThi, string Diem)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                string sql = "insert into Diem(MaHV,MaMH, LanThi, Diem) values('" + MaHV + "','" + MaMH + "','" + LanThi + "','" + Diem + "')";
                cmd.Connection = Connec;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Lưu không thành công\nChương trình không thể lưu bởi vì : " + ex.Message);
            }
        }
        #endregion

        #region Sua ket qua
        public void SuaKQ(string MaHV, string MaMH, string LanThi, string Diem)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                string sql = "update Diem set Diem='" + Diem + "' where MaHV='" + MaHV + "' and MaMH='" + MaMH + "' and LanThi='" + LanThi + "'";
                cmd.Connection = Connec;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Lưu thay đổi không thành công\nChương trình không thể lưu bởi vì : " + ex.Message);
            }
        }
        #endregion

        #region Xoa ket qua
        public void XoaKQ(string MaHV)
        {
            try
            {
                string sql = "Delete From Diem Where MaHV='" + MaHV + "'";
                OleDbCommand cmd = new OleDbCommand(sql, Connec);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Không Thể Xoá kết quả này\nChương trình không thể Xóa bởi vì : " + ex.Message);
            }
        }
        #endregion

        #endregion

        #endregion

        #region Hoc Vien

        #region Tim kiem hoc vien
        public DataSet GetDataSetTimcobanHVMa(string MaHV)//tim co ban theo ma hoc vien
        {
            string SQL;
            DataSet ds = new DataSet();
            OleDbDataAdapter DA;
            SQL = "select * from HocVien where MaHV like '%" + MaHV + "%'";
            DA = new OleDbDataAdapter(SQL, Connec);
            DA.Fill(ds);
            return ds;
        }
        public DataSet GetDataSetTimcobanHVTen(string TenHV)//tim co ban theo ten hoc vien
        {
            string SQL;
            DataSet ds = new DataSet();
            OleDbDataAdapter DA;
            SQL = "select * from HocVien where TenHV like '%" + TenHV + "%'";
            DA = new OleDbDataAdapter(SQL, Connec);
            DA.Fill(ds);
            return ds;
        }
        #endregion

        #region Xu ly them, sua, xoa hoc vien

        #region Them HV
        public void ThemHV(string MaHV, string Ten, bool Phai, DateTime NgaySinh, string diachi, string dienthoai, string malop)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                string sql = "insert into HocVien(MaHV,TenHV, Phai, NgaySinh,DiaChi,DienThoai,MaLop) values('" + MaHV + "','" + Ten + "'," + Phai + ",'" + NgaySinh + "','" + diachi + "','" + dienthoai + "','" + malop + "')";
                cmd.Connection = Connec;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Lưu không thành công\nChương trình không thể lưu bởi vì : " + ex.Message);
            }
        }
        #endregion

        #region Sua HV
        public void SuaHV(string MaHV, string Ten, bool Phai, DateTime NgaySinh, string diachi, string dienthoai, string malop)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                string sql = "update HocVien set TenHV='" + Ten + "', Phai=" + Phai + ",NgaySinh=#" + NgaySinh.ToShortDateString() + "#,DiaChi='" + diachi + "',DienThoai='" + dienthoai + "',MaLop='" + malop + "' where MaHV='" + MaHV + "'";
                cmd.Connection = Connec;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Lưu thay đổi không thành công\nChương trình không thể lưu bởi vì : " + ex.Message);
            }
        }
        #endregion

        #region Ktra trung ma
        public Boolean KTMaHV(string ma)
        {
            DataSet ds = new DataSet();
            string sql = "Select * From HocVien Where MaHV='" + ma + "'";
            OleDbDataAdapter da = new OleDbDataAdapter(sql, Connec);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count == 1)
                return true;
            return false;
        }
        #endregion

        #region Xoa HV
        public void XoaHV(string MaHV)
        {
            try
            {
                string sql = "Delete From HocVien Where MaHV='" + MaHV + "'";
                OleDbCommand cmd = new OleDbCommand(sql, Connec);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Không Thể Xoá học viên này\nChương trình không thể xóa bởi vì : " + ex.Message);
            }
        }
        #endregion

        #endregion

        #endregion

        #region Mon Hoc

        #region tim kiem mon hoc
        public DataSet GetDataSetTimcobanMHMa(string MaMH)//tim co ban theo ma mon hoc
        {
            string SQL;
            DataSet ds = new DataSet();
            OleDbDataAdapter DA;
            SQL = "select * from MonHoc where MaMH like '%" + MaMH + "%'";
            DA = new OleDbDataAdapter(SQL, Connec);
            DA.Fill(ds);
            return ds;
        }
        public DataSet GetDataSetTimcobanMHTen(string TenMH)//tim co ban theo ten mon hoc
        {
            string SQL;
            DataSet ds = new DataSet();
            OleDbDataAdapter DA;
            SQL = "select * from MonHoc where TenMH like '%" + TenMH + "%'";
            DA = new OleDbDataAdapter(SQL, Connec);
            DA.Fill(ds);
            return ds;
        }
        #endregion

        #region Xu ly them, sua, xoa mon hoc

        #region Them moi
        public void ThemMH(string MaMH, string TenMH, string Sotiet)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                string sql = "insert into MonHoc(MaMH, TenMH, Sotiet) values('" + MaMH + "','" + TenMH + "','" + Sotiet + "')";
                cmd.Connection = Connec;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Lưu không thành công\nChương trình không thể lưu bởi vì : " + ex.Message);
            }
        }
        #endregion

        #region Luu sua
        public void SuaMH(string MaMH, string TenMH, string Sotiet)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                string sql = "update MonHoc set TenMH='" + TenMH + "',Sotiet='" + Sotiet + "' where MaMH='" + MaMH + "'";
                cmd.Connection = Connec;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Lưu thay đổi không thành công\nChương trình không thể lưu bởi vì : " + ex.Message);
            }
        }
        #endregion

        #region Ktra ma
        public Boolean KTMaMH(string ma)
        {
            DataSet ds = new DataSet();
            string sql = "Select * From MonHoc Where MaMH='" + ma + "'";
            OleDbDataAdapter da = new OleDbDataAdapter(sql, Connec);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count == 1)
                return true;
            return false;
        }
        #endregion

        #region Xoa
        public void XoaMH(string MaMH)
        {
            try
            {
                string sql = "Delete From MonHoc Where MaMH='" + MaMH + "'";
                OleDbCommand cmd = new OleDbCommand(sql, Connec);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Không Thể Xoá môn này\nChương trình không thể xóa bởi vì : " + ex.Message);
            }
        }
        #endregion

        #endregion

        #endregion

        #region Lop Hoc

        #region tim kiem lop hoc
        public DataSet GetDataSetTimcobanLHMa(string MaLH)//tim co ban theo ma lop
        {
            string SQL;
            DataSet ds = new DataSet();
            OleDbDataAdapter DA;
            SQL = "select * from Lop where MaLop like '%" + MaLH + "%'";
            DA = new OleDbDataAdapter(SQL, Connec);
            DA.Fill(ds);
            return ds;
        }
        public DataSet GetDataSetTimcobanLHTen(string TenLH)//tim co ban theo ten lop
        {
            string SQL;
            DataSet ds = new DataSet();
            OleDbDataAdapter DA;
            SQL = "select * from Lop where TenLop like '%" + TenLH + "%'";
            DA = new OleDbDataAdapter(SQL, Connec);
            DA.Fill(ds);
            return ds;
        }
        #endregion

        #region Xu ly them, sua, xoa, KTra ma lop

        #region Them lop
        public void ThemLH(string MaLH, string TenLH, string KhoaHoc, string GVCN, DateTime NgayKG)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                string sql = "insert into Lop(MaLop, TenLop, KhoaHoc, GVCN, NgayKG) values('" + MaLH + "','" + TenLH + "','" + KhoaHoc + "','"+ GVCN + "','"+ NgayKG + "')";
                cmd.Connection = Connec;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Lưu không thành công\nChương trình không thể lưu bởi vì : " + ex.Message);
            }
        }
        #endregion

        #region Sua lop
        public void SuaLH(string MaLH, string TenLH, string KhoaHoc, string GVCN, DateTime NgayKG)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                string sql = "update Lop set TenLop='" + TenLH + "',KhoaHoc='" + KhoaHoc + "',GVCN='"+ GVCN+ "',NgayKG=#"+ NgayKG.ToShortDateString()+ "# where MaLop='" + MaLH + "'";
                cmd.Connection = Connec;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Lưu thay đổi không thành công\nChương trình không thể lưu bởi vì : " + ex.Message);
            }
        }
        #endregion

        #region Kiem tra trung ma 
        public Boolean KTMaLop(string ma)
        {
            DataSet ds = new DataSet();
            string sql = "Select * From Lop Where MaLop='" + ma + "'";
            OleDbDataAdapter da = new OleDbDataAdapter(sql, Connec);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count == 1)
                return true;
            return false;
        }
        #endregion

        #region Xoa lop
        public void XoaLop(string MaLop)
        {
            try
            {
                string sql = "Delete From Lop Where MaLop='" + MaLop + "'";
                OleDbCommand cmd = new OleDbCommand(sql, Connec);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Không Thể Xoá lớp này\nChương trình không thể xóa bởi vì : " + ex.Message);
            }
        }
        #endregion

        #endregion

        #endregion
    }
}
