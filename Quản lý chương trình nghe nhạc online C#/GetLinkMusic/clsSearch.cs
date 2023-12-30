using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing;

namespace MusicOnline
{
   public class clsSearch
   {
       public clsSearch(MainForm mainForm,string id, bool SearchOne_Or_SearchAll)
       {
           _MainForm = mainForm;
           _SearchOne_Or_SearchAll = SearchOne_Or_SearchAll;
           _Id = id;
       }
       //Download source code tại Sharecode.vn
       private MainForm _MainForm;
       private string _Id;
       private bool _SearchOne_Or_SearchAll;
     
       private void SearchPage(string data, string begin,string end,string Site)
       {
           if (data.Contains(begin))
           {
               _MainForm._pages.Clear();
               string tempPage = data.Substring(data.IndexOf(begin));
               tempPage = tempPage.Remove(tempPage.IndexOf(end));
               string[] pages = tempPage.Split(new string[] { begin, end }, StringSplitOptions.RemoveEmptyEntries);
               string regexPatternPage = @"<a.*?href=[""'](?<GroupId>.*?)[""'].*?((title=[""'](?<GroupTitle>.*?)[""'])|)>.*?(?<GroupName>.*?)</a>";
               MatchCollection matchPage=null;
              if(pages.Length>1)
                    matchPage = Regex.Matches(pages[1], regexPatternPage, RegexOptions.IgnoreCase);
              else
                  matchPage = Regex.Matches(pages[0], regexPatternPage, RegexOptions.IgnoreCase);
               foreach (Match page in matchPage)
               {
                   clsLinkA linkPage = new clsLinkA();
                   if (page.Groups["GroupName"].Success && page.Groups["GroupId"].Success)
                   {
                       linkPage.StrName = page.Groups["GroupName"].Value.Trim();
                       if (Site.Contains("nhaccuatui"))
                            linkPage.StrHref = "http://v6.nhaccuatui.com" + page.Groups["GroupId"].Value;
                       else
                           linkPage.StrHref =  page.Groups["GroupId"].Value;
                       _MainForm._pages.Add(linkPage);
                   }
               }
               if (_MainForm._pages.Count > 0)
               {
                   
                   int temp=int.Parse(_MainForm._pages[_MainForm._pages.Count-1].StrName.Trim());
                   int indexPage = 0;
                   for (int i = temp - _MainForm._pages.Count; i <= temp; i++)
                   {
                      
                       foreach (clsLinkA item in _MainForm._pages)
                       {
                           if (i.ToString() != item.StrName.Trim())
                           {
                                   _MainForm._CurrentPage = i.ToString();
                                   clsLinkA linkpage = new clsLinkA();

                                   linkpage.StrName = i.ToString();
                                   if (Site.Contains("nhaccuatui"))
                                   {
                                       linkpage.StrHref = _MainForm._pages[0].StrHref.Replace(_MainForm._pages[0].StrName, _MainForm._CurrentPage.ToString());
                                       _MainForm._pages.Insert(indexPage, linkpage);
                                       _MainForm.Invoke(new MusicOnline.MainForm.delegateUpdatePage(_MainForm.UpdatePage), new object[] { "http://v6.nhaccuatui.com" });
                                       return;
                                   }
                                   else
                                   {
                                       linkpage.StrHref = _MainForm._pages[0].StrHref.Replace(_MainForm._pages[0].StrName + ".html", _MainForm._CurrentPage.ToString() + ".html");
                                       _MainForm._pages.Insert(indexPage, linkpage);
                                       _MainForm.Invoke(new MusicOnline.MainForm.delegateUpdatePage(_MainForm.UpdatePage), new object[] { "http://mp3.zing.vn"});
                                       return;
                                   }
                                   
                                                           
                           }
                           i++;
                          indexPage++;
                       }

                   }
                   
                  
                  
               }


              

           }
   
       }


