using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLDiemSoHocSinhTHPT.Data
{
    public class NguoiDungData
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM NGUOI_DUNG");
            this.DataService.Clear();
            this.DataService.Load(cmd);
            return this.DataService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="maNguoiDung"></param>
        /// <returns></returns>
        public DataTable LayTuMaLoai(String maNguoiDung)
        {
            if (this.DataService == null)
            {
                this.DataService = new DataService();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM NGUOI_DUNG WHERE MaNguoiDung=@maNguoiDung");
            cmd.Parameters.Add("maNguoiDung", SqlDbType.VarChar).Value = maNguoiDung;
            this.DataService.Clear();
            this.DataService.Load(cmd);
            return this.DataService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tendangnhap"></param>
        /// <returns></returns>
        public DataTable LayNguoiDung(string tendangnhap)
        {
            if (this.DataService == null)
            {
                this.DataService = new DataService();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM NGUOI_DUNG WHERE TenDangNhap=@tendangnhap");
            cmd.Parameters.Add("tendangnhap", SqlDbType.VarChar).Value = tendangnhap;
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="info"></param>
        /// <param name="newPassword"></param>
        /// <returns></returns>
        public bool Update(int maNguoiDung, string newPassword)
        {
            if (this.DataService == null)
            {
                this.DataService = new DataService();
            }
            SqlCommand cmd = new SqlCommand("UPDATE NGUOI_DUNG SET Password=@newPassword WHERE MaNguoiDung=@maNguoiDung");
            cmd.Parameters.Add("newPassword", SqlDbType.VarChar).Value = newPassword;
            cmd.Parameters.Add("maNguoiDung", SqlDbType.Int).Value = maNguoiDung;

            return this.DataService.ExecuteNonQuery(cmd) > 0;
        }
    }
}
