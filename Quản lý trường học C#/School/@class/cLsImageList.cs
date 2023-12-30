using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
namespace School._class
{
    class cLsImageList
    {
        public static void SetListView(ListView sListView, string sCaption, Byte sIcon, ImageList sImageList)
        {
          //  sListView.Width = 650;
            sListView.LargeImageList = sImageList;
            sListView.SmallImageList = sImageList;
            sListView.Items.Add(new ListViewItem(sCaption, sIcon));


        }
        
    }
}
