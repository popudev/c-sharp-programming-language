using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    internal class Exercise8 : BaseExercise
    {
        public void Run()
        {
            Console.Write("Nhập số lượng giá trị: ");
            int n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                Console.Write("Số lượng giá trị phải là một số nguyên dương.");
                return;
            }

            double minValue = double.MaxValue; // Giá trị nhỏ nhất ban đầu là vô cùng lớn
            double maxValue = double.MinValue; // Giá trị lớn nhất ban đầu là vô cùng nhỏ

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập giá trị thứ {i + 1}: ");
                if (double.TryParse(Console.ReadLine(), out double value))
                {
                    minValue = Math.Min(minValue, value);
                    maxValue = Math.Max(maxValue, value);
                }
                else
                {
                    Console.Write("Giá trị không hợp lệ. Vui lòng nhập một số.");
                    i--; // Lặp lại lần này để nhập lại giá trị hợp lệ.
                }
            }

            Console.WriteLine($"\n\nGiá trị nhỏ nhất: {minValue}");
            Console.WriteLine($"Giá trị lớn nhất: {maxValue}");
        }
    
    }
}
