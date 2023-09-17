using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    internal class ThoiGian
    {
        private int gio;
        private int phut;
        private int giay;

        public ThoiGian(int gio, int phut, int giay)
        {
            Gio = gio;
            Phut = phut;
            Giay = giay;
        }

        public int Gio
        {
            get { return gio; }
            set
            {
                if (value >= 0 && value < 24)
                {
                    gio = value;
                }
                else
                {
                    throw new ArgumentException("Giờ không hợp lệ");
                }
            }
        }

        public int Phut
        {
            get { return phut; }
            set
            {
                if (value >= 0 && value < 60)
                {
                    phut = value;
                }
                else
                {
                    throw new ArgumentException("Phút không hợp lệ");
                }
            }
        }

        public int Giay
        {
            get { return giay; }
            set
            {
                if (value >= 0 && value < 60)
                {
                    giay = value;
                }
                else
                {
                    throw new ArgumentException("Giây không hợp lệ");
                }
            }
        }

        public static ThoiGian TinhThanhTich(ThoiGian thoiGianKetThuc, ThoiGian thoiGianBatDau)
        {
            int tongGiayKetThuc = thoiGianKetThuc.Gio * 3600 + thoiGianKetThuc.Phut * 60 + thoiGianKetThuc.Giay;
            int tongGiayBatDau = thoiGianBatDau.Gio * 3600 + thoiGianBatDau.Phut * 60 + thoiGianBatDau.Giay;

            int tongGiayThanhTich = Math.Max(tongGiayKetThuc - tongGiayBatDau, 0);

            int gio = tongGiayThanhTich / 3600;
            int phut = (tongGiayThanhTich % 3600) / 60;
            int giay = tongGiayThanhTich % 60;

            return new ThoiGian(gio, phut, giay);
        }

        public override string ToString()
        {
            return $"{Gio:D2}:{Phut:D2}:{Giay:D2}";
        }
    }
}
