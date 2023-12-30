using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

using BaoCaoThongKe.BusinessObject;
namespace BaoCaoThongKe.DataLayer
{
    
    public class NhomThueBao_Data
    {
        DataService DT_SV=new DataService();

        public DataTable Show_NhomThueBao()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM NhomThueBao");
            DT_SV.Load(cmd);
            return DT_SV;
        }
        public void Update()
        {
            DT_SV.Update();
        }
        public DataTable LayMaMax()
        {
            SqlCommand cmd = new SqlCommand("select MAX(MaThueBao) from NhomThueBao");
            DT_SV.Load(cmd);
            return DT_SV;
        }

        public void Xoa(NhomThueBao_InFo thuebao)
        {
            SqlCommand s = new SqlCommand("Delete NhomThueBao where MaThueBao=@ma");
            s.Parameters.Add("@ma", SqlDbType.Int).Value = thuebao.MaThueBao;
            DT_SV.Load(s);
        }

        public void Them(NhomThueBao_InFo thuebao)
        {
            SqlCommand s = new SqlCommand("INSERT INTO NhomThueBao(MaThueBao, TenThueBao) VALUES(@ma, @ten)");
            s.Parameters.Add("@ma", SqlDbType.Int).Value = thuebao.MaThueBao;
            s.Parameters.Add("@ten", SqlDbType.NVarChar, 50).Value = thuebao.TenThueBao;
            DT_SV.Load(s);

        }

        public void Sua(NhomThueBao_InFo thuebao)
        {
            SqlCommand s = new SqlCommand("Update NhomThueBao set TenThueBao = @ten where MaThueBao= @ma");
            s.Parameters.Add("@ten", SqlDbType.NVarChar, 50).Value = thuebao.TenThueBao;
            s.Parameters.Add("@ma", SqlDbType.Int).Value = thuebao.MaThueBao;
            DT_SV.Load(s);
        }
        //
        public object GetLastID()
        {
            if (this.DT_SV == null)
            {
                this.DT_SV = new DataService();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM NhomThueBao ORDER BY MaThueBao DESC");
            return DT_SV.ExecuteScalar(cmd);
        }
    }
}
