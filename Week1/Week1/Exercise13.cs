using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    internal class Exercise13 : BaseExercise
    {
  		public void Run () {
			Console.Write("Nhập n: ");
        	int n = int.Parse(Console.ReadLine());
			int temp = n;
			int count;
	    	for(int i = 2; i <= temp; i++){
        		count = 0;
        		while(temp % i == 0){
        	    	++count;
        	    	temp /= i;
        		}
        		if(count >= 1){
        	    	Console.Write(i);
        	    	if(count > 1) Console.Write($"^{count}");;
        	    	if(temp > i){
        	        	Console.Write("*");
        	    	}
        		}
    		}
			Console.Write("\n");
			Console.WriteLine($"n có {n.ToString().Length} chữ số ");
  		}
    }
}