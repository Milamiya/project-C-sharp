using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Collections;
using System.IO;
using System.Net;
using System.Threading;
using System.Data.SqlClient;

namespace Server
{
    public partial class frmServer : Form
    {
        //Tạo Luồng nhận data
        Thread thdHandler;
        //Tạo luồng lắng nghe
        Thread langnghe;
        public ArrayList alclient = new ArrayList();
        static String tmpStr;
        public int count = 0;
        String port = "8080";
        TcpListener myTcpListener;
        TcpClient myClient;
        SqlConnection conn;

        //Các Delegate
        private delegate void GetListBoxAddItem(ListBox lb);
        private delegate void GetListBoxRemoveItem(ListBox lb);
        private delegate void GetImageListBoxChangeItem(ImageListBox imglb, String s, bool Online);
        private delegate void GetImageListBoxAddItem(ImageListBox imglb, String s, bool Online);
        private delegate void GetMultilineListBoxAddItem(MultilineListBox lb, String s, Color color);

        private static void getImageListBoxAddItem(ImageListBox imglb, String s, bool Online)
        {
            if (imglb.InvokeRequired)
            {
                GetImageListBoxAddItem brao = new GetImageListBoxAddItem(getImageListBoxAddItem);
                imglb.Invoke(brao, new object[] { imglb, s, Online });
                return;
            }
            else
            {
                if (Online)
                {
                    imglb.Items.Add(new ImageListBoxItem(s, 1, Color.Red));
                }
                else
                {
                    imglb.Items.Add(new ImageListBoxItem(s, 0, Color.Blue));
                }
            }
        }

        private static void getImageListBoxChangeItem(ImageListBox imglb, String s, bool Online)
        {
            if (imglb.InvokeRequired)
            {
                GetImageListBoxChangeItem brao = new GetImageListBoxChangeItem(getImageListBoxChangeItem);
                imglb.Invoke(brao, new object[] { imglb, s, Online });
                return;
            }
            else
            {
                int i = SearchImageListBox(imglb, s);
                if (i != -1)
                {
                    if (Online)
                    {
                        imglb.SetImageIndex(i, 1);
                        imglb.SetTextColor(i, Color.Red);
                    }
                    else
                    {
                        imglb.SetImageIndex(i, 0);
                        imglb.SetTextColor(i, Color.Blue);
                    }
                }
                else
                {
                    if (Online)
                    {
                        imglb.Items.Add(new ImageListBoxItem(s, 1, Color.Red));
                    }
                    else
                    {
                        imglb.Items.Add(new ImageListBoxItem(s, 0, Color.Blue));
                    }
                }
            }
        }

        private static void getMultilineListBoxAddItem(MultilineListBox lb, String s, Color color)
        {
            if (lb.InvokeRequired)
            {
                GetMultilineListBoxAddItem brao = new GetMultilineListBoxAddItem(getMultilineListBoxAddItem);
                lb.Invoke(brao, new object[] { lb, s, color });
                return;
            }
            else
            {
                lb.Items.Add(new MultilineListBoxItem(s, color));
            }
        }
        
        private static void getListBoxAddItem(ListBox lb)
        {
            if (lb.InvokeRequired)
            {
                GetListBoxAddItem brao = new GetListBoxAddItem(getListBoxAddItem);
                lb.Invoke(brao, new object[] { lb });
                return;
            }
            else
            {
                lb.Items.Add(tmpStr);
            }
        }

        private static void getListBoxRemoveItem(ListBox lb)
        {
            if (lb.InvokeRequired)
            {
                GetListBoxRemoveItem brao = new GetListBoxRemoveItem(getListBoxRemoveItem);
                lb.Invoke(brao, new object[] { lb });
                return;
            }
            else
            {                
                lb.Items.Remove(tmpStr);
            }
        }

        public frmServer()
        {
            InitializeComponent();
            LoadData();
            StartServer();
        }

        private void LoadData()
        {
            //Kết nối CSDL
            try
            {
                String ketnoi = CSDL.ketnoiCSDL();
                conn = new SqlConnection(ketnoi);
            }
            catch
            {
                MessageBox.Show("Kết nối thất bại");
            }
            btnSend.Enabled = false;            

            SqlDataAdapter adapter = new SqlDataAdapter("Select Username from tblUser", conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                lbOffline.Items.Add(table.Rows[i][0].ToString());
                lbUsers.Items.Add(new ImageListBoxItem(table.Rows[i][0].ToString(), 0, Color.Blue));
            }
            //Xoa tất cả các thông tin (nếu còn trong tblThongTin
            
            SqlCommand cmdStr = new SqlCommand("Delete tblThongTin", conn);
            cmdStr.CommandType = CommandType.Text;
            conn.Open();
            cmdStr.ExecuteNonQuery();
            conn.Close();
        }

        private void StartServer()
        {
            langnghe = new Thread(new ThreadStart(threadListen));
            langnghe.Start();
            btnSend.Enabled = true;
        }

        public void Somayonline()
        {
            if (count != 0)
            {
                lblCount.Text = "Có " + count + " Users đang Online";
            }
            else
            {
                lblCount.Text = "Không có User nào đang Online";
            }
            
        }

