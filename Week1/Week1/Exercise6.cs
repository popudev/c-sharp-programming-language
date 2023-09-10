using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    internal class Exercise6 : BaseExercise
    {

        public void A() {
            Console.WriteLine("Câu a: ");
            Console.Write("Nhập giá trị n: ");
            int n = int.Parse(Console.ReadLine());

            double a_n = 2021.0; // Khởi tạo giá trị đầu tiên của biểu thức

            double factorial = 1.0; // Khởi tạo giai thừa ban đầu

            for (int i = 2; i <= n; i++)
            {
                factorial *= i; // Tính giai thừa i!
                double term = Math.Pow(-1, i) / factorial; // Tính phần tử của dãy
                a_n += term; // Cộng phần tử vào biểu thức
            }

            Console.WriteLine($"Giá trị của a({n}) = {a_n}");
        }

        // Hàm tính giai thừa của một số
        public double Factorial(double num)
        {
            if (num == 0)
                return 1;
            else
                return num * Factorial(num - 1);
        }

        public void B()
        {
            Console.WriteLine("Câu b: ");

            Console.Write("Nhập giá trị x (1 ≤ x ≤ 50): ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Nhập giá trị n: ");
            int n = int.Parse(Console.ReadLine());

            double s_n = 0.0; // Khởi tạo giá trị của biểu thức

            for (int i = 1; i <= n; i++)
            {
                double denominator = x + i; // Mẫu số (x + i)
                double term = x / (i * Factorial(denominator)); // Tính phần tử của dãy
                s_n += term; // Cộng phần tử vào biểu thức
            }

            Console.WriteLine($"Giá trị của S({n}) = {s_n}");
        }

        public void Run()
        {
            A();
            B();
        }
    }
}
