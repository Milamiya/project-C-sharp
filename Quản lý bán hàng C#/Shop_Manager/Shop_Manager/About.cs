using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Shop_Manager
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs pea)
        {
            Graphics grfx = pea.Graphics;
            Brush brush = new SolidBrush(ForeColor);
            int y = 20;
            grfx.DrawString("    Chương trình quản lý bán hàng được", Font, brush, 0, y);
            grfx.DrawString("viết bằng ngôn ngữ C#",Font,brush,0,y+=Font.Height);
            grfx.DrawString("Tác giả: Nguyễn Tuấn Minh",Font,brush,0,y+=Font.Height);
            grfx.DrawString("Chương trình phần mềm này được Luật",Font,brush,0,y+=Font.Height);
            grfx.DrawString("pháp Việt nam và quốc tế bảo hộ.", Font, brush, 0, y+=Font.Height);
            grfx.DrawString("Sản xuất hoặc phân phối trái phép toàn",Font,brush,0,y+=Font.Height);
            grfx.DrawString("bộ hoặc một phần của phần mềm này sẽ",Font,brush,0,y+=Font.Height);
            grfx.DrawString("chịu các hình phạt về hình sự hoặc dân",Font,brush,0,y+=Font.Height);
            grfx.DrawString("sự, có thể lên đến mức tối đa đúng theo",Font,brush,0,y+=Font.Height);
            grfx.DrawString("pháp luật qui định.", Font, brush, 0, y += Font.Height);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}