using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLDiemSoHocSinhTHPT.Data
{
    public class KQHocKyMonHocData
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
        public KQHocKyMonHocData()
        {
            this.DataService = new DataService();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="maHocSinhLop"></param>
        /// <param name="maMonHoc"></param>
        /// <param name="maHocKy"></param>
        /// <returns></returns>
        public DataTable LayTuMa(string maHocSinhLop, string maMonHoc, string maHocKy)
        {
            if (this.DataService == null)
            {
                this.DataService = new DataService();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM KQ_HOC_KY_MON_HOC WHERE MaHocSinhLop=@maHocSinhLop AND MaMonHoc=@maMonHoc AND MaHocKy=@maHocKy");
            cmd.Parameters.Add("maHocSinhLop", SqlDbType.VarChar).Value = maHocSinhLop;
            cmd.Parameters.Add("maMonHoc", SqlDbType.VarChar).Value = maMonHoc;
            cmd.Parameters.Add("maHocKy", SqlDbType.VarChar).Value = maHocKy;
            this.DataService.Load(cmd);
            return this.DataService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="maHocSinhLop"></param>
        /// <param name="maMonHoc"></param>
        /// <param name="maHocKy"></param>
        /// <returns></returns>
        public static bool XoaTuMa(string maHocSinhLop, string maMonHoc, string maHocKy)
        {
            DataService ds = new DataService();
            SqlCommand cmd = new SqlCommand("DELETE FROM KQ_HOC_KY_MON_HOC WHERE MaHocSinhLop=@maHocSinhLop AND MaMonHoc=@maMonHoc AND MaHocKy=@maHocKy");
            cmd.Parameters.Add("maHocSinhLop", SqlDbType.VarChar).Value = maHocSinhLop;
            cmd.Parameters.Add("maMonHoc", SqlDbType.VarChar).Value = maMonHoc;
            cmd.Parameters.Add("maHocKy", SqlDbType.VarChar).Value = maHocKy;
            return (ds.ExecuteNonQuery(cmd) > 0);
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
