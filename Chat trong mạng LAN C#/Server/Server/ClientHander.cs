using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Server
{
    class ClientHandler
    {
        private string tmpStr;
        private string Username;
        static String[] rm = new String[100];
        static int biendem = 0;
        private SqlConnection conn;
        private string myPort;
        private TcpClient myClient;
        private frmServer mainFrm = null;

        //Hàm khởi tạo 3 tham số
        public ClientHandler(TcpClient client, string port, frmServer MainFrm)
        {
            myClient = client;
            myPort = port;
            String ketnoi = CSDL.ketnoiCSDL();
            conn = new SqlConnection(ketnoi);
            mainFrm = MainFrm;
        }
        //Hàm nhận dữ liệu từ Server
        public void ReceiveData()
        {
            try
            {
                NetworkStream stream = new NetworkStream(myClient.Client);
                byte[] data = new byte[1024];
                //byte[] buffer = new byte[102400];
                int receiv = 0;
                String Stringdata;
                while (true)
                {
                    receiv = myClient.Client.Receive(data);
                    Stringdata = Encoding.UTF8.GetString(data, 0, receiv).TrimEnd();
                    String[] catchuoi = Stringdata.Split('$');

                    if (catchuoi[0] == "Bye")
                    {
                        biendem++;
                        tmpStr = catchuoi[1];
                        //Thông báo cho các User trong Group biết là User này mới thoát
                        SignOutGroup(); //Thông báo User này rời khỏi Group
                        DestroyGroup(); //Thông báo xóa các Group mà User này đã tạo
                        //Thông báo cho các User trong Friend list biết là User mới thoát
                        SendUserState(false);
                        break;  //Thoát khỏi vòng lặp
                    }
                    //Các thông báo liên quan đến đăng nhập
                    #region Xử lý đăng nhập
                    if (catchuoi[0] == "Dangnhap")
                    {
                        int dn = Dangnhap(catchuoi[1], catchuoi[2]);
                        if (dn == 0)
                        {
                            String IP = ((IPEndPoint)myClient.Client.RemoteEndPoint).Address.ToString();
                            conn.Open();
                            SqlCommand cmd = new SqlCommand("Insert Into tblThongTin(Username,TinhTrang) VALUES ('" +
                                catchuoi[1] + "','" + 1 + "')", conn);
                            cmd.CommandType = CommandType.Text;
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            mainFrm.count++;
                            mainFrm.Somayonline();
                            Username = catchuoi[1].ToString();
                            tmpStr = catchuoi[1].ToString();
                            mainFrm.AddClient(tmpStr);
                            String strMess = "Dangnhap@TC@";
                            //Gởi cho User chuổi báo đang nhập thành công
                            //cùng với danh sách các Friend đang Online và Offline cho User
                            strMess += SendFriendList(Username);
                            //Gọi hàm gởi cho User các tin nhắn Offline nếu có
                            strMess += SendOfflineMessage();
                            byte[] message = Encoding.UTF8.GetBytes(strMess);
                            myClient.Client.Send(message);
                            //Báo cho các User trong Friend list là User này mới đang nhập
                            SendUserState(true);                            
                            Stringdata = "";
                        }
                        else
                        {
                            //Gởi cho User chuổi báo đăng nhập thất bại
                            String mess = "Dangnhap@TB@";
                            //dn = 1: User đã đăng nhập. dn!= 1: Sai Username hoặc Password
                            mess += dn.ToString();
                            byte[] message = Encoding.UTF8.GetBytes(mess);
                            myClient.Client.Send(message);
                        }
                    }
                    #endregion
                    //Hiển thị thông tin chat
                    #region Xử lý Chat Message
                    if (catchuoi[0] == "Chat")
                    {
                        if (catchuoi[2] == "Server")
                        {
                            tmpStr = catchuoi[1].ToString() + ": " + catchuoi[3].ToString();
                            mainFrm.ShowChatMessage(tmpStr,1);
                            Stringdata = "";
                        }
                        if (catchuoi[2] == "With")
                        {
                            String fname = catchuoi[3].ToString();
                            String strMess = "Chat@With@" + fname;
                            //Kiểm tra User fname có tồn tại không
                            if (CheckUserExist(fname))
                            {
                                strMess += "@1";
                            }
                            else
                            {
                                strMess += "@0";
                            }
                            byte[] message = Encoding.UTF8.GetBytes(strMess);
                            myClient.Client.Send(message);
                        }
                        if (catchuoi[2] == "Private")
                        {
                            String fname = catchuoi[3];
                            int i = CheckUserOnline(fname);
                            //Khi fname đang Online
                            if (i != -1)
                            {
                                String strMess = "Chat@Private@" + catchuoi[1] + "@" + catchuoi[4];
                                TcpClient client = (TcpClient)mainFrm.alclient[i];
                                byte[] message = Encoding.UTF8.GetBytes(strMess);
                                client.Client.Send(message);
                            }
                            //Khi fname đang Offline
                            else
                            {
                                conn.Open();
                                string sqlStr = "Insert Into tblOfflineMessage Values('" + fname + "','" +
                                    catchuoi[1] + "',N'" + catchuoi[4] + "','" +
                                    DateTime.Now.ToString() + "')";
                                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                                cmd.CommandType = CommandType.Text;
                                cmd.ExecuteNonQuery();
                                conn.Close();
                            }
                        }
                    }
                    #endregion
                    //Các thông báo liên quan đến Add và Delete friend list
                    #region Xử lý thông tin Friend list
                    if (catchuoi[0] == "Friend")
                    {
                        String strMess;
                        if (catchuoi[2] == "Add")
                        {
                            strMess = "Friend@" + catchuoi[1] + "@Add@";
                            String fname = catchuoi[1].ToString();
                            if (!CheckUserExist(fname))
                            {
                                strMess += "-1@";   //Báo cho User là Friend Name không tồn tại
                            }
                            else
                            {
                                if (!CheckList(Username, fname))
                                {
                                    //Thêm Friend vào tblFriendList
                                    conn.Open();
                                    string sqlStr = "Insert Into tblFriendList(Username,Friend) Values('" + Username + "','" + fname + "')";
                                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                                    cmd.CommandType = CommandType.Text;
                                    cmd.ExecuteNonQuery();
                                    conn.Close();
                                    if (CheckUserOnline(fname) != -1)
                                    {
                                        strMess += "1@";    //Báo cho User biết là Friend mới Add đang Online
                                    }
                                    else
                                    {
                                        strMess += "2@";    //Báo cho User biết là Friend mới Add đang Offline
                                    }
                                }
                                else
                                {
                                    strMess += "0@";
                                }
                            }
                        }
                        else
                        {
                            strMess = "Friend@" + catchuoi[1] + "@Del@";
                            String fname = catchuoi[1].ToString();
                            if (CheckList(Username, fname))
                            {
                                conn.Open();
                                string sqlStr = "Delete tblFriendList Where Username = '" + Username + "' and Friend ='" +
                                    fname + "'";
                                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                                cmd.CommandType = CommandType.Text;
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                if (CheckUserOnline(fname) != -1)
                                {
                                    strMess += "1@";    //Báo cho User biết là Friend mới Del đang Online
                                }
                                else
                                {
                                    strMess += "2@";    //Báo cho User biết là Friend mới Del đang Offline
                                }
                            }
                            else
                            {
                                strMess += "0@";    //Báo cho Uset biết là tên nhập vảo không có trang Friend List
                            }
                        }
                        byte[] message = Encoding.UTF8.GetBytes(strMess);
                        myClient.Client.Send(message);
                    }
                    #endregion
                    //Các thông báo liên quan đến Group
                    #region Xử lý Group Chat
                    if (catchuoi[0] == "Group")
                    {
                    	if (catchuoi[1] == "Invite")
                    	{
                    		SendGroupInvite(catchuoi[2], catchuoi[3], catchuoi[4]);
                    	}
                    	if (catchuoi[1] == "Allow")
                    	{
                    		//Gởi thông báo thêm đến các Friend có trong Group và User trưởng Group
                            	SendUsernameToGroup(catchuoi[2], catchuoi[3], false);
                    		//Gởi các Friend trong List nếu có cho User
                            	SendGroupUser(catchuoi[2], catchuoi[3]);
                    		//Thêm User này vào tblGroup
	                            conn.Open();
	                            SqlCommand cmd = new SqlCommand("Insert Into tblGroup Values('" + catchuoi[2] +
	                                "','" + Username + "','" + catchuoi[3] + "')", conn);
	                            cmd.CommandType = CommandType.Text;
	                            cmd.ExecuteNonQuery();
	                            conn.Close();
                    	}
                    	//Gởi thông tin chat cho các User
                    	if (catchuoi[1] == "Chat")
                    	{
                    		String fname = catchuoi[2];
                    		String groupName = catchuoi[3];
                    		String groupMess = catchuoi[4];
                    		//Gởi thông tin Chat đến các User trong Group
                    		SendMessToGroup(groupMess, groupName, fname);
                    	}
                    }
                    #endregion
                }
                conn.Open();
                SqlCommand cmdStr = new SqlCommand("Delete tblThongTin Where Username = '" + tmpStr + "'", conn);
                cmdStr.CommandType = CommandType.Text;
                cmdStr.ExecuteNonQuery();
                conn.Close();
                mainFrm.count--;
                rm[biendem] = tmpStr;
                int index = CheckUserOnline(Username);
                mainFrm.alclient.RemoveAt(index);
                mainFrm.RemoveClient(tmpStr);
                mainFrm.Somayonline();
                return;
            }
            catch
            {
                 if (myClient.Client.Connected)
                 {
                 	myClient.Client.Close();
                 }
            }
        }
        //Kiểm tra chuổi đăng nhập của Client
        public int Dangnhap(String ten, String matkhau)
        {
            conn.Open();
            SqlDataAdapter myAdapter = new SqlDataAdapter("Select Fullname From tblUser Where Username ='"
                + ten + "' and Password = '" + matkhau + "'", conn);
            DataTable myTable = new DataTable();
            myAdapter.Fill(myTable);
            SqlDataAdapter myTTAdapter = new SqlDataAdapter("Select TinhTrang From tblThongTin where Username ='"
                + ten + "'", conn);
            DataTable myTTTable = new DataTable();
            myTTAdapter.Fill(myTTTable);
            conn.Close();
            if (myTable.Rows.Count > 0)
            {
                if (myTTTable.Rows.Count > 0)
                {
                    return Convert.ToInt16(myTTTable.Rows[0][0].ToString());
                }
                return 0;
            }
            else
            {
                return -1;
            }
        }
        //Kiểm tra User có tồn tại không
        private bool CheckUserExist(string user)
        {
            conn.Open();
            String sqlStr = "Select ID From tblUser Where Username = '" + user + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            if (dt.Rows.Count == 1)
            {
                return true;
            }
            return false;
        }
        //Kiểm tra User có đang Online không
        private int CheckUserOnline(string user)
        {
            int count = mainFrm.lbOnline.Items.Count;
            for (int i = 0; i < count; i++)
            {
                String name = mainFrm.lbOnline.Items[i].ToString();
                if (name == user)
                {
                    return i;
                }
            }
            return -1;
        }
        //Kiểm tra User2 đã có trong Friend list của User chưa
        private bool CheckList(string User1, string User2)
        {
            conn.Open();
            String sqlStr = "Select ID From tblFriendList Where Username = '" + User1 +
                "' and Friend = '" + User2 + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            if (dt.Rows.Count == 1)
            {
                return true;
            }
            return false;
        }
        //Gởi danh sách các Friend đang Online và Offline cho User
        private string SendFriendList(string user)
        {
            conn.Open();
            String sqlStr = "Select Friend From tblFriendList Where Username = '" +
                user + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            int row = dt.Rows.Count;
            String strMess;
            strMess = "Friend@";
            if (row == 0)
            {
                conn.Close();
            }
            else
            {
                //Thêm vào chuổi các Friend đang Online
                int count = mainFrm.lbOnline.Items.Count;
                for (int i = 0; i < count; i++)
                {
                    string fname = mainFrm.lbOnline.Items[i].ToString();
                    sqlStr = "Select ID From tblFriendList Where Username = '" +
                        Username + "' and Friend = '" + fname + "'";
                    adapter = new SqlDataAdapter(sqlStr, conn);
                    DataTable tbl = new DataTable();
                    adapter.Fill(tbl);
                    if (tbl.Rows.Count == 1)
                    {
                        strMess += fname + "_";
                    }
                }
                //Thêm vào chuổi các Friend Offline
                strMess += "^";
                count = mainFrm.lbOffline.Items.Count;
                for (int i = 0; i < count; i++)
                {
                    string fname = mainFrm.lbOffline.Items[i].ToString();
                    sqlStr = "Select ID From tblFriendList Where Username = '" +
                        Username + "' and Friend = '" + fname + "'";
                    adapter = new SqlDataAdapter(sqlStr, conn);
                    DataTable tbl = new DataTable();
                    adapter.Fill(tbl);
                    if (tbl.Rows.Count == 1)
                    {
                        strMess += fname + "_";
                    }
                }
                conn.Close();
            }
            return strMess;
        }
        //Báo cho các Friend biết là User này mới đăng nhập hoặc mới thoát ra
        private void SendUserState(bool state)
        {
            conn.Open();
            int count = mainFrm.lbOnline.Items.Count;
            for (int i = 0; i < count; i++)
            {
                string fname = mainFrm.lbOnline.Items[i].ToString();
                String sqlStr = "Select ID From tblFriendList Where Username = '" +
                    fname + "' and Friend = '" + Username + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable tbl = new DataTable();
                adapter.Fill(tbl);
                if (tbl.Rows.Count == 1)
                {

                    String strMess = "Friend@" + Username;
                    if (state)
                    {
                        strMess += "@In"; //User này mới đăng nhập vào
                    }
                    else
                    {
                        strMess += "@Out";  //User này mới thoát ra
                    }
                    TcpClient client = (TcpClient)mainFrm.alclient[i];
                    byte[] message = Encoding.UTF8.GetBytes(strMess);
                    client.Client.Send(message);
                }
            }
            conn.Close();
        }
        //Gởi cho User mới đăng nhập tin nhắn Offline nếu có
        private string SendOfflineMessage()
        {
            conn.Open();
            String sqlStr = "Select Sender,SendTime,Message From tblOfflineMessage Where Username = '" +
                    Username + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
            DataTable tbl = new DataTable();
            adapter.Fill(tbl);
            String strMess = "@Offline@";
            for (int i = 0; i < tbl.Rows.Count; i++ )
            {
                strMess += tbl.Rows[i][0].ToString().Trim() + "@" +
                    tbl.Rows[i][1].ToString().Trim() + "@" + tbl.Rows[i][2].ToString().Trim()+"@";                
            }
            sqlStr = "Delete from tblOfflineMessage Where Username = '" + Username + "'";
            SqlCommand cmd = new SqlCommand(sqlStr, conn);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            conn.Close();
            return strMess;
        }
        //Gởi thông báo Group Chat đến các User được mời đang Online
        private void SendGroupInvite(String fname, String mess, String groupname)
        {
        	String[] Users = fname.Split('-');
        	for (int i = 0; i < Users.Length -1; i++)
        	{
                String user = Users[i];
                int index = CheckUserOnline(user);
        	    if (index != -1)
        	    {
                    String strMess = "Group@Invite@" + Username + "@" + mess + "@" + groupname;
                    TcpClient client = (TcpClient)mainFrm.alclient[index];
                    byte[] message = Encoding.UTF8.GetBytes(strMess);
                    client.Client.Send(message);
        	    }        	    	
        	}
        }
        //Gởi thông báo thêm  hoặc xóa đến các Friend có trong Group và User trưởng Group
        private void SendUsernameToGroup(String leader, String groupName, bool removeUser)
        {
        	//Gởi thông báo xóa đến các User trong Group và User trưởng nhóm
        	String strMess;
        	if (removeUser)
        	{
        		strMess = "Group@Remove@" + Username + "@" + groupName;
        	}
            //Gởi thông báo thêm đến các User trong Group và User trưởng nhóm
        	else
        	{
        		strMess = "Group@Add@" + Username + "@" + groupName;
        	}
            conn.Open();
        	String sqlStr = "Select Friend From tblGroup Where Leader = '" +
                leader + "' and GroupName = '" + groupName + "' and Friend != '" + Username + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
            DataTable tbl = new DataTable();
            adapter.Fill(tbl);
             for (int i = 0; i < tbl.Rows.Count; i++)
             {
             	String fname = tbl.Rows[i][0].ToString().Trim();
             	int index = CheckUserOnline(fname);
             	TcpClient client = (TcpClient)mainFrm.alclient[i];
             	byte[] message = Encoding.UTF8.GetBytes(strMess);
             	client.Client.Send(message);
                }
            //Gởi thông báo cho trưởng Group
            int leaderInder = CheckUserOnline(leader);
            TcpClient clientLeader = (TcpClient)mainFrm.alclient[leaderInder];
            byte[] leaderMessage = Encoding.UTF8.GetBytes(strMess);
            clientLeader.Client.Send(leaderMessage);
            conn.Close();
        }
        //Gởi các Friend trong Group cho User
        private void SendGroupUser(String leader, String groupName)
        {
            conn.Open();
            String strMess = "Group@Add@";
            String sqlStr = "Select Friend From tblGroup Where Leader = '" +
                leader + "' and GroupName = '" + groupName + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
            DataTable tbl = new DataTable();
            adapter.Fill(tbl);
            if (tbl.Rows.Count != 0)
            {
                for (int i = 0; i < tbl.Rows.Count; i++ )
                {
                    strMess += tbl.Rows[i][0].ToString().Trim() + "-";
                }                
            }
            strMess += "@" + groupName;
            byte[] message = Encoding.UTF8.GetBytes(strMess);
            myClient.Client.Send(message);
            conn.Close();
        }
        //Gởi Mess cho các User trong Group
        private void SendMessToGroup(String groupMess, String groupName, String fname)
        {
        	String[] Users = fname.Split('-');
        	for (int i = 0; i < Users.Length; i++)
        	{
        		String user = Users[i];
        		int index = CheckUserOnline(user);
        		if (index != -1)
        		{
        			String strMess = "Group@Chat@" + Username + "@" + groupName + "@" + groupMess;
        			TcpClient client = (TcpClient)mainFrm.alclient[index];
                    	byte[] message = Encoding.UTF8.GetBytes(strMess);
                    	client.Client.Send(message);
        		}        		
        	}
        }
        //Thông báo User đã thoát khỏi Group (khi User là thành viên)
        private void SignOutGroup()
        {
            conn.Open();
            String sqlStr = "Select Leader, GroupName From tblGroup Where Friend = '" +
                Username + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            conn.Close();
            for (int i = 0; i < tb.Rows.Count; i++)
            {
            	SendUsernameToGroup(tb.Rows[i][0].ToString().Trim(),
                    tb.Rows[i][1].ToString().Trim(), true);
            	conn.Open();
            	sqlStr = "Delete tblGroup Where Friend = '" + Username + "'";
            	SqlCommand cmd = new SqlCommand(sqlStr,conn);
            	cmd.CommandType = CommandType.Text;
            	cmd.ExecuteNonQuery();
            	conn.Close();
            }
        }
        //Thông báo các User khác là trưởng nhóm đã giải tán nhom
        private void DestroyGroup()
        {
            conn.Open();
            String sqlStr = "Select GroupName, Friend From tblGroup Where Leader = '" +
                Username + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            conn.Close();
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                String fname = tb.Rows[i][1].ToString().Trim();
                int index = CheckUserOnline(fname);
                String strMess = "Group@Destroy@" + Username + "@" + tb.Rows[i][0].ToString().Trim();
                TcpClient client = (TcpClient)mainFrm.alclient[index];
                byte[] message = Encoding.UTF8.GetBytes(strMess);
                client.Client.Send(message);
                conn.Open();
                sqlStr = "Delete tblGroup Where Leader = '" + Username + "'";
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
;