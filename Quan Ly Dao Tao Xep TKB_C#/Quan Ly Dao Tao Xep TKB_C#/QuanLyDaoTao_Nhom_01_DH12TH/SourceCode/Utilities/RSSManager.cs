using System;
using System.Collections.ObjectModel;
using System.Xml;

namespace QuanLyDaoTao.Utilities
{
    /// <summary>
    /// Lớp phục vụ việc chuyển đổi và hiển thị tin tức (RSS feeds)
    /// </summary>
    [Serializable]
    class RSSManager: IDisposable
    {
        #region Biến thành viên

        private string url;
        private string feedTitle;
        private string feedDescription;
        private Collection<RSS.Items> rssItems = new Collection<RSS.Items>();
        private bool isDisposed;

        #endregion

        #region Hàm dựng

        /// <summary>
        /// Hàm dựng mặc định không đối số.
        /// Url được gán giá trị rỗng (Url = Empty)
        /// </summary>
        public RSSManager()
        {
            url = string.Empty;
        }

        /// <summary>
        /// Hàm dựng có đối số.
        /// </summary>
        /// <param name="feedUrl">Url</param>
        public RSSManager(string feedUrl)
        {
            url = feedUrl;
        }

        #endregion

        #region Thuộc tính

        /// <summary>
        /// Lấy/gán url cho nguồn cung cấp tin tức
        /// </summary>
        public string Url
        {
            get { return url; }
            set { url = value; }
        }

        /// <summary>
        /// Lấy tất cả các bài viết của nguồn
        /// </summary>
        public Collection<RSS.Items> RssItems
        {
            get { return rssItems; }
        }

        /// <summary>
        /// Tiêu đề nguồn tin
        /// </summary>
        public string FeedTitle
        {
            get { return feedTitle; }
            set { feedTitle = value; }
        }

        /// <summary>
        /// Mô tả
        /// </summary>
        public string FeedDescription
        {
            get { return feedDescription; }
            set { feedDescription = value; }
        }

        #endregion

        #region Phương thức

        /// <summary>
        /// Lấy tập hợp các tin tức
        /// </summary>
        public Collection<RSS.Items> GetFeed()
        {
            //kiểm tra url
            if (string.IsNullOrEmpty(url))
                throw new Exception("Bạn phải cung cấp Url nguồn tin");
            using (XmlReader reader = XmlReader.Create(url))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(reader);
                ParseDocElements(xmlDoc.SelectSingleNode("//channel"), "title", ref feedTitle);
                ParseDocElements(xmlDoc.SelectSingleNode("//channel"), "description", ref feedDescription);
                ParseRssItems(xmlDoc);
                return rssItems;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void ParseRssItems(XmlDocument xmlDoc)
        {
            rssItems.Clear();
            XmlNodeList nodes = xmlDoc.SelectNodes("rss/channel/item");

            foreach (XmlNode node in nodes)
            {
                RSS.Items item = new RSS.Items();
                ParseDocElements(node, "title", ref item.Title);
                ParseDocElements(node, "description", ref item.Description);
                ParseDocElements(node, "link", ref item.Link);

                string date = null;
                ParseDocElements(node, "pubDate", ref date);
                DateTime.TryParse(date, out item.Date);

                rssItems.Add(item);
            }
        }

        private void ParseDocElements(XmlNode parent, string xPath, ref string property)
        {
            XmlNode node = parent.SelectSingleNode(xPath);
            if (node != null)
                property = node.InnerText;
            else
                property = "Unresolvable";
        }

        /// <summary>
        /// Performs the disposal.
        /// </summary>
        private void Dispose(bool disposing)
        {
            if (disposing && !isDisposed)
            {
                rssItems.Clear();
                url = null;
                feedTitle = null;
                feedDescription = null;
            }

            isDisposed = true;
        }

        /// <summary>
        /// Releases the object to the garbage collector
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
