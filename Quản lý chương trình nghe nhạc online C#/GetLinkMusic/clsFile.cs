using System;
using System.Collections.Generic;
using System.Text;

namespace MusicOnline
{
   public class clsFile
    {

        private int _iIndex = 0;
        private string _strId = string.Empty;
        private string _strTitle = string.Empty;
        private string _strName = string.Empty;
        private string _strArtist = string.Empty;
        private string _strArtistUrl = string.Empty;
        private string _strCategory = string.Empty;
        private string _strCategoryUrl = string.Empty;
        private string _strRefererUrl = string.Empty;
        private string _strUrl = string.Empty;

        public int IIndex
        {
            get { return _iIndex; }
            set { _iIndex = value; }
        }
                   

        public string StrId
        {
            get { return _strId; }
            set { _strId = value; }
        }
                     

        public string StrTitle
        {
            get { return _strTitle; }
            set { _strTitle = value; }
        }
                    

        public string StrName
        {
            get { return _strName; }
            set { _strName = value; }
        }
              

        public string StrArtist
        {
            get { return _strArtist; }
            set { _strArtist = value; }
        }
               

        public string StrArtistUrl
        {
            get { return _strArtistUrl; }
            set { _strArtistUrl = value; }
        }
              

        public string StrCategory
        {
            get { return _strCategory; }
            set { _strCategory = value; }
        }
               

        public string StrCategoryUrl
        {
            get { return _strCategoryUrl; }
            set { _strCategoryUrl = value; }
        }
               

        public string StrRefererUrl
        {
            get { return _strRefererUrl; }
            set { _strRefererUrl = value; }
        }
              

        public string StrUrl
        {
            get { return _strUrl; }
            set { _strUrl = value; }
        }

        

    }
}