        //Tạo luồng lắng nghe cho server
        public void threadListen()
        {
            myTcpListener = new TcpListener(IPAddress.Any,Convert.ToInt16(port));
            myTcpListener.Start();
            while (true)
            {
                try
                {
                    myClient = myTcpListener.AcceptTcpClient();                    
                    int i;
                    for (i = 0; i < alclient.Count; i++)
                    {
                        if (((IPEndPoint)myClient.Client.RemoteEndPoint).Address.ToString()
                            == ((IPEndPoint)(((TcpClient)alclient[i]).Client.RemoteEndPoint)).Address.ToString())
                        {
                            break;
                        }
                    }
                    if (i == alclient.Count)
                    {
                        alclient.Add(myClient);
                    }                    
                    ClientHandler clientHandler = new ClientHandler(myClient, port, this);
                    thdHandler = new Thread(new ThreadStart(clientHandler.ReceiveData));
                    thdHandler.Start();
                }
                catch
                {
                    myTcpListener.Stop();
                }                
            }            
        }

        int d = 0;
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (d == 0)
            {
                ShowChatMessage("Server: " + txtMess.Text,0);
                GuiMessage();
            }
        }
        //Gửi Thông tin đến các client      
        public void GuiMessage()
        {
            String messStr = "Server@" + txtMess.Text;
            for (int i = 1; i <= alclient.Count; i++)
            {                
                myClient = (TcpClient)alclient[alclient.Count - i];
                byte[] thongbao = Encoding.UTF8.GetBytes(messStr);
                myClient.Client.Send(thongbao);     //Gởi Mess đến các User đang Online
                if (txtMess.Text == "Bye")
                {
                    d++;
                    btnSend.Enabled = false;
                    //Xóa các User đang Online trong tblThongTin
                    conn.Open();
                    string tmp = lbOnline.Items[i - 1].ToString();
                    SqlCommand cmdStr = new SqlCommand("Delete tblThongTin Where Username = '" + tmp + "'", conn);
                    cmdStr.CommandType = CommandType.Text;
                    cmdStr.ExecuteNonQuery();
                    conn.Close();
                    //Xóa danh sách các User đang Online ra khỏi lbOnline
                    RemoveClient(tmp);
                }
            }
            txtMess.Clear();
            txtMess.Focus();
        }
        //Sự kiện Click button Hibernate
        private void btnHibernate_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= alclient.Count; i++)
            {
                myClient = (TcpClient)alclient[alclient.Count - i];
                NetworkStream stream = new NetworkStream(myClient.Client);
                byte[] thongbao = Encoding.UTF8.GetBytes("Hibernate*@");
                myClient.Client.Send(thongbao);
            }
        }
        //Sự kiện Click button LogOff
        private void btnLogOff_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= alclient.Count; i++)
            {
                myClient = (TcpClient)alclient[alclient.Count - i];
                NetworkStream stream = new NetworkStream(myClient.Client);
                byte[] thongbao = Encoding.UTF8.GetBytes("LogOff*@");
                myClient.Client.Send(thongbao);
            }
        }
        //Đưa message lên Listbox
        public void ShowChatMessage(string s, int cIdex)
        {
            tmpStr = s;
            if (cIdex == 0)
            {
                getMultilineListBoxAddItem(lbMessage, tmpStr, Color.Red);
            }
            else
            {
                getMultilineListBoxAddItem(lbMessage, tmpStr, Color.Blue);
            }
            
        }
        //Gọi khi có 1 User đăng nhập
        //Vẫn Add các user vào lbOnline và Offline (dễ xữ lý)
        //Add vào imageListBox để tạo giao diện thân thiện
        public void AddClient(string s)
        {
            tmpStr = s;
            getListBoxAddItem(lbOnline);
            getListBoxRemoveItem(lbOffline);
            getImageListBoxChangeItem(lbUsers, s, true);
        }
        //Gọi khi 1 User Log out
        public void RemoveClient(string s)
        {
            tmpStr = s;
            getListBoxAddItem(lbOffline);
            getListBoxRemoveItem(lbOnline);
            getImageListBoxChangeItem(lbUsers, s, false);
        }
        //Sự kiện File -> Exit
        private void miExit_Click(object sender, EventArgs e)
        {
        	Application.Exit();
        }
        //Sự kiện nhấn Enter trong txtMess
        private void txtMess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (d == 0)
                {
                    ShowChatMessage("Server: " + txtMess.Text,0);
                    GuiMessage();
                }
            }
        }
        //Sự kiện Form Close
        private void frmServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (count != 0)
                {
                    myTcpListener.Stop();
                    myClient.Client.Close();
                    langnghe.Abort();
                    thdHandler.Abort();
                    myClient.Close();
                }
                else
                {
                    if (langnghe.IsAlive)
                    {
                    	langnghe.Abort();
                    }
                    if (myTcpListener != null)
                    {
                    	myTcpListener.Stop();
                    	thdHandler.Abort();
                    }                    
                }
            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message);
            }
        }
        public static int SearchImageListBox(ImageListBox imglb, String s)
        {
            for (int i = 0; i < imglb.Items.Count; i++)
            {
                if (s == ((ImageListBoxItem)imglb.Items[i]).Text)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}