using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyVayVonChoNHCSXH.BusinessObject
{
   public class HTDamBao
    {
       public HTDamBao() { }

       public HTDamBao(String mahtdambao)
       {
           m_MaHTDamBao = mahtdambao;
       }
       public HTDamBao(String mahtdambao, String tendambao)
       {
           m_MaHTDamBao = mahtdambao;
           m_TenHTDamBao = tenhtdambao;
       }

       private String m_MaHTDamBao;

       public String mahtdambao
       {
           get { return m_MaHTDamBao; }
           set { m_MaHTDamBao = value; }
       }

       private String m_TenHTDamBao;
       public String tenhtdambao
       {
           get { return m_TenHTDamBao; }
           set { m_TenHTDamBao = value; }
       }
    }
}
