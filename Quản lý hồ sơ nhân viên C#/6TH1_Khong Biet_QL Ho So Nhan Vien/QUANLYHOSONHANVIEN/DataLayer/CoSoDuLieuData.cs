using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using DevComponents.DotNetBar;
using System.Windows.Forms;

namespace QUANLYHOSONHANVIEN.DataLayer
{
    public class CoSoDuLieuData
    {
        DataService m_Ds = new DataService();
        static bool AAA = false;
        public bool SaoLuuDuLieu(string duongDan)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand(" backup database QLHSNS to disk = '" + duongDan + "'");
                m_Ds.Load(cmd);
                MessageBoxEx.Show("Sao lưu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch
            {
                MessageBoxEx.Show("Có lỗi khi sao lưu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
        }
        public bool PhucHoiDuLieu(string duongDan)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand(" use master restore database QLHSNS from disk = '" + duongDan + "' with REPLACE");
                m_Ds.Load(cmd);
                MessageBoxEx.Show("Phục hồi thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch
            {
                MessageBoxEx.Show("Không thể phục hồi CSDL", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //AAA = true;
                return false;
            }
        }
    }
}
