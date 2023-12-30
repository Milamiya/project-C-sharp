using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLDiemSoHocSinhTHPT.BusinessObject;

namespace QLDiemSoHocSinhTHPT.Data
{
    public class MonHocData
    {
        #region DataService
        private DataService m_DatService;

        public DataService DataService
        {
            get { return m_DatService; }
            set { m_DatService = value; }
        }
	
        #endregion
        /// <summary>
        /// 
        /// </summary>
        public MonHocData()
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM MON_HOC");
            this.DataService.Load(cmd);
            return this.DataService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataTable LayDS(LopInfo lopInfo)
        {
            if (this.DataService == null)
            {
                this.DataService = new DataService();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM MON_HOC WHERE MaMonHoc NOT IN (SELECT MaMonHoc FROM LOP_MONHOC WHERE MaLop=@maLop)");
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = lopInfo.MaLop;
            this.DataService.Load(cmd);
            return this.DataService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="maMonHoc"></param>
        /// <returns></returns>
        public DataTable LayTuMa(string maMonHoc)
        {
            if (this.DataService == null)
            {
                this.DataService = new DataService();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM MON_HOC WHERE MaMonHoc=@maMonHoc");
            cmd.Parameters.Add("maMonHoc", SqlDbType.VarChar).Value = maMonHoc;
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
            SqlCommand cmd = new SqlCommand("SELECT MaMonHoc FROM MON_HOC ORDER BY (MaMonHoc) DESC");
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
