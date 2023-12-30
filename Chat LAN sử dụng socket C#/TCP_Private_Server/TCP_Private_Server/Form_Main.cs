using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
////////////////////////////
using System.Collections;
using System.Threading;
using System.Net.Sockets;

namespace TCP_Private_Server
{
    public partial class Form_Main : Form
    {
        const int PORT_NUM = 2010;
        private Hashtable clients = new Hashtable();
        private TcpListener listener;
        private Thread listenerThread;
        public Form_Main()
        {
            //This call is required by the Windows Form Designer.
            InitializeComponent();
            //Add any initialization after the InitializeComponent() call
            // So that we only need to set the title of the application once,
            // we use the AssemblyInfo class (defined in the AssemblyInfo.cs file)
            // to read the AssemblyTitle attribute.
            AssemblyInfo ainfo = new AssemblyInfo();
            this.Text = ainfo.Title;
            this.aboutToolStripMenuItem.Text = string.Format("&About {0} ...", ainfo.Title);
        }

        // Start the background listener thread.
        private void Form_Server_Load(object sender, EventArgs e)
        {
            listenerThread = new Thread(new ThreadStart(DoListen));
            listenerThread.Start();
            UpdateStatus("Sang sang ket noi");
        }

        /*
         This subroutine is used a background listener thread to allow reading incoming
         messages without lagging the user interface.
         */
        private void DoListen()
        {
            try
            {
                // Listen for new connections.
                listener = new TcpListener(System.Net.IPAddress.Any, PORT_NUM);
                listener.Start();
                do
                {
                    // Create a new user connection using TcpClient returned by
                    // TcpListener.AcceptTcpClient()
                    UserConnection client = new UserConnection(listener.AcceptTcpClient());
                    // Create an event handler to allow the UserConnection to communicate
                    // with the window.
                    client.LineReceived += new LineReceive(OnLineReceived);
                    //AddHandler client.LineReceived, AddressOf OnLineReceived;
                    UpdateStatus("Mot nguoi dang ket noi. Xin doi trong vai giay.");
                } while (true);
            }
            catch
            {
            }
        }

        /* 
         This subroutine adds line to the Status listbox
         */
        private void UpdateStatus(string statusMessage)
        {
            listBox_Status.Items.Add(statusMessage);
        }

        /*
         This is the event handler for the UserConnection when it receives a full line.
        Parse the cammand and parameters and take appropriate action.
         */
        private void OnLineReceived(UserConnection sender, string data)
        {
            string[] dataArray;
            // Message parts are divided by "|"  Break the string into an array accordingly.
            dataArray = data.Split((char)124);

            // dataArray(0) is the command.
            switch (dataArray[0])
            {
                case "CONNECT":
                    ConnectUser(dataArray[1], sender);
                    break;
                case "CHAT":
                    SendChat(dataArray[1], sender);
                    break;
                case "DISCONNECT":
                    DisconnectUser(sender);
                    break;
                case "REQUESTUSERS":
                    ListUsers(sender);
                    break;
                default:
                    UpdateStatus("Unknown message:" + data);
                    break;
            }
        }

        /* This subroutine checks to see if username already exists in the clients 
         Hashtable.  if it does, send a REFUSE message, otherwise confirm with a JOIN.
         */
        private void ConnectUser(string userName, UserConnection sender)
        {
            if (clients.Contains(userName))
            {
                ReplyToSender("REFUSE", sender);
            }
            else
            {
                sender.Name = userName;
                UpdateStatus(userName + " vua dang nhap.");
                clients.Add(userName, sender);
                // Send a JOIN to sender, and notify all other clients that sender joined
                ReplyToSender("JOIN", sender);
                SendToClients("CHAT|" + "Waiting..." + sender.Name + " vua dang nhap.", sender);
            }
        }
        // This subroutine sends a response to the sender.
        private void ReplyToSender(string strMessage, UserConnection sender)
        {
            sender.SendData(strMessage);
        }
        // This subroutine sends a message to all attached clients except the sender.
        private void SendToClients(string strMessage, UserConnection sender)
        {
            UserConnection client;
            // All entries in the clients Hashtable are UserConnection so it is possible
            // to assign it safely.
            foreach (DictionaryEntry entry in clients)
            {
                client = (UserConnection)entry.Value;
                // Exclude the sender.
                if (client.Name != sender.Name)
                {
                    client.SendData(strMessage);
                }
            }
        }

       /* 
         Send a chat message to all clients except sender.
       */
        private void SendChat(string message, UserConnection sender)
        {
            UpdateStatus(sender.Name + ": " + message);
            SendToClients("CHAT|" + sender.Name + ": " + message, sender);
        }

       /* 
          This subroutine notifies other clients that sender left the chat, and removes
         the name from the clients Hashtable.
       */
        private void DisconnectUser(UserConnection sender)
        {
            UpdateStatus("Waiting..." + sender.Name + " da thoat ra.");
            SendToClients("CHAT|" + "Waiting..." + sender.Name + " da thoat ra.", sender);
            clients.Remove(sender.Name);
        }

        /* 
         Concatenate all the client names and send them to the user who requested user list
         */
        private void ListUsers(UserConnection sender)
        {
            UserConnection client;
            string strUserList;
            UpdateStatus("Dang gui toi " + sender.Name + " danh sach nhung nguoi dang online.");
            strUserList = "LISTUSERS";
            // All entries in the clients Hashtable are UserConnection so it is possible
            // to assign it safely.

            foreach (DictionaryEntry entry in clients)
            {
                client = (UserConnection)entry.Value;
                strUserList = strUserList + "|" + client.Name;
            }

            // Send the list to the sender.
            ReplyToSender(strUserList, sender);
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            if (textBox_Send.Text != "")
            {
                UpdateStatus("Server: " + textBox_Send.Text);
                Send("BROAD|" + textBox_Send.Text);
                textBox_Send.Text = string.Empty;
            }
        }
        // This subroutine sends a message to all attached clients
        private void Send(string strMessage)
        {
            UserConnection client;
            // All entries in the clients Hashtable are UserConnection so it is possible
            // to assign it safely.
            foreach (DictionaryEntry entry in clients)
            {
                client = (UserConnection)entry.Value;
                client.SendData(strMessage);
            }
        }

        // This code will close the form.
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Close the current form
            this.Close();
        }

        // This code simply shows the About form.
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open the About form in Dialog Mode
            Form_About frm = new Form_About();
            frm.ShowDialog(this);
            frm.Dispose();
        }

        // When the window closes, stop the listener.
        private void Form_Server_Closing(object sender, System.ComponentModel.CancelEventArgs e) //base.Closing;
        {
            listener.Stop();
        }
    }
}