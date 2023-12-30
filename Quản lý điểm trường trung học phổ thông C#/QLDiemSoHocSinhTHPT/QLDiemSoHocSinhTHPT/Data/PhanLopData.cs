using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLDiemSoHocSinhTHPT.BusinessObject;

namespace QLDiemSoHocSinhTHPT.Data
{
    public class PhanLopData
    {
        #region DataService
        private DataService m_DataService;

        public DataService DataService
        {
            get { return m_DataService; }
            set { m_DataService = value; }
        }

        #endregion

        public PhanLopData()
        {
            this.DataService = new DataService();
        }
        /// <summary>
        /// Lay danh sach phan lop, liet ke tat ca
        /// </summary>
        /// <returns></returns>
        public DataTable LayDS()
        {
            if (this.DataService == null)
            {
                this.DataService = new DataService();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FORM PHAN_LOP ORDER BY (MaHocSinhLop) ASC");
            this.DataService.Load(cmd);
            return this.DataService;
        }

        /// <summary>
        /// Lay danh sach phan lop theo ma lop
        /// </summary>
        /// <param name="maLop"></param>
        /// <returns></returns>
        public DataTable LayDSTuMaLop(string maLop)
        {
            if (this.DataService == null)
            {
                this.DataService = new DataService();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM PHAN_LOP WHERE MaLop=@maLop ORDER BY (MaHocSinhLop) ASC");
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;
            this.DataService.Load(cmd);
            return this.DataService;
        }

        /// <summary>
        /// Lay danh sach phan lop theo ma lop cu va ma lop moi.
        /// Nhung hoc sinh trong lop cu khong ton tai trong lop moi
        /// </summary>
        /// <param name="maLopCu"></param>
        /// <param name="maLopMoi"></param>
        /// <returns></returns>
        public DataTable LayDSLopCu(string maLopCu, string maNamHocMoi)
        {
            if (this.DataService == null)
            {
                this.DataService = new DataService();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM PHAN_LOP WHERE MaLop=@maLopCu AND MaHocSinh NOT IN (SELECT MaHocSinh FROM PHAN_LOP, LOP WHERE PHAN_LOP.MaLop=LOP.MaLop AND MaNamHoc=@maNamHocMoi) ORDER BY (MaHocSinhLop) ASC");
            cmd.Parameters.Add("maLopCu", SqlDbType.VarChar).Value = maLopCu;
            cmd.Parameters.Add("maNamHocMoi", SqlDbType.VarChar).Value = maNamHocMoi;
            this.DataService.Load(cmd);
            return this.DataService;
        }

        /// <summary>
        /// Lay danh sach phan lop tu ma hoc sinh
        /// </summary>
        /// <param name="maHocSinh"></param>
        /// <returns></returns>
        public DataTable LayDSTuMaHocSinh(String maHocSinh)
        {
            if (this.DataService == null)
            {
                this.DataService = new DataService();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM PHAN_LOP WHERE maHocSinh=@maHocSinh ORDER BY (MaHocSinhLop) ASC");
            cmd.Parameters.Add("maHocSinh", SqlDbType.VarChar).Value = maHocSinh;
            this.DataService.Load(cmd);
            return this.DataService;
        }

        /// <summary>
        /// Lay mot phan lop tu ma phan lop (MaHocSinhLop)
        /// </summary>
        /// <param name="maHocSinhLop"></param>
        /// <returns></returns>
        public DataTable LayTuMa(String maHocSinhLop)
        {
            if (this.DataService == null)
            {
                this.DataService = new DataService();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM PHAN_LOP WHERE MaHocSinhLop=@maHocSinhLop ORDER BY (MaHocSinhLop) ASC");
            cmd.Parameters.Add("maHocSinhLop", SqlDbType.VarChar).Value = maHocSinhLop;
            this.DataService.Load(cmd);
            return this.DataService;
        }

        /// <summary>
        /// Lay ma cua record phan lop cuoi cung trong bang phan lop
        /// </summary>
        /// <param name="maLop"></param>
        /// <returns></returns>
        public object LayMaCuoi(string maLop)
        {
            if (this.DataService == null)
            {
                this.DataService = new DataService();
            }
            SqlCommand cmd = new SqlCommand("SELECT MaHocSinhLop FROM PHAN_LOP WHERE MaLop=@maLop ORDER BY (MaHocSinhLop) DESC");
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;
            return this.DataService.ExecuteScalar(cmd);            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int ThemPhanLop(PhanLopInfo info)
        {
            DataService ds = new DataService();
            SqlCommand cmd = new SqlCommand("INSERT INTO PHAN_LOP VALUES(@maHocSinhLop, @maLop, @maHocSinh)");
            cmd.Parameters.Add("maHocSinhLop", SqlDbType.VarChar).Value = info.MaHocSinhLop;
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = info.MaLop;
            cmd.Parameters.Add("maHocSinh", SqlDbType.VarChar).Value = info.MaHocSinh;
            return ds.ExecuteNonQuery(cmd);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool Update()
        {
            return this.DataService.Update();
        }

    }
}
