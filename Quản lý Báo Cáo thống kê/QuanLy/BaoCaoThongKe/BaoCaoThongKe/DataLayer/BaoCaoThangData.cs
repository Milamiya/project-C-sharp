using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BaoCaoThongKe.DataLayer
{
    public class BaoCaoThangData
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM BaoCaoThang ORDER BY MaBaoCaoThang DESC");
            return Provider.ExecuteScalar(cmd);
        }

        //

        DataService ds = new DataService();
        //
        public DataTable LayDSBaoCaoThang(int maDoanhNghiep, string nam)
        {
            SqlCommand cmd = new SqlCommand("select T.*, BCT.Thang1, BCT.Thang2, BCT.Thang3, BCT.Thang4, BCT.Thang5, BCT.Thang6, BCT.Thang7, BCT.Thang8, BCT.Thang9, BCT.Thang10, BCT.Thang11, BCT.Thang12 "
                                            + "From ChiTieu T Left Join BaoCaoThang BCT On T.MaChiTieu = BCT.MaChiTieu AND BCT.MaDoanhNghiep = " + maDoanhNghiep + " AND CONVERT(VarChar(4),YEAR(BCT.NgayBaoCao)) = " + nam + "");
                                            //+ "Where BCT.MaDoanhNghep = '" + maDoanhNghiep + "' AND CONVERT(YEAR(VarChar(4),BCT.NgayBaoCao)) = '" + nam + "'");
            ds.Load(cmd);
            return ds;
        }

        //
        public DataTable LayDSBaoCaoThang1(int maDoanhNghiep, string nam)
        {
            SqlCommand cmd = new SqlCommand("select * From BaoCaoThang where MaDoanhNghiep = " + maDoanhNghiep + " AND CONVERT(VarChar(4),YEAR(NgayBaoCao)) = " + nam + "");
            ds.Load(cmd);
            return ds;
        }

        //
        public void LuuBaoCaoThang(int maBaoCaoThang, String maChiTieu, int maDoanhNghiep, int thang1, int thang2, int thang3, int thang4, int thang5, int thang6, int thang7, int thang8, int thang9, int thang10, int thang11, int thang12, DateTime NgayBaoCao)
        {
            DataService m_DData = new DataService();

            SqlCommand cmd = new SqlCommand("INSERT INTO BaoCaoThang(MaBaoCaoThang,MaChiTieu,MaDoanhNghiep,Thang1,Thang2,Thang3,Thang4,Thang5,Thang6,Thang7,Thang8,Thang9,Thang10,Thang11,Thang12,NgayBaoCao)VALUES(@maBaoCaoThang,@maChiTieu,@maDoanhNghiep,@thang1,@thang2,@thang3,@thang4,@thang5,@thang6,@thang7,@thang8,@thang9,@thang10,@thang11,@thang12,@NgayBaoCao)");
            cmd.Parameters.Add("maBaoCaoThang", SqlDbType.Int).Value = maBaoCaoThang;
            cmd.Parameters.Add("maChiTieu", SqlDbType.VarChar).Value = maChiTieu;
            cmd.Parameters.Add("maDoanhNghiep", SqlDbType.Int).Value = maDoanhNghiep;
            cmd.Parameters.Add("thang1", SqlDbType.Int).Value = thang1;
            cmd.Parameters.Add("thang2", SqlDbType.Int).Value = thang2;
            cmd.Parameters.Add("thang3", SqlDbType.Int).Value = thang3;
            cmd.Parameters.Add("thang4", SqlDbType.Int).Value = thang4;
            cmd.Parameters.Add("thang5", SqlDbType.Int).Value = thang5;
            cmd.Parameters.Add("thang6", SqlDbType.Int).Value = thang6;
            cmd.Parameters.Add("thang7", SqlDbType.Int).Value = thang7;
            cmd.Parameters.Add("thang8", SqlDbType.Int).Value = thang8;
            cmd.Parameters.Add("thang9", SqlDbType.Int).Value = thang9;
            cmd.Parameters.Add("thang10", SqlDbType.Int).Value = thang10;
            cmd.Parameters.Add("thang11", SqlDbType.Int).Value = thang11;
            cmd.Parameters.Add("thang12", SqlDbType.Int).Value = thang12;
            cmd.Parameters.Add("NgayBaoCao", SqlDbType.DateTime).Value = NgayBaoCao;

            m_DData.Load(cmd);
        }

        //
        public void SuaBaoCaoThang(string maChiTieu, int maDoanhNghiep, string nam, int thang1, int thang2, int thang3, int thang4, int thang5, int thang6, int thang7, int thang8, int thang9, int thang10, int thang11, int thang12)
        {
            SqlCommand cmd = new SqlCommand("Update BaoCaoThang Set Thang1 = @thang1, Thang2 = @thang2, Thang3 = @thang3, Thang4 = @thang4, Thang5 = @thang5, Thang6 = @thang6, Thang7 = @thang7, Thang8 = @thang8, Thang9 = @thang9, Thang10 = @thang10, Thang11 = @thang11, Thang12 = @thang12"
                                            + " where MaChiTieu = @maChiTieu AND MaDoanhNghiep = @maDoanhNghiep AND CONVERT(VarChar(4),YEAR(NgayBaoCao)) = @nam ");
            cmd.Parameters.Add("@maChiTieu", SqlDbType.VarChar).Value = maChiTieu;
            cmd.Parameters.Add("@maDoanhNghiep", SqlDbType.Int).Value = maDoanhNghiep;
            cmd.Parameters.Add("@nam", SqlDbType.VarChar).Value = nam;
            cmd.Parameters.Add("@thang1", SqlDbType.Int).Value = thang1;
            cmd.Parameters.Add("@thang2", SqlDbType.Int).Value = thang2;
            cmd.Parameters.Add("@thang3", SqlDbType.Int).Value = thang3;
            cmd.Parameters.Add("@thang4", SqlDbType.Int).Value = thang4;
            cmd.Parameters.Add("@thang5", SqlDbType.Int).Value = thang5;
            cmd.Parameters.Add("@thang6", SqlDbType.Int).Value = thang6;
            cmd.Parameters.Add("@thang7", SqlDbType.Int).Value = thang7;
            cmd.Parameters.Add("@thang8", SqlDbType.Int).Value = thang8;
            cmd.Parameters.Add("@thang9", SqlDbType.Int).Value = thang9;
            cmd.Parameters.Add("@thang10", SqlDbType.Int).Value = thang10;
            cmd.Parameters.Add("@thang11", SqlDbType.Int).Value = thang11;
            cmd.Parameters.Add("@thang12", SqlDbType.Int).Value = thang12;

            ds.Load(cmd);
            
        }
        
        //
        public void Update()
        {
            ds.Update();
        }
    }
}
