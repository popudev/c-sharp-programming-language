using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Bai2
{
    internal class VanDongVien
    {
        public int MaSo { get; set; }
        public string HoTen { get; set; }
        public int SoAo { get; set; }
        public ThoiGian ThoiGianBatDau { get; set; }
        public ThoiGian ThoiGianKetThuc { get; set; }
        public ThoiGian ThanhTichChuan { get; } = new ThoiGian(1, 30, 0);

        public VanDongVien() { }

        public VanDongVien(int maSo, string hoTen, int soAo, ThoiGian thoiGianBatDau, ThoiGian thoiGianKetThuc)
        {
            MaSo = maSo;
            HoTen = hoTen;
            SoAo = soAo;
            ThoiGianBatDau = thoiGianBatDau;
            ThoiGianKetThuc = thoiGianKetThuc;
        }

        public bool KiemTraThoiGianHopLe()
        {
            try
            {
                DateTime.Now.Add(new TimeSpan(ThoiGianBatDau.Gio, ThoiGianBatDau.Phut, ThoiGianBatDau.Giay));
                DateTime.Now.Add(new TimeSpan(ThoiGianKetThuc.Gio, ThoiGianKetThuc.Phut, ThoiGianKetThuc.Giay));
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void NhapThongTin()
        {
            Console.WriteLine("Nhập thông tin vận động viên:");
            Console.Write("Mã số: ");
            MaSo = int.Parse(Console.ReadLine());

            Console.Write("Họ tên: ");
            HoTen = Console.ReadLine();

            Console.Write("Số áo: ");
            SoAo = int.Parse(Console.ReadLine());

            do
            {
                Console.Write("Thời gian bắt đầu (HH:mm:ss): ");
                string thoiGianBatDauStr = Console.ReadLine();
                var thoiGianBatDauParts = thoiGianBatDauStr.Split(':');
                if (thoiGianBatDauParts.Length != 3 ||
                    !int.TryParse(thoiGianBatDauParts[0], out int gio) ||
                    !int.TryParse(thoiGianBatDauParts[1], out int phut) ||
                    !int.TryParse(thoiGianBatDauParts[2], out int giay) ||
                    gio < 0 || gio >= 24 || phut < 0 || phut >= 60 || giay < 0 || giay >= 60)
                {
                    Console.WriteLine("Thời gian không hợp lệ. Vui lòng nhập lại.");
                }
                else
                {
                    ThoiGianBatDau = new ThoiGian(gio, phut, giay);
                    break;
                }
            } while (true);

            do
            {
                Console.Write("Thời gian kết thúc (HH:mm:ss): ");
                string thoiGianKetThucStr = Console.ReadLine();
                var thoiGianKetThucParts = thoiGianKetThucStr.Split(':');
                if (thoiGianKetThucParts.Length != 3 ||
                    !int.TryParse(thoiGianKetThucParts[0], out int gio) ||
                    !int.TryParse(thoiGianKetThucParts[1], out int phut) ||
                    !int.TryParse(thoiGianKetThucParts[2], out int giay) ||
                    gio < 0 || gio >= 24 || phut < 0 || phut >= 60 || giay < 0 || giay >= 60)
                {
                    Console.WriteLine("Thời gian không hợp lệ. Vui lòng nhập lại.");
                }
                else
                {
                    ThoiGianKetThuc = new ThoiGian(gio, phut, giay);
                    break;
                }
            } while (true);
        }

        public void XuatThongTin()
        {
            Console.WriteLine("Thông tin vận động viên:");
            Console.WriteLine($"Mã số: {MaSo}");
            Console.WriteLine($"Họ tên: {HoTen}");
            Console.WriteLine($"Số áo: {SoAo}");
            Console.WriteLine($"Thời gian bắt đầu: {ThoiGianBatDau}");
            Console.WriteLine($"Thời gian kết thúc: {ThoiGianKetThuc}");
            if (KiemTraThoiGianHopLe())
            {
                ThoiGian thanhTich = TinhThanhTich();
                if (thanhTich.Gio == 0 && thanhTich.Phut == 0 && thanhTich.Giay == 0)
                {
                    Console.WriteLine("Không đạt thành tích chuẩn.");
                }
                else
                {
                    Console.WriteLine($"Thành tích: {thanhTich}");
                }
            }
            else
            {
                Console.WriteLine("Thời gian không hợp lệ.");
            }
        }

        public ThoiGian TinhThanhTich()
        {
            return ThoiGian.TinhThanhTich(ThoiGianKetThuc, ThoiGianBatDau);
        }
    }
}
