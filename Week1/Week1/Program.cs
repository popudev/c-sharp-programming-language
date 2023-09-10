using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* PHÍM TẮT VISUAL STUDIO
 *  cmt code: ctrl + K + U
 *  format code: ctrl + K + D
 */


namespace Week1
{
    internal class Program
    {
        static void RunExercise(int n)
        { 
            switch (n)
            {
                case 1:
                    {
                        Exercise1 ex = new Exercise1();
                        ex.Run();
                        break;
                    }
                case 6:
                    {
                        Exercise6 ex = new Exercise6();
                        ex.Run();
                        break;
                    }

                case 7:
                    {
                        Exercise7 ex = new Exercise7();
                        ex.Run();
                        break;
                    }

                case 8:
                    {
                        Exercise8 ex = new Exercise8();
                        ex.Run();
                        break;
                    }
            }
        }
        static void Main(string[] args)
        {
            // fix lỗi font chữ không có dấu
            Console.OutputEncoding = System.Text.Encoding.UTF8;
    
            while(true)
            {
                Console.Write("Bạn muốn chạy bài tập mấy (Nhấn 0 để thoát): ");
                int n = int.Parse(Console.ReadLine());
                if (n <= 0) return;
                Console.Clear();
                RunExercise(n);
                Console.WriteLine("\n\n\n================================================");
            }

          
        }
    }
}
