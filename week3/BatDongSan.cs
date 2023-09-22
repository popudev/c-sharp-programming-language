using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace week3
{
    internal abstract class BatDongSan
    {
        private string maso;
        private float chieudai;
        private float chieurong;

        public BatDongSan(string maso, float chieudai, float chieurong)
        {
             this.maso = maso;
             this.chieudai = chieudai;
             this.chieurong = chieurong;
        }
        
        public string Maso
        {
            get => maso;
            set => maso = value;
        }
        public float Chieudai
        {
            get => chieudai;
            set => chieudai = value;
        }
        public float Chieurong
        {
            get => chieurong;
            set => chieurong = value;
        }
        public abstract float TinhGiaTri();
    }
}
