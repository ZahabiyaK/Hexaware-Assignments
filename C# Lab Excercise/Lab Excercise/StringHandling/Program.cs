using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace StringHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program to search the word entered by user in the given string.
            string str = "Hello,Good Morning Everyone.I hope you all are good.Now let's start the session";

            Console.WriteLine("Enter a word: ");
            string word = Console.ReadLine();

            bool result = str.Contains(word);

            Console.WriteLine($"Check the word is present in string: {result}");


            //Write a program to split a given string using comma (,) operator in print each value on separate line. (val1, val2, val3)
            String str2 = "Zahabiya,Nidhi,Nimrit,Karan,Rahul";

            String [] names = str2.Split(',');

            foreach (String s in names)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }
    }
}
