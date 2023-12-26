using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_SMNZ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int day, month, year;

            int[] Months = { 1, 3, 5, 7, 8, 10, 12 };
            int[] months = { 4, 6, 9, 11 };
        xyz: Console.WriteLine("Enter today's date:");
            Console.WriteLine("Day");
            day = Int32.Parse(Console.ReadLine());
            Console.WriteLine("month");
            month = Int32.Parse(Console.ReadLine());
            Console.WriteLine("year");
            year = Int32.Parse(Console.ReadLine());
            if (day >= 32 || day == 0 || month > 12 || month == 0)
            { Console.WriteLine("There is something wrong!"); }
            else
            {
                Console.WriteLine("Today is " + day + "/" + month + "/" + year);
                if (Months.Contains(month))
                {
                    if (day <= 30)
                    {
                        day += 1;
                        Console.WriteLine("Tomorrow is " + day + " /" + month + "/" + year);
                    }
                    else if (month == 12)
                    {
                        day = 1;
                        month = 1;
                        year += 1;
                        Console.WriteLine("Tomorrow is " + day + " /" + month + "/" + year);
                    }
                    else
                    {
                        day = 1;
                        month += 1;
                        Console.WriteLine("Tomorrow is " + day + " /" + month + "/" + year);
                    }
                }
                if (months.Contains(month))
                {
                    if (day <= 29)
                    {
                        day += 1;
                        Console.WriteLine("Tomorrow is " + day + " /" + month + "/" + year);
                    }

                    else
                    {
                        day = 1;
                        month += 1;
                        Console.WriteLine("Tomorrow is " + day + " /" + month + "/" + year);
                    }
                }
                if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
                {
                    if (day <= 28 && month == 2)
                    {
                        day += 1;
                        Console.WriteLine("Tomorrow is " + day + " /" + month + "/" + year);
                    }

                    else if (day == 29 && month == 2)
                    {
                        day = 1;
                        month += 1;
                        Console.WriteLine("Tomorrow is " + day + " /" + month + "/" + year);
                    }

                }
                else if (day <= 27 && month == 2)
                {
                    day += 1;
                    Console.WriteLine("Tomorrow is " + day + " /" + month + "/" + year);
                }

                else if (day <= 28 && month == 2)
                {
                    day = 1;
                    month += 1;
                    Console.WriteLine("Tomorrow is " + day + " /" + month + "/" + year);
                }
                goto xyz;

            }   }
    }
}
