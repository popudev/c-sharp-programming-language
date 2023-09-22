using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3
{
    internal abstract class MonHoc
    {
        private string mamh;
        private string tenmon;
        private int soTC;
        private string khoa;
        private float diem;

        public MonHoc()
        {

        }
        public MonHoc(string mamh, string tenmon, int soTC, string khoa, float diem)
        {
            this.mamh = mamh;
            this.tenmon = tenmon;
            this.soTC = soTC;
            this.khoa = khoa;
            this.diem = diem;
        }

        public string Mamh
        {
            get => mamh;
            set => mamh = value;
        }
        public string Tenmon
        {
            get => tenmon;
            set => tenmon = value;
        }
        public int SoTC
        {
            get => soTC;    
            set => soTC = value;
        }
        public string Khoa
        {
            get => khoa; 
            set => khoa = value;
        }
        public float Diem
        {
            get => diem;
            set => diem = value;
        }
        public abstract int TinhHocPhi();
        public abstract float TinhDiem();
    }
    
}

