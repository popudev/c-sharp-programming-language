using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    internal class DSKhoaHoc
    {

    
        List<KhoaHoc> khoaHocs;
        public List<KhoaHoc> readFromFile()
        {
            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string relativeFilePath = Path.Combine("..", "..", "Bai3", "KhoaHoc.txt");
            string filePath = Path.Combine(appDirectory, relativeFilePath);
            List<KhoaHoc> list = new List<KhoaHoc>();
            string[] a = File.ReadAllLines(filePath);
            for (int i = 0; i < a.Length; i++)
            {
                list.Add(new KhoaHoc(a[i]));
            }
            return list;
        }

        public DSKhoaHoc()
        {
            khoaHocs = readFromFile();
        }
        public float TongTien()
        {
            float total = 0;
            for (int i = 0; i < khoaHocs.Count; i++)
            {
                total += (khoaHocs[i].HocPhi - khoaHocs[i].ThuLaoGiaoVien());
            }
            return total;
        }
        public float TongTienDangCo()
        {
            float total = 0;
            for (int i = 0; i < khoaHocs.Count; i++)
            {
                total += khoaHocs[i].HocPhi;
            }
            return total;
        }

        public List<KhoaHoc> lopTren15HocVien()
        {
            List<KhoaHoc> khoas = new List<KhoaHoc>();
            for (int i = 0; i < khoaHocs.Count; i++)
            {
                if (khoaHocs[i].SoHocVien > 15)
                {
                    khoas.Add(khoaHocs[i]);
                }
            }

            return khoas;
        }

        public int SoLuongLopGVX(string x)
        {
            int total = 0;
            for (int i = 0; i < khoaHocs.Count; i++)
            {
                if (khoaHocs[i].SoHocVien > 15)
                {
                    total++;
                }
            }
            return total;
        }

        public void SXTheoHocPhiGiam()
        {
            var sort = khoaHocs.OrderByDescending(khoahoc => khoahoc.HocPhi).ToList();
            foreach (KhoaHoc item in sort)
            {
                item.XuatThongTinKhoaHoc();
            }
        }
        public void InRaManHinhKhoaHocX(string x)
        {
            for (int i = 0; i < khoaHocs.Count; i++)
            {
                if (khoaHocs[i].TenKhoaHoc.Trim().Equals(x.Trim()))
                {
                    khoaHocs[i].XuatThongTinKhoaHoc();
                }
            }
        }
        public void InRaManHinhKhoaHoc()
        {
            for (int i = 0; i < khoaHocs.Count; i++)
            {
                {
                    khoaHocs[i].XuatThongTinKhoaHoc();
                }
            }
        }
        public void InDS(List<KhoaHoc> khoas, string ten)
        {

            Console.WriteLine($"In thông tin theo giờ học:{ten}");
            for (int i = 0; i < khoas.Count; i++)
            {
                khoas[i].XuatThongTinKhoaHoc();
            }
        }
        public void KhoaHocTheoGio()
        {
            List<KhoaHoc> khoahoc246 = new List<KhoaHoc>();
            List<KhoaHoc> khoahoc357 = new List<KhoaHoc>();
            List<KhoaHoc> khoahoc7CN = new List<KhoaHoc>();
            for (int i = 0; i < khoaHocs.Count; i++)
            {
                if (khoaHocs[i].GioHoc.Equals("2,4,6"))
                {
                    khoahoc246.Add(khoaHocs[i]);
                }
                else if (khoaHocs[i].GioHoc.Equals("3,5,7"))
                {
                    khoahoc357.Add(khoaHocs[i]);
                }
                else
                {
                    khoahoc7CN.Add(khoaHocs[i]);
                }
            }
            InDS(khoahoc246, "2,4,6");
            InDS(khoahoc357, "3,5,7");
            InDS(khoahoc7CN, "7, CN");
        }

    }

}
