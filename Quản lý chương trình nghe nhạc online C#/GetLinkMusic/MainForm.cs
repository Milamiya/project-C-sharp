using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Net;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace MusicOnline
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        //Download source code tại Sharecode.vn
        Thread _thrSearch = null;
        public List<clsFile> FileList = new List<clsFile>();
        private bool _bIsUrlExists = false;//chua co trong playlist
        int _PlayingRow = -1;
        public string _CurrentPage="1";
        public int _IndexRow = 1;
        private List<clsLinkA> _ArtistLink = new List<clsLinkA>();
        private List<clsLinkA> _CateogryLink = new List<clsLinkA>();
        public List<clsLinkA> _pages = new List<clsLinkA>();

        private bool _IsSearchMenu = false;
        private SearchBy _SearchBy = SearchBy.None;
        public enum SearchBy
        {

            TatCa,
            TheLoai,
            CaSi,
            None,
        }

        public delegate void delegateUpdate(ListViewItem item, clsFile PlayFile);
        public void Update(ListViewItem item, clsFile PlayFile)
        {
            if (!_bIsUrlExists)
            {
              
                lvDetails.Items.Add(item);
                lvDetails.TopItem = item;
                FileList.Add(PlayFile);
              
            }
        }

        public delegate void delegateUpdateCreatePlaylist(string file, bool AddOrClear);
        public void UpdateCreatePlaylist(string file, bool AddOrClear)
        {
            if (AddOrClear)//add
            {
                _bIsUrlExists = false;
                for (int i = 0; i < Player.currentPlaylist.count; i++)
                {
                    if (file == Player.currentPlaylist.Item[i].sourceURL)
                        _bIsUrlExists = true;//trung

                }
                if (_bIsUrlExists)
                {
                    //DialogResult dialog = MessageBox.Show(file + " \nđã tồn tại trong playlist. Bạn có muốn thêm hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    //if (dialog == DialogResult.Yes)
                    //{
                    //    WMPLib.IWMPMedia song = Player.newMedia(file);
                    //    Player.currentPlaylist.appendItem(song);
                    //    _bIsUrlExists = false;

                    //}
                }
                else
                {
                    _IndexRow++;
                    WMPLib.IWMPMedia song = Player.newMedia(file);
                    Player.currentPlaylist.appendItem(song);
                    
                }

            }
            else
                UpdateClear();
            
        }

        public delegate void delegateUpdateClear();
        public void UpdateClear()
        {
            Player.currentPlaylist.clear();
            lvDetails.Items.Clear();
            FileList.Clear();
            _CurrentPage = "1";
            _PlayingRow = -1;
            _IndexRow = 1;
            _bIsUrlExists = false;
           
            FileList = new List<clsFile>();
        }

        public delegate void delegateUpdatePage(string Site);
        public void UpdatePage(string Site)
        {
            if (Site.Contains("nhaccuatui.com"))
            {
                cboNCT_Trang.Items.Clear();
                foreach (clsLinkA item in _pages)
                {
                    cboNCT_Trang.Items.Add(item.StrName);
                }
                if (cboNCT_Trang.Items.Count > 0)
                    cboNCT_Trang.Text = _CurrentPage;
            }
            else if (Site.Contains("mp3.zing.vn"))
            {
                cboZing_Trang.Items.Clear();
                foreach (clsLinkA item in _pages)
                {
                    cboZing_Trang.Items.Add(item.StrName);
                }
                if (cboZing_Trang.Items.Count > 0)
                    cboZing_Trang.Text = _CurrentPage;
            }

            
        }

        public delegate void delegatePlayFile();
        public void AutoPlayFile()
        {
            if (chkAutoSearch.Checked && FileList.Count > 0)
                PlayFile(0);
        }


        private void GetAllLink()
        {
            for (int i = 0; i <lvDetails.Items.Count; i++)
            {
                string url =clsProcessUrl.URL(FileList[i].StrUrl)[1];
                if (url != null)
                {
                    url = url.Replace(" ", "%20");
                    this.Invoke(new delegateUpdateCreatePlaylist(UpdateCreatePlaylist), new object[] { url });
                }
            }
        }


        private string Category(string Site)
        {
            foreach (clsLinkA item in _CateogryLink)
            {
                if (Site.Contains("nhaccuatui.com"))
                {
                    if (cboNCT_TheLoai.Text == item.StrName)
                        return item.StrHref;
                }
                else if (Site.Contains("mp3.zing.vn"))
                {
                    if (cboZing_TheLoai.Text == item.StrName)
                          return item.StrHref;
                  
                }
                
            }
           
            return "";
        }


        private string Artist(string Site)
        {
            foreach (clsLinkA item in _ArtistLink)
            {
                if (Site.Contains("nhaccuatui.com"))
                {
                    if (cboNCT_CaSi.Text == item.StrName)
                        return item.StrHref;
                }
                else if (Site.Contains("mp3.zing.vn"))
                {
                    if (cboZing_CaSi.Text == item.StrName)
                       return item.StrName;
                  
                }
                
            }
            return "";
        }

        private void Search(string Site,string TypeSearch,bool TypeSearchIsMenu)
        {
        
            if (_thrSearch!=null && _thrSearch.IsAlive)
                _thrSearch.Abort();
            
            splitContainerMainRight.SplitterDistance = splitContainerMainRight.Panel1MinSize;
            string urlSearch = string.Empty;
           

                string artist = Artist(Site);
                string category = Category(Site);
                string key = string.Empty;
                
                if(Site.Contains("nhaccuatui.com"))
                {
                    if (TypeSearch == "TatCa")
                    {
                        if (txtNCT_Tim.Text != "")
                            key = "key=" + txtNCT_Tim.Text + "&page=" + _CurrentPage;
                        if (artist == "" && category == "/tim_kiem" && txtNCT_Tim.Text == "")
                            urlSearch = "http://v6.nhaccuatui.com/tim_kiem&page=" + _CurrentPage;
                        if (artist == "" && category == "/tim_kiem")
                            urlSearch = "http://v6.nhaccuatui.com/tim_kiem?" + key;
                        else if (artist != "" && category == "/tim_kiem")
                            urlSearch = "http://v6.nhaccuatui.com/tim_kiem?by=casi&" + key;
                        else if (artist == "" && category != "/tim_kiem")
                            urlSearch = "http://v6.nhaccuatui.com" + category + "&" + key;
                        else
                            urlSearch = "http://v6.nhaccuatui.com/tim_kiem?by=casi&type=" + category.Substring(Category(Site).LastIndexOf("=") + 1) + "&" + key + "&page=" + _CurrentPage;

                    }
                    else if (TypeSearch == "TheLoai")
                    {
                        if(!category.Contains("?"))
                            urlSearch = "http://v6.nhaccuatui.com" + category + "?page=" + _CurrentPage.ToString();
                        else 
                            urlSearch = "http://v6.nhaccuatui.com" + category + "&page=" + _CurrentPage.ToString();
                    }
                    else if (TypeSearch == "CaSi")
                        urlSearch = "http://v6.nhaccuatui.com/tim_kiem?by=casi&key" + key + "&page=" + _CurrentPage.ToString();

                }
                else if(Site.Contains("mp3.zing.vn"))
                {                                            

                        
                        if(!TypeSearchIsMenu)
                        {

                            if (TypeSearch == "TatCa" && txtZing_Tim.Text != "")
                                urlSearch = "http://mp3.zing.vn/mp3/search/do.html?t=1&q=" + txtZing_Tim.Text;
                            else if (TypeSearch == "CaSi" && txtZing_Tim.Text != "")
                                urlSearch = "http://mp3.zing.vn/mp3/search/do.html?t=2&q=" + txtZing_Tim.Text;
                            else if (TypeSearch == "Album" && txtZing_Tim.Text != "")
                                urlSearch = "http://mp3.zing.vn/mp3/search/do.html?t=3&q=" + txtZing_Tim.Text;
                            else if (TypeSearch == "Video" && txtZing_Tim.Text != "")
                                urlSearch = "http://mp3.zing.vn/mp3/search/do.html?t=4&q=" + txtZing_Tim.Text;
                        }
                        else
                        {

                            if (TypeSearch == "TheLoai")
                            {
                                if (_CurrentPage != "")
                                    urlSearch = "http://mp3.zing.vn" + category.Replace(".html", "." + _CurrentPage + ".html");
                                else
                                    urlSearch = "http://mp3.zing.vn" + category;
                            }

                            else
                            {
                                if (_CurrentPage != "")
                                    urlSearch = "http://mp3.zing.vn/mp3/search/do." + _CurrentPage + ".html?t=2&q=" + artist;
                                else
                                    urlSearch = "http://mp3.zing.vn/mp3/search/do.1.html?t=2&q=" + artist;
                            }
                        }
                            

                }
              

                if (!urlSearch.Contains("http://")) return;
            clsSearch cls_search = new clsSearch(this, null, false);
            if (urlSearch.Contains("nhaccuatui.com"))
                _thrSearch = new Thread(new ParameterizedThreadStart(cls_search.NhacCuaTui));
            else if (urlSearch.Contains("mp3.zing.vn"))
                _thrSearch = new Thread(new ParameterizedThreadStart(cls_search.NhacCuaTui));
            _thrSearch.IsBackground = true;
            _thrSearch.Start(urlSearch);
            Thread.Sleep(100);
        }

       

        private void SetRowForcolorDefault()
        {
            foreach (ListViewItem item in lvDetails.Items)
               item.ForeColor =lvDetails.ForeColor;
        }
        
        public void PlayFile(int index)
        {
            if (Player.currentPlaylist.count <= 0 || Player.currentPlaylist.count < index) return;
            SetRowForcolorDefault();
            _PlayingRow = index;
           lvDetails.Items[index].ForeColor = Color.Red;
           WMPLib.IWMPMedia media = Player.currentPlaylist.get_Item(index);
           if (media.sourceURL.Substring(media.sourceURL.LastIndexOf(".") + 1).ToUpper() == "flv".ToUpper())
               splitContainerMainRight.SplitterDistance = 250;
           else
               splitContainerMainRight.SplitterDistance = 45;
           
           Player.Ctlcontrols.playItem(media);
           //Player.settings.volume = 0;
           //splitContainerScreen.Panel1Collapsed = false;//hien web player
           //splitContainerScreen.Panel2Collapsed = true;//an media

           
            
           
        }

  

        private void FormMain_Load(object sender, EventArgs e)
        {
            Player.currentPlaylist.clear();
            Player.newPlaylist("MusicOnline", "MusicOnline.wpl");
            ribbonTabItemMp3Zing_Click(sender, e);
            
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (splitContainerMainRight.SplitterDistance == splitContainerMainRight.Panel1MinSize||
                this.Size ==this.MinimumSize)
                splitContainerMainRight.SplitterDistance = splitContainerMainRight.Panel1MinSize;
        }

        private void trmState_Tick(object sender, EventArgs e)
        {

            //if (MousePosition.X < (Screen.PrimaryScreen.Bounds.Width / 2) && MousePosition.Y < (Screen.PrimaryScreen.Bounds.Height / 2))
            //{
            //    this.Location = new Point(MousePosition.X+10,MousePosition.Y+10);
            //}
            //else if (MousePosition.X > (Screen.PrimaryScreen.Bounds.Width / 2) && MousePosition.Y < (Screen.PrimaryScreen.Bounds.Height / 2))
            //{
            //    this.Location = new Point(MousePosition.X - (this.Width+10), MousePosition.Y+10);
            //}
            //else if (MousePosition.X < (Screen.PrimaryScreen.Bounds.Width / 2) && MousePosition.Y > (Screen.PrimaryScreen.Bounds.Height / 2))
            //{
            //    this.Location = new Point(MousePosition.X+10, MousePosition.Y-(this.Height+10));
            //}
            //else if (MousePosition.X > (Screen.PrimaryScreen.Bounds.Width / 2) && MousePosition.Y > (Screen.PrimaryScreen.Bounds.Height / 2))
            //{
            //    this.Location = new Point(MousePosition.X-(this.Width+10), MousePosition.Y-(this.Height+10));
            //}
            if (lvDetails.Items.Count > 0 && _PlayingRow > -1 && _PlayingRow < lvDetails.Items.Count)
            {
                if (lvDetails.Items[_PlayingRow].SubItems[1].Text == "" || lvDetails.Items[_PlayingRow].SubItems[1].Text=="00:00")
                {
                    lvDetails.Items[_PlayingRow].SubItems[1].Text = Player.currentMedia.durationString;
                    lvDetails.Columns[0].Width =360;
                    lvDetails.Columns[1].Width = 40;
                    this.Text = "Music Online - " + lvDetails.Items[_PlayingRow].Text;
                }

            }
          


        }

       

        private void Player_CurrentItemChange(object sender, AxWMPLib._WMPOCXEvents_CurrentItemChangeEvent e)
        {
          
            if (!Player.status.Contains("Stopped") && Player.currentPlaylist.count == FileList.Count && lvDetails.Items.Count > 0)
            {

                SetRowForcolorDefault();

                foreach (clsFile item in FileList)
                {
                    if (item.StrUrl == Player.currentMedia.sourceURL)
                    {
                        if(ribbonControlMain.SelectedRibbonTabItem==ribbonTabItemNCT)
                        {
                            //next page
                            if (Player.status.Contains("Ready") && Player.currentMedia.duration == 0
                            && chkAutoSearch.Checked && _PlayingRow + 1 == Player.currentPlaylist.count && cboNCT_Trang.Items.IndexOf(_CurrentPage) < cboNCT_Trang.Items.Count)
                            {
                                int page = Convert.ToInt32(_CurrentPage.Trim());
                                page++;
                                _CurrentPage = page.ToString();
                                cboNCT_Trang.SelectedIndex = cboNCT_Trang.Items.IndexOf(page.ToString());
                                Search("http://v6.nhaccuatui.com", _SearchBy.ToString(), _IsSearchMenu);
                                return;
                            }
                        }
                        else if (ribbonControlMain.SelectedRibbonTabItem == ribbonTabItemNCT)
                        {
                            //next page
                            if (Player.status.Contains("Ready") && Player.currentMedia.duration == 0
                            && chkAutoSearch.Checked && _PlayingRow + 1 == Player.currentPlaylist.count && cboZing_Trang.Items.IndexOf(_CurrentPage) < cboZing_Trang.Items.Count)
                            {
                                int page = Convert.ToInt32(_CurrentPage.Trim());
                                page++;
                                _CurrentPage = page.ToString();
                                cboZing_Trang.SelectedIndex = cboZing_Trang.Items.IndexOf(page.ToString());
                                Search("http://mp3.zing.vn", _SearchBy.ToString(), _IsSearchMenu);
                                return;
                            }
                        }
                        
                        _PlayingRow = FileList.IndexOf(item);
                        if (Convert.ToBoolean(lvDetails.Items[_PlayingRow].Checked))
                        {
                            if (Player.currentMedia.sourceURL.Substring(Player.currentMedia.sourceURL.LastIndexOf(".") + 1).ToUpper() == "flv".ToUpper())
                                splitContainerMainRight.SplitterDistance = 262;
                            else
                                splitContainerMainRight.SplitterDistance = 45;

                            lvDetails.Items[_PlayingRow].ForeColor = Color.Red;
                            lvDetails.Items[_PlayingRow].Selected = true;
                            trmState.Start();
                           
                        }
                        else
                        {
                            if (_PlayingRow + 1 < FileList.Count)
                                _PlayingRow++;
                            else
                                _PlayingRow = 0;
                            lvDetails.Items[_PlayingRow].ForeColor = Color.Red;
                            lvDetails.Items[_PlayingRow].Selected = true;
                            Player.Ctlcontrols.next();

                        }

                        break;
                    }
                }
            }
            
            
        }

      

       

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Player.currentPlaylist.clear();
            lvDetails.Items.Clear();

        }

        private void deleteFromPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
         if (lvDetails.Items.Count > 0 && lvDetails.FocusedItem != null && lvDetails.FocusedItem.Index >= 0)
            {
                Player.currentPlaylist.removeItem(Player.currentPlaylist.Item[lvDetails.FocusedItem.Index]);
                    lvDetails.Items.RemoveAt(lvDetails.FocusedItem.Index);
               
            }
            
            
        }

        private void thToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvDetails.Items.Count > 0 && lvDetails.FocusedItem != null && lvDetails.FocusedItem.Index >= 0)
            {
                string file =FileList[lvDetails.FocusedItem.Index].StrUrl;
                if (!File.Exists(Properties.Settings.Default.IDM))
                {
                    OpenFileDialog f = new OpenFileDialog();
                    f.Filter = "*.exe";
                    f.Multiselect = false;
                    f.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        Properties.Settings.Default.IDM = f.FileName;
                        Properties.Settings.Default.Save();
                        Process.Start(Properties.Settings.Default.IDM, "/d " + file);
                    }
                }
                else
                    Process.Start(Properties.Settings.Default.IDM, "/d " + file);
               
            }
        }

           

       

      

     

        #region Mp3.Zing.VN

         private void ribbonTabItemMp3Zing_Click(object sender, EventArgs e)
        {
            if (cboZing_TheLoai.Items.Count <= 0)
            {
                _CurrentPage = "1";
                List<clsLinkA> linkAs = new List<clsLinkA>();
                _CateogryLink = new List<clsLinkA>();
                _ArtistLink = new List<clsLinkA>();
                _pages = new List<clsLinkA>();
                linkAs = clsSearch.Category("http://mp3.zing.vn");
                cboZing_TheLoai.Items.Clear();
                cboZing_CaSi.Items.Clear();
                for (int i = 0; i < linkAs.Count; i++)
                {
                    if (linkAs[i].StrName.Contains("Nhạc"))
                    {
                        _CateogryLink.Add(linkAs[i]);
                        cboZing_TheLoai.Items.Add(linkAs[i].StrName);
                    }
                    else
                    {
                        _ArtistLink.Add(linkAs[i]);
                        cboZing_CaSi.Items.Add(linkAs[i].StrName);

                    }
                }
                if (cboZing_TheLoai.Items.Count > 0)
                    cboZing_TheLoai.SelectedIndex = 0;
                if (cboZing_CaSi.Items.Count > 0)
                    cboZing_CaSi.SelectedIndex = 0;
             }
            
        }

         private void cboZing_TheLoai_SelectionChangeCommitted(object sender, EventArgs e)
         {
             _CurrentPage = "1";
             _SearchBy = SearchBy.TheLoai;
             _IsSearchMenu = true;
             Search("http://mp3.zing.vn", _SearchBy.ToString(), _IsSearchMenu);
         }

         private void cboZing_CaSi_SelectionChangeCommitted(object sender, EventArgs e)
         {
             _CurrentPage = "1";
             _SearchBy = SearchBy.CaSi;
             _IsSearchMenu = true;
             Search("http://mp3.zing.vn", _SearchBy.ToString(), _IsSearchMenu);
         }
               
              
        private void cboZing_Trang_SelectionChangeCommitted(object sender, EventArgs e)
        {
            foreach (clsLinkA item in _pages)
            {
                if (item.StrName.Trim() == cboZing_Trang.Text.Trim())
                {
                    _CurrentPage = cboZing_Trang.Text;
                    Search("http://mp3.zing.vn", _SearchBy.ToString(), _IsSearchMenu);

                    break;
                }
            }
        }

      

        private void btnZing_Tim_Click(object sender, EventArgs e)
        {
            _SearchBy = SearchBy.TatCa;
            _IsSearchMenu = false;
            Search("http://mp3.zing.vn", _SearchBy.ToString(), _IsSearchMenu);
        }

        #endregion



        #region NhacCuaTui.Com

        private void ribbonTabItemNCT_Click(object sender, EventArgs e)
        {
            if (cboNCT_TheLoai.Items.Count <= 0)
            {
                _CurrentPage = "1";
                List<clsLinkA> linkAs = new List<clsLinkA>();
                _CateogryLink = new List<clsLinkA>();
                _ArtistLink = new List<clsLinkA>();
                _pages = new List<clsLinkA>();
                linkAs = clsSearch.Category("http://v6.nhaccuatui.com");
                cboNCT_TheLoai.Items.Clear();
                cboNCT_CaSi.Items.Clear();

                for (int i = 0; i < linkAs.Count; i++)
                {
                    _CateogryLink.Add(linkAs[i]);
                    cboNCT_TheLoai.Items.Add(linkAs[i].StrName);
                }

                cboNCT_CaSi.Items.AddRange(new string[] { "Tên bài hát/ chủ đề", "Tên ca sĩ/ trình diễn" });
                clsLinkA link = new clsLinkA();
                link.StrName = "Tên bài hát/ chủ đề";
                link.StrHref = "";
                _ArtistLink.Add(link);
                link = new clsLinkA();
                link.StrName = "Tên ca sĩ/ trình diễn";
                link.StrHref = "casi";
                _ArtistLink.Add(link);

                if (cboNCT_TheLoai.Items.Count > 0)
                    cboNCT_TheLoai.SelectedIndex = 0;
                if (cboNCT_CaSi.Items.Count > 0)
                    cboNCT_CaSi.SelectedIndex = 0;              
            }
            
        }

        private void cboNCT_CaSi_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _CurrentPage = "1";
            _SearchBy = SearchBy.CaSi;
            _IsSearchMenu = true;
            Search("http://v6.nhaccuatui.com", _SearchBy.ToString(), _IsSearchMenu);
        }

        private void cboNCT_TheLoai_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _CurrentPage = "1";
            _SearchBy = SearchBy.TheLoai;
            _IsSearchMenu = true;
            Search("http://v6.nhaccuatui.com", _SearchBy.ToString(), _IsSearchMenu);
        }

                     

        private void cboNCT_Trang_SelectionChangeCommitted(object sender, EventArgs e)
        {
            foreach (clsLinkA item in _pages)
            {
                if (item.StrName.Trim() == cboNCT_Trang.Text.Trim())
                {
                    _CurrentPage = cboNCT_Trang.Text;
                    Search("http://v6.nhaccuatui.com", _SearchBy.ToString(), _IsSearchMenu);
                    break;
                }
            }
        }


        private void btnNCT_Tim_Click(object sender, EventArgs e)
        {
            _SearchBy = SearchBy.TatCa;
            _IsSearchMenu = false;
            Search("http://v6.nhaccuatui.com", _SearchBy.ToString(), _IsSearchMenu);
        }

        #endregion




        #region ListView

         private void lvDetails_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && lvDetails.Items.Count <= 0)
                ctxFileList.Enabled = false;
        }

        private void lvDetails_DoubleClick(object sender, EventArgs e)
        {
            if (lvDetails.Items.Count > 0 && lvDetails.FocusedItem != null && lvDetails.FocusedItem.Index > 0)
            {
                lvDetails.Items[lvDetails.FocusedItem.Index].Checked = true;
                PlayFile(lvDetails.FocusedItem.Index);


            }
        }

        private void lvDetails_DragDrop(object sender, DragEventArgs e)
        {
            trmState.Start();
            string url = (string)e.Data.GetData(DataFormats.Text);
            //clsFile file = new clsFile();
            //file = clsProcessUrl.GetInfoURL(url);   
            Match matchDomain = Regex.Match(url, @"(?<Protocol>\w+):\/\/(?<Domain>[\w.]+\/?)\S*");
            string Id = string.Empty;
            if (matchDomain.Groups["Domain"].Value.Contains("nhaccuatui.com"))
                Id = url.Substring(url.LastIndexOf("=") + 1);
            else if (matchDomain.Groups["Domain"].Value.Contains("mp3.zing.vn"))
                Id = url.Substring(url.LastIndexOf("/") + 1);
            clsSearch cls_search = new clsSearch(this, Id, true);

            Thread working = null;
            working = new Thread(new ParameterizedThreadStart(cls_search.NhacCuaTui));
            working.IsBackground = true;
            working.Start(url);
            Thread.Sleep(100);
        }

        private void lvDetails_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;   
        }

         #endregion

      

      
      
      

      

      


       

       
    }
}
