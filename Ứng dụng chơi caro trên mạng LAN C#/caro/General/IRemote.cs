using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace General
{
    public interface IRemote
    {
        bool SignIn(String Username);
        void RegisterWrapperTransporterClass(String Sender, WrapperTransporterClass wtc);
        void SendMessageToServer(String Sender, String MsgCont);
        void SendValuePrivate(String Sender, String Receiver, int type,int x, int y, int who,String msg);
    }
}
