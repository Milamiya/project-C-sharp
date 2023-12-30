using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLDiemSoHocSinhTHPT.Data
{
    public class KQCaNamMonHocData
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
        public KQCaNamMonHocData()
        {
            this.DataService = new DataService();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="maHocSinhLop"></param>
        /// <param name="maMonHoc"></param>
        /// <returns></returns>
        public DataTable LayTuMa(string maHocSinhLop, string maMonHoc)
        {
            if (this.DataService == null)
            {
                this.DataService = new DataService();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM KQ_CA_NAM_MON_HOC WHERE MaHocSinhLop=@maHocSinhLop AND MaMonHoc=@maMonHoc");
            cmd.Parameters.Add("maHocSinhLop", SqlDbType.VarChar).Value = maHocSinhLop;
            cmd.Parameters.Add("maMonHoc", SqlDbType.VarChar).Value = maMonHoc;
            this.DataService.Load(cmd);
            return this.DataService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="maHocSinhLop"></param>
        /// <param name="maMonHoc"></param>
        /// <returns></returns>
        public static bool XoaTuMa(string maHocSinhLop, string maMonHoc)
        {
            DataService ds = new DataService();
            SqlCommand cmd = new SqlCommand("DELETE FROM KQ_CA_NAM_MON_HOC WHERE MaHocSinhLop=@maHocSinhLop AND MaMonHoc=@maMonHoc");
            cmd.Parameters.Add("maHocSinhLop", SqlDbType.VarChar).Value = maHocSinhLop;
            cmd.Parameters.Add("maMonHoc", SqlDbType.VarChar).Value = maMonHoc;
            return (ds.ExecuteNonQuery(cmd) > 0);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="maHocSinhLop"></param>
        /// <param name="maMonHoc"></param>
        public object TinhDTBMonCaNam(string maHocSinhLop, string maMonHoc)
        {
            DataService ds = new DataService();
            SqlCommand cmd = new SqlCommand("SELECT SUM(K.DiemNhanHeSo)/SUM(K.HeSo) FROM " +
                "(SELECT KQHK.MaHocSinhLop, KQHK.MaMonHoc, KQHK.MaHocKy, KQHK.DTBMonHocKy*KQHK.HeSo AS DiemNhanHeSo, KQHK.HeSo FROM " +
                    "(SELECT KQ.MaHocSinhLop, KQ.MaMonHoc, KQ.MaHocKy, KQ.DTBMonHocKy, HK.HeSo FROM "+
                        "KQ_HOC_KY_MON_HOC KQ, HOC_KY HK  WHERE KQ.MaHocKy=HK.MaHocKy AND KQ.MaHocSinhLop=@maHocSinhLop AND KQ.MaMonHoc=@maMonhoc) "+
                    "KQHK)"+
                " K");
            cmd.Parameters.Add("maHocSinhLop", SqlDbType.VarChar).Value = maHocSinhLop;
            cmd.Parameters.Add("maMonHoc", SqlDbType.VarChar).Value = maMonHoc;
            return ds.ExecuteScalar(cmd);
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
