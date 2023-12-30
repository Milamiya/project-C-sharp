using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Data.OleDb;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

/// <summary>
/// Summary description for GioHang
/// </summary>
public class GioHangData
{
    DataTable dt;
	public GioHangData()
	{
        dt = new DataTable();
        dt.Columns.Add("Anh");
        dt.Columns.Add("TenSP");
        dt.Columns.Add("SoLuong");
        dt.Columns.Add("Gia");
        dt.Columns.Add("TongGia");       
        dt.Columns.Add("masp");
	}

    public DataTable  setTable()
    {
        return this.dt;
    }

    public DataTable dienVaoBang(DataTable tb, string Anh, string TenSP, double soluong, double gia, string masp)
    {
        if (tb.Rows.Count != 0)
        {
            bool kiemtra = false;
            foreach (DataRow dr in tb.Rows)
            {
                if (dr[1].ToString().Equals(TenSP))
                {
                    dr[2] = Convert.ToDouble(dr[2].ToString()) + 1;
                    dr[4] = Convert.ToDouble(dr[2].ToString()) * gia;
                    kiemtra = true;
                }
            }
            if (!kiemtra)
            {
                DataRow dr = tb.NewRow();
                dr[0] = Anh;
                dr[1] = TenSP;
                dr[2] = soluong;
                dr[3] = gia;
                dr[4] = soluong * gia;
                dr[5] = masp;   
                tb.Rows.Add(dr);
            }
        }
        else
        {
            DataRow dr = tb.NewRow();
            dr[0] = Anh;
            dr[1] = TenSP;
            dr[2] = soluong;
            dr[3] = gia;
            dr[4] = soluong * gia;
            dr[5] = masp;            
            tb.Rows.Add(dr);
        }
        return tb;
    }

    public DataTable xoaDong(DataTable tb, string tensp)
    {
        foreach (DataRow dr in tb.Rows)
        {
            if (dr[1].ToString().Equals(tensp))
            {
                tb.Rows.Remove(dr);
                break;
            }
        }
        return tb;
    }

    public DataTable capNhatlai(DataTable tb, double soluong, string tensp)
    {
        DataTable td = tb;
        foreach (DataRow dr in td.Rows)
        {
            if (tensp.Trim().Equals(dr[1].ToString().Trim()))
            {
                dr[2] = soluong;
                dr[4] = double.Parse(dr[3].ToString()) * soluong;
            }
        }
        return td;
    }
}
