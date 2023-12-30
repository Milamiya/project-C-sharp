using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyDaoTao.DataAccess;

namespace QuanLyDaoTao.DTO
{
    public class rptThanhToanGioDayDTO
    {
        private IEnumerable<sp_ThongTinThanhToanResult> nguonDuLieu;

        public IEnumerable<sp_ThongTinThanhToanResult> NguonDuLieu
        {
            get { return nguonDuLieu; }
            set { nguonDuLieu = value; }
        }

        private string maGV;

        public string MaGV
        {
            get { return maGV; }
            set { maGV = value; }
        }

        private string tenGV;

        public string TenGV
        {
          get { return tenGV; }
          set { tenGV = value; }
        }

        private string trinhDo;

        public string TrinhDo
        {
            get { return trinhDo; }
            set { trinhDo = value; }
        }

        private int thucDay;

        public int ThucDay
        {
            get { return thucDay; }
            set { thucDay = value; }
        }

        private int thuLao;

        public int ThuLao
        {
            get { return thuLao; }
            set { thuLao = value; }
        }

        private DateTime ngayBD;

        public DateTime NgayBD
        {
            get { return ngayBD; }
            set { ngayBD = value; }
        }

        private DateTime ngayKT;

        public DateTime NgayKT
        {
            get { return ngayKT; }
            set { ngayKT = value; }
        }

        public rptThanhToanGioDayDTO() { }
    }
}
