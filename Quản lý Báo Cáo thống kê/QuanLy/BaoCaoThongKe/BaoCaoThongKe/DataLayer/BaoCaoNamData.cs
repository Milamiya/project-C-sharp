using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BaoCaoThongKe.DataLayer
{
    public class BaoCaoNamData
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM BaoCaoNam ORDER BY MaBaoCaoNam DESC");
            return Provider.ExecuteScalar(cmd);
        }
        
        //
        DataService ds = new DataService();
        //
        public DataTable LayDSBaoCaoNam(int maDoanhNghiep, string nam)
        {
            SqlCommand cmd = new SqlCommand("select T.*, BCN.SoLuong "
                                            + " From ChiTieu T Left Join BaoCaoNam BCN On T.MaChiTieu = BCN.MaChiTieu AND BCN.MaDoanhNghiep = " + maDoanhNghiep + " AND CONVERT(VarChar(4),YEAR(BCN.NgayBaoCao)) = " + nam + "");
            //+ "Where BCT.MaDoanhNghep = '" + maDoanhNghiep + "' AND CONVERT(YEAR(VarChar(4),BCT.NgayBaoCao)) = '" + nam + "'");
            ds.Load(cmd);
            return ds;
        }

        //
        public DataTable LayDSBaoCaoNam1(int maDoanhNghiep, string nam)
        {
            SqlCommand cmd = new SqlCommand("select * From BaoCaoNam where MaDoanhNghiep = " + maDoanhNghiep + " AND CONVERT(VarChar(4),YEAR(NgayBaoCao)) = " + nam + "");
            ds.Load(cmd);
            return ds;
        }

        //
        public void LuuBaoCaoNam(int maBaoCaoNam, String maChiTieu, int maDoanhNghiep, int soluong, DateTime NgayBaoCao)
        {
            DataService m_DData = new DataService();

            SqlCommand cmd = new SqlCommand("INSERT INTO BaoCaoNam(MaBaoCaoNam,MaChiTieu,MaDoanhNghiep,SoLuong,NgayBaoCao)VALUES(@maBaoCaoNam,@maChiTieu,@maDoanhNghiep,@soluong,@NgayBaoCao)");
            cmd.Parameters.Add("maBaoCaoNam", SqlDbType.Int).Value = maBaoCaoNam;
            cmd.Parameters.Add("maChiTieu", SqlDbType.VarChar).Value = maChiTieu;
            cmd.Parameters.Add("maDoanhNghiep", SqlDbType.Int).Value = maDoanhNghiep;
            cmd.Parameters.Add("soluong", SqlDbType.Int).Value = soluong;
            cmd.Parameters.Add("NgayBaoCao", SqlDbType.DateTime).Value = NgayBaoCao;

            m_DData.Load(cmd);
        }

        //
        public void SuaBaoCaoNam(string maChiTieu, int maDoanhNghiep, string nam, int soluong)
        {
            SqlCommand cmd = new SqlCommand("Update BaoCaoNam Set SoLuong = @soluong"
                                            + " where MaChiTieu = @maChiTieu AND MaDoanhNghiep = @maDoanhNghiep AND CONVERT(VarChar(4),YEAR(NgayBaoCao)) = @nam ");
            cmd.Parameters.Add("@maChiTieu", SqlDbType.VarChar).Value = maChiTieu;
            cmd.Parameters.Add("@maDoanhNghiep", SqlDbType.Int).Value = maDoanhNghiep;
            cmd.Parameters.Add("@nam", SqlDbType.VarChar).Value = nam;
            cmd.Parameters.Add("@soluong", SqlDbType.Int).Value = soluong;

            ds.Load(cmd);

        }

        //
        public void Update()
        {
            ds.Update();
        }
    }
}
