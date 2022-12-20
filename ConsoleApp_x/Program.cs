using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_x
{
    internal class Program
    {
        static bool isPerfect(int number)
        {
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                    sum += i;
            }
            if (sum==number)
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            int x, y;
            Console.Write("enter the first number : ");
            x= int.Parse(Console.ReadLine());
            Console.Write("enter the second number : ");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");

            for (int i = x; i <=y; i++)
            {
                if (isPerfect(i))
                    Console.WriteLine("{0}", i);
            }
        }
    }
}
