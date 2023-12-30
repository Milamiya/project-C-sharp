/*
 * sv thực hiện: Lê Hữu Hoàng Quân - 10258441
 * ngày bắt đầu đề tài : 26/10/2012
 * lần cuối update ngày: 02/11/2012
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DATA_Tier;

namespace BUS_Tier
{
    public class Casi_Baihat_BUS
    {
        CasiBaiHat_DATA objCasi_baihat = new CasiBaiHat_DATA();

        #region lấy dử liệu
        public DataTable getCasi_BaiHat_by_mabaihat(string mabaihat)
        {
            return objCasi_baihat.getCasi_BaiHat_by_mabaihat(mabaihat);
        }

        public DataTable getCasi_BaiHat_by_macasi(string macasi)
        {
            return objCasi_baihat.getCasi_BaiHat_by_macasi(macasi);
        }
        #endregion
    }
}
