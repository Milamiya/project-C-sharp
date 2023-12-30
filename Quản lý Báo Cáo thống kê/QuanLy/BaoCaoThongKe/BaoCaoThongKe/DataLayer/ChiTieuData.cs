using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BaoCaoThongKe.DataLayer
{
    class ChiTieuData
    {
        DataService ds = new DataService();

        public DataTable LayDSChiTieu()
        {
            SqlCommand cmd = new SqlCommand("SELECT * From ChiTieu");
            ds.Load(cmd);
            return ds;
        }

        ////
        //public bool XetChiTieu(string maChiTieu)
        //{
        //    SqlCommand cmd = new SqlCommand("SELECT MaChiTieu FROM ChiTieu WHERE MaChiTieu like '" + maChiTieu + "'");
        //    //ds.Load(cmd);
        //    //return ds;
        //    try
        //    {
        //        ds.Load(cmd);
        //        return true;
        //    }
        //    catch (Exception e)
        //    {
        //        e.ToString();
        //        return false;
        //    }
        //}

        public void Update()
        {
            ds.Update();
        }
    }
}
