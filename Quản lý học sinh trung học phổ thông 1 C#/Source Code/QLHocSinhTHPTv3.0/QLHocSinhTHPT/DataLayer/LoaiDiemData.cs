using System;
using System.Data;
using System.Data.SqlClient;

namespace QLHocSinhTHPT.DataLayer
{
    public class LoaiDiemData
    {
        DataService m_LoaiDiemData = new DataService();

        public DataTable LayDsLoaiDiem()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM LOAIDIEM");
            m_LoaiDiemData.Load(cmd);
            return m_LoaiDiemData;
        }

        public DataRow ThemDongMoi()
        {
            return m_LoaiDiemData.NewRow();
        }

        public void ThemLoaiDiem(DataRow m_Row)
        {
            m_LoaiDiemData.Rows.Add(m_Row);
        }

        public bool LuuLoaiDiem()
        {
            return m_LoaiDiemData.ExecuteNoneQuery() > 0;
        }
    }
}
