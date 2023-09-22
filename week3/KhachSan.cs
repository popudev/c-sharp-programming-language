using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3
{
    internal class KhachSan:BatDongSan,phuongthuc
    {
        private int sosao;
        public KhachSan(string maso, float chieudai,float chieurong, int sosao):base(maso,chieudai,chieurong) 
        {
            this.sosao = sosao;
        }
        public int Sosao
        {
            get => sosao;
            set => sosao = value;
        }
        public override float TinhGiaTri()
        {
            return 100000 + Sosao * 50000 + Chieurong*TinhPhi();
        }
        public float TinhPhi()
        {
            return Chieurong * 5000;
        }
    }
}
