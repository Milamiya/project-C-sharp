using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLDiemSoHocSinhTHPT.BusinessObject;

namespace QLDiemSoHocSinhTHPT.Data
{
    public class NgheNghiepData
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
        public NgheNghiepData()
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM NGHE_NGHIEP");
            this.DataService.Load(cmd);
            return this.DataService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="maNgheNghiep"></param>
        /// <returns></returns>
        public DataTable LayTuMa(int maNghe)
        {
            if (this.DataService == null)
            {
                this.DataService = new DataService();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM NGHE_NGHIEP WHERE MaNghe=maNghe");
            cmd.Parameters.Add("maNghe", SqlDbType.Int).Value = maNghe;
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM NGHE_NGHIEP ORDER BY (MaNghe) DESC");
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
