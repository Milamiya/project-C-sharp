using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLDiemSoHocSinhTHPT.BusinessObject;

namespace QLDiemSoHocSinhTHPT.Data
{
    public class LoaiDiemData
    {
        #region DatService
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
        public LoaiDiemData()
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM LOAI_DIEM");
            this.DataService.Load(cmd);
            return this.DataService;
        }

        /// <summary>
        /// v10.1
        /// </summary>
        /// <param name="maLoaiDiem"></param>
        /// <returns></returns>
        public DataTable LayTuMa(string maLoai)
        {
            if (this.DataService == null)
            {
                this.DataService = new DataService();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM LOAI_DIEM WHERE MaLoai=@maLoai");
            cmd.Parameters.Add("maLoai", SqlDbType.VarChar).Value = maLoai;
            this.DataService.Load(cmd);
            return this.DataService;
        }

        /// <summary>
        /// 
        /// </summary>
        public object LayMaCuoi()
        {
            if (this.DataService == null)
            {
                this.DataService = new DataService();
            }
            SqlCommand cmd = new SqlCommand("SELECT MaLoai FROM LOAI_DIEM ORDER BY (MaLoai) DESC");
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
