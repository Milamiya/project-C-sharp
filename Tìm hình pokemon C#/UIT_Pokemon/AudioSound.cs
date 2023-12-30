using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
namespace UIT_Pokemon
{
    class AudioSound
    {
        
       /* private string _command;
        private bool isOpen;
        [DllImport("winmm.dll")]
        bool OK = false;
        int lng = 0;
        private static extern long mciSendString(string strCommand, StringBuilder strReturn, int iReturnLength, IntPtr hwndCallback);
        public void Close()
        {
            _command = "close MediaFile";
            mciSendString(_command, null, 0, IntPtr.Zero);
            isOpen = false;
        }

        public void Open(string sFileName)
        {
            _command = "open \"" + sFileName + "\" type mpegvideo alias MediaFile";
            mciSendString(_command, null, 0, IntPtr.Zero);
            isOpen = true;
        }
        private void CalculateLength()
        {
            StringBuilder str = new StringBuilder(128);
            mciSendString("status MediaFile length", str, 128, IntPtr.Zero);
           // Lng = Convert.ToUInt64(str.ToString());
        }

        public void Play(bool loop)
        {
            if (isOpen)
            {
                _command = "play MediaFile";
                if (loop)
                    _command += " REPEAT";
                mciSendString(_command, null, 0, IntPtr.Zero);
            }
        }
        public void uu(bool loop)
        {
            if (isOpen)
            {
                _command = "stop MediaFile";
                mciSendString(_command, null, 0, IntPtr.Zero);
            }
        } */

    }
}
