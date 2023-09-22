using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3
{
    internal class MonDoAn : MonHoc
    {
        public static int hocphi = 2000000;
        private float diemGVHD;
        private float diemGVPB;

        public MonDoAn(string mamh,string tenmh, int soTC, string khoa, float diem,float diemGVHD, float diemGVPB)
            :base(mamh,tenmh,soTC,khoa,diem)
        {
            this.diemGVHD = diemGVHD;
            this.diemGVPB = diemGVPB;
        }

        public float DiemGVHD
        {
            get { return diemGVHD; }
            set { diemGVHD = value; }
        }
        public float DiemGVPB
        {
            get { return diemGVPB; }
            set { diemGVPB = value;}
        }
        public override int TinhHocPhi()
        {
            return hocphi;
        }

        public override float TinhDiem()
        {
            Diem = (DiemGVHD * 2 + DiemGVPB) / 3;
            return Diem;
        }
    }
}
