using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLDiemSoHocSinhTHPT.Data
{
    public class LoaiNguoiDungData
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
        /// <returns></returns>
        public DataTable LayDS()
        {
            if (this.DataService == null)
            {
                this.DataService = new DataService();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM LOAI_NGUOI_DUNG");
            this.DataService.Clear();
            this.DataService.Load(cmd);
            return this.DataService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="maLoai"></param>
        /// <returns></returns>
        public DataTable LayTuMaLoai(String maLoai)
        {
            if (this.DataService == null)
            {
                this.DataService = new DataService();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM LOAI_NGUOI_DUNG WHERE MaLoai=@maLoai");
            cmd.Parameters.Add("maLoai", SqlDbType.VarChar).Value = maLoai;
            this.DataService.Clear();
            this.DataService.Load(cmd);
            return this.DataService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="loaiNguoiDung"></param>
        /// <returns></returns>
        public DataTable LayLoaiNguoiDung(int loaiNguoiDung)
        {
            if (this.DataService == null)
            {
                this.DataService = new DataService();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM LOAI_NGUOI_DUNG WHERE MaLoai=@maLoai");
            cmd.Parameters.Add("maLoai", SqlDbType.Char).Value = loaiNguoiDung;
            this.DataService.Load(cmd);
            return this.DataService;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Update()
        {
            this.DataService.Update();
        }
    }
}
