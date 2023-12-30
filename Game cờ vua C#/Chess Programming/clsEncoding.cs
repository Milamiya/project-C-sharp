using System;
using System.Collections.Generic;
using System.Text;

namespace Chess_Programming
{
    public static class clsEncoding
    {
        public static string Encode(string s)
        {
            s = Convert.ToBase64String(UTF8Encoding.UTF8.GetBytes(s));
            string str = "";
            foreach (char c in s)
            {
                if (char.IsLower(c))
                    str += char.ToUpper(c);
                else
                    str += char.ToLower(c);
            }
            return str;
        }

        public static string Decode(string s)
        {
            string str = "";
            foreach (char c in s)
            {
                if (char.IsLower(c))
                    str += char.ToUpper(c);
                else
                    str += char.ToLower(c);
            }

            byte[] b = Convert.FromBase64String(str);
            return UTF8Encoding.UTF8.GetString(b);
        }
    }
}
