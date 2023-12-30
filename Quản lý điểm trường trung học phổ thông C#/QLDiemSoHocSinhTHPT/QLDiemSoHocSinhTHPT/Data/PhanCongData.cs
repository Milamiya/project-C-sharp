using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLDiemSoHocSinhTHPT.BusinessObject;

namespace QLDiemSoHocSinhTHPT.Data
{
    public class PhanCongData
    {
        #region DataService
        private DataService m_DataServcie;

        public DataService DataService
        {
            get { return m_DataServcie; }
            set { m_DataServcie = value; }
        }
	
        #endregion

        public PhanCongData()
        {
            this.DataService = new DataService();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataTable LayDS()
        {
            if(this.DataService == null)
            {
                this.DataService = new DataService();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM PHAN_CONG");
            this.DataService.Load(cmd);
            return this.DataService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="maLop"></param>
        /// <returns></returns>
        public DataTable LayDS(LopInfo lopInfo)
        {
            if(this.DataService == null)
            {
                this.DataService = new DataService();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM PHAN_CONG WHERE MaLopMonHoc IN (SELECT MaLopMonHoc FROM LOP_MONHOC WHERE MaLop=@maLop)");
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = lopInfo.MaLop;
            this.DataService.Load(cmd);
            return this.DataService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="maMonHoc"></param>
        /// <returns></returns>
        public DataTable LayDS(MonHocInfo monHocInfo)
        {
            if (this.DataService == null)
            {
                this.DataService = new DataService();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM PHAN_CONG WHERE MaMonHoc=@maMonHoc");
            cmd.Parameters.Add("maMonHoc", SqlDbType.VarChar).Value = monHocInfo.MaMonHoc;
            this.DataService.Load(cmd);
            return this.DataService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="maGiaoVien"></param>
        /// <returns></returns>
        public DataTable LayDS(GiaoVienInfo giaoVienInfo)
        {
            if (this.DataService == null)
            {
                this.DataService = new DataService();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM PHAN_CONG WHERE MaGiaoVien=@maGiaoVien");
            cmd.Parameters.Add("maGiaoVien", SqlDbType.VarChar).Value = giaoVienInfo.MaGiaoVien;
            this.DataService.Load(cmd);
            return this.DataService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="maPhanCong"></param>
        /// <returns></returns>
        public DataTable LayTuMa(int maPhanCong)
        {
            if (this.DataService == null)
            {
                this.DataService = new DataService();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM PHAN_CONG WHERE MaPhanCong=@maPhanCong");
            cmd.Parameters.Add("maPhanCong", SqlDbType.Int).Value = maPhanCong;
            this.DataService.Load(cmd);
            return this.DataService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="maPhanCong"></param>
        /// <returns></returns>
        public bool XoaTuMa(string maPhanCong)
        {
            if (this.DataService == null)
            {
                this.DataService = new DataService();
            }
            SqlCommand cmd = new SqlCommand("DELETE FROM PHAN_CONG WHERE MaPhanCong=@maPhanCong");
            cmd.Parameters.Add("maPhanCong", SqlDbType.Int).Value = maPhanCong;
            if (this.DataService.ExecuteNonQuery(cmd) == 0)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="monHoc"></param>
        /// <returns></returns>
        public bool Xoa(LopMonHocInfo lopMonHoc)
        {
            if (this.DataService == null)
            {
                this.DataService = new DataService();
            }
            SqlCommand cmd = new SqlCommand("DELETE FROM PHAN_CONG WHERE MaLopMonHoc=@maLopMonHoc");
            cmd.Parameters.Add("maLopMonHoc", SqlDbType.Int).Value = lopMonHoc.MaLopMonHoc;
            if (this.DataService.ExecuteNonQuery(cmd) == 0)
            {
                return false;
            }
            return true;
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
