using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using QuanLyVayVonChoNHCSXH.Setting;
using System.Data.OleDb;

namespace QuanLyVayVonChoNHCSXH.Setting
{
    public class ThamSo
    {
        public enum Controll
        {
            Normal,
            Addnew,
            Edit,
            noreally,
            aa,
            Add,     
            Remove,
            Save
        }

        public static bool LaSoNguyen(String so)
        {
            try
            {
                Convert.ToInt64(so);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static long LayMaDoiTac()
        {
            DataService ds = new DataService();
            object obj =ds.ExecuteNoneQuery(new SqlCommand("SELECT DoiTac FROM ThamSo"));
            return Convert.ToInt64(obj);
        }


        public static void GanMaDoiTac(long id)
        {
            DataService ds = new DataService();
            ds.ExecuteNoneQuery(new SqlCommand("UPDATE ThamSo SET DoiTac = " + id));

        }

        public static long LayMaNhanVien()
        {
            DataService ds = new DataService();
            object obj = ds.ExecuteScalar(new SqlCommand("SELECT NhanVien FROM ThamSo"));
            return Convert.ToInt64(obj);
        }


        public static void GanMaNhanVien(long id)
        {
            DataService ds = new DataService();
            ds.ExecuteNoneQuery(new SqlCommand("UPDATE ThamSo SET NhanVien = " + id));

        }

        public static long LaySoKheUoc()
        {
            DataService ds = new DataService();
            object obj = ds.ExecuteScalar(new SqlCommand("SELECT SoKheUoc FROM ThamSo"));
            return Convert.ToInt64(obj);
        }


        public static void GanSoKheUoc(long id)
        {
            DataService ds = new DataService();
            ds.ExecuteNoneQuery(new SqlCommand("UPDATE ThamSo SET SoKheUoc = " + id));

        }

       
        public static long LayMaTV()
        {
            DataService ds = new DataService();
            object obj = ds.ExecuteScalar(new SqlCommand("SELECT MaTNTL FROM ThamSo"));
            return Convert.ToInt64(obj);
        }

        public static long LayMaTL()
        {
            DataService ds = new DataService();
            object obj = ds.ExecuteScalar(new SqlCommand("SELECT MaTNTL FROM ThamSo"));
            return Convert.ToInt64(obj);
        }


        public static void GanMaTNTL(long id)
        {
            DataService ds = new DataService();
            ds.ExecuteNoneQuery(new SqlCommand("UPDATE ThamSo SET MaTNTL = " + id));

        }

        public static long SoButToan
        {
            get
            {
                DataService ds = new DataService();
                object obj = ds.ExecuteScalar(new SqlCommand("SELECT SoButToan FROM ThamSo"));
                return Convert.ToInt64(obj);
            }
            set
            {
                DataService ds = new DataService();
                ds.ExecuteNoneQuery(new SqlCommand("UPDATE ThamSo SET SoButToan = " + value));
            }
        }




    }
}
