using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    //Câu 3.	Viết chương trình biện luận và giải phương trình bậc 1.
    internal class Exercise3 : BaseExercise
    {
        string title = "Phương trình bậc 1 có dạng : ax+b=0 \n" +
                        "VUI LÒNG NHẬP A VÀ B";
        public void Cau3(double a, double b)
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine($"{a}x+{b}=0");
                    Console.WriteLine("=> Phương trình có vô số nghiệm");
                }
                else
                {
                    Console.WriteLine($"{a}x+{b}=0");
                    Console.WriteLine("=> Phương trình vô nghiệm");
                }
            }
            else
            {
                double x = -b / a;
                Console.WriteLine($"{a}x+{b}=0");
                Console.WriteLine($"=> Nghiệm của phương trình x = {x}");
            }
        }
        public void Run()
        {
            Console.WriteLine(title);
            Console.Write("Nhap bien A= ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhap bien B= ");
            double b = double.Parse(Console.ReadLine());
            Cau3(a, b);
        }
    }
}
