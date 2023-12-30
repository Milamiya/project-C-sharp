using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;


namespace DAL
{
    public class DocGiaDAL
    {
         #region khai báo biến cục bộ
            private OleDbConnection cnn;
            private DAconnect objDAconnect = new DAconnect();
        #endregion

        #region hàm khởi tạo
            public DocGiaDAL()
            { }
        
        #endregion

        #region các hàm  xử lí trong câu lệnh SQL

        /// <summary>
        /// Truy xuất dữ liệu bảng DOCGIA
        /// </summary>
            /// <returns>Datatable cua DOCGIA</returns>
            public DataTable truyXuatDuLieuBang_DocGia()
            {
                string strTableName = "DOCGIA";
                DataTable dtTemp = objDAconnect.HienThiThongTin(strTableName);
                return dtTemp;
            }

            /// <summary>
            /// thêm thông tin vào bảng DOCGIA
            /// </summary>
            /// <param name="maDocGia">mã đọc giả</param>
            /// <param name="hoDocGia">họ đọc giả</param>
            /// <param name="tenLotDocGia">tên lót đọc giả</param>
            /// <param name="tenDocGia">tên đọc giả</param>
            /// <param name="gioiTinh">giới tính</param>
            /// <param name="ngaySinh">ngày sinh</param>
            /// <param name="soNha">số nhà</param>
            /// <param name="duong">đường</param>
            /// <param name="quan">quận</param>
            /// <param name="soDienThoai">số điện thoại</param>
            /// <param name="ngayDK">ngày đăng kí</param>
            /// <param name="ngayHetHanDK">ngày hết hạn đăng kí</param>
            /// <returns>0:không có lỗi; 1:có lỗi; 2:  có mã đọc trong bảng DOCGIA;</returns>
            public int Them(string maDocGia,string hoDocGia, string tenLotDocGia, string tenDocGia,bool gioiTinh,DateTime ngaySinh,string soNha,string duong,string quan,string soDienThoai,DateTime ngayDK,DateTime ngayHetHanDK)
            {
                if (KiemTraMaDocGia_BangDocGia(maDocGia) == false)
                {                    
                        string strSQL = "insert into DOCGIA (MaDocGia,HoDocGia,TenLotDocGia,TenDocGia,GioiTinh,NgaySinh,SoNha,Duong,Quan,SoDienThoai,NgayDangKi,NgayHetHanDK) "+
                            "values('" + maDocGia + "','" + hoDocGia + "','" + tenLotDocGia + "','" + tenDocGia + "'," + gioiTinh + ",'" + ngaySinh + "','" + soNha + "','" + duong + "','" + quan + "','" + soDienThoai + "','" + ngayDK + "','" + ngayHetHanDK + "')";
                         return objDAconnect.ExecuteQuery(strSQL);
                
                }
            else
                return 2;
            }


            /// <summary>
            /// câp nhật thông tin vào bảng DOCGIA
            /// </summary>
            /// <param name="maDocGia">mã đọc giả</param>
            /// <param name="hoDocGia">họ đọc giả</param>
            /// <param name="tenLotDocGia">tên lót đọc giả</param>
            /// <param name="tenDocGia">tên đọc giả</param>
            /// <param name="gioiTinh">giới tính</param>
            /// <param name="ngaySinh">ngày sinh</param>
            /// <param name="soNha">số nhà</param>
            /// <param name="duong">đường</param>
            /// <param name="quan">quận</param>
            /// <param name="soDienThoai">số điện thoại</param>
            /// <param name="ngayDK">ngày đăng kí</param>
            /// <param name="ngayHetHanDK">ngày hết hạn đăng kí</param>
            /// <returns>0:không có lỗi; 1:có lỗi; 2:không  có mã đọc trong bảng DOCGIA;3:có mã đọc giả trong bảng MUON</returns>
            public int CapNhat(string maDocGia, string hoDocGia, string tenLotDocGia, string tenDocGia, bool gioiTinh, DateTime ngaySinh, string soNha, string duong, string quan, string soDienThoai, DateTime ngayDK, DateTime ngayHetHanDK)
            {

                if (KiemTraMaDocGia_BangDocGia(maDocGia) == true)
                {
                    if ((KiemTraMaDocGia_BangMuon(maDocGia) == false))
                    {

                        string strSQL = "update DOCGIA set HoDocGia='" + hoDocGia + "',TenLotDocGia= '"+tenLotDocGia + "',TenDocGia='" + tenDocGia + "',GioiTinh=" + gioiTinh + ",NgaySinh='" + ngaySinh + "',Sonha='" + soNha + "',Duong='" + duong + "',Quan='" + quan + "',SoDienThoai='" + soDienThoai + "',NgayDangKi='" + ngayDK + "',NgayHethanDK='" + ngayHetHanDK + "' where MaDocGia='" + maDocGia + "'";
                        return objDAconnect.ExecuteQuery(strSQL);

                    }
                    else
                    {
                        return 3;
                    }

                }
                else
                    return 2;

            }

            /// <summary>
            /// Xóa  thông tin cho bảng DOCGIA
            /// </summary>
            /// <param name="maDocGia">mã cđọc giả</param>
            /// <returns>0:không có lỗi; 1:có lỗi; 2: không có mã đọc giả trong bảng DOCGIA;3:có mã đọc giả trong bảng MUON</returns>
            public int Xoa(string maDocGia)
            {
                if (KiemTraMaDocGia_BangDocGia(maDocGia) == true)
                {
                    if (KiemTraMaDocGia_BangMuon(maDocGia) == false)
                    {
                        //câu lệnh sql
                        string strSQL = "delete from DOCGIA where MaDocGia='" + maDocGia + "'";
                        return objDAconnect.ExecuteQuery(strSQL);
                    }
                    else
                        return 3;
                }
                else
                    return 2;
            }
            
            /// <summary>
            /// kiểm tra xem mã đọc giả có trong bảng DOCGIA
            /// </summary>
            /// <param name="maDocGia">mã đọc giả</param>
            /// <returns>nếu có trả về true,ko trả về false</returns>
            public bool KiemTraMaDocGia_BangDocGia(string maDocGia)
            {
                //câu lệnh sql
                string strSQL = "select count (*) from DOCGIA where MaDocGia='" + maDocGia + "'";
                objDAconnect.KetNoi();
                OleDbCommand command = new OleDbCommand(strSQL, objDAconnect.connect);
                int sodong = (int)command.ExecuteScalar();
                if (sodong > 0)
                    return true;
                else
                    return false;
            }

            /// <summary>
            /// kiểm tra xem mã đọc giả có trong bảng MUON
            /// </summary>
            /// <param name="maDocGia">mã đọc giả</param>
            /// <returns>nếu có trả về true,ko trả về false</returns>
            public bool KiemTraMaDocGia_BangMuon(string maDocGia)
            {
                //câu lệnh sql
                string strSQL = "select count (*) from MUON where MaDocGia='" + maDocGia + "'";
                objDAconnect.KetNoi();
                OleDbCommand command = new OleDbCommand(strSQL, objDAconnect.connect);
                int sodong = (int)command.ExecuteScalar();
                if (sodong > 0)
                    return true;
                else
                    return false;
            }

            
            
           


        #endregion

    }
}
