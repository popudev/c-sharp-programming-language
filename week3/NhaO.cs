using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3
{
    internal class NhaO:BatDongSan
    {
        private int solau;
        public NhaO(string maso, float chieudai,float chieurong, int solau):base(maso,chieudai,chieurong)
        {
            this.solau = solau; 
        }

        public int Solau
        {
            get => solau;
            set => solau = value;
        }
        public override float TinhGiaTri()
        {
            return Chieudai*Chieurong*10000 + Solau*100000;
        }
    }
}
