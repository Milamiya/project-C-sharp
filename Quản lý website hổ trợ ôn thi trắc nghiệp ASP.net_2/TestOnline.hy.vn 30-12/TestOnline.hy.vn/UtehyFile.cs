using System;
using System.Data;
using System.IO;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace sdh.utehy.edu.vn
{
    public class UtehyFile
    {
        private static string strFile = "";
        private static string strExtenSion = "";
        private static string strVideo = "";
        private static string strVideoExtenSion = "";
        private static string strFoder = "";

        public static string StrExtenSion
        {
            get { return strExtenSion; }
            set { strExtenSion = value; }
        }
        public static bool DeleteFileInFck(string strFCK)
        {
            return _DeleteFileInFck(strFCK);
        }
        private static bool _DeleteFileInFck(string strFCK)
        {
            bool havedo = false;
            if (!string.IsNullOrEmpty(strFCK))
            {
                List<string> list = new List<string>();
                string s = strFCK;
                int i = -1, j = 0;
                i = s.IndexOf("<img");
                while (i > -1)
                {
                    s = s.Substring(i);
                    j = s.IndexOf("/>");
                    if (j > -1)
                    {
                        list.Add(s.Substring(0, (j + 2)));
                        s = s.Substring(j + 1);
                    }
                    else
                    {
                        s = s.Substring(1);
                    }
                    i = s.IndexOf("<img");

                }

                if (list.Count > 0)
                {
                    havedo = true;
                    string item = "", path = "";
                    HttpApplication a = new HttpApplication();
                    HttpServerUtility h = null;
                    for (int k = 0; k < list.Count; k++)
                    {
                        i = list[k].IndexOf("src=");
                        if (i != -1)
                        {
                            item = list[k].Substring(i + 5);
                            j = item.IndexOf('"');
                            if (j != -1)
                            {
                                item = item.Substring(0, j);
                                path = h.MapPath(item);
                                if (File.Exists(path))
                                {
                                    File.Delete(path);
                                }
                            }
                        }

                    }

                }
            }
            return havedo;
        }
        public static string StrFile
        {
            get { return UtehyFile.strFile; }
            set { UtehyFile.strFile = value; }
        }
        public static string StrVideo
        {
            get { return UtehyFile.strVideo; }
            set { UtehyFile.strVideo = value; }
        }
        public static string StrVideoExtenSion
        {
            get { return UtehyFile.strVideoExtenSion; }
            set { UtehyFile.strVideoExtenSion = value; }
        }
        public static string StrFoder
        {
            get { return UtehyFile.strFoder; }
            set { UtehyFile.strFoder = value; }
        }
        public enum StyleFile
        {
            HOUR_MINUTE_SECOND,
            YEAR_MONTH_DAY_SECOND
        }
        public enum StyleFoder
        {
            YEAR_MONTH_DAY, YEAR_MONTH
        }
        public static bool FileImage(string fileName)
        {

            try
            {
                string[] strEX = new string[] { ".bmp", ".gif", ".jpeg", ".jpg", ".png" };
                if (strEX.Contains(Path.GetExtension(fileName).ToLower()))
                {
                    strExtenSion = Path.GetExtension(fileName).ToLower();
                    return true;
                }
                else return false;
            }
            catch
            {
                return false;
            }
        }
        public static bool FileVideo(string fileName)
        {
            try
            {
                string[] strEX = new string[] { "7z", "aiff", "asf", "avi", "bmp", "csv", "doc", "fla", "flv", "gif", "gz", "gzip", "jpeg", "jpg", "mid", "mov", "mp3", "mp4", "mpc", "mpeg", "mpg", "ods", "odt", "pdf", "png", "ppt", "pxd", "qt", "ram", "rar", "rm", "rmi", "rmvb", "rtf", "sdc", "sitd", "swf", "sxc", "sxw", "tar", "tgz", "tif", "tiff", "txt", "vsd", "wav", "wma", "wmv", "xls", "xml", "zip" };
                if (strEX.Contains(Path.GetExtension(fileName).ToLower()))
                {
                    strVideoExtenSion = Path.GetExtension(fileName).ToLower();
                    return true;
                }
                else return false;
            }
            catch
            {
                return false;

            }
        }
        public static void CreateFoder(string paht)
        {
            try
            {
                DirectoryInfo dtinfo = new DirectoryInfo(paht);
                if (!dtinfo.Exists)
                {
                    dtinfo.Create();
                }
                StrFoder = paht;

            }
            catch
            {
                StrFoder = "";
            }

        }

        public static void CreateFoder(string paht, string styleFoder)
        {
            try
            {
                if (StyleFoder.YEAR_MONTH_DAY.ToString() == styleFoder)
                {
                    string strFoder1 = paht + "/" + DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Day;
                    DirectoryInfo dtinfo = new DirectoryInfo(strFoder1);
                    if (!dtinfo.Exists)
                    {
                        dtinfo.Create();

                    }
                    StrFoder = strFoder1;
                }
                if (StyleFoder.YEAR_MONTH.ToString() == styleFoder)
                {
                    string strFoder1 = paht + "/" + DateTime.Now.Year + "/" + DateTime.Now.Month;
                    DirectoryInfo dtinfo = new DirectoryInfo(strFoder1);
                    if (!dtinfo.Exists)
                    {
                        dtinfo.Create();

                    }
                    StrFoder = strFoder1;
                }

            }
            catch
            {

                StrFoder = "";
            }


        }
        public static void DeleteFile(string path)
        {
            try
            {
                FileInfo file = new FileInfo(path);
                if (file.Exists)
                {
                    file.IsReadOnly = false;
                    file.Delete();
                }
            }
            catch
            {


            }
        }
        public static void CreateFile(string strpath, string styleFile, string strWordEnd)
        {
            try
            {
                string fi = "";
                if (StyleFile.HOUR_MINUTE_SECOND.ToString() == styleFile)
                {
                    while (true)
                    {
                        fi = strpath + "/" + DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second + "_" + strWordEnd;
                        FileInfo file = new FileInfo(fi);
                        if (!file.Exists)
                        {
                            break;

                        }

                    }
                }
                else
                {
                    if (StyleFile.YEAR_MONTH_DAY_SECOND.ToString() == styleFile)
                    {
                        while (true)
                        {
                            fi = strpath + "/" + DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_" + DateTime.Now.Second + "_" + strWordEnd;
                            FileInfo file = new FileInfo(fi);
                            if (!file.Exists)
                            {
                                break;

                            }

                        }
                    }

                }
                StrFile = fi;
            }
            catch
            {
                StrFile = "";
            }

        }
        public static string FolderNoSpaces(string strInput)
        {
            try
            {

                string input = strInput.ToLower();
                char[] ch = new char[] 
            { 
                'a','à','ả','ã','á',
                'ạ','ă','ằ','ẳ','ẵ',
                'ắ','ặ','â','ầ','ẩ',
                'ẫ','ấ','ậ','e','è',
                'ẻ','ẽ','é','ẹ','ê',
                'ề','ể','ễ','ế','ệ',
                'i','ì','ỉ','ĩ','í',
                'ị','o','ò','ỏ','õ',
                'ó','ọ','ô','ồ','ổ',
                'ỗ','ố','ộ','ơ','ờ',
                'ở','ỡ','ớ','ợ','u',
                'ù','ủ','ũ','ú','ụ',
                'ư','ừ','ử','ữ','ứ',
                'ự','y','ỳ','ỷ','ỹ',
                'ý','ỵ','d','đ'
            };
                string[] str = new string[] 
            { 
                "a","a","a","a","a",
                 "a","a","a","a","a",
                "a","a","a","a","a",
               "a","a","a","e","e",
                "e","e", "e","e","e",
                 "e","e", "e","e","e",
                "i","i","i","i","i",
                 "i", "o","o","o","o",
                "o","o","o","o","o",
               "o","o","o","o","o",
               "o","o","o","o","u",
               "u","u","u","u","u",
                "u","u","u","u","u",
               "u","y","y","y","y",
               "y","y","d","d"
            };
                string strTmp = "";
                for (int i = 0; i < input.Length; i++)
                {
                    bool ok = false;
                    int index = 0;
                    for (int j = 0; j < ch.GetLength(0); j++)
                    {
                        if (input[i] == ch[j])
                        {
                            index = j;
                            ok = true; break;
                        }

                    }
                    if (ok)
                        strTmp += str[index];
                    else strTmp += input[i];
                }
                // execute Standardized
                string[] strStandar = strTmp.Split(new char[] { ' ' });
                strTmp = "";
                for (int i = 0; i < strStandar.Length; i++)
                {
                    string tmp = strStandar[i];
                    if (i != strStandar.Length - 1)
                        strTmp += tmp[0].ToString().ToUpper() + tmp.Substring(1, tmp.Length - 1) + "-";
                    else strTmp += tmp[0].ToString().ToUpper() + tmp.Substring(1, tmp.Length - 1);
                }
                return strTmp;
            }
            catch
            {

                string strError = DateTime.Now.Year + "-" + DateTime.Now.Month;
                return strError;
            }
        }
        public static string NoSpaces(string strInput)
        {
            try
            {

                string input = strInput.ToLower().Replace(" ", "");
                char[] ch = new char[] 
            { 
                'a','à','ả','ã','á',
                'ạ','ă','ằ','ẳ','ẵ',
                'ắ','ặ','â','ầ','ẩ',
                'ẫ','ấ','ậ','e','è',
                'ẻ','ẽ','é','ẹ','ê',
                'ề','ể','ễ','ế','ệ',
                'i','ì','ỉ','ĩ','í',
                'ị','o','ò','ỏ','õ',
                'ó','ọ','ô','ồ','ổ',
                'ỗ','ố','ộ','ơ','ờ',
                'ở','ỡ','ớ','ợ','u',
                'ù','ủ','ũ','ú','ụ',
                'ư','ừ','ử','ữ','ứ',
                'ự','y','ỳ','ỷ','ỹ',
                'ý','ỵ','d','đ'
            };
                string[] str = new string[] 
            { 
                "a","a","a","a","a",
                 "a","a","a","a","a",
                "a","a","a","a","a",
               "a","a","a","e","e",
                "e","e", "e","e","e",
                 "e","e", "e","e","e",
                "i","i","i","i","i",
                 "i", "o","o","o","o",
                "o","o","o","o","o",
               "o","o","o","o","o",
               "o","o","o","o","u",
               "u","u","u","u","u",
                "u","u","u","u","u",
               "u","y","y","y","y",
               "y","y","d","d"
            };
                string strTmp = "";
                for (int i = 0; i < input.Length; i++)
                {
                    bool ok = false;
                    int index = 0;
                    for (int j = 0; j < ch.GetLength(0); j++)
                    {
                        if (input[i] == ch[j])
                        {
                            index = j;
                            ok = true; break;
                        }

                    }
                    if (ok)
                        strTmp += str[index];
                    else strTmp += input[i];
                }
                return strTmp;
            }
            catch
            {

                return "";
            }
        }
    }
}