       public void NhacCuaTui(object linkBegin)
       {
           string link = (string)linkBegin;
           Match matchDomain = Regex.Match(link, @"(?<Protocol>\w+):\/\/(?<Domain>[\w.]+\/?)\S*");

           string data = string.Empty;
           List<MatchCollection> matchs = new List<MatchCollection>();
           string RegexPatternBaiHat = string.Empty;
           string RegexPatternTrinhBay = @"<a href=[""].*?/tim[-|_|+]kiem\?by=casi&key=(?<GroupId>.*?)[""].*?((title=[""](?<GroupTitle>.*?)[""])|)>.*?(?<GroupName>.*?)</a>";
           string RegexPatternTheLoai = @"<a href=[""].*?/tim[-|_|+]kiem\?type=(?<GroupId>.*?)[""].*?((title=[""](?<GroupTitle>.*?)[""])|)>.*?(?<GroupName>.*?)</a>";
           string RegexPatternIcon = @"<img src=[""]http://static2.nhaccuatui.com/Icon/?(?<icon>.*?)?.(gif|jpg)[""]";
           string KeyBaiHat = "nghe?M=";
           string KeyTrinhBay = "tim_kiem?by=casi&key=";
           string KeyTheLoai = "tim_kiem?type=";
           List<string> arrRow =new List<string>();
           data = clsHTML.GetHTML(link);
           try
           {
               if (_SearchOne_Or_SearchAll)
               {
                   if (matchDomain.Groups["Domain"].Value.Contains("nhaccuatui.com"))
                       RegexPatternBaiHat = @"<a.*?href=[""]\/nghe\?M=" + _Id + @"[""].*?(title=[""](?<GroupTitle>.*?)[""]).*?>.*?(?<GroupName>.*?)</a>";
                   else if (matchDomain.Groups["Domain"].Value.Contains("mp3.zing.vn"))
                       RegexPatternBaiHat = @"<a.*?href=[""]\/mp3\/nghe-bai-hat\/" + _Id + @"[""].*?((title=[""](?<GroupTitle>.*?)[""])|).*?>.*?(?<GroupName>.*?)</a>";
               }

               else
               {
                   _MainForm.Invoke(new MusicOnline.MainForm.delegateUpdateClear(_MainForm.UpdateClear), new object[] { });
                   _MainForm.Invoke(new MusicOnline.MainForm.delegateUpdateCreatePlaylist(_MainForm.UpdateCreatePlaylist), new object[] { null, false });

                   if (matchDomain.Groups["Domain"].Value.Contains("nhaccuatui.com"))
                       RegexPatternBaiHat = @"<a.*?href=[""]\/nghe\?M=(?<GroupId>.*?)[""].*?(title=[""](?<GroupTitle>.*?)[""]).*?>.*?(?<GroupName>.*?)</a>";
                   else if (matchDomain.Groups["Domain"].Value.Contains("mp3.zing.vn"))
                       RegexPatternBaiHat = @"<a.*?href=[""]\/mp3\/nghe-bai-hat\/(?<GroupId>.*?)[""].*?((title=[""](?<GroupTitle>.*?)[""])|).*?>.*?(?<GroupName>.*?)</a>";

               }



               if (matchDomain.Groups["Domain"].Value.Contains("nhaccuatui.com"))
               {
                   KeyBaiHat = "nghe?M=";
                   KeyTrinhBay = "tim_kiem?by=casi&key=";
                   KeyTheLoai = "tim_kiem?type=";
                   RegexPatternTrinhBay = @"<a.*?href=[""].*?/tim[-|_|+]kiem\?by=casi&key=(?<GroupId>.*?)[""].*?((title=[""](?<GroupTitle>.*?)[""])|)>.*?(?<GroupName>.*?)</a>";
                   RegexPatternTheLoai = @"<a.*?href=[""].*?/tim[-|_|+]kiem\?type=(?<GroupId>.*?)[""].*?((title=[""](?<GroupTitle>.*?)[""])|)>.*?(?<GroupName>.*?)</a>";
                   SearchPage(data, "Trang:", "chủ đề", "http://v6.nhaccuatui.com");
                }
               else if (matchDomain.Groups["Domain"].Value.Contains("mp3.zing.vn"))
               {
                   KeyBaiHat = "mp3/nghe-bai-hat/";
                   KeyTrinhBay = "mp3/search/do.html?";
                   KeyTheLoai = "mp3/search/do.html?g=";
                   RegexPatternTrinhBay = @"Trình bày:.*?<a href=[""]\/mp3\/search\/do.html\?(?<GroupId>.*?)[""].*?((title=[""](?<GroupTitle>.*?)[""])|).*?>.*?(?<GroupName>.*?)</a>";
                   RegexPatternTheLoai = @"<a.*?href=[""]\/mp3\/search\/do.html\?g=(?<GroupId>.*?)[""].*?((title=[""](?<GroupTitle>.*?)[""])|)>.*?(?<GroupName>.*?)</a>";
                   SearchPage(data, "Trang trước", "Trang sau", "");
                   
               }

               
                             

               string strsplit = string.Empty;
               if (matchDomain.Groups["Domain"].Value.Contains("nhaccuatui.com"))
                   strsplit = "<div class=\"row\">";
               else
                   strsplit = "<h1>";

               arrRow.AddRange(data.Split(new string[] { strsplit, "" }, StringSplitOptions.RemoveEmptyEntries));
               if (matchDomain.Groups["Domain"].Value.Contains("mp3.zing")&& arrRow.Count <= 6 && !_SearchOne_Or_SearchAll)
               {
                   strsplit = "RwCakhuc";
                   arrRow.Clear();
                   arrRow.AddRange(data.Split(new string[] { strsplit, "" }, StringSplitOptions.RemoveEmptyEntries));
               }
               else if (matchDomain.Groups["Domain"].Value.Contains("nhaccuatui") && arrRow.Count <= 6 &&_SearchOne_Or_SearchAll)
               {
                   strsplit = "<div class=\"item\">";
                   arrRow.Clear();
                   arrRow.AddRange(data.Split(new string[] { strsplit, "" }, StringSplitOptions.RemoveEmptyEntries));
               }
               if (arrRow.Count <= 1) return;
               if (matchDomain.Groups["Domain"].Value.Contains("mp3.zing"))
               {
                   if (!_SearchOne_Or_SearchAll)
                         arrRow.RemoveAt(1);
                   else
                       arrRow.RemoveAt(0);
                   for (int i = 0; i < arrRow.Count; i++)
                   {
                       if (arrRow[i].Contains("Gợi ý") || arrRow[i].Contains("Bình luận"))
                       {
                           arrRow.RemoveRange(i, arrRow.Count - i);
                           break;
                       }

                   }

               }
               if (!_SearchOne_Or_SearchAll)
                    arrRow.RemoveAt(0);

               MatchCollection match;
               ListViewItem item;              
               foreach (string row in arrRow)
               {

                   if (row.Contains("<!DOCTYPE")) continue;
                   clsFile PlayerFile = new clsFile();
                   PlayerFile.IIndex=_MainForm._IndexRow;
                   item = new ListViewItem();                  
                  
                   
                   //Bai hat va link
                   match = Regex.Matches(row, RegexPatternBaiHat, RegexOptions.IgnoreCase);
                   if (matchDomain.Groups["Domain"].Value.Contains("mp3.zing") && match.Count <= 0)
                   {
                       //tim video
                       if (!_SearchOne_Or_SearchAll)
                       {
                           RegexPatternBaiHat = @"<a href=[""]\/mp3\/video-clip\/xem-video/(?<GroupId>.*?)[""].*?((title=[""](?<GroupTitle>.*?)[""])|).*?>.*?(?<GroupName>.*?)</a>";
                           match = Regex.Matches(row, RegexPatternBaiHat, RegexOptions.IgnoreCase);
                           if (match.Count <= 0)//tim album
                               RegexPatternBaiHat = @"<a href=[""]\/mp3\/nghe-album/(?<GroupId>.*?)[""].*?((title=[""](?<GroupTitle>.*?)[""])|).*?>.*?(?<GroupName>.*?)</a>";
                           match = Regex.Matches(row, RegexPatternBaiHat, RegexOptions.IgnoreCase);
                       }
                       else
                       {
                           RegexPatternBaiHat =@"<a.*?href=[""]\/mp3\/search\/do.html\?t=1(?<GroupId>.*?)[""].*?((title=[""](?<GroupTitle>.*?)[""])|)>.*?(?<GroupName>.*?)</a>";
                           RegexPatternTrinhBay = @"Trình bày:.*?<a.*?href=[""]\/mp3\/search\/do.html\?t=2(?<GroupId>.*?)[""].*?((title=[""](?<GroupTitle>.*?)[""])|).*?>.*?(?<GroupName>.*?)</a>";
                           match = Regex.Matches(row, RegexPatternBaiHat, RegexOptions.IgnoreCase);
                           KeyTrinhBay +="t=2";
                       }
                       
                   }

                   if (match.Count > 0 && match[0] != null && match[0].Success)
                   {
                       if (match[0].Groups["GroupName"].Value.Contains("img"))
                           continue;

                       PlayerFile.StrName = string.Format("{0:000}", _MainForm._IndexRow) + ". " + match[0].Groups["GroupName"].Value;
                       item.ToolTipText= match[0].Groups["GroupTitle"].Value;
                      
                       if (_SearchOne_Or_SearchAll)//search one
                           PlayerFile.StrRefererUrl =string.Format("{0}://{1}{2}{3}", matchDomain.Groups["Protocol"].Value , matchDomain.Groups["Domain"].Value ,KeyBaiHat, _Id);
                       else
                           PlayerFile.StrRefererUrl =string.Format("{0}://{1}{2}{3}", matchDomain.Groups["Protocol"].Value, matchDomain.Groups["Domain"].Value ,KeyBaiHat, match[0].Groups["GroupId"].Value);
                                      

                       string[] url = { "", "" };
                       url = clsProcessUrl.URL(PlayerFile.StrRefererUrl);
                       if (url != null && url[1] != null)
                       {
                           PlayerFile.StrUrl = url[1];
                           _MainForm.Invoke(new MusicOnline.MainForm.delegateUpdateCreatePlaylist(_MainForm.UpdateCreatePlaylist), new object[] { url[1], true });
                       }
                       else
                           url = new string[] { "", "" };
                       //url xml
                       PlayerFile.StrRefererUrl = url[0];
                       

                       //link download
                       PlayerFile.StrUrl = url[1];
                       
                   }
                   else
                       continue;
                                                     
                   

                   match = Regex.Matches(row, RegexPatternTrinhBay, RegexOptions.IgnoreCase);
                   //Trinh bay va link
                 
                   if (match.Count > 0 && match[0] != null && match[0].Success)
                   {
                       PlayerFile.StrArtist = match[0].Groups["GroupName"].Value;
                       PlayerFile.StrArtistUrl =string.Format("{0}://{1}{2}{3}",matchDomain.Groups["Protocol"].Value , matchDomain.Groups["Domain"].Value,KeyTrinhBay, match[0].Groups["GroupId"].Value);
                       
                   }
                   else
                   {
                       PlayerFile.StrArtist = "";
                       PlayerFile.StrArtistUrl = "";
                   }

                   match = Regex.Matches(row, RegexPatternTheLoai, RegexOptions.IgnoreCase);
                   //The loai va link
                   
                   if (match.Count > 0 && match[0] != null && match[0].Success)
                   {
                       string theloaiTemp = match[0].Groups["GroupName"].Value;
                       theloaiTemp = theloaiTemp.Replace("<strong>", "");
                       theloaiTemp = theloaiTemp.Replace("</strong>", "");
                       PlayerFile.StrCategory = theloaiTemp;
                       PlayerFile.StrCategoryUrl =string.Format("{0}://{1}{2}{3}",matchDomain.Groups["Protocol"].Value,matchDomain.Groups["Domain"].Value ,KeyTheLoai, match[0].Groups["GroupId"].Value);
                        
                   }
                   else
                   {
                       PlayerFile.StrCategory ="";
                       PlayerFile.StrCategoryUrl = "";
                   }
                      
                   //ten - casi - the loai

                   //Icon
                   match = Regex.Matches(row, RegexPatternIcon, RegexOptions.IgnoreCase);
                   if (match.Count > 0 && match[0] != null && match[0].Success)
                   {
                       if (match[0].Groups["icon"].Value == "MP3")
                           item.ImageIndex = 0;
                       else
                           item.ImageIndex = 1;
                   }
                   else
                       item.ImageIndex = 1;
                   item.Text =string.Format("{0} - {1} - {2}",PlayerFile.StrName ,PlayerFile.StrArtist, PlayerFile.StrCategory);
                   item.Checked = true;
                   item.SubItems.Add("");
                   _MainForm.Invoke(new MusicOnline.MainForm.delegateUpdate(_MainForm.Update), new object[] { item, PlayerFile });

                   if (_SearchOne_Or_SearchAll)//search one
                       break;
               }
           }
           catch 
           {
               
               
           }

           _MainForm.Invoke(new MusicOnline.MainForm.delegatePlayFile(_MainForm.AutoPlayFile), new object[] {  });


       }

