using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace PKT
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                load();
            }
            MaintainScrollPositionOnPostBack = true;
        }

        protected void load()
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["pktphonedata"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionstring);
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter("select SanPham.*,TenSX  from SanPham join NhaSanXuat on SanPham.MaSX = NhaSanXuat.MaSX where GETDATE()- NgayNhap < 15 order by NgayNhap,MaSP desc", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            paging1(dt);
            //adapter.Dispose();
            //Newphone.DataSource = dt.DefaultView;
            //Newphone.DataBind();
            //detail.DataSource = dt.DefaultView;
            //detail.DataBind();
            adapter = new SqlDataAdapter("select SanPham.*,TenSX  from SanPham join NhaSanXuat on SanPham.MaSX = NhaSanXuat.MaSX where PhanLoai='Smart Phone' order by NgayNhap,MaSP desc ", conn);
            DataTable dt1 = new DataTable();
            adapter.Fill(dt1);
            paging2(dt1);
            //adapter.Dispose();
            //Smartphone.DataSource = dt1.DefaultView;
            //Smartphone.DataBind();

            adapter = new SqlDataAdapter("select SanPham.*,TenSX  from SanPham join NhaSanXuat on SanPham.MaSX = NhaSanXuat.MaSX where PhanLoai=N'Phổ Thông' order by NgayNhap,MaSP desc", conn);
            DataTable dt2 = new DataTable();
            adapter.Fill(dt2);
            paging3(dt2);

            adapter = new SqlDataAdapter("select SanPham.*,TenSX  from SanPham join NhaSanXuat on SanPham.MaSX = NhaSanXuat.MaSX where SLTon > 0", conn);
            DataTable dt3 = new DataTable();
            adapter.Fill(dt3);
            adapter.Dispose();
            detail.DataSource = dt3.DefaultView;
            detail.DataBind();
            adapter = new SqlDataAdapter("select SanPham.*,TenSX  from SanPham join NhaSanXuat on SanPham.MaSX = NhaSanXuat.MaSX where SLTon = 0", conn);
            DataTable dt4 = new DataTable();
            adapter.Fill(dt4);
            adapter.Dispose();
            detail2.DataSource = dt4.DefaultView;
            detail2.DataBind();
        }

        protected DataTable load1()
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["pktphonedata"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionstring);
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter("select SanPham.*,TenSX  from SanPham join NhaSanXuat on SanPham.MaSX = NhaSanXuat.MaSX where GETDATE()- NgayNhap < 15 ", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        protected DataTable load2()
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["pktphonedata"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionstring);
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter("select SanPham.*,TenSX  from SanPham join NhaSanXuat on SanPham.MaSX = NhaSanXuat.MaSX where PhanLoai='Smart Phone'", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        protected DataTable load3()
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["pktphonedata"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionstring);
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter("select SanPham.*,TenSX  from SanPham join NhaSanXuat on SanPham.MaSX = NhaSanXuat.MaSX where PhanLoai=N'Phổ Thông'", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        protected void paging1(DataTable dt)
        {
            try
            {
                // Starting paging here.
                PagedDataSource pagedata = new PagedDataSource();
                DataView dv = new DataView(dt);
                pagedata.DataSource = dv;
                pagedata.AllowPaging = true;
                pagedata.PageSize = 9;
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
                pagedata.CurrentPageIndex = currentPage - 1;
                page.Text = currentPage.ToString();
                if (!pagedata.IsFirstPage)
                {                   
                    lnkPre.NavigateUrl = Request.CurrentExecutionFilePath + "?page=" +Convert.ToString(currentPage - 1);
                }
                else
                {
                    lnkPre.Enabled = false;
                }
                if (!pagedata.IsLastPage)
                {

                    lnkNext.NavigateUrl = Request.CurrentExecutionFilePath + "?page=" + Convert.ToString(currentPage + 1);
                }
                else
                {
                    lnkNext.Enabled = false;
                }
                count.Text = dt.Rows.Count.ToString();
                Newphone.DataSource = pagedata;
                Newphone.DataBind();
            }
            catch
            {
                Response.Write("Loi!");
            }
            finally
            {
            }
        }
        protected void paging2(DataTable dt)
        {
            try
            {
                // Starting paging here.
                PagedDataSource pagedata = new PagedDataSource();
                DataView dv = new DataView(dt);
                pagedata.DataSource = dv;
                pagedata.AllowPaging = true;
                pagedata.PageSize = 9;
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
                pagedata.CurrentPageIndex = currentPage - 1;
                page2.Text = currentPage.ToString();
                if (!pagedata.IsFirstPage)
                {
                    lnkPre2.NavigateUrl = Request.CurrentExecutionFilePath + "?page=" + Convert.ToString(currentPage - 1);
                }
                else
                {
                    lnkPre2.Enabled = false;
                }
                if (!pagedata.IsLastPage)
                {

                    lnkNext2.NavigateUrl = Request.CurrentExecutionFilePath + "?page=" + Convert.ToString(currentPage + 1);
                }
                else
                {
                    lnkNext2.Enabled = false;
                }
                count2.Text = dt.Rows.Count.ToString();
                Smartphone.DataSource = pagedata;
                Smartphone.DataBind();
            }
            catch
            {
                Response.Write("Loi!");
            }
            finally
            {
            }
        }
        protected void paging3(DataTable dt)
        {
            try
            {
                // Starting paging here.
                PagedDataSource pagedata = new PagedDataSource();
                DataView dv = new DataView(dt);
                pagedata.DataSource = dv;
                pagedata.AllowPaging = true;
                pagedata.PageSize = 9;
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
                pagedata.CurrentPageIndex = currentPage - 1;
                page3.Text = currentPage.ToString();
                if (!pagedata.IsFirstPage)
                {
                    lnkPre3.NavigateUrl = Request.CurrentExecutionFilePath + "?page=" + Convert.ToString(currentPage - 1);
                }
                else
                {
                    lnkPre3.Enabled = false;
                }
                if (!pagedata.IsLastPage)
                {

                    lnkNext3.NavigateUrl = Request.CurrentExecutionFilePath + "?page=" + Convert.ToString(currentPage + 1);
                }
                else
                {
                    lnkNext3.Enabled = false;
                }
                count3.Text = dt.Rows.Count.ToString();
                Phothong.DataSource = pagedata;
                Phothong.DataBind();
            }
            catch
            {
                Response.Write("Loi!");
            }
            finally
            {
            }
        }

        protected void order_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = load1();
            count.Text = dt.Rows.Count.ToString();
            if (order.SelectedValue.ToString() == "1")
            {
                DataView dv = dt.DefaultView;
                dv.Sort = "GiaBan asc";
                dt = dv.ToTable();
                paging1(dt);
            }
            if (order.SelectedValue.ToString() == "2")
            {
                DataView dv = dt.DefaultView;
                dv.Sort = "GiaBan desc";
                dt = dv.ToTable();
                paging1(dt);
            }
            if (order.SelectedValue.ToString() == "3")
            {
                DataView dv = dt.DefaultView;
                dv.Sort = "TenSP asc";
                dt = dv.ToTable();
                paging1(dt);
            }
            if (order.SelectedValue.ToString() == "4")
            {
                DataView dv = dt.DefaultView;
                dv.Sort = "TenSP desc";
                dt = dv.ToTable();
                paging1(dt);
            }
        }

        protected void order2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = load2();
            count2.Text = dt.Rows.Count.ToString();
            if (order2.SelectedValue.ToString() == "1")
            {
                DataView dv = dt.DefaultView;
                dv.Sort = "GiaBan asc";
                dt = dv.ToTable();
                paging2(dt);
            }
            if (order2.SelectedValue.ToString() == "2")
            {
                DataView dv = dt.DefaultView;
                dv.Sort = "GiaBan desc";
                dt = dv.ToTable();
                paging2(dt);
            }
            if (order2.SelectedValue.ToString() == "3")
            {
                DataView dv = dt.DefaultView;
                dv.Sort = "TenSP asc";
                dt = dv.ToTable();
                paging2(dt);
            }
            if (order2.SelectedValue.ToString() == "4")
            {
                DataView dv = dt.DefaultView;
                dv.Sort = "TenSP desc";
                dt = dv.ToTable();
                paging2(dt);
            }
        }

        protected void order3_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = load3();
            count3.Text = dt.Rows.Count.ToString();
            if (order3.SelectedValue.ToString() == "1")
            {
                DataView dv = dt.DefaultView;
                dv.Sort = "GiaBan asc";
                dt = dv.ToTable();
                paging3(dt);
            }
            if (order3.SelectedValue.ToString() == "2")
            {
                DataView dv = dt.DefaultView;
                dv.Sort = "GiaBan desc";
                dt = dv.ToTable();
                paging3(dt);
            }
            if (order3.SelectedValue.ToString() == "3")
            {
                DataView dv = dt.DefaultView;
                dv.Sort = "TenSP asc";
                dt = dv.ToTable();
                paging3(dt);
            }
            if (order3.SelectedValue.ToString() == "4")
            {
                DataView dv = dt.DefaultView;
                dv.Sort = "TenSP desc";
                dt = dv.ToTable();
                paging3(dt);
            }
        }

    }
}