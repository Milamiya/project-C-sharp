using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan_DTO
    {
        private string _uID;

        public string UID
        {
            get { return _uID; }
            set { _uID = value; }
        }

        private string _uPSS;

        public string UPSS
        {
            get { return _uPSS; }
            set { _uPSS = value; }
        }
        private string _uPSS2;

        public string UPSS2
        {
            get { return _uPSS2; }
            set { _uPSS2 = value; }
        }
        private int _uTYPE;

        public int UTYPE
        {
            get { return _uTYPE; }
            set { _uTYPE = value; }
        }
        private string _uQUES;

        public string UQUES
        {
            get { return _uQUES; }
            set { _uQUES = value; }
        }
        private string _uANS;

        public string UANS
        {
            get { return _uANS; }
            set { _uANS = value; }
        }
    }
}
