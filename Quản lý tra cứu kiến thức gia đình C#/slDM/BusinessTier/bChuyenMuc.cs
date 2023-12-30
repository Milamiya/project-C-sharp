using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataTier;
using Entities;
using System.Data;
namespace BusinessTier
{
    public class bChuyenMuc
    {
        dChuyenMuc objcm=new dChuyenMuc();
        public DataTable getTable_ChuyenMuc()
        {
            return objcm.GetDataTable("ChuyenMuc").Tables["ChuyenMuc"];
        }
        public int ThemChuyenMuc(string Tencm)
        {
            return objcm.ThemChuyenMuc(Tencm);
        }
    }
}
