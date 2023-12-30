using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.IO;
using System.Text;

namespace TestOnline.hy.vn.Control.Manager
{
    public class tool
    {
        
        /// <summary>
        ///Kiểm tra trong xâu có tồn tại chỉ số hay không
        /// </summary>
        /// <param name="xau"></param>
        /// <returns></returns>
        public bool KtraNumber(string xau)
        {
            bool kt = true;
            StringBuilder x = new StringBuilder(xau);
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] != '0' && x[i] != '1' && x[i] != '2' && x[i] != '3' && x[i] != '4' && x[i] != '5' && x[i] != '6' && x[i] != '7' && x[i] != '8' && x[i] != '9' && x[i] != ' ')
                { kt = false; break; }
            }
            return kt;
        }
        /// <summary>
        ///Kiểm tra trong xâu có tồn tại chỉ số hay không
        /// </summary>
        /// <param name="xau"></param>
        /// <returns></returns>
        public bool KtraNumberFloat(string xau)
        {
            bool kt = true;
            StringBuilder x = new StringBuilder(xau);
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] != '0' && x[i] != '1' && x[i] != '2' && x[i] != '3' && x[i] != '4' && x[i] != '5' && x[i] != '6' && x[i] != '7' && x[i] != '8' && x[i] != '9' && x[i] != ' ' && x[i] != '.')
                { kt = false; break; }
            }
            return kt;
        }
    }
}
