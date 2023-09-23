using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3
{
    internal class MonLyThuyet:MonHoc
    {
        public static int hocphi = 250000;
        private float diemTL;
        private float diemGK;
        private float diemCK;

        public MonLyThuyet(string mamh, string tenmon,int soTC,string khoa,float diem,float diemTL, float diemGK, float diemCK)
            :base(mamh,tenmon,soTC,khoa,diem)
        {
            this.diemTL = diemTL;
            this.diemGK = diemGK;
            this.diemCK = diemCK;
        }

        public float DiemTL
        {
           get => diemTL;
           set => diemTL = value;
        }
        public float DiemGK
        { 
           get => diemGK;
           set => diemGK = value;
        }
        public float DiemCK
        {
            get => diemCK;
            set => diemCK = value;
        }
        public override int TinhHocPhi()
        {
            return hocphi*SoTC;
        }

        public override float TinhDiem()
        {
            return (float)(DiemTL * 0.2 + DiemGK * 0.3 + DiemCK * 0.5);
        }
    }
}
