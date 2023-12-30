using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QLKTX
{
    
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            //Application.Run(new frmBackup());
            //Application.Run(new frmRestore());
            //Application.Run(new frmNguoiDung());//OK
            Application.Run(new frmMainForm());        
            //Application.Run(new frmDanhGiaSinhVien()); //Yes --> OK
            //Application.Run(new frmTraCuuSinhVien()); //Yes --> OK
            //Application.Run(new frmKyLuatSinhVien()); //Yes --> OK
            //Application.Run(new frmHoatDongSinhVien()); //Yes --> OK
            //Application.Run(new SinhVien.frmXepNguoiDungSinhVien()); //Yes --> OK

            //Application.Run(new NguoiDung.frmNhapKWDien_NguoiDung());
            //Application.Run(new NguoiDung.frmNhapDiem_NguoiDung());  //Yes
            //Application.Run(new frmKWDienDanhSinhVien());        //Yes --> OK
            //Application.Run(new frmChuyenNguoiDungSinhVien());        //Yes --> OK
            //Application.Run(new frmHoatDongSinhVien());
            //Application.Run(new frmCanBo());                                  //yes --> OK
            //Application.Run(new Form1());
            //Application.Run(new frmHocKi());                                  //yes
            //Application.Run(new frmQuocTich());                               //yes --> OK
            //Application.Run(new frmTonGiao());                                //yes --> OK
            //Application.Run(new frmDanToc());                                 //yes --> OK            

            //Application.Run(new frmKyLuat());                                 //yes --> OK            
            //Application.Run(new frmDanhGia());                                 //yes --> OK                        

            //Application.Run(new frmThemSinhVien());                           //yes
            //Application.Run(new frmSuaSinhVien()); 
            //Application.Run(new frmNamHoc());                                 //        OK
            //Application.Run(new frmXepLoai());                                //        OK

            //Application.Run(new QLKTX.Dialog.DiaLog_Them_Sua_QuanHe());       //yes --> OK
            //Application.Run(new QLKTX.Dialog.DiaLog_Them_Sua_NgheNghiep());   //yes --> OK
            //Application.Run(new QLKTX.Dialog.DiaLog_Them_Sua_Cap());          //yes --> OK

            //Application.Run(new frmKTX());                                    //yes --> OK
            //Application.Run(new frmDay());                                    //        OK

            //Application.Run(new NguoiDung.frmNguoiDung());                                  //        OK
            //Application.Run(new QLKTX.NguoiDung.frmThongKeSinhVienThuocNguoiDung());            //Yes
            //Application.Run(new QLKTX.Day.frmThongKeSinhVienThuocDay());            //Yes
            //Application.Run(new QLKTX.KTX.frmThongKeSinhVienThuocKTX());            //Yes
            
            //Application.Run(new frmHoatDongSinhVien());      
            //Application.Run(new QLKTX.Dialog.DiaLog_HoatDong());              //        OK
            //Application.Run(new QLKTX.Dialog.DiaLog_ThemDanhGia());               //        OK
            //Application.Run(new QLKTX.Dialog.DiaLog_Cap());                   //        OK
            //Application.Run(new QLKTX.NguoiDung.frmXepLoai());                    //        OK
            
            //Application.Run(new QLKTX.SinhVien.frmXepNguoiDungSinhVien());                    //        
            

            

            }
        
    }
}