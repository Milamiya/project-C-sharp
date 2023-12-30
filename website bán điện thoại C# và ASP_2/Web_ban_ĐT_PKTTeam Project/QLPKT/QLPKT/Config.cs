using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace QLPKT
{
    public class Config
    {
        private string path = "";
        //dung lenh da co trong kernel32 cua windows
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filepath);
        [DllImport("kernel32")]
        private static extern long GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filepath);
        public Config(string thePath)
        {
            this.path = thePath;
        }
        /// <summary>
        /// doc thong tin trong file ini
        /// </summary>
        /// <param name="section"></param>
        /// <param name="key"></param>
        /// <returns>string value</returns>
        public string ReadValue(string section, string key)
        {
            StringBuilder tmp = new StringBuilder(255);
            long i = GetPrivateProfileString(section, key, "", tmp, 255, this.path);
            return tmp.ToString();
        }
        /// <summary>
        /// Ghi thong tin vao file ini
        /// </summary>
        /// <param name="section"></param>
        /// <param name="key"></param>
        /// <param name="val"></param>
        public void WriteValue(string section, string key, string values)
        {
            WritePrivateProfileString(section, key, values, this.path);
        }

    }
}
