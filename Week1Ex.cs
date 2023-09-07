using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Week1
{
    internal class Week1Ex
    {

        // Câu 1: Câu 1.	Viết chương trình nhập vào giá trị ngày/tháng/năm của một ngày trong một năm
        // bất kỳ.Cho biết ngày đó thứ mấy.Biết rằng công thức tính thứ của một ngày/tháng/năm

        public int Cau1(int day, int month, int year)
        {
            if (month < 3)
            {
                month += 12;
                year--;
            }
            return  (day + 2 * month + (3 * (month + 1)) / 5 + year + (year / 4)) % 7;
        }

        //Câu 2.	Nhập vào 1 ngày tháng năm. Cho biết ngày trước đó và ngày hôm sau là ngày nào.
        bool laNamNhuan(int year)
        {
            if((year % 4==0 && year %100!=0) || year %400==0) {
                return true;
            }
            return false;
        }
        int tinhSoNgayTrongThang(int month, int year)
        {
            int numOfDays=0;
            switch(month)
            {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12: numOfDays = 31; break;
                case 4: case 6: case 9: case 11: numOfDays=30; break;
                case 2:
                    if (laNamNhuan(year))
                    {
                        numOfDays = 29;
                    }
                    else
                    {
                        numOfDays = 28;
                    }
                    break;

            }
            return numOfDays;
        }
        void timNgayHomTruoc(int day, int month, int year) {
            day--;
            if(day==0)
            {
                month--;
                if(month==0)
                {
                    month = 12;
                    year--;
                }
                day=tinhSoNgayTrongThang(month, year);
            }
            Console.WriteLine($"ngay hom truoc la: {day}/{month}/{year}");
        }
        void timNgayHomSau(int day, int month, int year)
        {
            day++;
            if (day > tinhSoNgayTrongThang(month, year))
            {
                day = 1;
                month++;
                if (month > 12)
                {
                    month = 1;
                    year++;
                }
            }
            Console.WriteLine($"ngay hom sau la: {day}/{month}/{year}");
        }
        public void Cau2(int day, int month, int year)
        {
            int tmpDay = day;
            int tmpMonth = month;
            int tmpYear = year;
            timNgayHomTruoc(tmpDay,tmpMonth, tmpYear);
             tmpDay = day;
             tmpMonth = month;
             tmpYear = year;
            timNgayHomSau(tmpDay, tmpMonth, tmpYear);


        }

        //Câu 3.	Viết chương trình biện luận và giải phương trình bậc 1.

        public void Cau3(double a, double b)
        {
            if (a == 0)
            {
                if(b == 0){
                    Console.WriteLine("Phuong trinh co vo so nghiem");
                }
                else
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
            }
            else
            {
                double x = -b / a;
                Console.WriteLine($"Nghiem cua phuong trinh là x = {x}");
            }
        }

        //Câu 4.	Viết chương trình biện luận và giải phương trình bậc 2.

        public void cau4(double a,double b, double c)
        {
            double delta = b * b - 4 * a * c;
            if(delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"Nghiem cua phuong trinh x1 = {x1}");
                Console.WriteLine($"Nghiem cua phuong trinh x2 = {x2}");

            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Nghiem kep cua phuong trinh x1 = x2 = {x}");
            }
            else
            {
                Console.WriteLine($"Phuong trinh vo nghiem");
            }
        }

        /*
         * Câu 5.	Viết chương trình nhập số nguyên N. In ra các kết quả:
                a. Các số tự nhiên <=N và tổng của chúng.
                b. Các số tự nhiên chẵn <=N và tổng của chúng.
                c. Các số tự nhiên lẻ <=N và tổng của chúng
                d. Các số tự nhiên là số nguyên tố <=N và tổng của chúng
                e. N số nguyên tố đầu tiên

         */
        public int cau5a(int n)
        {
            int sum = 0;
            for(int i = 0; i <= n; i++)
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
            for (int i = 0; i <= n; i++)
            {
                if (SNT(i))
                {
                  Console.WriteLine($"{i} ");
                }
            }
        }
    }

}
