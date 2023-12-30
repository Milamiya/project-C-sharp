
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace DATA_Tier
{
    public class CaSi_DATA
    {
        //khai báo
        ConnectDB objCon = new ConnectDB();

        #region hàm lấy dử liệu bảng
        /// <summary>
        /// hàm lấy bảng ca sĩ
        /// </summary>
        /// <returns>trả về bảng ca sĩ</returns>
        public DataTable getCasi()
        {
            return objCon.getAllTable("CASI").Tables["CASI"];
        }

        /// <summary>
        /// hàm lấy bảng ca sĩ với mã ca sĩ
        /// </summary>
        /// <param name="macasi">mã ca sĩ cần lấy</param>
        /// <returns>trả về 1 bảng có 1 ca sĩ với mã ca sĩ truyền vào</returns>
        public DataTable getCaSi_by_macasi(string macasi)
        {
            
            OleDbCommand cmd = new OleDbCommand("select * from CASI where macasi = @macasi", objCon.con);
            cmd.Parameters.Add("@macasi", OleDbType.BSTR).Value = macasi;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand=cmd;
            DataSet ds = new DataSet();
            da.Fill(ds, "casi");
            return ds.Tables["casi"];
        }
        #endregion

        #region các phương thức xử lý
        /// <summary>
        /// hàm thêm ca sĩ
        /// </summary>
        /// <param name="macasi">mã ca sĩ</param>
        /// <param name="tencasi">tên ca sĩ</param>
        /// <param name="thongtincasi">thông tin ca sĩ</param>
        /// <returns>trả về 0 nếu 0 có lỗi (thêm thành công)</returns>
        public int themCaSi(string macasi, string tencasi,string thongtincasi)
        {
            return objCon.executeNonQuery("Insert into CASI values('" + macasi + "','" + tencasi + "','" + thongtincasi + "')");
        }

        /// <summary>
        /// hàm xóa ca sĩ (xóa luôn các bài hát của ca sĩ đó thể hiện)
        /// </summary>
        /// <param name="macasi">mã ca sĩ cần xóa</param>
        /// <returns>trả về 0 nếu 0 có lỗi (xóa thành công)</returns>
        public int xoaCaSi(string macasi)
        {
            objCon.executeNonQuery("DELETE FROM BAIHAT WHERE macasi ='" + macasi + "'");
            return objCon.executeNonQuery("DELETE FROM CASI WHERE macasi ='" + macasi + "'");
        }

        /// <summary>
        /// hàm cập nhật ca sĩ
        /// </summary>
        /// <param name="macasi">mã ca sĩ cần cập nhật</param>
        /// <param name="tencasi">tên mới của ca sĩ</param>
        /// <param name="thongtincasi">thông tin mới của ca sĩ</param>
        /// <returns>trả về 0 nếu 0 có lỗi (cập nhật thành công)</returns>
        public int capnhatCaSi(string macasi, string tencasi, string thongtincasi)
        {
            return objCon.executeNonQuery("UPDATE CASI SET tencasi ='" + tencasi + "', thongtincasi = '" + thongtincasi + "' WHERE macasi ='" + macasi + "'");
        }
        #endregion
    }
}
