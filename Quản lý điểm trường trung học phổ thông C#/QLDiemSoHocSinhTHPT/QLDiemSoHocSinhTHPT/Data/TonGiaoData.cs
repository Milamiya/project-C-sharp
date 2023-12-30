using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLDiemSoHocSinhTHPT.BusinessObject;

namespace QLDiemSoHocSinhTHPT.Data
{
    public class TonGiaoData
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
        public TonGiaoData()
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM TON_GIAO");
            this.DataService.Load(cmd);
            return this.DataService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="maTonGiao"></param>
        /// <returns></returns>
        public DataTable LayTuMa(int maTonGiao)
        {
            if (this.DataService == null)
            {
                this.DataService = new DataService();
            }

            SqlCommand cmd = new SqlCommand("SELECT * FROM TON_GIAO WHERE MaTonGiao=@maTonGiao");
            cmd.Parameters.Add("maTocGiao", SqlDbType.Int).Value = maTonGiao;
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM TON_GIAO ORDER BY (MaTonGiao) DESC");
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
