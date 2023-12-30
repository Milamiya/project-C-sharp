using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuanLyHoSoCongChuc.BusinessObject;
using QuanLyHoSoCongChuc.Controller;
using QuanLyHoSoCongChuc.DataLayer;
using System.Data.SqlClient;


namespace QuanLyHoSoCongChuc.Datalayer
{
    public class DangNhapData
    {
     

       
       DataService _provider = new DataService();


        public DataTable DSDangNhap()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM DangNhap");
            _provider.Load(cmd);

            return _provider;
        }

        public DataRow NewRow()
        {
            return _provider.NewRow();
        }
        public void Add(DataRow row)
        {
            _provider.Rows.Add(row);
        }
        public bool Save()
        {
            return _provider.ExecuteNoneQuery() > 0;
        }
    }
}
