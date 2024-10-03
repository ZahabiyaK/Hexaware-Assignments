using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //program to accept day, month and year from user as input and construct new date.

            Console.WriteLine("Enter a day: ");
            int day = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter a month: ");
            int month = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter a year: ");
            int year = Int32.Parse(Console.ReadLine());


            DateTime date = new DateTime(year, month, day);


            Console.WriteLine($"Date is: {date.ToShortDateString()}");

            //program to accept 2 dates from user as string and calculate difference between dates in days.

            Console.WriteLine("Enter two dates: ");
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            DateTime date1 = Convert.ToDateTime(input1);
            DateTime date2 = Convert.ToDateTime(input2);

            string onlyDate1 = date1.ToShortDateString();
            string onlyDate2 = date2.ToShortDateString();


            Console.WriteLine($"Difference between dates in days:{(date1.Subtract(date2)).Days} ");

            Console.ReadKey();
        }
    }
}
