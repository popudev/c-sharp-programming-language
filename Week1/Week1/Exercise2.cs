using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    internal class Exercise2 : BaseExercise
    {
        bool laNamNhuan(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                return true;
            }
            return false;
        }
        int tinhSoNgayTrongThang(int month, int year)
        {
            int numOfDays = 0;
            switch (month)
            {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12: numOfDays = 31; break;
                case 4: case 6: case 9: case 11: numOfDays = 30; break;
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
        void timNgayHomTruoc(int day, int month, int year)
        {
            day--;
            if (day == 0)
            {
                month--;
                if (month == 0)
                {
                    month = 12;
                    year--;
                }
                day = tinhSoNgayTrongThang(month, year);
            }
            Console.WriteLine($"Ngày hôm trước là: {day}/{month}/{year}");
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
            Console.WriteLine($"Ngày hôm sau là: {day}/{month}/{year}");
        }
        public void CheckDay(int day, int month, int year)
        {
            int tmpDay = day;
            int tmpMonth = month;
            int tmpYear = year;
            timNgayHomTruoc(tmpDay, tmpMonth, tmpYear);
            tmpDay = day;
            tmpMonth = month;
            tmpYear = year;
            timNgayHomSau(tmpDay, tmpMonth, tmpYear);
        }
        public void Run()
        {
            Console.Write("Vui lòng nhập ngày: ");
            int day = int.Parse(Console.ReadLine());
            Console.Write("Vui lòng nhập tháng: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Vui lòng lòng nhập năm: ");
            int year = int.Parse(Console.ReadLine());
            if (day != 0 && month != 0 && year != 0)
            {
                Console.WriteLine($"{day}/{month}/{year}");
                CheckDay(day, month, year);
            }

        }
    }
}
