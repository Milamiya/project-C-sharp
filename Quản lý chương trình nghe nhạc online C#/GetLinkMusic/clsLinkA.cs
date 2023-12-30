using System;
using System.Collections.Generic;
using System.Text;

namespace MusicOnline
{
   public class clsLinkA
    {
        private string _strHref = string.Empty;

        public string StrHref
        {
            get { return _strHref; }
            set { _strHref = value; }
        }
        private string _strTitle = string.Empty;

        public string StrTitle
        {
            get { return _strTitle; }
            set { _strTitle = value; }
        }
        private string _strName = string.Empty;

        public string StrName
        {
            get { return _strName; }
            set { _strName = value; }
        }
        private string _strAlt = string.Empty;

        public string StrAlt
        {
            get { return _strAlt; }
            set { _strAlt = value; }
        }
    }
}
