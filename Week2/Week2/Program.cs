using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2.Bai1;
using Week2.Bai2;
using Week2.Bai3;
using Week2.BaiTapTrenLop;

namespace Week2
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

                case 2:
                    {
                        Exercise2 ex = new Exercise2();
                        ex.Run();
                        break;
                    }
                case 3:
                    {
                        Exercise3 ex = new Exercise3();
                        ex.Run();
                        break;
                    }
                case 4:
                    {
                        ExerciseOnClass ex = new ExerciseOnClass();
                        ex.Run();
                        break;
                    }

            }
        }
        static void Main(string[] args)
        {
            // fix lỗi font chữ không có dấu
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            while (true)
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
