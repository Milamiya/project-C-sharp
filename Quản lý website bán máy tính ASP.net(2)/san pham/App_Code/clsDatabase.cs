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
using System.Web.Configuration;
/// <summary>
/// Summary description for clsDatabase
/// </summary>
public class clsDatabase
{    
    SqlConnection sqlCon;
    SqlCommand sqlCom;
    SqlDataReader sqlDr;
    SqlDataAdapter sqlDa;
    DataSet ds = new DataSet();
    DataTable dt = new DataTable();    
    static string strConnect = WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
    
    void KetNoi()
    {
        sqlCon = new SqlConnection(strConnect);
        if (sqlCon.State == ConnectionState.Closed)
            sqlCon.Open();
    }
    
    void NgatKetNoi()
    {
        sqlCon.Close();
    }
    
    public void ThucThiSQL(string strSQL)
    {
       KetNoi();
       sqlCom = new SqlCommand(strSQL, sqlCon);
       sqlCom.ExecuteNonQuery();
       NgatKetNoi();
    }
    public DataTable LoadDuLieuPKN(string strSQL)
    {
        sqlCon = new SqlConnection(strConnect);
        sqlDa = new SqlDataAdapter(strSQL, sqlCon);
        DataTable dt = new DataTable();
        sqlDa.Fill(dt);
        return dt;                 
    }
    public void LoadDuLieuKN(string strSQL, GridView gv)
    {
        KetNoi();
        sqlCom = new SqlCommand(strSQL, sqlCon);
        sqlDr = sqlCom.ExecuteReader();
        while (sqlDr.Read())
        {
            object[] mang = new object[sqlDr.FieldCount];
            sqlDr.GetValues(mang);            
        }
    }
    public string LoadDuLieu(string strSQL, int i)
    {
        KetNoi();
        string strMa = "";
        sqlCom = new SqlCommand(strSQL, sqlCon);
        sqlDr = sqlCom.ExecuteReader();
        while (sqlDr.Read())
        {
            strMa = sqlDr[i].ToString();
            break;
        }
        NgatKetNoi();
        return strMa;
    }
    //public bool KiemTra(string strSQL,string strMa)
    //{       
    //    KetNoi();
    //    sqlCom = new SqlCommand(strSQL, sqlCon);
    //    sqlDr = sqlCom.ExecuteReader();
    //    while (sqlDr.Read())
    //    {
    //        if (sqlDr[0].ToString() == strMa)
    //        {
    //            return true;
    //            break;
    //        }
    //    }
    //    return false;
    //}
    public clsDatabase()
    {
        dt = new DataTable();
        dt.Columns.Add("ProductID");
        dt.Columns.Add("ProductName");
        dt.Columns.Add("Price");
        dt.Columns.Add("Number");
        dt.Columns.Add("Total");
    }       
    public DataTable  GetDataTable()
    {
        return this.dt;
    }
    public DataSet GetDataSet()
    {
        return this.ds;
    }
    public SqlDataAdapter GetDataAdapter()
    {
        return this.sqlDa;
    }
    public SqlConnection GetSqlCon()
    {
        return this.sqlCon;
    }
    public void DienVaoBang(DataTable dt, string strProductID, string strProductName, int strPrice, int strNumber, int strTotal)
    {
        if (dt.Rows.Count != 0)
        {
            bool kt = false;
            foreach (DataRow dr in dt.Rows)
            {
                if (dr[0].ToString().Equals(strProductID))
                {
                    dr[3] = Convert.ToInt32(dr[3].ToString()) + strNumber;
                    dr[4] = Convert.ToInt32(dr[3].ToString()) * strPrice;
                    kt = true;
                }
            }
            if (!kt)
            {
                DataRow dr = dt.NewRow();
                dr[0] = strProductID;
                dr[1] = strProductName;
                dr[2] = strPrice;
                dr[3] = strNumber;
                dr[4] = strTotal;
                dt.Rows.Add(dr);
            }
        }
        else
        {
            DataRow dr = dt.NewRow();
            dr[0] = strProductID;
            dr[1] = strProductName;
            dr[2] = strPrice;
            dr[3] = strNumber;
            dr[4] = strTotal;
            dt.Rows.Add(dr);
        }
    }
    public void DeleteRow(DataTable tb, string ma)
    {        
        //bool kt = true;
        foreach (DataRow dr in tb.Rows)
        {
            if (dr[0].ToString() == ma)
            {
                tb.Rows.Remove(dr);
                break;

            }
        }
    }
    public void UpdateNumber(ref DataTable dt, string ma, string soluong)
    {
        bool kt = true;
        foreach (DataRow dr in dt.Rows)
        {
            if (dr[0].ToString() == ma)
            {
                soluong = dr[3].ToString();
                break;
            }
        }
    }
    public int KiemTraRole(string strSQL,string strUseName, string strPass)
    {
        bool ok = false;
        int role = 0;
        KetNoi();
        sqlCom = new SqlCommand(strSQL, sqlCon);
        sqlDr = sqlCom.ExecuteReader();
        while (sqlDr.Read())
        {
            if (sqlDr[0].ToString().ToLower() == strUseName.ToLower() && sqlDr[1].ToString().ToLower() == strPass.ToLower())
            {
                role = int.Parse(sqlDr[2].ToString());
                ok = true;
                break;
            }           
        }
        return role;
    }
    public bool KiemTraLoginKH(string strSQL, string strUseName, string strPass)
    {
        bool ok = false;        
        KetNoi();
        sqlCom = new SqlCommand(strSQL, sqlCon);
        sqlDr = sqlCom.ExecuteReader();
        while (sqlDr.Read())

        {
            if (sqlDr[1].ToString().ToLower() == strUseName.ToLower() && sqlDr[2].ToString().ToLower() == strPass.ToLower())
            {                
                ok = true;
                break;
            }
        }
        return ok;
    }
    public bool KiemTraMaTrung(string strSQL)
    {
        KetNoi();
        sqlCom = new SqlCommand(strSQL, sqlCon);
        int i = (int)(sqlCom.ExecuteScalar());
        NgatKetNoi();
        if (i <= 0) return false;
        else return true;        
    }
}
