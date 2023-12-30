using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class Play_Video : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SVR"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        Tenvideo();
        string V = null;
        if (Request.QueryString.HasKeys())
        {
            V = Request.QueryString["V"].ToString();
            string sql = "select * from Video where MaVideo='" + V + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            string tenvideo = dr["TenFile"].ToString();
            string hinhvideo = dr["Hinh"].ToString();
            string video_img = "../MusicWeb/img_video/" + hinhvideo;
            string video_mp4 = "../MusicWeb/video-js/" + tenvideo + ".mp4";
            string video_webm = "../MusicWeb/video-js/" + tenvideo + ".webm";
            string video_ogv = "../MusicWeb/video-js/" + tenvideo + ".ogv";
            con.Close();
            Play__.InnerHtml = "<video id='example_video_1' class='video-js vjs-default-skin' controls preload='none' width='100%' height='310' poster='" + video_img + "' data-setup='{}'>";
            Play__.InnerHtml += "<source src='" + video_mp4 + "' type='video/mp4' /> <source src='" + video_webm + "' type='video/webm' /> <source src='" + video_ogv + "' type='video/ogg' />";
            Play__.InnerHtml += "<track kind='captions' src='../MusicWeb/video-js/demo.captions.vtt' srclang='en' label='English'></track>";
            Play__.InnerHtml += "<track kind='subtitles' src='../MusicWeb/video-js/demo.captions.vtt' srclang='en' label='English'></track>";
            Play__.InnerHtml += "</video>";
        }
    }
    public void Tenvideo()
    {
        string V = null;
        if (Request.QueryString.HasKeys())
        {
            V = Request.QueryString["V"].ToString();
            con.Open();
            string video = null;
            string Casi = null;
            string TheLoai = null;
            string macasi = null;
            string sql = "select * from Video,Casi,TheLoai where Casi.MaCaSi=Video.MaCaSi and Video.MaTheLoai=TheLoai.MaTheLoai and MaVideo='" + V + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                video = dr["TenVideo"].ToString();
                Casi = dr["TenCaSi"].ToString();
                TheLoai = dr["TenTheLoai"].ToString();
                macasi = dr["MaCaSi"].ToString();
            }
            lblTenvideo.Text = video;
            lblCasy.Text = Casi;
            lblTheLoai.Text = TheLoai;
            Lab_casi.Text = Casi;
            con.Close();
            videolienquan(macasi);
        }
    }
    public void videolienquan(string macasi)
    {
        string sql = "select * from Video,Casi,TheLoai where Casi.MaCaSi=Video.MaCaSi and Video.MaTheLoai=TheLoai.MaTheLoai and Casi.MaCaSi ='" + macasi + "' order by LuotXem desc";
        con.Open();
        SqlDataAdapter da = new SqlDataAdapter(sql, con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        Video__.DataSource = ds;
        Video__.DataBind();
        con.Close();
    }
}