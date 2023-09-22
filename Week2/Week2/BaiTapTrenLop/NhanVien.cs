using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.BaiTapTrenLop
{
    internal class Nhanvien
    {
        public static int luong1Ngay = 200000;
        private string maSo;
        private string hoTen;
        private int soNgayCong;
        private char xepLoai;
        private int luong;
        public string MaSo
        {
            get => maSo;
            set
            {
                maSo = value;
            }
        }
        public string HoTen { get => hoTen; set { hoTen = value; } }
        public int SoNgayCong
        {
            get => soNgayCong;
            set
            {
                if (value <= 0)
                    Console.WriteLine("Nhap lon hon 0");
                else
                    soNgayCong = value;
            }
        }
        public char XepLoai
        {
            get
            {
                if (soNgayCong > 26)
                {
                    return 'A';
                }
                else if (22 <= soNgayCong && soNgayCong <= 26)
                {
                    return 'B';
                }
                else
                {
                    return 'C';
                }
            }
        }

        public Nhanvien(string maSo, string hoTen, int soNgayCong)
        {
            this.maSo = maSo;
            this.hoTen = hoTen;
            this.soNgayCong = soNgayCong;
        }
        public Nhanvien(string hoTen, int soNgayCong)
        {
            this.hoTen = hoTen;
            this.soNgayCong = soNgayCong;
        }

        public Nhanvien()
        {

        }
        ~Nhanvien()
        {
            this.maSo = null;
            this.hoTen = null;
            this.soNgayCong = 0;
        }
        public void nhapNhanvien()
        {
            Console.WriteLine("Nhap thong tin nhan vien");
            Console.Write("Nhap ma so: ");
            MaSo = Console.ReadLine();
            Console.Write("Nhap ho va ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap so ngay cong: ");
            while (true)
            {
                SoNgayCong = int.Parse(Console.ReadLine());
                if (SoNgayCong > 0) break;
            }


        }
        public String thongTinNhanVien()
        {
            return $"ma So: {MaSo} \n" +
                $"Ho va ten: {HoTen} \n" +
                $"So ngay Cong: {SoNgayCong} \n" +
                $"Xep loai: {XepLoai}";
        }
        public int luongNgay()
        {
            int luong = 0;
            luong = this.SoNgayCong * luong1Ngay;
            return luong;
        }
        public double tinhThuong()
        {
            double tienThuong = 0;
            switch (this.xepLoai)
            {
                case 'A':
                    tienThuong = this.luong * 0.05;
                    break;
                case 'B':
                    tienThuong = this.luong * 0.02;
                    break;
                default:
                    tienThuong = 0;
                    break;

            }
            return tienThuong;
        }
    }
}
