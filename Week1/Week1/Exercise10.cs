using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    internal class Exercise10 : BaseExercise
    {
        int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int tmp = b;
                b = a % b;
                a = tmp;
            }
            return a;
        }
        int BCNN(int a, int b)
        { 
            return (a * b) / UCLN((int)a, (int)b);
        }
        public void Run()
        {
            Console.Write("Nhap so dau tien: "); int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");  int b = int.Parse(Console.ReadLine());

            Console.WriteLine("UCLN: "+UCLN(a,b));
            Console.WriteLine("BCNN: "+BCNN(a,b));
        }
    }
}
