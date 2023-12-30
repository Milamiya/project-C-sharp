using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class Play : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SVR"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        Tenbaihat();
        playnhac();       
    }
    public void playnhac()
    {
        string M = null;
        if (Request.QueryString.HasKeys())
        {
            M = Request.QueryString["M"].ToString();
            string sql = "select * from Music where MaBaiHat='" + M + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            int LuotXem = dr["LuotXem"].GetHashCode();
            int LuotXem2 = Convert.ToInt32(LuotXem);
            int LuotXem3 = LuotXem2 + 1;           
            string tencakhuc = dr["TenFile"].ToString();
            string song_url = "../MusicWeb/AudioPlayer/audio/" + tencakhuc;
            con.Close();
            Play__.InnerHtml = "<audio preload='auto' controls><source src='" + song_url + "'></audio>	";
            Play__.InnerHtml += "<script src='../MusicWeb/AudioPlayer/js/jquery.js'></script>";
            Play__.InnerHtml += "<script src='../MusicWeb/AudioPlayer/js/audioplayer.js'></script>";
            Play__.InnerHtml += "<script>$(function () { $('audio').audioPlayer(); });</script>";
            //Download source code tai Sharecode.vn
            update(LuotXem3); 
        }
    }
    public void update(int LuotXem3)
    {
        string M = Request.QueryString["M"].ToString();
        string updatequery = "Update  Music Set LuotXem =N'" + LuotXem3 + "' Where MaBaiHat ='" + M + "'";
        con.Open();
        SqlCommand cmd = new SqlCommand(updatequery, con);
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public void Tenbaihat()
    {
       string M = null;
        if (Request.QueryString.HasKeys())
        {
            M = Request.QueryString["M"].ToString();
        con.Open();
        string Baihat = null;
        string Casi = null;
        string TheLoai = null;
        string macasi = null;
        string sql = "select * from Music,Casi,TheLoai where Casi.MaCaSi=Music.MaCaSi and Music.MaTheLoai=TheLoai.MaTheLoai and MaBaiHat='" + M + "'";
        SqlCommand cmd = new SqlCommand(sql, con);
        SqlDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            Baihat = dr["TenBaiHat"].ToString();
            Casi=dr["TenCaSi"].ToString();
            TheLoai = dr["TenTheLoai"].ToString();
            macasi = dr["MaCaSi"].ToString();
        }
        lblTenCaKhuc.Text = Baihat;
        lblCasy.Text = Casi;
        lblTheLoai.Text=TheLoai;
        Lab_casi.Text = Casi;
        con.Close();
        baihatlienquan(macasi);
        }
    }
    public void baihatlienquan(string macasi)
    {
        //Download source code tai Sharecode.vn
        string sql = "select * from Music,Casi,TheLoai where Casi.MaCaSi=Music.MaCaSi and Music.MaTheLoai=TheLoai.MaTheLoai and Casi.MaCaSi ='" + macasi + "' order by LuotXem desc";
        con.Open();
        SqlDataAdapter da = new SqlDataAdapter(sql, con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        Music__.DataSource = ds;
        Music__.DataBind();
        con.Close();
    }
}