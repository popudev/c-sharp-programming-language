using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    /*
        * Câu 5.	Viết chương trình nhập số nguyên N. In ra các kết quả:
               a. Các số tự nhiên <=N và tổng của chúng.
               b. Các số tự nhiên chẵn <=N và tổng của chúng.
               c. Các số tự nhiên lẻ <=N và tổng của chúng
               d. Các số tự nhiên là số nguyên tố <=N và tổng của chúng
               e. N số nguyên tố đầu tiên

        */
    internal class Exercise5 : BaseExercise
    {
        public int cau5a(int n)
        {
            int sum = 0;
            for (int i = 0; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }
        public int cau5b(int n)
        {
            int sum = 0;
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
        public int cau5c(int n)
        {
            int sum = 0;
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
        bool SNT(int n)
        {
            if (n <= 1)
            {
                return false;
            }
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public int cau5d(int n)
        {
            int sum = 0;
            for (int i = 0; i <= n; i++)
            {
                if (SNT(i))
                {
                    sum += i;
                }
            }
            return sum;
        }
        public void cau5e(int n)
        {
            Console.Write("5e. N số nguyên tố đầu tiên: ");
            for (int i = 0; i <= n; i++)
            {
                if (SNT(i))
                {
                    Console.Write($"{i} ");
                }
            }
        }
        public void Run()
        {
            Console.Write("Vui lòng nhập n = ");
            int n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("n phải lớn hơn 0");
                return;
            }
            Console.WriteLine($"5a. Tổng n số tự nhiên = {cau5a(n)}");
            Console.WriteLine($"5b. Tổng n số tự nhiên chẵn = {cau5b(n)}");
            Console.WriteLine($"5c. Tổng n số tự nhiên lẽ = {cau5c(n)}");
            Console.WriteLine($"5d. Tổng n số tự nhiên là số nguyên tố = {cau5d(n)}");
            cau5e(n);
        }
    }
}
