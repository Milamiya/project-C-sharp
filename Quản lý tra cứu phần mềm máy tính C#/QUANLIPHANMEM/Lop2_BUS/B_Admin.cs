using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using Lop3_DAL;

using Enities;

namespace Lop2_BUS
{
   public class B_Admin
    {
       D_Admin objAD = new D_Admin();
        private String id;
       private String matkhau;
       private String ho;
       private String ten;
       private String diachi;
       private String cmnd;
       private String chuoisobimat;
        public String Id
        {
            get { return id; }
            set { id = value; }
        }
        public String Matkhau
        {
            get { return matkhau; }
            set { matkhau = value; }
        }
        public String Ho
        {
            get { return ho; }
            set { ho = value; }
        }
        public String Ten
        {
            get { return ten; }
            set { ten = value; }
        }
        public String DiaChi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        public String CMND
        {
            get { return cmnd; }
            set { cmnd = value; }
        }
        public String ChuoiSoBiMat
        {
            get { return chuoisobimat; }
            set { chuoisobimat = value; }
        }
       public B_Admin(){}
       public B_Admin(string ID, string MatKhau)
       {
           id = ID;
           matkhau = MatKhau;
       }
       public B_Admin(string ID, string Matkhau, string Ho, string Ten, string DiaChi, string CMND, string ChuoiSoBiMat)
       {
           ID = id;
           Matkhau = matkhau;
           Ho = ho;
           Ten = ten;
           DiaChi = diachi;
           CMND = cmnd;
           ChuoiSoBiMat = chuoisobimat;
       }
       D_Admin ad = new D_Admin();
       public bool Log_In()
       {

           return ad.Log_In(Id, Matkhau);
       }

       public DataTable gettb_ADMIN()
       {
           return objAD.getAllTable("ADMIN").Tables["ADMIN"];
       }
       public void DangKi_Admin(DataTable tb)
       {
           objAD.CapNhatDuLieu(tb, "ADMIN");
       }
    }
}
