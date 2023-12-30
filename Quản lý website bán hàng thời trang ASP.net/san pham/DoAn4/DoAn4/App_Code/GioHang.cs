using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;


namespace DoAn4
{
    public class GioHang
    {
        //string strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
        //DataSet ds = new DataSet();
        DataTable dt;
        public GioHang()
        {
            dt = new DataTable();
            dt.Columns.Add("Product_Name");
            dt.Columns.Add("Amount");
            dt.Columns.Add("Price_Export");
            dt.Columns.Add("Size");
            dt.Columns.Add("Color");
            dt.Columns.Add("Material");
            dt.Columns.Add("Weight");
            dt.Columns.Add("Product_ID");
            dt.Columns.Add("Money");
         }

        public DataTable GetDataTable()
        {
            return this.dt;
        }

        /// <summary>
        /// Dien hang hoa vua chon mua vao bang luu tru
        /// </summary>
        /// <param name="tb"></param>
        /// <param name="TenSP"></param>
        /// <param name="soluong"></param>
        /// <param name="gia"></param>
        /// <param name="size"></param>
        /// <param name="mau"></param>
        /// <param name="chatlieu"></param>
        /// <param name="trongluong"></param>
        /// <param name="masp"></param>
        /// <param name="tien"></param>
        public void dienVaoBang( string TenSP, double soluong, double gia, string size, string mau, string chatlieu, string trongluong, string masp, double tien)
        {
            if (dt.Rows.Count != 0)
            {
                bool kiemtra = false;
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr[7].ToString().Equals(masp))
                    {
                        dr[1] = Convert.ToDouble(dr[1].ToString()) + soluong;
                        dr[8] = Convert.ToDouble(dr[1].ToString()) * gia;
                        kiemtra = true;
                    }
                }
                if (!kiemtra)
                {
                    DataRow dr = dt.NewRow();
                    dr[0] = TenSP;
                    dr[1] = soluong;
                    dr[2] = gia;
                    dr[3] = size;
                    dr[4] = mau;
                    dr[5] = chatlieu;
                    dr[6] = trongluong;
                    dr[7] = masp;
                    dr[8] = soluong * gia;
                    dt.Rows.Add(dr);
                }
            }
            else
            {
                DataRow dr = dt.NewRow();
                dr[0] = TenSP;
                dr[1] = soluong;
                dr[2] = gia;
                dr[3] = size;
                dr[4] = mau;
                dr[5] = chatlieu;
                dr[6] = trongluong;
                dr[7] = masp;
                dr[8] = soluong * gia;
                dt.Rows.Add(dr);
            }
        }
    }
}
