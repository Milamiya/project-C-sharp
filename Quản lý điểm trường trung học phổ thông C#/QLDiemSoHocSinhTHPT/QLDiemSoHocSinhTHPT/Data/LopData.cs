using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLDiemSoHocSinhTHPT.BusinessObject;

namespace QLDiemSoHocSinhTHPT.Data
{
    public class LopData
    {
        #region DataService
        private DataService m_DataService;

        public DataService DataService
        {
            get { return m_DataService; }
            set { m_DataService = value; }
        }
	
        #endregion
        /// <summary>
        /// 
        /// </summary>
        public LopData()
        {
            this.DataService = new DataService();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataTable LayDS()
        {
            if (this.DataService == null)
            {
                this.DataService = new DataService();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM LOP ORDER BY (MaLop) ASC");
            this.DataService.Load(cmd);
            return this.DataService;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="maKhoi"></param>
        /// <returns></returns>
        public DataTable LayDS(string maKhoiLop, string maNamHoc)
        {
            if (this.DataService == null)
            {
                this.DataService = new DataService();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM LOP WHERE MaKhoiLop=@maKhoiLop AND MaNamHoc=@maNamHoc");
            cmd.Parameters.Add("maKhoiLop", SqlDbType.VarChar).Value = maKhoiLop;
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;
            this.DataService.Load(cmd);
            return this.DataService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="maKhoiLop"></param>
        /// <param name="maNamHoc"></param>
        /// <param name="maGiaoVien"></param>
        /// <returns></returns>
        public DataTable LayDS(string maKhoiLop, string maNamHoc, string maGiaoVien)
        {
            if (this.DataService == null)
            {
                this.DataService = new DataService();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM LOP WHERE MaKhoiLop=@maKhoiLop AND MaNamHoc=@maNamHoc AND MaLop IN (SELECT MaLop FROM LOP_MONHOC LMH, PHAN_CONG PC WHERE LMH.MaLopMonHoc=PC.MaLopMonHoc AND PC.MaGiaoVien=@maGiaoVien)");
            cmd.Parameters.Add("maGiaoVien", SqlDbType.VarChar).Value = maGiaoVien;
            cmd.Parameters.Add("maKhoiLop", SqlDbType.VarChar).Value = maKhoiLop;
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;
            this.DataService.Load(cmd);
            return this.DataService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="maKhoi"></param>
        /// <returns></returns>
        public DataTable LayDS(string maNamHoc)
        {
            if (this.DataService == null)
            {
                this.DataService = new DataService();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM LOP WHERE MaNamHoc=@maNamHoc");
            //cmd.Parameters.Add("maKhoiLop", SqlDbType.VarChar).Value = maKhoiLop;
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;
            this.DataService.Load(cmd);
            return this.DataService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="maLop"></param>
        /// <returns></returns>
        public DataTable LayTuMa(string maLop)
        {
            if (this.DataService == null)
            {
                this.DataService = new DataService();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM LOP WHERE MaLop=@maLop");
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;
            this.DataService.Load(cmd);
            return this.DataService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public object LayMaCuoi()
        {
            if (this.DataService == null)
            {
                this.DataService = new DataService();
            }
            SqlCommand cmd = new SqlCommand("SELECT MaLop FROM LOP ORDER BY (MaLop) DESC");
            return this.DataService.ExecuteScalar(cmd);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Update()
        {
            return this.DataService.Update();
        }      
    }
}
