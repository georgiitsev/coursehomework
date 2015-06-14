using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number ");
            int b = int.Parse(Console.ReadLine());

            int h = a % b;

            Console.WriteLine(h);
        }
    }
}
