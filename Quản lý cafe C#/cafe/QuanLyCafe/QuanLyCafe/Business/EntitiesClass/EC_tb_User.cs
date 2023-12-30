using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyCafe.Business.EntitiesClass
{
    class EC_tb_User
    {
        private string username;
        private string password;

        public string USERNAME
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
                if (username == "")
                {
                    throw new Exception("Tên Đăng Nhập Không Được Để Trống !");
                }
            }
        }
        public string PASSWORD
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
                if (password == "")
                {
                    throw new Exception("Mã Giáo Viên Nhập Không Được Để Trống !");
                }
            }
        }
    }
}
