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

/// <summary>
/// Summary description for ShoppingCart
/// </summary>
public class ShoppingCart
{
    
    private Int64 total=0;
    private int quantity=0;
    private string primarykey="";

    private DataTable data;
	public ShoppingCart()
	{

	       
        data = new DataTable();
        //data.Columns.Add("STT", typeof(int));
        data.Columns.Add("ID",typeof(string));
        data.Columns.Add("DisplayName", typeof(string));
        data.Columns.Add("Quantity", typeof(int));
        data.Columns.Add("Price", typeof(long));        
        data.PrimaryKey = new DataColumn[] {this.data.Columns["ID"] };
       
	}

    #region Method
    private bool Exits(string id)
    {
        foreach (DataRow dong in data.Rows)
        {
            if (dong["ID"].ToString() == id)
                return true;
        }
        return false;

    }
    public bool  ADD(string id,string name, int quant,long price)
    {
        
            if (Exits(id))
            {
                DataRow dong = data.Rows.Find(id);
                if (dong != null)
                {
                    dong["Quantity"] = (int)dong["Quantity"] + quant;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                DataRow newrow = this.data.NewRow();
                //newrow["STT"] = this.quantity + 1;
                newrow["ID"] = id;
                newrow["DisplayName"] = name;
                newrow["Quantity"] = quant;
                newrow["Price"] = price;
                
                data.Rows.Add(newrow);
             
                this.quantity++;
            }
            return true;
       
    }
    public bool Remove(string id)
    {
        DataRow dong = data.Rows.Find(id);
        if (dong != null)
        {
            dong.Delete();
            this.quantity--;
            data.AcceptChanges();
            return true;
        }
        return false;
    }
    //private void updateStt()
    //{
    //    int dem=1;
    //    foreach (DataRow dong in data.Rows)
    //    {
    //        dong["STT"] = dem;
    //        dem++;
    //    }
    //}
    private void GetTotal()
    {
        this.total = 0;
        foreach (DataRow dong in data.Rows)
        {
            this.total +=(long)dong["Price"]*(int)dong["Quantity"];
        }        
    }
    public bool UpdateQuantity(string id, int quan)
    {
        //foreach (DataRow dong in data.Rows)
        //{
        //    this.quantity = quan;
        //}
        //return true;
        DataRow dong = this.data.Rows.Find(id);
        if (dong != null)
        {
            dong[2] = quan;
            this.data.AcceptChanges();
            return true;
        }
        return false;
    }
    public bool Clear()
    {
        this.total = 0;
        this.quantity = 0;
        this.data.Clear();
        return true;
    }

    //Tính tỏng tiền trên giỏ
    public long TotalMoney()
    {
        long tong = 0;
        for (int i = 0; i < this.data.Rows.Count; i++)
        {
            tong = tong + (int.Parse(this.data.Rows[i][2].ToString())*(long.Parse(this.data.Rows[i][3].ToString())));
        }
        return tong;
    }

    public DataTable GetProduct(string id)
    {
        DataTable pnew = this.Data.Clone();
        pnew.Clear();
        DataRow dong = this.data.Rows.Find(id);
        if (dong != null)
        {
            DataRow newrow = pnew.NewRow();
            //newrow["STT"] = "1";
            newrow["ID"] = dong["ID"].ToString();
            newrow["DisplayName"] = dong["DisplayName"].ToString();
            newrow["Quantity"] = dong["Quantity"].ToString();
            newrow["Price"] = dong["Price"].ToString();
            
            if (!pnew.Columns.Contains("Total"))
            {
                pnew.Columns.Add("Total", typeof(Int64));
            }
            newrow["Total"] = (long)newrow["Price"] * (int)newrow["Quantity"];
            pnew.Rows.Add(newrow);
        }
        
        return pnew;
    }
    
    #endregion
    
    #region Properties

    public Int64 Total
    {
        get { GetTotal(); return this.total; }
    }
    public int Quantity
    {
        get { return this.quantity; }
    }

    public DataTable Data
    {
        get 
        {
            //updateStt();
            if (!data.Columns.Contains("Total"))
            {
                data.Columns.Add("Total", typeof(Int64));
            }
            foreach (DataRow dong in this.data.Rows)
            {
                dong["Total"] = (long)dong["Price"] * (int)dong["Quantity"];
            }            
            return this.data; }       
    }
  
    
    #endregion
	}

