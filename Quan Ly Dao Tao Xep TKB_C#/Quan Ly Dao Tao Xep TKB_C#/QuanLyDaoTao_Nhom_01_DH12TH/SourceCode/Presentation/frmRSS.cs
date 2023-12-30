using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyDaoTao.Utilities;
using System.Collections.ObjectModel;

namespace QuanLyDaoTao.Presentation
{
    public partial class frmRSS : XtraForm
    {
        RSSManager reader;
        Collection<RSS.Items> list;
        ListViewItem row;

        public frmRSS()
        {
            InitializeComponent();
            reader = new RSSManager();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            try
            {
                grbMain.Text = webBrowser1.Url.ToString();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
                return;
            }
        }

        private void lsvDiaChi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lsvMucTin.Items.Clear();

                reader.Url = lsvDiaChi.Items[SelectedItemIndex(lsvDiaChi)].SubItems[1].Text;
                reader.GetFeed();
                list = reader.RssItems;

                for (int i = 0; i < list.Count; i++)
                {
                    row = new ListViewItem();
                    row.Text = list[i].Title;
                    row.SubItems.Add(list[i].Link);
                    lsvMucTin.Items.Add(row);
                }
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
                return;
            }
        }

        private void lsvMucTin_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Uri url = new Uri(lsvMucTin.Items[SelectedItemIndex(lsvMucTin)].SubItems[1].Text);
                webBrowser1.Url = url;
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
                return;
            }
        }

        private void frmRSS_Load(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = new ListViewItem("Tin tức VNExpress");
                item.SubItems.Add("http://vnexpress.net/rss/tin-moi-nhat.rss");
                lsvDiaChi.Items.Add(item);

                item = new ListViewItem("Nội dung số VNExpress");
                item.SubItems.Add("http://sohoa.vnexpress.net/rss");
                lsvDiaChi.Items.Add(item);

                item = new ListViewItem("Thời Báo Kinh Tế Sài Gòn");
                item.SubItems.Add("http://www.thesaigontimes.vn/rss/doanhnghiep/");
                lsvDiaChi.Items.Add(item);

                item = new ListViewItem("Khoa học VNExpress");
                item.SubItems.Add("http://vnexpress.net/rss/khoa-hoc.rss/");
                lsvDiaChi.Items.Add(item);

                item = new ListViewItem("Cộng đồng VNExpress");
                item.SubItems.Add("http://vnexpress.net/rss/cong-dong.rss");
                lsvDiaChi.Items.Add(item);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
                return;
            }
        }

        private int SelectedItemIndex(ListView list)
        {
            for (int i = 0; i < list.Items.Count; i++)
            {
                if (list.Items[i].Selected) { return i; }
            }
            return 0;
        }




    }
}