       public static List<clsLinkA> Category(object linkBegin)
       {
           List<string> category = new List<string>();
           List<clsLinkA> LinkA = new List<clsLinkA>();
           string link = (string)linkBegin;
           string data = clsHTML.GetHTML(link);
           string Beginsplit = string.Empty;
           string Endsplit = string.Empty;
           string RegexPattern = "<.*a.*?href=.*?\"(?<GroupId>.*?)\".*?>(?<GroupName>.*?)<.*/.*a.*>";
           if (link.Contains("nhaccuatui.com"))
           {
               Beginsplit = "category-box";
               Endsplit = "menu-hot-keyword";
           }
           else
           {
               Beginsplit = "THỂ LOẠI";
               Endsplit = "maincol";
           
           }
           category.AddRange(data.Split(new string[] { Beginsplit, Endsplit }, StringSplitOptions.RemoveEmptyEntries));
           category.RemoveAt(0);
           category.RemoveAt(1);
           MatchCollection matchs = Regex.Matches(category[0], RegexPattern, RegexOptions.IgnoreCase);
           category.Clear();
           foreach (Match match in matchs)
           {
               clsLinkA a = new clsLinkA();
               a.StrName = match.Groups["GroupName"].Value;
               a.StrHref = match.Groups["GroupId"].Value;
               LinkA.Add(a);
           }

           return LinkA;

       }

           



   }
}
