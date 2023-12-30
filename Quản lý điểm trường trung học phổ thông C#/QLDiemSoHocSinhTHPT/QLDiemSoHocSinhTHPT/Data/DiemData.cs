using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLDiemSoHocSinhTHPT.BusinessObject;

namespace QLDiemSoHocSinhTHPT.Data
{
    public class DiemData
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
        public DiemData()
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM DIEM");
            this.DataService.Load(cmd);
            return this.DataService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hocKy"></param>
        /// <returns></returns>
        public DataTable LayDS(HocKyInfo hocKy)
        {
            if (this.DataService == null)
            {
                this.DataService = new DataService();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM DIEM WHERE MaHocKy=@maHocKy");
            cmd.Parameters.Add("maHocKy", SqlDbType.VarChar).Value = hocKy.MaHocKy;
            this.DataService.Load(cmd);
            return this.DataService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="monHoc"></param>
        /// <returns></returns>
        public DataTable LayDS(MonHocInfo monHoc)
        {
            if (this.DataService == null)
            {
                this.DataService = new DataService();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM DIEM WHERE MaMonHoc=@maMonHoc");
            cmd.Parameters.Add("maMonHoc", SqlDbType.VarChar).Value = monHoc.MaMonHoc;
            this.DataService.Load(cmd);
            return this.DataService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="monHoc"></param>
        /// <param name="hocKy"></param>
        /// <returns></returns>
        public DataTable LayDS(MonHocInfo monHoc, HocKyInfo hocKy)
        {
            if (this.DataService == null)
            {
                this.DataService = new DataService();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM DIEM WHERE MaMonHoc=@maMonHoc AND MaHocKy=@maHocKy");
            cmd.Parameters.Add("maMonHoc", SqlDbType.VarChar).Value = monHoc.MaMonHoc;
            cmd.Parameters.Add("maHocKy", SqlDbType.VarChar).Value = hocKy.MaHocKy;
            this.DataService.Load(cmd);
            return this.DataService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="phanLop"></param>
        /// <param name="monHoc"></param>
        /// <param name="hocKy"></param>
        /// <returns></returns>
        public DataTable LayDS(PhanLopInfo phanLop, MonHocInfo monHoc, HocKyInfo hocKy)
        {
            if (this.DataService == null)
            {
                this.DataService = new DataService();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM DIEM WHERE MaHocSinhLop=@maHocSinhLop AND MaMonHoc=@maMonHoc AND MaHocKy=@maHocKy");
            cmd.Parameters.Add("maHocSinhlop", SqlDbType.VarChar).Value = phanLop.MaHocSinhLop;
            cmd.Parameters.Add("maMonHoc", SqlDbType.VarChar).Value = monHoc.MaMonHoc;
            cmd.Parameters.Add("maHocKy", SqlDbType.VarChar).Value = hocKy.MaHocKy;
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
            SqlCommand cmd = new SqlCommand("SELECT ID FROM DIEM ORDER BY (ID) DESC");
            return this.DataService.ExecuteScalar(cmd);
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
