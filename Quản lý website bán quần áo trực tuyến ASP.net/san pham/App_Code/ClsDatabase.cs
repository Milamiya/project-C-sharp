

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



public class clsDatabase
{
    //Khai báo các đối tượng thao tác với CSDL
    //string strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["KetNoi"].ToString();
    //string strConnect = System.Configuration.ConfigurationManager.ConnectionStrings["KetNoi"].ToString();
    string strConnect = @"Data Source=.\SQLEXPRESS;Initial Catalog=Shoponline;Integrated Security=True";
    SqlConnection sqlCon;
    SqlCommand sqlCom;
    //SqlDataReader sqlDr;
    SqlDataAdapter sqlAda;
    DataSet ds = new DataSet();
    DataTable tb = new DataTable();
    //Phương thức khởi dựng
    public DataSet GetDaTaSet
    {
        get
        {
            return ds;
        }
    }

    public DataTable FillDataSet(string SelectString, string tenBang)
    {
        sqlCon = new SqlConnection(strConnect);
        sqlAda = new SqlDataAdapter(SelectString, sqlCon);
        if (ds.Tables[tenBang] != null)
        {
            ds.Tables.Remove(tenBang);
        }
        sqlAda.Fill(ds, tenBang);
        sqlAda.Dispose();
        return ds.Tables[tenBang];
    }

    public clsDatabase()
    {
        //Trong phương thức khởi dựng: khởi tạo chuỗi kết nối
        //strConnect = @"Data Source=(local)\SQLEXPRESS; AttachDbFilename=|DataDirectory|dbWebsiteSach.mdf;Integrated Security=True;User Instance=True";


    }
    //Phương thức kết nối tới CSDL
    public void KetNoi()
    {
        sqlCon = new SqlConnection(strConnect);
        if (sqlCon.State == ConnectionState.Closed)
            sqlCon.Open();
    }
    //Phương thức Ngắt kết nối
    public void NgatKetNoi()
    {
        sqlCon.Close();
    }

    //Phương thức thực thi câu lệnh SQL theo mô hình kết nối
    public void ThucThiSQL(string strSQL)
    {
        //Bước 1:
        KetNoi();
        //Bước 2:
        sqlCom = new SqlCommand(strSQL, sqlCon);
        sqlCom.ExecuteNonQuery();
        //Bước 3:
        NgatKetNoi();
    }

    //Phương thức thực thi theo mô hình phi kết nối
    public void ThucThiSQLPKN(string strSQL)
    {
        sqlAda = new SqlDataAdapter(strSQL, strConnect);
        sqlAda.Fill(ds, "TK4");
    }
    public void ThucThiSQLPKN(string sql, DataTable tenbang)
    {
        sqlAda = new SqlDataAdapter(sql, strConnect);
        sqlAda.Fill(tenbang);
    }
    //Kết thúc lớp
    //Lay du lieu vao bang
    public void GetTable(string sql, DataTable tb)
    {
        sqlAda = new SqlDataAdapter(sql, strConnect);
        sqlAda.Fill(tb);
    }

    public int LaySL(string masp)
    {
        string sql = "Select SL from tbSanPham where masp='" + masp + "'";
        KetNoi();
        sqlCon = new SqlConnection(strConnect);
        sqlCom = new SqlCommand(sql, sqlCon);
        int sl = (int)sqlCom.ExecuteScalar();
        NgatKetNoi();
        return sl;

    }

    //public  SqlDataReader ExcuRead(string sql)
    //{
    //    KetNoi();
    //    sqlCon=new SqlConnection (strConnect);

    //    sqlCom = new SqlCommand(sql, sqlCon);
    //    sqlDr = sqlCom.ExecuteReader();      
    //    return sqlDr;

    //}

    public string LayMaSP(string Maloai, string mau, string Size)
    {
        string sql = "Select MaSP,SL from tbSanPham where Maloai='" + Maloai + "' and MauSac=N'" + mau + "' and Size='" + Size + "'";
        sqlAda = new SqlDataAdapter(sql, strConnect);
        sqlAda.Fill(tb);
        string ma = "";
        if (tb.Rows.Count > 0) ma = tb.Rows[0][0].ToString();
        return ma;
    }

    public void InsertCTHoaDon(GridViewRow gr)
    {

    }
    public int KiemTra(string TenBang, string TenTruong, string GiaTri)
    {
        int kq = 0;
        //Kết nối
        KetNoi();
        //Lấy bản ghi
        string strSelect = "select count(*) from " + TenBang + " where " + TenTruong + "='" + GiaTri + "' ";
        sqlCom = new SqlCommand(strSelect, sqlCon);
        kq = (int)sqlCom.ExecuteScalar();
        //Ngat
        NgatKetNoi();
        //
        return kq;
        //
    }
    public int KiemTra1(string TenBang, string TenTruong1, string Tentruong2, string GiaTri1, string Giatri2)
    {
        int kq = 0;
        //Kết nối
        KetNoi();
        //Lấy bản ghi
        string strSelect = "select count(*) from " + TenBang + " where " + TenTruong1 + "=N'" + GiaTri1 + "' and " + Tentruong2 + "=N'" + Giatri2 + "'";
        sqlCom = new SqlCommand(strSelect, sqlCon);
        kq = (int)sqlCom.ExecuteScalar();
        //Ngat
        NgatKetNoi();
        //
        return kq;
        //
    }
    public string Laymacuoi(string tenbangds, string tencotkhoa, string dkien)
    {
        DataView dv = new DataView(ds.Tables[tenbangds], dkien, tencotkhoa, DataViewRowState.CurrentRows);
        dv.Sort = tencotkhoa + "DESC";
        if (dv.Count > 0)
        {
            return dv[0][tencotkhoa].ToString();
        }
        else
            return null;
    }
    public DataTable LuuBangTrongDataSet(string strsql, string TenBang)
    {
        sqlAda = new SqlDataAdapter(strsql, strConnect);
        sqlAda.Fill(ds, TenBang);
        sqlAda.Dispose();
        return ds.Tables[TenBang];
    }
    public DataTable Datatable_Laydulieu(string caulenh, string tenBang)
    {

        if (ds.Tables.Contains(tenBang)) ds.Tables[tenBang].Clear();
      sqlAda = new SqlDataAdapter(caulenh,strConnect);
       sqlAda.Fill(ds, tenBang);
        sqlAda.Dispose();
        return ds.Tables[tenBang];

    }
    public bool kiemtratontai(string strcommand)
    {
        bool boolTontai = false;
        KetNoi();

        sqlCom = new SqlCommand(strcommand, sqlCon);
        SqlDataReader dr = sqlCom.ExecuteReader();
        boolTontai = dr.HasRows;
        NgatKetNoi();
        return boolTontai;
    }
}

