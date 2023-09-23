using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3
{
    internal class SinhVien
    {
        private MonLyThuyet monLT;
        private MonThucHanh monTH;
        private MonDoAn monDA;
        private float diemTL;
        private int hocphi;

        public SinhVien(MonLyThuyet monLT, MonThucHanh monTH, MonDoAn monDA, float diemTL, int hocphi)
        {
            this.monLT = monLT;
            this.monTH = monTH;
            this.monDA = monDA;
            this.diemTL = diemTL;
            this.hocphi = hocphi;
        }
        public SinhVien(MonLyThuyet monLT, MonThucHanh monTH, MonDoAn monDA)
        {
            this.monLT = monLT;
            this.monTH = monTH;
            this.monDA = monDA;
        }
        public MonLyThuyet MonLT
        {
            get => monLT;
            set => monLT = value;
        }
        public MonThucHanh MonTH
        {
            get => monTH;
            set => monTH = value;
        }
        public MonDoAn MonDA
        {
            get => monDA; 
            set => monDA = value;
        }
        public float DiemTL
        {
            get => diemTL;
            set => diemTL = value;
        }
        public int Hocphi
        {
            get => hocphi;
            set => hocphi = value;
        }
        public float DiemTichLuy()
        {
            DiemTL = (MonLT.TinhDiem() + MonTH.TinhDiem() + MonDA.TinhDiem())/3;
            return DiemTL;
        }
        public int HocPhi()
        {
            return MonLT.TinhHocPhi()+MonTH.TinhHocPhi()+MonDA.TinhHocPhi();
        }
    }
}
