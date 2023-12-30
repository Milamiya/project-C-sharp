using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataTier;
using System.Data;
using Entities;
namespace BusinessTier
{
    public class bMeoVat
    {
        dMeoVat objmv = new dMeoVat();
        public DataTable getTable_MeoVat()
        {
            return objmv.GetDataTable("MeoVat").Tables["MeoVat"];
        }
        public DataTable getTable_MeoVat_Ma_Tendm(string mavn)
        {
            return objmv.getTable_MeoVat_Ma_Tendm(mavn).Tables["MeoVat"];

        }
        public DataTable getTable_MeoVat_Ma(string mamv)
        {
            return objmv.getTable_MeoVat_Ma(mamv).Tables["MeoVat"];
        }
        public DataTable getTable_MeoVat_forsearch()
        {
            return objmv.getTable_MeoVat_forsearch().Tables["MeoVat"];
        }
        public int XoaMeoVat(string ma)
        {
            return objmv.XoaMeoVat(ma);
        }
        public int CapnhapMeoVat(MeoVat mv_)
        {
            return objmv.CapnhapMeoVat(mv_);
        }
        public int Themmeovat(MeoVat mv_)
        {
            return objmv.Themmeovat(mv_);
        }
        public int UpdateDanhgia(string ma, int diem)
        {
            return objmv.UpdateDanhgia(ma, diem);
        }
        public Boolean Kiemtraanhkosudung(string tenanh)
        {
            return objmv.Kiemtraanhkosudung(tenanh);
        }
        public int getMamv_cuoi_tblMeovat()
        {
            return objmv.getMamv_cuoi_tblMeovat();
        }
    }
}
