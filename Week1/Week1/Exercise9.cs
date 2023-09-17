using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    internal class Exercise9 : BaseExercise
    {
        public void Run()
        {
            Console.WriteLine("Cac boi so cua 3 tu 300 den 3: ");
            for (int i = 300; i >= 3; i--)
            {
                if (i % 3 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
