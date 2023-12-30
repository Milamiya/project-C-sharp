using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Entities;
using Data_Tier;

namespace Business_Tier
{
    public class B_NganhNghe
    {
        D_NganhNghe objNN = new D_NganhNghe();
        public DataTable gettbnganhnghe(){
            return objNN.getAllTable("NganhNghe").Tables["NganhNghe"];
        }
        public int ThemNganhNghe(Nganh_Nghe nn)
        {
            return objNN.ThemNganhNghe(nn);
        }
        public int XoaNganhNghe(string ma)
        {
            return objNN.XoaNganhNghe(ma);
        }
        public int CapNhatNganhNghe(Nganh_Nghe nn)
        {
            return objNN.CapNhatNganhNghe(nn);
        }
        public DataTable LayMaNN_TheoTen(string ten)
        {
            return objNN.getMaNN_TheoTen(ten).Tables["nganhnghe"];
        }
    }
}
