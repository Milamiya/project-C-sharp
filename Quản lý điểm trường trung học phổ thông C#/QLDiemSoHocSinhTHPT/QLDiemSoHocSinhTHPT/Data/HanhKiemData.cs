using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLDiemSoHocSinhTHPT.BusinessObject;

namespace QLDiemSoHocSinhTHPT.Data
{
    public class HanhKiemData
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
        public HanhKiemData()
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM HANH_KIEM");
            this.DataService.Load(cmd);
            return this.DataService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="maDanToc"></param>
        /// <returns></returns>
        public DataTable LayTuMa(int maHanhKiem)
        {
            if (this.DataService == null)
            {
                this.DataService = new DataService();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM HANH_KIEM WHERE MaHanhKiem=@maHanhKiem");
            cmd.Parameters.Add("maHanhKiem", SqlDbType.Int).Value = maHanhKiem;
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
            SqlCommand cmd = new SqlCommand("SELECT MaHanhKiem FROM HANH_KIEM ORDER BY (MaHanhKiem) DESC");
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
