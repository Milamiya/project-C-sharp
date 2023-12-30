using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyCafe.Business.EntitiesClass
{
    class EC_tb_Que
    {
        private string maque;
        private string tenque;

        public string MAQUE
        {
            get
            {
                return maque;
            }
            set
            {
                maque = value;
                if (maque == "")
                {
                    throw new Exception("Mã không được để trống");
                }
            }
        }
        public string TENQUE
        {
            get
            {
                return tenque;
            }
            set
            {
                tenque = value;
            }
        }
    }
}
