using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLDiemSoHocSinhTHPT.BusinessObject;

namespace QLDiemSoHocSinhTHPT.Data
{
    public class GiaoVienData
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
        public GiaoVienData()
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM GIAO_VIEN");
            this.DataService.Load(cmd);
            return this.DataService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="monHocInfo"></param>
        /// <returns></returns>
        public DataTable LayDS(MonHocInfo monHocInfo)
        {
            if (this.DataService == null)
            {
                this.DataService = new DataService();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM GIAO_VIEN WHERE MaMonHoc=@maMonHoc");
            cmd.Parameters.Add("maMonHoc", SqlDbType.VarChar).Value = monHocInfo.MaMonHoc;
            this.DataService.Load(cmd);
            return this.DataService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tengv"></param>
        /// <returns></returns>
        public DataTable TimTheoTen(string tengv)
        {
            if (this.DataService == null)
            {
                this.DataService = new DataService();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM GIAO_VIEN WHERE HoTen LIKE N'%" + tengv + "%'");
            this.DataService.Load(cmd);
            return this.DataService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="maGiaoVien"></param>
        /// <returns></returns>
        public DataTable LayTuMa(string maGiaoVien)
        {
            if (this.DataService == null)
            {
                this.DataService = new DataService();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM GIAO_VIEN WHERE MaGiaoVien=@maGiaoVien");
            cmd.Parameters.Add("maGiaoVien", SqlDbType.VarChar).Value = maGiaoVien;
            this.DataService.Load(cmd);
            return this.DataService;
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Update()
        {
            return this.DataService.Update();
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM GIAO_VIEN ORDER BY (MaGiaoVien) DESC");
            return this.DataService.ExecuteScalar(cmd);
        }
    }
}
