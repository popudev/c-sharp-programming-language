using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Bai1
{
    internal class Exercise1
    {
        public void Run()
        {
            // Bài 1
            NuocGiaiKhat nuocGiaiKhat = new NuocGiaiKhat();
            nuocGiaiKhat.NhapThongTin();
            nuocGiaiKhat.XuatThongTIn();
            Console.WriteLine($"Tính tiền: {nuocGiaiKhat.TinhTien()}");
        }
    }
}
