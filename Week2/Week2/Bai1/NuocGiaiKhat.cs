using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    internal class NuocGiaiKhat
    {
        const float THUE_VAT = 1 / 10;
        private string tenHang;
        private string donViTinh;
        private int soLuong;
        private float donGia;
        public string TenHang { get => tenHang; set { tenHang = value; } }
        public string DonViTinh
        {
            get => donViTinh; set
            {
                switch (value)
                {
                    case "kết":
                    case "thùng":
                    case "chai":
                    case "lon":
                        donViTinh = value; break;
                    default:
                        donViTinh = "kết";
                        break;
                }
            }
        }
        public int SoLuong { get => soLuong; set { soLuong = value; } }
        public float DonGia { get => donGia; set { donGia = value; } }

        public NuocGiaiKhat()
        {

        }
        public NuocGiaiKhat(string tenHang, string donViTinh, int soLuong, float donGia)
        {
            this.tenHang = tenHang;
            this.donViTinh = donViTinh;
            this.soLuong = soLuong;
            this.DonGia = donGia;
        }
        public float TinhTien()
        {
            float total = 0;
            switch (this.donViTinh)
            {
                case "kết":
                case "thùng":
                    total = this.soLuong * this.donGia + this.soLuong * this.donGia * THUE_VAT;
                    break;
                case "chai":
                    total = this.soLuong * (this.donGia / 20) + this.soLuong * (this.donGia / 20) * THUE_VAT;
                    break;
                case "lon":
                    total = this.soLuong * (this.donGia / 24) + this.soLuong * (this.donGia / 24) * THUE_VAT;
                    break;
            }


            return total;
        }
        public void NhapThongTin()
        {
            Console.WriteLine("Nhập thông tin nước giải khát!!!!");
            Console.Write("Nhập Tên hàng: ");
            this.tenHang = Console.ReadLine();
            Console.Write("Nhập đơn vị Tính: ");
            this.donViTinh = Console.ReadLine();
            Console.Write("Nhập số lượng: ");
            this.soLuong = int.Parse(Console.ReadLine());
            Console.Write("Nhập đơn giá: ");
            this.donGia = float.Parse(Console.ReadLine());

        }
        public void XuatThongTIn()
        {
            Console.WriteLine($"THÔNG TIN NƯỚC GIẢI KHÂT \n" +
                              $"Tên nước giải khát: {this.tenHang} \n" +
                              $"Đơn vị tính: {this.donViTinh} \n" +
                              $"Số lượng: {this.soLuong} \n" +
                              $"Đơn giá: {this.donGia}");
        }

    }
}

