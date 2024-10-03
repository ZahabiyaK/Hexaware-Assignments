using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program to print a sum of single dim int array.

            Int32[] arr = { 10, 20, 50, 53, 52, 21, 72, 90};
            int sum = 0;

            Console.WriteLine("Array elements are: ");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ", ");
            }

            for (int j = 0; j < arr.Length; j++)
            {
                sum += arr[j];
            }
            Console.WriteLine($"\nSum of all array elements are: {sum}");

            //Write a program to display sum of diagonal elements(bold elements) of given array.

            Int32[,] MultiArr = {
                {10,20,30 },
                {40,50,60 },
                {70,80,90 }
            };

            Console.WriteLine("Sum of all diagonal elements: ");
            for (int i = 0; i < MultiArr.GetLength(0); i++)
            {
                
            }

            //Write a program to search element from jagged array.

            //Write a program to make sum of each row for multi dim array and print them.

            /* Write a program to collect list Product using Generic List< T > class and information of products. (Please follow below instructions to create Product class)

            a.declares a class with the name[Product].

            b.Create properties[ProductCode, ProductName, Category].

            c.Create List<Product> and add products in a list and print them on console. */
            Console.ReadKey();

            //Write a program to maintain country name and its mobile telephone prefixes using hashtable and print them together.
        }
    }
}
