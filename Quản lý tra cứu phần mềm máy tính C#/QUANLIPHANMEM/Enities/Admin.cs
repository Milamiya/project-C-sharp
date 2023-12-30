using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enities
{
   public class Admin
   {
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
       public Admin(){}
       public Admin(string ID, string MatKhau)
       {
           id = ID;
           matkhau = MatKhau;
       }
       public Admin(string ID, string Matkhau, string Ho, string Ten, string DiaChi, string CMND, string ChuoiSoBiMat)
       {
           ID = id;
           Matkhau = matkhau;
           Ho = ho;
           Ten = ten;
           DiaChi = diachi;
           CMND = cmnd;
           ChuoiSoBiMat = chuoisobimat;
       }
    }
}
