using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3
{
    internal class BietThu:BatDongSan,phuongthuc
    {
        public BietThu(string maso, float chieudai, float chieurong):base(maso,chieudai,chieurong)
        {

        }
        public override float TinhGiaTri()
        {
            return Chieudai * Chieurong * 400000 + TinhPhi();
        }
        public float TinhPhi()
        {
            return Chieudai * Chieurong * 1000; 
        }
    }
}
