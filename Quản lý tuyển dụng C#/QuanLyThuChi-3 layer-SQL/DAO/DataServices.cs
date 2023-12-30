using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DTO;

namespace DAO
{
    public class DataServices
    {
        public static SqlConnection ketnoi()
        {
            SqlConnection cnn = new SqlConnection();
            string m_ConnectString;
            XmlDocument xmlDoc = XML.XMLReader("Connection.xml");
            XmlElement xmlEle = xmlDoc.DocumentElement;
            m_ConnectString = "Data Source="
                + xmlEle.SelectSingleNode("servname").InnerText
                + ";Initial Catalog="
                + xmlEle.SelectSingleNode("database").InnerText
                + ";User Id="
                + xmlEle.SelectSingleNode("username").InnerText
                + ";Password="
                + xmlEle.SelectSingleNode("password").InnerText
                + ";";
            cnn.ConnectionString = m_ConnectString;
            return cnn;
        }
        public static Boolean testketnoi()
        {
            SqlConnection cnn = ketnoi();
            try
            {
                cnn.Open();
                return true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Lỗi kết nối đến cơ sở dữ liệu! Xin vui lòng thiết lập lại kết nối...", "ERROR", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                cnn.Close();
            }
        }
    }
}
