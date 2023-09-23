using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace week3
{
    internal class MonThucHanh:MonHoc
    {
        public static int hocphi = 350000;
        private float diemKT1;
        private float diemKT2;
        private float diemKT3;
        private float diemKT4;
        
        public MonThucHanh(string mamh,string tenmon, int soTC,string khoa,float diem,float diemKT1,float diemKT2,float diemKT3,float diemKT4)
            :base(mamh,tenmon,soTC,khoa,diem)
        {
            this.diemKT1 = diemKT1;
            this.diemKT2 = diemKT2;
            this.diemKT3 = diemKT3;
            this.diemKT4 = diemKT4;
        }
        
        public float DiemKT1
        {
            get => diemKT1;
            set => diemKT1 = value;
        }
        public float DiemKT2
        {
            get => diemKT2;
            set => diemKT2 = value;
        }
        public float DiemKT3
        {
            get => diemKT3;
            set => diemKT3 = value;
        }
        public float DiemKT4
        {
            get => diemKT4;
            set => diemKT4 = value;
        }
        public override int TinhHocPhi()
        {
            return hocphi*SoTC+1000000;
        }

        public override float TinhDiem()
        {
            return (DiemKT1+DiemKT2+DiemKT3+DiemKT4)/4;
        }
    }
}
