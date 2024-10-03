using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Develop a program to decide whether number is negative or positive using if else.
            Console.WriteLine("Enter the number: ");
            int num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine($"{num} is Posistive");
            }
            else if (num < 0)
            {
                Console.WriteLine($"{num} is negative");
            }
            else if (num == 0)
            {
                Console.WriteLine($"{num} is zero");
            }
            else
            {
                Console.WriteLine("Not valid number");
            }

            //Develop a program to decide grade according by taking percentage as input from user using
            //If-else if-else. (70 > "A" | 60 > "B" | 50 > "C" | 40 > "D")

            Console.WriteLine("\nEnter your percentage value: ");
            int grade = int.Parse(Console.ReadLine());

            if (grade > 70)
            {
                Console.WriteLine("Your grade is: " + "A");
            }
            else if(grade > 60 && grade <= 70)
            {
                Console.WriteLine("Your grade is: " + "B");

            }
            else if (grade > 50 && grade <= 60)
            {
                Console.WriteLine("Your grade is: " + "C");
            }
            else if(grade > 40 && grade <= 50)
            {
                Console.WriteLine("Your grade is: " + "D");

            }
            else
            {
                Console.WriteLine("Fail");

            }

            //Develop a program to display name of day from taking input 1 - 7 using switch case. (1 - Monday | 2 - Tuesday | 3 - Wednesday)

            Console.WriteLine("\nEnter the value between 1 to 7: ");
            int val = int.Parse(Console.ReadLine());

            switch (val)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }

            //Develop a program to decide whether number is negative or positive using Ternary operator.

            Console.WriteLine("\nCheck number is positive or negative(using ternary operator): ");
            string result = (num > 0) ? "Number Is Positive" : "Number may be negative or zero";
            Console.WriteLine(result);

            Console.ReadKey();
            }
        }
}
