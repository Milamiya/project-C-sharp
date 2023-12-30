using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using System.Windows.Forms;

namespace MusicOnline
{
   public class clsHTML
   {
       public static string GetHTML(string address)
       {
           if (address == "") return "";
           String Url = address;
           WebRequest request = null;
           WebResponse response = null;
           StreamReader reader = null;
           string data = string.Empty;
           try
           {               
               request = WebRequest.Create(Url);
               response = request.GetResponse();
               reader = new StreamReader(response.GetResponseStream());
               data = reader.ReadToEnd();
               reader.Close();
               response.Close();
           }
           catch
           {

              
           }
           
           return data;

       }


       public static void Download(string address,string type)
       {
           WebRequest req = WebRequest.Create(address);
           WebResponse response = req.GetResponse();
           Stream stream = response.GetResponseStream();
           FileStream file = new FileStream(Application.StartupPath + @"\icon." + type, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
           byte[] buffer = new byte[8912];
           int read=0;
           while (true)
           {
               read = stream.Read(buffer, 0, buffer.Length);
               file.Write(buffer, 0, read);

           }
           file.Close();
           response.Close();
           stream.Close();
       }

       public static string GetPlayerNCT(int height, int width,string url)
       {

           string CSS_body = "<style type=\"text/css\">body {margin-left: 0px;margin-top: 0px;margin-right: 0px;}</style>";
           string strBody = ""
               + "<html><head>" + CSS_body + "</head><body><center><object codebase=\"http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=9,0,0,0\" "
               + "id=\"FlashNCTPlayer\" classid=\"clsid:D27CDB6E-AE6D-11cf-96B8-444553540000\" width=\"" + width + "\" height=\"" + height + "\"> "
               + "<param "
               + " value=\""+new Uri(Application.StartupPath +"\\player.swf")+"?file=" + url + "\" "
               + " name=\"movie\"> "
               + "<param value=\"high\" name=\"quality\"> "
               + "<param value=\"always\" name=\"AllowScriptAccess\"> "
               + "<param value=\"transparent\" name=\"wmode\"> "
               + "<param value=\"autostart=true\" name=\"FlashVars\"> "
               + "<embed src=\""+new Uri(Application.StartupPath +"\\player.swf")+"?file=" + url + "\" "
               + "pluginspage=\"http://www.macromedia.com/go/getflashplayer\" "
               + "allowscriptaccess=\"always\" type=\"application/x-shockwave-flash\" "
               + "flashvars=\"autostart=true\" wmode=\"transparent\" id=\"FlashNCTPlayer\" "
               + "width=\"" + width + "\" height=\"" + height + "\"> "
               + "</object></center></body></html>";
           return strBody;
       }

    }
}
