using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLDiemSoHocSinhTHPT.BusinessObject;
using System.Windows.Forms;

namespace QLDiemSoHocSinhTHPT.Data
{
    public class HocSinhData
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
        public HocSinhData()
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM HOC_SINH");
            this.DataService.Load(cmd);
            return this.DataService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tenhs"></param>
        /// <returns></returns>
        public DataTable TimTenHocSinh(String tenhs)
        {
            if (this.DataService == null)
            {
                this.DataService = new DataService();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM HOC_SINH WHERE HoTen LIKE N'%" + tenhs + "%'");
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM HOC_SINH ORDER BY (MaHocSinh) DESC");
            return this.DataService.ExecuteScalar(cmd);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="maHocSinh"></param>
        /// <returns></returns>
        public DataTable LayTuMa(string maHocSinh)
        {
            if (this.DataService == null)
            {
                this.DataService = new DataService();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM HOC_SINH WHERE MaHocSinh=@maHocSinh");
            cmd.Parameters.Add("maHocSinh", SqlDbType.VarChar).Value = maHocSinh;
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
