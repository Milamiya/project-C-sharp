
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;


namespace DATA_Tier
{
    public class CasiBaiHat_DATA
    {
        // khai báo
        ConnectDB objCon = new ConnectDB();

        // khởi tạo
        public CasiBaiHat_DATA() { }

        #region các hàm lấy dử liệu bảng
        /// <summary>
        /// hàm lấy bảng casi_baihat theo mã bài hát
        /// </summary>
        /// <param name="mabaihat">mã bài hát</param>
        /// <returns>trả về bảng gồm các ca sĩ hát bài hát có mã là mabaihat</returns>
        public DataTable getCasi_BaiHat_by_mabaihat(string mabaihat)
        {
            
            OleDbCommand cmd=new OleDbCommand("select * from CASI_BAIHAT where mabaihat = @mabaihat",objCon.con);
            cmd.Parameters.Add("@mabaihat",OleDbType.BSTR).Value=mabaihat;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds, "Casi_baihat");
            return ds.Tables["Casi_baihat"];
        }

        /// <summary>
        /// hàm lấy bảng casi_baihat theo macasi
        /// </summary>
        /// <param name="macasi">mã ca sĩ</param>
        /// <returns>trả về bảng gồm các bài hát có chung ca sĩ thể hiện</returns>
        public DataTable getCasi_BaiHat_by_macasi(string macasi)
        {
            
            OleDbCommand cmd = new OleDbCommand("select * from CASI_BAIHAT where macasi = @macasi", objCon.con);
            cmd.Parameters.Add("@macasi", OleDbType.BSTR).Value = macasi;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds, "Casi_baihat");
            return ds.Tables["Casi_baihat"];

        }
        #endregion
    }
}
