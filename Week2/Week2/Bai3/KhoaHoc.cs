using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    internal class KhoaHoc
    {
        const int hoc1Tiet = 20;
        const int ThuLaoGV = 100;
        const int TraThem = 2;
        private string maKhoaHoc;
        private string tenKhoaHoc;
        private string gioHoc;
        private int soTiet;
        private int soHocVien;
        private string giaoVien;
        private float hocPhi;

        public string GioHoc
        {
            get => gioHoc; set
            {
                switch (value)
                {
                    case "3,5,7":
                    case "2,4,6":
                    case "7,CN":
                        gioHoc = value;
                        break;
                    default:
                        gioHoc = "3,5,7";
                        break;

                }
            }
        }
        public float HocPhi
        {
            get
            {
                switch (this.gioHoc)
                {
                    case "3,5,7":
                    case "2,4,6":
                        hocPhi = (float)(hoc1Tiet * this.soTiet * 1.0);
                        break;
                    case "7,CN":
                        hocPhi = (float)(hoc1Tiet * this.soTiet * 1.2);
                        break;
                }
                return hocPhi;
            }
        }
        public string MaKhoaHoc { get => maKhoaHoc; set { maKhoaHoc = value; } }
        public string TenKhoaHoc { get => tenKhoaHoc; set { tenKhoaHoc = value; } }
        public int SoTiet { get => soTiet; set { soTiet = value; } }
        public int SoHocVien { get => soHocVien; set { soHocVien = value; } }
        public string GiaoVien { get => giaoVien; set { giaoVien = value; } }
        public KhoaHoc()
        {
            this.maKhoaHoc = "TH023";
            this.tenKhoaHoc = "Android Programming";
            this.soTiet = 48;
            this.gioHoc = "2,4,6";
            this.soHocVien = 13;
            this.giaoVien = "Nguyễn Hữu Đại";
        }
        public KhoaHoc(string maKhoaHoc, string tenKhoaHoc, string gioHoc, int soTiet, int soHocVien, string giaoVien)
        {
            this.maKhoaHoc = maKhoaHoc;
            this.tenKhoaHoc = tenKhoaHoc;
            this.gioHoc = gioHoc;
            this.soTiet = soTiet;
            this.soHocVien = soHocVien;
            this.giaoVien = giaoVien;
        }
        public KhoaHoc(string s)
        {
            var arrayList = s.Split('@');
            this.maKhoaHoc = arrayList[0];
            this.tenKhoaHoc = arrayList[1];
            this.soTiet = int.Parse(arrayList[2]);
            this.gioHoc = arrayList[3];
            this.soHocVien = int.Parse(arrayList[4]);
            this.giaoVien = arrayList[5];
        }
        public KhoaHoc(string maKhoaHoc, string tenKhoaHoc, int soTiet, int soHocVien, string giaoVien)
        {
            this.maKhoaHoc = maKhoaHoc;
            this.tenKhoaHoc = tenKhoaHoc;
            this.soTiet = soTiet;
            this.soHocVien = soHocVien;
            this.giaoVien = giaoVien;
        }
        public static KhoaHoc operator +(KhoaHoc n)

        {
            KhoaHoc khoaHoc = new KhoaHoc();
            khoaHoc.soTiet += n.soTiet;
            return khoaHoc;
        }
        public int ThuLaoGiaoVien()
        {
            int total;
            if (this.soHocVien > 10)
            {
                total = (ThuLaoGV + TraThem) * soTiet;
            }
            else
            {
                total = ThuLaoGV * soTiet;
            }
            return total;
        }
        public void XuatThongTinKhoaHoc()
        {
            Console.WriteLine($"========Xuất thông tin khóa học {this.tenKhoaHoc}==========");
            Console.WriteLine($"Mã khóa học: {this.maKhoaHoc} \n" +
                              $"Tên khóa học: {this.tenKhoaHoc} \n" +
                              $"Giờ học: {this.gioHoc} \n" +
                              $"Số tiết:{this.soTiet} \n" +
                              $"Số học viên: {this.soHocVien} \n" +
                              $"Học phí: {HocPhi} \n" +
                              $"Giáo viên: {this.giaoVien}");
        }

    }
}
