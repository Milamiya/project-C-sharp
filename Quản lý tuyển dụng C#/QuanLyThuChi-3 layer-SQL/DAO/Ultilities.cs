using System;
using System.Text;
using System.Data;
using System.Xml;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;

namespace DAO
{
        public static class Utilities
        {
            //public static NguoiDungInfo NguoiDung;
            public static String DatabaseName;
        }

        public class QuyDinh
        {
            public String ArrayToString(String[] array, int n)
            {
                String str = "";
                for (int i = 0; i < n; i++)
                {
                    if (i != n - 1)
                        str += array[i] + ";";
                    else
                        str += array[i];
                }
                return str;
            }

            public String LaySTT(int autoNum)
            {
                if (autoNum < 10)
                    return "000" + autoNum;

                else if (autoNum >= 10 && autoNum < 100)
                    return "00" + autoNum;

                else if (autoNum >= 100 && autoNum < 1000)
                    return "0" + autoNum;

                else if (autoNum >= 1000 && autoNum < 10000)
                    return "" + autoNum;

                else
                    return "";
            }
        }

        #region Các hàm xử lý tập tin XML
        public class XML
        {
            public static XmlDocument XMLReader(String filename)
            {
                XmlDocument xmlR = new XmlDocument();
                try
                {
                    xmlR.Load(filename);
                }
                catch
                {
                    MessageBox.Show("Không đọc được hoặc không tồn tại tập tin cấu hình " + filename, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return xmlR;
            }

            public static void XMLWriter(String filename, String servname, String database, String costatus)
            {
                XmlTextWriter xmlW = new XmlTextWriter(filename, null);
                xmlW.Formatting = Formatting.Indented;

                xmlW.WriteStartDocument();
                xmlW.WriteComment("\nKhong duoc thay doi noi dung file nay!\n" +
                                    "Thong so co ban:\n\t" +
                                    "costatus = true : quyen Windows\n\t" +
                                    "costatus = false: quyen SQL Server\n\t" +
                                    "servname: ten server\n\t" +
                                    "username: ten dang nhap he thong\n\t" +
                                    "password: mat khau dang nhap he thong\n\t" +
                                    "database: ten co so du lieu\n");
                xmlW.WriteStartElement("config");

                xmlW.WriteStartElement("costatus");
                xmlW.WriteString(costatus);
                xmlW.WriteEndElement();

                xmlW.WriteStartElement("servname");
                xmlW.WriteString(servname);
                xmlW.WriteEndElement();

                xmlW.WriteStartElement("username");
                xmlW.WriteString("");
                xmlW.WriteEndElement();

                xmlW.WriteStartElement("password");
                xmlW.WriteString("");
                xmlW.WriteEndElement();

                xmlW.WriteStartElement("database");
                xmlW.WriteString(database);
                xmlW.WriteEndElement();

                xmlW.WriteEndElement();
                xmlW.WriteEndDocument();

                xmlW.Close();
            }

            public static void XMLWriter(String filename, String servname, String username, String password, String database, String costatus)
            {
                XmlTextWriter xmlW = new XmlTextWriter(filename, null);
                xmlW.Formatting = Formatting.Indented;

                xmlW.WriteStartDocument();
                xmlW.WriteComment("\nKhong duoc thay doi noi dung file nay!\n" +
                                    "Thong so co ban:\n\t" +
                                    "costatus = true : quyen Windows\n\t" +
                                    "costatus = false: quyen SQL Server\n\t" +
                                    "servname: ten server\n\t" +
                                    "username: ten dang nhap he thong\n\t" +
                                    "password: mat khau dang nhap he thong\n\t" +
                                    "database: ten co so du lieu\n");
                xmlW.WriteStartElement("config");

                xmlW.WriteStartElement("costatus");
                xmlW.WriteString(costatus);
                xmlW.WriteEndElement();

                xmlW.WriteStartElement("servname");
                xmlW.WriteString(servname);
                xmlW.WriteEndElement();

                xmlW.WriteStartElement("username");
                xmlW.WriteString(username);
                xmlW.WriteEndElement();

                xmlW.WriteStartElement("password");
                xmlW.WriteString(password);
                xmlW.WriteEndElement();

                xmlW.WriteStartElement("database");
                xmlW.WriteString(database);
                xmlW.WriteEndElement();

                xmlW.WriteEndElement();
                xmlW.WriteEndDocument();

                xmlW.Close();
            }
        }
        #endregion
}

