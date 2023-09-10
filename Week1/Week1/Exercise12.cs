using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    internal class Exercise12 : BaseExercise
    {
		public bool isSquareNumber(int n)
		{
    		double result = Math.Sqrt(n);
			return result%1 == 0;
		}
  		public void Run () {
			int n = 0;
			do {
				Console.Write("Nhập số chính phương n: ");
        		n = int.Parse(Console.ReadLine());
			}while(!isSquareNumber(n));
			Console.Write($"Bạn vừa nhập số chính phương là {n}");
  		}
		
    }
}