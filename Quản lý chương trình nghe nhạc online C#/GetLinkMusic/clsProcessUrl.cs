using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;
using System.Xml;

namespace MusicOnline
{
   public class clsProcessUrl
   {
       public static bool IsURL(string url)
       {
           Match m = Regex.Match(url, @"(?<Protocol>\w+):\/\/(?<Domain>[\w.]+\/?)\S*");
           if (m.ToString() != string.Empty)
           {
               return true;
           }
           return false;
       }


       public static string[] URL(string urlNeedProcess)
       {
           string[] UrlCap1VaCap2 = new string[2];
           Match matchDomain = Regex.Match(urlNeedProcess, @"(?<Protocol>\w+):\/\/(?<Domain>[\w.]+\/?)\S*");
           if (IsURL(urlNeedProcess))
               matchDomain = Regex.Match(urlNeedProcess, @"(?<Protocol>\w+):\/\/(?<Domain>[\w.]+\/?)\S*");
           try
           {
               String Url = urlNeedProcess;

               string data = string.Empty;
               string RegexPattern = @"<embed.*?src=[""'].*?.swf?.*?=(?<url>.*?)[""']";
               string[] UrlList = null;
               bool FlagComplete = false;
               MatchCollection matches = null;

           Working:
               int c = 0;
               data =clsHTML.GetHTML(Url);
               matches = Regex.Matches(data, RegexPattern, RegexOptions.IgnoreCase);
               UrlList = new string[matches.Count];
               foreach (Match match in matches)
               {
                   UrlList[c] = match.Groups["url"].Value;
                   c++;
               }
               if (FlagComplete == false && UrlList.Length > 0)
               {
                   //UrlList[0] co dang: http://v6.nhaccuatui.com/GetMusic.aspx?key2=007600040060007600150018002300320060000c
                   if (!UrlList[0].Contains(matchDomain.Groups["Protocol"].Value))
                   {
                       Url = matchDomain.Groups["Protocol"].Value + "://" + matchDomain.Groups["Domain"].Value.Remove(matchDomain.Groups["Domain"].Value.IndexOf('/')) + UrlList[0];
                   }

                   else
                       Url = UrlList[0];
                   UrlCap1VaCap2[0] = Url;
                  
                   FlagComplete = true;// chay lan nua la se lay duoc link goc
                   goto Working; //xu li tiep link cap 2 de lay link goc
               }
               // FlagComplete = true; se lay duoc link goc
               else
               {
                   //loc link tu file xml
                   UrlList = data.Split(new char[] { '>', '<' });

                   foreach (string link in UrlList)
                   {
                       if (link != "" && link.LastIndexOf('.') > 0)
                       {
                           string linkTemp = link;
                           //neu ma link tu mp3.zing.vn thi lay duoc link mp3 fai + them doan fia sau: ?q=....
                           if (linkTemp.Contains("mp3.zdn.vn"))
                               linkTemp += "?q=e43176f8150d7e30a6bd59bbe46b766b&t=60303108";
                           linkTemp = linkTemp.Replace(" ", "%20");
                           UrlCap1VaCap2[1] = linkTemp;
                           string extension = link.Substring(link.LastIndexOf('.'));
                           switch (extension)
                           {
                               case ".mp3": return UrlCap1VaCap2;
                               case ".flv": return UrlCap1VaCap2;
                               case ".avi": return UrlCap1VaCap2;
                               case ".mp4": return UrlCap1VaCap2;
                               case ".m4a": return UrlCap1VaCap2;
                               case ".m4v": return UrlCap1VaCap2;
                               case ".mov": return UrlCap1VaCap2;
                               case ".mpa": return UrlCap1VaCap2;
                               case ".mpeg": return UrlCap1VaCap2;
                               case ".wav": return UrlCap1VaCap2;
                               case ".wma": return UrlCap1VaCap2;
                               case ".wmv": return UrlCap1VaCap2;
                           }
                       }


                   }

               }
           }
           catch
           {


           }



           return new string[]{"",""};

       }


