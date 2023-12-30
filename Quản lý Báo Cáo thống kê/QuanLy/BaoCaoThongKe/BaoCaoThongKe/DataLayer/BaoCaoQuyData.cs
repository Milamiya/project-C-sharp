using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BaoCaoThongKe.DataLayer
{
    public class BaoCaoQuyData
    {
        private DataService m_provider;

        public DataService Provider
        {
            get { return m_provider; }
            set { m_provider = value; }
        }

        //Lay ma bao cao HD lon nhat
        public object GetLastID()
        {
            if (this.Provider == null)
            {
                this.Provider = new DataService();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM BaoCaoQuy ORDER BY MaBaoCaoQuy DESC");
            return Provider.ExecuteScalar(cmd);
        }

        //
        DataService ds = new DataService();
        //
        public DataTable LayDSBaoCaoQuy(int maDoanhNghiep, string nam)
        {
            SqlCommand cmd = new SqlCommand("select T.*, BCQ.Quy1, BCQ.Quy2, BCQ.Quy3, BCQ.Quy4 "
                                            + "From ChiTieu T Left Join BaoCaoQuy BCQ On T.MaChiTieu = BCQ.MaChiTieu AND BCQ.MaDoanhNghiep = " + maDoanhNghiep + " AND CONVERT(VarChar(4),YEAR(BCQ.NgayBaoCao)) = " + nam + "");
            //+ "Where BCT.MaDoanhNghep = '" + maDoanhNghiep + "' AND CONVERT(YEAR(VarChar(4),BCT.NgayBaoCao)) = '" + nam + "'");
            ds.Load(cmd);
            return ds;
        }

        //
        public DataTable LayDSBaoCaoQuy1(int maDoanhNghiep, string nam)
        {
            SqlCommand cmd = new SqlCommand("select * From BaoCaoQuy where MaDoanhNghiep = " + maDoanhNghiep + " AND CONVERT(VarChar(4),YEAR(NgayBaoCao)) = " + nam + "");
            ds.Load(cmd);
            return ds;
        }

        //
        public void LuuBaoCaoQuy(int maBaoCaoQuy, String maChiTieu, int maDoanhNghiep, int quy1, int quy2, int quy3, int quy4, DateTime NgayBaoCao)
        {
            DataService m_DData = new DataService();

            SqlCommand cmd = new SqlCommand("INSERT INTO BaoCaoQuy(MaBaoCaoQuy,MaChiTieu,MaDoanhNghiep,Quy1,Quy2,Quy3,Quy4,NgayBaoCao)VALUES(@maBaoCaoQuy,@maChiTieu,@maDoanhNghiep,@quy1,@quy2,@quy3,@quy4,@NgayBaoCao)");
            cmd.Parameters.Add("maBaoCaoQuy", SqlDbType.Int).Value = maBaoCaoQuy;
            cmd.Parameters.Add("maChiTieu", SqlDbType.VarChar).Value = maChiTieu;
            cmd.Parameters.Add("maDoanhNghiep", SqlDbType.Int).Value = maDoanhNghiep;
            cmd.Parameters.Add("quy1", SqlDbType.Int).Value = quy1;
            cmd.Parameters.Add("quy2", SqlDbType.Int).Value = quy2;
            cmd.Parameters.Add("quy3", SqlDbType.Int).Value = quy3;
            cmd.Parameters.Add("quy4", SqlDbType.Int).Value = quy4;
            cmd.Parameters.Add("NgayBaoCao", SqlDbType.DateTime).Value = NgayBaoCao;

            m_DData.Load(cmd);
        }

        //
        public void SuaBaoCaoQuy(string maChiTieu, int maDoanhNghiep, string nam, int quy1, int quy2, int quy3, int quy4)
        {
            SqlCommand cmd = new SqlCommand("Update BaoCaoQuy Set Quy1 = @quy1, Quy2 = @quy2, Quy3 = @quy3, Quy4 = @quy4 "
                                            + " where MaChiTieu = @maChiTieu AND MaDoanhNghiep = @maDoanhNghiep AND CONVERT(VarChar(4),YEAR(NgayBaoCao)) = @nam ");
            cmd.Parameters.Add("@maChiTieu", SqlDbType.VarChar).Value = maChiTieu;
            cmd.Parameters.Add("@maDoanhNghiep", SqlDbType.Int).Value = maDoanhNghiep;
            cmd.Parameters.Add("@nam", SqlDbType.VarChar).Value = nam;
            cmd.Parameters.Add("@quy1", SqlDbType.Int).Value = quy1;
            cmd.Parameters.Add("@quy2", SqlDbType.Int).Value = quy2;
            cmd.Parameters.Add("@quy3", SqlDbType.Int).Value = quy3;
            cmd.Parameters.Add("@quy4", SqlDbType.Int).Value = quy4;

            ds.Load(cmd);

        }

        //
        public void Update()
        {
            ds.Update();
        }
    }
}
