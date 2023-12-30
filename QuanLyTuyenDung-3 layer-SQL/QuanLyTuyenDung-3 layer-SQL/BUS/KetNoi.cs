using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class KetNoi
    {
        public static Boolean thucnn()
        {
            return DataServices.testketnoi();
        }
    }
}
