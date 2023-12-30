using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace DAL
{
    public class MuonDAL
    {
        #region khai báo biến cục bộ
            private OleDbConnection cnn;
            private DAconnect objDAconnect = new DAconnect();
        #endregion

        #region hàm khởi tạo
            public MuonDAL()
            { }
        
        #endregion

        #region các hàm  xử lí trong câu lệnh SQL

        /// <summary>
        /// Truy xuất dữ liệu bảng MUON
        /// </summary>
            /// <returns>Datatable cua MUON</returns>
            public DataTable truyXuatDuLieuBang_Muon()
            {
                string strTableName = "MUON";
                DataTable dtTemp = objDAconnect.HienThiThongTin(strTableName);
                return dtTemp;
            }

           /// <summary>
           /// thêm thông tin vào bảng MUON
           /// </summary>
           /// <param name="maMuon">mã mượn</param>
           /// <param name="maDocGia">mã đọc giả</param>
           /// <param name="maCuonSach">mã cuốn sách</param>
           /// <param name="soLuong">số lượng</param>
           /// <param name="ngayMuon">ngày mượn</param>
           /// <param name="ngayHenTra">ngày hẹn trả</param>
           /// <param name="ngayTra">ngày trả</param>
            /// <param name="ghiChu">ghi chú</param>
            /// <returns>0:không có lỗi; 1:có lỗi; 2:  có mã mượn trong bảng MUON;3: không có mã đọc giả(mã cuốn sách) trong bảng DOCGIA(CUONSACH)</returns>
            public int Them(string maMuon,string maDocGia, string maCuonSach, int soLuong,DateTime ngayMuon,DateTime ngayHenTra,DateTime ngayTra,string ghiChu)
            {
                if (KiemTraMaMuon_BangMuon(maMuon) == false)
                {
                    if((KiemTraMaDocGia_BangDocGia(maDocGia)==true) && (KiemTraMaCuonSach_BangCuonSach(maCuonSach)==true))
                    {
                       

                        string strSQL = "insert into MUOn (MaMuon,MaDocGia,MaCuonSach,SoLuong,NgayMuon,NgayHenTra,NgayTra,GhiChu) "+
                        "values('" + maMuon + "','" + maDocGia + "','" + maCuonSach + "','" + soLuong + "','" + ngayMuon + "','" + ngayHenTra + "','" + ngayTra + "','" + ghiChu + "')";
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
            /// thêm thông tin vào bảng MUON
            /// </summary>
            /// <param name="maMuon">mã mượn</param>
            /// <param name="maDocGia">mã đọc giả</param>
            /// <param name="maCuonSach">mã cuốn sách</param>
            /// <param name="soLuong">số lượng</param>
            /// <param name="ngayMuon">ngày mượn</param>
            /// <param name="ngayHenTra">ngày hẹn trả</param>
            /// <param name="ngayTra">ngày trả</param>
            /// <param name="ghiChu">ghi chú</param>
            /// <returns>0:không có lỗi; 1:có lỗi; 2:  không có mã mượn trong bảng MUON;3: không có mã đọc giả(mã cuốn sách) trong bảng DOCGIA(CUONSACH)</returns>
            public int CapNhat(string maMuon,string maDocGia, string maCuonSach, int soLuong,DateTime ngayMuon,DateTime ngayHenTra,DateTime ngayTra,string chiChu)
            {

                if (KiemTraMaMuon_BangMuon(maMuon) == true)
                {
                    if ((KiemTraMaDocGia_BangDocGia(maDocGia) == true)&&(KiemTraMaCuonSach_BangCuonSach(maCuonSach)==true))
                    {
                        string strSQL = "update MUON set MaDocGia='" + maDocGia + "',MaCuonSach='" + maCuonSach + "',SoLuong=" + soLuong + ",NgayMuon='" + ngayMuon + "',NgayHenTra='" + ngayHenTra + "',NgayTra='" + ngayTra + "',GhiChu='" + chiChu + "' where MaMuon='" + maMuon + "'";
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
        /// xóa thông tin bảng MUON
        /// </summary>
        /// <param name="maMuon">mã mượn</param>
            /// <returns>0:không có lỗi; 1:có lỗi; 2: không có mã mượn trong bảng MUON</returns>
            public int Xoa(string maMuon)
            {
                if (KiemTraMaMuon_BangMuon(maMuon) == true)
                {
                   
                    //câu lệnh sql
                    string strSQL = "delete from MUON where MaMuon='" + maMuon + "'";
                    return objDAconnect.ExecuteQuery(strSQL);
                }
                else
                    return 2;
            }

            
            /// <summary>
            ///  kiểm tra mã mươn có trong bảng MUON hay ko?
            /// </summary>
            /// <param name="maMuon">mã mượn</param>
            /// <returns>nếu có trả về true,ko trả về false</returns>
            public bool KiemTraMaMuon_BangMuon(string maMuon)
            {
                //câu lệnh sql
                string strSQL = "select count (*) from MUON where MaMuon='" + maMuon + "'";
                objDAconnect.KetNoi();
                OleDbCommand command = new OleDbCommand(strSQL, objDAconnect.connect);
                int sodong = (int)command.ExecuteScalar();
                if (sodong > 0)
                    return true;
                else
                    return false;
            }

            /// <summary>
            /// kiểm tra mã cuốn sách có trong bảng CUONSACH hay ko?
            /// </summary>
            /// <param name="maCuonSach">mã cuốn sách</param>
            /// <returns>nếu có trả về true,ko trả về false</returns>
            public bool KiemTraMaCuonSach_BangCuonSach(string maCuonSach)
            {
                //câu lệnh sql
                string strSQL = "select count (*) from CUONSACH where MaCuonSach='" + maCuonSach + "'";
                objDAconnect.KetNoi();
                OleDbCommand command = new OleDbCommand(strSQL, objDAconnect.connect);
                int sodong = (int)command.ExecuteScalar();
                if (sodong > 0)
                    return true;
                else
                    return false;
            }

           
            /// <summary>
            /// kiểm tra xem mã đọc giả có trong  bảng DOCGIA hay ko?
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

        #endregion

    }
}
