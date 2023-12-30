using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace PKT
{
    public partial class sanpham : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                load();
            }
        }

        protected void paging(DataTable dt)
        {
            try
            {
                // Starting paging here.
                PagedDataSource pagedata = new PagedDataSource();
                DataView dv = new DataView(dt);
                pagedata.DataSource = dv;
                pagedata.AllowPaging = true;
                // Show number of product in one page.
                pagedata.PageSize = 9;
                // Specify sum of page.
                int numPage = pagedata.PageCount;

                int currentPage;
                if (Request.QueryString["page"] != null)
                {
                    currentPage = Int32.Parse(Request.QueryString["page"]);
                }
                else
                {
                    currentPage = 1;
                }
                // Because paging always start at 0.
                pagedata.CurrentPageIndex = currentPage - 1;
                // Show
                //count.Text = pagedata.PageCount.ToString() ;
                page.Text = currentPage.ToString();
                page2.Text = currentPage.ToString();
                // Config next - pre link.
                if (!pagedata.IsFirstPage)
                {
                    string key = "";
                    if (Request.QueryString["key"] != null)
                    {
                        key = Request.QueryString["key"].ToString();
                    }
                    else
                    {
                        key = "";
                    }
                    string manu;
                    if (Request.QueryString["manu"] != null)
                    {
                            manu = Request.QueryString["manu"].ToString();
                    }
                    else
                    {
                        manu = "";
                    }
                    string pricef = "";
                    if (Request.QueryString["pricef"] != null)
                    {
                        pricef =Request.QueryString["pricef"].ToString();
                    }
                    else
                    {
                        pricef = "";
                    }
                    string pricet = "";
                    if (Request.QueryString["pricet"] != null)
                    {
                        pricet =Request.QueryString["pricet"].ToString();
                    }
                    else
                    {
                        pricet = "";
                    }
                    string ct1 = "";
                    if (Request.QueryString["ct1"] != null)
                    {
                        ct1 = Request.QueryString["ct1"].ToString();
                    }
                    else
                    {
                        ct1 = "";
                    }
                    string ct3 = "";
                    if (Request.QueryString["ct3"] != null)
                    {
                        ct3= Request.QueryString["ct3"].ToString();
                    }
                    else
                    {
                        ct3 = "";
                    }
                    string ct21 = "";
                    if (Request.QueryString["ct21"] != null)
                    {
                        ct21 = Request.QueryString["ct21"].ToString();
                    }
                    else
                    {
                        ct21 = "";
                    }
                    string ct6 = "";
                    if (Request.QueryString["ct6"] != null)
                    {
                        ct6 = Request.QueryString["ct6"].ToString();
                    }
                    else
                    {
                        ct6 = "";
                    }
                    string ct19 = "";
                    if (Request.QueryString["ct19"] != null)
                    {
                        ct19=Request.QueryString["ct19"].ToString();
                    }
                    else
                    {
                        ct19 = "";
                    }
                    string ct17 = "";
                    if (Request.QueryString["ct17"] != null)
                    {
                        ct17 = Request.QueryString["ct17"].ToString();
                    }
                    else
                    {
                        ct17 = "";
                    }
                    string ct20 = "";
                    if (Request.QueryString["ct20"] != null)
                    {
                        ct20 = Request.QueryString["ct20"].ToString();
                    }
                    else
                    {
                        ct20 = "";
                    }
                    string ct5 = "";
                    if (Request.QueryString["ct5"] != null)
                    {
                        ct5  = Request.QueryString["ct5"].ToString();
                    }
                    else
                    {
                        ct5 = "";
                    }
                    string ct18 = "";
                    if (Request.QueryString["ct18"] != null)
                    {
                        ct18 = Request.QueryString["ct18"].ToString();
                    }
                    else
                    {
                        ct18 = "";
                    }
                    lnkPre.NavigateUrl = Request.CurrentExecutionFilePath + "?key=" + key +
                        "&pricef=" + pricef + "&pricet=" + pricet +
                        "&manu=" + manu + "&ct1" + ct1 + "&ct3" + ct3 + "&ct21" + ct21 + "&ct6" + ct6 + "&ct17" + ct17 + "&ct20" + ct20 + "&ct5" + ct5 + "&ct18" + ct18 + "&ct19" + ct19 + "&page=" + Convert.ToString(currentPage - 1);
                    lnkPre2.NavigateUrl = lnkPre.NavigateUrl;
                }
                else
                {
                    lnkPre2.Enabled = false;
                    lnkPre.Enabled = false;
                }
                if (!pagedata.IsLastPage)
                {
                    string key = "";
                    if (Request.QueryString["key"] != null)
                    {
                        key = Request.QueryString["key"].ToString();
                    }
                    else
                    {
                        key = "";
                    }
                    string manu;
                    if (Request.QueryString["manu"] != null)
                    {
                        manu = Request.QueryString["manu"].ToString();
                    }
                    else
                    {
                        manu = "";
                    }
                    string pricef = "";
                    if (Request.QueryString["pricef"] != null)
                    {
                        pricef = Request.QueryString["pricef"].ToString();
                    }
                    else
                    {
                        pricef = "";
                    }
                    string pricet = "";
                    if (Request.QueryString["pricet"] != null)
                    {
                        pricet = Request.QueryString["pricet"].ToString();
                    }
                    else
                    {
                        pricet = "";
                    }
                    string ct1 = "";
                    if (Request.QueryString["ct1"] != null)
                    {
                        ct1 = Request.QueryString["ct1"].ToString();
                    }
                    else
                    {
                        ct1 = "";
                    }
                    string ct3 = "";
                    if (Request.QueryString["ct3"] != null)
                    {
                        ct3 = Request.QueryString["ct3"].ToString();
                    }
                    else
                    {
                        ct3 = "";
                    }
                    string ct21 = "";
                    if (Request.QueryString["ct21"] != null)
                    {
                        ct21 = Request.QueryString["ct21"].ToString();
                    }
                    else
                    {
                        ct21 = "";
                    }
                    string ct6 = "";
                    if (Request.QueryString["ct6"] != null)
                    {
                        ct6 = Request.QueryString["ct6"].ToString();
                    }
                    else
                    {
                        ct6 = "";
                    }
                    string ct19 = "";
                    if (Request.QueryString["ct19"] != null)
                    {
                        ct19 = Request.QueryString["ct19"].ToString();
                    }
                    else
                    {
                        ct19 = "";
                    }
                    string ct17 = "";
                    if (Request.QueryString["ct17"] != null)
                    {
                        ct17 = Request.QueryString["ct17"].ToString();
                    }
                    else
                    {
                        ct17 = "";
                    }
                    string ct20 = "";
                    if (Request.QueryString["ct20"] != null)
                    {
                        ct20 = Request.QueryString["ct20"].ToString();
                    }
                    else
                    {
                        ct20 = "";
                    }
                    string ct5 = "";
                    if (Request.QueryString["ct5"] != null)
                    {
                        ct5 = Request.QueryString["ct5"].ToString();
                    }
                    else
                    {
                        ct5 = "";
                    }
                    string ct18 = "";
                    if (Request.QueryString["ct18"] != null)
                    {
                        ct18 = Request.QueryString["ct18"].ToString();
                    }
                    else
                    {
                        ct18 = "";
                    }
                    lnkNext.NavigateUrl = Request.CurrentExecutionFilePath + "?key=" + key +
                        "&pricef=" + pricef + "&pricet=" + pricet +
                        "&manu=" + manu + "&ct1" + ct1 + "&ct3" + ct3 + "&ct21" + ct21 + "&ct6" + ct6 + "&ct17" + ct17 + "&ct20" + ct20 + "&ct5" + ct5 + "&ct18" + ct18 + "&ct19" + ct19 + "&page=" + Convert.ToString(currentPage + 1);
                    lnkNext2.NavigateUrl = lnkNext.NavigateUrl;
                }
                else
                {
                    lnkNext2.Enabled = false;
                    lnkNext.Enabled = false;
                }

                data.DataSource = pagedata;
                data.DataBind();
                detail.DataSource = pagedata;
                detail.DataBind();
            }
            catch
            {
                Response.Write("Loi!");
            }
            finally
            {
            }
        }

        protected void load()
        {
            string key = "";
            if (Request.QueryString["key"] != null)
            {
                key = " TenSP like '%" + Request.QueryString["key"].ToString() + "%'";
            }
            else
            {
                key = " TenSP <>''";
            }
            string manu;
            if (Request.QueryString["manu"] != null)
            {
                if (Request.QueryString["manu"].ToString() == "SX00")
                    manu = "";
                else
                    manu = " and MaSX like '%" + Request.QueryString["manu"].ToString() + "%'";
            }
            else
            {
                manu = "";
            }
            string pricef = "";
            if (Request.QueryString["pricef"] != null)
            {
                pricef = " and GiaBan >" + int.Parse(Request.QueryString["pricef"]);
            }
            else
            {
                pricef = " and GiaBan > 0";
            }
            string pricet = "";
            if (Request.QueryString["pricet"] != null)
            {
                pricet = " and GiaBan <=" + int.Parse(Request.QueryString["pricet"]);
            }
            else
            {
                pricet = "";
            }
            string ct1 = "";
            if (Request.QueryString["ct1"] != null)
            {
                if (Request.QueryString["ct1"].ToString() == "True")
                    ct1 = " and CT1<>'-'";
            }
            else
            {
                ct1 = "";
            }
            string ct3 = "";
            if (Request.QueryString["ct3"] != null)
            {
                if (Request.QueryString["ct3"].ToString() == "True")
                    ct3 = " and CT3<>'-'";
            }
            else
            {
                ct3 = "";
            }
            string ct21 = "";
            if (Request.QueryString["ct21"] != null)
            {
                if (Request.QueryString["ct21"].ToString() == "True")
                    ct21 = " and CT21<>'-'";
            }
            else
            {
                ct21 = "";
            }
            string ct6 = "";
            if (Request.QueryString["ct6"] != null)
            {
                if (Request.QueryString["ct6"].ToString() == "True")
                    ct6 = " and CT6<>'-'";
            }
            else
            {
                ct6 = "";
            }
            string ct19 = "";
            if (Request.QueryString["ct19"] != null)
            {
                if (Request.QueryString["ct19"].ToString() == "True")
                    ct19 = " and CT19<>'-'";
            }
            else
            {
                ct19 = "";
            }
            string ct17 = "";
            if (Request.QueryString["ct17"] != null)
            {
                if (Request.QueryString["ct17"].ToString() == "True")
                    ct17 = " and CT17<>'-'";
            }
            else
            {
                ct17 = "";
            }
            string ct20 = "";
            if (Request.QueryString["ct20"] != null)
            {
                if (Request.QueryString["ct20"].ToString() == "True")
                    ct20 = " and CT20<>'-'";
            }
            else
            {
                ct20 = "";
            }
            string ct5 = "";
            if (Request.QueryString["ct5"] != null)
            {
                if (Request.QueryString["ct5"].ToString() == "True")
                    ct5 = " and CT5<>'-'";
            }
            else
            {
                ct5 = "";
            }
            string ct18 = "";
            if (Request.QueryString["ct18"] != null)
            {
                if (Request.QueryString["ct18"].ToString() == "True")
                    ct18 = " and CT18<>'-'";
            }
            else
            {
                ct18 = "";
            }

            string connectionstring = ConfigurationManager.ConnectionStrings["pktphonedata"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            string sql;
            if (Request.QueryString["pricet"] != null && int.Parse(Request.QueryString["pricet"]) != 0)
                sql = "select *from SanPham where"+ key + manu + pricef + pricet + ct1 + ct17 + ct18 + ct19 + ct20 + ct21 + ct3 + ct5 + ct6;
            else
                sql = "select * from SanPham where " + key + manu + pricef + ct1 + ct17 + ct18 + ct19 + ct20 + ct21 + ct3 + ct5 + ct6; 
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            count.Text = dt.Rows.Count.ToString();
            count2.Text = dt.Rows.Count.ToString();
            paging(dt);
        }



        protected void order_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = load2();
            count.Text = dt.Rows.Count.ToString();
            count2.Text = dt.Rows.Count.ToString();
            if (order.SelectedValue.ToString() == "1")
            {
                DataView dv = dt.DefaultView;
                dv.Sort = "GiaBan asc";
                dt = dv.ToTable();
                paging(dt);
                order2.SelectedValue = "1";
            }
            if (order.SelectedValue.ToString() == "2")
            {
                DataView dv = dt.DefaultView;
                dv.Sort = "GiaBan desc";
                dt = dv.ToTable();
                paging(dt);
                order2.SelectedValue = "2";
            }
            if (order.SelectedValue.ToString() == "3")
            {
                DataView dv = dt.DefaultView;
                dv.Sort = "TenSP asc";
                dt = dv.ToTable();
                paging(dt);
                order2.SelectedValue = "3";
            }
            if (order.SelectedValue.ToString() == "4")
            {
                DataView dv = dt.DefaultView;
                dv.Sort = "TenSP desc";
                dt = dv.ToTable();
                paging(dt);
                order2.SelectedValue = "4";
            }
        }

        protected void order2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = load2();
            count.Text = dt.Rows.Count.ToString();
            count2.Text = dt.Rows.Count.ToString();
            if (order2.SelectedValue.ToString() == "1")
            {
                DataView dv = dt.DefaultView;
                dv.Sort = "GiaBan asc";
                dt = dv.ToTable();
                paging(dt);
                order.SelectedValue = "1";
            }
            if (order2.SelectedValue.ToString() == "2")
            {
                DataView dv = dt.DefaultView;
                dv.Sort = "GiaBan desc";
                dt = dv.ToTable();
                paging(dt);
                order.SelectedValue = "2";
            }
            if (order2.SelectedValue.ToString() == "3")
            {
                DataView dv = dt.DefaultView;
                dv.Sort = "TenSP asc";
                dt = dv.ToTable();
                paging(dt);
                order.SelectedValue = "3";
            }
            if (order2.SelectedValue.ToString() == "4")
            {
                DataView dv = dt.DefaultView;
                dv.Sort = "TenSP desc";
                dt = dv.ToTable();
                paging(dt);
                order.SelectedValue = "4";
            }
        }

        protected DataTable load2()
        {
            string key = "";
            if (Request.QueryString["key"] != null)
            {
                key = " TenSP like '%" + Request.QueryString["key"].ToString() + "%'";
            }
            else
            {
                key = " TenSP like '%%'";
            }
            string manu;
            if (Request.QueryString["manu"] != null)
            {
                if (Request.QueryString["manu"].ToString() == "SX00")
                    manu = "";
                else
                    manu = " and MaSX like '%" + Request.QueryString["manu"].ToString() + "%'";
            }
            else
            {
                manu = "";
            }
            string pricef = "";
            if (Request.QueryString["pricef"] != null)
            {
                pricef = " and GiaBan >" + int.Parse(Request.QueryString["pricef"]);
            }
            else
            {
                pricef = " and GiaBan > 0";
            }
            string pricet = "";
            if (Request.QueryString["pricet"] != null)
            {
                pricet = " and GiaBan <=" + int.Parse(Request.QueryString["pricet"]);
            }
            else
            {
                pricet = "";
            }
            string connectionstring = ConfigurationManager.ConnectionStrings["pktphonedata"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            string sql;
            if (Request.QueryString["pricet"] != null && int.Parse(Request.QueryString["pricet"]) != 0)
                sql = "select *from SanPham where" + key + manu + pricef + pricet;
            else
                sql = "select * from SanPham where" + key + manu + pricef;
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }

        
    }
}