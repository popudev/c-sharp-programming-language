using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    internal class Exercise7 : BaseExercise
    {
        public void Run()
        {
            Console.WriteLine("Nhập giá trị n: ");
            int n = int.Parse(Console.ReadLine());

            double result = 0.0; // Tổng sẽ được tính vào biến này

            if (n % 2 == 1)
            {
                // Nếu n là số lẻ, tính tổng các số lẻ
                result = (n + 1) / 2 * n;
            }
            else
            {
                // Nếu n là số chẵn, tính tổng các số chẵn
                result = n / 2 * (n + 1);
            }

            Console.WriteLine($"Tổng các số {(n % 2 == 1 ? "lẻ" : "chẵn")} từ 1 đến {n} = {result}");
        }
    }
}
