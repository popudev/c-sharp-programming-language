using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    /* Câu 1: 
        * Viết chương trình nhập vào giá trị ngày/tháng/năm của một ngày trong một năm 
        * bất kỳ.Cho biết ngày đó thứ mấy. Biết rằng công thức tính thứ của một ngày/tháng/năm
    */
    internal class Exercise1 : BaseExercise
    {
        public void Run()
        {
            Console.Write("Nhập ngày (1-31): ");
            int ngay = int.Parse(Console.ReadLine());

            Console.Write("Nhập tháng (1-12): ");
            int thang = int.Parse(Console.ReadLine());

            Console.Write("Nhập năm: ");
            int nam = int.Parse(Console.ReadLine());

            if (thang < 3)
            {
                thang += 12;
                nam--;
            }

            int thu = (ngay + 2 * thang + (3 * (thang + 1)) / 5 + nam + (nam / 4)) % 7;

            string[] ngayTrongTuan = { "Chủ Nhật", "Thứ 2", "Thứ 3", "Thứ 4", "Thứ 5", "Thứ 6", "Thứ 7" };

            Console.WriteLine($"Ngày {ngay}/{thang}/{nam} là {ngayTrongTuan[thu]}.");
        }
    }
}
