using System;
using System.Collections.Generic;
using System.Text;

//Hoàn chỉnh
namespace QLHocSinhTHPT.Bussiness
{
    public class QuyDinhInfo
    {
        public QuyDinhInfo()
        {

        }

        private int m_TuoiCanDuoi;
        public int TuoiCanDuoi
        {
            get { return m_TuoiCanDuoi; }
            set { m_TuoiCanDuoi = value; }
        }

        private int m_TuoiCanTren;
        public int TuoiCanTren
        {
            get { return m_TuoiCanTren; }
            set { m_TuoiCanTren = value; }
        }

        private int m_SiSoCanDuoi;
        public int SiSoCanDuoi
        {
            get { return m_SiSoCanDuoi; }
            set { m_SiSoCanDuoi = value; }
        }

        private int m_SiSoCanTren;
        public int SiSoCanTren
        {
            get { return m_SiSoCanTren; }
            set { m_SiSoCanTren = value; }
        }

        private int m_ThangDiem;
        public int ThangDiem
        {
            get { return m_ThangDiem; }
            set { m_ThangDiem = value; }
        }

        private String m_TenTruong;
        public String TenTruong
        {
            get { return m_TenTruong; }
            set { m_TenTruong = value; }
        }

        private String m_DiaChiTruong;
        public String DiaChiTruong
        {
            get { return m_DiaChiTruong; }
            set { m_DiaChiTruong = value; }
        }
    }
}
