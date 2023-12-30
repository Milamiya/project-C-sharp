using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;


//That code is written by Suman Biswas, Calcutta, India (Email: sumanbiswas@aol.in,Website: sumanbiswas.xm.com).
//That code is running to transfer small file to client to server. by using and after doing modification any one 
//can able to make a large file transfer application in C#.Net. This is Client code.
namespace FTClientCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileDialog fDg = new OpenFileDialog();
            if (fDg.ShowDialog() == DialogResult.OK)
            {
                FTClientCode.SendFile(fDg.FileName);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = FTClientCode.curMsg;
        }
    }

    //FILE TRANSFER USING C#.NET SOCKET - CLIENT
    class FTClientCode
    {
        public static string curMsg = "Idle";
        public static void SendFile(string fileName)
        {
            try
            {
                IPAddress[] ipAddress = Dns.GetHostAddresses("localhost");
                IPEndPoint ipEnd = new IPEndPoint(ipAddress[0], 5656);
                Socket clientSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);


                string filePath = "";

                fileName = fileName.Replace("\\", "/");
                while (fileName.IndexOf("/") > -1)
                {
                    filePath += fileName.Substring(0, fileName.IndexOf("/") + 1);
                    fileName = fileName.Substring(fileName.IndexOf("/") + 1);
                }


                byte[] fileNameByte = Encoding.ASCII.GetBytes(fileName);
                if (fileNameByte.Length > 850 * 1024)
                {
                    curMsg = "File size is more than 850kb, please try with small file.";
                    return;
                }

                curMsg = "Buffering ...";
                byte[] fileData = File.ReadAllBytes(filePath + fileName);
                byte[] clientData = new byte[4 + fileNameByte.Length + fileData.Length];
                byte[] fileNameLen = BitConverter.GetBytes(fileNameByte.Length);

                fileNameLen.CopyTo(clientData, 0);
                fileNameByte.CopyTo(clientData, 4);
                fileData.CopyTo(clientData, 4 + fileNameByte.Length);

                curMsg = "Connection to server ...";
                clientSock.Connect(ipEnd);

                curMsg = "File sending...";
                clientSock.Send(clientData);

                curMsg = "Disconnecting...";
                clientSock.Close();
                curMsg = "File transferred.";
                
            }
            catch (Exception ex)
            {
                if(ex.Message=="No connection could be made because the target machine actively refused it")
                    curMsg="File Sending fail. Because server not running." ;
                else
                    curMsg = "File Sending fail." + ex.Message;
            }

        }
    }
}