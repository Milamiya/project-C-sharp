using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using General;

namespace Server
{   
   
   
    class RemoteObject : MarshalByRefObject, IRemote
    {
        
        #region IRemote Members
        
        public bool SignIn(string Username)
        {
            if (Username != null && Username.Length > 0)
            {
                try
                {
                    ServerStartup.sf.AddUserToOnlineUserList(Username, null);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Thử lại với tên đăng nhập khác ^_^!");
                    return false;
                }
                if (ServerStartup.sf.i < 100)
                {

                    ServerStartup.sf.AddTextToDisplay(Username + " Đăng nhập");
                    ServerStartup.sf.Usenames[ServerStartup.sf.i] = Username;
                    ServerStartup.sf.i++;
                    return true;
                }
                else
                {
                    MessageBox.Show("Server đầy....!");
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public void SendMessageToServer(string Sender, string MsgCont)
        {
              for (int j = 0; j < ServerStartup.sf.i; j++)
                {

                    ((WrapperTransporterClass)(ServerStartup.sf.GetConnectionTo(ServerStartup.sf.Usenames[j]))).RunDelegateSendvaluePrivateTransporter(Sender, 7, 0, 0,0,MsgCont);
                }
        }// goi toan Server

        public void RegisterWrapperTransporterClass(string Sender, WrapperTransporterClass wtc)
        {
            ServerStartup.sf.ModifyUserOnlineListWrapper(Sender, wtc);
        }//tao theard


        public void SendValuePrivate(string Sender, string Receiver, int type, int x, int y, int who, String Msg)
        {
            if (type == 6)
            {
               
                for (int j = 0; j < ServerStartup.sf.i; j++)
                {

                    ((WrapperTransporterClass)(ServerStartup.sf.GetConnectionTo(Sender))).RunDelegateSendvaluePrivateTransporter(Sender, 6, x, y, who, ServerStartup.sf.Usenames[j]);
                }
            }
            else
            {

                try
                {
                    //((WrapperTransporterClass)(ServerStartup.sf.GetConnectionTo(Receiver))).SendChatPrivateTransporterDelegate(Sender, MsgCont);
                    ((WrapperTransporterClass)(ServerStartup.sf.GetConnectionTo(Receiver))).RunDelegateSendvaluePrivateTransporter(Sender, type, x, y, who, Msg);
                }
                catch (Exception e)
                {

                    try
                    {

                        if (type == 0)
                            ((WrapperTransporterClass)(ServerStartup.sf.GetConnectionTo(Sender))).RunDelegateSendvaluePrivateTransporter(null, 2, x, y, who, Receiver);
                        else
                            ((WrapperTransporterClass)(ServerStartup.sf.GetConnectionTo(Sender))).RunDelegateSendvaluePrivateTransporter(null, 5, x, y, who, Receiver);

                    }
                    catch (Exception e1) { }

                }
            }
        }// goi Data đến Peceiver

        #endregion

    }
}
