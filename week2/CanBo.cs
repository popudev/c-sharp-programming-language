using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2
{
    internal class CanBo
    {
        private string hoten;
        private int namsinh;
        private string gioitinh;
        private string diachi;

        public CanBo(string hoten, int namsinh, string gioitinh, string diachi) { 
            this.hoten = hoten;
            this.namsinh = namsinh; 
            this.gioitinh = gioitinh;
            this.diachi = diachi;   
        }
        public string Hoten
        {
            get => hoten;
            set
            {
                hoten = value;
            }
        }
        public int Namsinh
        {
            get => namsinh;
            set
            {
                if ((int.Parse(DateTime.Now.Year.ToString()) - value) >= 18)
                    namsinh = value;
                else
                    Console.WriteLine("Khong du 18 tuoi");
            }
        }
        public string Gioitinh
        {
            get => gioitinh;
            set
            {
                if (!value.Equals("Nam") || !value.Equals("Nu"))
                    gioitinh = value;
                else
                    Console.WriteLine("Gioi tinh la Nam hoac nu");
            }
        }
        public string Diachi
        {
            get => diachi;
            set
            {
                diachi = value;
            }
        }
    }
}
