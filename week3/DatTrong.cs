using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3
{
    internal class DatTrong : BatDongSan
    {
        public DatTrong(string maso,float chieudai, float chieurong):base(maso,chieudai,chieurong)
        {

        }
        public override float TinhGiaTri()
        {
            return Chieudai * Chieurong * 10000;  
        }
    }
}
