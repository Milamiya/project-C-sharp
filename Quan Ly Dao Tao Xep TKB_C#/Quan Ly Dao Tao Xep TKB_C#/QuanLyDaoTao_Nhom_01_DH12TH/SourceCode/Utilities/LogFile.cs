using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Collections.ObjectModel;

namespace QuanLyDaoTao.Utilities
{
    /// <summary>
    /// Ghi nhận lịch sử sử dụng chương trình.
    /// </summary>
    public class LogFile
    {
        private string tenFile;

        public string TenFile
        {
            get { return tenFile; }
        }

        private DateTime thoiGian;

        public DateTime ThoiGian
        {
            get { return thoiGian; }
        }

        private string thaoTac;

        public string ThaoTac
        {
            get { return thaoTac; }
            set { thaoTac = value; }
        }

        private string quyen;

        public string Quyen
        {
            get { return quyen; }
        }
        private string tenNguoiDung;

        public string TenNguoiDung
        {
            get { return tenNguoiDung; }
        }

        public LogFile()
        {
            try
            {
                thoiGian = new DateTime();
                tenFile = "Thang_" + DateTime.Now.ToString("MM-yyyy") + "_log.log";
                thaoTac = string.Empty;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void GhiFile()
        {
            StreamWriter writer = new StreamWriter(tenFile, true);
            try
            {
                writer.WriteLine(DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy") + "#" + StaticClass.User.MoTaQuyen + "#" +
                    StaticClass.User.TenNguoiDung + "#" + thaoTac);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                writer.Close();
            }
        }

        public void GhiFile(string hanhDong)
        {
            StreamWriter writer = new StreamWriter(tenFile, true);
            try
            {
                writer.WriteLine(DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy") + "#" + StaticClass.User.MoTaQuyen + "#" +
                    StaticClass.User.TenNguoiDung + "#" + hanhDong);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                writer.Close();
            }
        }

        public static Collection<LogFile> DocFile(string duongDan)
        {
            StreamReader reader = new StreamReader(duongDan);
            try
            {
                Collection<LogFile> result = new Collection<LogFile>();
                while (!reader.EndOfStream)
                {
                    LogFile item = new LogFile();
                    string str = reader.ReadLine();
                    string[] strArr = str.Split('#');
                    item.thoiGian = DateTime.Parse(strArr[0]);
                    item.quyen = strArr[1];
                    item.tenNguoiDung = strArr[2];
                    item.thaoTac = strArr[3];
                    result.Add(item);
                }
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                reader.Close();
            }
        }
    }
}
