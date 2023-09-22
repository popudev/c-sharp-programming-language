using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.BaiTapTrenLop
{
    internal class ExerciseOnClass
    {
        public void Run ()
        {
            Nhanvien nhanvien = new Nhanvien();
            nhanvien.nhapNhanvien();
            Console.WriteLine(nhanvien.thongTinNhanVien());
        }
    }
}
