using System;

namespace QuanLyDaoTao.Utilities
{
    public static class ExceptionUtil
    {
        public static void Throw(string msg)
        {
            throw new Exception(msg);
        }

        public static void ThrowMsgBox(string msg)
        {
            MsgboxUtil.Error(msg);
        }
    }
}