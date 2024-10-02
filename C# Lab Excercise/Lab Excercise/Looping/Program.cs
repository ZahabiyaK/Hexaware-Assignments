using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Looping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //program to display numbers in reverse order from 50 to 1 using for Loop construct.

            Console.WriteLine("Reverse order: ");
            for(int i = 50; i >= 1; i--)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");

            //program to display odd numbers between 1 to 50 using do while Loop.

            Console.WriteLine("Display Odd numbers between 1 to 50: ");
            for (int i = 1; i <=50; i++)
            {
                if(i%2 != 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine("\n");


            //program to display even numbers between 1 to 50 using while loop.
            Console.WriteLine("Display even numbers between 1 to 50: ");

            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine("\n");

            //program to print table of given number using for loop.

            Console.WriteLine("Enter the value to print table: ");
            Int32 val = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Printing Table of {val}:");
            for (int i = 1; i <= 10; i++)
            {
                 Console.Write($"{val} x {i} = {val * i}" + "\n");
            }
            Console.WriteLine("\n");


            //program to find out even numbers from given array using for loop.

            int[] num = { 31, 20, 53, 10, 43, 99, 80, 72, 21, 52 };
            int count = 0;

            Console.WriteLine($"Total elements which are even: ");
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 == 0)
                {
                    Console.Write(num[i] + " ");
                    count++;
                }
            }

            Console.ReadKey();
        }
    }
}
