using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    internal class Exercise11 : BaseExercise
    {
       	public int Fibonacci(int n) {	
    		int a = 0;
    		int b = 1;
    		for (int i = 0; i < n; i++) {
      			int temp = a;
      			a = b;
      			b = temp + b;
    		}
    		return a;
  		}
		public bool isPerfectSquare(int x)
		{
    		int s = (int)Math.Sqrt(x);
    		return (s * s == x);
		}
		public bool isFibonacci(int n)
		{
    		return isPerfectSquare(5 * n * n + 4) || isPerfectSquare(5 * n * n - 4);
		}
  		public void Run () {
			Console.WriteLine("11a. Tính số fibonacci thứ n");
			Console.Write("Nhập n: ");
    	    int n = int.Parse(Console.ReadLine());
			Console.WriteLine($"Fibonacci({n}) = {Fibonacci(n)}");
			Console.WriteLine("11b. Kiểm tra một số x có phải là số fibonnaci hay không?");
			Console.Write("Nhập x: ");
    	    int x = int.Parse(Console.ReadLine());
			Console.WriteLine($"isFibonacci({x}) = {isFibonacci(x)}");
			Console.WriteLine("11c. n số fibonacci đầu tiên");
			for (int i = 0; i <= n; i++) {
    	  		Console.Write(Fibonacci(i)+" ");
    		}
			Console.Write("\n");
			Console.WriteLine("11d. Tính tổng các số fibonacci bé hơn m, m nhập từ bàn phím");
			Console.Write("Nhập m: ");
			int sum = 0;
			int m = int.Parse(Console.ReadLine());
			for (int i = 1; i < m; i++) {
    	  		sum += Fibonacci(i);
    		}
			Console.Write($"Tổng: {sum}");
  		}
    }
}