       public static clsFile GetInfoURL(string urlNeedProcess)
       {
           clsFile file = new clsFile();
           Match matchDomain = Regex.Match(urlNeedProcess, @"(?<Protocol>\w+):\/\/(?<Domain>[\w.]+\/?)\S*");
           if (IsURL(urlNeedProcess))
               matchDomain = Regex.Match(urlNeedProcess, @"(?<Protocol>\w+):\/\/(?<Domain>[\w.]+\/?)\S*");
           try
           {
               String Url = urlNeedProcess;

               string data = string.Empty;
               string RegexPattern = @"<embed.*?src=[""'].*?.swf?.*?=(?<url>.*?)[""']";
               string[] UrlList = null;
               bool FlagComplete = false;
               MatchCollection matches = null;

           Working:
               int c = 0;
               data = clsHTML.GetHTML(Url);
               matches = Regex.Matches(data, RegexPattern, RegexOptions.IgnoreCase);
               UrlList = new string[matches.Count];
               foreach (Match match in matches)
               {
                   UrlList[c] = match.Groups["url"].Value;
                   c++;
               }
               if (FlagComplete == false && UrlList.Length > 0)
               {
                   //UrlList[0] co dang: http://v6.nhaccuatui.com/GetMusic.aspx?key2=007600040060007600150018002300320060000c
                   if (!UrlList[0].Contains(matchDomain.Groups["Protocol"].Value))
                   {
                       Url = matchDomain.Groups["Protocol"].Value + "://" + matchDomain.Groups["Domain"].Value.Remove(matchDomain.Groups["Domain"].Value.IndexOf('/')) + UrlList[0];
                   }

                   else
                       Url = UrlList[0];


                   FlagComplete = true;// chay lan nua la se lay duoc link goc
                   goto Working; //xu li tiep link cap 2 de lay link goc
               }
               // FlagComplete = true; se lay duoc link goc
               else
               {
                   
                   string RegexPatternTrinhBay =string.Empty;
                   string RegexPatternBaiHat = string.Empty;
                   if (matchDomain.Groups["Domain"].Value.Contains("nhaccuatui.com")) //nhaccuatui.com
                   {
                       RegexPattern = @"<location>(?<url>.*?)</location>";
                       RegexPatternBaiHat = @"<creator>(?<baihat>.*?)</creator>";
                       RegexPatternTrinhBay = @"<title>(?<trinhbay>.*?)</title>";
                   }
                   else
                   {
                       RegexPattern = @"<source>(?<url>.*?)</source>"; //mp3.zing.vn
                       RegexPatternBaiHat = @"<title>(?<baihat>.*?)((]]>)|)</title>";
                       RegexPatternTrinhBay = @"<singer>(?<trinhbay>.*?)</singer>";
                   }
                   data = clsHTML.GetHTML(Url);
                   matches = Regex.Matches(data, RegexPattern, RegexOptions.IgnoreCase);
                   file.StrUrl = matches[0].Groups["url"].Value;
                   if (file.StrUrl.Contains(".mp4"))
                       file.StrUrl += "?q=57dd52d4365be86ebd4803521862f5ee&t=603031854";
                   else if (file.StrUrl.Contains(".mp3"))
                       file.StrUrl += "?q=e43176f8150d7e30a6bd59bbe46b766b&t=60303108";
                   else if (file.StrUrl.Contains(".flv"))
                       file.StrUrl += "?q=93f74da9793c0ffe9fc1d4c71fae5ebf&t=603031854";

                   file.StrUrl = file.StrUrl.Replace(" ", "%20");

                   matches = Regex.Matches(data, RegexPatternBaiHat, RegexOptions.IgnoreCase);
                   file.StrName = matches[0].Groups["baihat"].Value;
                   file.StrName=file.StrName.Substring(file.StrName.LastIndexOf("[")+1);
                   file.StrName = file.StrName.Replace("]","");
                   file.StrName = file.StrName.Replace(">", "").Trim();

                   matches = Regex.Matches(data, RegexPatternTrinhBay, RegexOptions.IgnoreCase);
                   file.StrArtist = matches[0].Groups["trinhbay"].Value;
                   file.StrArtist = file.StrArtist.Substring(file.StrArtist.LastIndexOf("[") + 1);
                   file.StrArtist = file.StrArtist.Replace("]", "");
                   file.StrArtist = file.StrArtist.Replace(">", "").Trim();
                  

               }
           }
           catch
           {


           }



           return file;

       }


       public static clsFile GetUrlById(string url)
       {
           clsFile file = new clsFile();
           MatchCollection matches = null;
           file.StrRefererUrl = url;
           
           Match matchDomain = Regex.Match(url, @"(?<Protocol>\w+):\/\/(?<Domain>[\w.]+\/?)\S*");
           string Id = url.Substring(url.LastIndexOf("=") + 1);
           string RegexPatternBaiHat = @"<a href=[""']\/nghe\?M=" + Id + @"[""'].*?title=[""'](?<GroupTitle>.*?)[""'].*?>.*?(?<GroupName>.*?)</a>";
           string data =clsHTML.GetHTML(url);
           matches = Regex.Matches(data, RegexPatternBaiHat, RegexOptions.IgnoreCase);
           foreach (Match match in matches)
           {

              file.StrTitle = match.Groups["GroupTitle"].Value;
              file.StrName= match.Groups["GroupName"].Value;
              file.StrUrl = URL(url)[1];
           }
           return file;
       }


       #region TheoYeuCau.com

       public static string XmlReaderTheoyeucau(string link, string Xml_url)
       {
           Xml_url = link + "XML/?refer=" + Xml_url.Substring(1) + "XML/";
           
           string host = "";
           string ext = "";
           int id = 0;
           string title = "";
           string file = "";
           string artist = "";
           string name = "";
           string content = "";
           string url = "";
           url = "";
           try
           {
              string temp = clsHTML.GetHTML(Xml_url);
               string[] element = temp.Split(new string[] { "<host>", "</host>" }, StringSplitOptions.RemoveEmptyEntries);
               host = element[1];
               element= temp.Split(new string[] { "<title>", "</title>" }, StringSplitOptions.RemoveEmptyEntries);
               title = element[1].Trim();
               element = temp.Split(new string[] { "<file>", "</file>" }, StringSplitOptions.RemoveEmptyEntries);
               file = element[1].Trim();
                             
               element = temp.Split(new string[] { "<ext>", "</ext>" }, StringSplitOptions.RemoveEmptyEntries);
               ext = element[1].Trim();
              
               url = host + "/" + EncryptThepyeucau(title, file) + "." + EncryptThepyeucau(host, ext) + "?refer=" + file;
             
           }
           catch (Exception ex)
           {
               url = ex.Message;
           }
           
           return url;

       }
       public static string EncryptThepyeucau(string title, string file)
       {
           string _l4 = "";
           string _l1 = "";
           int _l2 = 0;
           for (int i = 0; i < Math.Ceiling((double)file.Length / 4); i++)
           {
               _l1 = file.Substring(i * 4, 4);
               _l1 = _l1.Substring(1, 3);
               if (_l1.Substring(0, 1) == "0")
               {
                   _l1 = _l1.Substring(1, 2);
               } // end if
               _l2 = Convert.ToInt32(_l1) - title.Length;
               _l4 = _l4 + Convert.ToChar(_l2);
           } // end of for
           return (_l4);
       }

       #endregion

   }
}
