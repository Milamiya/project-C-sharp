using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLDiemSoHocSinhTHPT.BusinessObject;

namespace QLDiemSoHocSinhTHPT.Data
{
    public class KhoiLopData
    {
        #region DatService
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
        public KhoiLopData()
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM KHOI_LOP");
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM KHOI_LOP ORDER BY (MaKhoiLop) DESC");
            return this.DataService.ExecuteScalar(cmd);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="maNamHoc"></param>
        /// <returns></returns>
        public object LayMaTruoc(string maKhoiLop)
        {
            if (this.DataService == null)
            {
                this.DataService = new DataService();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM KHOI_LOP WHERE MaKhoiLop<@maKhoiLop ORDER BY (MaKhoiLop) DESC");
            cmd.Parameters.Add("maKhoiLop", SqlDbType.VarChar).Value = maKhoiLop;
            return this.DataService.ExecuteScalar(cmd);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="maKhoiLop"></param>
        /// <returns></returns>
        public DataTable LayTuMa(string maKhoiLop)
        {
            if (this.DataService == null)
            {
                this.DataService = new DataService();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM KHOI_LOP WHERE MaKhoiLop=@maKhoiLop");
            cmd.Parameters.Add("maKhoiLop", SqlDbType.VarChar).Value = maKhoiLop;
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
    }
}
