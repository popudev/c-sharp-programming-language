using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    //Câu 4.	Viết chương trình biện luận và giải phương trình bậc 2.
    internal class Exercise4 : BaseExercise
    {
        string title = "Phương trình bậc 2 có dạng : Ax^2+Bx+C=0 \n"
                       + "Vui lòng nhập A, B, C";
        public void cau4(double a, double b, double c)
        {
            double delta = b * b - 4 * a * c;
            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"{a}x^2+{b}x+{c}=0");
                Console.WriteLine($"=> Nghiệm của phương trình x1 = {x1}");
                Console.WriteLine($"=> Nghiệm của phương trình x2 = {x2}");

            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"{a}x^2+{b}x+{c}=0");
                Console.WriteLine($"=> Nghiệm kép của phương trình x1 = x2 = {x}");
            }
            else
            {
                Console.WriteLine($"{a}x^2+{b}x+{c}=0");
                Console.WriteLine($"=> Phương trình vô nghiệm");
            }
        }
        public void Run()
        {
            Console.WriteLine(title);
            Console.Write("Nhập A= ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhập B= ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Nhập C= ");
            double c = double.Parse(Console.ReadLine());
            cau4(a, b, c);
        }
    }
}
