using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using QuanLyBanHangDienTu.DataAccess;

namespace QuanLyBanHangDienTu.Presentation
{
    public partial class fr_Ketnoi : Form
    {
        public fr_Ketnoi()
        {
            InitializeComponent();
        }
        ConnectDB cn = new ConnectDB();
        private void cmddn_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (File.Exists("Sinfo"))
                {
                    File.Delete("Sinfo");
                    StreamWriter write = new StreamWriter("Sinfo");
                    write.WriteLine("SV=:" + txtserver.Text);
                    write.WriteLine("DB=:" + txtdb.Text);
                    write.Close();
                    MessageBox.Show("Đã Thiết Lập xong", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    StreamWriter write = new StreamWriter("Sinfo");
                    write.WriteLine("SV=:" + txtserver.Text);
                    write.Close();
                    MessageBox.Show("Đã Thiết Lập xong", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Question);

                }

                MessageBox.Show("Kết Nối Thành Công Tới Sever " + txtserver.Text + ". Bạn sẻ phải khởi động lại chương trình đối với lần kết nối đầu tiên", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("Không thiết lập được", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void cmdthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
