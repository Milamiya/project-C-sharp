using System;
using System.Collections.Generic;

namespace QuanLyDaoTao.Utilities
{
    class RSS
    {
        /// <summary>
        /// Một struct chứa các thông tin của 1 tin tức
        /// </summary>
        [Serializable]
        public struct Items
        {
            /// <summary>
            /// Ngày đăng bài viết.
            /// </summary>
            public DateTime Date;

            /// <summary>
            /// Tiêu đề của bài viết
            /// </summary>
            public string Title;

            /// <summary>
            /// Nội dung chính của bài viết
            /// </summary>
            public string Description;

            /// <summary>
            /// Liên kết đến bài viết đầy đủ
            /// </summary>
            public string Link;
        }
    }
}
