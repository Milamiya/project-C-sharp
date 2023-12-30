using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace DAL
{
    public class CuonSachDAL
    {
        #region khai báo biến cục bộ
            private OleDbConnection cnn;
            private DAconnect objDAconnect = new DAconnect();
        #endregion

        #region hàm khởi tạo
            public CuonSachDAL()
            { }
        
        #endregion

        #region các hàm  xử lí trong câu lệnh SQL

        /// <summary>
        /// Truy xuất dữ liệu bảng CUONSACH
        /// </summary>
        /// <returns>Datatable cua CUONSACH</returns>
            public DataTable truyXuatDuLieuBang_CuonSach()
            {
                string strTableName = "CUONSACH";
                DataTable dtTemp = objDAconnect.HienThiThongTin(strTableName);
                return dtTemp;
            }

            public DataTable truyXuatDuLieuBang_CuonSach1()
            {
               // string strTableName = "CUONSACH";
                DataTable dtTemp = objDAconnect.HienThiThongTin1();
                return dtTemp;
            }

       



            /// <summary>
            /// hàm thêm vào bảng CUONSACH
            /// </summary>
            /// <param name="maCuonSach">mã cuốn sách</param>
            /// <param name="maDauSach">mã đầu sách</param>
            /// <param name="tinhTrang">tình trạng</param>
            /// <returns>0:không có lỗi; 1:có lỗi; 2:  có mã cuốn sách trong bảng CUONSACH;3: không có mã đầu sách trong bảng DAUSACH</returns>
            public int Them(string maCuonSach,string tenCuonSach, string maDauSach, string tinhTrang)
            {
                if (KiemTraMaCuonSach_BangCuonSach(maCuonSach) == false)
                {
                    if ((KiemTraMaDauSach_BangDauSach(maDauSach) == true) )
                    {
                        bool flag = false;
                        if (tinhTrang == "Chưa Mượn")
                        {
                            flag = false;
                        }
                        string strSQL = "insert into CUONSACH (MaCuonSach,TenCuonSach,MaDauSach,TinhTrang) values('" + maCuonSach + "','" + tenCuonSach + "','" + maDauSach + "'," + flag + ")";
                       
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
            /// cập nhật bảng cuốn sách
            /// </summary>
            /// <param name="maCuonSach">mã cuốn sách</param>
            /// <param name="maDauSach">mã đầu sách</param>
            /// <param name="tinhTrang">tình trạng</param>
            /// <returns>0:không có lỗi; 1:có lỗi; 2:  không có mã cuốn sách trong bảng CUONSACH;3: không có mã đầu sách(mã cuốn sách) trong bảng DAUSACH(MUON)</returns>
            public int CapNhat(string maCuonSach, string tenCuonSach, string maDauSach, string tinhTrang)
            {

                if (KiemTraMaCuonSach_BangCuonSach(maCuonSach) == true)
                {
                    if ((KiemTraMaDauSach_BangDauSach(maDauSach) == true) )
                    {
                        bool flag = true;
                        if (tinhTrang == "Đã Mượn")
                        {
                           
                            return 4;
                        }

                        else
                        {
                            flag = false;
                            string strSQL = "update CUONSACH set TenCuonSach='" + tenCuonSach + "',MaDauSach='" + maDauSach + "',TinhTrang=" + flag + " where MaCuonSach='" + maCuonSach + "'";
                            return objDAconnect.ExecuteQuery(strSQL);
                        }

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
            /// Xóa  thông tin cho bảng CUONSACH
            /// </summary>
            /// <param name="maCuonSach">mã cuốn sách</param>
            /// <returns>0:không có lỗi; 1:có lỗi; 2: không có mã cuốn sách trong bảng CUONSACH</returns>
            public int Xoa(string maCuonSach)
            {
                if (KiemTraMaCuonSach_BangCuonSach(maCuonSach) == true)
                {
                    //câu lệnh sql
                    string strSQL = "delete * from CUONSACH where MaCuonSach='" + maCuonSach + "'";
                    return objDAconnect.ExecuteQuery(strSQL);
                }
                else
                    return 2;
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
            /// kiểm tra mã đầu sách có trong bảng DAUSACH hay ko?
            /// </summary>
            /// <param name="maDauSach">mã đầu sách</param>
            /// <returns>nếu có trả về true,ko trả về false</returns>
            public bool KiemTraMaDauSach_BangDauSach(string maDauSach)
            {
                //câu lệnh sql
                string strSQL = "select count (*) from DAUSACH where MaDauSach='" + maDauSach + "'";
                objDAconnect.KetNoi();
                OleDbCommand command = new OleDbCommand(strSQL, objDAconnect.connect);
                int sodong = (int)command.ExecuteScalar();
                if (sodong > 0)
                    return true;
                else
                    return false;
            }

            
            /// <summary>
            /// kiểm tra mã cuốn sách có trong bảng MUON hay ko?
            /// </summary>
            /// <param name="maCuonSach">mã cuốn sách</param>
            /// <returns>>nếu có trả về true,ko trả về false</returns>
            public bool KiemTraMaCuonSach_BangMuon(string maCuonSach)
            {
                //câu lệnh sql
                string strSQL = "select count (*) from MUON where MaCuonSach='" + maCuonSach + "'";
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
