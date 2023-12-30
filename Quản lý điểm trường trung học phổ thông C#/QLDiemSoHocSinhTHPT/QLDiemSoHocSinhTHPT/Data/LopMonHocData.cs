using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLDiemSoHocSinhTHPT.BusinessObject;

namespace QLDiemSoHocSinhTHPT.Data
{
    public class LopMonHocData
    {
        #region DataService
        private DataService m_DataServcie;

        public DataService DataService
        {
            get { return m_DataServcie; }
            set { m_DataServcie = value; }
        }

        #endregion

        public LopMonHocData()
        {
            this.DataService = new DataService();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataTable LayDS(bool layTen)
        {
            if (this.DataService == null)
            {
                this.DataService = new DataService();
            }
            SqlCommand cmd;
            if (layTen)
            {
                cmd = new SqlCommand("SELECT * FROM LOP_MONHOC A, MON_HOC B WHERE A.MaMonHoc=B.MaMonHoc");
            }
            else
            {
                cmd = new SqlCommand("SELECT * FROM LOP_MONHOC");
            }
            this.DataService.Load(cmd);
            return this.DataService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="maLop"></param>
        /// <returns></returns>
        public DataTable LayDS(LopInfo lopInfo, bool layTen)
        {
            if (this.DataService == null)
            {
                this.DataService = new DataService();
            }
            SqlCommand cmd;
            if (layTen)
            {
                cmd = new SqlCommand("SELECT * FROM LOP_MONHOC A, MON_HOC B WHERE A.MaMonHoc=B.MaMonHoc AND MaLop=@maLop");
            }
            else
            {
                cmd = new SqlCommand("SELECT * FROM LOP_MONHOC WHERE MaLop=@maLop");
            }
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = lopInfo.MaLop;
            this.DataService.Load(cmd);
            return this.DataService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lopInfo"></param>
        /// <param name="giaoVien"></param>
        /// <param name="layTen"></param>
        /// <returns></returns>
        public DataTable LayDS(LopInfo lopInfo, GiaoVienInfo giaoVien, bool layTen)
        {
            if (this.DataService == null)
            {
                this.DataService = new DataService();
            }
            SqlCommand cmd;
            if (layTen)
            {
                cmd = new SqlCommand("SELECT * FROM LOP_MONHOC A, MON_HOC B WHERE A.MaMonHoc=B.MaMonHoc AND MaLop=@maLop AND MaLopMonHoc IN (SELECT MaLopMonHoc FROM PHAN_CONG WHERE MaGiaoVien=@maGiaoVien)");
                cmd.Parameters.Add("maGiaoVien", SqlDbType.VarChar).Value = giaoVien.MaGiaoVien;
            }
            else
            {
                cmd = new SqlCommand("SELECT * FROM LOP_MONHOC WHERE MaLop=@maLop");
            }
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = lopInfo.MaLop;
            this.DataService.Load(cmd);
            return this.DataService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="phanCongInfo"></param>
        /// <returns></returns>
        public DataTable LayDSChuaPhanCong(string maLop)
        {
            if (this.DataService == null)
            {
                this.DataService = new DataService();
            }
            DataService ds = new DataService();

            SqlCommand cmd = new SqlCommand("SELECT * FROM LOP_MONHOC A, MON_HOC B WHERE A.MaMonHoc=B.MaMonHoc AND A.MaLop=@maLop AND MaLopMonHoc NOT IN (SELECT MaLopMonHoc FROM PHAN_CONG)");
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;
            this.DataService.Load(cmd);
            return this.DataService;
            return this.DataService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="maLopMonHoc"></param>
        /// <returns></returns>
        public DataTable LayTuMa(int maLopMonHoc)
        {
            if (this.DataService == null)
            {
                this.DataService = new DataService();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM LOP_MONHOC WHERE MaLopMonHoc=@maLopMonHoc");
            cmd.Parameters.Add("maLopMonHoc", SqlDbType.Int).Value = maLopMonHoc;
            this.DataService.Load(cmd);
            return this.DataService;
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
