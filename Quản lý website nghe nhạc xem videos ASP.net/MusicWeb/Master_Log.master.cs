using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class Master_Log : System.Web.UI.MasterPage
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SVR"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        Play__.InnerHtml = "<video id='example_video_1' class='video-js vjs-default-skin' controls preload='none' width='100%' height='310' poster='../MusicWeb/img_QuangCao/den.png' data-setup='{}'>";
            Play__.InnerHtml += "<source src='../MusicWeb/img_QuangCao/QC_Video.MP4' type='video/mp4' /> <source src='../MusicWeb/img_QuangCao/QC_Video.webm' type='video/webm' /> <source src='../MusicWeb/img_QuangCao/QC_Video.ogv' type='video/ogg' />";
            Play__.InnerHtml += "<track kind='captions' src='../MusicWeb/video-js/demo.captions.vtt' srclang='en' label='English'></track>";
            Play__.InnerHtml += "<track kind='subtitles' src='../MusicWeb/video-js/demo.captions.vtt' srclang='en' label='English'></track>";
    }
}
