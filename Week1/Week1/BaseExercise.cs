using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    internal class BaseExercise
    {
        public BaseExercise()
        {
            // Lấy tên của lớp con và in ra
            string derivedClassName = this.GetType().Name;
            Console.WriteLine("\n\n======> " + derivedClassName + " <======");
        }
    }
}
