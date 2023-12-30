using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace General
{
    public class WrapperTransporterClass : MarshalByRefObject
    {
       
        public DelegateSendvaluePrivateTransporter SendvaluePrivateTransporterDelegate;
       
       
        public void RunDelegateSendvaluePrivateTransporter(String Sender,int Type, int x, int y, int who,String MSg)
        {
            SendvaluePrivateTransporterDelegate(Sender,Type, x, y, who,MSg);
        }
       
    }
}
