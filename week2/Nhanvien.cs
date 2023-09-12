using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2
{
    internal class Nhanvien
    {
        const int luong1Ngay = 200000;
        private string maSo;
        private string hoTen;
        private int soNgayCong;
        private char xepLoai;
        private int luong;
        public string MaSo { get; set; }
        public string HoTen { get; set; }
        public int SoNgayCong { get; set; }
        public char XepLoai
        {
            get
            {
                return xepLoai;
            }
            set
            {
                if (soNgayCong > 26)
                {
                    xepLoai = 'A';
                }
                else if (22 <= soNgayCong && soNgayCong <= 26)
                {
                    xepLoai = 'B';
                }
                else
                {
                    xepLoai = 'C';
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
        public Nhanvien nhapNhanvien()
        {
            Console.WriteLine("Nhap thong tin nhan vien");
            Console.Write("Nhap ma so: ");
            string maSo = Console.ReadLine();
            Console.Write("Nhap ho va ten: ");
            string hoTen = Console.ReadLine();
            Console.Write("Nhap so ngay cong: ");
            int soNgayCong = int.Parse(Console.ReadLine());
            return new Nhanvien(maSo, hoTen, soNgayCong);

        }
        public String thongTinNhanVien()
        {
            return $"ma So: {maSo} \n" +
                $"Ho va ten: {hoTen} \n+" +
                $"So ngay Cong: {soNgayCong} \n+" +
                $"Xep loai: {xepLoai}";
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
